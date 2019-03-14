Imports MySql.Data.MySqlClient

Public Class formLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ValidateAccount()
        AddLogs()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidateAccount()
            AddLogs()
        End If
    End Sub

#Region "Validate Account"
    Private Sub ValidateAccount()
        Dim qryadmin As String

        Try
            'Connect to Database
            Connection()
            'SQL Query and Execution
            qryadmin = "SELECT * FROM thesis.tblLogin WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "' AND usertype='" & cboUsertype.SelectedItem & "' "
            sqlcommand = New MySqlCommand(qryadmin, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                MsgBox("Welcome to SSCT Voting System w/ SMS Notification", MsgBoxStyle.Information, "Access Granted")
                Me.Hide()
                formMain.Show()
                formMain.lblStatus.Text = sqlreader("usertype")
                formMain.lblStatus.Tag = sqlreader("StudentID")
            ElseIf txtUsername.Text = "" Or txtPassword.Text = "" Or cboUsertype.SelectedItem = "" Then
                MsgBox("All fields required", MsgBoxStyle.Exclamation, "Login Account")
            ElseIf txtUsername.Text = "Enter Username" Or txtPassword.Text = "Enter Password" Or cboUsertype.SelectedItem = "" Or cboUsertype.SelectedItem = "Select Login as" Then
                MsgBox("Make sure you have enter your Username and Password Correctly", MsgBoxStyle.Exclamation, "Login Account")
            ElseIf sqlreader.Read = False Then
                MsgBox("Make sure you have enter your Username and Password Correctly", MsgBoxStyle.Exclamation, "Login Account")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
#End Region

    Public Sub AddLogs()
        Dim strPCName As String = System.Net.Dns.GetHostName()
        Dim strDesc As String = formMain.lblStatus.Tag & " - Active user"

        Try
            query = "INSERT INTO UserLogs(Date, Time, Description, PCName) VALUES('" & Date.Now.ToString("MM/dd/yyyy") & "', '" & Format(Date.Now, "Long Time") & "', '" & strDesc & "', '" & strPCName & "')"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlcommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

#Region "Username and Password Selectall text"
    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        txtUsername.SelectAll()
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub

    Private Sub txtUsername_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtUsername.MouseClick
        txtUsername.SelectAll()
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPassword.MouseClick
        txtPassword.SelectAll()
    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel, "Cancel") = MsgBoxResult.Cancel Then
            txtUsername.SelectAll()
        Else
            End
        End If
    End Sub
    
    Private Sub chkShowChar_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkShowChar.CheckedChanged
        If chkShowChar.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

End Class