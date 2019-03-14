Imports System
Imports System.IO.Ports
Imports System.Management
Imports System.Threading
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class formSMS
    Dim result() As String
    Dim query As String
    Dim rcvdata As String
    Dim index As String = "" 'first declare our index

    'Private Sub Form1_Load
    Private Sub formSMS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            TextBox1.Text = ports(i) 'Show Detected Available COMMPORT with Description(The GSM MODEM)
            lblCOMMPORT.Text = Trim(Mid(TextBox1.Text, 1, 5)) 'Trim detected Modem from TextBox1 and Get only COM15
            ModemConnect() 'Private sub Auto ModemConnect()
        Next
    End Sub

    'Detect Modem
#Region "ModemsConnected()"
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return modems
    End Function
#End Region

    'Automatic Connect the Detected Modem
#Region "Auto Connect Modem"
    Private Sub ModemConnect()
        Try
            With SerialPort1
                .PortName = lblCOMMPORT.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With
            If SerialPort1.IsOpen Then
                lblModemStatus.Visible = True
                btnDisconnect.Visible = True
                lblModemStatus.Text = "Connected - Port " & lblCOMMPORT.Text & " is used"
            Else
                lblModemStatus.Text = "Got some Error, Check your connection with your Modem."
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Text Messaging")
        End Try
    End Sub
#End Region

    'Modem Connection
#Region "Button Connect"
    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
        Try
            With SerialPort1
                .PortName = lblCOMMPORT.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With
            If SerialPort1.IsOpen Then
                lblModemStatus.Visible = True
                btnDisconnect.Visible = True
                lblModemStatus.Text = "Connected - Port " & lblCOMMPORT.Text & " is used"
            Else
                lblModemStatus.Text = "Got some Error, Check your connection with your Modem."
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Text Messaging")
        End Try
    End Sub
#End Region

    'Disconnect Modem
#Region "Button Disconnect"
    Private Sub btnDisconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnect.Click
        Try
            If SerialPort1.IsOpen Then
                With SerialPort1
                    .Close()
                    .Dispose()
                    lblCOMMPORT.Visible = False
                    lblModemStatus.Visible = False
                    btnDisconnect.Visible = False
                    ListView1.Items.Clear()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    'Handle SerialPort DataReceived
#Region "SerialPort DataReceived"
    Private Sub SerialPort1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        test(datain)
    End Sub
    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub
#End Region

    'Save Read messages to ListView1
