Public Class fSplash

    Private Sub fSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myVer As String = My.Application.Info.Version.ToString

        txtVersion.Text = myVer
    End Sub
End Class