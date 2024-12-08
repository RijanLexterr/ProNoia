Imports Google.Protobuf.WellKnownTypes
Imports Org.BouncyCastle.Asn1.Cms

Public Class employeePayroll

    Dim empId As Integer
    Dim fromDate As Date
    Dim toDate As Date
    Dim currentUserId = 1
    Public Property Payroll As New Payroll
    Dim employee As Employee = New Employee
    Dim isNewPayroll = True
    Dim isFormloadDone = False
    Private Sub employeePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindObject()
        FillDropdown(empBox)
        If Payroll.Id > 0 Then
            Button1.Enabled = False
            empBox.Enabled = False
            empId = Payroll.Id
            isNewPayroll = False
            IsExisting()
        End If

        isFormloadDone = True
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
        populateGrid()
        fetchEmployeeDetails()
        SetPayroll()
        bindObject()
    End Sub

    Sub SetPayroll()
        Payroll.FromDate = fromPicker.Value
        Payroll.ToDate = toPicker.Value
        Payroll.CreatedBy = currentUserId
        Payroll.CreatedDate = DateTime.Now
        Dim sum As Decimal = 0D
        Dim com As Common = New Common
        Dim lowestDate As DateTime = DateTime.MaxValue
        Dim highestDate As DateTime = DateTime.MinValue
        ' Iterate through each row in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Check if the cell value is not null or DBNull and ensure it's a numeric value

            If Not row.IsNewRow Then
                If row.Cells("DurationInSeconds").Value IsNot Nothing AndAlso IsNumeric(row.Cells("DurationInSeconds").Value) Then
                    ' Add the value of the DurationInSeconds column to the sum
                    sum += Convert.ToDecimal(row.Cells("DurationInSeconds").Value)
                End If
                Dim cellValue1 = row.Cells("AttendanceDate").Value
                Dim cellValue = row.Cells("AttendanceDate").Value

                If cellValue1 IsNot Nothing AndAlso IsDate(cellValue1) Then
                    Dim currentDate As DateTime = Convert.ToDateTime(cellValue1)
                    ' Compare to find the lowest date
                    If currentDate < lowestDate Then
                        lowestDate = currentDate
                    End If
                End If

                If cellValue IsNot Nothing AndAlso IsDate(cellValue) Then
                    Dim currentDate As DateTime = Convert.ToDateTime(cellValue)

                    ' Compare to find the highest date
                    If currentDate > highestDate Then
                        highestDate = currentDate
                    End If
                End If


            End If
        Next
        Payroll.FromDate = lowestDate
        Payroll.ToDate = highestDate
        Payroll.NoOfHrs = sum
        Payroll.GrossPay = sum * employee.HiringRate
        Payroll.SSS = com.ComputeSSS(Payroll.GrossPay, True)
        Payroll.Pagibig = com.ComputePagIbig(Payroll.GrossPay, True)
        Payroll.PhilHealth = com.ComputePhilHealth(Payroll.GrossPay, True)
        Payroll.NetPay = Payroll.GrossPay - (Payroll.SSS + Payroll.Pagibig + Payroll.PhilHealth)
        Payroll.EmpId = employee.EmployeeID

    End Sub

    Sub fetchEmployeeDetails()
        Dim empBl As EmployeeBL = New EmployeeBL
        employee = empBl.FetchEmployee(empId)
    End Sub

    Sub bindObject()
        lblsss.Text = Payroll.SSS
        lblpbg.Text = Payroll.Pagibig
        lblph.Text = Payroll.PhilHealth
        lblGross.Text = Payroll.GrossPay
        lblNet.Text = Payroll.NetPay
        lblRate.Text = employee.HiringRate
        lblTotalHrs.Text = Payroll.NoOfHrs


    End Sub

    Sub populateGrid()
        If isNewPayroll Then
            IsNew()
        Else
            IsExisting()
        End If


    End Sub

    Sub IsNew()
        Dim attendanceBL As New AttendanceBL()
        empId = empBox.SelectedValue
        Dim fromDate = fromPicker.Value
        Dim toDate = toPicker.Value

        ' Step 2: Retrieve the list of attendance records based on the filters
        Dim attendance As List(Of PayrollItems) = attendanceBL.FetchAttendanceByFilters(empId, fromDate, toDate)

        ' Step 3: Create a DataTable to store the attendance data
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("EmployeeID", GetType(Integer))
        dataTable.Columns.Add("AttendanceDate")
        dataTable.Columns.Add("MinAttendanceDate")
        dataTable.Columns.Add("MaxAttendanceDate")
        dataTable.Columns.Add("DurationInSeconds")
        dataTable.Columns.Add("PayrollItemID")

        ' Step 4: Populate the DataTable with attendance data from the attendance list
        For Each attendanceTime As PayrollItems In attendance
            ' Add a row for each AttendanceTime object
            dataTable.Rows.Add(attendanceTime.EmployeeID,
                               attendanceTime.AttendanceDate.ToString("yyyy-MM-dd"),
                               CType(attendanceTime.MinAttendanceDate, DateTime).ToString("HH:mm:ss"),
                               CType(attendanceTime.MaxAttendanceDate, DateTime).ToString("HH:mm:ss"),
                               attendanceTime.DurationInSeconds / 3600)
        Next

        ' Step 5: Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dataTable

        ' Optional: Customize the DataGridView columns
        DataGridView1.Columns("EmployeeID").Visible = False
        DataGridView1.Columns("PayrollItemID").Visible = False
        DataGridView1.Columns("AttendanceDate").HeaderText = "Date"
        DataGridView1.Columns("MinAttendanceDate").HeaderText = "Time In"
        DataGridView1.Columns("MaxAttendanceDate").HeaderText = "Time Out"
        DataGridView1.Columns("DurationInSeconds").HeaderText = "Total Hours"
    End Sub

    Sub IsExisting()
        Dim attendanceBL As New PayrollItemsBL()
        Dim payrollBL As PayrollBL = New PayrollBL
        Dim fromDate = fromPicker.Value
        Dim toDate = toPicker.Value
        Payroll = payrollBL.GetPayrollByID(Payroll.Id)
        empId = Payroll.EmpId
        fetchEmployeeDetails()

        ' Step 2: Retrieve the list of attendance records based on the filters
        Dim attendance As List(Of PayrollItems) = attendanceBL.FetchPayrollItemsByPayrollID(Payroll.Id)

        ' Step 3: Create a DataTable to store the attendance data
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("EmployeeID", GetType(Integer))
        dataTable.Columns.Add("AttendanceDate")
        dataTable.Columns.Add("MinAttendanceDate")
        dataTable.Columns.Add("MaxAttendanceDate")
        dataTable.Columns.Add("DurationInSeconds")
        dataTable.Columns.Add("PayrollItemID")

        ' Step 4: Populate the DataTable with attendance data from the attendance list
        For Each attendanceTime As PayrollItems In attendance
            ' Add a row for each AttendanceTime object
            dataTable.Rows.Add(attendanceTime.EmployeeID,
                               attendanceTime.AttendanceDate.ToString("yyyy-MM-dd"),
                               CType(attendanceTime.MinAttendanceDate, DateTime).ToString("HH:mm:ss"),
                               CType(attendanceTime.MaxAttendanceDate, DateTime).ToString("HH:mm:ss"),
                               attendanceTime.DurationInSeconds)
        Next

        ' Step 5: Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dataTable

        ' Optional: Customize the DataGridView columns
        DataGridView1.Columns("EmployeeID").Visible = False
        DataGridView1.Columns("PayrollItemID").Visible = False
        DataGridView1.Columns("AttendanceDate").HeaderText = "Date"
        DataGridView1.Columns("MinAttendanceDate").HeaderText = "Time In"
        DataGridView1.Columns("MaxAttendanceDate").HeaderText = "Time Out"
        DataGridView1.Columns("DurationInSeconds").HeaderText = "Total Hours"


        bindObject()

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If isFormloadDone Then
            SetPayroll()
            bindObject()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetPayroll()

        Try
            Dim payrollBL As PayrollBL = New PayrollBL
            Payroll.Id = payrollBL.UpsertPayroll(Payroll)


            Dim payrollItemBL As PayrollItemsBL = New PayrollItemsBL
            Dim items As List(Of PayrollItems) = New List(Of PayrollItems)

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then
                    Continue For ' Skip new empty rows
                End If

                ' Retrieve the data from the DataGridView row
                Dim item As PayrollItems = New PayrollItems
                item.EmployeeID = employee.EmployeeID ' Assuming employee object is already populated
                item.AttendanceDate = row.Cells("AttendanceDate").Value
                item.DurationInSeconds = If(row.Cells("DurationInSeconds").Value IsNot Nothing, Convert.ToDouble(row.Cells("DurationInSeconds").Value), 0)
                item.PayrollID = Payroll.Id
                item.MaxAttendanceDate = row.Cells("MaxAttendanceDate").Value
                item.MinAttendanceDate = row.Cells("MinAttendanceDate").Value

                ' Handle PayrollItemID if exists
                If row.Cells("PayrollItemID").Value IsNot DBNull.Value Then
                    Try
                        item.PayrollItemID = Convert.ToInt32(row.Cells("PayrollItemID").Value)
                    Catch ex As Exception
                        item.PayrollItemID = 0 ' Set to default if not valid
                    End Try
                Else
                    item.PayrollItemID = 0 ' Default if the value is Nothing
                End If

                ' Check for valid data before adding to the list
                If Not IsDBNull(item.AttendanceDate) AndAlso item.AttendanceDate <> DateTime.MinValue AndAlso item.DurationInSeconds > 0 Then
                    payrollItemBL.UpsertPayrollItem(item) ' Upsert only valid records
                End If
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Me.Close()
    End Sub
End Class