Imports System.Data

Public Class CategoryService
    Public Shared Function GetAllCategories() As List(Of Category)
        Dim categories As New List(Of Category)
        Dim query As String = "SELECT CategoryId, CategoryName, IsActive FROM Categories WHERE IsActive = 1 ORDER BY CategoryName"

        Dim dt As DataTable = DatabaseHelper.ExecuteReader(query, Nothing)

        For Each row As DataRow In dt.Rows
            categories.Add(New Category With {
                .CategoryId = Convert.ToInt32(row("CategoryId")),
                .CategoryName = row("CategoryName").ToString(),
                .IsActive = Convert.ToBoolean(row("IsActive"))
            })
        Next

        Return categories
    End Function
End Class
