<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDinger
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
        Me.LabelPlaying = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPlaying
        '
        Me.LabelPlaying.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPlaying.Location = New System.Drawing.Point(0, 0)
        Me.LabelPlaying.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelPlaying.Name = "LabelPlaying"
        Me.LabelPlaying.Size = New System.Drawing.Size(282, 56)
        Me.LabelPlaying.TabIndex = 0
        Me.LabelPlaying.Text = "Hi! You're not supposed to be here! ☺"
        Me.LabelPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 56)
        Me.Controls.Add(Me.LabelPlaying)
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDinger"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dinger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelPlaying As Label
End Class
