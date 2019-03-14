Imports MySql.Data.MySqlClient

Public Class formAddCourse

    Private Sub formAddCourse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formCourse.adding = True Then
            lblTitle.Text = "Adding New Course Information"
            txtCourseID.ReadOnly = True
            ClearAllFields()
            GetCourseID()
        Else
            GetUpdateCourse()
            lblTitle.Text = "Updating Course Information"
            txtCourseID.ReadOnly = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If formCourse.adding = True Then
            AddCourse()
            formCourse.LoadCourse()
        Else
            UpdateCourse()
            formCourse.LoadCourse()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearAllFields()
        txtCourseID.Text = ""
        txtCourseCode.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub GetCourseID()
        Try
            query = "SELECT * FROM Course ORDER BY CourseID ASC"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtCourseID.Text = sqlreader("CourseID") + 1
            Else
                txtCourseID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub AddCourse()
        Try
            Connection()
            query = "INSERT INTO Course(Code,Description) VALUES('" & txtCourseCode.Text & "','" & txtDescription.Text & "') "
            sqlcommand = New MySqlCommand(query, conn)

            If txtCourseCode.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Course Information")
            ElseIf txtDescription.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Course Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Course Information successfully Added")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateCourse()
        Try
            Connection()
            query = "UPDATE Course SET Code='" & txtCourseCode.Text & "', Description='" & txtDescription.Text & "' WHERE CourseID='" & txtCourseID.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)

            If txtCourseID.Text = "" Then
                MsgBox("All fields required", MsgBoxStyle.Exclamation, "Update Course Information")
            ElseIf txtDescription.Text = "" Then
                MsgBox("All fields required", MsgBoxStyle.Exclamation, "Update Course Information")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Course information successfully updated.", MsgBoxStyle.Information, "Update Course")
                ClearAllFields()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdateCourse()
        Try
            query = "SELECT CourseID,Code,Description FROM thesis.course WHERE CourseID  = '" & formCourse.ListViewCourse.FocusedItem.Text & "'"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            If sqlreader.Read = True Then
                txtCourseID.Text = sqlreader("CourseID")
                txtCourseCode.Text = sqlreader("Code")
                txtDescription.Text = sqlreader("Description")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoadDepartment_Click(sender As System.Object, e As System.EventArgs)
        formLoadDepartment.ShowDialog()
    End Sub
End Class