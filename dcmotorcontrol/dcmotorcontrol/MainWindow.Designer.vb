<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainWindow
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabMainWindowTab = New System.Windows.Forms.TabControl()
        Me.tpControls = New System.Windows.Forms.TabPage()
        Me.btnMoveDCForward = New System.Windows.Forms.Button()
        Me.btnDCStop = New System.Windows.Forms.Button()
        Me.btnMoveDCBack = New System.Windows.Forms.Button()
        Me.tbProperties = New System.Windows.Forms.TabPage()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.tabMainWindowTab.SuspendLayout()
        Me.tpControls.SuspendLayout()
        Me.tbProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMainWindowTab
        '
        Me.tabMainWindowTab.Controls.Add(Me.tpControls)
        Me.tabMainWindowTab.Controls.Add(Me.tbProperties)
        Me.tabMainWindowTab.Location = New System.Drawing.Point(12, 12)
        Me.tabMainWindowTab.Name = "tabMainWindowTab"
        Me.tabMainWindowTab.SelectedIndex = 0
        Me.tabMainWindowTab.Size = New System.Drawing.Size(549, 310)
        Me.tabMainWindowTab.TabIndex = 0
        '
        'tpControls
        '
        Me.tpControls.Controls.Add(Me.txtConsole)
        Me.tpControls.Controls.Add(Me.btnMoveDCForward)
        Me.tpControls.Controls.Add(Me.btnDCStop)
        Me.tpControls.Controls.Add(Me.btnMoveDCBack)
        Me.tpControls.Location = New System.Drawing.Point(4, 22)
        Me.tpControls.Name = "tpControls"
        Me.tpControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpControls.Size = New System.Drawing.Size(541, 284)
        Me.tpControls.TabIndex = 0
        Me.tpControls.Text = "Controls"
        Me.tpControls.UseVisualStyleBackColor = True
        '
        'btnMoveDCForward
        '
        Me.btnMoveDCForward.Location = New System.Drawing.Point(363, 52)
        Me.btnMoveDCForward.Name = "btnMoveDCForward"
        Me.btnMoveDCForward.Size = New System.Drawing.Size(97, 85)
        Me.btnMoveDCForward.TabIndex = 5
        Me.btnMoveDCForward.Text = "Forward"
        Me.btnMoveDCForward.UseVisualStyleBackColor = True
        '
        'btnDCStop
        '
        Me.btnDCStop.Location = New System.Drawing.Point(223, 52)
        Me.btnDCStop.Name = "btnDCStop"
        Me.btnDCStop.Size = New System.Drawing.Size(97, 85)
        Me.btnDCStop.TabIndex = 4
        Me.btnDCStop.Text = "Stop"
        Me.btnDCStop.UseVisualStyleBackColor = True
        '
        'btnMoveDCBack
        '
        Me.btnMoveDCBack.Location = New System.Drawing.Point(83, 52)
        Me.btnMoveDCBack.Name = "btnMoveDCBack"
        Me.btnMoveDCBack.Size = New System.Drawing.Size(97, 85)
        Me.btnMoveDCBack.TabIndex = 3
        Me.btnMoveDCBack.Text = "Back"
        Me.btnMoveDCBack.UseVisualStyleBackColor = True
        '
        'tbProperties
        '
        Me.tbProperties.Controls.Add(Me.txtPort)
        Me.tbProperties.Controls.Add(Me.Label1)
        Me.tbProperties.Location = New System.Drawing.Point(4, 22)
        Me.tbProperties.Name = "tbProperties"
        Me.tbProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProperties.Size = New System.Drawing.Size(541, 284)
        Me.tbProperties.TabIndex = 1
        Me.tbProperties.Text = "Properties"
        Me.tbProperties.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(53, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "COM3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port:"
        '
        'txtConsole
        '
        Me.txtConsole.Location = New System.Drawing.Point(6, 166)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.Size = New System.Drawing.Size(529, 112)
        Me.txtConsole.TabIndex = 6
        '
        'frmMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 334)
        Me.Controls.Add(Me.tabMainWindowTab)
        Me.Name = "frmMainWindow"
        Me.Text = "Main Window"
        Me.tabMainWindowTab.ResumeLayout(False)
        Me.tpControls.ResumeLayout(False)
        Me.tpControls.PerformLayout()
        Me.tbProperties.ResumeLayout(False)
        Me.tbProperties.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMainWindowTab As System.Windows.Forms.TabControl
    Friend WithEvents tpControls As System.Windows.Forms.TabPage
    Friend WithEvents tbProperties As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveDCForward As System.Windows.Forms.Button
    Friend WithEvents btnDCStop As System.Windows.Forms.Button
    Friend WithEvents btnMoveDCBack As System.Windows.Forms.Button
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox

End Class
