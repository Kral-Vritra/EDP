Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand()
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM users WHERE username = @username AND password = @password"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login successful.")
                Me.Hide()
                Dim landingpage As New landingpage()
                landingpage.Show()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.ToString())

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
