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

'Latest source code for this project can be found at http://mellowdev.net

Public Class fMain
    Dim tab As Integer = 0

    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.varHideWelcome = False Then
            fWelcome.Show()
            fWelcome.WindowState = FormWindowState.Normal
            fWelcome.BringToFront()
        Else
            Me.Opacity = 0
        End If

        loadTabAdd()
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.dataHome)

        If My.Computer.Network.IsAvailable = False Then
            Me.Text = "lemon | offline"
        End If

        tbNav.Focus()

        loadBookmarks()
        loadFavicon()
        loadHistory()
        loadMemory()
        loadVar()

        Me.Opacity = 100
    End Sub

    Friend Sub loadBookmarks()
        listBookmarks.Items.Clear()

        For Each Item As String In My.Settings.dataBookmarks
            listBookmarks.Items.Add(Item)
        Next
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
            Me.picFavicon.SizeMode = PictureBoxSizeMode.StretchImage
        End Try
    End Sub

    Friend Sub loadHistory()
        listHistory.Items.Clear()

        For Each Item As String In My.Settings.dataHistory
            listHistory.Items.Add(Item)
        Next
    End Sub

    Friend Sub loadMemory()
        For Each Item As String In My.Settings.dataMemory
            tbNav.AutoCompleteCustomSource.Add(Item)
        Next
    End Sub

    Friend Sub loadTabAdd()
        Dim browser As New WebBrowser

        tcWeb.TabPages.Add("New Tab")
        tcWeb.SelectTab(tab)
        browser.Dock = DockStyle.Fill
        tcWeb.SelectedTab.Controls.Add(browser)
        AddHandler browser.DocumentCompleted, AddressOf loadComplete
        tab = tab + 1
    End Sub

    Friend Sub loadTabRemove()
        If Not tcWeb.TabPages.Count = 1 Then
            tcWeb.TabPages.RemoveAt(tcWeb.SelectedIndex)
            tcWeb.SelectTab(tcWeb.TabPages.Count - 1)
            tab = tab - 1
        End If
    End Sub

    Friend Sub loadVar()
        iVersion.Text = My.Application.Info.Version.ToString

        If My.Settings.varTopNav = True Then
            tcWeb.Alignment = TabAlignment.Top
            pNav.Dock = DockStyle.Top
        Else
            tcWeb.Alignment = TabAlignment.Bottom
            pNav.Dock = DockStyle.Bottom
        End If

        My.Settings.Save()
    End Sub

    Private Sub loadComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        If My.Settings.dataBookmarks.Contains(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle) Then
            bBookmark.BackgroundImage = My.Resources.bookmark
        End If

        Try
            tcWeb.SelectedTab.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Catch ex As Exception
        End Try

        If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
            bBack.BackgroundImage = My.Resources.back
            bBack.Enabled = True
        Else
            bBack.BackgroundImage = My.Resources.back_alt
            bBack.Enabled = False
        End If

        If CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
            bForward.BackgroundImage = My.Resources.forward
            bForward.Enabled = True
        Else
            bForward.BackgroundImage = My.Resources.forward_alt
            bForward.Enabled = False
        End If

        Try
            tbNav.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try

        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True

        loadFavicon()
    End Sub

    Private Sub fMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Me.Opacity = 0
        loadBookmarks()
        loadHistory()
        loadMemory()
    End Sub

    Private Sub bMenu_Click(sender As Object, e As EventArgs) Handles bMenu.Click
        If pApps.Visible = True Then
            listBookmarks.Visible = False
            listHistory.Visible = False
            pApps.Visible = False
        Else
            pApps.Height = 200
            listBookmarks.Visible = False
            listHistory.Visible = False
            pApps.Visible = True
        End If
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        tcWeb.SelectedTab.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).GoBack
    End Sub

    Private Sub bForward_Click(sender As Object, e As EventArgs) Handles bForward.Click
        tcWeb.SelectedTab.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).GoForward
    End Sub

    Private Sub bNav_Click(sender As Object, e As EventArgs) Handles bNav.Click
        For Each Item As String In My.Settings.dataDomains
            If tbNav.Text.Contains(Item) Then
                My.Settings.varGoogle = False
            End If
        Next

        If My.Settings.varGoogle = True Then
            CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?hl=en&q=" & tbNav.Text & "&btnG=Google+Search&meta=")
        Else
            Try
                CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tbNav.Text)
            Catch
                CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?hl=en&q=" & tbNav.Text & "&btnG=Google+Search&meta=")
            End Try
        End If

        tbNav.AutoCompleteCustomSource.Add(tbNav.Text)
        listHistory.Items.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)

        My.Settings.dataHistory.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.dataMemory.Add(tbNav.Text)
        My.Settings.varGoogle = True
    End Sub

    Private Sub bBookmark_Click(sender As Object, e As EventArgs) Handles bBookmark.Click
        If Not My.Settings.dataBookmarks.Contains(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle) Then
            bBookmark.BackgroundImage = My.Resources.bookmark

            listBookmarks.Items.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)

            My.Settings.dataBookmarks.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
            My.Settings.dataUrl.Add(CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            My.Settings.Save()
        End If
    End Sub

    Private Sub bAddTab_Click(sender As Object, e As EventArgs) Handles bAddTab.Click
        loadTabAdd()
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.dataHome)
    End Sub

    Private Sub bRemoveTab_Click(sender As Object, e As EventArgs) Handles bRemoveTab.Click
        loadTabRemove()
    End Sub

    Private Sub bPrintPreview_Click(sender As Object, e As EventArgs) Handles bPrintPreview.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub bLock_Click(sender As Object, e As EventArgs) Handles bLock.Click
        fWelcome.Show()
        fWelcome.WindowState = FormWindowState.Normal
        fWelcome.BringToFront()
    End Sub

    Private Sub bOptions_Click(sender As Object, e As EventArgs) Handles bOptions.Click
        fOptions.Show()
        fOptions.WindowState = FormWindowState.Normal
        fOptions.BringToFront()
    End Sub

    Private Sub bScreenshot_Click(sender As Object, e As EventArgs) Handles bScreenshot.Click
        fScreenshot.Show()
        fScreenshot.WindowState = FormWindowState.Normal
        fScreenshot.BringToFront()
    End Sub

    Private Sub bNotes_Click(sender As Object, e As EventArgs) Handles bNotes.Click
        fNotes.Show()
        fNotes.WindowState = FormWindowState.Normal
        fNotes.BringToFront()
    End Sub

    Private Sub bFullscreen_Click(sender As Object, e As EventArgs) Handles bFullscreen.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            bFullscreen.BackgroundImage = My.Resources.collapse
        Else
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Maximized
            bFullscreen.BackgroundImage = My.Resources.expand
        End If
    End Sub

    Private Sub bBookmarks_Click(sender As Object, e As EventArgs) Handles bBookmarks.Click
        pApps.Height = 400
        listBookmarks.Visible = True
        listBookmarks.BringToFront()
    End Sub

    Private Sub bHistory_Click(sender As Object, e As EventArgs) Handles bHistory.Click
        pApps.Height = 400
        listHistory.Visible = True
        listHistory.BringToFront()
    End Sub

    Private Sub bShare_Click(sender As Object, e As EventArgs) Handles bShare.Click
        '
        ' TODO
        '
    End Sub

    Private Sub bOffline_Click(sender As Object, e As EventArgs) Handles bOffline.Click
        'Dim images As HtmlElementCollection = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Document.GetElementsByTagName("img")

        'For Each element As HtmlElement In images
        '    element.GetAttribute("src")
        'Next
    End Sub

    Private Sub iClose_Click(sender As Object, e As EventArgs) Handles iClose.Click
        bMenu.PerformClick()
    End Sub

    Private Sub tbNav_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNav.KeyDown
        If e.KeyCode = Keys.Enter Then
            bNav.PerformClick()
        End If
    End Sub

    Private Sub tbNav_DoubleClick(sender As Object, e As EventArgs) Handles tbNav.DoubleClick
        tbNav.SelectAll()
    End Sub

    Private Sub tbNav_TextChanged(sender As Object, e As EventArgs) Handles tbNav.TextChanged
        pApps.Visible = False
    End Sub

    Private Sub picFavicon_Click(sender As Object, e As EventArgs) Handles picFavicon.Click
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub listBookmarks_DoubleClick(sender As Object, e As EventArgs) Handles listBookmarks.DoubleClick
        loadTabAdd()
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.dataUrl(listBookmarks.SelectedIndex))
        pApps.Visible = False
    End Sub

    Private Sub listHistory_DoubleClick(sender As Object, e As EventArgs) Handles listHistory.DoubleClick
        loadTabAdd()
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(listHistory.SelectedItem)
        pApps.Visible = False
    End Sub

    Private Sub tcWeb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcWeb.SelectedIndexChanged
        Try
            tcWeb.SelectedTab.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Catch ex As Exception
        End Try

        Try
            tbNav.Text = CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try

        loadFavicon()
    End Sub

    Private Sub tcWeb_DoubleClick(sender As Object, e As EventArgs) Handles tcWeb.DoubleClick
        loadTabAdd()
        CType(tcWeb.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.dataHome)
    End Sub

    Private Sub tcWeb_MouseUp(sender As Object, e As MouseEventArgs) Handles tcWeb.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                For tabIndex As Integer = 0 To tcWeb.TabCount - 1
                    If tcWeb.GetTabRect(tabIndex).Contains(e.Location) Then
                        tcWeb.SelectTab(tabIndex)
                    End If
                Next

                loadTabRemove()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pApps_Leave(sender As Object, e As EventArgs) Handles pApps.Leave
        pApps.Visible = False
    End Sub
End Class
