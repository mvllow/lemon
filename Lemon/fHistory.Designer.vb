<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHistory))
        Me.listHistory = New System.Windows.Forms.ListBox()
        Me.cmHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iEditHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.space1 = New System.Windows.Forms.ToolStripSeparator()
        Me.iClearHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbAutoLock = New System.Windows.Forms.CheckBox()
        Me.txtAutoLock = New System.Windows.Forms.Label()
        Me.txtAutoClear = New System.Windows.Forms.Label()
        Me.cbAutoClear = New System.Windows.Forms.CheckBox()
        Me.cmHistory.SuspendLayout()
        Me.SuspendLayout()
        '
        'listHistory
        '
        Me.listHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listHistory.ContextMenuStrip = Me.cmHistory
        Me.listHistory.Dock = System.Windows.Forms.DockStyle.Left
        Me.listHistory.ForeColor = System.Drawing.Color.White
        Me.listHistory.FormattingEnabled = True
        Me.listHistory.HorizontalScrollbar = True
        Me.listHistory.ItemHeight = 21
        Me.listHistory.Location = New System.Drawing.Point(0, 0)
        Me.listHistory.Name = "listHistory"
        Me.listHistory.Size = New System.Drawing.Size(534, 411)
        Me.listHistory.TabIndex = 1
        '
        'cmHistory
        '
        Me.cmHistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.iEditHistory, Me.space1, Me.iClearHistory})
        Me.cmHistory.Name = "cmHistory"
        Me.cmHistory.Size = New System.Drawing.Size(141, 54)
        '
        'iEditHistory
        '
        Me.iEditHistory.Image = Global.Lemon.My.Resources.Resources.edit_dark
        Me.iEditHistory.Name = "iEditHistory"
        Me.iEditHistory.Size = New System.Drawing.Size(140, 22)
        Me.iEditHistory.Text = "Edit history"
        '
        'space1
        '
        Me.space1.Name = "space1"
        Me.space1.Size = New System.Drawing.Size(137, 6)
        '
        'iClearHistory
        '
        Me.iClearHistory.Image = Global.Lemon.My.Resources.Resources.remove_dark
        Me.iClearHistory.Name = "iClearHistory"
        Me.iClearHistory.Size = New System.Drawing.Size(140, 22)
        Me.iClearHistory.Text = "Clear history"
        '
        'cbAutoLock
        '
        Me.cbAutoLock.AutoSize = True
        Me.cbAutoLock.Location = New System.Drawing.Point(540, 126)
        Me.cbAutoLock.Name = "cbAutoLock"
        Me.cbAutoLock.Size = New System.Drawing.Size(96, 25)
        Me.cbAutoLock.TabIndex = 4
        Me.cbAutoLock.Text = "Auto Lock"
        Me.cbAutoLock.UseVisualStyleBackColor = True
        '
        'txtAutoLock
        '
        Me.txtAutoLock.AutoSize = True
        Me.txtAutoLock.Location = New System.Drawing.Point(540, 154)
        Me.txtAutoLock.Name = "txtAutoLock"
        Me.txtAutoLock.Size = New System.Drawing.Size(204, 84)
        Me.txtAutoLock.TabIndex = 5
        Me.txtAutoLock.Text = "When checked, this browser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will automatically lock itself" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "every 30 minutes.  Th" & _
    "is is a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "newly added security feature."
        Me.txtAutoLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAutoClear
        '
        Me.txtAutoClear.AutoSize = True
        Me.txtAutoClear.Location = New System.Drawing.Point(540, 40)
        Me.txtAutoClear.Name = "txtAutoClear"
        Me.txtAutoClear.Size = New System.Drawing.Size(197, 63)
        Me.txtAutoClear.TabIndex = 7
        Me.txtAutoClear.Text = "When checked, ALL history" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and auto complete memory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be deleted on exit."
        Me.txtAutoClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbAutoClear
        '
        Me.cbAutoClear.AutoSize = True
        Me.cbAutoClear.Location = New System.Drawing.Point(540, 12)
        Me.cbAutoClear.Name = "cbAutoClear"
        Me.cbAutoClear.Size = New System.Drawing.Size(100, 25)
        Me.cbAutoClear.TabIndex = 6
        Me.cbAutoClear.Text = "Auto Clear"
        Me.cbAutoClear.UseVisualStyleBackColor = True
        '
        'fHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.txtAutoClear)
        Me.Controls.Add(Me.cbAutoClear)
        Me.Controls.Add(Me.txtAutoLock)
        Me.Controls.Add(Me.cbAutoLock)
        Me.Controls.Add(Me.listHistory)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(780, 450)
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "fHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.TopMost = True
        Me.cmHistory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listHistory As System.Windows.Forms.ListBox
    Friend WithEvents cmHistory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iClearHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iEditHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents space1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbAutoLock As System.Windows.Forms.CheckBox
    Friend WithEvents txtAutoLock As System.Windows.Forms.Label
    Friend WithEvents txtAutoClear As System.Windows.Forms.Label
    Friend WithEvents cbAutoClear As System.Windows.Forms.CheckBox
End Class
