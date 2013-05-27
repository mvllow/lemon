Public Class fScreenshot

    'buttons

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
        Me.picScreenshot.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub bShare_Click(sender As Object, e As EventArgs) Handles bShare.Click
        MessageBox.Show("Coming Soon...", "Notice")
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        save.Title = "Save File"
        save.FileName = "screenshot"
        save.Filter = "Bitmap |*.bmp"
        If save.ShowDialog() = DialogResult.OK Then
            picScreenshot.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub

    'context menus

    Private Sub iToggleFullscreen_Click(sender As Object, e As EventArgs) Handles iToggleFullscreen.Click
        If Me.WindowState = FormWindowState.Normal Then
            picScreenshot.Dock = DockStyle.Fill
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            picScreenshot.BringToFront()
        Else
            picScreenshot.Dock = DockStyle.Top
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            picScreenshot.SendToBack()
        End If
    End Sub
End Class