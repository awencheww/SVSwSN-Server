Imports MySql.Data.MySqlClient

Public Class formParty
    Public adding As Boolean
    Public updating As Boolean

    Private Sub formParty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadParty()
    End Sub

    Public Sub LoadParty()
        Try
            Connection()
            query = "SELECT * FROM Party WHERE PartyName LIKE '" & txtBoxSearch.Text & "%' ORDER BY PartyName "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewParty.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("PartyID").ToString)
                x.SubItems.Add(sqlreader("PartyCode"))
                x.SubItems.Add(sqlreader("PartyName"))

                ListViewParty.Items.Add(x)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButtonADD_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonADD.Click
        adding = True
        updating = False
        formAddParty.ShowDialog()
    End Sub

    Private Sub ToolStripButtonUPDATE_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonUPDATE.Click
        If ListViewParty.Items.Count = 0 Then
            MsgBox("Please select record to Update", MsgBoxStyle.Exclamation, "Updating Party List")
            Exit Sub
        ElseIf ListViewParty.FocusedItem.Text = "" Then
            Exit Sub
        End If
        adding = False
        updating = True
        formAddParty.ShowDialog()
    End Sub

    Private Sub txtBoxSearch_TextChanged(sender As Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        LoadParty()
    End Sub
End Class