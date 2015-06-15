Public Class frmMainWindow

    ''Declaring delegate method to read data from arduino
    Delegate Sub MethodDelegate(ByVal [text] As String)
    Dim displayDataDelegate As New MethodDelegate(AddressOf displayArduinoData)

    Dim ArduinoSerialComm As inocomm.inocomm

    ''Declaring a serial port for vb-arduino tx/rx 
    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    Private Sub frmMainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ArduinoSerialComm.CloseSerial()
    End Sub

    Private Sub frmMainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArduinoSerialComm = New inocomm.inocomm
        AddHandler ArduinoSerialComm.DataReceived, AddressOf receiveArduinoData

        ArduinoSerialComm.ConfigureComm(txtPort.Text)
        ArduinoSerialComm.ConnectSerial()
    End Sub

    Private Sub displayArduinoData(ByVal data As String)
        txtTest.AppendText(data)
    End Sub
    Private Sub receiveArduinoData()
        Invoke(displayDataDelegate, ArduinoSerialComm.getDataReceived())
    End Sub

    Private Sub ConnectSerial()
        Try
            SerialPort.BaudRate = 9600
            SerialPort.PortName = txtPort.Text
            SerialPort.Open()
        Catch datos_error As Exception
            SerialPort.Close()
        End Try
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim trama(10) As Byte
        'trama = {255, 100, m1_vel, 110, m1_pos, 200, m2_vel, 210, m2_pos, 255}
        trama = {255, 110, 40, 255, 50, 200, 70, 210, 80, 255}
        ArduinoSerialComm.SendFrame(trama, 4)
    End Sub
End Class
