<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrade
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
        Me.BtnGrade = New System.Windows.Forms.Button()
        Me.TxtMid = New System.Windows.Forms.TextBox()
        Me.TxtFin = New System.Windows.Forms.TextBox()
        Me.TxtGrade = New System.Windows.Forms.TextBox()
        Me.LblMid = New System.Windows.Forms.Label()
        Me.LblFinal = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnGrade
        '
        Me.BtnGrade.Location = New System.Drawing.Point(88, 95)
        Me.BtnGrade.Name = "BtnGrade"
        Me.BtnGrade.Size = New System.Drawing.Size(100, 70)
        Me.BtnGrade.TabIndex = 2
        Me.BtnGrade.Text = "Get Letter Grade"
        Me.BtnGrade.UseVisualStyleBackColor = True
        '
        'TxtMid
        '
        Me.TxtMid.Location = New System.Drawing.Point(12, 27)
        Me.TxtMid.Name = "TxtMid"
        Me.TxtMid.Size = New System.Drawing.Size(100, 22)
        Me.TxtMid.TabIndex = 0
        '
        'TxtFin
        '
        Me.TxtFin.Location = New System.Drawing.Point(164, 27)
        Me.TxtFin.Name = "TxtFin"
        Me.TxtFin.Size = New System.Drawing.Size(106, 22)
        Me.TxtFin.TabIndex = 1
        '
        'TxtGrade
        '
        Me.TxtGrade.Location = New System.Drawing.Point(33, 203)
        Me.TxtGrade.Name = "TxtGrade"
        Me.TxtGrade.ReadOnly = True
        Me.TxtGrade.Size = New System.Drawing.Size(208, 22)
        Me.TxtGrade.TabIndex = 3
        Me.TxtGrade.TabStop = False
        '
        'LblMid
        '
        Me.LblMid.AutoSize = True
        Me.LblMid.Location = New System.Drawing.Point(9, 56)
        Me.LblMid.Name = "LblMid"
        Me.LblMid.Size = New System.Drawing.Size(99, 17)
        Me.LblMid.TabIndex = 4
        Me.LblMid.Text = "Midterm Score"
        '
        'LblFinal
        '
        Me.LblFinal.AutoSize = True
        Me.LblFinal.Location = New System.Drawing.Point(161, 56)
        Me.LblFinal.Name = "LblFinal"
        Me.LblFinal.Size = New System.Drawing.Size(113, 17)
        Me.LblFinal.TabIndex = 5
        Me.LblFinal.Text = "FinalExam Score"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(234, 133)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(36, 32)
        Me.BtnClear.TabIndex = 6
        Me.BtnClear.Text = " C"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FrmGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblFinal)
        Me.Controls.Add(Me.LblMid)
        Me.Controls.Add(Me.TxtGrade)
        Me.Controls.Add(Me.TxtFin)
        Me.Controls.Add(Me.TxtMid)
        Me.Controls.Add(Me.BtnGrade)
        Me.Name = "FrmGrade"
        Me.Text = "Get Your Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGrade As System.Windows.Forms.Button
    Friend WithEvents TxtMid As System.Windows.Forms.TextBox
    Friend WithEvents TxtFin As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrade As System.Windows.Forms.TextBox
    Friend WithEvents LblMid As System.Windows.Forms.Label
    Friend WithEvents LblFinal As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button

End Class
