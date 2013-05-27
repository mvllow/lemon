<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDownloads
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDownloads))
        Me.tbFileDir = New System.Windows.Forms.TextBox()
        Me.tbSaveDir = New System.Windows.Forms.TextBox()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.bDownload = New System.Windows.Forms.Button()
        Me.pbDownload = New System.Windows.Forms.ProgressBar()
        Me.txtComplete = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbFileDir
        '
        Me.tbFileDir.BackColor = System.Drawing.Color.DimGray
        Me.tbFileDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFileDir.ForeColor = System.Drawing.Color.White
        Me.tbFileDir.Location = New System.Drawing.Point(12, 12)
        Me.tbFileDir.Name = "tbFileDir"
        Me.tbFileDir.Size = New System.Drawing.Size(510, 22)
        Me.tbFileDir.TabIndex = 0
        Me.tbFileDir.Text = "File directory"
        '
        'tbSaveDir
        '
        Me.tbSaveDir.BackColor = System.Drawing.Color.DimGray
        Me.tbSaveDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSaveDir.ForeColor = System.Drawing.Color.White
        Me.tbSaveDir.Location = New System.Drawing.Point(12, 40)
        Me.tbSaveDir.Name = "tbSaveDir"
        Me.tbSaveDir.Size = New System.Drawing.Size(510, 22)
        Me.tbSaveDir.TabIndex = 1
        Me.tbSaveDir.Text = "Save to... (directory)"
        '
        'tbFileName
        '
        Me.tbFileName.BackColor = System.Drawing.Color.DimGray
        Me.tbFileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFileName.ForeColor = System.Drawing.Color.White
        Me.tbFileName.Location = New System.Drawing.Point(12, 68)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(472, 22)
        Me.tbFileName.TabIndex = 2
        Me.tbFileName.Text = "Save as... (name)"
        '
        'bDownload
        '
        Me.bDownload.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bDownload.BackgroundImage = Global.Lemon.My.Resources.Resources.download_light
        Me.bDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bDownload.Location = New System.Drawing.Point(490, 68)
        Me.bDownload.Name = "bDownload"
        Me.bDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bDownload.Size = New System.Drawing.Size(32, 32)
        Me.bDownload.TabIndex = 4
        Me.bDownload.UseVisualStyleBackColor = True
        '
        'pbDownload
        '
        Me.pbDownload.Location = New System.Drawing.Point(12, 96)
        Me.pbDownload.Name = "pbDownload"
        Me.pbDownload.Size = New System.Drawing.Size(471, 23)
        Me.pbDownload.TabIndex = 5
        '
        'txtComplete
        '
        Me.txtComplete.AutoSize = True
        Me.txtComplete.Location = New System.Drawing.Point(8, 123)
        Me.txtComplete.Name = "txtComplete"
        Me.txtComplete.Size = New System.Drawing.Size(160, 21)
        Me.txtComplete.TabIndex = 6
        Me.txtComplete.Text = "Download Complete..."
        Me.txtComplete.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "This feature is still a work in progress."
        '
        'fDownloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComplete)
        Me.Controls.Add(Me.pbDownload)
        Me.Controls.Add(Me.bDownload)
        Me.Controls.Add(Me.tbFileName)
        Me.Controls.Add(Me.tbSaveDir)
        Me.Controls.Add(Me.tbFileDir)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(780, 450)
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "fDownloads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloads"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbFileDir As System.Windows.Forms.TextBox
    Friend WithEvents tbSaveDir As System.Windows.Forms.TextBox
    Friend WithEvents tbFileName As System.Windows.Forms.TextBox
    Friend WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents bDownload As System.Windows.Forms.Button
    Friend WithEvents pbDownload As System.Windows.Forms.ProgressBar
    Friend WithEvents txtComplete As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
