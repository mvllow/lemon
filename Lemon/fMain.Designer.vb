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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.tcWeb = New System.Windows.Forms.TabControl()
        Me.pNav = New System.Windows.Forms.Panel()
        Me.picFavicon = New System.Windows.Forms.PictureBox()
        Me.bNav = New System.Windows.Forms.Button()
        Me.tbNav = New System.Windows.Forms.TextBox()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.bBookmark = New System.Windows.Forms.Button()
        Me.bBack = New System.Windows.Forms.Button()
        Me.bForward = New System.Windows.Forms.Button()
        Me.bLock = New System.Windows.Forms.Button()
        Me.pApps = New System.Windows.Forms.Panel()
        Me.listHistory = New System.Windows.Forms.ListBox()
        Me.bFullscreen = New System.Windows.Forms.Button()
        Me.pMenu = New System.Windows.Forms.MenuStrip()
        Me.iClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.iVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.listBookmarks = New System.Windows.Forms.ListBox()
        Me.bOffline = New System.Windows.Forms.Button()
        Me.bShare = New System.Windows.Forms.Button()
        Me.bPrintPreview = New System.Windows.Forms.Button()
        Me.bRemoveTab = New System.Windows.Forms.Button()
        Me.bAddTab = New System.Windows.Forms.Button()
        Me.bOptions = New System.Windows.Forms.Button()
        Me.bScreenshot = New System.Windows.Forms.Button()
        Me.bBookmarks = New System.Windows.Forms.Button()
        Me.bNotes = New System.Windows.Forms.Button()
        Me.bHistory = New System.Windows.Forms.Button()
        Me.pNav.SuspendLayout()
        CType(Me.picFavicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pApps.SuspendLayout()
        Me.pMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcWeb
        '
        Me.tcWeb.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tcWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcWeb.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcWeb.Location = New System.Drawing.Point(0, 0)
        Me.tcWeb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tcWeb.Name = "tcWeb"
        Me.tcWeb.SelectedIndex = 0
        Me.tcWeb.Size = New System.Drawing.Size(1264, 723)
        Me.tcWeb.TabIndex = 1
        '
        'pNav
        '
        Me.pNav.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pNav.Controls.Add(Me.picFavicon)
        Me.pNav.Controls.Add(Me.bNav)
        Me.pNav.Controls.Add(Me.tbNav)
        Me.pNav.Controls.Add(Me.bMenu)
        Me.pNav.Controls.Add(Me.bBookmark)
        Me.pNav.Controls.Add(Me.bBack)
        Me.pNav.Controls.Add(Me.bForward)
        Me.pNav.Controls.Add(Me.bLock)
        Me.pNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pNav.Location = New System.Drawing.Point(0, 723)
        Me.pNav.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pNav.Name = "pNav"
        Me.pNav.Size = New System.Drawing.Size(1264, 38)
        Me.pNav.TabIndex = 6
        '
        'picFavicon
        '
        Me.picFavicon.BackColor = System.Drawing.Color.White
        Me.picFavicon.ErrorImage = Nothing
        Me.picFavicon.InitialImage = Nothing
        Me.picFavicon.Location = New System.Drawing.Point(118, 9)
        Me.picFavicon.Name = "picFavicon"
        Me.picFavicon.Size = New System.Drawing.Size(19, 19)
        Me.picFavicon.TabIndex = 8
        Me.picFavicon.TabStop = False
        '
        'bNav
        '
        Me.bNav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bNav.BackColor = System.Drawing.Color.White
        Me.bNav.BackgroundImage = Global.Lemon.My.Resources.Resources.search
        Me.bNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNav.ForeColor = System.Drawing.Color.White
        Me.bNav.Location = New System.Drawing.Point(1165, 9)
        Me.bNav.Name = "bNav"
        Me.bNav.Size = New System.Drawing.Size(19, 19)
        Me.bNav.TabIndex = 7
        Me.bNav.UseVisualStyleBackColor = False
        '
        'tbNav
        '
        Me.tbNav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNav.AutoCompleteCustomSource.AddRange(New String() {"google.com"})
        Me.tbNav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbNav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbNav.BackColor = System.Drawing.Color.White
        Me.tbNav.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNav.Location = New System.Drawing.Point(137, 9)
        Me.tbNav.Name = "tbNav"
        Me.tbNav.Size = New System.Drawing.Size(1048, 19)
        Me.tbNav.TabIndex = 0
        '
        'bMenu
        '
        Me.bMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bMenu.BackgroundImage = Global.Lemon.My.Resources.Resources.grid
        Me.bMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bMenu.Location = New System.Drawing.Point(3, 3)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(32, 32)
        Me.bMenu.TabIndex = 2
        Me.bMenu.UseVisualStyleBackColor = True
        '
        'bBookmark
        '
        Me.bBookmark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBookmark.BackgroundImage = Global.Lemon.My.Resources.Resources.star
        Me.bBookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBookmark.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bBookmark.Location = New System.Drawing.Point(1191, 3)
        Me.bBookmark.Name = "bBookmark"
        Me.bBookmark.Size = New System.Drawing.Size(32, 32)
        Me.bBookmark.TabIndex = 5
        Me.bBookmark.UseVisualStyleBackColor = True
        '
        'bBack
        '
        Me.bBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bBack.BackgroundImage = Global.Lemon.My.Resources.Resources.back_alt
        Me.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBack.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bBack.Location = New System.Drawing.Point(41, 3)
        Me.bBack.Name = "bBack"
        Me.bBack.Size = New System.Drawing.Size(32, 32)
        Me.bBack.TabIndex = 3
        Me.bBack.UseVisualStyleBackColor = True
        '
        'bForward
        '
        Me.bForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bForward.BackgroundImage = Global.Lemon.My.Resources.Resources.forward_alt
        Me.bForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bForward.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bForward.Location = New System.Drawing.Point(79, 3)
        Me.bForward.Name = "bForward"
        Me.bForward.Size = New System.Drawing.Size(32, 32)
        Me.bForward.TabIndex = 4
        Me.bForward.UseVisualStyleBackColor = True
        '
        'bLock
        '
        Me.bLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLock.BackgroundImage = Global.Lemon.My.Resources.Resources.lock
        Me.bLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bLock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLock.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bLock.Location = New System.Drawing.Point(1229, 3)
        Me.bLock.Name = "bLock"
        Me.bLock.Size = New System.Drawing.Size(32, 32)
        Me.bLock.TabIndex = 6
        Me.bLock.UseVisualStyleBackColor = True
        '
        'pApps
        '
        Me.pApps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pApps.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pApps.Controls.Add(Me.listHistory)
        Me.pApps.Controls.Add(Me.bFullscreen)
        Me.pApps.Controls.Add(Me.pMenu)
        Me.pApps.Controls.Add(Me.listBookmarks)
        Me.pApps.Controls.Add(Me.bOffline)
        Me.pApps.Controls.Add(Me.bShare)
        Me.pApps.Controls.Add(Me.bPrintPreview)
        Me.pApps.Controls.Add(Me.bRemoveTab)
        Me.pApps.Controls.Add(Me.bAddTab)
        Me.pApps.Controls.Add(Me.bOptions)
        Me.pApps.Controls.Add(Me.bScreenshot)
        Me.pApps.Controls.Add(Me.bBookmarks)
        Me.pApps.Controls.Add(Me.bNotes)
        Me.pApps.Controls.Add(Me.bHistory)
        Me.pApps.Location = New System.Drawing.Point(432, 280)
        Me.pApps.Name = "pApps"
        Me.pApps.Size = New System.Drawing.Size(400, 400)
        Me.pApps.TabIndex = 2
        Me.pApps.Visible = False
        '
        'listHistory
        '
        Me.listHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.listHistory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listHistory.FormattingEnabled = True
        Me.listHistory.IntegralHeight = False
        Me.listHistory.ItemHeight = 18
        Me.listHistory.Location = New System.Drawing.Point(3, 203)
        Me.listHistory.Name = "listHistory"
        Me.listHistory.Size = New System.Drawing.Size(394, 194)
        Me.listHistory.TabIndex = 18
        '
        'bFullscreen
        '
        Me.bFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bFullscreen.BackgroundImage = Global.Lemon.My.Resources.Resources.expand
        Me.bFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFullscreen.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bFullscreen.Location = New System.Drawing.Point(349, 27)
        Me.bFullscreen.Name = "bFullscreen"
        Me.bFullscreen.Size = New System.Drawing.Size(48, 48)
        Me.bFullscreen.TabIndex = 19
        Me.bFullscreen.UseVisualStyleBackColor = True
        '
        'pMenu
        '
        Me.pMenu.BackColor = System.Drawing.Color.Crimson
        Me.pMenu.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iClose, Me.iVersion})
        Me.pMenu.Location = New System.Drawing.Point(0, 0)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(400, 24)
        Me.pMenu.TabIndex = 0
        '
        'iClose
        '
        Me.iClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.iClose.Image = Global.Lemon.My.Resources.Resources.cancel_alt
        Me.iClose.Name = "iClose"
        Me.iClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.iClose.Size = New System.Drawing.Size(28, 20)
        '
        'iVersion
        '
        Me.iVersion.ForeColor = System.Drawing.Color.White
        Me.iVersion.Image = Global.Lemon.My.Resources.Resources.about_alt
        Me.iVersion.Name = "iVersion"
        Me.iVersion.Size = New System.Drawing.Size(28, 20)
        '
        'listBookmarks
        '
        Me.listBookmarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.listBookmarks.BackColor = System.Drawing.SystemColors.ControlLight
        Me.listBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listBookmarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listBookmarks.FormattingEnabled = True
        Me.listBookmarks.IntegralHeight = False
        Me.listBookmarks.ItemHeight = 18
        Me.listBookmarks.Location = New System.Drawing.Point(3, 203)
        Me.listBookmarks.Name = "listBookmarks"
        Me.listBookmarks.Size = New System.Drawing.Size(394, 194)
        Me.listBookmarks.TabIndex = 17
        '
        'bOffline
        '
        Me.bOffline.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bOffline.BackgroundImage = Global.Lemon.My.Resources.Resources.offline
        Me.bOffline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOffline.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bOffline.Location = New System.Drawing.Point(241, 27)
        Me.bOffline.Name = "bOffline"
        Me.bOffline.Size = New System.Drawing.Size(48, 48)
        Me.bOffline.TabIndex = 16
        Me.bOffline.UseVisualStyleBackColor = True
        Me.bOffline.Visible = False
        '
        'bShare
        '
        Me.bShare.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bShare.BackgroundImage = Global.Lemon.My.Resources.Resources.share
        Me.bShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bShare.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bShare.Location = New System.Drawing.Point(295, 27)
        Me.bShare.Name = "bShare"
        Me.bShare.Size = New System.Drawing.Size(48, 48)
        Me.bShare.TabIndex = 15
        Me.bShare.UseVisualStyleBackColor = True
        Me.bShare.Visible = False
        '
        'bPrintPreview
        '
        Me.bPrintPreview.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bPrintPreview.FlatAppearance.BorderSize = 0
        Me.bPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPrintPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bPrintPreview.Location = New System.Drawing.Point(3, 103)
        Me.bPrintPreview.Name = "bPrintPreview"
        Me.bPrintPreview.Size = New System.Drawing.Size(128, 32)
        Me.bPrintPreview.TabIndex = 9
        Me.bPrintPreview.Text = "print preview"
        Me.bPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPrintPreview.UseVisualStyleBackColor = True
        '
        'bRemoveTab
        '
        Me.bRemoveTab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bRemoveTab.FlatAppearance.BorderSize = 0
        Me.bRemoveTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRemoveTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bRemoveTab.Location = New System.Drawing.Point(3, 65)
        Me.bRemoveTab.Name = "bRemoveTab"
        Me.bRemoveTab.Size = New System.Drawing.Size(128, 32)
        Me.bRemoveTab.TabIndex = 8
        Me.bRemoveTab.Text = "remove tab"
        Me.bRemoveTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bRemoveTab.UseVisualStyleBackColor = True
        '
        'bAddTab
        '
        Me.bAddTab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bAddTab.FlatAppearance.BorderSize = 0
        Me.bAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bAddTab.Location = New System.Drawing.Point(3, 27)
        Me.bAddTab.Name = "bAddTab"
        Me.bAddTab.Size = New System.Drawing.Size(128, 32)
        Me.bAddTab.TabIndex = 7
        Me.bAddTab.Text = "add tab"
        Me.bAddTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAddTab.UseVisualStyleBackColor = True
        '
        'bOptions
        '
        Me.bOptions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bOptions.BackgroundImage = Global.Lemon.My.Resources.Resources.settings
        Me.bOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOptions.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bOptions.Location = New System.Drawing.Point(3, 149)
        Me.bOptions.Name = "bOptions"
        Me.bOptions.Size = New System.Drawing.Size(48, 48)
        Me.bOptions.TabIndex = 10
        Me.bOptions.UseVisualStyleBackColor = True
        '
        'bScreenshot
        '
        Me.bScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bScreenshot.BackgroundImage = Global.Lemon.My.Resources.Resources.camera
        Me.bScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bScreenshot.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bScreenshot.Location = New System.Drawing.Point(187, 149)
        Me.bScreenshot.Name = "bScreenshot"
        Me.bScreenshot.Size = New System.Drawing.Size(48, 48)
        Me.bScreenshot.TabIndex = 11
        Me.bScreenshot.UseVisualStyleBackColor = True
        '
        'bBookmarks
        '
        Me.bBookmarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bBookmarks.BackgroundImage = Global.Lemon.My.Resources.Resources.bookmark
        Me.bBookmarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBookmarks.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bBookmarks.Location = New System.Drawing.Point(295, 149)
        Me.bBookmarks.Name = "bBookmarks"
        Me.bBookmarks.Size = New System.Drawing.Size(48, 48)
        Me.bBookmarks.TabIndex = 13
        Me.bBookmarks.UseVisualStyleBackColor = True
        '
        'bNotes
        '
        Me.bNotes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bNotes.BackgroundImage = Global.Lemon.My.Resources.Resources.notes
        Me.bNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNotes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bNotes.Location = New System.Drawing.Point(241, 149)
        Me.bNotes.Name = "bNotes"
        Me.bNotes.Size = New System.Drawing.Size(48, 48)
        Me.bNotes.TabIndex = 12
        Me.bNotes.UseVisualStyleBackColor = True
        '
        'bHistory
        '
        Me.bHistory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bHistory.BackgroundImage = Global.Lemon.My.Resources.Resources.history
        Me.bHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHistory.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.bHistory.Location = New System.Drawing.Point(349, 149)
        Me.bHistory.Name = "bHistory"
        Me.bHistory.Size = New System.Drawing.Size(48, 48)
        Me.bHistory.TabIndex = 14
        Me.bHistory.UseVisualStyleBackColor = True
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.bLock
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.pApps)
        Me.Controls.Add(Me.tcWeb)
        Me.Controls.Add(Me.pNav)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.pMenu
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fMain"
        Me.Text = "lemon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pNav.ResumeLayout(False)
        Me.pNav.PerformLayout()
        CType(Me.picFavicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pApps.ResumeLayout(False)
        Me.pApps.PerformLayout()
        Me.pMenu.ResumeLayout(False)
        Me.pMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcWeb As System.Windows.Forms.TabControl
    Friend WithEvents pNav As System.Windows.Forms.Panel
    Friend WithEvents tbNav As System.Windows.Forms.TextBox
    Friend WithEvents bLock As System.Windows.Forms.Button
    Friend WithEvents bBack As System.Windows.Forms.Button
    Friend WithEvents bForward As System.Windows.Forms.Button
    Friend WithEvents bBookmark As System.Windows.Forms.Button
    Friend WithEvents bMenu As System.Windows.Forms.Button
    Friend WithEvents pApps As System.Windows.Forms.Panel
    Friend WithEvents pMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents bScreenshot As System.Windows.Forms.Button
    Friend WithEvents bBookmarks As System.Windows.Forms.Button
    Friend WithEvents bNotes As System.Windows.Forms.Button
    Friend WithEvents bHistory As System.Windows.Forms.Button
    Friend WithEvents bOptions As System.Windows.Forms.Button
    Friend WithEvents bPrintPreview As System.Windows.Forms.Button
    Friend WithEvents bRemoveTab As System.Windows.Forms.Button
    Friend WithEvents bAddTab As System.Windows.Forms.Button
    Friend WithEvents iClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bOffline As System.Windows.Forms.Button
    Friend WithEvents bShare As System.Windows.Forms.Button
    Friend WithEvents listBookmarks As System.Windows.Forms.ListBox
    Friend WithEvents iVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents listHistory As System.Windows.Forms.ListBox
    Friend WithEvents bNav As System.Windows.Forms.Button
    Friend WithEvents bFullscreen As System.Windows.Forms.Button
    Friend WithEvents picFavicon As System.Windows.Forms.PictureBox

End Class
