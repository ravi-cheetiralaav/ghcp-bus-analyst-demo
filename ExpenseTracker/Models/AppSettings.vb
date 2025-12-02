Public Class AppSettings
    Public Property SettingId As Integer
    Public Property UserId As Integer
    Public Property DefaultCurrency As String
    Public Property Theme As String

    Public Sub New()
        DefaultCurrency = "USD"
        Theme = "Light"
    End Sub
End Class
