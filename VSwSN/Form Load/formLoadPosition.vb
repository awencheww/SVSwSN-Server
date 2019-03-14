Imports MySql.Data.MySqlClient

Public Class formLoadPosition

    Private Sub LoadPosition()
        Try
            query = "SELECT PositionID, PositionName, LevelName FROM Positions as P, voting_level as L WHERE P.LevelID = L.LevelID AND PositionName LIKE '" & txtBoxSearch.Text & "%' AND LevelName LIKE '" & formAddCandidate.cmbLevel.Text & "%' ORDER By PositionID ASC"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("PositionID").ToString)
                x.SubItems.Add(sqlreader("PositionName"))
                x.SubItems.Add(sqlreader("levelname"))
                ListView1.Items.Add(x)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ListView1_Click(sender As Object, e As System.EventArgs) Handles ListView1.Click
        formAddCandidate.txtPosition.Text = ListView1.FocusedItem.SubItems(1).Text
        formAddCandidate.txtPosition.Tag = ListView1.FocusedItem.Text
        Me.Close()
    End Sub

    Private Sub txtBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadPosition()
    End Sub

    Private Sub formLoadPosition_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadPosition()
        txtBoxSearch.Text = ""
    End Sub
End Class