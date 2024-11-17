Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class payrollReport

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim Id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainform.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        disp_data()
    End Sub

    Private Sub payrollReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Server=localhost;Database=peroll;Uid=root;Pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        disp_data()


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class