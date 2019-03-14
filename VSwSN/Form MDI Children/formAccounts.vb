Imports MySql.Data.MySqlClient

Public Class formAccounts
    Public adding As Boolean 'Turn on/off adding Account information
    Public updating As Boolean 'Turn on/off updating Account information

    Private Sub formAccounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAccounts()
    End Sub

#Region "LoadAccount Another style"
    'Public Sub LoadAccount()
    '    Dim query As String = "SELECT * FROM thesis.tblLogin"
    '    Dim sqladapter As New MySqlDataAdapter
    '    Dim TABLE As New DataTable
    '    Dim i As Integer

    '    With sqlcommand
    '        .CommandText = query
    '        Connection()
    '    End With

    '    With sqladapter
    '        .SelectCommand = sqlcommand
    '        .Fill(TABLE)
    '    End With

    '    For i = 0 To TABLE.Rows.Count - 1
    '        With ListViewAccounts
    '            .Items.Add(TABLE.Rows(i)("userid"))
    '            With .Items(.Items.Count - 1).SubItems
    '                .Add(TABLE.Rows(i)("username"))
    '                .Add(TABLE.Rows(i)("password"))
    '                .Add(TABLE.Rows(i)("usertype"))
    '            End With
    '        End With
    '    Next
    'End Sub
#End Region

#Region "LoadAccounts()"
    Public Sub LoadAccounts()
        Try
            Connection()
            query = "SELECT userid,username,password,usertype,s.studentID,concat(lastname,', ',firstname,' ',middlename) as studname FROM student as s join tbllogin as l On s.StudentID=l.StudentID"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewAccounts.Items.Clear()
            Dim x As ListViewItem

            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("userid").ToString)
                x.SubItems.Add(sqlreader("username"))
                x.SubItems.Add(encrypt(sqlreader("password")))
                x.SubItems.Add(sqlreader("usertype"))
                x.SubItems.Add(sqlreader("StudentID"))
                x.SubItems.Add(sqlreader("studname"))

                ListViewAccounts.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
#End Region

#Region "ToolStrip Buttnn ADD"
    Private Sub ToolStripButtonADD_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonADD.Click
        adding = True
        updating = False
        formAddAccounts.ShowDialog()
    End Sub
#End Region

#Region "ToolStrip Button UPDATE"
    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        Try
            If ListViewAccounts.Items.Count = 0 Then
                MsgBox("Please select record to update.", MsgBoxStyle.Exclamation, "Update Student")
                Exit Sub
            ElseIf ListViewAccounts.FocusedItem.Text = "" Then
                Exit Sub
            End If
            adding = False
            updating = True
            formAddAccounts.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub ToolStripButtonDELETE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonDELETE.Click
        Try
            query = "DELETE FROM tblLogin WHERE userid='" & ListViewAccounts.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            If ListViewAccounts.Items.Count = 0 Then
                MsgBox("Please select record to delete.", MsgBoxStyle.Exclamation, "Delete Account")
                Exit Sub
            ElseIf ListViewAccounts.FocusedItem.Text = "" Then
                Exit Sub
            ElseIf MsgBox("Are you sure you want to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.Yes Then
                sqlcommand.ExecuteNonQuery()
                MsgBox("Account successfully deleted", MsgBoxStyle.Information, "Delete Account")
            End If
            LoadAccounts()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
End Class