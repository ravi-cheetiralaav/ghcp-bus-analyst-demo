Imports System.Data
Imports System.Windows.Forms

Public Class ExpenseService
    Public Shared Function GetAllExpenses(userId As Integer) As List(Of Expense)
        Dim expenses As New List(Of Expense)
        Dim query As String = "SELECT e.*, c.CategoryName FROM Expenses e 
                               LEFT JOIN Categories c ON e.CategoryId = c.CategoryId 
                               WHERE e.UserId = @UserId 
                               ORDER BY e.ExpenseDate DESC"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", userId}
        }

        Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, parameters)

        For Each row As DataRow In dt.Rows
            expenses.Add(MapRowToExpense(row))
        Next

        Return expenses
    End Function

    Public Shared Function AddExpense(expense As Expense) As Boolean
        Try
            Dim query As String = "INSERT INTO Expenses (UserId, Description, Amount, Currency, CategoryId, ExpenseDate, 
                                   IsTaxDeductible, IsRecurring, RecurringFrequency, CreatedDate) 
                                   VALUES (@UserId, @Description, @Amount, @Currency, @CategoryId, @ExpenseDate, 
                                   @IsTaxDeductible, @IsRecurring, @RecurringFrequency, @CreatedDate)"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@UserId", expense.UserId},
                {"@Description", expense.Description},
                {"@Amount", expense.Amount},
                {"@Currency", expense.Currency},
                {"@CategoryId", If(expense.CategoryId > 0, expense.CategoryId, DBNull.Value)},
                {"@ExpenseDate", expense.ExpenseDate.ToString("yyyy-MM-dd")},
                {"@IsTaxDeductible", If(expense.IsTaxDeductible, 1, 0)},
                {"@IsRecurring", If(expense.IsRecurring, 1, 0)},
                {"@RecurringFrequency", If(expense.IsRecurring, expense.RecurringFrequency, DBNull.Value)},
                {"@CreatedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}
            }

            Return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0
        Catch ex As Exception
            MessageBox.Show($"Error adding expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function UpdateExpense(expense As Expense) As Boolean
        Try
            Dim query As String = "UPDATE Expenses SET Description = @Description, Amount = @Amount, 
                                   Currency = @Currency, CategoryId = @CategoryId, ExpenseDate = @ExpenseDate, 
                                   IsTaxDeductible = @IsTaxDeductible, IsRecurring = @IsRecurring, 
                                   RecurringFrequency = @RecurringFrequency, ModifiedDate = @ModifiedDate 
                                   WHERE ExpenseId = @ExpenseId"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@ExpenseId", expense.ExpenseId},
                {"@Description", expense.Description},
                {"@Amount", expense.Amount},
                {"@Currency", expense.Currency},
                {"@CategoryId", If(expense.CategoryId > 0, expense.CategoryId, DBNull.Value)},
                {"@ExpenseDate", expense.ExpenseDate.ToString("yyyy-MM-dd")},
                {"@IsTaxDeductible", If(expense.IsTaxDeductible, 1, 0)},
                {"@IsRecurring", If(expense.IsRecurring, 1, 0)},
                {"@RecurringFrequency", If(expense.IsRecurring, expense.RecurringFrequency, DBNull.Value)},
                {"@ModifiedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}
            }

            Return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0
        Catch ex As Exception
            MessageBox.Show($"Error updating expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function DeleteExpense(expenseId As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Expenses WHERE ExpenseId = @ExpenseId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@ExpenseId", expenseId}
            }
            Return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0
        Catch ex As Exception
            MessageBox.Show($"Error deleting expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function GetExpenseById(expenseId As Integer) As Expense
        Dim query As String = "SELECT e.*, c.CategoryName FROM Expenses e 
                               LEFT JOIN Categories c ON e.CategoryId = c.CategoryId 
                               WHERE e.ExpenseId = @ExpenseId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@ExpenseId", expenseId}
        }

        Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, parameters)
        If dt.Rows.Count > 0 Then
            Return MapRowToExpense(dt.Rows(0))
        End If
        Return Nothing
    End Function

    Public Shared Function SearchExpenses(userId As Integer, dateFrom As Date?, dateTo As Date?, 
                                          currency As String, categoryId As Integer?, 
                                          isTaxDeductible As Boolean?, isRecurring As Boolean?, 
                                          keyword As String) As List(Of Expense)
        Dim expenses As New List(Of Expense)
        Dim query As String = "SELECT e.*, c.CategoryName FROM Expenses e 
                               LEFT JOIN Categories c ON e.CategoryId = c.CategoryId 
                               WHERE e.UserId = @UserId"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", userId}
        }

        If dateFrom.HasValue Then
            query &= " AND e.ExpenseDate >= @DateFrom"
            parameters.Add("@DateFrom", dateFrom.Value.ToString("yyyy-MM-dd"))
        End If

        If dateTo.HasValue Then
            query &= " AND e.ExpenseDate <= @DateTo"
            parameters.Add("@DateTo", dateTo.Value.ToString("yyyy-MM-dd"))
        End If

        If Not String.IsNullOrEmpty(currency) Then
            query &= " AND e.Currency = @Currency"
            parameters.Add("@Currency", currency)
        End If

        If categoryId.HasValue AndAlso categoryId.Value > 0 Then
            query &= " AND e.CategoryId = @CategoryId"
            parameters.Add("@CategoryId", categoryId.Value)
        End If

        If isTaxDeductible.HasValue Then
            query &= " AND e.IsTaxDeductible = @IsTaxDeductible"
            parameters.Add("@IsTaxDeductible", If(isTaxDeductible.Value, 1, 0))
        End If

        If isRecurring.HasValue Then
            query &= " AND e.IsRecurring = @IsRecurring"
            parameters.Add("@IsRecurring", If(isRecurring.Value, 1, 0))
        End If

        If Not String.IsNullOrEmpty(keyword) Then
            query &= " AND e.Description LIKE @Keyword"
            parameters.Add("@Keyword", $"%{keyword}%")
        End If

        query &= " ORDER BY e.ExpenseDate DESC"

        Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, parameters)
        For Each row As DataRow In dt.Rows
            expenses.Add(MapRowToExpense(row))
        Next

        Return expenses
    End Function

    ' Calculate recurring expense instances within a date range
    Public Shared Function GetRecurringExpenseInstances(expense As Expense, startDate As Date, endDate As Date) As List(Of Expense)
        Dim instances As New List(Of Expense)

        If Not expense.IsRecurring OrElse String.IsNullOrEmpty(expense.RecurringFrequency) Then
            Return instances
        End If

        Dim currentDate As Date = expense.ExpenseDate
        While currentDate <= endDate
            If currentDate >= startDate Then
                Dim instance As New Expense With {
                    .ExpenseId = expense.ExpenseId,
                    .UserId = expense.UserId,
                    .Description = expense.Description,
                    .Amount = expense.Amount,
                    .Currency = expense.Currency,
                    .CategoryId = expense.CategoryId,
                    .CategoryName = expense.CategoryName,
                    .ExpenseDate = currentDate,
                    .IsTaxDeductible = expense.IsTaxDeductible,
                    .IsRecurring = True,
                    .RecurringFrequency = expense.RecurringFrequency
                }
                instances.Add(instance)
            End If

            ' Move to next occurrence
            Select Case expense.RecurringFrequency.ToLower()
                Case "weekly"
                    currentDate = currentDate.AddDays(7)
                Case "fortnightly"
                    currentDate = currentDate.AddDays(14)
                Case "monthly"
                    currentDate = currentDate.AddMonths(1)
                Case "quarterly"
                    currentDate = currentDate.AddMonths(3)
                Case "annually"
                    currentDate = currentDate.AddYears(1)
                Case Else
                    Exit While
            End Select
        End While

        Return instances
    End Function

    ' Get all expenses including recurring instances for a date range
    Public Shared Function GetExpensesWithRecurring(userId As Integer, startDate As Date, endDate As Date) As List(Of Expense)
        Dim allExpenses As New List(Of Expense)

        ' Get all expenses for the user
        Dim expenses As List(Of Expense) = GetAllExpenses(userId)

        For Each expense In expenses
            If expense.IsRecurring Then
                ' Add recurring instances
                allExpenses.AddRange(GetRecurringExpenseInstances(expense, startDate, endDate))
            Else
                ' Add non-recurring expense if within date range
                If expense.ExpenseDate >= startDate AndAlso expense.ExpenseDate <= endDate Then
                    allExpenses.Add(expense)
                End If
            End If
        Next

        Return allExpenses.OrderByDescending(Function(e) e.ExpenseDate).ToList()
    End Function

    Private Shared Function MapRowToExpense(row As DataRow) As Expense
        Return New Expense With {
            .ExpenseId = Convert.ToInt32(row("ExpenseId")),
            .UserId = Convert.ToInt32(row("UserId")),
            .Description = row("Description").ToString(),
            .Amount = Convert.ToDecimal(row("Amount")),
            .Currency = row("Currency").ToString(),
            .CategoryId = If(IsDBNull(row("CategoryId")), 0, Convert.ToInt32(row("CategoryId"))),
            .CategoryName = If(IsDBNull(row("CategoryName")), "", row("CategoryName").ToString()),
            .ExpenseDate = DateTime.Parse(row("ExpenseDate").ToString()),
            .IsTaxDeductible = Convert.ToBoolean(row("IsTaxDeductible")),
            .IsRecurring = Convert.ToBoolean(row("IsRecurring")),
            .RecurringFrequency = If(IsDBNull(row("RecurringFrequency")), "", row("RecurringFrequency").ToString()),
            .CreatedDate = DateTime.Parse(row("CreatedDate").ToString()),
            .ModifiedDate = If(IsDBNull(row("ModifiedDate")), Nothing, DateTime.Parse(row("ModifiedDate").ToString()))
        }
    End Function
End Class
