Imports BCrypt.Net
Imports System.Data
Imports System.Windows.Forms

Public Class AuthenticationService
    Private Shared _currentUser As User = Nothing

    Public Shared Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Private Set(value As User)
            _currentUser = value
        End Set
    End Property

    Public Shared Function Register(username As String, password As String) As Boolean
        Try
            ' Hash the password
            Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(password)

            ' Insert user into database
            Dim query As String = "INSERT INTO Users (Username, PasswordHash, CreatedDate) VALUES (@Username, @PasswordHash, @CreatedDate)"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Username", username},
                {"@PasswordHash", passwordHash},
                {"@CreatedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}
            }

            Dim result As Integer = DatabaseHelper.ExecuteNonQuery(query, parameters)

            If result > 0 Then
                ' Get the newly created user ID
                Dim userIdQuery As String = "SELECT last_insert_rowid()"
                Dim userId As Integer = Convert.ToInt32(DatabaseHelper.ExecuteScalar(userIdQuery, Nothing))

                ' Create default settings for the user
                Dim settingsQuery As String = "INSERT INTO Settings (UserId, DefaultCurrency, Theme) VALUES (@UserId, 'USD', 'Light')"
                Dim settingsParams As New Dictionary(Of String, Object) From {
                    {"@UserId", userId}
                }
                DatabaseHelper.ExecuteNonQuery(settingsQuery, settingsParams)

                Return True
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show($"Registration error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Login(username As String, password As String) As Boolean
        Try
            ' Retrieve user from database
            Dim query As String = "SELECT UserId, Username, PasswordHash, Role, CreatedDate, IsActive FROM Users WHERE Username = @Username AND IsActive = 1"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Username", username}
            }

            Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, parameters)

            If dt.Rows.Count = 0 Then
                Return False
            End If

            Dim row As DataRow = dt.Rows(0)
            Dim storedHash As String = row("PasswordHash").ToString()

            ' Verify password
            If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                ' Set current user
                CurrentUser = New User With {
                    .UserId = Convert.ToInt32(row("UserId")),
                    .Username = row("Username").ToString(),
                    .PasswordHash = storedHash,
                    .Role = row("Role").ToString(),
                    .CreatedDate = DateTime.Parse(row("CreatedDate").ToString()),
                    .IsActive = Convert.ToBoolean(row("IsActive"))
                }
                Return True
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Sub Logout()
        CurrentUser = Nothing
    End Sub

    Public Shared Function ChangePassword(userId As Integer, oldPassword As String, newPassword As String) As Boolean
        Try
            ' Verify old password
            Dim query As String = "SELECT PasswordHash FROM Users WHERE UserId = @UserId"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@UserId", userId}
            }

            Dim storedHash As String = DatabaseHelper.ExecuteScalar(query, parameters)?.ToString()

            If String.IsNullOrEmpty(storedHash) OrElse Not BCrypt.Net.BCrypt.Verify(oldPassword, storedHash) Then
                Return False
            End If

            ' Hash new password and update
            Dim newHash As String = BCrypt.Net.BCrypt.HashPassword(newPassword)
            Dim updateQuery As String = "UPDATE Users SET PasswordHash = @PasswordHash WHERE UserId = @UserId"
            Dim updateParams As New Dictionary(Of String, Object) From {
                {"@PasswordHash", newHash},
                {"@UserId", userId}
            }

            Return DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams) > 0
        Catch ex As Exception
            MessageBox.Show($"Password change error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function IsUsernameTaken(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Username", username}
        }
        Dim count As Integer = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters))
        Return count > 0
    End Function
End Class
