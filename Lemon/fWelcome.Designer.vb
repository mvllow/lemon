<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fWelcome))
        Me.tbPin = New System.Windows.Forms.TextBox()
        Me.cbRemember = New System.Windows.Forms.CheckBox()
        Me.tbNewPin = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.Label()
        Me.txtNewPin = New System.Windows.Forms.Label()
        Me.webWelcome = New System.Windows.Forms.WebBrowser()
        Me.txtVersion = New System.Windows.Forms.Label()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bUnlock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPin
        '
        Me.tbPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbPin.Location = New System.Drawing.Point(556, 338)
        Me.tbPin.MaxLength = 4
        Me.tbPin.Name = "tbPin"
        Me.tbPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.tbPin.Size = New System.Drawing.Size(94, 20)
        Me.tbPin.TabIndex = 1
        '
        'cbRemember
        '
        Me.cbRemember.AutoSize = True
        Me.cbRemember.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRemember.Location = New System.Drawing.Point(556, 364)
        Me.cbRemember.Name = "cbRemember"
        Me.cbRemember.Size = New System.Drawing.Size(94, 24)
        Me.cbRemember.TabIndex = 3
        Me.cbRemember.Text = "remember"
        Me.cbRemember.UseVisualStyleBackColor = True
        '
        'tbNewPin
        '
        Me.tbNewPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbNewPin.Location = New System.Drawing.Point(556, 292)
        Me.tbNewPin.MaxLength = 4
        Me.tbNewPin.Name = "tbNewPin"
        Me.tbNewPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.tbNewPin.Size = New System.Drawing.Size(94, 20)
        Me.tbNewPin.TabIndex = 0
        '
        'txtPin
        '
        Me.txtPin.AutoSize = True
        Me.txtPin.Location = New System.Drawing.Point(552, 315)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(31, 20)
        Me.txtPin.TabIndex = 10
        Me.txtPin.Text = "pin"
        '
        'txtNewPin
        '
        Me.txtNewPin.AutoSize = True
        Me.txtNewPin.Location = New System.Drawing.Point(552, 269)
        Me.txtNewPin.Name = "txtNewPin"
        Me.txtNewPin.Size = New System.Drawing.Size(63, 20)
        Me.txtNewPin.TabIndex = 11
        Me.txtNewPin.Text = "new pin"
        '
        'webWelcome
        '
        Me.webWelcome.IsWebBrowserContextMenuEnabled = False
        Me.webWelcome.Location = New System.Drawing.Point(12, 12)
        Me.webWelcome.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webWelcome.Name = "webWelcome"
        Me.webWelcome.Size = New System.Drawing.Size(534, 376)
        Me.webWelcome.TabIndex = 13
        Me.webWelcome.WebBrowserShortcutsEnabled = False
        '
        'txtVersion
        '
        Me.txtVersion.AutoSize = True
        Me.txtVersion.Location = New System.Drawing.Point(552, 18)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(53, 20)
        Me.txtVersion.TabIndex = 14
        Me.txtVersion.Text = "0.0.0.0"
        '
        'bClose
        '
        Me.bClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bClose.BackgroundImage = Global.Lemon.My.Resources.Resources.cancel
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.ForeColor = System.Drawing.SystemColors.Control
        Me.bClose.Location = New System.Drawing.Point(656, 12)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(32, 32)
        Me.bClose.TabIndex = 12
        Me.bClose.UseVisualStyleBackColor = True
        '
        'bUnlock
        '
        Me.bUnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bUnlock.BackgroundImage = Global.Lemon.My.Resources.Resources.unlock
        Me.bUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUnlock.ForeColor = System.Drawing.SystemColors.Control
        Me.bUnlock.Location = New System.Drawing.Point(656, 332)
        Me.bUnlock.Name = "bUnlock"
        Me.bUnlock.Size = New System.Drawing.Size(32, 32)
        Me.bUnlock.TabIndex = 2
        Me.bUnlock.UseVisualStyleBackColor = True
        '
        'fWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bClose
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.webWelcome)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.txtNewPin)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.tbNewPin)
        Me.Controls.Add(Me.cbRemember)
        Me.Controls.Add(Me.bUnlock)
        Me.Controls.Add(Me.tbPin)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "welcome"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbPin As System.Windows.Forms.TextBox
    Friend WithEvents bUnlock As System.Windows.Forms.Button
    Friend WithEvents cbRemember As System.Windows.Forms.CheckBox
    Friend WithEvents tbNewPin As System.Windows.Forms.TextBox
    Friend WithEvents txtPin As System.Windows.Forms.Label
    Friend WithEvents txtNewPin As System.Windows.Forms.Label
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents webWelcome As System.Windows.Forms.WebBrowser
    Friend WithEvents txtVersion As System.Windows.Forms.Label
End Class
