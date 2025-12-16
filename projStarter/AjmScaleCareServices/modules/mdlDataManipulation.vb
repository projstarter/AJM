Imports System.Data.SQLite


Module mdlDataManipulation

    Public conn As New SQLiteConnection
    Sub OpenDB()
        Dim db As String = Environment.CurrentDirectory & "\ajm.db"
        Try
            AppLog = "Connecting to database..."
            conn.ConnectionString = String.Format("Data Source={0};", db)
            conn.Open()
            AppLog = "Database successfully connected!"
        Catch ex As Exception
            AppLog = "Error while connecting to database:" & ex.Message
        End Try
    End Sub
End Module
