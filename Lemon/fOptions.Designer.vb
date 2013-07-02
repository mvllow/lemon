<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fOptions))
        Me.tbNewPin = New System.Windows.Forms.TextBox()
        Me.txtNewPin = New System.Windows.Forms.Label()
        Me.tbPin = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.Label()
        Me.bResetHistory = New System.Windows.Forms.Button()
        Me.bResetBookmarks = New System.Windows.Forms.Button()
        Me.bResetMemory = New System.Windows.Forms.Button()
        Me.boxPrivacy = New System.Windows.Forms.GroupBox()
        Me.bResetBrowser = New System.Windows.Forms.Button()
        Me.txtReset = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTopNav = New System.Windows.Forms.CheckBox()
        Me.cbHideWelcome = New System.Windows.Forms.CheckBox()
        Me.txtHome = New System.Windows.Forms.Label()
        Me.tbHome = New System.Windows.Forms.TextBox()
        Me.boxPrivacy.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNewPin
        '
        Me.tbNewPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbNewPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNewPin.Location = New System.Drawing.Point(6, 46)
        Me.tbNewPin.MaxLength = 4
        Me.tbNewPin.Name = "tbNewPin"
        Me.tbNewPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.tbNewPin.Size = New System.Drawing.Size(94, 20)
        Me.tbNewPin.TabIndex = 2
        '
        'txtNewPin
        '
        Me.txtNewPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNewPin.AutoSize = True
        Me.txtNewPin.Location = New System.Drawing.Point(2, 23)
        Me.txtNewPin.Name = "txtNewPin"
        Me.txtNewPin.Size = New System.Drawing.Size(63, 20)
        Me.txtNewPin.TabIndex = 11
        Me.txtNewPin.Text = "new pin"
        '
        'tbPin
        '
        Me.tbPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbPin.Location = New System.Drawing.Point(106, 46)
        Me.tbPin.MaxLength = 4
        Me.tbPin.Name = "tbPin"
        Me.tbPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.tbPin.Size = New System.Drawing.Size(94, 20)
        Me.tbPin.TabIndex = 12
        '
        'txtPin
        '
        Me.txtPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPin.AutoSize = True
        Me.txtPin.Location = New System.Drawing.Point(102, 23)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(62, 20)
        Me.txtPin.TabIndex = 13
        Me.txtPin.Text = "confirm"
        '
        'bResetHistory
        '
        Me.bResetHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResetHistory.FlatAppearance.BorderSize = 0
        Me.bResetHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bResetHistory.Location = New System.Drawing.Point(112, 102)
        Me.bResetHistory.Name = "bResetHistory"
        Me.bResetHistory.Size = New System.Drawing.Size(100, 32)
        Me.bResetHistory.TabIndex = 15
        Me.bResetHistory.Text = "history"
        Me.bResetHistory.UseVisualStyleBackColor = True
        '
        'bResetBookmarks
        '
        Me.bResetBookmarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResetBookmarks.FlatAppearance.BorderSize = 0
        Me.bResetBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetBookmarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bResetBookmarks.Location = New System.Drawing.Point(6, 102)
        Me.bResetBookmarks.Name = "bResetBookmarks"
        Me.bResetBookmarks.Size = New System.Drawing.Size(100, 32)
        Me.bResetBookmarks.TabIndex = 14
        Me.bResetBookmarks.Text = "bookmarks"
        Me.bResetBookmarks.UseVisualStyleBackColor = True
        '
        'bResetMemory
        '
        Me.bResetMemory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bResetMemory.FlatAppearance.BorderSize = 0
        Me.bResetMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bResetMemory.Location = New System.Drawing.Point(218, 102)
        Me.bResetMemory.Name = "bResetMemory"
        Me.bResetMemory.Size = New System.Drawing.Size(100, 32)
        Me.bResetMemory.TabIndex = 16
        Me.bResetMemory.Text = "memory"
        Me.bResetMemory.UseVisualStyleBackColor = True
        '
        'boxPrivacy
        '
        Me.boxPrivacy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxPrivacy.Controls.Add(Me.bResetBrowser)
        Me.boxPrivacy.Controls.Add(Me.txtReset)
        Me.boxPrivacy.Controls.Add(Me.bResetMemory)
        Me.boxPrivacy.Controls.Add(Me.txtNewPin)
        Me.boxPrivacy.Controls.Add(Me.bResetHistory)
        Me.boxPrivacy.Controls.Add(Me.tbNewPin)
        Me.boxPrivacy.Controls.Add(Me.txtPin)
        Me.boxPrivacy.Controls.Add(Me.bResetBookmarks)
        Me.boxPrivacy.Controls.Add(Me.tbPin)
        Me.boxPrivacy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.boxPrivacy.Location = New System.Drawing.Point(12, 209)
        Me.boxPrivacy.Name = "boxPrivacy"
        Me.boxPrivacy.Size = New System.Drawing.Size(460, 140)
        Me.boxPrivacy.TabIndex = 17
        Me.boxPrivacy.TabStop = False
        Me.boxPrivacy.Text = "privacy"
        '
        'bResetBrowser
        '
        Me.bResetBrowser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bResetBrowser.FlatAppearance.BorderSize = 0
        Me.bResetBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bResetBrowser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bResetBrowser.Location = New System.Drawing.Point(354, 102)
        Me.bResetBrowser.Name = "bResetBrowser"
        Me.bResetBrowser.Size = New System.Drawing.Size(100, 32)
        Me.bResetBrowser.TabIndex = 18
        Me.bResetBrowser.Text = "browser"
        Me.bResetBrowser.UseVisualStyleBackColor = True
        '
        'txtReset
        '
        Me.txtReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtReset.AutoSize = True
        Me.txtReset.Location = New System.Drawing.Point(2, 79)
        Me.txtReset.Name = "txtReset"
        Me.txtReset.Size = New System.Drawing.Size(55, 20)
        Me.txtReset.TabIndex = 17
        Me.txtReset.Text = "reset..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbTopNav)
        Me.GroupBox1.Controls.Add(Me.cbHideWelcome)
        Me.GroupBox1.Controls.Add(Me.txtHome)
        Me.GroupBox1.Controls.Add(Me.tbHome)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 191)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "preferences"
        '
        'cbTopNav
        '
        Me.cbTopNav.AutoSize = True
        Me.cbTopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTopNav.Location = New System.Drawing.Point(6, 102)
        Me.cbTopNav.Name = "cbTopNav"
        Me.cbTopNav.Size = New System.Drawing.Size(125, 24)
        Me.cbTopNav.TabIndex = 15
        Me.cbTopNav.Text = "top navigation"
        Me.cbTopNav.UseVisualStyleBackColor = True
        '
        'cbHideWelcome
        '
        Me.cbHideWelcome.AutoSize = True
        Me.cbHideWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHideWelcome.Location = New System.Drawing.Point(6, 72)
        Me.cbHideWelcome.Name = "cbHideWelcome"
        Me.cbHideWelcome.Size = New System.Drawing.Size(158, 24)
        Me.cbHideWelcome.TabIndex = 14
        Me.cbHideWelcome.Text = "hide welcome page"
        Me.cbHideWelcome.UseVisualStyleBackColor = True
        '
        'txtHome
        '
        Me.txtHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHome.AutoSize = True
        Me.txtHome.Location = New System.Drawing.Point(2, 23)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(48, 20)
        Me.txtHome.TabIndex = 13
        Me.txtHome.Text = "home"
        '
        'tbHome
        '
        Me.tbHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbHome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbHome.Location = New System.Drawing.Point(6, 46)
        Me.tbHome.Name = "tbHome"
        Me.tbHome.Size = New System.Drawing.Size(448, 20)
        Me.tbHome.TabIndex = 12
        '
        'fOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.boxPrivacy)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fOptions"
        Me.Text = "options"
        Me.boxPrivacy.ResumeLayout(False)
        Me.boxPrivacy.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbNewPin As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPin As System.Windows.Forms.Label
    Friend WithEvents tbPin As System.Windows.Forms.TextBox
    Friend WithEvents txtPin As System.Windows.Forms.Label
    Friend WithEvents bResetHistory As System.Windows.Forms.Button
    Friend WithEvents bResetBookmarks As System.Windows.Forms.Button
    Friend WithEvents bResetMemory As System.Windows.Forms.Button
    Friend WithEvents boxPrivacy As System.Windows.Forms.GroupBox
    Friend WithEvents txtReset As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bResetBrowser As System.Windows.Forms.Button
    Friend WithEvents txtHome As System.Windows.Forms.Label
    Friend WithEvents tbHome As System.Windows.Forms.TextBox
    Friend WithEvents cbTopNav As System.Windows.Forms.CheckBox
    Friend WithEvents cbHideWelcome As System.Windows.Forms.CheckBox
End Class
