<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeeInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeeInformation))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.employeeId = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.mI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.contactNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dateBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.TextBox()
        Me.hiringRate = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.hiringDate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxQr = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBoxQr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee ID:"
        '
        'employeeId
        '
        Me.employeeId.Enabled = False
        Me.employeeId.Location = New System.Drawing.Point(102, 26)
        Me.employeeId.Multiline = True
        Me.employeeId.Name = "employeeId"
        Me.employeeId.Size = New System.Drawing.Size(134, 20)
        Me.employeeId.TabIndex = 4
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(102, 54)
        Me.lastName.Multiline = True
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(134, 20)
        Me.lastName.TabIndex = 6
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(102, 83)
        Me.firstName.Multiline = True
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(134, 20)
        Me.firstName.TabIndex = 7
        '
        'mI
        '
        Me.mI.Location = New System.Drawing.Point(102, 113)
        Me.mI.Multiline = True
        Me.mI.Name = "mI"
        Me.mI.Size = New System.Drawing.Size(134, 20)
        Me.mI.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LastName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "FirstName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Middle Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address:"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(103, 158)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(300, 48)
        Me.address.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact No:"
        '
        'contactNo
        '
        Me.contactNo.Location = New System.Drawing.Point(103, 212)
        Me.contactNo.Multiline = True
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(134, 20)
        Me.contactNo.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(256, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sex:"
        '
        'sex
        '
        Me.sex.FormattingEnabled = True
        Me.sex.Items.AddRange(New Object() {"Male ", "Female"})
        Me.sex.Location = New System.Drawing.Point(290, 211)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(113, 21)
        Me.sex.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Date of Birth;"
        '
        'dateBirth
        '
        Me.dateBirth.CustomFormat = "yyyy-MM-dd"
        Me.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateBirth.Location = New System.Drawing.Point(103, 239)
        Me.dateBirth.Name = "dateBirth"
        Me.dateBirth.Size = New System.Drawing.Size(202, 20)
        Me.dateBirth.TabIndex = 19
        Me.dateBirth.Value = New Date(2024, 9, 25, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Position:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Hiring Rate:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Hiring Date:"
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(102, 29)
        Me.position.Multiline = True
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(134, 20)
        Me.position.TabIndex = 33
        '
        'hiringRate
        '
        Me.hiringRate.Location = New System.Drawing.Point(102, 59)
        Me.hiringRate.Multiline = True
        Me.hiringRate.Name = "hiringRate"
        Me.hiringRate.Size = New System.Drawing.Size(134, 20)
        Me.hiringRate.TabIndex = 34
        '
        'SaveBtn
        '
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBtn.Location = New System.Drawing.Point(17, 140)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(219, 30)
        Me.SaveBtn.TabIndex = 39
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'hiringDate
        '
        Me.hiringDate.CustomFormat = "yyyy-MM-dd"
        Me.hiringDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hiringDate.Location = New System.Drawing.Point(102, 90)
        Me.hiringDate.Name = "hiringDate"
        Me.hiringDate.Size = New System.Drawing.Size(134, 20)
        Me.hiringDate.TabIndex = 42
        '
        'PictureBoxQr
        '
        Me.PictureBoxQr.Location = New System.Drawing.Point(258, 29)
        Me.PictureBoxQr.Name = "PictureBoxQr"
        Me.PictureBoxQr.Size = New System.Drawing.Size(141, 141)
        Me.PictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxQr.TabIndex = 44
        Me.PictureBoxQr.TabStop = False
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Image = CType(resources.GetObject("PictureBoxProfile.Image"), System.Drawing.Image)
        Me.PictureBoxProfile.Location = New System.Drawing.Point(265, 19)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(137, 113)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProfile.TabIndex = 45
        Me.PictureBoxProfile.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(262, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Browse Image"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.employeeId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lastName)
        Me.GroupBox1.Controls.Add(Me.PictureBoxProfile)
        Me.GroupBox1.Controls.Add(Me.firstName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mI)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.contactNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dateBirth)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.sex)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 295)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.position)
        Me.GroupBox2.Controls.Add(Me.SaveBtn)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.hiringRate)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.PictureBoxQr)
        Me.GroupBox2.Controls.Add(Me.hiringDate)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 188)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hiring Details"
        '
        'employeeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "employeeInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        CType(Me.PictureBoxQr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents employeeId As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents firstName As TextBox
    Friend WithEvents mI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents contactNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents sex As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dateBirth As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents position As TextBox
    Friend WithEvents hiringRate As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents hiringDate As DateTimePicker
    Friend WithEvents PictureBoxQr As PictureBox
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
