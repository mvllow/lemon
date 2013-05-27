<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNotepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fNotepad))
        Me.tbNotes = New System.Windows.Forms.TextBox()
        Me.cmNotes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.space1 = New System.Windows.Forms.ToolStripSeparator()
        Me.iClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.cmNotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNotes
        '
        Me.tbNotes.BackColor = System.Drawing.Color.DimGray
        Me.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNotes.ContextMenuStrip = Me.cmNotes
        Me.tbNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNotes.ForeColor = System.Drawing.Color.White
        Me.tbNotes.Location = New System.Drawing.Point(0, 0)
        Me.tbNotes.Multiline = True
        Me.tbNotes.Name = "tbNotes"
        Me.tbNotes.Size = New System.Drawing.Size(534, 411)
        Me.tbNotes.TabIndex = 0
        '
        'cmNotes
        '
        Me.cmNotes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iSaveAs, Me.space1, Me.iClearAll})
        Me.cmNotes.Name = "cmNotes"
        Me.cmNotes.Size = New System.Drawing.Size(122, 54)
        '
        'iSaveAs
        '
        Me.iSaveAs.Image = Global.Lemon.My.Resources.Resources.save_dark
        Me.iSaveAs.Name = "iSaveAs"
        Me.iSaveAs.Size = New System.Drawing.Size(121, 22)
        Me.iSaveAs.Text = "Save as..."
        '
        'space1
        '
        Me.space1.Name = "space1"
        Me.space1.Size = New System.Drawing.Size(118, 6)
        '
        'iClearAll
        '
        Me.iClearAll.Image = Global.Lemon.My.Resources.Resources.remove_dark
        Me.iClearAll.Name = "iClearAll"
        Me.iClearAll.Size = New System.Drawing.Size(121, 22)
        Me.iClearAll.Text = "Clear all"
        '
        'fNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.tbNotes)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Name = "fNotepad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad"
        Me.TopMost = True
        Me.cmNotes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmNotes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iClearAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
End Class
