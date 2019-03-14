Imports MySql.Data.MySqlClient

Module db_connect
    Public sqlcommand As MySqlCommand
    Public sqlreader As MySqlDataReader
    Public sqladapter As MySqlDataAdapter
    Public conn As MySqlConnection
    Public query As String

    Public Sub Connection()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost; userid=root; password=yahquew2411; database=thesis"
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
