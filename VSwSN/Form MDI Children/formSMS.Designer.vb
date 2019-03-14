<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSaveMessage = New System.Windows.Forms.Button()
        Me.btnDeleteAllSMS = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.btnReceiveMessage = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDeleteMessage = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnReadsms = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblModemStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblCOMMPORT = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'btnSaveMessage
        '
        Me.btnSaveMessage.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveMessage.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMessage.ForeColor = System.Drawing.Color.White
        Me.btnSaveMessage.Location = New System.Drawing.Point(662, 263)
        Me.btnSaveMessage.Name = "btnSaveMessage"
        Me.btnSaveMessage.Size = New System.Drawing.Size(115, 28)
        Me.btnSaveMessage.TabIndex = 113
        Me.btnSaveMessage.Text = "Save Message"
        Me.btnSaveMessage.UseVisualStyleBackColor = True
        '
        'btnDeleteAllSMS
        '
        Me.btnDeleteAllSMS.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteAllSMS.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteAllSMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteAllSMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteAllSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAllSMS.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAllSMS.Location = New System.Drawing.Point(541, 263)
        Me.btnDeleteAllSMS.Name = "btnDeleteAllSMS"
        Me.btnDeleteAllSMS.Size = New System.Drawing.Size(115, 28)
        Me.btnDeleteAllSMS.TabIndex = 112
        Me.btnDeleteAllSMS.Text = "Delete ALL sms"
        Me.btnDeleteAllSMS.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(11, 175)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(277, 80)
        Me.txtMessage.TabIndex = 111
        Me.txtMessage.Text = ""
        '
        'btnReceiveMessage
        '
        Me.btnReceiveMessage.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnReceiveMessage.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReceiveMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReceiveMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReceiveMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiveMessage.ForeColor = System.Drawing.Color.White
        Me.btnReceiveMessage.Location = New System.Drawing.Point(173, 263)
        Me.btnReceiveMessage.Name = "btnReceiveMessage"
        Me.btnReceiveMessage.Size = New System.Drawing.Size(115, 28)
        Me.btnReceiveMessage.TabIndex = 109
        Me.btnReceiveMessage.Text = "Receive Message"
        Me.btnReceiveMessage.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 20)
        Me.TextBox1.TabIndex = 108
        '
        'btnDeleteMessage
        '
        Me.btnDeleteMessage.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMessage.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteMessage.ForeColor = System.Drawing.Color.White
        Me.btnDeleteMessage.Location = New System.Drawing.Point(420, 263)
        Me.btnDeleteMessage.Name = "btnDeleteMessage"
        Me.btnDeleteMessage.Size = New System.Drawing.Size(115, 28)
        Me.btnDeleteMessage.TabIndex = 107
        Me.btnDeleteMessage.Text = "Delete sms"
        Me.btnDeleteMessage.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDisconnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisconnect.ForeColor = System.Drawing.Color.White
        Me.btnDisconnect.Location = New System.Drawing.Point(109, 93)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(82, 28)
        Me.btnDisconnect.TabIndex = 106
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        Me.btnDisconnect.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(315, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(568, 243)
        Me.ListView1.TabIndex = 105
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Null"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Index"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message status"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Number"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date and Time"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Message"
        Me.ColumnHeader6.Width = 2048
        '
        'btnReadsms
        '
        Me.btnReadsms.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnReadsms.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReadsms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReadsms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnReadsms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadsms.ForeColor = System.Drawing.Color.White
        Me.btnReadsms.Location = New System.Drawing.Point(315, 263)
        Me.btnReadsms.Name = "btnReadsms"
        Me.btnReadsms.Size = New System.Drawing.Size(99, 28)
        Me.btnReadsms.TabIndex = 104
        Me.btnReadsms.Text = "Read Message"
        Me.btnReadsms.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(10, 263)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(115, 28)
        Me.btnSend.TabIndex = 103
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Location = New System.Drawing.Point(11, 144)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(277, 20)
        Me.txtNumber.TabIndex = 102
        '
        'lblModemStatus
        '
        Me.lblModemStatus.AutoSize = True
        Me.lblModemStatus.ForeColor = System.Drawing.Color.White
        Me.lblModemStatus.Location = New System.Drawing.Point(52, 60)
        Me.lblModemStatus.Name = "lblModemStatus"
        Me.lblModemStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblModemStatus.TabIndex = 101
        Me.lblModemStatus.Text = "Label3"
        Me.lblModemStatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Status:"
        '
        'btnConnect
        '
        Me.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Location = New System.Drawing.Point(11, 93)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(82, 28)
        Me.btnConnect.TabIndex = 99
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblCOMMPORT
        '
        Me.lblCOMMPORT.AutoSize = True
        Me.lblCOMMPORT.ForeColor = System.Drawing.Color.White
        Me.lblCOMMPORT.Location = New System.Drawing.Point(7, 12)
        Me.lblCOMMPORT.Name = "lblCOMMPORT"
        Me.lblCOMMPORT.Size = New System.Drawing.Size(39, 13)
        Me.lblCOMMPORT.TabIndex = 98
        Me.lblCOMMPORT.Text = "Label1"
        Me.lblCOMMPORT.Visible = False
        '
        'SerialPort1
        '
        '
        'formSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(890, 368)
        Me.Controls.Add(Me.btnSaveMessage)
        Me.Controls.Add(Me.btnDeleteAllSMS)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnReceiveMessage)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDeleteMessage)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnReadsms)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblModemStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblCOMMPORT)
        Me.Name = "formSMS"
        Me.Text = "formSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveMessage As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAllSMS As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btnReceiveMessage As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteMessage As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnReadsms As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblModemStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents lblCOMMPORT As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
End Class
