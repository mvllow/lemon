'Copyright 2013 Tate Kwiecinski

'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at

'       http://www.apache.org/licenses/LICENSE-2.0

'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.

'The source for this project is free for anyone.  You may not redistribute
'this package or any modified application of this project without permission
'from the owner, Tate Kwiecinski.  To contact me, please visit http://mellowdev.net

Imports System.Environment

Public Class fMain
    Dim tab As Integer = 0

    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.varStartLocked = True Then
            Me.Opacity = 0
        End If

        Dim browser As New WebBrowser

        tcWeb.TabPages.Add("New Tab")
        tcWeb.SelectTab(tab)
        browser.Dock = DockStyle.Fill
        tcWeb.SelectedTab.Controls.Add(browser)
        AddHandler browser.DocumentCompleted, AddressOf loadComplete
        tab = tab + 1

        browser.Navigate(My.Settings.varHomepage)
        browser.ScriptErrorsSuppressed = True

        If My.Settings.varFullscreen = True Then
            pSearch.Hide()
        End If
        If My.Settings.varStartLocked = True Then
            bLock.PerformClick()
        End If

        loadVar()
        loadTheme()
        loadBookmarks()
        loadCache()
    End Sub

    Private Sub fMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If My.Settings.autoClear = True Then
            My.Settings.varHistory.Clear()
            My.Settings.autoComplete.Clear()
            My.Settings.Save()
        End If
    End Sub

    Private Sub pHover_MouseEnter(sender As Object, e As System.EventArgs) Handles pHover.MouseEnter
        If My.Settings.varFullscreen = True Then
            pSearch.Show()
            pMenu.Show()
        End If
    End Sub

    Private Sub pSearch_MouseEnter(sender As Object, e As System.EventArgs) Handles pSearch.MouseEnter
        If Not My.Settings.varFullscreen = True Then
            If pMenu.Visible = False Then
                pMenu.Visible = True
            End If
        End If
    End Sub

    Private Sub pMenu_MouseLeave(sender As Object, e As System.EventArgs) Handles pMenu.MouseLeave
        If Not My.Settings.varFullscreen = True Then
            If My.Settings.autoHideMenu = True Then
                pMenu.Visible = False
            End If
        Else
            If Not Me.ClientRectangle.Contains(pMenu.PointToClient(Windows.Forms.Cursor.Position)) Then
                pMenu.Visible = False
                pSearch.Hide()
            End If
        End If
    End Sub

    Private Sub loadComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        Try
            tcWeb.SelectedTab.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Catch ex As Exception
        End Try
        If My.Settings.themeDark = True Then
            If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                bWebBack.BackgroundImage = My.Resources.back_light
            Else
                bWebBack.BackgroundImage = My.Resources.back_dark
            End If
            If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                bWebForward.BackgroundImage = My.Resources.forward_light
            Else
                bWebForward.BackgroundImage = My.Resources.forward_dark
            End If
            If My.Settings.varBookmark.Contains(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle) Then
                bBookmark.BackgroundImage = My.Resources.bookmark_light
            Else
                bBookmark.BackgroundImage = My.Resources.star_light
            End If
        Else
            If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                bWebBack.BackgroundImage = My.Resources.back_dark
            Else
                bWebBack.BackgroundImage = My.Resources.back_light
            End If
            If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                bWebForward.BackgroundImage = My.Resources.forward_dark
            Else
                bWebForward.BackgroundImage = My.Resources.forward_light
            End If
            If My.Settings.varBookmark.Contains(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle) Then
                bBookmark.BackgroundImage = My.Resources.bookmark_dark
            Else
                bBookmark.BackgroundImage = My.Resources.star_dark
            End If
        End If
        Try
            tbSearch.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

        loadFavicon()
    End Sub

    'friend subs

    Friend Sub loadVar()
        For Each Item As String In My.Settings.varHistory
            fHistory.listHistory.Items.Clear()
            fHistory.listHistory.Items.Add(Item)
        Next
        For Each Item As String In My.Settings.autoComplete
            tbSearch.AutoCompleteCustomSource.Add(Item)
        Next
        If My.Settings.varTopSearch = True Then
            tcWeb.Alignment = TabAlignment.Top
            pMenu.Dock = DockStyle.Top
            pSearch.Dock = DockStyle.Top
            pHover.Dock = DockStyle.Top
        Else
            tcWeb.Alignment = TabAlignment.Bottom
            pMenu.Dock = DockStyle.Bottom
            pSearch.Dock = DockStyle.Bottom
            pHover.Dock = DockStyle.Bottom
        End If
        If My.Settings.autoLock = True And My.Settings.autoClear = True Then
            Me.Text = "Lemon | Auto Lock | Incognito"
        Else
            If My.Settings.autoLock = True Then
                timerAutoLock.Enabled = True
                Me.Text = "Lemon | Auto Lock"
            ElseIf My.Settings.autoClear = True Then
                timerAutoLock.Enabled = False
                Me.Text = "Lemon | Incognito"
            Else
                Me.Text = "Lemon"
            End If
        End If

        My.Settings.Save()
    End Sub

    Friend Sub loadTheme()
        Dim dark = Color.FromArgb(64, 64, 64)
        Dim gray = Color.DimGray
        Dim white = Color.White
        Dim blue = Color.LightSkyBlue
        Dim purple = Color.DarkViolet
        Dim light = Color.Gainsboro
        Dim silver = Color.Silver

        If My.Settings.themeDark = True Then

            'fMain

            Me.BackColor = gray
            Me.ForeColor = white

            pSearch.BackColor = dark
            pSearch.ForeColor = white
            pMenu.BackColor = dark
            pMenu.ForeColor = white

            iFile.ForeColor = white
            iTools.ForeColor = white
            iView.ForeColor = white

            fav0.ForeColor = blue
            fav1.ForeColor = blue
            fav2.ForeColor = blue
            fav3.ForeColor = blue
            fav4.ForeColor = blue
            fav5.ForeColor = blue
            fav6.ForeColor = blue
            fav7.ForeColor = blue
            fav8.ForeColor = blue
            fav9.ForeColor = blue

            bWebBack.BackgroundImage = My.Resources.back_light
            bWebBack.ForeColor = dark
            bWebForward.BackgroundImage = My.Resources.forward_light
            bWebForward.ForeColor = dark
            bSearch.BackgroundImage = My.Resources.search_light
            bSearch.BackColor = gray
            bSearch.ForeColor = gray
            bBookmark.BackgroundImage = My.Resources.bookmark_light
            bBookmark.BackColor = gray
            bBookmark.ForeColor = gray
            bLock.BackgroundImage = My.Resources.lock_light
            bLock.ForeColor = dark

            tbSearch.BackColor = gray
            tbSearch.ForeColor = white

            picFavicon.BackColor = gray

            'fSplash

            fSplash.BackColor = dark
            fSplash.ForeColor = white

            'fScreenshot

            fScreenshot.BackColor = dark
            fScreenshot.ForeColor = white

            fScreenshot.picScreenshot.BackColor = gray

            fScreenshot.bScreenshot.BackgroundImage = My.Resources.camera_light
            fScreenshot.bScreenshot.ForeColor = dark
            fScreenshot.bShare.BackgroundImage = My.Resources.share_light
            fScreenshot.bShare.ForeColor = dark
            fScreenshot.bSave.BackgroundImage = My.Resources.save_light
            fScreenshot.bSave.ForeColor = dark

            'fNotepad

            fNotepad.BackColor = dark
            fNotepad.ForeColor = white

            fNotepad.tbNotes.BackColor = gray
            fNotepad.tbNotes.ForeColor = white

            'fLogin

            fLogin.BackColor = dark
            fLogin.ForeColor = white

            fLogin.bClose.BackgroundImage = My.Resources.cancel_light
            fLogin.bClose.ForeColor = dark
            fLogin.bMinimize.BackgroundImage = My.Resources.minimize_light
            fLogin.bMinimize.ForeColor = dark
            fLogin.bUser.Image = My.Resources.user_light
            fLogin.bUser.ForeColor = light
            fLogin.bGuest.Image = My.Resources.user_light
            fLogin.bGuest.ForeColor = light
            fLogin.bIncognito.Image = My.Resources.user_light
            fLogin.bIncognito.ForeColor = light
            fLogin.bUnlock.BackgroundImage = My.Resources.user_light
            fLogin.bUnlock.ForeColor = dark

            fLogin.tbPassword.BackColor = dark
            fLogin.tbPassword.ForeColor = white

            'fHistory

            fHistory.BackColor = dark
            fHistory.ForeColor = white

            fHistory.cbAutoClear.ForeColor = white
            fHistory.cbAutoLock.ForeColor = white

            fHistory.txtAutoClear.ForeColor = white
            fHistory.txtAutoLock.ForeColor = white

            fHistory.listHistory.BackColor = dark
            fHistory.listHistory.ForeColor = white

            'fDownloads

            fDownloads.BackColor = dark
            fDownloads.ForeColor = white

            'fBookmarks

            fBookmarks.BackColor = dark
            fBookmarks.ForeColor = white

            fBookmarks.txtName.ForeColor = white
            fBookmarks.txtUrl.ForeColor = white

            fBookmarks.tbName.BackColor = gray
            fBookmarks.tbName.ForeColor = white
            fBookmarks.tbUrl.BackColor = gray
            fBookmarks.tbUrl.ForeColor = white

            fBookmarks.bAdd.BackgroundImage = My.Resources.add_light
            fBookmarks.bAdd.ForeColor = dark

            fBookmarks.listBookmarks.BackColor = dark
            fBookmarks.listBookmarks.ForeColor = white

            'fOptions

            fOptions.BackColor = dark
            fOptions.ForeColor = white

            fOptions.txtHomepage.ForeColor = white
            fOptions.txtNewPassword.ForeColor = white
            fOptions.txtOldPassword.ForeColor = white
            fOptions.txtSearchEngine.ForeColor = white
            fOptions.txtTheme.ForeColor = white

            fOptions.tbHomepage.BackColor = gray
            fOptions.tbHomepage.ForeColor = white
            fOptions.tbNewPassword.BackColor = gray
            fOptions.tbNewPassword.ForeColor = white
            fOptions.tbOldPassword.BackColor = gray
            fOptions.tbOldPassword.ForeColor = white

            fOptions.bSetHomepage.BackgroundImage = My.Resources.accept_light
            fOptions.bSetHomepage.ForeColor = dark
            fOptions.bCurrentPage.ForeColor = white
            fOptions.bChangePassword.BackgroundImage = My.Resources.accept_light
            fOptions.bChangePassword.ForeColor = dark

            fOptions.comboTheme.BackColor = gray
            fOptions.comboTheme.ForeColor = white
            fOptions.comboSearch.BackColor = gray
            fOptions.comboSearch.ForeColor = white

            fOptions.gbPreferences.ForeColor = white

            fOptions.cbTopSearchBar.ForeColor = white
            fOptions.cbEarlyReleases.ForeColor = white
            fOptions.cbStartLocked.ForeColor = white
        End If

        If My.Settings.themeLight = True Then

            'fMain

            Me.BackColor = silver
            Me.ForeColor = dark

            pSearch.BackColor = light
            pSearch.ForeColor = dark
            pMenu.BackColor = light
            pMenu.ForeColor = dark

            iFile.ForeColor = dark
            iTools.ForeColor = dark
            iView.ForeColor = dark

            fav0.ForeColor = purple
            fav1.ForeColor = purple
            fav2.ForeColor = purple
            fav3.ForeColor = purple
            fav4.ForeColor = purple
            fav5.ForeColor = purple
            fav6.ForeColor = purple
            fav7.ForeColor = purple
            fav8.ForeColor = purple
            fav9.ForeColor = purple

            bWebBack.BackgroundImage = My.Resources.back_dark
            bWebBack.ForeColor = light
            bWebForward.BackgroundImage = My.Resources.forward_dark
            bWebForward.ForeColor = light
            bSearch.BackgroundImage = My.Resources.search_dark
            bSearch.BackColor = silver
            bSearch.ForeColor = silver
            bBookmark.BackgroundImage = My.Resources.bookmark_dark
            bBookmark.BackColor = silver
            bBookmark.ForeColor = silver
            bLock.BackgroundImage = My.Resources.lock_dark
            bLock.ForeColor = light

            tbSearch.BackColor = silver
            tbSearch.ForeColor = dark

            picFavicon.BackColor = silver

            'fSplash

            fSplash.BackColor = light
            fSplash.ForeColor = dark

            'fScreenshot

            fScreenshot.BackColor = light
            fScreenshot.ForeColor = dark

            fScreenshot.picScreenshot.BackColor = silver

            fScreenshot.bScreenshot.BackgroundImage = My.Resources.camera_dark
            fScreenshot.bScreenshot.ForeColor = light
            fScreenshot.bShare.BackgroundImage = My.Resources.share_dark
            fScreenshot.bShare.ForeColor = light
            fScreenshot.bSave.BackgroundImage = My.Resources.save_dark
            fScreenshot.bSave.ForeColor = light

            'fNotepad

            fNotepad.BackColor = light
            fNotepad.ForeColor = dark

            fNotepad.tbNotes.BackColor = light
            fNotepad.tbNotes.ForeColor = dark

            'fLogin

            fLogin.BackColor = light
            fLogin.ForeColor = dark

            fLogin.bClose.BackgroundImage = My.Resources.cancel_dark
            fLogin.bClose.ForeColor = light
            fLogin.bMinimize.BackgroundImage = My.Resources.minimize_dark
            fLogin.bMinimize.ForeColor = light
            fLogin.bUser.Image = My.Resources.user_dark
            fLogin.bUser.ForeColor = dark
            fLogin.bGuest.Image = My.Resources.user_dark
            fLogin.bGuest.ForeColor = dark
            fLogin.bIncognito.Image = My.Resources.user_dark
            fLogin.bIncognito.ForeColor = dark
            fLogin.bUnlock.BackgroundImage = My.Resources.user_dark
            fLogin.bUnlock.ForeColor = light

            fLogin.tbPassword.BackColor = light
            fLogin.tbPassword.ForeColor = dark

            'fHistory

            fHistory.BackColor = light
            fHistory.ForeColor = dark

            fHistory.cbAutoClear.ForeColor = dark
            fHistory.cbAutoLock.ForeColor = dark

            fHistory.txtAutoClear.ForeColor = dark
            fHistory.txtAutoLock.ForeColor = dark

            fHistory.listHistory.BackColor = light
            fHistory.listHistory.ForeColor = dark

            'fDownloads

            fDownloads.BackColor = light
            fDownloads.ForeColor = dark

            'fBookmarks

            fBookmarks.BackColor = light
            fBookmarks.ForeColor = dark

            fBookmarks.txtName.ForeColor = dark
            fBookmarks.txtUrl.ForeColor = dark

            fBookmarks.tbName.BackColor = silver
            fBookmarks.tbName.ForeColor = dark
            fBookmarks.tbUrl.BackColor = silver
            fBookmarks.tbUrl.ForeColor = dark

            fBookmarks.bAdd.BackgroundImage = My.Resources.add_dark
            fBookmarks.bAdd.ForeColor = light

            fBookmarks.listBookmarks.BackColor = light
            fBookmarks.listBookmarks.ForeColor = dark

            'fOptions

            fOptions.BackColor = light
            fOptions.ForeColor = dark

            fOptions.txtHomepage.ForeColor = dark
            fOptions.txtNewPassword.ForeColor = dark
            fOptions.txtOldPassword.ForeColor = dark
            fOptions.txtSearchEngine.ForeColor = dark
            fOptions.txtTheme.ForeColor = dark

            fOptions.tbHomepage.BackColor = silver
            fOptions.tbHomepage.ForeColor = dark
            fOptions.tbNewPassword.BackColor = silver
            fOptions.tbNewPassword.ForeColor = dark
            fOptions.tbOldPassword.BackColor = silver
            fOptions.tbOldPassword.ForeColor = dark

            fOptions.bSetHomepage.BackgroundImage = My.Resources.accept_dark
            fOptions.bSetHomepage.ForeColor = light
            fOptions.bCurrentPage.ForeColor = dark
            fOptions.bChangePassword.BackgroundImage = My.Resources.accept_dark
            fOptions.bChangePassword.ForeColor = light

            fOptions.comboTheme.BackColor = silver
            fOptions.comboTheme.ForeColor = dark
            fOptions.comboSearch.BackColor = silver
            fOptions.comboSearch.ForeColor = dark

            fOptions.gbPreferences.ForeColor = dark

            fOptions.cbTopSearchBar.ForeColor = dark
            fOptions.cbEarlyReleases.ForeColor = dark
            fOptions.cbStartLocked.ForeColor = dark
        End If
    End Sub

    Friend Sub loadFavicon()
        Try
            Dim webpageUrl As Uri = New Uri(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)

            If webpageUrl.HostNameType = UriHostNameType.Dns Then
                Dim icons = "http://" & webpageUrl.Host & "/favicon.ico"
                Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
                Dim res As System.Net.HttpWebResponse = req.GetResponse()
                Dim stream As System.IO.Stream = res.GetResponseStream()
                Dim favicon = Image.FromStream(stream)

                picFavicon.Image = favicon
                Me.picFavicon.SizeMode = PictureBoxSizeMode.CenterImage
            End If
        Catch
            picFavicon.Image = My.Resources.favicon
            Me.picFavicon.SizeMode = PictureBoxSizeMode.CenterImage
        End Try
    End Sub

    Friend Sub loadNewTab()
        Dim browser As New WebBrowser

        tcWeb.TabPages.Add("New Tab")
        tcWeb.SelectTab(tab)
        browser.Dock = DockStyle.Fill
        tcWeb.SelectedTab.Controls.Add(browser)
        AddHandler browser.DocumentCompleted, AddressOf loadComplete
        tab = tab + 1
    End Sub

    Friend Sub loadRemoveTab()
        If Not tcWeb.TabPages.Count = 1 Then
            tcWeb.TabPages.RemoveAt(tcWeb.SelectedIndex)
            tcWeb.SelectTab(tcWeb.TabPages.Count - 1)
            tab = tab - 1
        End If
    End Sub

    Friend Sub loadBookmarks()
        fBookmarks.listBookmarks.Items.Clear()

        For Each Item As String In My.Settings.varBookmark
            fBookmarks.listBookmarks.Items.Add(Item)
        Next

        Try
            fav0.Visible = True
            fav0.Text = My.Settings.varBookmark.Item(0)
        Catch
            fav0.Visible = False
        End Try
        Try
            fav1.Visible = True
            fav1.Text = My.Settings.varBookmark.Item(1)
        Catch
            fav1.Visible = False
        End Try
        Try
            fav2.Visible = True
            fav2.Text = My.Settings.varBookmark.Item(2)
        Catch
            fav2.Visible = False
        End Try
        Try
            fav3.Visible = True
            fav3.Text = My.Settings.varBookmark.Item(3)
        Catch
            fav3.Visible = False
        End Try
        Try
            fav4.Visible = True
            fav4.Text = My.Settings.varBookmark.Item(4)
        Catch
            fav4.Visible = False
        End Try
        Try
            fav5.Visible = True
            fav5.Text = My.Settings.varBookmark.Item(5)
        Catch
            fav5.Visible = False
        End Try
        Try
            fav6.Visible = True
            fav6.Text = My.Settings.varBookmark.Item(6)
        Catch
            fav6.Visible = False
        End Try
        Try
            fav7.Visible = True
            fav7.Text = My.Settings.varBookmark.Item(7)
        Catch
            fav7.Visible = False
        End Try
        Try
            fav8.Visible = True
            fav8.Text = My.Settings.varBookmark.Item(8)
        Catch
            fav8.Visible = False
        End Try
        Try
            fav9.Visible = True
            fav9.Text = My.Settings.varBookmark.Item(9)
        Catch
            fav9.Visible = False
        End Try
    End Sub

    Friend Sub loadCache()
        If My.Settings.cache = False Then
            MessageBox.Show("Welcome to Lemon!  Just a quick tip, version 1.0 includes many visual enhancements.  To clean up the interface, some options have been hidden.  You may see many extra options by right clicking on some items.  For any questions, please email me!", "Welcome")

            My.Settings.cache = True
            My.Settings.Save()
        End If
    End Sub

    'bookmarks

    Private Sub fav_Click(sender As Object, e As EventArgs) Handles fav0.Click, fav1.Click, fav2.Click, fav3.Click, fav4.Click, fav5.Click, fav6.Click, fav7.Click, fav8.Click, fav9.Click
        Dim selectedFav As ToolStripMenuItem

        selectedFav = CType(sender, ToolStripMenuItem)

        If selectedFav.Equals(fav0) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(0))
            tbSearch.Text = My.Settings.varUrl.Item(0)
        ElseIf selectedFav.Equals(fav1) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(1))
            tbSearch.Text = My.Settings.varUrl.Item(1)
        ElseIf selectedFav.Equals(fav2) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(2))
            tbSearch.Text = My.Settings.varUrl.Item(2)
        ElseIf selectedFav.Equals(fav3) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(3))
            tbSearch.Text = My.Settings.varUrl.Item(3)
        ElseIf selectedFav.Equals(fav4) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(4))
            tbSearch.Text = My.Settings.varUrl.Item(4)
        ElseIf selectedFav.Equals(fav5) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(5))
            tbSearch.Text = My.Settings.varUrl.Item(5)
        ElseIf selectedFav.Equals(fav6) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(6))
            tbSearch.Text = My.Settings.varUrl.Item(6)
        ElseIf selectedFav.Equals(fav7) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(7))
            tbSearch.Text = My.Settings.varUrl.Item(7)
        ElseIf selectedFav.Equals(fav8) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(8))
            tbSearch.Text = My.Settings.varUrl.Item(8)
        ElseIf selectedFav.Equals(fav9) Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(9))
            tbSearch.Text = My.Settings.varUrl.Item(9)
        End If
    End Sub

    Private Sub fav_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles fav0.MouseUp, fav1.MouseUp, fav2.MouseUp, fav3.MouseUp, fav4.MouseUp, fav5.MouseUp, fav6.MouseUp, fav7.MouseUp, fav8.MouseUp, fav9.MouseUp
        Dim selectedFav As ToolStripMenuItem

        selectedFav = CType(sender, ToolStripMenuItem)

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If selectedFav.Equals(fav0) Then
                My.Settings.varSelectedFav = "fav0"
            End If
            If selectedFav.Equals(fav1) Then
                My.Settings.varSelectedFav = "fav1"
            End If
            If selectedFav.Equals(fav2) Then
                My.Settings.varSelectedFav = "fav2"
            End If
            If selectedFav.Equals(fav3) Then
                My.Settings.varSelectedFav = "fav3"
            End If
            If selectedFav.Equals(fav4) Then
                My.Settings.varSelectedFav = "fav4"
            End If
            If selectedFav.Equals(fav5) Then
                My.Settings.varSelectedFav = "fav5"
            End If
            If selectedFav.Equals(fav6) Then
                My.Settings.varSelectedFav = "fav6"
            End If
            If selectedFav.Equals(fav7) Then
                My.Settings.varSelectedFav = "fav7"
            End If
            If selectedFav.Equals(fav8) Then
                My.Settings.varSelectedFav = "fav8"
            End If
            If selectedFav.Equals(fav9) Then
                My.Settings.varSelectedFav = "fav9"
            End If

            cmFav.Show(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
        End If

        My.Settings.Save()
    End Sub

    'menu items

    Private Sub iAddTab_Click(sender As Object, e As EventArgs) Handles iAddTab.Click
        loadNewTab()

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varHomepage)
    End Sub

    Private Sub iRemoveTab_Click(sender As Object, e As EventArgs) Handles iRemoveTab.Click
        loadRemoveTab()
    End Sub

    Private Sub iNewWindow_Click(sender As Object, e As EventArgs) Handles iNewWindow.Click
        Dim newWindow As New fMain

        newWindow.Show()
    End Sub

    Private Sub iLockWindow_Click(sender As Object, e As EventArgs) Handles iLockWindow.Click
        fLogin.Show()
        fLogin.WindowState = FormWindowState.Normal
        fLogin.BringToFront()
    End Sub

    Private Sub iPrint_Click(sender As Object, e As EventArgs) Handles iPrint.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub iPrintPreview_Click(sender As Object, e As EventArgs) Handles iPrintPreview.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub iPageSetup_Click(sender As Object, e As EventArgs) Handles iPageSetup.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub iProperties_Click(sender As Object, e As EventArgs) Handles iProperties.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub iExit_Click(sender As Object, e As EventArgs) Handles iExit.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub iNotepad_Click(sender As Object, e As EventArgs) Handles iNotepad.Click
        fNotepad.Show()
        fNotepad.WindowState = FormWindowState.Normal
        fNotepad.BringToFront()
    End Sub

    Private Sub iScreenshot_Click(sender As Object, e As EventArgs) Handles iScreenshot.Click
        fScreenshot.Show()
        fScreenshot.WindowState = FormWindowState.Normal
        fScreenshot.BringToFront()
    End Sub

    Private Sub iOptions_Click(sender As Object, e As EventArgs) Handles iOptions.Click
        fOptions.Show()
        fOptions.WindowState = FormWindowState.Normal
        fOptions.BringToFront()
    End Sub

    Private Sub iHistory_Click(sender As Object, e As EventArgs) Handles iHistory.Click
        fHistory.Show()
        fHistory.WindowState = FormWindowState.Normal
        fHistory.BringToFront()
    End Sub

    Private Sub iBookmarks_Click(sender As Object, e As EventArgs) Handles iBookmarks.Click
        fBookmarks.Show()
        fBookmarks.WindowState = FormWindowState.Normal
        fBookmarks.BringToFront()
    End Sub

    Private Sub iDownloads_Click(sender As Object, e As EventArgs) Handles iDownloads.Click
        fDownloads.Show()
        fDownloads.WindowState = FormWindowState.Normal
        fDownloads.BringToFront()
    End Sub

    Private Sub iHideMenu_Click(sender As Object, e As EventArgs) Handles iAutoHideMenu.Click
        If pMenu.Visible = True Then
            pMenu.Visible = False
            iAutoHideMenu.Checked = True

            My.Settings.autoHideMenu = True
            My.Settings.Save()
        Else
            pMenu.Visible = True
            iAutoHideMenu.Checked = False

            My.Settings.autoHideMenu = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub iFullscreen_Click(sender As Object, e As EventArgs) Handles iFullscreen.Click
        If pHover.Visible = False Then
            pSearch.Visible = False
            pMenu.Visible = False
            pHover.Visible = True
            iFullscreen.Checked = True

            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized

            My.Settings.varFullscreen = True
            My.Settings.Save()
        Else
            pSearch.Visible = True
            pMenu.Visible = True
            pHover.Visible = False
            iFullscreen.Checked = False

            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Maximized

            My.Settings.varFullscreen = False
            My.Settings.Save()
        End If
    End Sub

    'buttons

    Private Sub bWebBack_Click(sender As Object, e As EventArgs) Handles bWebBack.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub bWebForward_Click(sender As Object, e As EventArgs) Handles bWebForward.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        If tbSearch.Text = "#_debug" Then
            My.Settings.Reset()
            My.Settings.Save()

            Application.Exit()
        End If

        My.Settings.autoComplete.Add(tbSearch.Text)

        Try
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbSearch.Text)
        Catch
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbSearch.Text)
        End Try

        My.Settings.varHistory.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)

        loadVar()
    End Sub

    Private Sub bBookmark_Click(sender As Object, e As EventArgs) Handles bBookmark.Click
        If Not My.Settings.varBookmark.Contains(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle) Then
            If My.Settings.themeDark = True Then
                bBookmark.BackgroundImage = My.Resources.bookmark_light
            Else
                bBookmark.BackgroundImage = My.Resources.bookmark_dark
            End If

            My.Settings.varBookmark.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
            My.Settings.varUrl.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            My.Settings.Save()

            loadBookmarks()
        End If
    End Sub

    Private Sub bLock_Click(sender As Object, e As EventArgs) Handles bLock.Click
        fLogin.Show()
        fLogin.WindowState = FormWindowState.Normal
        fLogin.BringToFront()

        My.Settings.Save()
    End Sub

    'textboxes

    Private Sub tbSearch_DoubleClick(sender As Object, e As EventArgs) Handles tbSearch.DoubleClick
        tbSearch.SelectAll()
    End Sub

    Private Sub tbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            My.Settings.autoComplete.Add(tbSearch.Text)

            If tbSearch.Text.Contains("www.") Or tbSearch.Text.Contains(".com") Or tbSearch.Text.Contains(".net") Or tbSearch.Text.Contains(".org") Or tbSearch.Text.Contains(".edu") Then
                Try
                    CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbSearch.Text)
                Catch
                    CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbSearch.Text)
                End Try
            Else
                If My.Settings.searchBing = True Then
                    CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" & tbSearch.Text)
                ElseIf My.Settings.searchYoutube = True Then
                    CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.youtube.com/results?search_query=" & tbSearch.Text & "&aq=f")
                Else
                    CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?hl=en&q=" & tbSearch.Text & "&btnG=Google+Search&meta=")
                End If
            End If

            My.Settings.varHistory.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)

            loadVar()
        End If
    End Sub

    'picturebox

    Private Sub picFavicon_Click(sender As Object, e As EventArgs) Handles picFavicon.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    'tabcontrol

    Private Sub tcWeb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcWeb.SelectedIndexChanged
        Try
            tbSearch.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try

        loadFavicon()
    End Sub

    Private Sub tcWeb_MouseUp(sender As Object, e As MouseEventArgs) Handles tcWeb.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                For tabIndex As Integer = 0 To tcWeb.TabCount - 1
                    If tcWeb.GetTabRect(tabIndex).Contains(e.Location) Then
                        tcWeb.SelectTab(tabIndex)
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    'timers

    Private Sub timerAutoLock_Tick(sender As Object, e As EventArgs) Handles timerAutoLock.Tick
        bLock.PerformClick()
    End Sub

    'context menus

    Private Sub iOpenInNewTab_Click(sender As Object, e As EventArgs) Handles iOpenInNewTab.Click
        loadNewTab()

        If My.Settings.varSelectedFav = "fav0" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(0))
            tbSearch.Text = My.Settings.varUrl.Item(0)
        ElseIf My.Settings.varSelectedFav = "fav1" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(1))
            tbSearch.Text = My.Settings.varUrl.Item(1)
        ElseIf My.Settings.varSelectedFav = "fav2" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(2))
            tbSearch.Text = My.Settings.varUrl.Item(2)
        ElseIf My.Settings.varSelectedFav = "fav3" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(3))
            tbSearch.Text = My.Settings.varUrl.Item(3)
        ElseIf My.Settings.varSelectedFav = "fav4" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(4))
            tbSearch.Text = My.Settings.varUrl.Item(4)
        ElseIf My.Settings.varSelectedFav = "fav5" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(5))
            tbSearch.Text = My.Settings.varUrl.Item(5)
        ElseIf My.Settings.varSelectedFav = "fav6" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(6))
            tbSearch.Text = My.Settings.varUrl.Item(6)
        ElseIf My.Settings.varSelectedFav = "fav7" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(7))
            tbSearch.Text = My.Settings.varUrl.Item(7)
        ElseIf My.Settings.varSelectedFav = "fav8" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(8))
            tbSearch.Text = My.Settings.varUrl.Item(8)
        ElseIf My.Settings.varSelectedFav = "fav9" Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varUrl.Item(9))
            tbSearch.Text = My.Settings.varUrl.Item(9)
        End If
    End Sub

    Private Sub iBookmarksManager_Click(sender As Object, e As EventArgs) Handles iBookmarksManager.Click
        iBookmarks.PerformClick()
    End Sub

    Private Sub iSearchBing_Click(sender As Object, e As EventArgs) Handles iSearchBing.Click
        My.Settings.autoComplete.Add(tbSearch.Text)

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" & tbSearch.Text)
    End Sub

    Private Sub iSearchGoogle_Click(sender As Object, e As EventArgs) Handles iSearchGoogle.Click
        My.Settings.autoComplete.Add(tbSearch.Text)

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?hl=en&q=" & tbSearch.Text & "&btnG=Google+Search&meta=")
    End Sub

    Private Sub iSearchYoutube_Click(sender As Object, e As EventArgs) Handles iSearchYoutube.Click
        My.Settings.autoComplete.Add(tbSearch.Text)

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.youtube.com/results?search_query=" & tbSearch.Text & "&aq=f")
    End Sub

    Private Sub iNewTab_Click(sender As Object, e As EventArgs) Handles iNewTab.Click
        loadNewTab()

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.varHomepage)
    End Sub

    Private Sub iDeleteTab_Click(sender As Object, e As EventArgs) Handles iDeleteTab.Click
        loadRemoveTab()
    End Sub
End Class
