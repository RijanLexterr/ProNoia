<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeePayroll
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
        Me.empBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fromPicker = New System.Windows.Forms.DateTimePicker()
        Me.toPicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblph = New System.Windows.Forms.Label()
        Me.lblpbg = New System.Windows.Forms.Label()
        Me.lblsss = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblTotalHrs = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'empBox
        '
        Me.empBox.FormattingEnabled = True
        Me.empBox.Location = New System.Drawing.Point(71, 12)
        Me.empBox.Name = "empBox"
        Me.empBox.Size = New System.Drawing.Size(195, 21)
        Me.empBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'fromPicker
        '
        Me.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromPicker.Location = New System.Drawing.Point(308, 12)
        Me.fromPicker.Name = "fromPicker"
        Me.fromPicker.Size = New System.Drawing.Size(81, 20)
        Me.fromPicker.TabIndex = 4
        '
        'toPicker
        '
        Me.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toPicker.Location = New System.Drawing.Point(308, 38)
        Me.toPicker.Name = "toPicker"
        Me.toPicker.Size = New System.Drawing.Size(81, 20)
        Me.toPicker.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(458, 387)
        Me.DataGridView1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblph)
        Me.GroupBox1.Controls.Add(Me.lblpbg)
        Me.GroupBox1.Controls.Add(Me.lblsss)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(491, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 147)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deductions"
        '
        'lblph
        '
        Me.lblph.AutoSize = True
        Me.lblph.Location = New System.Drawing.Point(132, 113)
        Me.lblph.Name = "lblph"
        Me.lblph.Size = New System.Drawing.Size(0, 13)
        Me.lblph.TabIndex = 5
        '
        'lblpbg
        '
        Me.lblpbg.AutoSize = True
        Me.lblpbg.Location = New System.Drawing.Point(132, 73)
        Me.lblpbg.Name = "lblpbg"
        Me.lblpbg.Size = New System.Drawing.Size(0, 13)
        Me.lblpbg.TabIndex = 4
        '
        'lblsss
        '
        Me.lblsss.AutoSize = True
        Me.lblsss.Location = New System.Drawing.Point(132, 39)
        Me.lblsss.Name = "lblsss"
        Me.lblsss.Size = New System.Drawing.Size(0, 13)
        Me.lblsss.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Philhealth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pag-ibig"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SSS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNet)
        Me.GroupBox2.Controls.Add(Me.lblGross)
        Me.GroupBox2.Controls.Add(Me.lblRate)
        Me.GroupBox2.Controls.Add(Me.lblTotalHrs)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(491, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 158)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(172, 121)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(0, 13)
        Me.lblNet.TabIndex = 7
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(172, 95)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(0, 13)
        Me.lblGross.TabIndex = 6
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(172, 67)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(0, 13)
        Me.lblRate.TabIndex = 5
        '
        'lblTotalHrs
        '
        Me.lblTotalHrs.AutoSize = True
        Me.lblTotalHrs.Location = New System.Drawing.Point(172, 37)
        Me.lblTotalHrs.Name = "lblTotalHrs"
        Me.lblTotalHrs.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalHrs.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Net Pay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Gross Pay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Rate/Hr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Number of Hours"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(491, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 55)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Save/Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(626, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 55)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'employeePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 485)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.toPicker)
        Me.Controls.Add(Me.fromPicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empBox)
        Me.Name = "employeePayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employeePayroll"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents empBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fromPicker As DateTimePicker
    Friend WithEvents toPicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblsss As Label
    Friend WithEvents lblph As Label
    Friend WithEvents lblpbg As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblTotalHrs As Label
End Class
