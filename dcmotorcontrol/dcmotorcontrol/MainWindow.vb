Public Class frmMainWindow

    ''Declaring delegate method to display the readed data from arduino
    Delegate Sub MethodDelegate(ByVal [text] As String)
    Dim displayDataDelegate As New MethodDelegate(AddressOf displayArduinoData)

    ''Module to comunicate with Arduino
    Dim ArduinoSerialComm As inocomm.inocomm

    ''Declaring a serial port for vb-arduino tx/rx 
    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    ''Close the arduino communication when the form closes
    Private Sub frmMainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ArduinoSerialComm.CloseSerial()
    End Sub

    ''Init the Arduino communication whent the program starts
    Private Sub frmMainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArduinoSerialComm = New inocomm.inocomm
        AddHandler ArduinoSerialComm.DataReceived, AddressOf receiveArduinoData

        ArduinoSerialComm.ConfigureComm(txtPort.Text)
        ArduinoSerialComm.ConnectSerial()
    End Sub

    ''This method is executed every time the arduino sends a data 
    Private Sub receiveArduinoData()
        ''do something (store, etc)
        ''call to the display method
        Invoke(displayDataDelegate, ArduinoSerialComm.getDataReceived())
    End Sub

    ''Method to display the received data from arduino
    Private Sub displayArduinoData(ByVal data As String)
        txtTest.AppendText(data)
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim trama(10) As Byte
        'trama = {255, 100, m1_vel, 110, m1_pos, 200, m2_vel, 210, m2_pos, 255}
        trama = {255, 200, 255, 50, 200, 70, 210, 80, 255}
        ''Send data to the Arduino
        ArduinoSerialComm.SendFrame(trama, 3)
    End Sub
End Class
