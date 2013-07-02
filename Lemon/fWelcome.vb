Public Class fWelcome

    Private Sub fWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fMain.Enabled = False
        fMain.Opacity = 0
        fMain.WindowState = FormWindowState.Minimized
        fMain.ShowInTaskbar = False

        webWelcome.Navigate("https://dl.dropboxusercontent.com/u/57594406/web/mellow/lemon.html")

        txtVersion.Text = My.Application.Info.Version.ToString

        If My.Settings.varRemember = True Then
            cbRemember.Checked = True
            tbPin.Text = My.Settings.dataPin
        Else
            cbRemember.Checked = False
        End If

        If My.Settings.dataPin = "" Then
            txtNewPin.Visible = True
            tbNewPin.Visible = True
            txtPin.Text = "confirm"
            tbNewPin.Focus()
        Else
            txtNewPin.Visible = False
            tbNewPin.Visible = False
            tbPin.Focus()
        End If
    End Sub

    Private Sub bUnlock_Click(sender As Object, e As EventArgs) Handles bUnlock.Click
        If Not My.Settings.dataPin = "" Then
            If tbPin.Text = My.Settings.dataPin Then
                fMain.Enabled = True
                fMain.Opacity = 100
                fMain.WindowState = FormWindowState.Maximized
                fMain.ShowInTaskbar = True
                tbPin.Clear()
                Me.Close()
            Else
                tbPin.Clear()
            End If
        Else
            If tbNewPin.Text = tbPin.Text Then
                My.Settings.dataPin = tbPin.Text
                bUnlock.PerformClick()
            End If
        End If
    End Sub

    Private Sub cbRemember_CheckedChanged(sender As Object, e As EventArgs) Handles cbRemember.CheckedChanged
        If cbRemember.Checked = True Then
            My.Settings.varRemember = True
        Else
            My.Settings.varRemember = False
        End If
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Application.Exit()
    End Sub

    Private Sub tbConfirmPin_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPin.KeyDown
        If e.KeyCode = Keys.Enter Then
            bUnlock.PerformClick()
        End If
    End Sub
End Class