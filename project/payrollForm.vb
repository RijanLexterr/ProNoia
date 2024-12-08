Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class payrollForm



    Dim ans As Integer
    Dim deduc As Integer
    Dim tax As Integer
    Dim phil As Integer
    Dim s As Integer
    Dim net As Integer

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ID As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        mainform.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click


        Try
            ans = ((RatePerHour.Text * HourPerDay.Text) * (NumberofDaysWorked.Text))
            GrossSalary1.Text = ans
            GrossSalary2.Text = ans
            tax = ans * 0.15
            MonthlyWage.Text = tax
            phil = ans * 0.05
            Philhealth.Text = phil
            s = ans * 0.02
            SSS.Text = s

            deduc = tax + phil + s
            TotalDeduction.Text = deduc
            Deduction.Text = deduc

            net = GrossSalary2.Text - Deduction.Text
            NetSalary.Text = net
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table105"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub


    Private Sub payrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Server=localhost;Database=peroll;Uid=root;Pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        disp_data()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into table105 values (NULL,'" + TextBox1.Text + "','" + MonthlyWage.Text + "','" + Philhealth.Text + "','" + SSS.Text + "',
         '" + GrossSalary1.Text + "','" + NetSalary.Text + "','" + TotalDeduction.Text + "')"

            cmd.ExecuteNonQuery()

            TextBox1.Text = ""
            MonthlyWage.Text = ""
            Philhealth.Text = ""
            SSS.Text = ""
            GrossSalary1.Text = ""
            NetSalary.Text = ""
            TotalDeduction.Text = ""

            disp_data()

            MessageBox.Show("Record saved Successfully!!")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try

            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            Try

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from table105 where ID =" & ID & ""
                cmd.ExecuteNonQuery()


                TextBox1.Text = ""
                MonthlyWage.Text = ""
                Philhealth.Text = ""
                SSS.Text = ""
                GrossSalary1.Text = ""
                NetSalary.Text = ""
                TotalDeduction.Text = ""

                disp_data()


            Catch ex As Exception




            End Try

            Dim response As Integer

            response = MessageBox.Show("Are you sure you want to Delete?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = vbYes Then


            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Try
            'print
            TextBox51.Text = ""
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)

            TextBox51.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + vbTab & "PAYSLIP" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("Employee name" + vbTab & TextBox1.Text + vbTab + vbTab + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)

            TextBox51.AppendText("Gross Salary:" + vbTab & GrossSalary2.Text + vbNewLine)
            TextBox51.AppendText("Net Amount:" + vbTab & NetSalary.Text + vbNewLine)

            TextBox51.AppendText("===================================================================================" + vbNewLine)

            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText(vbTab + vbTab & "Dedutions" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("W/Tax" + vbTab + vbTab + vbTab & TotalDeduction.Text + vbNewLine)


            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("Total deduction" + vbTab & TotalDeduction.Text + vbTab + vbTab & "Net Amount:" + vbTab & NetSalary.Text + vbNewLine)
            TextBox51.AppendText("=================================================================================================" + vbNewLine)
            TextBox51.AppendText(vbTab + "Due Date" + Today & vbTab + vbTab + vbTab + vbTab + vbTab + vbTab & "Time:" & TimeOfDay + vbNewLine)
            TextBox51.AppendText("=================================================================================================" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText(vbTab + "Recieve By:" + vbNewLine)
            TextBox51.AppendText(vbTab + vbTab + vbTab + "___________________" + vbNewLine)
            TextBox51.AppendText(vbTab + vbTab + vbTab + vbTab + TextBox1.Text + vbNewLine)
            TextBox51.AppendText(vbTab + vbTab + vbTab + "            Employee" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("=================================================================================================" + vbNewLine)
            TextBox51.AppendText("" + vbNewLine)
            TextBox51.AppendText("=================================================================================================" + vbNewLine)
            TextBox51.AppendText(vbTab + vbTab + vbTab + PictureBox1.Text + vbNewLine)
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString(TextBox51.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ID = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()



            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from table105 where ID =" & ID & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                TextBox1.Text = dr.GetString(1).ToString
                'RatePerHour.Text = dr.GetString(1).ToString
                'HourPerDay.Text = dr.GetString(2).ToString
                'NumberofDaysWorked.Text = dr.GetString(3).ToString
                GrossSalary1.Text = dr.GetString(5).ToString
                MonthlyWage.Text = dr.GetString(2).ToString
                Philhealth.Text = dr.GetString(3).ToString
                SSS.Text = dr.GetString(4).ToString
                TotalDeduction.Text = dr.GetString(7).ToString
                ' GrossSalary2.Text = dr.GetString().ToString
                'Deduction.Text = dr.GetString().ToString
                NetSalary.Text = dr.GetString(6).ToString


            End While
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class