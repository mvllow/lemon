<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fScreenshot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fScreenshot))
        Me.cmPicture = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iToggleFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.bShare = New System.Windows.Forms.Button()
        Me.bScreenshot = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.picScreenshot = New System.Windows.Forms.PictureBox()
        Me.cmPicture.SuspendLayout()
        CType(Me.picScreenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmPicture
        '
        Me.cmPicture.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iToggleFullscreen})
        Me.cmPicture.Name = "cmPicture"
        Me.cmPicture.Size = New System.Drawing.Size(166, 26)
        '
        'iToggleFullscreen
        '
        Me.iToggleFullscreen.Image = Global.Lemon.My.Resources.Resources.expand_dark
        Me.iToggleFullscreen.Name = "iToggleFullscreen"
        Me.iToggleFullscreen.Size = New System.Drawing.Size(165, 22)
        Me.iToggleFullscreen.Text = "Toggle fullscreen"
        '
        'bShare
        '
        Me.bShare.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bShare.BackgroundImage = Global.Lemon.My.Resources.Resources.share_light
        Me.bShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bShare.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bShare.Location = New System.Drawing.Point(502, 317)
        Me.bShare.Name = "bShare"
        Me.bShare.Size = New System.Drawing.Size(32, 32)
        Me.bShare.TabIndex = 7
        Me.bShare.UseVisualStyleBackColor = True
        '
        'bScreenshot
        '
        Me.bScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bScreenshot.BackgroundImage = Global.Lemon.My.Resources.Resources.camera_light
        Me.bScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bScreenshot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bScreenshot.Location = New System.Drawing.Point(464, 317)
        Me.bScreenshot.Name = "bScreenshot"
        Me.bScreenshot.Size = New System.Drawing.Size(32, 32)
        Me.bScreenshot.TabIndex = 5
        Me.bScreenshot.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bSave.BackgroundImage = Global.Lemon.My.Resources.Resources.save_light
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bSave.Location = New System.Drawing.Point(540, 317)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(32, 32)
        Me.bSave.TabIndex = 4
        Me.bSave.UseVisualStyleBackColor = True
        '
        'picScreenshot
        '
        Me.picScreenshot.BackColor = System.Drawing.Color.DimGray
        Me.picScreenshot.ContextMenuStrip = Me.cmPicture
        Me.picScreenshot.Dock = System.Windows.Forms.DockStyle.Top
        Me.picScreenshot.Location = New System.Drawing.Point(0, 0)
        Me.picScreenshot.Name = "picScreenshot"
        Me.picScreenshot.Size = New System.Drawing.Size(584, 311)
        Me.picScreenshot.TabIndex = 0
        Me.picScreenshot.TabStop = False
        '
        'fScreenshot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.bShare)
        Me.Controls.Add(Me.bScreenshot)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.picScreenshot)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "fScreenshot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screenshot"
        Me.TopMost = True
        Me.cmPicture.ResumeLayout(False)
        CType(Me.picScreenshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picScreenshot As System.Windows.Forms.PictureBox
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bScreenshot As System.Windows.Forms.Button
    Friend WithEvents bShare As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmPicture As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iToggleFullscreen As System.Windows.Forms.ToolStripMenuItem
End Class
