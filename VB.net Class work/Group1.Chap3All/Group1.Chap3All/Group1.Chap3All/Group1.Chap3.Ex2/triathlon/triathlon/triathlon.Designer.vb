<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class triathlon
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
        Me.BtnCompute = New System.Windows.Forms.Button()
        Me.TxtCycling = New System.Windows.Forms.TextBox()
        Me.TxtSwimming = New System.Windows.Forms.TextBox()
        Me.TxtRunning = New System.Windows.Forms.TextBox()
        Me.TxtLost = New System.Windows.Forms.TextBox()
        Me.LblCycling = New System.Windows.Forms.Label()
        Me.LblSwimming = New System.Windows.Forms.Label()
        Me.LblRunning = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCompute
        '
        Me.BtnCompute.Location = New System.Drawing.Point(48, 230)
        Me.BtnCompute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCompute.Name = "BtnCompute"
        Me.BtnCompute.Size = New System.Drawing.Size(318, 28)
        Me.BtnCompute.TabIndex = 0
        Me.BtnCompute.Text = "Compute Weight Loss"
        Me.BtnCompute.UseVisualStyleBackColor = True
        '
        'TxtCycling
        '
        Me.TxtCycling.Location = New System.Drawing.Point(234, 28)
        Me.TxtCycling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCycling.Name = "TxtCycling"
        Me.TxtCycling.Size = New System.Drawing.Size(132, 22)
        Me.TxtCycling.TabIndex = 1
        '
        'TxtSwimming
        '
        Me.TxtSwimming.Location = New System.Drawing.Point(234, 162)
        Me.TxtSwimming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSwimming.Name = "TxtSwimming"
        Me.TxtSwimming.Size = New System.Drawing.Size(132, 22)
        Me.TxtSwimming.TabIndex = 2
        '
        'TxtRunning
        '
        Me.TxtRunning.Location = New System.Drawing.Point(234, 93)
        Me.TxtRunning.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtRunning.Name = "TxtRunning"
        Me.TxtRunning.Size = New System.Drawing.Size(132, 22)
        Me.TxtRunning.TabIndex = 3
        '
        'TxtLost
        '
        Me.TxtLost.Location = New System.Drawing.Point(48, 311)
        Me.TxtLost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLost.Name = "TxtLost"
        Me.TxtLost.ReadOnly = True
        Me.TxtLost.Size = New System.Drawing.Size(293, 22)
        Me.TxtLost.TabIndex = 4
        '
        'LblCycling
        '
        Me.LblCycling.AutoSize = True
        Me.LblCycling.Location = New System.Drawing.Point(44, 33)
        Me.LblCycling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCycling.Name = "LblCycling"
        Me.LblCycling.Size = New System.Drawing.Size(165, 17)
        Me.LblCycling.TabIndex = 5
        Me.LblCycling.Text = "Number of hours cycling:"
        '
        'LblSwimming
        '
        Me.LblSwimming.AutoSize = True
        Me.LblSwimming.Location = New System.Drawing.Point(44, 167)
        Me.LblSwimming.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSwimming.Name = "LblSwimming"
        Me.LblSwimming.Size = New System.Drawing.Size(182, 17)
        Me.LblSwimming.TabIndex = 6
        Me.LblSwimming.Text = "Number of hours swimming:"
        '
        'LblRunning
        '
        Me.LblRunning.AutoSize = True
        Me.LblRunning.Location = New System.Drawing.Point(44, 98)
        Me.LblRunning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRunning.Name = "LblRunning"
        Me.LblRunning.Size = New System.Drawing.Size(170, 17)
        Me.LblRunning.TabIndex = 7
        Me.LblRunning.Text = "Number of hours running:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "All entrys fields must be filled. Enter 0 for no activity."
        '
        'triathlon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 404)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblRunning)
        Me.Controls.Add(Me.LblSwimming)
        Me.Controls.Add(Me.LblCycling)
        Me.Controls.Add(Me.TxtLost)
        Me.Controls.Add(Me.TxtRunning)
        Me.Controls.Add(Me.TxtSwimming)
        Me.Controls.Add(Me.TxtCycling)
        Me.Controls.Add(Me.BtnCompute)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "triathlon"
        Me.Text = "triathlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCompute As System.Windows.Forms.Button
    Friend WithEvents TxtCycling As System.Windows.Forms.TextBox
    Friend WithEvents TxtSwimming As System.Windows.Forms.TextBox
    Friend WithEvents TxtRunning As System.Windows.Forms.TextBox
    Friend WithEvents TxtLost As System.Windows.Forms.TextBox
    Friend WithEvents LblCycling As System.Windows.Forms.Label
    Friend WithEvents LblSwimming As System.Windows.Forms.Label
    Friend WithEvents LblRunning As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
