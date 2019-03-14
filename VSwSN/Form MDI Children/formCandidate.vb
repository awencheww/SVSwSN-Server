Imports MySql.Data.MySqlClient

Public Class formCandidate
    Public adding As Boolean
    Public updating As Boolean
    Public SearchCandidate As Boolean


    Private Sub formCandidate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadCandidate()
        LoadDeptCode()
        LoadLevel()
        cmbFilterDept.Text = "Department"
        cmbFilterLevel.Text = "Year Level"
        cmbFilterVotingLevel.Text = "Voting Level"
    End Sub

    Public Sub LoadCandidate()
        Try
            Connection()
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', middlename) as CanName, age, bdate, sex, Address, DeptCode, Code, PartyName, PositionName,LevelName, Votes FROM thesis.Candidate as C, thesis.Department as D, thesis.Course as Co, thesis.Party as P, voting_level as L, thesis.Positions as Po WHERE C.PositionID = Po.PositionID AND Po.levelID = L.LevelID AND C.DepartmentID = D.DepartmentID AND C.CourseID = Co.CourseID AND C.PartyID = P.PartyID AND Lastname LIKE '" & txtBoxSearch.Text & "%' AND LevelName LIKE '" & cmbFilterVotingLevel.Text & "%' AND D.DeptCode LIKE '" & cmbFilterDept.Text & "%' AND yearlevel LIKE '" & cmbFilterLevel.Text & "%' ORDER BY Lastname "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewCandidate.Items.Clear()
            Dim x As ListViewItem
            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("Age"))
                x.SubItems.Add(sqlreader("bdate"))
                x.SubItems.Add(sqlreader("SEX"))
                x.SubItems.Add(sqlreader("Address"))
                x.SubItems.Add(sqlreader("DeptCode"))
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("PositionName"))
                x.SubItems.Add(sqlreader("LevelName"))
                x.SubItems.Add(sqlreader("Votes"))

                ListViewCandidate.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
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

    Private Sub LoadLevel()
        Try
            query = "SELECT LevelName FROM voting_level ORDER BY LevelName"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            cmbFilterVotingLevel.Items.Clear()
            cmbFilterVotingLevel.Items.Add("")
            Do While sqlreader.Read = True
                cmbFilterVotingLevel.Items.Add(sqlreader("LevelName"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButtonADD_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonADD.Click
        adding = True
        updating = False
        SearchCandidate = False
        formAddCandidate.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        Try
            If ListViewCandidate.Items.Count = 0 Then
                MsgBox("Please select record to Update", MsgBoxStyle.Exclamation, "Update Department")
                Exit Sub
            ElseIf ListViewCandidate.FocusedItem.Text = "" Then
                Exit Sub
            End If
            adding = False
            updating = True
            SearchCandidate = True
            formAddCandidate.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    'Search Box
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadCandidate()
    End Sub

    'Filter by Department
    Private Sub cmbFilterDept_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterDept.SelectedIndexChanged
        LoadCandidate()
    End Sub

    'Filter by yearlevel
    Private Sub cmbFilterLevel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterLevel.SelectedIndexChanged
        LoadCandidate()
    End Sub

    Private Sub txtBoxSearch_Click(sender As System.Object, e As System.EventArgs) Handles txtBoxSearch.Click
        cmbFilterDept.Text = ""
        cmbFilterLevel.Text = ""
        cmbFilterVotingLevel.Text = ""
        LoadCandidate()
    End Sub

    'Load LevelName
    Private Sub cmbFilterVotingLevel_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFilterVotingLevel.SelectedIndexChanged
        LoadCandidate()
    End Sub
End Class