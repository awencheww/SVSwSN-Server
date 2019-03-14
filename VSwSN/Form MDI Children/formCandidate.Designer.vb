<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCandidate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCandidate))
        Me.ListViewCandidate = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripCandidate = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonADD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUPDATE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFilterVotingLevel = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbFilterDept = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbFilterLevel = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripCandidate.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewCandidate
        '
        Me.ListViewCandidate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewCandidate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListViewCandidate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewCandidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewCandidate.FullRowSelect = True
        Me.ListViewCandidate.GridLines = True
        Me.ListViewCandidate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewCandidate.Location = New System.Drawing.Point(0, 28)
        Me.ListViewCandidate.Name = "ListViewCandidate"
        Me.ListViewCandidate.Size = New System.Drawing.Size(1138, 351)
        Me.ListViewCandidate.TabIndex = 12
        Me.ListViewCandidate.UseCompatibleStateImageBehavior = False
        Me.ListViewCandidate.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Candidate ID"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Candidate Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Age"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Birthdate"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SEX"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Address"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Department"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Course"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Party Name"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Position"
        Me.ColumnHeader12.Width = 150
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Level name"
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Votes"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Photo"
        Me.ColumnHeader7.Width = 0
        '
        'ToolStripCandidate
        '
        Me.ToolStripCandidate.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripCandidate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripCandidate.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripCandidate.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripCandidate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonADD, Me.ToolStripButtonUPDATE, Me.ToolStripLabel1, Me.txtBoxSearch, Me.ToolStripLabel3, Me.ToolStripLabel2, Me.cmbFilterVotingLevel, Me.cmbFilterDept, Me.cmbFilterLevel})
        Me.ToolStripCandidate.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripCandidate.Name = "ToolStripCandidate"
        Me.ToolStripCandidate.Size = New System.Drawing.Size(1138, 28)
        Me.ToolStripCandidate.TabIndex = 11
        Me.ToolStripCandidate.Text = "ToolStrip1"
        Me.ToolStripCandidate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripButtonADD
        '
        Me.ToolStripButtonADD.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButtonADD.Image = CType(resources.GetObject("ToolStripButtonADD.Image"), System.Drawing.Image)
        Me.ToolStripButtonADD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonADD.Name = "ToolStripButtonADD"
        Me.ToolStripButtonADD.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripButtonADD.Size = New System.Drawing.Size(68, 25)
        Me.ToolStripButtonADD.Text = "New"
        Me.ToolStripButtonADD.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButtonUPDATE
        '
        Me.ToolStripButtonUPDATE.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButtonUPDATE.Image = CType(resources.GetObject("ToolStripButtonUPDATE.Image"), System.Drawing.Image)
        Me.ToolStripButtonUPDATE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUPDATE.Name = "ToolStripButtonUPDATE"
        Me.ToolStripButtonUPDATE.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripButtonUPDATE.Size = New System.Drawing.Size(86, 25)
        Me.ToolStripButtonUPDATE.Text = "Update"
        Me.ToolStripButtonUPDATE.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(81, 25)
        Me.ToolStripLabel1.Text = "Search by:"
        Me.ToolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.AutoSize = False
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.txtBoxSearch.Size = New System.Drawing.Size(150, 25)
        Me.txtBoxSearch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(116, 21)
        Me.ToolStripLabel3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(81, 25)
        Me.ToolStripLabel2.Text = "Filter By   :"
        Me.ToolStripLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'cmbFilterVotingLevel
        '
        Me.cmbFilterVotingLevel.Name = "cmbFilterVotingLevel"
        Me.cmbFilterVotingLevel.Size = New System.Drawing.Size(121, 28)
        Me.cmbFilterVotingLevel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'cmbFilterDept
        '
        Me.cmbFilterDept.Name = "cmbFilterDept"
        Me.cmbFilterDept.Size = New System.Drawing.Size(121, 28)
        Me.cmbFilterDept.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'cmbFilterLevel
        '
        Me.cmbFilterLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbFilterLevel.Name = "cmbFilterLevel"
        Me.cmbFilterLevel.Size = New System.Drawing.Size(121, 28)
        Me.cmbFilterLevel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'formCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 379)
        Me.Controls.Add(Me.ListViewCandidate)
        Me.Controls.Add(Me.ToolStripCandidate)
        Me.Name = "formCandidate"
        Me.Text = "Candidate"
        Me.ToolStripCandidate.ResumeLayout(False)
        Me.ToolStripCandidate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewCandidate As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripCandidate As System.Windows.Forms.ToolStrip
    Friend WithEvents txtBoxSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilterDept As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbFilterLevel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilterVotingLevel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButtonADD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
