Public Class fLogin

    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fMain.WindowState = FormWindowState.Minimized
        fMain.ShowInTaskbar = False
    End Sub

    'buttons

    Private Sub bUser_Click(sender As Object, e As EventArgs) Handles bUser.Click
        If My.Settings.varPassword = "" Then
            Me.Close()
            fMain.ShowInTaskbar = True
            fMain.WindowState = FormWindowState.Maximized
            fMain.Opacity = 100
        Else
            Me.Height = 250
        End If
    End Sub

    Private Sub bGuest_Click(sender As Object, e As EventArgs) Handles bGuest.Click
        MessageBox.Show("Coming Soon...", "Notice")
    End Sub

    Private Sub bIncognito_Click(sender As Object, e As EventArgs) Handles bIncognito.Click
        MessageBox.Show("This feature is coming soon, you may still enable incognito mode by going to view > history and right click > edit history.", "Notice")
    End Sub

    Private Sub bUnlock_Click(sender As Object, e As EventArgs) Handles bUnlock.Click
        If tbPassword.Text = My.Settings.varPassword Then
            Me.Close()
            fMain.ShowInTaskbar = True
            fMain.WindowState = FormWindowState.Maximized
            fMain.Opacity = 100
        End If
    End Sub

    Private Sub bMinimize_Click(sender As Object, e As EventArgs) Handles bMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Application.Exit()
    End Sub

    'textboxes

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            bUnlock.PerformClick()
        End If
    End Sub
End Class