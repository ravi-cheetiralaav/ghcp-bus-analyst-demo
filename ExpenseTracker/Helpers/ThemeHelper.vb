Imports System.Drawing
Imports System.Windows.Forms

Public Class ThemeHelper
    ' Color scheme
    Private Shared ReadOnly PrimaryBlue As Color = Color.FromArgb(0, 120, 215)
    Private Shared ReadOnly SuccessGreen As Color = Color.FromArgb(16, 124, 16)
    Private Shared ReadOnly WarningOrange As Color = Color.FromArgb(255, 140, 0)
    Private Shared ReadOnly DangerRed As Color = Color.FromArgb(196, 43, 28)
    Private Shared ReadOnly InfoCyan As Color = Color.FromArgb(0, 151, 167)
    Private Shared ReadOnly HighlightYellow As Color = Color.FromArgb(255, 185, 0)
    
    Public Shared Sub ApplyLightTheme(frm As Form)
        frm.BackColor = Color.FromArgb(243, 243, 243)
        For Each ctrl As Control In frm.Controls
            ApplyControlTheme(ctrl)
        Next
    End Sub

    Private Shared Sub ApplyControlTheme(ctrl As Control)
        ' Panels and GroupBoxes
        If TypeOf ctrl Is Panel Then
            Dim p = CType(ctrl, Panel)
            p.BackColor = Color.White
            ' Highlight stats panel
            If ctrl.Name = "pnlStats" Then
                p.BackColor = Color.FromArgb(240, 248, 255)
                p.BorderStyle = BorderStyle.FixedSingle
            End If
        End If
        
        If TypeOf ctrl Is GroupBox Then
            Dim g = CType(ctrl, GroupBox)
            g.BackColor = Color.White
            g.ForeColor = PrimaryBlue
            g.Font = New Font(g.Font, FontStyle.Bold)
        End If
        
        ' Buttons with role-based colors
        If TypeOf ctrl Is Button Then
            Dim b = CType(ctrl, Button)
            b.FlatStyle = FlatStyle.Flat
            b.ForeColor = Color.White
            b.Font = New Font(b.Font.FontFamily, b.Font.Size, FontStyle.Bold)
            
            ' Apply colors based on button name/text
            Select Case b.Name.ToLower()
                Case "btnadd", "btnaddexpense"
                    b.BackColor = SuccessGreen
                Case "btndelete", "btnremove"
                    b.BackColor = DangerRed
                Case "btnedit", "btneditexpense"
                    b.BackColor = WarningOrange
                Case "btnsummaries", "btnviewsummaries", "btnprint", "btnprintmonthly", "btnprintcalendaryear", "btnprintfy"
                    b.BackColor = InfoCyan
                Case "btnsettings"
                    b.BackColor = Color.FromArgb(106, 90, 205)
                Case "btnlogout"
                    b.BackColor = Color.FromArgb(139, 69, 19)
                Case "btnsearch", "btngenerate", "btngeneratemonthly", "btngeneratecalendaryear", "btngeneratefy"
                    b.BackColor = PrimaryBlue
                Case Else
                    b.BackColor = PrimaryBlue
            End Select
        End If
        
        ' Labels - highlight stats labels
        If TypeOf ctrl Is Label Then
            Dim l = CType(ctrl, Label)
            l.ForeColor = Color.FromArgb(45, 45, 48)
            
            ' Highlight important labels
            If l.Name.ToLower().Contains("total") OrElse l.Name.ToLower().Contains("welcome") Then
                l.Font = New Font(l.Font, FontStyle.Bold)
                If l.Name.ToLower().Contains("total") Then
                    l.ForeColor = PrimaryBlue
                End If
            End If
        End If
        
        ' DataGridView styling
        If TypeOf ctrl Is DataGridView Then
            Dim dgv = CType(ctrl, DataGridView)
            dgv.BackgroundColor = Color.White
            dgv.BorderStyle = BorderStyle.Fixed3D
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryBlue
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
            dgv.EnableHeadersVisualStyles = False
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)
        End If
        
        ' Recurse through child controls
        For Each child As Control In ctrl.Controls
            ApplyControlTheme(child)
        Next
    End Sub
End Class
