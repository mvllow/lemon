<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fNotes))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.tbSave = New System.Windows.Forms.TextBox()
        Me.tbNotes = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSave.BackgroundImage = Global.Lemon.My.Resources.Resources.save
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.ForeColor = System.Drawing.SystemColors.Control
        Me.bSave.Location = New System.Drawing.Point(339, 423)
        Me.bSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(32, 32)
        Me.bSave.TabIndex = 13
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClear.BackgroundImage = Global.Lemon.My.Resources.Resources.remove
        Me.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClear.ForeColor = System.Drawing.SystemColors.Control
        Me.bClear.Location = New System.Drawing.Point(13, 423)
        Me.bClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(32, 32)
        Me.bClear.TabIndex = 14
        Me.bClear.UseVisualStyleBackColor = True
        '
        'tbSave
        '
        Me.tbSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSave.Location = New System.Drawing.Point(132, 429)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(200, 20)
        Me.tbSave.TabIndex = 15
        Me.tbSave.Text = "notes"
        Me.tbSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNotes
        '
        Me.tbNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNotes.Location = New System.Drawing.Point(12, 12)
        Me.tbNotes.Multiline = True
        Me.tbNotes.Name = "tbNotes"
        Me.tbNotes.Size = New System.Drawing.Size(360, 403)
        Me.tbNotes.TabIndex = 16
        '
        'fNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.tbNotes)
        Me.Controls.Add(Me.tbSave)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bSave)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "notes"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents tbSave As System.Windows.Forms.TextBox
    Friend WithEvents tbNotes As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
End Class
