Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class PrintHelper
    Public Shared Sub PrintDataGridView(dgv As DataGridView, title As String)
        Try
            Dim pd As New PrintDocument()
            Dim printDialog As New PrintDialog()
            printDialog.Document = pd

            AddHandler pd.PrintPage, Sub(sender, e)
                                        Dim y As Integer = 20
                                        Dim font As New Font("Segoe UI", 10)
                                        e.Graphics.DrawString(title, New Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, 20, y)
                                        y += 40

                                        ' Simple column headers
                                        Dim xStart As Integer = 20
                                        For Each col As DataGridViewColumn In dgv.Columns
                                            e.Graphics.DrawString(col.HeaderText, font, Brushes.Black, xStart, y)
                                            xStart += 150
                                        Next
                                        y += 20

                                        ' Rows
                                        For Each row As DataGridViewRow In dgv.Rows
                                            Dim x As Integer = 20
                                            For Each cell As DataGridViewCell In row.Cells
                                                Dim cellText = If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty)
                                                e.Graphics.DrawString(cellText, font, Brushes.Black, x, y)
                                                x += 150
                                            Next
                                            y += 20
                                            If y > e.MarginBounds.Bottom - 50 Then
                                                e.HasMorePages = True
                                                Return
                                            End If
                                        Next
                                        e.HasMorePages = False
                                    End Sub

            If printDialog.ShowDialog() = DialogResult.OK Then
                pd.PrinterSettings = printDialog.PrinterSettings
                pd.Print()
            End If
        Catch ex As Exception
            MessageBox.Show($"Print error: {ex.Message}", "Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
