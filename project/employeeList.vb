Public Class employeeList
    Private Sub employeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeesInGrid(DataGridView1)
    End Sub

    Private Sub DisplayEmployeesInGrid(dataGrid As DataGridView)
        ' Step 1: Call FetchAllEmployees to retrieve all employee data
        Dim employeeBL As New EmployeeBL()
        Dim employees As List(Of Employee) = employeeBL.FetchAllEmployees()

        ' Step 2: Convert the List(Of Employee) to a DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Employee ID")
        dataTable.Columns.Add("First Name")
        dataTable.Columns.Add("Last Name")
        dataTable.Columns.Add("Middle Name")
        dataTable.Columns.Add("Address")
        dataTable.Columns.Add("Contact")
        dataTable.Columns.Add("Gender")
        dataTable.Columns.Add("Birthday")
        dataTable.Columns.Add("Position")
        dataTable.Columns.Add("Hiring Rate")
        dataTable.Columns.Add("Hiring Date")

        ' Step 3: Populate the DataTable with data from the employees list
        For Each employee As Employee In employees
            dataTable.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName, employee.MiddleName, employee.Address, employee.Contact, employee.Gender, employee.Birthday.ToShortDateString(), employee.Position, employee.HiringRate.ToString("C"), employee.HiringDate.ToShortDateString())
        Next

        ' Step 4: Bind the DataTable to the DataGridView
        dataGrid.DataSource = dataTable
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Using empDetails As New employeeInformation
            empDetails.empID = 0
            empDetails.ShowDialog()
        End Using
        DisplayEmployeesInGrid(DataGridView1)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Using empDetails As New employeeInformation
            empDetails.empID = DataGridView1.CurrentRow.Cells(0).Value
            empDetails.ShowDialog()
        End Using

        DisplayEmployeesInGrid(DataGridView1)
    End Sub


End Class