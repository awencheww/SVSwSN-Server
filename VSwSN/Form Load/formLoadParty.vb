Imports MySql.Data.MySqlClient
Public Class formLoadParty


    Private Sub LoadParty()
        Try
            query = "SELECT * FROM Party WHERE PartyName LIKE '" & txtBoxSearch.Text & "%' ORDER By PartyName"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While sqlreader.Read = True
                x = New ListViewItem(sqlreader("PartyID").ToString)
                x.SubItems.Add(sqlreader("PartyCode"))
                x.SubItems.Add(sqlreader("PartyName"))

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
        LoadParty()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        formAddCandidate.txtParty.Text = Me.ListView1.FocusedItem.SubItems(2).Text
        formAddCandidate.txtParty.Tag = Me.ListView1.FocusedItem.Text
        Me.Close()
    End Sub

    Private Sub frmLoadParty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadParty()
        txtBoxSearch.Text = ""
    End Sub
End Class