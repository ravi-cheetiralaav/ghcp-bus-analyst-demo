Imports System.Windows.Forms

Public Class ExpenseForm
    Private _expenseId As Integer = 0
    Private _isEditMode As Boolean = False

    Public Sub New()
        InitializeComponent()
        _isEditMode = False
    End Sub

    Public Sub New(expenseId As Integer)
        InitializeComponent()
        _expenseId = expenseId
        _isEditMode = True
    End Sub

    Private Sub ExpenseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadCurrencies()
        LoadFrequencies()

        If _isEditMode Then
            Me.Text = "Edit Expense"
            LoadExpense()
        Else
            Me.Text = "Add Expense"
            dtpExpenseDate.Value = DateTime.Now

            ' Load user's default currency
            Dim settings As AppSettings = SettingsService.GetUserSettings(AuthenticationService.CurrentUser.UserId)
            Dim currencyIndex As Integer = cboCurrency.Items.IndexOf(settings.DefaultCurrency)
            If currencyIndex >= 0 Then
                cboCurrency.SelectedIndex = currencyIndex
            Else
                cboCurrency.SelectedIndex = 0
            End If
        End If

        UpdateRecurringFields()
    End Sub

    Private Sub LoadCategories()
        Dim categories As List(Of Category) = CategoryService.GetAllCategories()
        cboCategory.Items.Clear()
        cboCategory.Items.Add(New With {.CategoryId = 0, .CategoryName = "-- Select Category --"})

        For Each category In categories
            cboCategory.Items.Add(category)
        Next

        cboCategory.DisplayMember = "CategoryName"
        cboCategory.ValueMember = "CategoryId"
        cboCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadCurrencies()
        cboCurrency.Items.Clear()
        cboCurrency.Items.AddRange(New String() {"USD", "EUR", "GBP", "AUD", "CAD", "INR", "JPY", "CNY"})
        cboCurrency.SelectedIndex = 0
    End Sub

    Private Sub LoadFrequencies()
        cboFrequency.Items.Clear()
        cboFrequency.Items.AddRange(New String() {"Weekly", "Fortnightly", "Monthly", "Quarterly", "Annually"})
        cboFrequency.SelectedIndex = 2 ' Default to Monthly
    End Sub

    Private Sub LoadExpense()
        Dim expense As Expense = ExpenseService.GetExpenseById(_expenseId)
        If expense IsNot Nothing Then
            txtDescription.Text = expense.Description
            txtAmount.Text = expense.Amount.ToString("F2")
            
            Dim currencyIndex As Integer = cboCurrency.Items.IndexOf(expense.Currency)
            If currencyIndex >= 0 Then
                cboCurrency.SelectedIndex = currencyIndex
            End If

            dtpExpenseDate.Value = expense.ExpenseDate
            chkTaxDeductible.Checked = expense.IsTaxDeductible
            chkRecurring.Checked = expense.IsRecurring

            ' Set category
            For i As Integer = 0 To cboCategory.Items.Count - 1
                Dim item = cboCategory.Items(i)
                If TypeOf item Is Category Then
                    Dim cat As Category = DirectCast(item, Category)
                    If cat.CategoryId = expense.CategoryId Then
                        cboCategory.SelectedIndex = i
                        Exit For
                    End If
                End If
            Next

            If expense.IsRecurring AndAlso Not String.IsNullOrEmpty(expense.RecurringFrequency) Then
                Dim freqIndex As Integer = cboFrequency.Items.IndexOf(expense.RecurringFrequency)
                If freqIndex >= 0 Then
                    cboFrequency.SelectedIndex = freqIndex
                End If
            End If
        End If
    End Sub

    Private Sub chkRecurring_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecurring.CheckedChanged
        UpdateRecurringFields()
    End Sub

    Private Sub UpdateRecurringFields()
        lblFrequency.Enabled = chkRecurring.Checked
        cboFrequency.Enabled = chkRecurring.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            MessageBox.Show("Please enter a description", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescription.Focus()
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid amount greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If

        If cboCategory.SelectedIndex = 0 Then
            MessageBox.Show("Please select a category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboCategory.Focus()
            Return
        End If

        If chkRecurring.Checked AndAlso cboFrequency.SelectedIndex < 0 Then
            MessageBox.Show("Please select a recurring frequency", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboFrequency.Focus()
            Return
        End If

        ' Create expense object
        Dim expense As New Expense With {
            .UserId = AuthenticationService.CurrentUser.UserId,
            .Description = txtDescription.Text.Trim(),
            .Amount = amount,
            .Currency = cboCurrency.SelectedItem.ToString(),
            .CategoryId = DirectCast(cboCategory.SelectedItem, Category).CategoryId,
            .ExpenseDate = dtpExpenseDate.Value.Date,
            .IsTaxDeductible = chkTaxDeductible.Checked,
            .IsRecurring = chkRecurring.Checked,
            .RecurringFrequency = If(chkRecurring.Checked, cboFrequency.SelectedItem.ToString(), Nothing)
        }

        Dim success As Boolean
        If _isEditMode Then
            expense.ExpenseId = _expenseId
            success = ExpenseService.UpdateExpense(expense)
        Else
            success = ExpenseService.AddExpense(expense)
        End If

        If success Then
            MessageBox.Show($"Expense {If(_isEditMode, "updated", "added")} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        ' Allow only numbers, decimal point, and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso txtAmount.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class
