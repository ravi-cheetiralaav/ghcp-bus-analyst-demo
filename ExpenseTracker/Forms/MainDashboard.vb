Imports System.Windows.Forms
Imports System.Linq
Imports System.IO
Imports System.Drawing

Public Class MainDashboard
    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set welcome message
        lblWelcome.Text = $"Welcome, {AuthenticationService.CurrentUser.Username}!"
        ' Apply simple theme
        Try
            ThemeHelper.ApplyLightTheme(Me)
        Catch
        End Try

        ' Load logo if exists
        Try
            ' Try multiple paths to find logo
            Dim logoPath As String = Nothing
            Dim basePaths As String() = {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "logo.png"),
                Path.Combine(Directory.GetCurrentDirectory(), "ExpenseTracker", "Assets", "logo.png"),
                Path.Combine(Directory.GetCurrentDirectory(), "Assets", "logo.png")
            }
            
            For Each testPath In basePaths
                If File.Exists(testPath) Then
                    logoPath = testPath
                    Exit For
                End If
            Next
            
            If logoPath IsNot Nothing Then
                picLogo.Image = Image.FromFile(logoPath)
                picLogo.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Catch ex As Exception
            ' Logo loading failed, continue without it
        End Try

        ' Load categories
        LoadCategories()

        ' Load currencies
        LoadCurrencies()

        ' Initialize date filters
        dtpFrom.Value = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpTo.Value = DateTime.Now

        ' Load expenses
        LoadExpenses()
    End Sub

    Private Sub LoadCategories()
        Dim categories As List(Of Category) = CategoryService.GetAllCategories()
        cboCategory.Items.Clear()
        cboCategory.Items.Add(New With {.CategoryId = 0, .CategoryName = "All Categories"})

        For Each category In categories
            cboCategory.Items.Add(category)
        Next

        cboCategory.DisplayMember = "CategoryName"
        cboCategory.ValueMember = "CategoryId"
        cboCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadCurrencies()
        cboCurrency.Items.Clear()
        cboCurrency.Items.AddRange(New String() {"All", "USD", "EUR", "GBP", "AUD", "CAD", "INR", "JPY", "CNY"})
        cboCurrency.SelectedIndex = 0
    End Sub

    Private Sub LoadExpenses()
        Try
            Dim expenses As List(Of Expense)

            If chkShowRecurring.Checked Then
                ' Load expenses with recurring instances
                expenses = ExpenseService.GetExpensesWithRecurring(
                    AuthenticationService.CurrentUser.UserId,
                    dtpFrom.Value.Date,
                    dtpTo.Value.Date
                )
            Else
                ' Load regular expenses with filters
                Dim currency As String = If(cboCurrency.SelectedIndex = 0, Nothing, cboCurrency.SelectedItem.ToString())
                Dim categoryId As Integer? = If(cboCategory.SelectedIndex = 0, Nothing, DirectCast(cboCategory.SelectedItem, Category).CategoryId)
                Dim isTaxDeductible As Boolean? = If(chkTaxDeductible.CheckState = CheckState.Indeterminate, Nothing, chkTaxDeductible.Checked)
                Dim isRecurring As Boolean? = If(chkRecurring.CheckState = CheckState.Indeterminate, Nothing, chkRecurring.Checked)

                expenses = ExpenseService.SearchExpenses(
                    AuthenticationService.CurrentUser.UserId,
                    dtpFrom.Value.Date,
                    dtpTo.Value.Date,
                    currency,
                    categoryId,
                    isTaxDeductible,
                    isRecurring,
                    txtSearch.Text.Trim()
                )
            End If

            ' Bind to DataGridView
            dgvExpenses.DataSource = Nothing
            dgvExpenses.DataSource = expenses
            ConfigureDataGridView()

            ' Update statistics
            UpdateStatistics(expenses)
        Catch ex As Exception
            MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigureDataGridView()
        If dgvExpenses.Columns.Count > 0 Then
            dgvExpenses.Columns("ExpenseId").Visible = False
            dgvExpenses.Columns("UserId").Visible = False
            dgvExpenses.Columns("CategoryId").Visible = False
            dgvExpenses.Columns("CreatedDate").Visible = False
            dgvExpenses.Columns("ModifiedDate").Visible = False

            dgvExpenses.Columns("Description").HeaderText = "Description"
            dgvExpenses.Columns("Description").Width = 200
            dgvExpenses.Columns("Amount").HeaderText = "Amount"
            dgvExpenses.Columns("Amount").DefaultCellStyle.Format = "N2"
            dgvExpenses.Columns("Currency").HeaderText = "Currency"
            dgvExpenses.Columns("CategoryName").HeaderText = "Category"
            dgvExpenses.Columns("ExpenseDate").HeaderText = "Date"
            dgvExpenses.Columns("ExpenseDate").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvExpenses.Columns("IsTaxDeductible").HeaderText = "Tax Deductible"
            dgvExpenses.Columns("IsRecurring").HeaderText = "Recurring"
            dgvExpenses.Columns("RecurringFrequency").HeaderText = "Frequency"

            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvExpenses.MultiSelect = False
            dgvExpenses.ReadOnly = True
        End If
    End Sub

    Private Sub UpdateStatistics(expenses As List(Of Expense))
        Dim totalExpenses As Integer = expenses.Count
        Dim totalAmount As Decimal = expenses.Sum(Function(e) e.Amount)
        Dim taxDeductibleAmount As Decimal = expenses.Where(Function(e) e.IsTaxDeductible).Sum(Function(e) e.Amount)

        lblTotalExpenses.Text = $"Total Expenses: {totalExpenses}"
        lblTotalAmount.Text = $"Total Amount: ${totalAmount:N2}"
        lblTaxDeductible.Text = $"Tax Deductible: ${taxDeductibleAmount:N2}"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim expenseForm As New ExpenseForm()
        If expenseForm.ShowDialog() = DialogResult.OK Then
            LoadExpenses()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an expense to edit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedExpense As Expense = DirectCast(dgvExpenses.SelectedRows(0).DataBoundItem, Expense)
        Dim expenseForm As New ExpenseForm(selectedExpense.ExpenseId)
        If expenseForm.ShowDialog() = DialogResult.OK Then
            LoadExpenses()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an expense to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedExpense As Expense = DirectCast(dgvExpenses.SelectedRows(0).DataBoundItem, Expense)
        Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete this expense: {selectedExpense.Description}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            If ExpenseService.DeleteExpense(selectedExpense.ExpenseId) Then
                MessageBox.Show("Expense deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadExpenses()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadExpenses()
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        txtSearch.Clear()
        cboCategory.SelectedIndex = 0
        cboCurrency.SelectedIndex = 0
        chkTaxDeductible.CheckState = CheckState.Indeterminate
        chkRecurring.CheckState = CheckState.Indeterminate
        chkShowRecurring.Checked = False
        dtpFrom.Value = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpTo.Value = DateTime.Now
        LoadExpenses()
    End Sub

    Private Sub btnSummaries_Click(sender As Object, e As EventArgs) Handles btnSummaries.Click
        Dim summaryForm As New SummaryForm()
        summaryForm.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settingsForm As New SettingsForm()
        If settingsForm.ShowDialog() = DialogResult.OK Then
            ' Reload if needed
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            AuthenticationService.Logout()
            Me.Close()
        End If
    End Sub

    Private Sub dgvExpenses_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpenses.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnEdit.PerformClick()
        End If
    End Sub
End Class
