Imports ZXing
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing
Imports System.IO
Imports System.Media


Public Class TimeInTimeOutForm
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Private WithEvents pictureBox As New PictureBox()
    Private barcodeReader As New BarcodeReader()
    Dim cout As Integer = 0
    Dim Bl As AttendanceBL = New AttendanceBL


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub
    Public Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        employeeInformation.Show()
        Me.Hide()

    End Sub

    Private Sub VideoCaptureDevice_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Create a MemoryStream to store the current frame


        If cout > 0 Then
            Timer1.Enabled = True
            Timer1.Interval = 1000
            Timer1.Start()


        Else
            Using ms As New MemoryStream()

                ' Clone the frame and save it to the MemoryStream
                eventArgs.Frame.Save(ms, Imaging.ImageFormat.Bmp)

                ' Create a new Bitmap from the MemoryStream to ensure it's independent
                ms.Seek(0, SeekOrigin.Begin)
                Dim currentFrame As New Bitmap(ms)

                ' Display the current frame in the PictureBox
                pictureBox.Image = currentFrame

                ' Attempt to decode a QR code from the current frame
                Try
                    Dim result = barcodeReader.Decode(currentFrame)
                    If result IsNot Nothing Then
                        ' Show the decoded result
                        If result.Text.IndexOf("SFICS") <> -1 Then
                            Dim att As New Attendance
                            att.EmployeeID = Convert.ToInt32(result.Text.Replace("SFICS:", ""))
                            att.AttendanceDate = DateTime.Now
                            Bl.AddAttendance(att)
                            SystemSounds.Beep.Play()
                            cout = 1
                            Timer1.Start()
                        End If


                    End If
                Catch ex As Exception
                    ' Handle any exceptions during decoding (e.g., no QR code detected)
                    MsgBox(ex.Message)

                End Try

            End Using
        End If



    End Sub

    Private Sub TimeInTimeOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        Try
            If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CAMERA = cameras.VideoDevice
                AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                AddHandler CAMERA.NewFrame, AddressOf VideoCaptureDevice_NewFrame
                CAMERA.Start()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Now
        cout = 0


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class