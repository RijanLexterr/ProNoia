Imports MySql.Data.MySqlClient
Imports System.CodeDom
Imports System.Data.Common
Imports WindowsApp1.BusinessLayer

Public Class loginform

#Region "Declares"

    Dim myconnection As New DBConnection
    Dim conadApter As MySqlDataAdapter
    Dim dataTable As DataTable
    Dim bl As New BusinessLayer

    Private Sub LongOnClick(sender As Object, e As EventArgs) Handles LoginButton.Click

        Try
            If txtUser.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Please fill up all fields")
                Return
            End If

            Dim isSuccess = bl.LoginUser(txtUser.Text, txtPassword.Text)

            If isSuccess Then
                MsgBox("Authorized")
                Dashboard.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then

            txtPassword.UseSystemPasswordChar = True

        Else

            txtPassword.UseSystemPasswordChar = False



        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(35)
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            mainform.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

#End Region
End Class