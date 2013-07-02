Public Class fScreenshot

    Private Sub bScreenshot_Click(sender As Object, e As EventArgs) Handles bScreenshot.Click
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics

        Me.Opacity = 0
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        Me.Opacity = 100
        picScreenshot.Image = screenshot
        picScreenshot.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        save.Title = "save screenshot"
        save.FileName = tbSave.Text()
        save.Filter = "Bitmap |*.bmp"

        If save.ShowDialog() = DialogResult.OK Then
            picScreenshot.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub
End Class