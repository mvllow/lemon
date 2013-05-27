<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSplash
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
        Me.txtLemonBrowser = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLemonBrowser
        '
        Me.txtLemonBrowser.AutoSize = True
        Me.txtLemonBrowser.Font = New System.Drawing.Font("Urban Jungle", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLemonBrowser.Location = New System.Drawing.Point(6, 8)
        Me.txtLemonBrowser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtLemonBrowser.Name = "txtLemonBrowser"
        Me.txtLemonBrowser.Size = New System.Drawing.Size(383, 48)
        Me.txtLemonBrowser.TabIndex = 1
        Me.txtLemonBrowser.Text = "Lemon Browser"
        '
        'txtVersion
        '
        Me.txtVersion.AutoSize = True
        Me.txtVersion.Location = New System.Drawing.Point(159, 72)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(76, 21)
        Me.txtVersion.TabIndex = 2
        Me.txtVersion.Text = "Loading..."
        Me.txtVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 102)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtLemonBrowser)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLemonBrowser As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.Label
End Class
