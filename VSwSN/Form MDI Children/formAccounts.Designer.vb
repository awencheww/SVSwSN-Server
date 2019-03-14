<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAccounts))
        Me.ToolStripAccounts = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonADD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUPDATE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ListViewAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripAccounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripAccounts
        '
        Me.ToolStripAccounts.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripAccounts.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripAccounts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripAccounts.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripAccounts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonADD, Me.ToolStripButtonUPDATE, Me.ToolStripButtonDELETE, Me.ToolStripTextBox1})
        Me.ToolStripAccounts.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripAccounts.Name = "ToolStripAccounts"
        Me.ToolStripAccounts.Size = New System.Drawing.Size(807, 28)
        Me.ToolStripAccounts.TabIndex = 5
        Me.ToolStripAccounts.Text = "ToolStrip1"
        Me.ToolStripAccounts.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
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
        'ToolStripButtonDELETE
        '
        Me.ToolStripButtonDELETE.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButtonDELETE.Image = CType(resources.GetObject("ToolStripButtonDELETE.Image"), System.Drawing.Image)
        Me.ToolStripButtonDELETE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDELETE.Name = "ToolStripButtonDELETE"
        Me.ToolStripButtonDELETE.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripButtonDELETE.Size = New System.Drawing.Size(80, 25)
        Me.ToolStripButtonDELETE.Text = "Delete"
        Me.ToolStripButtonDELETE.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(150, 25)
        Me.ToolStripTextBox1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ListViewAccounts
        '
        Me.ListViewAccounts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader6})
        Me.ListViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAccounts.FullRowSelect = True
        Me.ListViewAccounts.GridLines = True
        Me.ListViewAccounts.Location = New System.Drawing.Point(0, 28)
        Me.ListViewAccounts.Name = "ListViewAccounts"
        Me.ListViewAccounts.Size = New System.Drawing.Size(807, 258)
        Me.ListViewAccounts.TabIndex = 6
        Me.ListViewAccounts.UseCompatibleStateImageBehavior = False
        Me.ListViewAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User ID"
        Me.ColumnHeader2.Width = 66
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Username"
        Me.ColumnHeader3.Width = 165
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Password"
        Me.ColumnHeader4.Width = 175
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User type"
        Me.ColumnHeader5.Width = 135
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Student Name"
        Me.ColumnHeader6.Width = 178
        '
        'formAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 286)
        Me.Controls.Add(Me.ListViewAccounts)
        Me.Controls.Add(Me.ToolStripAccounts)
        Me.Name = "formAccounts"
        Me.Text = "Account Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStripAccounts.ResumeLayout(False)
        Me.ToolStripAccounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripAccounts As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonADD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ListViewAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButtonDELETE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
