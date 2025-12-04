Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.grpPreferences = New System.Windows.Forms.GroupBox()
        Me.cboDefaultCurrency = New System.Windows.Forms.ComboBox()
        Me.lblDefaultCurrency = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpPassword.SuspendLayout()
        Me.grpPreferences.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.lblPasswordError)
        Me.grpPassword.Controls.Add(Me.btnChangePassword)
        Me.grpPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpPassword.Controls.Add(Me.lblConfirmPassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.lblNewPassword)
        Me.grpPassword.Controls.Add(Me.txtOldPassword)
        Me.grpPassword.Controls.Add(Me.lblOldPassword)
        Me.grpPassword.Location = New System.Drawing.Point(20, 20)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(460, 220)
        Me.grpPassword.TabIndex = 0
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "Change Password"
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordError.Location = New System.Drawing.Point(20, 150)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(0, 15)
        Me.lblPasswordError.TabIndex = 7
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(20, 175)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(150, 30)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(180, 115)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(250, 23)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(20, 118)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(107, 15)
        Me.lblConfirmPassword.TabIndex = 4
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(180, 75)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(250, 23)
        Me.txtNewPassword.TabIndex = 3
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(20, 78)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(87, 15)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "New Password:"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(180, 35)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(250, 23)
        Me.txtOldPassword.TabIndex = 1
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(20, 38)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(99, 15)
        Me.lblOldPassword.TabIndex = 0
        Me.lblOldPassword.Text = "Current Password:"
        '
        'grpPreferences
        '
        Me.grpPreferences.Controls.Add(Me.cboDefaultCurrency)
        Me.grpPreferences.Controls.Add(Me.lblDefaultCurrency)
        Me.grpPreferences.Location = New System.Drawing.Point(20, 260)
        Me.grpPreferences.Name = "grpPreferences"
        Me.grpPreferences.Size = New System.Drawing.Size(460, 100)
        Me.grpPreferences.TabIndex = 1
        Me.grpPreferences.TabStop = False
        Me.grpPreferences.Text = "Preferences"
        '
        'cboDefaultCurrency
        '
        Me.cboDefaultCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDefaultCurrency.FormattingEnabled = True
        Me.cboDefaultCurrency.Location = New System.Drawing.Point(180, 40)
        Me.cboDefaultCurrency.Name = "cboDefaultCurrency"
        Me.cboDefaultCurrency.Size = New System.Drawing.Size(150, 23)
        Me.cboDefaultCurrency.TabIndex = 1
        '
        'lblDefaultCurrency
        '
        Me.lblDefaultCurrency.AutoSize = True
        Me.lblDefaultCurrency.Location = New System.Drawing.Point(20, 43)
        Me.lblDefaultCurrency.Name = "lblDefaultCurrency"
        Me.lblDefaultCurrency.Size = New System.Drawing.Size(101, 15)
        Me.lblDefaultCurrency.TabIndex = 0
        Me.lblDefaultCurrency.Text = "Default Currency:"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(165, 380)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(120, 35)
        Me.btnSaveSettings.TabIndex = 2
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(300, 380)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 430)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.grpPreferences)
        Me.Controls.Add(Me.grpPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.grpPreferences.ResumeLayout(False)
        Me.grpPreferences.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPassword As GroupBox
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents lblOldPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents grpPreferences As GroupBox
    Friend WithEvents cboDefaultCurrency As ComboBox
    Friend WithEvents lblDefaultCurrency As Label
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnCancel As Button
End Class
