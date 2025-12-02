Public Class User
    Public Property UserId As Integer
    Public Property Username As String
    Public Property PasswordHash As String
    Public Property Role As String
    Public Property CreatedDate As DateTime
    Public Property IsActive As Boolean

    Public Sub New()
        Role = "User"
        CreatedDate = DateTime.Now
        IsActive = True
    End Sub
End Class