#Region "ListView1_readmsg()"
    Private Sub ListView1_readmsg()
        Try
            Dim lineoftext As String
            Dim i As Integer
            Dim arytextfile() As String
            lineoftext = rcvdata.ToString
            arytextfile = Split(lineoftext, "+CMGL", , CompareMethod.Text)
            For i = 1 To UBound(arytextfile)
                Dim input As String = arytextfile(i)
                Dim pattern As String = "(:)|(,"")|("","")"
                result = Regex.Split(input, pattern)
                Dim concat() As String
                With ListView1.Items.Add("null")
                    'for index
                    .SubItems.AddRange(New String() {result(2).ToString})
                    'for status
                    .SubItems.AddRange(New String() {result(4).ToString})
                    'for number
                    Dim my_string, position As String
                    my_string = result(6)
                    position = my_string.Length - 2
                    my_string = my_string.Remove(position, 2)
                    .SubItems.Add(my_string)
                    'for date and time
                    concat = New String() {result(8) & result(9) & result(10) & result(11) & result(12).Substring(0, 2)}
                    .SubItems.AddRange(concat)
                    'for message
                    Dim lineoftexts As String
                    Dim arytextfiles() As String
                    lineoftexts = arytextfile(i)
                    arytextfiles = Split(lineoftexts, "+32", , CompareMethod.Text)
                    .SubItems.Add(arytextfiles(1))
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    'Private sub ReadSMS()
#Region "Read Message"
    Private Sub ReadSMS()
        Try
            With SerialPort1
                .Write("AT" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGF=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CPMS=""SM""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGL=""ALL""")
                Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
                ListView1_readmsg()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    'Button for Reading messages
#Region "Button Readsms()"
    Private Sub btnReadsms_Click(sender As System.Object, e As System.EventArgs) Handles btnReadsms.Click
        Try
            With SerialPort1
                .Write("AT" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGF=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CPMS=""SM""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGL=""ALL""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
                ListView1_readmsg()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    'Button Send Message
#Region "Button Send"
    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        Dim query As String
        Try
            Connection()
            query = "INSERT INTO thesis.tblsentitems (PhoneNumber, message) VALUES('" & txtNumber.Text & "', '" & txtMessage.Text & "')"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            With SerialPort1
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(200)
                .Write("at+cmgf=1" & vbCrLf)
                Threading.Thread.Sleep(200)
                .Write("at+cmgs=" & Chr(34) & txtNumber.Text & Chr(34) & vbCrLf)
                .Write(txtMessage.Text & Chr(26))
                Threading.Thread.Sleep(200)

            End With
            If rcvdata.ToString.Contains(">") Then
                MsgBox("Message Succesfully Sent")
                txtMessage.Text = ""
                txtNumber.Text = ""
                conn.Close()
            Else
                MsgBox("Got some error!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Text Messaging")
        End Try
    End Sub
#End Region

    'Button Delete Message
#Region "Button Delete Message"
    Private Sub btnDeleteMessage_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteMessage.Click
        Try
            With SerialPort1
                .Write("AT" & vbCrLf)
                .Write("AT+CMGD=0" & ListView1.FocusedItem.SubItems(1).Text & vbCrLf)
                Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
                If rcvdata.ToString.Contains("ERROR") = False Then
                    MsgBox("Message Deleted")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Text Messaging")
        End Try
    End Sub
#End Region

    'Delete all messages stored from preferred storage modem
#Region "Delete All message"
    Private Sub btnDeleteAllSMS_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteAllSMS.Click
        Try
            With SerialPort1
                .Write("AT" & vbCrLf)
                .Write("AT+CMGD=1" & ListView1.FocusedItem.SubItems(1).Text & ",4" & vbCrLf)
                Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
                If rcvdata.ToString.Contains("ERROR") = False Then
                    MsgBox("Message Deleted")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Text Messaging")
        End Try
    End Sub
#End Region

    'Button Save Message
#Region "Button Save Message"
    Private Sub btnSaveMessage_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveMessage.Click
        Try
            Connection()
            query = "INSERT INTO tblInbox(smsIndex, smsStatus, smsNumber, smsDateTime, smsMessage) VALUES('" & ListView1.FocusedItem.SubItems(1).Text & "', '" & ListView1.FocusedItem.SubItems(2).Text & "', '" & ListView1.FocusedItem.SubItems(3).Text & "', '" & ListView1.FocusedItem.SubItems(4).Text & "', '" & ListView1.FocusedItem.SubItems(5).Text & "')"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            MsgBox("Message Save")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            Connection()
            query = "INSERT INTO tblInbox(smsIndex, smsStatus, smsNumber, smsDateTime, smsMessage) VALUES('" & ListView1.FocusedItem.SubItems(1).Text & "', '" & ListView1.FocusedItem.SubItems(2).Text & "', '" & ListView1.FocusedItem.SubItems(3).Text & "', '" & ListView1.FocusedItem.SubItems(4).Text & "', '" & ListView1.FocusedItem.SubItems(5).Text & "') "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            MsgBox("Message save")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnReceiveMessage_Click(sender As System.Object, e As System.EventArgs) Handles btnReceiveMessage.Click
        Try
            With SerialPort1
                .Write("AT" & vbCrLf)
                .Write("AT+WUSS=?" & vbCrLf)
                Threading.Thread.Sleep(1000)
                MsgBox(rcvdata.ToString)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
