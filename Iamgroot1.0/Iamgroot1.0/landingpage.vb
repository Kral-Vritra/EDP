Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices

Public Class landingpage
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnAnime_Click(sender As Object, e As EventArgs) Handles btnAnime.Click
        Dim anime As New anime()
        anime.Show()
        Me.Hide()
    End Sub

    Private Sub btnDirector_Click(sender As Object, e As EventArgs) Handles btnDirector.Click
        Dim director As New director()
        director.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenre_Click(sender As Object, e As EventArgs) Handles btnGenre.Click
        Dim genre As New genre()
        genre.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudio_Click(sender As Object, e As EventArgs) Handles btnStudio.Click
        Dim studio As New studio()
        studio.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim users As New users()
        users.Show()
        Me.Hide()
    End Sub

    Private Sub btnWriters_Click(sender As Object, e As EventArgs) Handles btnWriters.Click
        Dim writers As New writers()
        writers.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) 

    End Sub
End Class