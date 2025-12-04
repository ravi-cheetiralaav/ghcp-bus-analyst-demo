Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.chkShowRecurring = New System.Windows.Forms.CheckBox()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chkRecurring = New System.Windows.Forms.CheckBox()
        Me.chkTaxDeductible = New System.Windows.Forms.CheckBox()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvExpenses = New System.Windows.Forms.DataGridView()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSummaries = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblTaxDeductible = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.grpFilters.SuspendLayout()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActions.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.Location = New System.Drawing.Point(20, 20)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(150, 25)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, User!"
        '
        'picLogo
        '
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picLogo.Location = New System.Drawing.Point(1080, 10)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 40)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 99
        Me.picLogo.TabStop = False
        '
        'grpFilters
        '
        Me.grpFilters.Controls.Add(Me.chkShowRecurring)
        Me.grpFilters.Controls.Add(Me.btnClearFilters)
        Me.grpFilters.Controls.Add(Me.btnSearch)
        Me.grpFilters.Controls.Add(Me.chkRecurring)
        Me.grpFilters.Controls.Add(Me.chkTaxDeductible)
        Me.grpFilters.Controls.Add(Me.cboCurrency)
        Me.grpFilters.Controls.Add(Me.lblCurrency)
        Me.grpFilters.Controls.Add(Me.cboCategory)
        Me.grpFilters.Controls.Add(Me.lblCategory)
        Me.grpFilters.Controls.Add(Me.dtpTo)
        Me.grpFilters.Controls.Add(Me.lblTo)
        Me.grpFilters.Controls.Add(Me.dtpFrom)
        Me.grpFilters.Controls.Add(Me.lblFrom)
        Me.grpFilters.Controls.Add(Me.txtSearch)
        Me.grpFilters.Controls.Add(Me.lblSearch)
        Me.grpFilters.Location = New System.Drawing.Point(20, 60)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(1160, 120)
        Me.grpFilters.TabIndex = 1
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Filters"
        '
        'chkShowRecurring
        '
        Me.chkShowRecurring.AutoSize = True
        Me.chkShowRecurring.Location = New System.Drawing.Point(880, 55)
        Me.chkShowRecurring.Name = "chkShowRecurring"
        Me.chkShowRecurring.Size = New System.Drawing.Size(147, 19)
        Me.chkShowRecurring.TabIndex = 14
        Me.chkShowRecurring.Text = "Expand Recurring Items"
        Me.chkShowRecurring.ThreeState = False
        Me.chkShowRecurring.UseVisualStyleBackColor = True
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Location = New System.Drawing.Point(1050, 80)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(90, 25)
        Me.btnClearFilters.TabIndex = 13
        Me.btnClearFilters.Text = "Clear"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1050, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 25)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chkRecurring
        '
        Me.chkRecurring.AutoSize = True
        Me.chkRecurring.Location = New System.Drawing.Point(740, 55)
        Me.chkRecurring.Name = "chkRecurring"
        Me.chkRecurring.Size = New System.Drawing.Size(78, 19)
        Me.chkRecurring.TabIndex = 11
        Me.chkRecurring.Text = "Recurring"
        Me.chkRecurring.ThreeState = True
        Me.chkRecurring.UseVisualStyleBackColor = True
        '
        'chkTaxDeductible
        '
        Me.chkTaxDeductible.AutoSize = True
        Me.chkTaxDeductible.Location = New System.Drawing.Point(590, 55)
        Me.chkTaxDeductible.Name = "chkTaxDeductible"
        Me.chkTaxDeductible.Size = New System.Drawing.Size(104, 19)
        Me.chkTaxDeductible.TabIndex = 10
        Me.chkTaxDeductible.Text = "Tax Deductible"
        Me.chkTaxDeductible.ThreeState = True
        Me.chkTaxDeductible.UseVisualStyleBackColor = True
        '
        'cboCurrency
        '
        Me.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.Location = New System.Drawing.Point(440, 52)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(120, 23)
        Me.cboCurrency.TabIndex = 9
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Location = New System.Drawing.Point(440, 30)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(58, 15)
        Me.lblCurrency.TabIndex = 8
        Me.lblCurrency.Text = "Currency:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(290, 52)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(120, 23)
        Me.cboCategory.TabIndex = 7
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(290, 30)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(58, 15)
        Me.lblCategory.TabIndex = 6
        Me.lblCategory.Text = "Category:"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(440, 85)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(120, 23)
        Me.dtpTo.TabIndex = 5
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(395, 89)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(22, 15)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "To:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(290, 85)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(90, 23)
        Me.dtpFrom.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(240, 89)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(38, 15)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(20, 52)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search description..."
        Me.txtSearch.Size = New System.Drawing.Size(240, 23)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 30)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(45, 15)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'dgvExpenses
        '
        Me.dgvExpenses.AllowUserToAddRows = False
        Me.dgvExpenses.AllowUserToDeleteRows = False
        Me.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpenses.Location = New System.Drawing.Point(20, 190)
        Me.dgvExpenses.Name = "dgvExpenses"
        Me.dgvExpenses.RowTemplate.Height = 25
        Me.dgvExpenses.Size = New System.Drawing.Size(1160, 400)
        Me.dgvExpenses.TabIndex = 2
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.btnLogout)
        Me.grpActions.Controls.Add(Me.btnSettings)
        Me.grpActions.Controls.Add(Me.btnSummaries)
        Me.grpActions.Controls.Add(Me.btnDelete)
        Me.grpActions.Controls.Add(Me.btnEdit)
        Me.grpActions.Controls.Add(Me.btnAdd)
        Me.grpActions.Location = New System.Drawing.Point(20, 600)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(720, 70)
        Me.grpActions.TabIndex = 3
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(620, 25)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(80, 30)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(510, 25)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(100, 30)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnSummaries
        '
        Me.btnSummaries.Location = New System.Drawing.Point(380, 25)
        Me.btnSummaries.Name = "btnSummaries"
        Me.btnSummaries.Size = New System.Drawing.Size(120, 30)
        Me.btnSummaries.TabIndex = 3
        Me.btnSummaries.Text = "View Summaries"
        Me.btnSummaries.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(270, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(140, 25)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 30)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit Expense"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Expense"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlStats
        '
        Me.pnlStats.Controls.Add(Me.lblTaxDeductible)
        Me.pnlStats.Controls.Add(Me.lblTotalAmount)
        Me.pnlStats.Controls.Add(Me.lblTotalExpenses)
        Me.pnlStats.Location = New System.Drawing.Point(750, 600)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(430, 70)
        Me.pnlStats.TabIndex = 4
        '
        'lblTaxDeductible
        '
        Me.lblTaxDeductible.AutoSize = True
        Me.lblTaxDeductible.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTaxDeductible.Location = New System.Drawing.Point(15, 45)
        Me.lblTaxDeductible.Name = "lblTaxDeductible"
        Me.lblTaxDeductible.Size = New System.Drawing.Size(140, 19)
        Me.lblTaxDeductible.TabIndex = 2
        Me.lblTaxDeductible.Text = "Tax Deductible: $0.00"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalAmount.Location = New System.Drawing.Point(15, 25)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(132, 19)
        Me.lblTotalAmount.TabIndex = 1
        Me.lblTotalAmount.Text = "Total Amount: $0.00"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalExpenses.Location = New System.Drawing.Point(15, 5)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(121, 19)
        Me.lblTotalExpenses.TabIndex = 0
        Me.lblTotalExpenses.Text = "Total Expenses: 0"
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 680)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.dgvExpenses)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense Tracker - Dashboard"
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActions.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCurrency As ComboBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents chkTaxDeductible As CheckBox
    Friend WithEvents chkRecurring As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents chkShowRecurring As CheckBox
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents grpActions As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSummaries As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTaxDeductible As Label
    Friend WithEvents picLogo As PictureBox
End Class
