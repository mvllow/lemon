Public Class fNotepad

    Private Sub fNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNotes.Text = My.Settings.varNotes
    End Sub

    Private Sub fNotepad_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        My.Settings.varNotes = tbNotes.Text
    End Sub

    'context menus

    Private Sub iSaveAs_Click(sender As Object, e As EventArgs) Handles iSaveAs.Click
        save.Title = "Save File"
        save.FileName = "notes"
        save.Filter = "Text File|*.txt"

        Dim Path As String = save.FileName

        Dim FileText As String = tbNotes.Text

        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(save.FileName, FileText, False)
        End If
    End Sub

    Private Sub iClearAll_Click(sender As Object, e As EventArgs) Handles iClearAll.Click
        tbNotes.Text = ""
    End Sub
End Class