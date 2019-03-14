Imports MySql.Data.MySqlClient

Public Class formPosition
    Public adding As Boolean
    Public updating As Boolean

    Private Sub formPosition_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadPosition()
    End Sub

    Public Sub LoadPosition()
        Try
            Connection()
            query = "SELECT DISTINCT PositionID, PositionName, LevelName FROM thesis.positions as p JOIN thesis.voting_level as l ON l.LevelID=p.LevelID WHERE l.LevelID=p.LevelID AND PositionName LIKE '" & txtBoxSearch.Text & "%' ORDER BY LevelName "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewPosition.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("PositionID").ToString)
                x.SubItems.Add(sqlreader("PositionName"))
                x.SubItems.Add(sqlreader("LevelName"))

                ListViewPosition.Items.Add(x)
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
        formAddPosition.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        If ListViewPosition.Items.Count = 0 Then
            MsgBox("Please select record to Update", MsgBoxStyle.Exclamation, "Updating Party List")
            Exit Sub
        ElseIf ListViewPosition.FocusedItem.Text = "" Then
            Exit Sub
        End If
        adding = False
        updating = True
        formAddPosition.ShowDialog()
    End Sub

    'Search box
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadPosition()
    End Sub
End Class