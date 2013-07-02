Public Class fNotes

    Private Sub fNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNotes.Text = My.Settings.dataNotes
    End Sub

    Private Sub fNotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.dataNotes = tbNotes.Text
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        If Not tbNotes.Text = "" Then
            Clipboard.SetText(tbNotes.Text)
            tbNotes.Clear()
            Me.Text = "notes copied to clipboard"
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        save.Title = "save notes"
        save.FileName = tbSave.Text()
        save.Filter = "Text File|*.txt"

        Dim Path As String = save.FileName
        Dim FileText As String = tbNotes.Text

        If save.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(save.FileName, FileText, False)
        End If
    End Sub
End Class