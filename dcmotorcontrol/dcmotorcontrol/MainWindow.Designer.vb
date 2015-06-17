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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.cboPorts = New System.Windows.Forms.ComboBox()
        Me.tabMainWindowTab.SuspendLayout()
        Me.tpControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMainWindowTab
        '
        Me.tabMainWindowTab.Controls.Add(Me.tpControls)
        Me.tabMainWindowTab.Location = New System.Drawing.Point(12, 12)
        Me.tabMainWindowTab.Name = "tabMainWindowTab"
        Me.tabMainWindowTab.SelectedIndex = 0
        Me.tabMainWindowTab.Size = New System.Drawing.Size(368, 180)
        Me.tabMainWindowTab.TabIndex = 0
        '
        'tpControls
        '
        Me.tpControls.Controls.Add(Me.btnMoveDCForward)
        Me.tpControls.Controls.Add(Me.btnDCStop)
        Me.tpControls.Controls.Add(Me.btnMoveDCBack)
        Me.tpControls.Location = New System.Drawing.Point(4, 22)
        Me.tpControls.Name = "tpControls"
        Me.tpControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tpControls.Size = New System.Drawing.Size(360, 154)
        Me.tpControls.TabIndex = 0
        Me.tpControls.Text = "Controles"
        Me.tpControls.UseVisualStyleBackColor = True
        '
        'btnMoveDCForward
        '
        Me.btnMoveDCForward.Location = New System.Drawing.Point(257, 34)
        Me.btnMoveDCForward.Name = "btnMoveDCForward"
        Me.btnMoveDCForward.Size = New System.Drawing.Size(97, 85)
        Me.btnMoveDCForward.TabIndex = 5
        Me.btnMoveDCForward.Text = "Adelante"
        Me.btnMoveDCForward.UseVisualStyleBackColor = True
        '
        'btnDCStop
        '
        Me.btnDCStop.Location = New System.Drawing.Point(131, 34)
        Me.btnDCStop.Name = "btnDCStop"
        Me.btnDCStop.Size = New System.Drawing.Size(97, 85)
        Me.btnDCStop.TabIndex = 4
        Me.btnDCStop.Text = "Alto"
        Me.btnDCStop.UseVisualStyleBackColor = True
        '
        'btnMoveDCBack
        '
        Me.btnMoveDCBack.Location = New System.Drawing.Point(6, 34)
        Me.btnMoveDCBack.Name = "btnMoveDCBack"
        Me.btnMoveDCBack.Size = New System.Drawing.Size(97, 85)
        Me.btnMoveDCBack.TabIndex = 3
        Me.btnMoveDCBack.Text = "Atras"
        Me.btnMoveDCBack.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(382, 102)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(135, 51)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Conectar"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Puerto:"
        '
        'txtConsole
        '
        Me.txtConsole.Location = New System.Drawing.Point(12, 198)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.Size = New System.Drawing.Size(505, 124)
        Me.txtConsole.TabIndex = 6
        '
        'cboPorts
        '
        Me.cboPorts.FormattingEnabled = True
        Me.cboPorts.Location = New System.Drawing.Point(429, 31)
        Me.cboPorts.Name = "cboPorts"
        Me.cboPorts.Size = New System.Drawing.Size(88, 21)
        Me.cboPorts.TabIndex = 7
        '
        'frmMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 334)
        Me.Controls.Add(Me.cboPorts)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtConsole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabMainWindowTab)
        Me.Name = "frmMainWindow"
        Me.Text = "Main Window"
        Me.tabMainWindowTab.ResumeLayout(False)
        Me.tpControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabMainWindowTab As System.Windows.Forms.TabControl
    Friend WithEvents tpControls As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMoveDCForward As System.Windows.Forms.Button
    Friend WithEvents btnDCStop As System.Windows.Forms.Button
    Friend WithEvents btnMoveDCBack As System.Windows.Forms.Button
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cboPorts As System.Windows.Forms.ComboBox

End Class
