Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim loginform As New Form1()
        loginform.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text
        Dim conn As MySqlConnection = connectionDB.CDB()

        Dim sex As String = cb_sex.SelectedItem.ToString()

        Try

            'Dim selectedData As String = ComboBox1.SelectedItem.ToString()
            'Dim query As String = "SELECT COUNT(*) FROM useraccount WHERE U_UserName  = @username AND U_password = @password"
            Dim query As String = "INSERT INTO `useraccount` (`U_Id`, `U_Username`, `U_Password`, `Role`, `Sex`) VALUES (NULL, @username, @password, '', @sex);"
            Dim cmd As New MySqlCommand(query, conn)
            ' Parameters for the query
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@sex", sex)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class