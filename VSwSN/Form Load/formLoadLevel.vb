Imports MySql.Data.MySqlClient

Public Class formLoadLevel

    Private Sub LoadLevel()
        Try
            query = "SELECT * FROM voting_level ORDER BY LevelName"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewLoadLevel.Items.Clear()
            Dim x As ListViewItem
            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("LevelID").ToString)
                x.SubItems.Add(sqlreader("LevelName"))

                ListViewLoadLevel.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub formLoadLevel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadLevel()
    End Sub

    Private Sub ListViewLoadLevel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewLoadLevel.SelectedIndexChanged
        formAddPosition.txtLevelName.Text = ListViewLoadLevel.FocusedItem.SubItems(1).Text
        formAddPosition.txtLevelName.Tag = ListViewLoadLevel.FocusedItem.Text
        Me.Close()
    End Sub
End Class