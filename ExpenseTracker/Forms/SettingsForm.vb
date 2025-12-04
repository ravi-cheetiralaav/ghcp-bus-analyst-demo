Imports System.Windows.Forms

Public Class SettingsForm
    Private _currentSettings As AppSettings

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrencies()
        LoadSettings()
    End Sub

    Private Sub LoadCurrencies()
        cboDefaultCurrency.Items.Clear()
        cboDefaultCurrency.Items.AddRange(New String() {"USD", "EUR", "GBP", "AUD", "CAD", "INR", "JPY", "CNY"})
    End Sub

    Private Sub LoadSettings()
        _currentSettings = SettingsService.GetUserSettings(AuthenticationService.CurrentUser.UserId)
        
        Dim currencyIndex As Integer = cboDefaultCurrency.Items.IndexOf(_currentSettings.DefaultCurrency)
        If currencyIndex >= 0 Then
            cboDefaultCurrency.SelectedIndex = currencyIndex
        Else
            cboDefaultCurrency.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        lblPasswordError.Text = ""

        ' Validate input
        If String.IsNullOrWhiteSpace(txtOldPassword.Text) Then
            lblPasswordError.Text = "Please enter current password"
            txtOldPassword.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            lblPasswordError.Text = "Please enter new password"
            txtNewPassword.Focus()
            Return
        End If

        If txtNewPassword.Text.Length < 6 Then
            lblPasswordError.Text = "New password must be at least 6 characters"
            txtNewPassword.Focus()
            Return
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            lblPasswordError.Text = "Passwords do not match"
            txtConfirmPassword.Focus()
            Return
        End If

        If txtOldPassword.Text = txtNewPassword.Text Then
            lblPasswordError.Text = "New password must be different from current password"
            txtNewPassword.Focus()
            Return
        End If

        ' Attempt password change
        If AuthenticationService.ChangePassword(
            AuthenticationService.CurrentUser.UserId,
            txtOldPassword.Text,
            txtNewPassword.Text
        ) Then
            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOldPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            lblPasswordError.Text = ""
        Else
            lblPasswordError.Text = "Current password is incorrect"
            txtOldPassword.Focus()
        End If
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        _currentSettings.DefaultCurrency = cboDefaultCurrency.SelectedItem.ToString()
        
        If SettingsService.UpdateSettings(_currentSettings) Then
            MessageBox.Show("Settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
