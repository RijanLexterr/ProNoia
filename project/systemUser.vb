Imports System.Net
Imports MySql.Data.MySqlClient

Public Class systemUser
    Public Property UserID As Integer
    Dim user As UserLogin
    Dim Bl As BusinessLayer = New BusinessLayer()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ID As Integer
    Public Sub disp_data()

        If UserID > 0 Then
            user = Bl.GetUserByID(UserID)
            txtFisrtname.Text = user.Details.FirstName
            txtLastname.Text = user.Details.LastName
            txtUsername.Text = user.Username
        End If
    End Sub

    Private Sub employeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click


        Dim firstname As String = txtFisrtname.Text.Trim()
        Dim lastname As String = txtLastname.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If txtPassword.Text <> "" Then
            If txtPassword.TextLength >= 8 Then

            Else
                MsgBox("Your Password is Weak.")
                Return
            End If

        End If
        Try
            If Me.UserID > 0 Then
                Bl.UpdateUser(Me.UserID, username, password, firstname, lastname, "", "", "")
                Me.Close()
            Else
                Bl.CreateUser(username, password, firstname, lastname, "", "", "")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        'Strong or Weak Input Password
        If txtPassword.Text <> "" Then
            If txtPassword.TextLength >= 8 Then
                lblStrongWeak.Text = "Password is Strong."
            Else
                lblStrongWeak.Text = "Password is Weeak."
            End If
            lblStrongWeak.Visible = True
        Else
            lblStrongWeak.Visible = False
        End If

    End Sub


End Class