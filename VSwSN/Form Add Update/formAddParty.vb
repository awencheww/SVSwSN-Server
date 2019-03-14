Imports MySql.Data.MySqlClient

Public Class formAddParty

    Private Sub formAddParty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formParty.adding = True Then
            lblTitle.Text = "Adding Party List"
            txtPartyID.ReadOnly = False
            ClearAllFields()
        Else
            lblTitle.Text = "Updating Party List"
            txtPartyID.ReadOnly = False
            GetUpdateParty()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If formParty.adding = True Then
            AddParty()
            formParty.LoadParty()
        Else
            UpdateParty()
            formParty.LoadParty()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearAllFields()
        txtPartyID.Text = ""
        txtPartyCode.Text = ""
        txtPartyName.Text = ""
    End Sub

    Private Sub AddParty()
        Try
            Connection()
            query = "INSERT INTO Party(PartyCode, PartyName) VALUES('" & txtPartyCode.Text & "', '" & txtPartyName.Text & "') "
            sqlcommand = New MySqlCommand(query, conn)
            If txtPartyCode.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Party List")
            ElseIf txtPartyName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding Party List")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Party List sucessfully Added", MsgBoxStyle.Information, "Adding Party List")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateParty()
        Try
            Connection()
            query = "UPDATE Party SET PartyCode='" & txtPartyCode.Text & "',PartyName='" & txtPartyName.Text & "' WHERE PartyID='" & txtPartyID.Text & "'  "
            sqlcommand = New MySqlCommand(query, conn)
            If txtPartyCode.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Updating Party List")
            ElseIf txtPartyName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Updating Party List")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Party List sucessfully Updated", MsgBoxStyle.Information, "Updating Party List")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdateParty()
        Try
            Connection()
            query = "SELECT * FROM Party WHERE PartyID='" & formParty.ListViewParty.FocusedItem.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader
            If sqlreader.Read = True Then
                txtPartyID.Text = sqlreader("PartyID")
                txtPartyCode.Text = sqlreader("PartyCode")
                txtPartyName.Text = sqlreader("PartyName")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
End Class