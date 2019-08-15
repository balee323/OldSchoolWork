<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHello
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
        Me.BtnRepeats = New System.Windows.Forms.Button()
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtWord = New System.Windows.Forms.TextBox()
        Me.TxtRepeats = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRepeats
        '
        Me.BtnRepeats.Location = New System.Drawing.Point(26, 150)
        Me.BtnRepeats.Name = "BtnRepeats"
        Me.BtnRepeats.Size = New System.Drawing.Size(244, 33)
        Me.BtnRepeats.TabIndex = 2
        Me.BtnRepeats.Text = "Display Repeats"
        Me.BtnRepeats.UseVisualStyleBackColor = True
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(26, 204)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.Size = New System.Drawing.Size(228, 22)
        Me.TxtDisplay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Display Word Repeats"
        '
        'TxtWord
        '
        Me.TxtWord.Location = New System.Drawing.Point(12, 12)
        Me.TxtWord.Name = "TxtWord"
        Me.TxtWord.Size = New System.Drawing.Size(104, 22)
        Me.TxtWord.TabIndex = 0
        '
        'TxtRepeats
        '
        Me.TxtRepeats.Location = New System.Drawing.Point(15, 70)
        Me.TxtRepeats.Name = "TxtRepeats"
        Me.TxtRepeats.Size = New System.Drawing.Size(104, 22)
        Me.TxtRepeats.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Word to repeat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter how Many Repeats"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(195, 51)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(195, 107)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtRepeats)
        Me.Controls.Add(Me.TxtWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.BtnRepeats)
        Me.Name = "FrmHello"
        Me.Text = "HelloLoop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRepeats As System.Windows.Forms.Button
    Friend WithEvents TxtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtWord As System.Windows.Forms.TextBox
    Friend WithEvents TxtRepeats As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
