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
        Me.txtHomepage = New System.Windows.Forms.Label()
        Me.tbHomepage = New System.Windows.Forms.TextBox()
        Me.bCurrentPage = New System.Windows.Forms.Button()
        Me.bSetHomepage = New System.Windows.Forms.Button()
        Me.txtSearchEngine = New System.Windows.Forms.Label()
        Me.txtTheme = New System.Windows.Forms.Label()
        Me.comboTheme = New System.Windows.Forms.ComboBox()
        Me.comboSearch = New System.Windows.Forms.ComboBox()
        Me.cbTopSearchBar = New System.Windows.Forms.CheckBox()
        Me.bChangePassword = New System.Windows.Forms.Button()
        Me.tbOldPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.Label()
        Me.cbEarlyReleases = New System.Windows.Forms.CheckBox()
        Me.gbPreferences = New System.Windows.Forms.GroupBox()
        Me.cbStartLocked = New System.Windows.Forms.CheckBox()
        Me.gbPreferences.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHomepage
        '
        Me.txtHomepage.AutoSize = True
        Me.txtHomepage.Location = New System.Drawing.Point(8, 13)
        Me.txtHomepage.Name = "txtHomepage"
        Me.txtHomepage.Size = New System.Drawing.Size(85, 21)
        Me.txtHomepage.TabIndex = 0
        Me.txtHomepage.Text = "Homepage"
        '
        'tbHomepage
        '
        Me.tbHomepage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHomepage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbHomepage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbHomepage.BackColor = System.Drawing.Color.DimGray
        Me.tbHomepage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHomepage.ForeColor = System.Drawing.Color.White
        Me.tbHomepage.Location = New System.Drawing.Point(12, 37)
        Me.tbHomepage.Name = "tbHomepage"
        Me.tbHomepage.Size = New System.Drawing.Size(356, 22)
        Me.tbHomepage.TabIndex = 1
        '
        'bCurrentPage
        '
        Me.bCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bCurrentPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bCurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCurrentPage.ForeColor = System.Drawing.Color.White
        Me.bCurrentPage.Location = New System.Drawing.Point(412, 31)
        Me.bCurrentPage.Name = "bCurrentPage"
        Me.bCurrentPage.Size = New System.Drawing.Size(110, 32)
        Me.bCurrentPage.TabIndex = 3
        Me.bCurrentPage.Text = "Current Page"
        Me.bCurrentPage.UseVisualStyleBackColor = True
        '
        'bSetHomepage
        '
        Me.bSetHomepage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bSetHomepage.BackgroundImage = Global.Lemon.My.Resources.Resources.accept_light
        Me.bSetHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bSetHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSetHomepage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bSetHomepage.Location = New System.Drawing.Point(374, 31)
        Me.bSetHomepage.Name = "bSetHomepage"
        Me.bSetHomepage.Size = New System.Drawing.Size(32, 32)
        Me.bSetHomepage.TabIndex = 2
        Me.bSetHomepage.UseVisualStyleBackColor = True
        '
        'txtSearchEngine
        '
        Me.txtSearchEngine.AutoSize = True
        Me.txtSearchEngine.Location = New System.Drawing.Point(248, 193)
        Me.txtSearchEngine.Name = "txtSearchEngine"
        Me.txtSearchEngine.Size = New System.Drawing.Size(105, 21)
        Me.txtSearchEngine.TabIndex = 6
        Me.txtSearchEngine.Text = "Search Engine"
        '
        'txtTheme
        '
        Me.txtTheme.AutoSize = True
        Me.txtTheme.Location = New System.Drawing.Point(8, 193)
        Me.txtTheme.Name = "txtTheme"
        Me.txtTheme.Size = New System.Drawing.Size(56, 21)
        Me.txtTheme.TabIndex = 7
        Me.txtTheme.Text = "Theme"
        '
        'comboTheme
        '
        Me.comboTheme.BackColor = System.Drawing.Color.DimGray
        Me.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboTheme.ForeColor = System.Drawing.Color.White
        Me.comboTheme.FormattingEnabled = True
        Me.comboTheme.Items.AddRange(New Object() {"Light", "Dark"})
        Me.comboTheme.Location = New System.Drawing.Point(12, 217)
        Me.comboTheme.Name = "comboTheme"
        Me.comboTheme.Size = New System.Drawing.Size(150, 29)
        Me.comboTheme.TabIndex = 7
        '
        'comboSearch
        '
        Me.comboSearch.BackColor = System.Drawing.Color.DimGray
        Me.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboSearch.ForeColor = System.Drawing.Color.White
        Me.comboSearch.FormattingEnabled = True
        Me.comboSearch.Items.AddRange(New Object() {"Google", "Bing", "YouTube"})
        Me.comboSearch.Location = New System.Drawing.Point(252, 217)
        Me.comboSearch.Name = "comboSearch"
        Me.comboSearch.Size = New System.Drawing.Size(150, 29)
        Me.comboSearch.TabIndex = 8
        '
        'cbTopSearchBar
        '
        Me.cbTopSearchBar.AutoSize = True
        Me.cbTopSearchBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTopSearchBar.Location = New System.Drawing.Point(6, 28)
        Me.cbTopSearchBar.Name = "cbTopSearchBar"
        Me.cbTopSearchBar.Size = New System.Drawing.Size(122, 25)
        Me.cbTopSearchBar.TabIndex = 9
        Me.cbTopSearchBar.Text = "Top search bar"
        Me.cbTopSearchBar.UseVisualStyleBackColor = True
        '
        'bChangePassword
        '
        Me.bChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bChangePassword.BackgroundImage = Global.Lemon.My.Resources.Resources.accept_light
        Me.bChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bChangePassword.Location = New System.Drawing.Point(490, 121)
        Me.bChangePassword.Name = "bChangePassword"
        Me.bChangePassword.Size = New System.Drawing.Size(32, 32)
        Me.bChangePassword.TabIndex = 6
        Me.bChangePassword.UseVisualStyleBackColor = True
        '
        'tbOldPassword
        '
        Me.tbOldPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbOldPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbOldPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbOldPassword.BackColor = System.Drawing.Color.DimGray
        Me.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbOldPassword.ForeColor = System.Drawing.Color.White
        Me.tbOldPassword.Location = New System.Drawing.Point(12, 127)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.Size = New System.Drawing.Size(232, 22)
        Me.tbOldPassword.TabIndex = 4
        '
        'txtOldPassword
        '
        Me.txtOldPassword.AutoSize = True
        Me.txtOldPassword.Location = New System.Drawing.Point(8, 103)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtOldPassword.TabIndex = 12
        Me.txtOldPassword.Text = "Old Password"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.tbNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbNewPassword.BackColor = System.Drawing.Color.DimGray
        Me.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewPassword.ForeColor = System.Drawing.Color.White
        Me.tbNewPassword.Location = New System.Drawing.Point(252, 127)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(232, 22)
        Me.tbNewPassword.TabIndex = 5
        '
        'txtNewPassword
        '
        Me.txtNewPassword.AutoSize = True
        Me.txtNewPassword.Location = New System.Drawing.Point(248, 103)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(106, 21)
        Me.txtNewPassword.TabIndex = 15
        Me.txtNewPassword.Text = "New Password"
        '
        'cbEarlyReleases
        '
        Me.cbEarlyReleases.AutoSize = True
        Me.cbEarlyReleases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEarlyReleases.Location = New System.Drawing.Point(6, 59)
        Me.cbEarlyReleases.Name = "cbEarlyReleases"
        Me.cbEarlyReleases.Size = New System.Drawing.Size(141, 25)
        Me.cbEarlyReleases.TabIndex = 16
        Me.cbEarlyReleases.Text = "Get early releases"
        Me.cbEarlyReleases.UseVisualStyleBackColor = True
        '
        'gbPreferences
        '
        Me.gbPreferences.Controls.Add(Me.cbStartLocked)
        Me.gbPreferences.Controls.Add(Me.cbTopSearchBar)
        Me.gbPreferences.Controls.Add(Me.cbEarlyReleases)
        Me.gbPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbPreferences.ForeColor = System.Drawing.Color.White
        Me.gbPreferences.Location = New System.Drawing.Point(12, 296)
        Me.gbPreferences.Name = "gbPreferences"
        Me.gbPreferences.Size = New System.Drawing.Size(510, 103)
        Me.gbPreferences.TabIndex = 17
        Me.gbPreferences.TabStop = False
        Me.gbPreferences.Text = "Preferences"
        '
        'cbStartLocked
        '
        Me.cbStartLocked.AutoSize = True
        Me.cbStartLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStartLocked.Location = New System.Drawing.Point(175, 28)
        Me.cbStartLocked.Name = "cbStartLocked"
        Me.cbStartLocked.Size = New System.Drawing.Size(169, 25)
        Me.cbStartLocked.TabIndex = 17
        Me.cbStartLocked.Text = "Lock browser on start"
        Me.cbStartLocked.UseVisualStyleBackColor = True
        '
        'fOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.gbPreferences)
        Me.Controls.Add(Me.tbNewPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.bChangePassword)
        Me.Controls.Add(Me.tbOldPassword)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.comboSearch)
        Me.Controls.Add(Me.comboTheme)
        Me.Controls.Add(Me.txtTheme)
        Me.Controls.Add(Me.txtSearchEngine)
        Me.Controls.Add(Me.bSetHomepage)
        Me.Controls.Add(Me.bCurrentPage)
        Me.Controls.Add(Me.tbHomepage)
        Me.Controls.Add(Me.txtHomepage)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 450)
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "fOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        Me.gbPreferences.ResumeLayout(False)
        Me.gbPreferences.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHomepage As System.Windows.Forms.Label
    Friend WithEvents tbHomepage As System.Windows.Forms.TextBox
    Friend WithEvents bCurrentPage As System.Windows.Forms.Button
    Friend WithEvents bSetHomepage As System.Windows.Forms.Button
    Friend WithEvents txtSearchEngine As System.Windows.Forms.Label
    Friend WithEvents txtTheme As System.Windows.Forms.Label
    Friend WithEvents comboTheme As System.Windows.Forms.ComboBox
    Friend WithEvents comboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cbTopSearchBar As System.Windows.Forms.CheckBox
    Friend WithEvents bChangePassword As System.Windows.Forms.Button
    Friend WithEvents tbOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.Label
    Friend WithEvents tbNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.Label
    Friend WithEvents cbEarlyReleases As System.Windows.Forms.CheckBox
    Friend WithEvents gbPreferences As System.Windows.Forms.GroupBox
    Friend WithEvents cbStartLocked As System.Windows.Forms.CheckBox
End Class
