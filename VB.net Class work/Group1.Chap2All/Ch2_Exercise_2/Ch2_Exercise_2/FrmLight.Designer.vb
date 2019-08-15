<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLight
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtRed = New System.Windows.Forms.TextBox()
        Me.TxtYellow = New System.Windows.Forms.TextBox()
        Me.TxtGreen = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'TxtRed
        '
        Me.TxtRed.BackColor = System.Drawing.Color.Gray
        Me.TxtRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRed.ForeColor = System.Drawing.Color.Gray
        Me.TxtRed.Location = New System.Drawing.Point(206, 68)
        Me.TxtRed.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRed.Multiline = True
        Me.TxtRed.Name = "TxtRed"
        Me.TxtRed.Size = New System.Drawing.Size(72, 58)
        Me.TxtRed.TabIndex = 1
        '
        'TxtYellow
        '
        Me.TxtYellow.BackColor = System.Drawing.Color.Gray
        Me.TxtYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtYellow.Location = New System.Drawing.Point(206, 165)
        Me.TxtYellow.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtYellow.Multiline = True
        Me.TxtYellow.Name = "TxtYellow"
        Me.TxtYellow.Size = New System.Drawing.Size(72, 58)
        Me.TxtYellow.TabIndex = 2
        '
        'TxtGreen
        '
        Me.TxtGreen.BackColor = System.Drawing.Color.Green
        Me.TxtGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGreen.Location = New System.Drawing.Point(206, 271)
        Me.TxtGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtGreen.Multiline = True
        Me.TxtGreen.Name = "TxtGreen"
        Me.TxtGreen.Size = New System.Drawing.Size(72, 58)
        Me.TxtGreen.TabIndex = 0
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(137, 356)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(207, 20)
        Me.TxtStatus.TabIndex = 0
        Me.TxtStatus.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FrmLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 398)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.TxtGreen)
        Me.Controls.Add(Me.TxtYellow)
        Me.Controls.Add(Me.TxtRed)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLight"
        Me.Text = "Traffic Light"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtRed As System.Windows.Forms.TextBox
    Friend WithEvents TxtYellow As System.Windows.Forms.TextBox
    Friend WithEvents TxtGreen As System.Windows.Forms.TextBox
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
