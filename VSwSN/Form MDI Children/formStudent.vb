Imports MySql.Data.MySqlClient

Public Class formStudent
    Public adding As Boolean
    Public updating As Boolean
    Dim strVoted As String
    Dim intVoted As Integer
    Dim intDidNotVote As Integer


    Private Sub formStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadStudent()
        LoadDeptCode()
        cmbFilterDept.Text = "Department"
        cmbFilterLevel.Text = "Year Level"
    End Sub

    Public Sub LoadStudent()
        Try
            Connection()
            query = "SELECT StudentID, CONCAT(lastname,', ', firstname,' ',middlename) as studname,cellnumber,gender,address,Code, d.DeptName, yearlevel FROM thesis.student as s, thesis.course as c, thesis.department as d WHERE d.DepartmentID=s.DepartmentID AND c.CourseID=s.CourseID AND Lastname LIKE '" & txtBoxSearch.Text & "%' AND d.DeptCode LIKE '" & cmbFilterDept.Text & "%' AND yearlevel LIKE '" & cmbFilterLevel.Text & "%' ORDER BY Lastname ASC"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewStudent.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("studentID").ToString)
                x.SubItems.Add(sqlreader("studname"))
                x.SubItems.Add(sqlreader("cellnumber"))
                x.SubItems.Add(sqlreader("gender"))
                x.SubItems.Add(sqlreader("address"))
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("DeptName"))
                x.SubItems.Add(sqlreader("yearlevel"))

                ListViewStudent.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButtonADD_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonADD.Click
        adding = True
        updating = False
        formAddStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        Try
            If ListViewStudent.Items.Count = 0 Then
                MsgBox("Please select record to Update", MsgBoxStyle.Exclamation, "Updating Student Information")
                Exit Sub
            ElseIf ListViewStudent.FocusedItem.Text = "" Then
                Exit Sub
            End If
            adding = False
            updating = True
            formAddStudent.ShowDialog()
        Catch ex As Exception

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

    Private Sub ToolStripTextBox1_Click(sender As System.Object, e As System.EventArgs) Handles txtBoxSearch.Click
        cmbFilterDept.Text = ""
        cmbFilterLevel.Text = ""
        LoadStudent()
    End Sub

    'Load Department
    Private Sub cmbFilterDept_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterDept.SelectedIndexChanged
        LoadStudent()
    End Sub

    'Load yearlevel
    Private Sub cmbFilterLevel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterLevel.SelectedIndexChanged
        LoadStudent()
    End Sub

    'Search Student
    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadStudent()
    End Sub
End Class