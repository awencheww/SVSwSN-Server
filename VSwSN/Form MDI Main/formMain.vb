Imports System.Drawing.Color

Public Class formMain
    Private Const AW_BLEND = &H80000  'Uses a fade effect. This flag can be used only if hwnd is a top-level window.
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Dim winHide As Integer = &H10000
    Dim winBlend As Integer = &H80000

    Private Sub formMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        lblDate.Text = Format(Date.Now, "MMMM dd, yyyy")
        formLogin.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Date.Now, "Long Time")
    End Sub

#Region "ToolStrip"
    Private Sub SSGExecutiveBranchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SSGExecutiveBranchToolStripMenuItem.Click
        formSSGEVotes.WindowState = FormWindowState.Maximized
        formSSGEVotes.MdiParent = Me
        formSSGEVotes.Show()
    End Sub

    Private Sub SSGLegislativeBranchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SSGLegislativeBranchToolStripMenuItem.Click
        formSSGLVotes.WindowState = FormWindowState.Maximized
        formSSGLVotes.MdiParent = Me
        formSSGLVotes.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentToolStripMenuItem1.Click
        formDepartmentVotes.WindowState = FormWindowState.Maximized
        formDepartmentVotes.MdiParent = Me
        formDepartmentVotes.Show()
    End Sub

    Private Sub accounts_Click(sender As System.Object, e As System.EventArgs) Handles accounts.Click
        formAccounts.WindowState = FormWindowState.Maximized
        formAccounts.MdiParent = Me
        formAccounts.Show()
    End Sub

    Private Sub expand_Click(sender As System.Object, e As System.EventArgs) Handles expand.Click
        If expand.CheckState = CheckState.Unchecked Then
            accounts.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            student.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            candidate.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            sms.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            voters.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            votes.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            lists.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            reports.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            about.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        Else
            accounts.DisplayStyle = ToolStripItemDisplayStyle.Image
            student.DisplayStyle = ToolStripItemDisplayStyle.Image
            candidate.DisplayStyle = ToolStripItemDisplayStyle.Image
            sms.DisplayStyle = ToolStripItemDisplayStyle.Image
            voters.DisplayStyle = ToolStripItemDisplayStyle.Image
            votes.DisplayStyle = ToolStripItemDisplayStyle.Image
            lists.DisplayStyle = ToolStripItemDisplayStyle.Image
            reports.DisplayStyle = ToolStripItemDisplayStyle.Image
            about.DisplayStyle = ToolStripItemDisplayStyle.Image
        End If
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        formCourse.WindowState = FormWindowState.Maximized
        formCourse.MdiParent = Me
        formCourse.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        formDepartment.WindowState = FormWindowState.Maximized
        formDepartment.MdiParent = Me
        formDepartment.Show()
    End Sub

    Private Sub PartyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PartyToolStripMenuItem.Click
        formParty.WindowState = FormWindowState.Maximized
        formParty.MdiParent = Me
        formParty.Show()
    End Sub

    Private Sub PositionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PositionToolStripMenuItem.Click
        formPosition.WindowState = FormWindowState.Maximized
        formPosition.MdiParent = Me
        formPosition.Show()
    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentInformationToolStripMenuItem.Click
        formStudent.WindowState = FormWindowState.Maximized
        formStudent.MdiParent = Me
        formStudent.Show()
    End Sub

    Private Sub CandidateInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CandidateInfoToolStripMenuItem.Click
        formCandidate.WindowState = FormWindowState.Maximized
        formCandidate.MdiParent = Me
        formCandidate.Show()
    End Sub

    Private Sub voters_Click(sender As System.Object, e As System.EventArgs) Handles voters.Click
        formVoters.WindowState = FormWindowState.Maximized
        formVoters.MdiParent = Me
        formVoters.Show()
    End Sub

    Private Sub sms_Click(sender As System.Object, e As System.EventArgs) Handles sms.Click
        formSMS.WindowState = FormWindowState.Maximized
        formSMS.MdiParent = Me
        formSMS.Show()
    End Sub
#End Region

#Region "MenuStrip"
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit VSwSN") = MsgBoxResult.Yes Then
            AnimateWindow(Me.Handle.ToInt32, CInt(500), winHide Or winBlend)
            Application.Exit()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Aree you sure you want to Logout?", MsgBoxStyle.OkCancel, "Logout Account") = MsgBoxResult.Ok Then
            Me.Close()
            formLogin.ShowDialog()
        End If
    End Sub

    Private Sub ToolbarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToolbarToolStripMenuItem.Click
        Me.ToolStrip1.Visible = ToolbarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusbarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatusbarToolStripMenuItem.Click
        StatusStrip1.Visible = StatusbarToolStripMenuItem.Checked
    End Sub

    Private Sub DockLeftToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ToolStrip1.Dock = DockStyle.Left
    End Sub

    Private Sub DockRightToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ToolStrip1.Dock = DockStyle.Right
    End Sub

    Private Sub DockTopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ToolStrip1.Dock = DockStyle.Top
    End Sub

    Private Sub DockBottomToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ToolStrip1.Dock = DockStyle.Bottom
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        'Close all Child forms of the parent
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
#End Region

#Region "ToolBar DockStyle"
    Private Sub DockLeftToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DockLeftToolStripMenuItem.Click
        ToolStrip1.Dock = DockStyle.Left
    End Sub

    Private Sub DockRightToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DockRightToolStripMenuItem.Click
        ToolStrip1.Dock = DockStyle.Right
    End Sub

    Private Sub DockTopToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DockTopToolStripMenuItem.Click
        ToolStrip1.Dock = DockStyle.Top
    End Sub

    Private Sub DockBottomToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DockBottomToolStripMenuItem.Click
        ToolStrip1.Dock = DockStyle.Bottom
    End Sub

    Private Sub about_Click(sender As System.Object, e As System.EventArgs) Handles about.Click
        AboutBox.ShowDialog()
    End Sub
#End Region

#Region "Theme"
    Private Sub DefaultToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.Silver
        ToolStrip1.BackColor = Color.FromArgb(64, 64, 64)
        StatusStrip1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DarkGray
        ToolStrip1.BackColor = Color.Black
        StatusStrip1.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub CrimsonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrimsonToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightPink
        ToolStrip1.BackColor = Color.Crimson
        StatusStrip1.BackColor = Color.MediumVioletRed
    End Sub

    Private Sub DarkSlateGrayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DarkSlateGrayToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightSlateGray
        ToolStrip1.BackColor = Color.DarkSlateGray
        StatusStrip1.BackColor = Color.Teal
    End Sub

    Private Sub DarkGreenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DarkGreenToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightGreen
        ToolStrip1.BackColor = Color.DarkGreen
        StatusStrip1.BackColor = Color.ForestGreen
    End Sub

    Private Sub MaroonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaroonToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.IndianRed
        ToolStrip1.BackColor = Color.Maroon
        StatusStrip1.BackColor = Color.Firebrick
    End Sub

    Private Sub IndigoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndigoToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.MediumPurple
        ToolStrip1.BackColor = Color.Indigo
        StatusStrip1.BackColor = Color.DarkViolet
    End Sub

    Private Sub MidnightBlueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MidnightBlueToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightBlue
        ToolStrip1.BackColor = Color.MidnightBlue
        StatusStrip1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub NavyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NavyToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightBlue
        ToolStrip1.BackColor = Color.Navy
        StatusStrip1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub SaddleBrownToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaddleBrownToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.Peru
        ToolStrip1.BackColor = Color.SaddleBrown
        StatusStrip1.BackColor = Color.Chocolate
    End Sub
#End Region
    
End Class