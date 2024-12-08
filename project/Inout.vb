Imports ZXing
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing
Imports System.IO

Public Class Inout
    ' Declare the webcam object
    Private videoCaptureDevice As VideoCaptureDevice
    Private barcodeReader As New BarcodeReader()

    ' Declare a PictureBox for displaying video frames
    Private WithEvents pictureBox As New PictureBox()

    ' Initialize the form and the video capture device
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the PictureBox to display the video feed
        pictureBox.Dock = DockStyle.Fill
        Me.Controls.Add(pictureBox)

        ' Get the list of available video capture devices (cameras)
        Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count > 0 Then
            ' Use the first available camera device
            videoCaptureDevice = New VideoCaptureDevice(videoDevices(0).MonikerString)

            ' Hook up the NewFrame event to capture video frames
            AddHandler videoCaptureDevice.NewFrame, AddressOf VideoCaptureDevice_NewFrame
            videoCaptureDevice.Start()
        Else
            MessageBox.Show("No video capture device found!")
        End If
    End Sub

    ' This is called whenever a new video frame is captured from the camera
    Private Sub VideoCaptureDevice_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Create a MemoryStream to store the current frame
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
                    MessageBox.Show("QR Code Detected: " & result.Text)
                End If
            Catch ex As Exception
                ' Handle any exceptions during decoding (e.g., no QR code detected)
            End Try
        End Using
    End Sub

    ' Stop the video capture when the form is closed
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoCaptureDevice IsNot Nothing AndAlso videoCaptureDevice.IsRunning Then
            ' Stop capturing video and release the camera
            videoCaptureDevice.SignalToStop()
            videoCaptureDevice.WaitForStop()
        End If
    End Sub
End Class
