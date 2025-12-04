Imports System.Data
Imports System.Windows.Forms

Public Class SettingsService
    Public Shared Function GetUserSettings(userId As Integer) As AppSettings
        Dim query As String = "SELECT SettingId, UserId, DefaultCurrency, Theme FROM Settings WHERE UserId = @UserId"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@UserId", userId}
        }

        Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            Return New AppSettings With {
                .SettingId = Convert.ToInt32(row("SettingId")),
                .UserId = Convert.ToInt32(row("UserId")),
                .DefaultCurrency = row("DefaultCurrency").ToString(),
                .Theme = row("Theme").ToString()
            }
        End If

        Return New AppSettings With {.UserId = userId}
    End Function

    Public Shared Function UpdateSettings(settings As AppSettings) As Boolean
        Try
            Dim query As String = "UPDATE Settings SET DefaultCurrency = @DefaultCurrency, Theme = @Theme WHERE UserId = @UserId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@DefaultCurrency", settings.DefaultCurrency},
                {"@Theme", settings.Theme},
                {"@UserId", settings.UserId}
            }
            Return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0
        Catch ex As Exception
            MessageBox.Show($"Error updating settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
