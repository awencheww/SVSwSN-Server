Imports MySql.Data.MySqlClient

Public Class formAddPosition

    Private Sub formAddPosition_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formPosition.adding = True Then
            lblTitle.Text = "Adding New Position"
            DisableFields()
            ClearAllFields()
        Else
            GetUpdatePosition()
            lblTitle.Text = "Updating Position"
            DisableFields()
        End If
    End Sub
        
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If formPosition.adding = True Then
            AddPosition()
            formPosition.LoadPosition()
        Else
            UpdatePosition()
            formPosition.LoadPosition()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearAllFields()
        txtPositionID.Text = ""
        cboPositionName.Text = "Select Position name"
        txtLevelName.Text = ""
    End Sub

    Private Sub DisableFields()
        txtPositionID.ReadOnly = True
        txtLevelName.ReadOnly = True
    End Sub

    Private Sub AddPosition()
        Try
            Connection()
            query = "INSERT INTO Positions(PositionName,LevelID) VALUES('" & cboPositionName.Text & "','" & txtLevelName.Tag & "') "
            sqlcommand = New MySqlCommand(query, conn)
            If cboPositionName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding New Position")
            ElseIf txtLevelName.Text = "" Then
                MsgBox("Please select Voting level", MsgBoxStyle.Exclamation, "Adding New Position")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Position successfully Added", MsgBoxStyle.Information, "Adding New Position")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdatePosition()
        Try
            Connection()
            query = "UPDATE Positions SET PositionName='" & cboPositionName.Text & "', LevelID='" & txtLevelName.Tag & "' WHERE PositionID='" & txtPositionID.Text & "'  "
            sqlcommand = New MySqlCommand(query, conn)
            If cboPositionName.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Update Position")
            ElseIf txtLevelName.Text = "" Then
                MsgBox("Please select Voting level", MsgBoxStyle.Exclamation, "Update Position")
            Else
                sqlreader = sqlcommand.ExecuteReader
                MsgBox("Position successfully Updated", MsgBoxStyle.Information, "Update Position")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdatePosition()
        Try
            query = "SELECT P.PositionID, P.PositionName,L.LevelName,P.LevelID FROM thesis.Positions as P, voting_level as L WHERE P.LevelID = L.LevelID AND PositionID  = '" & formPosition.ListViewPosition.FocusedItem.Text & "'"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtPositionID.Text = sqlreader("PositionID")
                cboPositionName.Text = sqlreader("PositionName")
                txtLevelName.Text = sqlreader("LevelName")
                txtLevelName.Tag = sqlreader("LevelID")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoadLevel_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadLevel.Click
        formLoadLevel.ShowDialog()
    End Sub
End Class