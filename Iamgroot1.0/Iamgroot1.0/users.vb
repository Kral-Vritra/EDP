Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text

Public Class users
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        landingpage.Show()
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection
            connection.Open()
            Using reader As New StreamReader(openFileDialog1.FileName)
                reader.ReadLine() ' Skip the first row
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    Dim id As Integer = Integer.Parse(values(0))
                    Dim username As String = values(1)
                    Dim password As String = values(2)
                    command.CommandText = $"INSERT INTO users (username, password) VALUES ('{username}', '{password}')"
                    command.ExecuteNonQuery()
                End While
            End Using
            MessageBox.Show("Data imported successfully.")
            connection.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "CSV file (*.csv)|*.csv"
            saveFileDialog1.Title = "Export Users Table to CSV File"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                Dim connString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
                Dim conn As MySqlConnection = New MySqlConnection(connString)
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM users", conn)

                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                Dim sb As New StringBuilder

                For Each column As DataColumn In dt.Columns
                    sb.Append(column.ColumnName).Append(",")
                Next
                sb.Remove(sb.Length - 1, 1)
                sb.Append(vbCrLf)

                For Each row As DataRow In dt.Rows
                    For Each column As DataColumn In dt.Columns
                        sb.Append(row(column.ColumnName)).Append(",")
                    Next
                    sb.Remove(sb.Length - 1, 1)
                    sb.Append(vbCrLf)
                Next

                File.WriteAllText(saveFileDialog1.FileName, sb.ToString())

                MessageBox.Show("Backup exported successfully to " & saveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT * FROM users", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection
            connection.Open()
            command.CommandText = $"INSERT INTO users (username, password) VALUES ('{txtUsername.Text}', '{txtPassword.Text}')"
            command.ExecuteNonQuery()
            MessageBox.Show("Data added successfully.")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the data: " & ex.Message)
        End Try
    End Sub
    Private Sub RefreshDataGridView()
        Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT * FROM users", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = DataGridView1.SelectedRows(0).Cells("id").Value
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
                Dim connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand()
                command.Connection = connection
                connection.Open()
                command.CommandText = $"DELETE FROM users WHERE id = {selectedID}"
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Record deleted successfully.")
                RefreshDataGridView()
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

End Class