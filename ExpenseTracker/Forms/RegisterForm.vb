Imports System.Windows.Forms

Public Class RegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lblError.Text = ""

        ' Validate input
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            lblError.Text = "Please enter username"
            txtUsername.Focus()
            Return
        End If

        If txtUsername.Text.Trim().Length < 3 Then
            lblError.Text = "Username must be at least 3 characters"
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblError.Text = "Please enter password"
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text.Length < 6 Then
            lblError.Text = "Password must be at least 6 characters"
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            lblError.Text = "Passwords do not match"
            txtConfirmPassword.Focus()
            Return
        End If

        ' Check if username already exists
        If AuthenticationService.IsUsernameTaken(txtUsername.Text.Trim()) Then
            lblError.Text = "Username already exists"
            txtUsername.Focus()
            Return
        End If

        ' Attempt registration
        If AuthenticationService.Register(txtUsername.Text.Trim(), txtPassword.Text) Then
            MessageBox.Show("Registration successful! Please login with your credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            lblError.Text = "Registration failed. Please try again."
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
