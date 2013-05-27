Public Class fBookmarks

    Private Sub fBookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBookmarks.Items.Clear()

        For Each Item As String In My.Settings.varBookmark
            listBookmarks.Items.Add(Item)
        Next
    End Sub

    'buttons

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        If Not tbUrl.Text = "" Then
            listBookmarks.Items.Add(tbName.Text)

            My.Settings.varBookmark.Add(tbName.Text)
            My.Settings.varUrl.Add(tbUrl.Text)
            My.Settings.Save()

            tbName.Text = ""
            tbUrl.Text = ""

            fMain.loadFavicon()
            fMain.loadBookmarks()

            listBookmarks.Items.Clear()

            For Each Item As String In My.Settings.varBookmark
                listBookmarks.Items.Add(Item)
            Next
        End If
    End Sub

    'textboxes

    Private Sub tbUrl_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUrl.KeyDown
        If e.KeyCode = Keys.Enter Then
            bAdd.PerformClick()
        End If
    End Sub

    'context menus

    Private Sub iEditBookmarks_Click(sender As Object, e As EventArgs) Handles iEditBookmarks.Click
        Me.Width = 780
    End Sub

    Private Sub iClearBookmarks_Click(sender As Object, e As EventArgs) Handles iClearBookmarks.Click
        listBookmarks.Items.Clear()

        My.Settings.varBookmark.Clear()
        My.Settings.varUrl.Clear()
        My.Settings.Save()

        fMain.loadFavicon()
        fMain.loadBookmarks()
    End Sub
End Class