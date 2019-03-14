Imports MySql.Data.MySqlClient

Public Class formDepartment
    Public adding As Boolean
    Public updating As Boolean

    Private Sub formDepartment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
    End Sub

    Public Sub LoadDepartment()
        Try
            Connection()
            query = "SELECT * FROM thesis.Department"
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewDepartment.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("DepartmentID").ToString)
                x.SubItems.Add(sqlreader("DeptCode"))
                x.SubItems.Add(sqlreader("DeptName"))

                ListViewDepartment.Items.Add(x)
            End While
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
        formAddDepartment.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        Try
            If ListViewDepartment.Items.Count = 0 Then
                MsgBox("Please select record to Update", MsgBoxStyle.Exclamation, "Update Department")
                Exit Sub
            ElseIf ListViewDepartment.FocusedItem.Text = "" Then
                Exit Sub
            End If
            adding = False
            updating = True
            formAddDepartment.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    'Search box
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadDepartment()
    End Sub
End Class