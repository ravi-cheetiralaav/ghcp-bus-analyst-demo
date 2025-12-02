Imports System.Windows.Forms

Public Class LoginForm
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
