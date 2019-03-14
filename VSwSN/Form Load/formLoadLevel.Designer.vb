<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLoadLevel
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
        Me.ListViewLoadLevel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewLoadLevel
        '
        Me.ListViewLoadLevel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewLoadLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewLoadLevel.FullRowSelect = True
        Me.ListViewLoadLevel.GridLines = True
        Me.ListViewLoadLevel.Location = New System.Drawing.Point(0, 0)
        Me.ListViewLoadLevel.Name = "ListViewLoadLevel"
        Me.ListViewLoadLevel.Size = New System.Drawing.Size(270, 200)
        Me.ListViewLoadLevel.TabIndex = 1
        Me.ListViewLoadLevel.UseCompatibleStateImageBehavior = False
        Me.ListViewLoadLevel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Level ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Level"
        Me.ColumnHeader2.Width = 168
        '
        'formLoadLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 200)
        Me.Controls.Add(Me.ListViewLoadLevel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formLoadLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click item to select Level"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewLoadLevel As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
