Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Try to load logo image similar to MainDashboard
        Try
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
            End If
        Catch
        End Try
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Text = ""

        ' Validate input
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            lblError.Text = "Please enter username"
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblError.Text = "Please enter password"
            txtPassword.Focus()
            Return
        End If

        ' Attempt login
        If AuthenticationService.Login(txtUsername.Text.Trim(), txtPassword.Text) Then
            ' Login successful, open main dashboard
            Dim dashboard As New MainDashboard()
            Me.Hide()
            dashboard.ShowDialog()
            Me.Close()
        Else
            lblError.Text = "Invalid username or password"
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registerForm As New RegisterForm()
        Me.Hide()
        If registerForm.ShowDialog() = DialogResult.OK Then
            ' User registered successfully, show login form again
            Me.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnLogin.PerformClick()
        End If
    End Sub
End Class
