Public Class mainform
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to Logout?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            loginform.Show()
            Me.Hide()

        End If

        loginform.txtUser.Clear()
        loginform.txtPassword.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        systemUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        employeeInformation.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        payrollForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        payrollReport.Show()
        Me.Hide()
    End Sub

    Private Sub btntimeintimeout_Click(sender As Object, e As EventArgs) Handles btntimeintimeout.Click
        TimeInTimeOutForm.Show()
        Me.Hide()
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = loginform.txtUser.Text.Trim()
    End Sub
End Class