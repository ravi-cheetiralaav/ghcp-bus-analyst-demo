Imports System.Data
Imports System.Data.SQLite
Imports System.IO

Public Class DatabaseHelper
    Private Shared ReadOnly ConnectionString As String = $"Data Source={GetDatabasePath()};Version=3;"

    Private Shared Function GetDatabasePath() As String
        Dim appDataPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ExpenseTracker")
        If Not Directory.Exists(appDataPath) Then
            Directory.CreateDirectory(appDataPath)
        End If
        Return Path.Combine(appDataPath, "ExpenseTracker.db")
    End Function

    Public Shared Sub InitializeDatabase()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            ' Create Users table
            Dim createUsersTable As String = "
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    Role TEXT DEFAULT 'User',
                    CreatedDate TEXT NOT NULL,
                    IsActive INTEGER DEFAULT 1
                )"

            ' Create Categories table
            Dim createCategoriesTable As String = "
                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryId INTEGER PRIMARY KEY AUTOINCREMENT,
                    CategoryName TEXT NOT NULL UNIQUE,
                    IsActive INTEGER DEFAULT 1
                )"

            ' Create Expenses table
            Dim createExpensesTable As String = "
                CREATE TABLE IF NOT EXISTS Expenses (
                    ExpenseId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Description TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    Currency TEXT NOT NULL,
                    CategoryId INTEGER,
                    ExpenseDate TEXT NOT NULL,
                    IsTaxDeductible INTEGER DEFAULT 0,
                    IsRecurring INTEGER DEFAULT 0,
                    RecurringFrequency TEXT,
                    CreatedDate TEXT NOT NULL,
                    ModifiedDate TEXT,
                    FOREIGN KEY (UserId) REFERENCES Users(UserId),
                    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
                )"

            ' Create Settings table
            Dim createSettingsTable As String = "
                CREATE TABLE IF NOT EXISTS Settings (
                    SettingId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    DefaultCurrency TEXT DEFAULT 'USD',
                    Theme TEXT DEFAULT 'Light',
                    FOREIGN KEY (UserId) REFERENCES Users(UserId)
                )"

            Using cmd As New SQLiteCommand(connection)
                cmd.CommandText = createUsersTable
                cmd.ExecuteNonQuery()

                cmd.CommandText = createCategoriesTable
                cmd.ExecuteNonQuery()

                cmd.CommandText = createExpensesTable
                cmd.ExecuteNonQuery()

                cmd.CommandText = createSettingsTable
                cmd.ExecuteNonQuery()
            End Using

            ' Insert default categories
            InsertDefaultCategories(connection)
        End Using
    End Sub

    Private Shared Sub InsertDefaultCategories(connection As SQLiteConnection)
        Dim categories() As String = {"Food & Dining", "Transportation", "Utilities", "Healthcare", 
                                       "Entertainment", "Shopping", "Education", "Housing", 
                                       "Insurance", "Business", "Travel", "Other"}

        For Each category In categories
            Dim query As String = "INSERT OR IGNORE INTO Categories (CategoryName) VALUES (@CategoryName)"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@CategoryName", category)
                cmd.ExecuteNonQuery()
            End Using
        Next
    End Sub

    Public Shared Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(ConnectionString)
    End Function

    Public Shared Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Using cmd As New SQLiteCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Using cmd As New SQLiteCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Shared Function ExecuteReader(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dataTable As New DataTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Using cmd As New SQLiteCommand(query, connection)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using
        Return dataTable
    End Function
End Class
