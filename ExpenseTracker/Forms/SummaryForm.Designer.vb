Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SummaryForm
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
        Me.btnPrintMonthly = New System.Windows.Forms.Button()
        Me.btnPrintCalendarYear = New System.Windows.Forms.Button()
        Me.btnPrintFY = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabMonthly = New System.Windows.Forms.TabPage()
        Me.dgvMonthly = New System.Windows.Forms.DataGridView()
        Me.pnlMonthlyControls = New System.Windows.Forms.Panel()
        Me.btnGenerateMonthly = New System.Windows.Forms.Button()
        Me.dtpMonthYear = New System.Windows.Forms.DateTimePicker()
        Me.lblMonthYear = New System.Windows.Forms.Label()
        Me.tabCalendarYear = New System.Windows.Forms.TabPage()
        Me.dgvCalendarYear = New System.Windows.Forms.DataGridView()
        Me.pnlCalendarYearControls = New System.Windows.Forms.Panel()
        Me.btnGenerateCalendarYear = New System.Windows.Forms.Button()
        Me.cboCalendarYear = New System.Windows.Forms.ComboBox()
        Me.lblCalendarYear = New System.Windows.Forms.Label()
        Me.tabFY = New System.Windows.Forms.TabPage()
        Me.dgvFY = New System.Windows.Forms.DataGridView()
        Me.pnlFYControls = New System.Windows.Forms.Panel()
        Me.btnGenerateFY = New System.Windows.Forms.Button()
        Me.cboFY = New System.Windows.Forms.ComboBox()
        Me.lblFY = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabControl.SuspendLayout()
        Me.tabMonthly.SuspendLayout()
        CType(Me.dgvMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMonthlyControls.SuspendLayout()
        Me.tabCalendarYear.SuspendLayout()
        CType(Me.dgvCalendarYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCalendarYearControls.SuspendLayout()
        Me.tabFY.SuspendLayout()
        CType(Me.dgvFY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFYControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabMonthly)
        Me.tabControl.Controls.Add(Me.tabCalendarYear)
        Me.tabControl.Controls.Add(Me.tabFY)
        Me.tabControl.Location = New System.Drawing.Point(12, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(976, 526)
        Me.tabControl.TabIndex = 0
        '
        'tabMonthly
        '
        Me.tabMonthly.Controls.Add(Me.dgvMonthly)
        Me.tabMonthly.Controls.Add(Me.pnlMonthlyControls)
        Me.tabMonthly.Location = New System.Drawing.Point(4, 24)
        Me.tabMonthly.Name = "tabMonthly"
        Me.tabMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMonthly.Size = New System.Drawing.Size(968, 498)
        Me.tabMonthly.TabIndex = 0
        Me.tabMonthly.Text = "Monthly Summary"
        Me.tabMonthly.UseVisualStyleBackColor = True
        '
        'dgvMonthly
        '
        Me.dgvMonthly.AllowUserToAddRows = False
        Me.dgvMonthly.AllowUserToDeleteRows = False
        Me.dgvMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonthly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMonthly.Location = New System.Drawing.Point(3, 63)
        Me.dgvMonthly.Name = "dgvMonthly"
        Me.dgvMonthly.RowTemplate.Height = 25
        Me.dgvMonthly.Size = New System.Drawing.Size(962, 432)
        Me.dgvMonthly.TabIndex = 1
        '
        'pnlMonthlyControls
        '
        Me.pnlMonthlyControls.Controls.Add(Me.btnGenerateMonthly)
        Me.pnlMonthlyControls.Controls.Add(Me.btnPrintMonthly)
        Me.pnlMonthlyControls.Controls.Add(Me.dtpMonthYear)
        Me.pnlMonthlyControls.Controls.Add(Me.lblMonthYear)
        Me.pnlMonthlyControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMonthlyControls.Location = New System.Drawing.Point(3, 3)
        Me.pnlMonthlyControls.Name = "pnlMonthlyControls"
        Me.pnlMonthlyControls.Size = New System.Drawing.Size(962, 60)
        Me.pnlMonthlyControls.TabIndex = 0
        '
        'btnGenerateMonthly
        '
        Me.btnGenerateMonthly.Location = New System.Drawing.Point(270, 18)
        Me.btnGenerateMonthly.Name = "btnGenerateMonthly"
        Me.btnGenerateMonthly.Size = New System.Drawing.Size(100, 25)
        Me.btnGenerateMonthly.TabIndex = 2
        Me.btnGenerateMonthly.Text = "Generate"
        Me.btnGenerateMonthly.UseVisualStyleBackColor = True
        '
        'btnPrintMonthly
        '
        Me.btnPrintMonthly.Location = New System.Drawing.Point(380, 18)
        Me.btnPrintMonthly.Name = "btnPrintMonthly"
        Me.btnPrintMonthly.Size = New System.Drawing.Size(100, 25)
        Me.btnPrintMonthly.TabIndex = 3
        Me.btnPrintMonthly.Text = "Print"
        Me.btnPrintMonthly.UseVisualStyleBackColor = True
        '
        'dtpMonthYear
        '
        Me.dtpMonthYear.CustomFormat = "MMMM yyyy"
        Me.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthYear.Location = New System.Drawing.Point(100, 20)
        Me.dtpMonthYear.Name = "dtpMonthYear"
        Me.dtpMonthYear.Size = New System.Drawing.Size(150, 23)
        Me.dtpMonthYear.TabIndex = 1
        '
        'lblMonthYear
        '
        Me.lblMonthYear.AutoSize = True
        Me.lblMonthYear.Location = New System.Drawing.Point(15, 23)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(76, 15)
        Me.lblMonthYear.TabIndex = 0
        Me.lblMonthYear.Text = "Select Month:"
        '
        'tabCalendarYear
        '
        Me.tabCalendarYear.Controls.Add(Me.dgvCalendarYear)
        Me.tabCalendarYear.Controls.Add(Me.pnlCalendarYearControls)
        Me.tabCalendarYear.Location = New System.Drawing.Point(4, 24)
        Me.tabCalendarYear.Name = "tabCalendarYear"
        Me.tabCalendarYear.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalendarYear.Size = New System.Drawing.Size(968, 498)
        Me.tabCalendarYear.TabIndex = 1
        Me.tabCalendarYear.Text = "Calendar Year Summary"
        Me.tabCalendarYear.UseVisualStyleBackColor = True
        '
        'dgvCalendarYear
        '
        Me.dgvCalendarYear.AllowUserToAddRows = False
        Me.dgvCalendarYear.AllowUserToDeleteRows = False
        Me.dgvCalendarYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendarYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCalendarYear.Location = New System.Drawing.Point(3, 63)
        Me.dgvCalendarYear.Name = "dgvCalendarYear"
        Me.dgvCalendarYear.RowTemplate.Height = 25
        Me.dgvCalendarYear.Size = New System.Drawing.Size(962, 432)
        Me.dgvCalendarYear.TabIndex = 1
        '
        'pnlCalendarYearControls
        '
        Me.pnlCalendarYearControls.Controls.Add(Me.btnGenerateCalendarYear)
        Me.pnlCalendarYearControls.Controls.Add(Me.btnPrintCalendarYear)
        Me.pnlCalendarYearControls.Controls.Add(Me.cboCalendarYear)
        Me.pnlCalendarYearControls.Controls.Add(Me.lblCalendarYear)
        Me.pnlCalendarYearControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCalendarYearControls.Location = New System.Drawing.Point(3, 3)
        Me.pnlCalendarYearControls.Name = "pnlCalendarYearControls"
        Me.pnlCalendarYearControls.Size = New System.Drawing.Size(962, 60)
        Me.pnlCalendarYearControls.TabIndex = 0
        '
        'btnGenerateCalendarYear
        '
        Me.btnGenerateCalendarYear.Location = New System.Drawing.Point(240, 18)
        Me.btnGenerateCalendarYear.Name = "btnGenerateCalendarYear"
        Me.btnGenerateCalendarYear.Size = New System.Drawing.Size(100, 25)
        Me.btnGenerateCalendarYear.TabIndex = 2
        Me.btnGenerateCalendarYear.Text = "Generate"
        Me.btnGenerateCalendarYear.UseVisualStyleBackColor = True
        '
        'btnPrintCalendarYear
        '
        Me.btnPrintCalendarYear.Location = New System.Drawing.Point(350, 18)
        Me.btnPrintCalendarYear.Name = "btnPrintCalendarYear"
        Me.btnPrintCalendarYear.Size = New System.Drawing.Size(100, 25)
        Me.btnPrintCalendarYear.TabIndex = 3
        Me.btnPrintCalendarYear.Text = "Print"
        Me.btnPrintCalendarYear.UseVisualStyleBackColor = True
        '
        'cboCalendarYear
        '
        Me.cboCalendarYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalendarYear.FormattingEnabled = True
        Me.cboCalendarYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cboCalendarYear.Location = New System.Drawing.Point(90, 20)
        Me.cboCalendarYear.Name = "cboCalendarYear"
        Me.cboCalendarYear.Size = New System.Drawing.Size(120, 23)
        Me.cboCalendarYear.TabIndex = 1
        '
        'lblCalendarYear
        '
        Me.lblCalendarYear.AutoSize = True
        Me.lblCalendarYear.Location = New System.Drawing.Point(15, 23)
        Me.lblCalendarYear.Name = "lblCalendarYear"
        Me.lblCalendarYear.Size = New System.Drawing.Size(67, 15)
        Me.lblCalendarYear.TabIndex = 0
        Me.lblCalendarYear.Text = "Select Year:"
        '
        'tabFY
        '
        Me.tabFY.Controls.Add(Me.dgvFY)
        Me.tabFY.Controls.Add(Me.pnlFYControls)
        Me.tabFY.Location = New System.Drawing.Point(4, 24)
        Me.tabFY.Name = "tabFY"
        Me.tabFY.Size = New System.Drawing.Size(968, 498)
        Me.tabFY.TabIndex = 2
        Me.tabFY.Text = "Financial Year Summary"
        Me.tabFY.UseVisualStyleBackColor = True
        '
        'dgvFY
        '
        Me.dgvFY.AllowUserToAddRows = False
        Me.dgvFY.AllowUserToDeleteRows = False
        Me.dgvFY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFY.Location = New System.Drawing.Point(0, 60)
        Me.dgvFY.Name = "dgvFY"
        Me.dgvFY.RowTemplate.Height = 25
        Me.dgvFY.Size = New System.Drawing.Size(968, 438)
        Me.dgvFY.TabIndex = 1
        '
        'pnlFYControls
        '
        Me.pnlFYControls.Controls.Add(Me.btnGenerateFY)
        Me.pnlFYControls.Controls.Add(Me.btnPrintFY)
        Me.pnlFYControls.Controls.Add(Me.cboFY)
        Me.pnlFYControls.Controls.Add(Me.lblFY)
        Me.pnlFYControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFYControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlFYControls.Name = "pnlFYControls"
        Me.pnlFYControls.Size = New System.Drawing.Size(968, 60)
        Me.pnlFYControls.TabIndex = 0
        '
        'btnGenerateFY
        '
        Me.btnGenerateFY.Location = New System.Drawing.Point(280, 18)
        Me.btnGenerateFY.Name = "btnGenerateFY"
        Me.btnGenerateFY.Size = New System.Drawing.Size(100, 25)
        Me.btnGenerateFY.TabIndex = 2
        Me.btnGenerateFY.Text = "Generate"
        Me.btnGenerateFY.UseVisualStyleBackColor = True
        '
        'btnPrintFY
        '
        Me.btnPrintFY.Location = New System.Drawing.Point(390, 18)
        Me.btnPrintFY.Name = "btnPrintFY"
        Me.btnPrintFY.Size = New System.Drawing.Size(100, 25)
        Me.btnPrintFY.TabIndex = 3
        Me.btnPrintFY.Text = "Print"
        Me.btnPrintFY.UseVisualStyleBackColor = True
        '
        'cboFY
        '
        Me.cboFY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFY.FormattingEnabled = True
        Me.cboFY.Location = New System.Drawing.Point(130, 20)
        Me.cboFY.Name = "cboFY"
        Me.cboFY.Size = New System.Drawing.Size(120, 23)
        Me.cboFY.TabIndex = 1
        '
        'lblFY
        '
        Me.lblFY.AutoSize = True
        Me.lblFY.Location = New System.Drawing.Point(15, 23)
        Me.lblFY.Name = "lblFY"
        Me.lblFY.Size = New System.Drawing.Size(109, 15)
        Me.lblFY.TabIndex = 0
        Me.lblFY.Text = "Select Financial Year:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(450, 550)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 592)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expense Summaries"
        Me.tabControl.ResumeLayout(False)
        Me.tabMonthly.ResumeLayout(False)
        CType(Me.dgvMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMonthlyControls.ResumeLayout(False)
        Me.pnlMonthlyControls.PerformLayout()
        Me.tabCalendarYear.ResumeLayout(False)
        CType(Me.dgvCalendarYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCalendarYearControls.ResumeLayout(False)
        Me.pnlCalendarYearControls.PerformLayout()
        Me.tabFY.ResumeLayout(False)
        CType(Me.dgvFY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFYControls.ResumeLayout(False)
        Me.pnlFYControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabMonthly As TabPage
    Friend WithEvents tabCalendarYear As TabPage
    Friend WithEvents tabFY As TabPage
    Friend WithEvents dgvMonthly As DataGridView
    Friend WithEvents pnlMonthlyControls As Panel
    Friend WithEvents lblMonthYear As Label
    Friend WithEvents dtpMonthYear As DateTimePicker
    Friend WithEvents btnGenerateMonthly As Button
    Friend WithEvents dgvCalendarYear As DataGridView
    Friend WithEvents pnlCalendarYearControls As Panel
    Friend WithEvents btnGenerateCalendarYear As Button
    Friend WithEvents cboCalendarYear As ComboBox
    Friend WithEvents lblCalendarYear As Label
    Friend WithEvents dgvFY As DataGridView
    Friend WithEvents pnlFYControls As Panel
    Friend WithEvents btnGenerateFY As Button
    Friend WithEvents cboFY As ComboBox
    Friend WithEvents lblFY As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrintMonthly As Button
    Friend WithEvents btnPrintCalendarYear As Button
    Friend WithEvents btnPrintFY As Button
End Class
