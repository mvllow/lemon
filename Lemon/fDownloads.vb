Imports System.Net

Public Class fDownloads
    Public WithEvents downloads As New WebClient

    'buttons

    Private Sub bDownload_Click(sender As Object, e As EventArgs) Handles bDownload.Click
        downloads = New WebClient
        downloads.DownloadFileAsync(New Uri(tbFileDir.Text), tbSaveDir.Text + "\" + tbFileName.Text)
    End Sub

    'textboxes

    Private Sub tbFileDir_Click(sender As Object, e As EventArgs) Handles tbFileDir.Click
        txtComplete.Visible = False
    End Sub

    Private Sub tbSaveDir_Click(sender As Object, e As EventArgs) Handles tbSaveDir.Click
        txtComplete.Visible = False
        folderBrowser.ShowDialog()
        tbSaveDir.Text = folderBrowser.SelectedPath
    End Sub

    Private Sub tbFileName_Click(sender As Object, e As EventArgs) Handles tbFileName.Click
        txtComplete.Visible = False
    End Sub

    Private Sub tbFileName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbFileName.KeyDown
        If e.KeyCode = Keys.Enter Then
            bDownload.PerformClick()
        End If
    End Sub

    Private Sub downloads_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloads.DownloadProgressChanged
        pbDownload.Value = e.ProgressPercentage

        If pbDownload.Value = 100 Then
            txtComplete.Visible = True
            pbDownload.Value = 0
        Else
            'txtComplete.Visible = False
        End If
    End Sub
End Class