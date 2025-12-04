Imports System

Imports System.Windows.Forms

Module Program
    <STAThread>
    Sub Main()
        ' Initialize database
        DatabaseHelper.InitializeDatabase()

        ' Enable visual styles
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Start with login form
        Dim loginForm As New LoginForm()
        Application.Run(loginForm)
    End Sub
End Module
