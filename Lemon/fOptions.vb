Public Class fOptions

    Private Sub fOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.varPassword = "" Then
            txtOldPassword.Text = "Set Password"
            txtNewPassword.Text = "Confirm Password"
        Else
            txtOldPassword.Text = "Old Password"
            txtNewPassword.Text = "New Password"
        End If
        If My.Settings.themeLight = True Then
            comboTheme.SelectedItem = "Light"
            My.Settings.themeLight = True
            My.Settings.themeDark = False
        Else
            comboTheme.SelectedItem = "Dark"
            My.Settings.themeLight = False
            My.Settings.themeDark = True
        End If
        If My.Settings.searchBing = True Then
            comboSearch.SelectedItem = "Bing"
        ElseIf My.Settings.searchYoutube = True Then
            comboSearch.SelectedItem = "YouTube"
        Else
            comboSearch.SelectedItem = "Google"
        End If
        If My.Settings.varTopSearch Then
            cbTopSearchBar.Checked = True
        Else
            cbTopSearchBar.Checked = False
        End If
        If My.Settings.varStartLocked Then
            cbStartLocked.Checked = True
        Else
            cbStartLocked.Checked = False
        End If

        tbHomepage.Text = My.Settings.varHomepage

        fMain.loadVar()
    End Sub

    'buttons

    Private Sub bSetHomepage_Click(sender As Object, e As EventArgs) Handles bSetHomepage.Click
        tbHomepage.Text = My.Settings.varHomepage

        My.Settings.Save()
        fMain.loadVar()
    End Sub

    Private Sub bCurrentPage_Click(sender As Object, e As EventArgs) Handles bCurrentPage.Click
        My.Settings.varHomepage = fMain.tbSearch.Text
        tbHomepage.Text = My.Settings.varHomepage

        My.Settings.Save()
        fMain.loadVar()
    End Sub

    Private Sub bChangePassword_Click(sender As Object, e As EventArgs) Handles bChangePassword.Click
        If My.Settings.varPassword = "" Then
            If tbOldPassword.Text = tbNewPassword.Text Then
                My.Settings.varPassword = tbNewPassword.Text
                txtOldPassword.Text = "Old Password"
                txtNewPassword.Text = "New Password"
                tbOldPassword.Text = ""
                tbNewPassword.Text = ""
            Else
                MessageBox.Show("Passwords do not match.", "Notice")
            End If
        ElseIf My.Settings.varPassword = tbOldPassword.Text Then
            My.Settings.varPassword = tbNewPassword.Text
            tbOldPassword.Text = ""
            tbNewPassword.Text = ""
        Else
            MessageBox.Show("Incorrect password.", "Notice")
        End If

        My.Settings.Save()
        Me.Refresh()
    End Sub

    'comboboxes

    Private Sub comboTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTheme.SelectedIndexChanged
        If comboTheme.SelectedItem = "Light" Then
            My.Settings.themeLight = True
            My.Settings.themeDark = False
        Else
            My.Settings.themeLight = False
            My.Settings.themeDark = True
        End If

        My.Settings.Save()
        fMain.loadTheme()
    End Sub

    Private Sub comboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSearch.SelectedIndexChanged
        If comboSearch.SelectedItem = "Bing" Then
            My.Settings.searchGoogle = False
            My.Settings.searchBing = True
            My.Settings.searchYoutube = False
        ElseIf comboSearch.SelectedItem = "YouTube" Then
            My.Settings.searchGoogle = False
            My.Settings.searchBing = False
            My.Settings.searchYoutube = True
        Else
            My.Settings.searchGoogle = True
            My.Settings.searchBing = False
            My.Settings.searchYoutube = False
        End If

        My.Settings.Save()
        fMain.loadVar()
    End Sub

    'checkboxes

    Private Sub cbTopSearchBar_CheckedChanged(sender As Object, e As EventArgs) Handles cbTopSearchBar.CheckedChanged
        If cbTopSearchBar.Checked = True Then
            My.Settings.varTopSearch = True
        Else
            My.Settings.varTopSearch = False
        End If

        My.Settings.Save()
        fMain.loadVar()
    End Sub

    Private Sub cbStartLocked_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartLocked.CheckedChanged
        If cbStartLocked.Checked = True Then
            My.Settings.varStartLocked = True
        Else
            My.Settings.varStartLocked = False
        End If
    End Sub

    'textboxes

    Private Sub tbHomepage_KeyDown(sender As Object, e As KeyEventArgs) Handles tbHomepage.KeyDown
        If e.KeyCode = Keys.Enter Then
            bSetHomepage.PerformClick()
        End If
    End Sub

    Private Sub tbNewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNewPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            bChangePassword.PerformClick()
        End If
    End Sub
End Class