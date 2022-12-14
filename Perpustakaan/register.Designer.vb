<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnRegistrasi = New System.Windows.Forms.Button()
        Me.lbllog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(180, 12)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(230, 23)
        Me.TxtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(180, 67)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(230, 23)
        Me.TxtPassword.TabIndex = 3
        '
        'BtnRegistrasi
        '
        Me.BtnRegistrasi.Location = New System.Drawing.Point(335, 125)
        Me.BtnRegistrasi.Name = "BtnRegistrasi"
        Me.BtnRegistrasi.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrasi.TabIndex = 4
        Me.BtnRegistrasi.Text = "Registrasi"
        Me.BtnRegistrasi.UseVisualStyleBackColor = True
        '
        'lbllog
        '
        Me.lbllog.AutoSize = True
        Me.lbllog.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbllog.Location = New System.Drawing.Point(76, 129)
        Me.lbllog.Name = "lbllog"
        Me.lbllog.Size = New System.Drawing.Size(194, 15)
        Me.lbllog.TabIndex = 5
        Me.lbllog.Text = "Sudah Punya Account? Login Disini"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources._1134714
        Me.ClientSize = New System.Drawing.Size(490, 171)
        Me.Controls.Add(Me.lbllog)
        Me.Controls.Add(Me.BtnRegistrasi)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUsername)
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnRegistrasi As Button
    Friend WithEvents lbllog As Label
End Class
