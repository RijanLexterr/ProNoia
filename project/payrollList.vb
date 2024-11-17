Public Class payrollList
    Dim empId As Integer = 0
    Dim payrollBL As New PayrollBL
    Private Sub payrollList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateGrid()
        FillDropdown(empBox)
    End Sub

    Sub populateGrid()
        Dim payrollList As List(Of Payroll) = payrollBL.FetchPayrollByEmployeeId(empId)


        DataGridView1.DataSource = payrollList
        DataGridView1.Columns("EmpId").Visible = False
        DataGridView1.Columns("Id").Visible = False
        DataGridView1.Columns("CreatedBy").Visible = False
        DataGridView1.Columns("FromDate").DisplayIndex = 0
        DataGridView1.Columns("ToDate").DisplayIndex = 1

    End Sub

    Private Sub FillDropdown(comboBox As ComboBox)
        Dim employeeBL As New EmployeeBL()
        Dim employees As List(Of Employee) = employeeBL.FetchAllEmployees()
        Dim EmptyEmp As New Employee
        employees.Add(EmptyEmp)
        employees.Sort(Function(emp1, emp2) emp1.EmployeeID.CompareTo(emp2.EmployeeID))

        comboBox.DataSource = employees
        comboBox.DisplayMember = "FullName" ' Change this to the property you want to display
        comboBox.ValueMember = "EmployeeID"  ' Use EmployeeID as the value member
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using empForm As New employeePayroll
            empForm.ShowDialog()
        End Using

    End Sub

    Private Sub empBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empBox.SelectedIndexChanged
        Dim selectedValue As Object = empBox.SelectedValue

        If empBox.SelectedValue IsNot Nothing AndAlso IsNumeric(empBox.SelectedValue) Then
            empId = Convert.ToInt32(sender.SelectedValue)

        End If



        populateGrid()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Using empForm As New employeePayroll

            empForm.Payroll.Id = DataGridView1.CurrentRow.Cells("Id").Value
            empForm.ShowDialog()
        End Using
        populateGrid()
    End Sub
End Class