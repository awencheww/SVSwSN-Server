Imports MySql.Data.MySqlClient

Public Class formAddStudent


    Private Sub formAddStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formStudent.adding = True Then
            lblTitle.Text = "Adding New Student Information"
            txtStudentID.ReadOnly = True
            txtCourse.ReadOnly = True
            txtDepartment.ReadOnly = True
            ClearAllFields()
        Else
            GetUpdateStudent()
            lblTitle.Text = "Updating Student Information"
            txtStudentID.ReadOnly = True
            txtCourse.ReadOnly = True
            txtDepartment.ReadOnly = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        If formStudent.adding = True Then
            AddStudent()
            formStudent.LoadStudent()
        Else
            UpdateStudent()
            formStudent.LoadStudent()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearAllFields()
        txtAddress.Text = ""
        txtAge.Text = ""
        txtBdate.Text = ""
        txtCellNumber.Text = "+639"
        txtCourse.Text = ""
        txtDepartment.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddlename.Text = ""
        cmbGender.Text = ""
        cmbYearLevel.Text = ""
    End Sub

    Private Sub AddStudent()
        Try
            Connection()
            query = "INSERT INTO Student(cellnumber,lastname,firstname,middlename,age,gender,bdate,address,CourseID,DepartmentID,yearlevel,isVoted) VALUES('" & txtCellNumber.Text & "','" & txtLastname.Text & "','" & txtFirstname.Text & "','" & txtMiddlename.Text & "','" & txtAge.Text & "','" & cmbGender.SelectedItem & "','" & txtBdate.Text & "','" & txtAddress.Text & "','" & txtCourse.Tag & "','" & txtDepartment.Tag & "','" & cmbYearLevel.SelectedItem & "', 'NO')"
            sqlcommand = New MySqlCommand(query, conn)
            'Required Fields
            If txtCellNumber.Text = "+639" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtMiddlename.Text = "" Or txtAge.Text = "" Or cmbGender.SelectedItem = "" Or txtBdate.Text = "" Or txtAddress.Text = "" Or txtCourse.Text = "" Or txtDepartment.Text = "" Or cmbYearLevel.SelectedItem = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding New Student Informatoin")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("New Student successfully added.", MsgBoxStyle.Information, "Adding New Student Information")
                Me.Close()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            sqlreader.Close()
        End Try
    End Sub

    Private Sub UpdateStudent()
        Try
            Connection()
            query = "UPDATE Student SET cellnumber='" & txtCellNumber.Text & "',lastname='" & txtLastname.Text & "',firstname='" & txtFirstname.Text & "',middlename='" & txtMiddlename.Text & "',age='" & txtAge.Text & "',gender='" & cmbGender.SelectedItem & "',bdate='" & txtBdate.Text & "',address='" & txtAddress.Text & "',CourseID='" & txtCourse.Tag & "',DepartmentID='" & txtDepartment.Tag & "',yearlevel='" & cmbYearLevel.SelectedItem & "' WHERE StudentID='" & txtStudentID.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)
            'Required Fields
            If txtCellNumber.Text = "+639" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtMiddlename.Text = "" Or txtAge.Text = "" Or cmbGender.SelectedItem = "" Or txtBdate.Text = "" Or txtAddress.Text = "" Or txtCourse.Text = "" Or txtDepartment.Text = "" Or cmbYearLevel.SelectedItem = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Updating Student Informatoin")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Student Information successfully Updated.", MsgBoxStyle.Information, "Updating Student Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdateStudent()
        Try
            query = "SELECT D.DepartmentID, DeptName, StudentID, cellnumber, lastname, firstname, middlename, address,bdate,cellnumber,gender,age,Code, Description, yearlevel, C.CourseID FROM Department as D, Student as S, Course as C WHERE D.DepartmentID = S.DepartmentID AND  C.CourseID = S.COurseID AND StudentID  = '" & formStudent.ListViewStudent.FocusedItem.Text & "'"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtStudentID.Text = sqlreader("StudentID")
                txtCellNumber.Text = sqlreader("cellnumber")
                txtLastname.Text = sqlreader("lastname")
                txtFirstname.Text = sqlreader("Firstname")
                txtMiddlename.Text = sqlreader("Middlename")
                txtAddress.Text = sqlreader("Address")
                txtCourse.Text = sqlreader("Description")
                txtDepartment.Text = sqlreader("DeptName")
                txtDepartment.Tag = sqlreader("DepartmentID")
                cmbYearLevel.Text = sqlreader("YearLevel")
                txtCourse.Tag = sqlreader("CourseID")
                txtBdate.Text = sqlreader("bdate")
                txtAge.Text = sqlreader("age")
                cmbGender.SelectedItem = sqlreader("gender")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoadCourse_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadCourse.Click
        formLoadCourse.ShowDialog()
    End Sub

    'Blocked Character input, Only integer allowed
    Private Sub txtCellNumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Characters are not allowed", MsgBoxStyle.Exclamation, "Enter Contact")
            End If
        End If
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Characters are not allowed", MsgBoxStyle.Exclamation, "Enter Age")
            End If
        End If
    End Sub

    Private Sub btnLoadDepartment_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadDepartment.Click
        formLoadDepartment.ShowDialog()
    End Sub
End Class