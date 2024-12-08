Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Imports System.IO
Imports System.Linq.Expressions

Public Class employeeInformation

    'dim for qrcode
    Dim code As String
    Dim qrcode As Bitmap
    Dim arrayImage() As Byte
    Dim mstream As New System.IO.MemoryStream
    'dim for employee profile picture
    Dim imgpath As String
    Dim arrImageProfilePic() As Byte



    Public Property empID As Integer
    Dim Bl As EmployeeBL = New EmployeeBL()
    Dim isNew As Boolean = False
    Dim emp As Employee = New Employee()
    Dim common As Common = New Common()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        mainform.Show()
        Me.Hide()
    End Sub

    Public Sub disp_data()
        If empID < 1 Then
            empID = Bl.GetNextEmployeeID
            employeeId.Text = empID.ToString().PadLeft(5, "0"c)
            isNew = True


            Try
                code = "SFICS:" & empID
                Dim enc As New QRCodeEncoder()
                enc.QRCodeScale = 2 '2 you can scan in mobile
                qrcode = enc.Encode(code)
                PictureBoxQr.Image = qrcode
                PictureBoxQr.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ' mstream=qrcode
                arrayImage = mstream.GetBuffer
                ' imagedata = qrcode
            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        Else
            Try
                emp = Bl.FetchEmployee(empID)
                employeeId.Text = emp.EmployeeID.ToString().PadLeft(5, "0"c)
                empID = emp.EmployeeID.ToString.TrimStart("0"c)
                address.Text = emp.Address
                sex.SelectedItem = emp.Gender
                position.Text = emp.Position
                dateBirth.Value = emp.Birthday
                hiringDate.Value = emp.Birthday
                firstName.Text = emp.FirstName
                lastName.Text = emp.LastName
                mI.Text = emp.MiddleName
                contactNo.Text = emp.Contact
                qrcode = common.ByteArrayToBitmap(emp.QRCode)
                PictureBoxQr.Image = qrcode
                hiringRate.Text = emp.HiringRate

            Catch ex As Exception

            End Try


        End If

    End Sub
    Private Sub employeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()

    End Sub

    Private Sub Save(sender As Object, e As EventArgs) Handles SaveBtn.Click


        Try
            If isNew Then

                emp.Address = address.Text
                emp.Gender = sex.SelectedItem.ToString
                emp.Position = position.Text
                emp.Birthday = dateBirth.Value.Date
                emp.HiringDate = hiringDate.Value.Date
                emp.FirstName = firstName.Text
                emp.LastName = lastName.Text
                emp.MiddleName = mI.Text
                emp.Contact = contactNo.Text
                emp.QRCode = common.BitmapToByteArray(qrcode)
                emp.HiringRate = Convert.ToDecimal(hiringRate.Text)
                Bl.CreateEmployee(emp)
            Else
                emp.EmployeeID = empID
                emp.Address = address.Text
                emp.Gender = sex.SelectedItem.ToString
                emp.Position = position.Text
                emp.Birthday = dateBirth.Value.Date
                emp.HiringDate = hiringDate.Value.Date
                emp.FirstName = firstName.Text
                emp.LastName = lastName.Text
                emp.MiddleName = mI.Text
                emp.Contact = contactNo.Text
                emp.QRCode = common.BitmapToByteArray(qrcode)
                emp.HiringRate = Convert.ToDecimal(hiringRate.Text)
                Bl.UpdateEmployee(emp)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Try
            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 9999))
            Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
            employeeId.Text = "1" & IDMaker
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        'for Employee Picture
        Try
            Dim imgpath As String
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File(*.jpg;*.png;*.gif;*jpeg)| *.jpg;*.png;*.gif;*jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                PictureBoxProfile.ImageLocation = imgpath
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message.ToString())

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxProfile_Click(sender As Object, e As EventArgs) Handles PictureBoxProfile.Click

    End Sub

    Private Sub PictureBoxProfile_Paint(sender As Object, e As PaintEventArgs) Handles PictureBoxProfile.Paint
        '  PictureBoxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ' mstream=qrcode
        '  arrImageProfilePic = mstream.GetBuffer
        ' imagedata = qrcode
    End Sub


End Class