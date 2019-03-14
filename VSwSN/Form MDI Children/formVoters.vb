Imports MySql.Data.MySqlClient

Public Class formVoters
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
        cmbFilterVoted.Text = "is Voted?"
    End Sub

    Public Sub LoadStudent()
        If cmbFilterVoted.Text = "Voted Students" Then
            strVoted = "YES"
        ElseIf cmbFilterVoted.Text = "Did Not Vote" Then
            strVoted = "NO"
        Else
            strVoted = ""
        End If
        Try
            Connection()
            query = "SELECT studentID,concat(lastname,', ',firstname,' ',middlename) as studname,Code,Description,DeptName,cellnumber,address,isVoted FROM thesis.student as s, thesis.course as c, thesis.department as d WHERE d.DepartmentID=s.DepartmentID AND c.CourseID=s.CourseID AND isVoted LIKE '" & strVoted & "%' AND Lastname LIKE '" & txtBoxSearch.Text & "%' AND d.DeptCode LIKE '" & cmbFilterDept.Text & "%' AND yearlevel LIKE '" & cmbFilterLevel.Text & "%' ORDER BY Lastname, Firstname ASC "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewStudent.Items.Clear()
            Dim x As ListViewItem
            intVoted = 0
            intDidNotVote = 0
            While sqlreader.Read = True
                If sqlreader("isVoted") = "YES" Then
                    intVoted += 1
                Else
                    intDidNotVote += 1
                End If
                x = New ListViewItem(sqlreader("studentID").ToString)
                x.SubItems.Add(sqlreader("studname"))
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("Description"))
                x.SubItems.Add(sqlreader("DeptName"))
                x.SubItems.Add(sqlreader("cellnumber"))
                x.SubItems.Add(sqlreader("address"))
                x.SubItems.Add(sqlreader("isVoted"))

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

    'Load Department
    Private Sub cmbFilterDept_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterDept.SelectedIndexChanged
        LoadStudent()
    End Sub

    'Load yearlevel
    Private Sub cmbFilterLevel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterLevel.SelectedIndexChanged
        LoadStudent()
    End Sub

    'Filter Voters who are done Voting and Not
    Private Sub cmbFilterVoted_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterVoted.SelectedIndexChanged
        LoadStudent()
    End Sub

    'Search Student Lastname
    Private Sub txtBoxSearch_Click(sender As System.Object, e As System.EventArgs) Handles txtBoxSearch.Click
        cmbFilterDept.Text = ""
        cmbFilterLevel.Text = ""
        cmbFilterVoted.Text = ""
        LoadStudent()
    End Sub
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadStudent()
    End Sub
End Class