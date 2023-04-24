Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class anime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        landingpage.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT anime_id, anime_title, anime_episode_count, studio_name, genre_type, writer_name, director_name 
            FROM anime 
            INNER JOIN studio ON anime.studio_id = studio.studio_id
            INNER JOIN genre ON anime.genre_id = genre.genre_id 
            INNER JOIN writer ON anime.writer_id = writer.writer_id 
            INNER JOIN director ON anime.director_id = director.director_id", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "CSV file (*.csv)|*.csv"
            saveFileDialog1.Title = "Export Anime Table to CSV File"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                Dim connString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
                Dim conn As MySqlConnection = New MySqlConnection(connString)
                Dim cmd As MySqlCommand = New MySqlCommand("
                SELECT a.anime_id, a.anime_title, a.anime_episode_count, s.studio_name, g.genre_type, w.writer_name, d.director_name
                FROM anime a
                JOIN studio s ON s.studio_id = a.studio_id
                JOIN genre g ON g.genre_id = a.genre_id
                JOIN writer w ON w.writer_id = a.writer_id
                JOIN director d ON d.director_id = a.director_id
            ", conn)

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection
            connection.Open()
            command.CommandText = $"INSERT INTO anime (anime_title, anime_episode_count, studio_id, genre_id, writer_id, director_id) VALUES ('{txtAnimeTitle.Text}', {Integer.Parse(txtEpisodeCount.Text)}, {Integer.Parse(txtStudio.Text)}, {Integer.Parse(txtGenre.Text)}, {Integer.Parse(txtWriter.Text)}, {Integer.Parse(txtDirector.Text)})"
            command.ExecuteNonQuery()
            MessageBox.Show("Data added successfully.")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the data: " & ex.Message)
        End Try
    End Sub
    Private Sub RefreshDataGridView()
        Try
            Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection
            connection.Open()
            command.CommandText = "SELECT * FROM anime"
            Dim dataAdapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = DataGridView1.SelectedRows(0).Cells("anime_id").Value
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim connectionString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
                Dim connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand()
                command.Connection = connection
                connection.Open()
                command.CommandText = $"DELETE FROM anime WHERE anime_id = {selectedID}"
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Record deleted successfully.")
                RefreshDataGridView()
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim printDoc As New Printing.PrintDocument()
            printDoc.DefaultPageSettings.Landscape = True
            AddHandler printDoc.PrintPage, AddressOf PrintPageHandler
            Dim printPreviewDlg As New PrintPreviewDialog()
            printPreviewDlg.Document = printDoc
            printPreviewDlg.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim connString As String = "Server=localhost;Database=anime_database;Uid=root;Pwd=iamgroot;"
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT anime_title, anime_episode_count,
            studio.studio_name, genre.genre_type, director.director_name
            FROM anime
            JOIN studio ON anime.studio_id = studio.studio_id
            JOIN genre ON anime.genre_id = genre.genre_id
            JOIN director ON anime.director_id = director.director_id", conn)
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim printFont As New Font("Arial", 11)
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim lineHeight As Integer = CInt(printFont.GetHeight())

        For Each column As DataColumn In dt.Columns
            e.Graphics.DrawString(column.ColumnName, printFont, Brushes.Black, leftMargin, topMargin)
            leftMargin += 180
        Next
        topMargin += lineHeight

        For Each row As DataRow In dt.Rows
            leftMargin = e.MarginBounds.Left
            For Each column As DataColumn In dt.Columns
                e.Graphics.DrawString(row(column.ColumnName).ToString(), printFont, Brushes.Black, leftMargin, topMargin)
                leftMargin += 180
            Next
            topMargin += lineHeight
        Next
    End Sub

End Class