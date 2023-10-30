Imports MySql.Data.MySqlClient

Module connectionDB
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public Function CDB() As MySqlConnection
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=vb_airport_tricket"
        Try
            conn.Open()
            'MessageBox.Show("Connection to MySQL vb_airport_tricket was successful!!!!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return conn
    End Function
End Module
