Public Class fOptions
    Private Sub fOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbHome.Text = My.Settings.dataHome

        If My.Settings.varHideWelcome = True Then
            cbHideWelcome.Checked = True
        Else
            cbHideWelcome.Checked = False
        End If

        If My.Settings.varTopNav = True Then
            cbTopNav.Checked = True
        Else
            cbTopNav.Checked = False
        End If
    End Sub

    Private Sub fOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.dataHome = tbHome.Text

        If Not tbNewPin.Text = "" Then
            If tbNewPin.Text = tbPin.Text Then
                My.Settings.dataPin = tbPin.Text
            End If
        End If
    End Sub

    Private Sub cbHideWelcome_CheckedChanged(sender As Object, e As EventArgs) Handles cbHideWelcome.CheckedChanged
        If cbHideWelcome.Checked = True Then
            My.Settings.varHideWelcome = True
        Else
            My.Settings.varHideWelcome = False
        End If
    End Sub

    Private Sub cbTopNav_CheckedChanged(sender As Object, e As EventArgs) Handles cbTopNav.CheckedChanged
        If cbTopNav.Checked = True Then
            My.Settings.varTopNav = True
            fMain.loadVar()
        Else
            My.Settings.varTopNav = False
            fMain.loadVar()
        End If
    End Sub

    Private Sub bResetBookmarks_Click(sender As Object, e As EventArgs) Handles bResetBookmarks.Click
        My.Settings.dataBookmarks.Clear()
        fMain.listBookmarks.Items.Clear()
    End Sub

    Private Sub bResetHistory_Click(sender As Object, e As EventArgs) Handles bResetHistory.Click
        My.Settings.dataHistory.Clear()
        fMain.listHistory.Items.Clear()
    End Sub

    Private Sub bResetMemory_Click(sender As Object, e As EventArgs) Handles bResetMemory.Click
        My.Settings.dataMemory.Clear()
    End Sub

    Private Sub bResetBrowser_Click(sender As Object, e As EventArgs) Handles bResetBrowser.Click
        My.Settings.Reset()
        Application.Restart()
    End Sub
End Class