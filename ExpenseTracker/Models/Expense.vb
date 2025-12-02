Public Class Expense
    Public Property ExpenseId As Integer
    Public Property UserId As Integer
    Public Property Description As String
    Public Property Amount As Decimal
    Public Property Currency As String
    Public Property CategoryId As Integer
    Public Property CategoryName As String
    Public Property ExpenseDate As DateTime
    Public Property IsTaxDeductible As Boolean
    Public Property IsRecurring As Boolean
    Public Property RecurringFrequency As String
    Public Property CreatedDate As DateTime
    Public Property ModifiedDate As DateTime?

    Public Sub New()
        ExpenseDate = DateTime.Now
        CreatedDate = DateTime.Now
        Currency = "USD"
        IsTaxDeductible = False
        IsRecurring = False
    End Sub
End Class
