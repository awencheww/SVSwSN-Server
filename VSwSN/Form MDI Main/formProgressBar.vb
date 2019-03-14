Public Class formProgressBar

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        Label3.Text = "" & ProgressBar1.Value & "%"
        If ProgressBar1.Value <= 30 Then

            Label1.Text = "Initializing..."

        ElseIf ProgressBar1.Value <= 50 Then

            Label1.Text = "Loading components..."

        ElseIf ProgressBar1.Value <= 70 Then

            Label1.Text = "Integrating Database..."

        ElseIf ProgressBar1.Value <= 96 Then

            Label1.Text = "Updating Your System..."
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = " Loading Complete"
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            formMain.Show()
        End If
    End Sub

    Private Sub frmProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Height = 125
        Me.Width = 350
        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        'Me.BackColor = Color.Red
    End Sub
End Class