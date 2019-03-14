<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formParty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formParty))
        Me.ListViewParty = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripParty = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonADD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUPDATE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripParty.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewParty
        '
        Me.ListViewParty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewParty.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewParty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewParty.FullRowSelect = True
        Me.ListViewParty.GridLines = True
        Me.ListViewParty.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewParty.Location = New System.Drawing.Point(0, 28)
        Me.ListViewParty.Name = "ListViewParty"
        Me.ListViewParty.Size = New System.Drawing.Size(648, 344)
        Me.ListViewParty.TabIndex = 12
        Me.ListViewParty.UseCompatibleStateImageBehavior = False
        Me.ListViewParty.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Party ID"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Party Code"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Party Name"
        Me.ColumnHeader3.Width = 253
        '
        'ToolStripParty
        '
        Me.ToolStripParty.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripParty.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripParty.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripParty.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripParty.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonADD, Me.ToolStripButtonUPDATE, Me.ToolStripLabel1, Me.txtBoxSearch})
        Me.ToolStripParty.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripParty.Name = "ToolStripParty"
        Me.ToolStripParty.Size = New System.Drawing.Size(648, 28)
        Me.ToolStripParty.TabIndex = 11
        Me.ToolStripParty.Text = "ToolStrip1"
        Me.ToolStripParty.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(163, 25)
        Me.ToolStripLabel1.Text = "Search by Party name:"
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
        'formParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 372)
        Me.Controls.Add(Me.ListViewParty)
        Me.Controls.Add(Me.ToolStripParty)
        Me.Name = "formParty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party List"
        Me.ToolStripParty.ResumeLayout(False)
        Me.ToolStripParty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewParty As System.Windows.Forms.ListView
    Friend WithEvents ToolStripParty As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonADD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBoxSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
