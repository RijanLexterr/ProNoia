Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls
Imports WindowsApp1.BusinessLayer
Public Class UserList

    Dim bl As BusinessLayer

    Private Sub UserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayUsersInGrid(DataGridView1)


    End Sub

    Private Sub DisplayUsersInGrid(dataGrid As DataGridView)
        ' Step 1: Call GetAllUsersWithDetails to retrieve users and their details
        Dim businessLayer As New BusinessLayer()
        Dim users As List(Of UserLogin) = businessLayer.GetAllUsersWithDetails()

        ' Step 2: Convert the List(Of UserLogin) to a DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("ID")
        dataTable.Columns.Add("Username")
        dataTable.Columns.Add("First Name")
        dataTable.Columns.Add("Last Name")
        dataTable.Columns.Add("Email")
        dataTable.Columns.Add("Phone Number")
        dataTable.Columns.Add("Address")

        ' Step 3: Populate the DataTable with data from the users list
        For Each user As UserLogin In users
            dataTable.Rows.Add(user.UserId, user.Username, user.Details.FirstName, user.Details.LastName, user.Details.Email, user.Details.PhoneNumber, user.Details.Address)
        Next

        ' Step 4: Bind the DataTable to the DataGridView
        dataGrid.DataSource = dataTable
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using userlist As New systemUser
            userlist.UserID = 0
            userlist.ShowDialog()
        End Using
        DisplayUsersInGrid(DataGridView1)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Using userlist As New systemUser
            userlist.UserID = DataGridView1.CurrentRow.Cells(0).Value
            userlist.ShowDialog()
        End Using

        DisplayUsersInGrid(DataGridView1)

    End Sub



End Class
