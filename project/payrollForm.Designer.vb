<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payrollForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payrollForm))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RatePerHour = New System.Windows.Forms.TextBox()
        Me.HourPerDay = New System.Windows.Forms.TextBox()
        Me.NumberofDaysWorked = New System.Windows.Forms.TextBox()
        Me.GrossSalary1 = New System.Windows.Forms.TextBox()
        Me.MonthlyWage = New System.Windows.Forms.TextBox()
        Me.Philhealth = New System.Windows.Forms.TextBox()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.TotalDeduction = New System.Windows.Forms.TextBox()
        Me.GrossSalary2 = New System.Windows.Forms.TextBox()
        Me.Deduction = New System.Windows.Forms.TextBox()
        Me.NetSalary = New System.Windows.Forms.TextBox()
        Me.ComputeBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackBtn.Location = New System.Drawing.Point(521, 640)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(115, 52)
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.Text = "back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, -2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(851, 230)
        Me.DataGridView1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 43)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 29)
        Me.TextBox1.TabIndex = 2
        '
        'RatePerHour
        '
        Me.RatePerHour.Location = New System.Drawing.Point(27, 112)
        Me.RatePerHour.Multiline = True
        Me.RatePerHour.Name = "RatePerHour"
        Me.RatePerHour.Size = New System.Drawing.Size(221, 29)
        Me.RatePerHour.TabIndex = 3
        '
        'HourPerDay
        '
        Me.HourPerDay.Location = New System.Drawing.Point(27, 177)
        Me.HourPerDay.Multiline = True
        Me.HourPerDay.Name = "HourPerDay"
        Me.HourPerDay.Size = New System.Drawing.Size(221, 29)
        Me.HourPerDay.TabIndex = 4
        '
        'NumberofDaysWorked
        '
        Me.NumberofDaysWorked.Location = New System.Drawing.Point(27, 251)
        Me.NumberofDaysWorked.Multiline = True
        Me.NumberofDaysWorked.Name = "NumberofDaysWorked"
        Me.NumberofDaysWorked.Size = New System.Drawing.Size(221, 29)
        Me.NumberofDaysWorked.TabIndex = 5
        '
        'GrossSalary1
        '
        Me.GrossSalary1.Cursor = System.Windows.Forms.Cursors.No
        Me.GrossSalary1.Location = New System.Drawing.Point(27, 329)
        Me.GrossSalary1.Multiline = True
        Me.GrossSalary1.Name = "GrossSalary1"
        Me.GrossSalary1.ReadOnly = True
        Me.GrossSalary1.Size = New System.Drawing.Size(221, 29)
        Me.GrossSalary1.TabIndex = 6
        '
        'MonthlyWage
        '
        Me.MonthlyWage.Cursor = System.Windows.Forms.Cursors.No
        Me.MonthlyWage.Location = New System.Drawing.Point(307, 43)
        Me.MonthlyWage.Multiline = True
        Me.MonthlyWage.Name = "MonthlyWage"
        Me.MonthlyWage.ReadOnly = True
        Me.MonthlyWage.Size = New System.Drawing.Size(221, 29)
        Me.MonthlyWage.TabIndex = 7
        '
        'Philhealth
        '
        Me.Philhealth.Cursor = System.Windows.Forms.Cursors.No
        Me.Philhealth.Location = New System.Drawing.Point(307, 112)
        Me.Philhealth.Multiline = True
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        Me.Philhealth.Size = New System.Drawing.Size(221, 29)
        Me.Philhealth.TabIndex = 8
        '
        'SSS
        '
        Me.SSS.Cursor = System.Windows.Forms.Cursors.No
        Me.SSS.Location = New System.Drawing.Point(307, 177)
        Me.SSS.Multiline = True
        Me.SSS.Name = "SSS"
        Me.SSS.ReadOnly = True
        Me.SSS.Size = New System.Drawing.Size(221, 29)
        Me.SSS.TabIndex = 9
        '
        'TotalDeduction
        '
        Me.TotalDeduction.Cursor = System.Windows.Forms.Cursors.No
        Me.TotalDeduction.Location = New System.Drawing.Point(307, 329)
        Me.TotalDeduction.Multiline = True
        Me.TotalDeduction.Name = "TotalDeduction"
        Me.TotalDeduction.ReadOnly = True
        Me.TotalDeduction.Size = New System.Drawing.Size(221, 29)
        Me.TotalDeduction.TabIndex = 10
        '
        'GrossSalary2
        '
        Me.GrossSalary2.Cursor = System.Windows.Forms.Cursors.No
        Me.GrossSalary2.Location = New System.Drawing.Point(611, 43)
        Me.GrossSalary2.Multiline = True
        Me.GrossSalary2.Name = "GrossSalary2"
        Me.GrossSalary2.ReadOnly = True
        Me.GrossSalary2.Size = New System.Drawing.Size(221, 29)
        Me.GrossSalary2.TabIndex = 11
        '
        'Deduction
        '
        Me.Deduction.Cursor = System.Windows.Forms.Cursors.No
        Me.Deduction.Location = New System.Drawing.Point(611, 112)
        Me.Deduction.Multiline = True
        Me.Deduction.Name = "Deduction"
        Me.Deduction.ReadOnly = True
        Me.Deduction.Size = New System.Drawing.Size(221, 29)
        Me.Deduction.TabIndex = 12
        '
        'NetSalary
        '
        Me.NetSalary.Cursor = System.Windows.Forms.Cursors.No
        Me.NetSalary.Location = New System.Drawing.Point(611, 329)
        Me.NetSalary.Multiline = True
        Me.NetSalary.Name = "NetSalary"
        Me.NetSalary.ReadOnly = True
        Me.NetSalary.Size = New System.Drawing.Size(221, 29)
        Me.NetSalary.TabIndex = 13
        '
        'ComputeBtn
        '
        Me.ComputeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComputeBtn.Location = New System.Drawing.Point(61, 640)
        Me.ComputeBtn.Name = "ComputeBtn"
        Me.ComputeBtn.Size = New System.Drawing.Size(115, 52)
        Me.ComputeBtn.TabIndex = 14
        Me.ComputeBtn.Text = "Compute"
        Me.ComputeBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBtn.Location = New System.Drawing.Point(206, 640)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(115, 52)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.Location = New System.Drawing.Point(367, 640)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(115, 52)
        Me.DeleteBtn.TabIndex = 16
        Me.DeleteBtn.Text = "Delete Selected"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Rate Per Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Hour Per Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No. Of Days Worked "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Gross Salary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tax 15% Of Monthly Wage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "PhilHealth 5%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "SSS 2%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Total Deduction "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(608, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Gross Salary"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(608, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Deduction "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(608, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Net Salary"
        '
        'PrintBtn
        '
        Me.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintBtn.Location = New System.Drawing.Point(665, 642)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(167, 50)
        Me.PrintBtn.TabIndex = 29
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 374)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(852, 260)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(844, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox51)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(844, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(0, 0)
        Me.TextBox51.Multiline = True
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(848, 234)
        Me.TextBox51.TabIndex = 14
        '
        'PrintDocument1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 698)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'payrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 763)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.ComputeBtn)
        Me.Controls.Add(Me.NetSalary)
        Me.Controls.Add(Me.Deduction)
        Me.Controls.Add(Me.GrossSalary2)
        Me.Controls.Add(Me.TotalDeduction)
        Me.Controls.Add(Me.SSS)
        Me.Controls.Add(Me.Philhealth)
        Me.Controls.Add(Me.MonthlyWage)
        Me.Controls.Add(Me.GrossSalary1)
        Me.Controls.Add(Me.NumberofDaysWorked)
        Me.Controls.Add(Me.HourPerDay)
        Me.Controls.Add(Me.RatePerHour)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BackBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "payrollForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payrollForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RatePerHour As TextBox
    Friend WithEvents HourPerDay As TextBox
    Friend WithEvents NumberofDaysWorked As TextBox
    Friend WithEvents GrossSalary1 As TextBox
    Friend WithEvents MonthlyWage As TextBox
    Friend WithEvents Philhealth As TextBox
    Friend WithEvents SSS As TextBox
    Friend WithEvents TotalDeduction As TextBox
    Friend WithEvents GrossSalary2 As TextBox
    Friend WithEvents Deduction As TextBox
    Friend WithEvents NetSalary As TextBox
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PrintBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
