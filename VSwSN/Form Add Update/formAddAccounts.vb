Imports MySql.Data.MySqlClient

Public Class formAddAccounts

    'Form load
    Private Sub formAddAccounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formAccounts.adding = True Then
            lblTitle.Text = "Adding New Account Information"
            txtUserID.ReadOnly = True
            txtStudentName.ReadOnly = True
            cboUsertype.Enabled = True
            CheckBox1.Checked = False
            ClearAllFields()
            GetAccountID()
        Else
            GetUpdateAccount()
            lblTitle.Text = "Updating Account Information"
            txtUserID.ReadOnly = True
            txtStudentName.ReadOnly = True
            cboUsertype.Enabled = False
            btnRegister.Text = "Save"
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub ClearAllFields()
        cboUsertype.SelectedItem = "Select Login as"
        txtUserID.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtStudentName.Text = ""
    End Sub

#Region "Button Cancel"
    Private Sub btnCancel_Click_1(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region

#Region "Button Register"
    Private Sub btnRegister_Click_1(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        If formAccounts.adding = True Then
            AddAccount()
            formAccounts.LoadAccounts()
        Else
            UpdateAccount()
            formAccounts.LoadAccounts()
        End If
    End Sub
#End Region

#Region "GetAccountID()"
    Private Sub GetAccountID()
        Try
            query = "SELECT * FROM tblLogin ORDER BY UserID ASC"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtUserID.Text = sqlreader("UserID") + 1
            Else
                txtUserID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
#End Region

#Region "Add Account"
    Private Sub AddAccount()
        Try
            Connection()
            query = "INSERT INTO thesis.tblLogin (username, password, usertype,StudentID) VALUES ('" & txtUser.Text & "', '" & txtPass.Text & "', '" & cboUsertype.SelectedItem & "', '" & txtStudentName.Tag & "' )"
            sqlcommand = New MySqlCommand(query, conn)

            If cboUsertype.SelectedItem = "" Then
                MsgBox("Please Select between 'Administrator' and 'User' ", MsgBoxStyle.Information, "Account Information")
            ElseIf txtStudentName.Text = "" Then
                MsgBox("All fields Required. Please click Button Search to find and add student information.", MsgBoxStyle.Information, "Account Information")
            ElseIf txtUser.Text = "" Or txtPass.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Account Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Account successfully Register", MsgBoxStyle.Information, "Add Account Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close() 'Close all connection
        End Try
    End Sub
#End Region

#Region "Update Account"
    Private Sub UpdateAccount()
        Try
            query = "UPDATE tblLogin SET username ='" & txtUser.Text & "', password='" & txtPass.Text & "', usertype='" & cboUsertype.SelectedItem & "', StudentID='" & txtStudentName.Tag & "' WHERE userid='" & txtUserID.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)

            If cboUsertype.SelectedItem = "" Then
                MsgBox("Please Select between 'Administrator' and 'User' ", MsgBoxStyle.Information, "Update Account Information")
            ElseIf txtUser.Text = "" Or txtStudentName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Update Account Information")
            ElseIf txtPass.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Update Account Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Account successfully Updated", MsgBoxStyle.Information, "Update Account Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
#End Region

#Region "GetUpdateAccount()"
    Private Sub GetUpdateAccount()
        Try
            query = "SELECT * FROM tblLogin WHERE userid='" & formAccounts.ListViewAccounts.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtUserID.Text = sqlreader("userid")
                txtUser.Text = sqlreader("username")
                txtPass.Text = sqlreader("password")
                cboUsertype.SelectedItem = sqlreader("usertype")
                txtStudentName.Text = sqlreader("StudentID")
                txtStudentName.Tag = sqlreader("StudentID")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
#End Region

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        formLoadStudent.ShowDialog()
    End Sub
End Class