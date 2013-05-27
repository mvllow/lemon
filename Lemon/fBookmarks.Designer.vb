<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBookmarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBookmarks))
        Me.listBookmarks = New System.Windows.Forms.ListBox()
        Me.cmBookmarks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iEditBookmarks = New System.Windows.Forms.ToolStripMenuItem()
        Me.space1 = New System.Windows.Forms.ToolStripSeparator()
        Me.iClearBookmarks = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.txtUrl = New System.Windows.Forms.Label()
        Me.tbUrl = New System.Windows.Forms.TextBox()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.cmBookmarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBookmarks
        '
        Me.listBookmarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBookmarks.ContextMenuStrip = Me.cmBookmarks
        Me.listBookmarks.Dock = System.Windows.Forms.DockStyle.Left
        Me.listBookmarks.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.listBookmarks.ForeColor = System.Drawing.Color.White
        Me.listBookmarks.FormattingEnabled = True
        Me.listBookmarks.HorizontalScrollbar = True
        Me.listBookmarks.ItemHeight = 21
        Me.listBookmarks.Location = New System.Drawing.Point(0, 0)
        Me.listBookmarks.Name = "listBookmarks"
        Me.listBookmarks.Size = New System.Drawing.Size(534, 411)
        Me.listBookmarks.TabIndex = 5
        '
        'cmBookmarks
        '
        Me.cmBookmarks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iEditBookmarks, Me.space1, Me.iClearBookmarks})
        Me.cmBookmarks.Name = "cmBookmarks"
        Me.cmBookmarks.Size = New System.Drawing.Size(164, 54)
        '
        'iEditBookmarks
        '
        Me.iEditBookmarks.Image = Global.Lemon.My.Resources.Resources.edit_dark
        Me.iEditBookmarks.Name = "iEditBookmarks"
        Me.iEditBookmarks.Size = New System.Drawing.Size(163, 22)
        Me.iEditBookmarks.Text = "Edit bookmarks"
        '
        'space1
        '
        Me.space1.Name = "space1"
        Me.space1.Size = New System.Drawing.Size(160, 6)
        '
        'iClearBookmarks
        '
        Me.iClearBookmarks.Image = Global.Lemon.My.Resources.Resources.remove_dark
        Me.iClearBookmarks.Name = "iClearBookmarks"
        Me.iClearBookmarks.Size = New System.Drawing.Size(163, 22)
        Me.iClearBookmarks.Text = "Clear bookmarks"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(541, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(50, 21)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = "Name"
        '
        'tbName
        '
        Me.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbName.BackColor = System.Drawing.Color.DimGray
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbName.ForeColor = System.Drawing.Color.White
        Me.tbName.Location = New System.Drawing.Point(597, 11)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(155, 22)
        Me.tbName.TabIndex = 0
        '
        'txtUrl
        '
        Me.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtUrl.AutoSize = True
        Me.txtUrl.Location = New System.Drawing.Point(563, 53)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(28, 21)
        Me.txtUrl.TabIndex = 8
        Me.txtUrl.Text = "Url"
        '
        'tbUrl
        '
        Me.tbUrl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbUrl.BackColor = System.Drawing.Color.DimGray
        Me.tbUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUrl.ForeColor = System.Drawing.Color.White
        Me.tbUrl.Location = New System.Drawing.Point(597, 52)
        Me.tbUrl.Name = "tbUrl"
        Me.tbUrl.Size = New System.Drawing.Size(155, 22)
        Me.tbUrl.TabIndex = 1
        '
        'bAdd
        '
        Me.bAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bAdd.BackgroundImage = Global.Lemon.My.Resources.Resources.add_light
        Me.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bAdd.Location = New System.Drawing.Point(720, 80)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(32, 32)
        Me.bAdd.TabIndex = 2
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'fBookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.tbUrl)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.listBookmarks)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(780, 450)
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "fBookmarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookmarks"
        Me.TopMost = True
        Me.cmBookmarks.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listBookmarks As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents txtUrl As System.Windows.Forms.Label
    Friend WithEvents tbUrl As System.Windows.Forms.TextBox
    Friend WithEvents bAdd As System.Windows.Forms.Button
    Friend WithEvents cmBookmarks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iEditBookmarks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iClearBookmarks As System.Windows.Forms.ToolStripMenuItem
End Class
