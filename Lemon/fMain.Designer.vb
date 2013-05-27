<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.pHover = New System.Windows.Forms.Panel()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.cmSearch = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iSearchBing = New System.Windows.Forms.ToolStripMenuItem()
        Me.iSearchGoogle = New System.Windows.Forms.ToolStripMenuItem()
        Me.iSearchYoutube = New System.Windows.Forms.ToolStripMenuItem()
        Me.pSearch = New System.Windows.Forms.Panel()
        Me.picFavicon = New System.Windows.Forms.PictureBox()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.bLock = New System.Windows.Forms.Button()
        Me.bBookmark = New System.Windows.Forms.Button()
        Me.bWebForward = New System.Windows.Forms.Button()
        Me.bWebBack = New System.Windows.Forms.Button()
        Me.tcWeb = New System.Windows.Forms.TabControl()
        Me.cmTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iNewTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.iDeleteTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.pMenu = New System.Windows.Forms.MenuStrip()
        Me.iFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.iAddTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.iRemoveTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.space1 = New System.Windows.Forms.ToolStripSeparator()
        Me.iNewWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.iLockWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.space2 = New System.Windows.Forms.ToolStripSeparator()
        Me.iPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.iPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.space3 = New System.Windows.Forms.ToolStripSeparator()
        Me.iPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.iProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.space4 = New System.Windows.Forms.ToolStripSeparator()
        Me.iExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.iTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.iNotepad = New System.Windows.Forms.ToolStripMenuItem()
        Me.iScreenshot = New System.Windows.Forms.ToolStripMenuItem()
        Me.space5 = New System.Windows.Forms.ToolStripSeparator()
        Me.iOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.iView = New System.Windows.Forms.ToolStripMenuItem()
        Me.iHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.iBookmarks = New System.Windows.Forms.ToolStripMenuItem()
        Me.iDownloads = New System.Windows.Forms.ToolStripMenuItem()
        Me.space6 = New System.Windows.Forms.ToolStripSeparator()
        Me.iAutoHideMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.iFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.fav9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmFav = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iOpenInNewTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.iBookmarksManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerAutoLock = New System.Windows.Forms.Timer(Me.components)
        Me.cmSearch.SuspendLayout()
        Me.pSearch.SuspendLayout()
        CType(Me.picFavicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmTab.SuspendLayout()
        Me.pMenu.SuspendLayout()
        Me.cmFav.SuspendLayout()
        Me.SuspendLayout()
        '
        'pHover
        '
        Me.pHover.BackColor = System.Drawing.Color.Transparent
        Me.pHover.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pHover.Location = New System.Drawing.Point(0, 760)
        Me.pHover.Name = "pHover"
        Me.pHover.Size = New System.Drawing.Size(1184, 1)
        Me.pHover.TabIndex = 1
        Me.pHover.Visible = False
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbSearch.BackColor = System.Drawing.Color.DimGray
        Me.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearch.ContextMenuStrip = Me.cmSearch
        Me.tbSearch.ForeColor = System.Drawing.Color.White
        Me.tbSearch.Location = New System.Drawing.Point(101, 8)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(998, 22)
        Me.tbSearch.TabIndex = 0
        '
        'cmSearch
        '
        Me.cmSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iSearchBing, Me.iSearchGoogle, Me.iSearchYoutube})
        Me.cmSearch.Name = "cmBookmarks"
        Me.cmSearch.Size = New System.Drawing.Size(198, 70)
        '
        'iSearchBing
        '
        Me.iSearchBing.Image = Global.Lemon.My.Resources.Resources.search_dark
        Me.iSearchBing.Name = "iSearchBing"
        Me.iSearchBing.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.iSearchBing.Size = New System.Drawing.Size(197, 22)
        Me.iSearchBing.Text = "Search Bing"
        '
        'iSearchGoogle
        '
        Me.iSearchGoogle.Image = Global.Lemon.My.Resources.Resources.search_dark
        Me.iSearchGoogle.Name = "iSearchGoogle"
        Me.iSearchGoogle.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.iSearchGoogle.Size = New System.Drawing.Size(197, 22)
        Me.iSearchGoogle.Text = "Search Google"
        '
        'iSearchYoutube
        '
        Me.iSearchYoutube.Image = Global.Lemon.My.Resources.Resources.search_dark
        Me.iSearchYoutube.Name = "iSearchYoutube"
        Me.iSearchYoutube.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.iSearchYoutube.Size = New System.Drawing.Size(197, 22)
        Me.iSearchYoutube.Text = "Search YouTube"
        '
        'pSearch
        '
        Me.pSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pSearch.Controls.Add(Me.picFavicon)
        Me.pSearch.Controls.Add(Me.bSearch)
        Me.pSearch.Controls.Add(Me.bLock)
        Me.pSearch.Controls.Add(Me.bBookmark)
        Me.pSearch.Controls.Add(Me.bWebForward)
        Me.pSearch.Controls.Add(Me.bWebBack)
        Me.pSearch.Controls.Add(Me.tbSearch)
        Me.pSearch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pSearch.Location = New System.Drawing.Point(0, 722)
        Me.pSearch.Name = "pSearch"
        Me.pSearch.Size = New System.Drawing.Size(1184, 38)
        Me.pSearch.TabIndex = 0
        '
        'picFavicon
        '
        Me.picFavicon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picFavicon.BackColor = System.Drawing.Color.DimGray
        Me.picFavicon.Location = New System.Drawing.Point(79, 8)
        Me.picFavicon.Name = "picFavicon"
        Me.picFavicon.Size = New System.Drawing.Size(22, 22)
        Me.picFavicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFavicon.TabIndex = 6
        Me.picFavicon.TabStop = False
        '
        'bSearch
        '
        Me.bSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bSearch.BackColor = System.Drawing.Color.DimGray
        Me.bSearch.BackgroundImage = Global.Lemon.My.Resources.Resources.search_light
        Me.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSearch.ForeColor = System.Drawing.Color.DimGray
        Me.bSearch.Location = New System.Drawing.Point(1099, 8)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(22, 22)
        Me.bSearch.TabIndex = 1
        Me.bSearch.UseVisualStyleBackColor = False
        '
        'bLock
        '
        Me.bLock.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bLock.BackgroundImage = Global.Lemon.My.Resources.Resources.lock_light
        Me.bLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bLock.Location = New System.Drawing.Point(1149, 3)
        Me.bLock.Name = "bLock"
        Me.bLock.Size = New System.Drawing.Size(32, 32)
        Me.bLock.TabIndex = 3
        Me.bLock.UseVisualStyleBackColor = True
        '
        'bBookmark
        '
        Me.bBookmark.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bBookmark.BackColor = System.Drawing.Color.DimGray
        Me.bBookmark.BackgroundImage = Global.Lemon.My.Resources.Resources.star_light
        Me.bBookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBookmark.ForeColor = System.Drawing.Color.DimGray
        Me.bBookmark.Location = New System.Drawing.Point(1121, 8)
        Me.bBookmark.Name = "bBookmark"
        Me.bBookmark.Size = New System.Drawing.Size(22, 22)
        Me.bBookmark.TabIndex = 2
        Me.bBookmark.UseVisualStyleBackColor = False
        '
        'bWebForward
        '
        Me.bWebForward.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bWebForward.BackgroundImage = Global.Lemon.My.Resources.Resources.forward_dark
        Me.bWebForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bWebForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWebForward.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bWebForward.Location = New System.Drawing.Point(41, 3)
        Me.bWebForward.Name = "bWebForward"
        Me.bWebForward.Size = New System.Drawing.Size(32, 32)
        Me.bWebForward.TabIndex = 5
        Me.bWebForward.UseVisualStyleBackColor = True
        '
        'bWebBack
        '
        Me.bWebBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bWebBack.BackgroundImage = Global.Lemon.My.Resources.Resources.back_dark
        Me.bWebBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bWebBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bWebBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bWebBack.Location = New System.Drawing.Point(3, 3)
        Me.bWebBack.Name = "bWebBack"
        Me.bWebBack.Size = New System.Drawing.Size(32, 32)
        Me.bWebBack.TabIndex = 4
        Me.bWebBack.UseVisualStyleBackColor = True
        '
        'tcWeb
        '
        Me.tcWeb.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tcWeb.ContextMenuStrip = Me.cmTab
        Me.tcWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcWeb.Location = New System.Drawing.Point(0, 0)
        Me.tcWeb.Name = "tcWeb"
        Me.tcWeb.SelectedIndex = 0
        Me.tcWeb.Size = New System.Drawing.Size(1184, 698)
        Me.tcWeb.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcWeb.TabIndex = 7
        '
        'cmTab
        '
        Me.cmTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iNewTab, Me.iDeleteTab})
        Me.cmTab.Name = "cmBookmarks"
        Me.cmTab.Size = New System.Drawing.Size(172, 48)
        '
        'iNewTab
        '
        Me.iNewTab.Image = Global.Lemon.My.Resources.Resources.add_dark
        Me.iNewTab.Name = "iNewTab"
        Me.iNewTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.iNewTab.Size = New System.Drawing.Size(171, 22)
        Me.iNewTab.Text = "New tab"
        '
        'iDeleteTab
        '
        Me.iDeleteTab.Image = Global.Lemon.My.Resources.Resources.minimize_dark
        Me.iDeleteTab.Name = "iDeleteTab"
        Me.iDeleteTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.iDeleteTab.Size = New System.Drawing.Size(171, 22)
        Me.iDeleteTab.Text = "Delete Tab"
        '
        'pMenu
        '
        Me.pMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iFile, Me.iTools, Me.iView, Me.fav0, Me.fav1, Me.fav2, Me.fav3, Me.fav4, Me.fav5, Me.fav6, Me.fav7, Me.fav8, Me.fav9})
        Me.pMenu.Location = New System.Drawing.Point(0, 698)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(1184, 24)
        Me.pMenu.TabIndex = 2
        '
        'iFile
        '
        Me.iFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iAddTab, Me.iRemoveTab, Me.space1, Me.iNewWindow, Me.iLockWindow, Me.space2, Me.iPrint, Me.iPrintPreview, Me.space3, Me.iPageSetup, Me.iProperties, Me.space4, Me.iExit})
        Me.iFile.ForeColor = System.Drawing.Color.White
        Me.iFile.Name = "iFile"
        Me.iFile.Size = New System.Drawing.Size(37, 20)
        Me.iFile.Text = "File"
        '
        'iAddTab
        '
        Me.iAddTab.Image = Global.Lemon.My.Resources.Resources.add_dark
        Me.iAddTab.Name = "iAddTab"
        Me.iAddTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.iAddTab.Size = New System.Drawing.Size(187, 22)
        Me.iAddTab.Text = "Add tab"
        '
        'iRemoveTab
        '
        Me.iRemoveTab.Image = Global.Lemon.My.Resources.Resources.minimize_dark
        Me.iRemoveTab.Name = "iRemoveTab"
        Me.iRemoveTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.iRemoveTab.Size = New System.Drawing.Size(187, 22)
        Me.iRemoveTab.Text = "Remove tab"
        '
        'space1
        '
        Me.space1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space1.Name = "space1"
        Me.space1.Size = New System.Drawing.Size(184, 6)
        '
        'iNewWindow
        '
        Me.iNewWindow.Image = Global.Lemon.My.Resources.Resources.new_dark
        Me.iNewWindow.Name = "iNewWindow"
        Me.iNewWindow.Size = New System.Drawing.Size(187, 22)
        Me.iNewWindow.Text = "New window"
        '
        'iLockWindow
        '
        Me.iLockWindow.Image = Global.Lemon.My.Resources.Resources.lock_dark
        Me.iLockWindow.Name = "iLockWindow"
        Me.iLockWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.iLockWindow.Size = New System.Drawing.Size(187, 22)
        Me.iLockWindow.Text = "Lock window"
        '
        'space2
        '
        Me.space2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space2.Name = "space2"
        Me.space2.Size = New System.Drawing.Size(184, 6)
        '
        'iPrint
        '
        Me.iPrint.Image = Global.Lemon.My.Resources.Resources.print_dark
        Me.iPrint.Name = "iPrint"
        Me.iPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.iPrint.Size = New System.Drawing.Size(187, 22)
        Me.iPrint.Text = "Print"
        '
        'iPrintPreview
        '
        Me.iPrintPreview.Image = Global.Lemon.My.Resources.Resources.preview_dark
        Me.iPrintPreview.Name = "iPrintPreview"
        Me.iPrintPreview.Size = New System.Drawing.Size(187, 22)
        Me.iPrintPreview.Text = "Print preview"
        '
        'space3
        '
        Me.space3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space3.Name = "space3"
        Me.space3.Size = New System.Drawing.Size(184, 6)
        '
        'iPageSetup
        '
        Me.iPageSetup.Image = Global.Lemon.My.Resources.Resources.setup_dark
        Me.iPageSetup.Name = "iPageSetup"
        Me.iPageSetup.Size = New System.Drawing.Size(187, 22)
        Me.iPageSetup.Text = "Page setup"
        '
        'iProperties
        '
        Me.iProperties.Image = Global.Lemon.My.Resources.Resources.properties_dark
        Me.iProperties.Name = "iProperties"
        Me.iProperties.Size = New System.Drawing.Size(187, 22)
        Me.iProperties.Text = "Properties"
        '
        'space4
        '
        Me.space4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space4.Name = "space4"
        Me.space4.Size = New System.Drawing.Size(184, 6)
        '
        'iExit
        '
        Me.iExit.Image = Global.Lemon.My.Resources.Resources.cancel_dark
        Me.iExit.Name = "iExit"
        Me.iExit.Size = New System.Drawing.Size(187, 22)
        Me.iExit.Text = "Exit"
        '
        'iTools
        '
        Me.iTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iNotepad, Me.iScreenshot, Me.space5, Me.iOptions})
        Me.iTools.ForeColor = System.Drawing.Color.White
        Me.iTools.Name = "iTools"
        Me.iTools.Size = New System.Drawing.Size(48, 20)
        Me.iTools.Text = "Tools"
        '
        'iNotepad
        '
        Me.iNotepad.Image = Global.Lemon.My.Resources.Resources.notes_dark
        Me.iNotepad.Name = "iNotepad"
        Me.iNotepad.Size = New System.Drawing.Size(132, 22)
        Me.iNotepad.Text = "Notepad"
        '
        'iScreenshot
        '
        Me.iScreenshot.Image = Global.Lemon.My.Resources.Resources.camera_dark
        Me.iScreenshot.Name = "iScreenshot"
        Me.iScreenshot.Size = New System.Drawing.Size(132, 22)
        Me.iScreenshot.Text = "Screenshot"
        '
        'space5
        '
        Me.space5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space5.Name = "space5"
        Me.space5.Size = New System.Drawing.Size(129, 6)
        '
        'iOptions
        '
        Me.iOptions.Image = Global.Lemon.My.Resources.Resources.settings_dark
        Me.iOptions.Name = "iOptions"
        Me.iOptions.Size = New System.Drawing.Size(132, 22)
        Me.iOptions.Text = "Options"
        '
        'iView
        '
        Me.iView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iHistory, Me.iBookmarks, Me.iDownloads, Me.space6, Me.iAutoHideMenu, Me.iFullscreen})
        Me.iView.ForeColor = System.Drawing.Color.White
        Me.iView.Name = "iView"
        Me.iView.Size = New System.Drawing.Size(44, 20)
        Me.iView.Text = "View"
        '
        'iHistory
        '
        Me.iHistory.Image = Global.Lemon.My.Resources.Resources.history_dark
        Me.iHistory.Name = "iHistory"
        Me.iHistory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.iHistory.Size = New System.Drawing.Size(174, 22)
        Me.iHistory.Text = "History"
        '
        'iBookmarks
        '
        Me.iBookmarks.Image = Global.Lemon.My.Resources.Resources.bookmark_dark
        Me.iBookmarks.Name = "iBookmarks"
        Me.iBookmarks.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.iBookmarks.Size = New System.Drawing.Size(174, 22)
        Me.iBookmarks.Text = "Bookmarks"
        '
        'iDownloads
        '
        Me.iDownloads.Image = Global.Lemon.My.Resources.Resources.download_dark
        Me.iDownloads.Name = "iDownloads"
        Me.iDownloads.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.iDownloads.Size = New System.Drawing.Size(174, 22)
        Me.iDownloads.Text = "Downloads"
        '
        'space6
        '
        Me.space6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.space6.Name = "space6"
        Me.space6.Size = New System.Drawing.Size(171, 6)
        '
        'iAutoHideMenu
        '
        Me.iAutoHideMenu.Image = Global.Lemon.My.Resources.Resources.menu_dark
        Me.iAutoHideMenu.Name = "iAutoHideMenu"
        Me.iAutoHideMenu.Size = New System.Drawing.Size(174, 22)
        Me.iAutoHideMenu.Text = "Auto hide menu"
        '
        'iFullscreen
        '
        Me.iFullscreen.Image = Global.Lemon.My.Resources.Resources.expand_dark
        Me.iFullscreen.Name = "iFullscreen"
        Me.iFullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.iFullscreen.Size = New System.Drawing.Size(174, 22)
        Me.iFullscreen.Text = "Fullscreen"
        '
        'fav0
        '
        Me.fav0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav0.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav0.Name = "fav0"
        Me.fav0.Size = New System.Drawing.Size(41, 20)
        Me.fav0.Text = "fav0"
        '
        'fav1
        '
        Me.fav1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav1.Name = "fav1"
        Me.fav1.Size = New System.Drawing.Size(41, 20)
        Me.fav1.Text = "fav1"
        '
        'fav2
        '
        Me.fav2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav2.Name = "fav2"
        Me.fav2.Size = New System.Drawing.Size(41, 20)
        Me.fav2.Text = "fav2"
        '
        'fav3
        '
        Me.fav3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav3.Name = "fav3"
        Me.fav3.Size = New System.Drawing.Size(41, 20)
        Me.fav3.Text = "fav3"
        '
        'fav4
        '
        Me.fav4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav4.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav4.Name = "fav4"
        Me.fav4.Size = New System.Drawing.Size(41, 20)
        Me.fav4.Text = "fav4"
        '
        'fav5
        '
        Me.fav5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav5.Name = "fav5"
        Me.fav5.Size = New System.Drawing.Size(41, 20)
        Me.fav5.Text = "fav5"
        '
        'fav6
        '
        Me.fav6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav6.Name = "fav6"
        Me.fav6.Size = New System.Drawing.Size(41, 20)
        Me.fav6.Text = "fav6"
        '
        'fav7
        '
        Me.fav7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav7.Name = "fav7"
        Me.fav7.Size = New System.Drawing.Size(41, 20)
        Me.fav7.Text = "fav7"
        '
        'fav8
        '
        Me.fav8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav8.Name = "fav8"
        Me.fav8.Size = New System.Drawing.Size(41, 20)
        Me.fav8.Text = "fav8"
        '
        'fav9
        '
        Me.fav9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.fav9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.fav9.Name = "fav9"
        Me.fav9.Size = New System.Drawing.Size(41, 20)
        Me.fav9.Text = "fav9"
        '
        'cmFav
        '
        Me.cmFav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iOpenInNewTab, Me.iBookmarksManager})
        Me.cmFav.Name = "cmBookmarks"
        Me.cmFav.Size = New System.Drawing.Size(184, 48)
        '
        'iOpenInNewTab
        '
        Me.iOpenInNewTab.Image = Global.Lemon.My.Resources.Resources.add_dark
        Me.iOpenInNewTab.Name = "iOpenInNewTab"
        Me.iOpenInNewTab.Size = New System.Drawing.Size(183, 22)
        Me.iOpenInNewTab.Text = "Open in new tab"
        '
        'iBookmarksManager
        '
        Me.iBookmarksManager.Image = Global.Lemon.My.Resources.Resources.bookmark_dark
        Me.iBookmarksManager.Name = "iBookmarksManager"
        Me.iBookmarksManager.Size = New System.Drawing.Size(183, 22)
        Me.iBookmarksManager.Text = "Bookmarks manager"
        '
        'timerAutoLock
        '
        Me.timerAutoLock.Interval = 1800000
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.tcWeb)
        Me.Controls.Add(Me.pMenu)
        Me.Controls.Add(Me.pSearch)
        Me.Controls.Add(Me.pHover)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.pMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fMain"
        Me.Text = "Lemon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmSearch.ResumeLayout(False)
        Me.pSearch.ResumeLayout(False)
        Me.pSearch.PerformLayout()
        CType(Me.picFavicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmTab.ResumeLayout(False)
        Me.pMenu.ResumeLayout(False)
        Me.pMenu.PerformLayout()
        Me.cmFav.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pHover As System.Windows.Forms.Panel
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents pSearch As System.Windows.Forms.Panel
    Friend WithEvents tcWeb As System.Windows.Forms.TabControl
    Friend WithEvents bWebForward As System.Windows.Forms.Button
    Friend WithEvents bWebBack As System.Windows.Forms.Button
    Friend WithEvents bBookmark As System.Windows.Forms.Button
    Friend WithEvents pMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents iFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iAddTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iRemoveTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iNewWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iLockWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iNotepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iScreenshot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iBookmarks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iAutoHideMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iFullscreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bLock As System.Windows.Forms.Button
    Friend WithEvents fav0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fav9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bSearch As System.Windows.Forms.Button
    Friend WithEvents picFavicon As System.Windows.Forms.PictureBox
    Friend WithEvents cmFav As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iOpenInNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iBookmarksManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmSearch As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iSearchBing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iSearchGoogle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iSearchYoutube As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timerAutoLock As System.Windows.Forms.Timer
    Friend WithEvents iDownloads As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iDeleteTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTab As System.Windows.Forms.ContextMenuStrip

End Class
