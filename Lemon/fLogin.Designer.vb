<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLogin))
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.bUnlock = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.bUser = New System.Windows.Forms.Button()
        Me.bGuest = New System.Windows.Forms.Button()
        Me.bIncognito = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.bMinimize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(12, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(172, 32)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Browser Locked"
        '
        'bUnlock
        '
        Me.bUnlock.BackgroundImage = Global.Lemon.My.Resources.Resources.unlock_light
        Me.bUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUnlock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bUnlock.Location = New System.Drawing.Point(280, 206)
        Me.bUnlock.Name = "bUnlock"
        Me.bUnlock.Size = New System.Drawing.Size(32, 32)
        Me.bUnlock.TabIndex = 4
        Me.bUnlock.UseVisualStyleBackColor = True
        '
        'bClose
        '
        Me.bClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bClose.BackgroundImage = Global.Lemon.My.Resources.Resources.cancel_light
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bClose.Location = New System.Drawing.Point(280, 12)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(32, 32)
        Me.bClose.TabIndex = 6
        Me.bClose.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPassword.BackColor = System.Drawing.Color.DimGray
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPassword.ForeColor = System.Drawing.Color.White
        Me.tbPassword.Location = New System.Drawing.Point(12, 212)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(260, 22)
        Me.tbPassword.TabIndex = 7
        '
        'bUser
        '
        Me.bUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUser.ForeColor = System.Drawing.Color.White
        Me.bUser.Image = Global.Lemon.My.Resources.Resources.user_light
        Me.bUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bUser.Location = New System.Drawing.Point(12, 65)
        Me.bUser.Name = "bUser"
        Me.bUser.Size = New System.Drawing.Size(96, 96)
        Me.bUser.TabIndex = 8
        Me.bUser.Text = "User"
        Me.bUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bUser.UseVisualStyleBackColor = True
        '
        'bGuest
        '
        Me.bGuest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuest.ForeColor = System.Drawing.Color.White
        Me.bGuest.Image = CType(resources.GetObject("bGuest.Image"), System.Drawing.Image)
        Me.bGuest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bGuest.Location = New System.Drawing.Point(114, 65)
        Me.bGuest.Name = "bGuest"
        Me.bGuest.Size = New System.Drawing.Size(96, 96)
        Me.bGuest.TabIndex = 9
        Me.bGuest.Text = "Guest"
        Me.bGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bGuest.UseVisualStyleBackColor = True
        '
        'bIncognito
        '
        Me.bIncognito.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bIncognito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bIncognito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIncognito.ForeColor = System.Drawing.Color.White
        Me.bIncognito.Image = CType(resources.GetObject("bIncognito.Image"), System.Drawing.Image)
        Me.bIncognito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bIncognito.Location = New System.Drawing.Point(216, 65)
        Me.bIncognito.Name = "bIncognito"
        Me.bIncognito.Size = New System.Drawing.Size(96, 96)
        Me.bIncognito.TabIndex = 10
        Me.bIncognito.Text = "Incognito"
        Me.bIncognito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bIncognito.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.txtPassword.Location = New System.Drawing.Point(8, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(72, 21)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "Password"
        '
        'bMinimize
        '
        Me.bMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bMinimize.BackgroundImage = Global.Lemon.My.Resources.Resources.minimize_light
        Me.bMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bMinimize.Location = New System.Drawing.Point(242, 12)
        Me.bMinimize.Name = "bMinimize"
        Me.bMinimize.Size = New System.Drawing.Size(32, 32)
        Me.bMinimize.TabIndex = 12
        Me.bMinimize.UseVisualStyleBackColor = True
        '
        'fLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 175)
        Me.Controls.Add(Me.bMinimize)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.bIncognito)
        Me.Controls.Add(Me.bGuest)
        Me.Controls.Add(Me.bUser)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bUnlock)
        Me.Controls.Add(Me.txtTitle)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(324, 250)
        Me.MinimumSize = New System.Drawing.Size(324, 175)
        Me.Name = "fLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents bUnlock As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents bUser As System.Windows.Forms.Button
    Friend WithEvents bGuest As System.Windows.Forms.Button
    Friend WithEvents bIncognito As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.Label
    Friend WithEvents bMinimize As System.Windows.Forms.Button
End Class
