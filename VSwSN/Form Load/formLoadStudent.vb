Imports MySql.Data.MySqlClient

Public Class formLoadStudent

    Private Sub txtBoxSearch_Click(sender As Object, e As System.EventArgs) Handles txtBoxSearch.Click
        cmbFilterDept.Text = ""
        cmbFilterLevel.Text = ""
        LoadStudent()
    End Sub

    Private Sub txtBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadStudent()
    End Sub

    Private Sub formLoadStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadStudent()
        LoadDeptCode()
        txtBoxSearch.Text = ""
        cmbFilterDept.Text = "Department"
        cmbFilterLevel.Text = "Year Level"
    End Sub

    Public Sub LoadStudent()
        Try
            Connection()
            query = "SELECT StudentID,lastname,firstname,middlename,cellnumber,gender,address,Code, d.DeptCode,yearlevel,age,bdate FROM thesis.student as s, thesis.course as c, thesis.department as d WHERE d.DepartmentID=s.DepartmentID AND c.CourseID=s.CourseID AND Lastname LIKE '" & txtBoxSearch.Text & "%' AND d.DeptCode LIKE '" & cmbFilterDept.Text & "%' AND yearlevel LIKE '" & cmbFilterLevel.Text & "%' ORDER BY Lastname ASC"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            ListViewStudent.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("studentID").ToString)
                x.SubItems.Add(sqlreader("lastname"))
                x.SubItems.Add(sqlreader("firstname"))
                x.SubItems.Add(sqlreader("middlename"))
                x.SubItems.Add(sqlreader("cellnumber"))
                x.SubItems.Add(sqlreader("gender"))
                x.SubItems.Add(sqlreader("address"))
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("DeptCode"))
                x.SubItems.Add(sqlreader("yearlevel"))
                x.SubItems.Add(sqlreader("age"))
                x.SubItems.Add(sqlreader("bdate"))

                ListViewStudent.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDeptCode()
        Try
            query = "SELECT DeptCode FROM Department ORDER BY DeptCode"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            cmbFilterDept.Items.Clear()
            cmbFilterDept.Items.Add("")
            Do While sqlreader.Read = True
                cmbFilterDept.Items.Add(sqlreader("DeptCode"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub cmbFilterDept_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterDept.SelectedIndexChanged
        LoadStudent()
    End Sub

    Private Sub cmbFilterLevel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterLevel.SelectedIndexChanged
        LoadStudent()
    End Sub

    Private Sub ListViewStudent_DoubleClick(sender As Object, e As System.EventArgs) Handles ListViewStudent.DoubleClick
        formAddCandidate.txtCandidateID.Text = ListViewStudent.FocusedItem.SubItems(0).Text
        formAddCandidate.txtLastname.Text = ListViewStudent.FocusedItem.SubItems(1).Text
        formAddCandidate.txtFirstname.Text = ListViewStudent.FocusedItem.SubItems(2).Text
        formAddCandidate.txtMiddlename.Text = ListViewStudent.FocusedItem.SubItems(3).Text
        formAddCandidate.txtCellNumber.Text = ListViewStudent.FocusedItem.SubItems(4).Text
        formAddCandidate.cmbGender.Text = ListViewStudent.FocusedItem.SubItems(5).Text
        formAddCandidate.txtAddress.Text = ListViewStudent.FocusedItem.SubItems(6).Text
        formAddCandidate.cmbYearLevel.Text = ListViewStudent.FocusedItem.SubItems(9).Text
        formAddCandidate.txtAge.Text = ListViewStudent.FocusedItem.SubItems(10).Text
        formAddCandidate.txtBdate.Text = ListViewStudent.FocusedItem.SubItems(11).Text

        formAddAccounts.txtStudentName.Text = ListViewStudent.FocusedItem.SubItems(0).Text
        formAddAccounts.txtStudentName.Tag = ListViewStudent.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub

End Class