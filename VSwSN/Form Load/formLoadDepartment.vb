Imports MySql.Data.MySqlClient

Public Class formLoadDepartment

    Private Sub formLoadDepartment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
        txtBoxSearch.Text = ""
    End Sub

    Private Sub LoadDepartment()
        Try
            query = "SELECT * FROM Department WHERE DeptCode LIKE '" & txtBoxSearch.Text & "%' ORDER BY DeptCode"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader()

            ListView1.Items.Clear()
            Dim x As ListViewItem
            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("DepartmentID").ToString)
                x.SubItems.Add(sqlreader("DeptCode"))
                x.SubItems.Add(sqlreader("DeptName"))

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub txtBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadDepartment()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As System.EventArgs) Handles ListView1.Click
        formAddStudent.txtDepartment.Text = ListView1.FocusedItem.SubItems(2).Text
        formAddStudent.txtDepartment.Tag = ListView1.FocusedItem.Text

        formAddCandidate.txtDepartment.Text = ListView1.FocusedItem.SubItems(2).Text
        formAddCandidate.txtDepartment.Tag = ListView1.FocusedItem.Text
        Me.Close()
    End Sub

End Class