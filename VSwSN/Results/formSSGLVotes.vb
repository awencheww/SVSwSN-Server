Imports MySql.Data.MySqlClient
Public Class formSSGLVotes
    Private totalvoters As Integer
    Private percent As Double

    Private Sub formSSGLVotes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadGov()
        LoadViceGov()
        LoadSecretary()
        LoadTreasurer()
        LoadBman()
        LoadAuditor()
        LoadPIO()
        GetTotalSSGVotes()
    End Sub


#Region "load Positions"

#Region "GOVERNOR"
    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewGov.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewGov.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxGov.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewGov.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarGov.Value = (percent)
                Label1.Text = ProgressBarGov.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadGov()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Governor' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewGov.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewGov.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "VICE-GOVERNOR"
    Private Sub ListViewViceGov_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewViceGov.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewViceGov.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxViceGov.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewViceGov.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarViceGov.Value = (percent)
                lblVG.Text = ProgressBarViceGov.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadViceGov()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Vice-Governor' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewViceGov.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewViceGov.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SECRETARY"
    Private Sub ListViewS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewS.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewS.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxSecretary.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewS.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarS.Value = (percent)
                lblS.Text = ProgressBarS.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadSecretary()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Secretary' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewS.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewS.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "TREASURER"
    Private Sub ListViewTreasurer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewTreasurer.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewTreasurer.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxTreasurer.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewTreasurer.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarTreasurer.Value = (percent)
                lblTreasurer.Text = ProgressBarTreasurer.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadTreasurer()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Treasurer' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewTreasurer.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewTreasurer.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "BUSINESS MANAGER"
    Private Sub ListViewBman_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewBman.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewBman.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxBman.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewBman.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarBman.Value = (percent)
                lblBman.Text = ProgressBarBman.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadBman()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Business Manager' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewBman.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewBman.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "AUDITOR"
    Private Sub ListViewAuditor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewAuditor.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewAuditor.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxAuditor.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewAuditor.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarAuditor.Value = (percent)
                lblAuditor.Text = ProgressBarAuditor.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadAuditor()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'Auditor' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewAuditor.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewAuditor.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "PIO"
    Private Sub ListViewPIO_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewPIO.SelectedIndexChanged
        Try
            query = "SELECT PicFile, Votes from Candidate where CandidateID = '" & ListViewPIO.FocusedItem.Text & "' "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBoxPIO.Image = Image.FromStream(ms)
                'Formula to get the Percentage... Total=(total votes / total voters) * 100
                percent = (ListViewPIO.FocusedItem.SubItems(3).Text / totalvoters) * 100

                ProgressBarPIO.Value = (percent)
                lblPIO.Text = ProgressBarPIO.Value & " %"
                Timer1.Dispose()
            End If
        Catch ex As Exception

        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadPIO()
        Try
            query = "SELECT CandidateID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) as CanName,PartyName,PicFile,Votes FROM Candidate as C, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.PartyID = P.PartyID AND C.PositionID = Po.PositionID AND PositionName = 'PIO' AND LevelName = 'SSG Legislative Branch'  ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            ListViewPIO.Items.Clear()
            Dim x As ListViewItem
            While sqlreader.Read = True
                x = New ListViewItem(sqlreader("CandidateID").ToString)
                x.SubItems.Add(sqlreader("CanName"))
                x.SubItems.Add(sqlreader("PartyName"))
                x.SubItems.Add(sqlreader("Votes"))
                ListViewPIO.Items.Add(x)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#End Region

    Private Sub GetTotalSSGVotes()
        totalvoters = 0
        Try
            query = "SELECT count(StudentID) as total FROM student"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                totalvoters = sqlreader("total")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub
End Class