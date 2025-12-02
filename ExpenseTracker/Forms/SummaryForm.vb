Imports System.Windows.Forms
Imports System.Linq
Imports System.IO

Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply theme
        Try
            ThemeHelper.ApplyLightTheme(Me)
        Catch
        End Try
        
        ' Initialize date pickers
        dtpMonthYear.Value = DateTime.Now
        cboCalendarYear.SelectedItem = DateTime.Now.Year.ToString()
        LoadFinancialYears()
        
        ' Select first tab
        tabControl.SelectedIndex = 0
    End Sub

    Private Sub LoadFinancialYears()
        cboFY.Items.Clear()
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear - 5 To currentYear + 1
            cboFY.Items.Add($"FY {i}-{(i + 1).ToString().Substring(2)}")
        Next
        
        ' Select current FY
        Dim currentFY As String
        If DateTime.Now.Month >= 7 Then
            currentFY = $"FY {currentYear}-{(currentYear + 1).ToString().Substring(2)}"
        Else
            currentFY = $"FY {currentYear - 1}-{currentYear.ToString().Substring(2)}"
        End If
        cboFY.SelectedItem = currentFY
    End Sub

    Private Sub btnGenerateMonthly_Click(sender As Object, e As EventArgs) Handles btnGenerateMonthly.Click
        Dim startDate As New Date(dtpMonthYear.Value.Year, dtpMonthYear.Value.Month, 1)
        Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)
        
        GenerateSummary(startDate, endDate, dgvMonthly, $"Monthly Summary - {startDate:MMMM yyyy}")
    End Sub

    Private Sub btnGenerateCalendarYear_Click(sender As Object, e As EventArgs) Handles btnGenerateCalendarYear.Click
        Dim year As Integer = Integer.Parse(cboCalendarYear.SelectedItem.ToString())
        Dim startDate As New Date(year, 1, 1)
        Dim endDate As New Date(year, 12, 31)
        
        GenerateSummary(startDate, endDate, dgvCalendarYear, $"Calendar Year Summary - {year}")
    End Sub

    Private Sub btnGenerateFY_Click(sender As Object, e As EventArgs) Handles btnGenerateFY.Click
        ' Parse FY string (e.g., "FY 2024-25")
        Dim fyString As String = cboFY.SelectedItem.ToString()
        Dim startYear As Integer = Integer.Parse(fyString.Substring(3, 4))
        
        Dim startDate As New Date(startYear, 7, 1)
        Dim endDate As New Date(startYear + 1, 6, 30)
        
        GenerateSummary(startDate, endDate, dgvFY, $"Financial Year Summary - {fyString}")
    End Sub

    Private Sub GenerateSummary(startDate As Date, endDate As Date, dgv As DataGridView, title As String)
        Try
            ' Get all expenses with recurring instances
            Dim expenses As List(Of Expense) = ExpenseService.GetExpensesWithRecurring(
                AuthenticationService.CurrentUser.UserId,
                startDate,
                endDate
            )

            If expenses.Count = 0 Then
                MessageBox.Show("No expenses found for the selected period", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv.DataSource = Nothing
                Return
            End If

            ' Group by currency and category
            Dim summaryData As New List(Of SummaryRow)

            ' Total by currency
            Dim currencyGroups = expenses.GroupBy(Function(e) e.Currency)
            For Each currencyGroup In currencyGroups
                Dim currency As String = currencyGroup.Key
                Dim totalAmount As Decimal = currencyGroup.Sum(Function(e) e.Amount)
                Dim taxDeductible As Decimal = currencyGroup.Where(Function(e) e.IsTaxDeductible).Sum(Function(e) e.Amount)
                Dim recurringAmount As Decimal = currencyGroup.Where(Function(e) e.IsRecurring).Sum(Function(e) e.Amount)
                Dim nonRecurringAmount As Decimal = currencyGroup.Where(Function(e) Not e.IsRecurring).Sum(Function(e) e.Amount)

                summaryData.Add(New SummaryRow With {
                    .Category = $"TOTAL ({currency})",
                    .Currency = currency,
                    .TotalAmount = totalAmount,
                    .TaxDeductible = taxDeductible,
                    .RecurringAmount = recurringAmount,
                    .NonRecurringAmount = nonRecurringAmount,
                    .Count = currencyGroup.Count()
                })

                ' Category breakdown for this currency
                Dim categoryGroups = currencyGroup.GroupBy(Function(e) If(String.IsNullOrEmpty(e.CategoryName), "Uncategorized", e.CategoryName))
                For Each categoryGroup In categoryGroups
                    Dim category As String = categoryGroup.Key
                    Dim catTotalAmount As Decimal = categoryGroup.Sum(Function(e) e.Amount)
                    Dim catTaxDeductible As Decimal = categoryGroup.Where(Function(e) e.IsTaxDeductible).Sum(Function(e) e.Amount)
                    Dim catRecurringAmount As Decimal = categoryGroup.Where(Function(e) e.IsRecurring).Sum(Function(e) e.Amount)
                    Dim catNonRecurringAmount As Decimal = categoryGroup.Where(Function(e) Not e.IsRecurring).Sum(Function(e) e.Amount)

                    summaryData.Add(New SummaryRow With {
                        .Category = $"  {category}",
                        .Currency = currency,
                        .TotalAmount = catTotalAmount,
                        .TaxDeductible = catTaxDeductible,
                        .RecurringAmount = catRecurringAmount,
                        .NonRecurringAmount = catNonRecurringAmount,
                        .Count = categoryGroup.Count()
                    })
                Next
            Next

            ' Bind to grid
            dgv.DataSource = summaryData
            ConfigureDataGridView(dgv)

        Catch ex As Exception
            MessageBox.Show($"Error generating summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigureDataGridView(dgv As DataGridView)
        If dgv.Columns.Count > 0 Then
            dgv.Columns("Category").HeaderText = "Category"
            dgv.Columns("Category").Width = 200
            dgv.Columns("Currency").HeaderText = "Currency"
            dgv.Columns("Currency").Width = 80
            dgv.Columns("TotalAmount").HeaderText = "Total Amount"
            dgv.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
            dgv.Columns("TaxDeductible").HeaderText = "Tax Deductible"
            dgv.Columns("TaxDeductible").DefaultCellStyle.Format = "N2"
            dgv.Columns("RecurringAmount").HeaderText = "Recurring"
            dgv.Columns("RecurringAmount").DefaultCellStyle.Format = "N2"
            dgv.Columns("NonRecurringAmount").HeaderText = "Non-Recurring"
            dgv.Columns("NonRecurringAmount").DefaultCellStyle.Format = "N2"
            dgv.Columns("Count").HeaderText = "# of Expenses"

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv.ReadOnly = True
            dgv.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrintMonthly_Click(sender As Object, e As EventArgs) Handles btnPrintMonthly.Click
        PrintHelper.PrintDataGridView(dgvMonthly, $"Monthly Summary - {dtpMonthYear.Value:MMMM yyyy}")
    End Sub

    Private Sub btnPrintCalendarYear_Click(sender As Object, e As EventArgs) Handles btnPrintCalendarYear.Click
        PrintHelper.PrintDataGridView(dgvCalendarYear, $"Calendar Year Summary - {cboCalendarYear.SelectedItem}")
    End Sub

    Private Sub btnPrintFY_Click(sender As Object, e As EventArgs) Handles btnPrintFY.Click
        PrintHelper.PrintDataGridView(dgvFY, $"Financial Year Summary - {cboFY.SelectedItem}")
    End Sub

    ' Helper class for summary rows
    Private Class SummaryRow
        Public Property Category As String
        Public Property Currency As String
        Public Property TotalAmount As Decimal
        Public Property TaxDeductible As Decimal
        Public Property RecurringAmount As Decimal
        Public Property NonRecurringAmount As Decimal
        Public Property Count As Integer
    End Class
End Class
