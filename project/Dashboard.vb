Public Class Dashboard
    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Dim userlist As New UserList
        userlist.TopLevel = False
        ResetPanel()
        MainPanel.Controls.Add(userlist)
        userlist.Show()
        SetAllChildtoCenter()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim employeelist As New employeeList
        employeelist.TopLevel = False
        ResetPanel()
        MainPanel.Controls.Add(employeelist)
        employeelist.Show()
        SetAllChildtoCenter()
    End Sub

    Private Sub TimeinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeinToolStripMenuItem.Click


        TimeInTimeOutForm.ShowDialog()


    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        MainPanel.Width = Me.ClientSize.Width
        GroupBox1.Width = Me.ClientSize.Width


        Label1.Left = (GroupBox1.Width - Label1.Width) / 2
        Label2.Left = (GroupBox1.Width - Label2.Width) / 2

        SetAllChildtoCenter()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.Size = Me.Size
    End Sub

    Private Sub Dashboard_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        MainPanel.Width = Me.ClientSize.Width
    End Sub

    Private Sub ResetPanel()
        MainPanel.Controls.Clear()
    End Sub
    Private Sub SetAllChildtoCenter()

        If MainPanel.Controls.Count > 0 Then
            If MainPanel.Width / 2 > 900 Then

                MainPanel.Controls.Item(0).Left = (MainPanel.Width - MainPanel.Controls.Item(0).Width) / 2

            Else

                MainPanel.Controls.Item(0).Left = (MainPanel.Width - MainPanel.Controls.Item(0).Width) / 2
            End If

        End If
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        Dim payrollList As New payrollList
        payrollList.TopLevel = False
        ResetPanel()
        MainPanel.Controls.Add(payrollList)
        payrollList.Show()
        SetAllChildtoCenter()
    End Sub
End Class