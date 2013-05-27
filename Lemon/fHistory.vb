Public Class fHistory

    Private Sub fHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listHistory.Items.Clear()

        For Each Item As String In My.Settings.varHistory
            listHistory.Items.Add(Item)
        Next

        If My.Settings.autoClear = True Then
            cbAutoClear.Checked = True
        Else
            cbAutoClear.Checked = False
        End If

        If My.Settings.autoLock = True Then
            cbAutoLock.Checked = True
        Else
            cbAutoLock.Checked = False
        End If
    End Sub

    Private Sub listHistory_DoubleClick(sender As Object, e As EventArgs) Handles listHistory.DoubleClick
        CType(fMain.tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(listHistory.SelectedItem)
    End Sub

    'checkboxes

    Private Sub cbAutoClear_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoClear.CheckedChanged
        If cbAutoClear.Checked = True Then
            My.Settings.autoClear = True
        Else
            My.Settings.autoClear = False
        End If

        fMain.loadVar()
    End Sub

    Private Sub cbAutoLock_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoLock.CheckedChanged
        If cbAutoLock.Checked = True Then
            My.Settings.autoLock = True
        Else
            My.Settings.autoLock = False
        End If

        fMain.loadVar()
    End Sub

    'context menus

    Private Sub iEditHistory_Click(sender As Object, e As EventArgs) Handles iEditHistory.Click
        Me.Width = 780
    End Sub

    Private Sub iClearHistory_Click(sender As Object, e As EventArgs) Handles iClearHistory.Click
        listHistory.Items.Clear()

        My.Settings.autoComplete.Clear()
        My.Settings.varHistory.Clear()

        My.Settings.Save()

        fMain.loadVar()
    End Sub
End Class