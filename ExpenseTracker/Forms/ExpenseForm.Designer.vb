Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpenseForm
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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpExpenseDate = New System.Windows.Forms.DateTimePicker()
        Me.chkTaxDeductible = New System.Windows.Forms.CheckBox()
        Me.chkRecurring = New System.Windows.Forms.CheckBox()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.cboFrequency = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(30, 30)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(70, 15)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(30, 50)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(420, 60)
        Me.txtDescription.TabIndex = 1
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(30, 130)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(54, 15)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(30, 150)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(150, 23)
        Me.txtAmount.TabIndex = 3
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Location = New System.Drawing.Point(210, 130)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(58, 15)
        Me.lblCurrency.TabIndex = 4
        Me.lblCurrency.Text = "Currency:"
        '
        'cboCurrency
        '
        Me.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.Location = New System.Drawing.Point(210, 150)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(100, 23)
        Me.cboCurrency.TabIndex = 5
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(30, 190)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(58, 15)
        Me.lblCategory.TabIndex = 6
        Me.lblCategory.Text = "Category:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(30, 210)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(200, 23)
        Me.cboCategory.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(250, 190)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 15)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'dtpExpenseDate
        '
        Me.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpenseDate.Location = New System.Drawing.Point(250, 210)
        Me.dtpExpenseDate.Name = "dtpExpenseDate"
        Me.dtpExpenseDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpExpenseDate.TabIndex = 9
        '
        'chkTaxDeductible
        '
        Me.chkTaxDeductible.AutoSize = True
        Me.chkTaxDeductible.Location = New System.Drawing.Point(30, 260)
        Me.chkTaxDeductible.Name = "chkTaxDeductible"
        Me.chkTaxDeductible.Size = New System.Drawing.Size(104, 19)
        Me.chkTaxDeductible.TabIndex = 10
        Me.chkTaxDeductible.Text = "Tax Deductible"
        Me.chkTaxDeductible.UseVisualStyleBackColor = True
        '
        'chkRecurring
        '
        Me.chkRecurring.AutoSize = True
        Me.chkRecurring.Location = New System.Drawing.Point(30, 295)
        Me.chkRecurring.Name = "chkRecurring"
        Me.chkRecurring.Size = New System.Drawing.Size(122, 19)
        Me.chkRecurring.TabIndex = 11
        Me.chkRecurring.Text = "Recurring Expense"
        Me.chkRecurring.UseVisualStyleBackColor = True
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Location = New System.Drawing.Point(30, 330)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(65, 15)
        Me.lblFrequency.TabIndex = 12
        Me.lblFrequency.Text = "Frequency:"
        '
        'cboFrequency
        '
        Me.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Location = New System.Drawing.Point(30, 350)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(200, 23)
        Me.cboFrequency.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(150, 410)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(290, 410)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ExpenseForm
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 470)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboFrequency)
        Me.Controls.Add(Me.lblFrequency)
        Me.Controls.Add(Me.chkRecurring)
        Me.Controls.Add(Me.chkTaxDeductible)
        Me.Controls.Add(Me.dtpExpenseDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cboCurrency)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ExpenseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expense"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents cboCurrency As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpExpenseDate As DateTimePicker
    Friend WithEvents chkTaxDeductible As CheckBox
    Friend WithEvents chkRecurring As CheckBox
    Friend WithEvents lblFrequency As Label
    Friend WithEvents cboFrequency As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
