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
        txtConsole.AppendText(data)
    End Sub

    Private Sub btnMoveDCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveDCBack.Click
        Dim trama(3) As Byte
        ''action = forward=100, reverse=200, stop=300
        'trama = {255, action, 255}
        trama = {255, 20, 255}
        ''Send data to the Arduino
        ArduinoSerialComm.SendFrame(trama, 3)
    End Sub

    Private Sub btnDCStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCStop.Click
        Dim trama(3) As Byte
        ''action = forward=100, reverse=200, stop=300
        'trama = {255, action, 255}
        trama = {255, 30, 255}
        ''Send data to the Arduino
        ArduinoSerialComm.SendFrame(trama, 3)
    End Sub

    Private Sub btnMoveDCForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveDCForward.Click
        Dim trama(3) As Byte
        ''action = forward=100, reverse=200, stop=300
        'trama = {255, action, 255}
        trama = {255, 10, 255}
        ''Send data to the Arduino
        ArduinoSerialComm.SendFrame(trama, 3)
    End Sub
End Class
