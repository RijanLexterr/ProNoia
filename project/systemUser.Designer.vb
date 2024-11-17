<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class systemUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFisrtname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblStrongWeak = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFisrtname
        '
        Me.txtFisrtname.Location = New System.Drawing.Point(26, 109)
        Me.txtFisrtname.Multiline = True
        Me.txtFisrtname.Name = "txtFisrtname"
        Me.txtFisrtname.Size = New System.Drawing.Size(267, 31)
        Me.txtFisrtname.TabIndex = 2
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(26, 171)
        Me.txtLastname.Multiline = True
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(267, 31)
        Me.txtLastname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lastname"
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Location = New System.Drawing.Point(26, 346)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(118, 47)
        Me.RegisterBtn.TabIndex = 6
        Me.RegisterBtn.Text = "Save"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(25, 232)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(267, 31)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(26, 43)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(267, 31)
        Me.txtUsername.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(26, 295)
        Me.txtConfirmPassword.Multiline = True
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(267, 31)
        Me.txtConfirmPassword.TabIndex = 12
        '
        'lblStrongWeak
        '
        Me.lblStrongWeak.AutoSize = True
        Me.lblStrongWeak.Location = New System.Drawing.Point(26, 263)
        Me.lblStrongWeak.Name = "lblStrongWeak"
        Me.lblStrongWeak.Size = New System.Drawing.Size(39, 13)
        Me.lblStrongWeak.TabIndex = 15
        Me.lblStrongWeak.Text = "Label3"
        Me.lblStrongWeak.Visible = False
        '
        'systemUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 416)
        Me.Controls.Add(Me.lblStrongWeak)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFisrtname)
        Me.Controls.Add(Me.Button1)
        Me.Name = "systemUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "systemUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtFisrtname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblStrongWeak As Label
End Class
