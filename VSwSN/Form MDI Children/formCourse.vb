Imports MySql.Data.MySqlClient

Public Class formCourse
    Public adding As Boolean
    Public updating As Boolean

    Private Sub formCourse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadCourse()
    End Sub

    Public Sub LoadCourse()
        Try
            Connection()
            query = "SELECT * FROM Course WHERE CODE LIKE '" & txtBoxSearch.Text & "%' ORDER BY Code ASC"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            ListViewCourse.Items.Clear()
            Dim x As ListViewItem
            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CourseID").ToString)
                x.SubItems.Add(sqlreader("Code"))
                x.SubItems.Add(sqlreader("Description"))

                ListViewCourse.Items.Add(x)
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
        formAddCourse.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        Try
            If ListViewCourse.Items.Count = 0 Then
                MsgBox("Please select record to update.", MsgBoxStyle.Exclamation, "Update Course")
                Exit Sub
            ElseIf ListViewCourse.FocusedItem.Text = "" Then
                Exit Sub
            End If
            adding = False
            updating = True
            formAddCourse.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    'Search button
    Private Sub ToolStripButtonSEARCH_Click(sender As System.Object, e As System.EventArgs)
        LoadCourse()
    End Sub

    'Search box
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadCourse()
    End Sub
End Class