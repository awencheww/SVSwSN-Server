Imports MySql.Data.MySqlClient

Public Class formLoadCourse

    Private Sub formLoadCourse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadCourse()
        txtBoxSearch.Text = ""
    End Sub

    Private Sub LoadCourse()
        Try
            query = "SELECT * FROM Course WHERE CODE LIKE '" & txtBoxSearch.Text & "%' ORDER BY Code ASC"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CourseID").ToString)
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("Description"))
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    'Course Search Box
    Private Sub txtBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadCourse()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As System.EventArgs) Handles ListView1.Click
        'Loading Course to Add/Update New Student
        formAddStudent.txtCourse.Text = ListView1.FocusedItem.SubItems(2).Text
        formAddStudent.txtCourse.Tag = ListView1.FocusedItem.Text

        'Loading Course to Add/Update Candidate
        formAddCandidate.txtCourse.Text = ListView1.FocusedItem.SubItems(2).Text
        formAddCandidate.txtCourse.Tag = ListView1.FocusedItem.Text
        Me.Close()
    End Sub

End Class