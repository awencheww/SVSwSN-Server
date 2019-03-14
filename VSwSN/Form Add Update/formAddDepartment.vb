Imports MySql.Data.MySqlClient

Public Class formAddDepartment

    Private Sub formAddDepartment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formDepartment.adding = True Then
            lblTitle.Text = "Adding Department Information"
            ClearAllFields()
            txtDeptID.Enabled = False
        Else
            GetUpdateDepartment()
            lblTitle.Text = "Updating Department Information"
            txtDeptID.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If formDepartment.adding = True Then
            AddDepartment()
            formDepartment.LoadDepartment()
        Else
            UpdateDepartment()
            formDepartment.LoadDepartment()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearAllFields()
        txtDeptID.Text = ""
        txtDeptCode.Text = ""
        txtDeptName.Text = ""
    End Sub

    Private Sub AddDepartment()
        Try
            Connection()
            query = "INSERT INTO Department(DeptCode, DeptName) VALUES('" & txtDeptCode.Text & "','" & txtDeptName.Text & "')"
            sqlcommand = New MySqlCommand(query, conn)
            If txtDeptCode.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Department Information")
            ElseIf txtDeptName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Department Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Department Information successfully Added", MsgBoxStyle.Information, "Adding Department Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateDepartment()
        Try
            Connection()
            query = "UPDATE Department SET DeptCode='" & txtDeptCode.Text & "', DeptName='" & txtDeptName.Text & "' WHERE DepartmentID='" & txtDeptID.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)

            If txtDeptCode.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Updating Department Information")
            ElseIf txtDeptName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Updating Department Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Department Information successfully Updated", MsgBoxStyle.Information, "Updating Department Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdateDepartment()
        Try
            Connection()
            query = "SELECT * FROM Department WHERE DepartmentID='" & formDepartment.ListViewDepartment.FocusedItem.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            If sqlreader.Read = True Then
                txtDeptID.Text = sqlreader("DepartmentID")
                txtDeptCode.Text = sqlreader("DeptCode")
                txtDeptName.Text = sqlreader("DeptName")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
End Class