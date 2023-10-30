

Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ''connectionDB.CDB()
        Dim registerform As New Register()
        registerform.Show()
        Me.Hide()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text

        Dim conn As MySqlConnection = connectionDB.CDB()

        Try
            Dim query As String = "SELECT COUNT(*) FROM useraccount WHERE U_UserName  = @username AND U_password = @password"
            Dim cmd As New MySqlCommand(query, conn)
            ' Parameters for the query
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Login successful!")
                Dim dashboard_Admin As New dashboard_admin()
                dashboard_Admin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
