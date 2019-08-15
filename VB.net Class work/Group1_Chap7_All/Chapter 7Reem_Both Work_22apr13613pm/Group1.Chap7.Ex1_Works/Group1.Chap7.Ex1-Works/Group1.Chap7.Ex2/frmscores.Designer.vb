<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmscores
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
        Me.btnscores = New System.Windows.Forms.Button()
        Me.lstscores = New System.Windows.Forms.ListBox()
        Me.lblscores = New System.Windows.Forms.Label()
        Me.btnabove = New System.Windows.Forms.Button()
        Me.txtaboveaverage = New System.Windows.Forms.TextBox()
        Me.btngrades = New System.Windows.Forms.Button()
        Me.lstgrades = New System.Windows.Forms.ListBox()
        Me.lblgrades = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnscores
        '
        Me.btnscores.Location = New System.Drawing.Point(37, 13)
        Me.btnscores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnscores.Name = "btnscores"
        Me.btnscores.Size = New System.Drawing.Size(176, 47)
        Me.btnscores.TabIndex = 0
        Me.btnscores.Text = " Show All Scores"
        Me.btnscores.UseVisualStyleBackColor = True
        '
        'lstscores
        '
        Me.lstscores.FormattingEnabled = True
        Me.lstscores.ItemHeight = 16
        Me.lstscores.Location = New System.Drawing.Point(37, 105)
        Me.lstscores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstscores.Name = "lstscores"
        Me.lstscores.Size = New System.Drawing.Size(175, 244)
        Me.lstscores.TabIndex = 1
        '
        'lblscores
        '
        Me.lblscores.AutoSize = True
        Me.lblscores.Location = New System.Drawing.Point(37, 81)
        Me.lblscores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblscores.Name = "lblscores"
        Me.lblscores.Size = New System.Drawing.Size(52, 17)
        Me.lblscores.TabIndex = 2
        Me.lblscores.Text = "Scores"
        '
        'btnabove
        '
        Me.btnabove.Location = New System.Drawing.Point(37, 372)
        Me.btnabove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnabove.Name = "btnabove"
        Me.btnabove.Size = New System.Drawing.Size(239, 28)
        Me.btnabove.TabIndex = 3
        Me.btnabove.Text = "Number of Scores Above Average"
        Me.btnabove.UseVisualStyleBackColor = True
        '
        'txtaboveaverage
        '
        Me.txtaboveaverage.Location = New System.Drawing.Point(301, 374)
        Me.txtaboveaverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtaboveaverage.Name = "txtaboveaverage"
        Me.txtaboveaverage.ReadOnly = True
        Me.txtaboveaverage.Size = New System.Drawing.Size(136, 22)
        Me.txtaboveaverage.TabIndex = 4
        '
        'btngrades
        '
        Me.btngrades.Location = New System.Drawing.Point(277, 13)
        Me.btngrades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btngrades.Name = "btngrades"
        Me.btngrades.Size = New System.Drawing.Size(183, 47)
        Me.btngrades.TabIndex = 5
        Me.btngrades.Text = "Number of:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " A's, B's, C's, D's, and F's"
        Me.btngrades.UseVisualStyleBackColor = True
        '
        'lstgrades
        '
        Me.lstgrades.FormattingEnabled = True
        Me.lstgrades.ItemHeight = 16
        Me.lstgrades.Location = New System.Drawing.Point(277, 105)
        Me.lstgrades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstgrades.Name = "lstgrades"
        Me.lstgrades.Size = New System.Drawing.Size(181, 244)
        Me.lstgrades.TabIndex = 6
        '
        'lblgrades
        '
        Me.lblgrades.AutoSize = True
        Me.lblgrades.Location = New System.Drawing.Point(277, 81)
        Me.lblgrades.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgrades.Name = "lblgrades"
        Me.lblgrades.Size = New System.Drawing.Size(96, 17)
        Me.lblgrades.TabIndex = 7
        Me.lblgrades.Text = "Letter Grades"
        '
        'frmscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 438)
        Me.Controls.Add(Me.lblgrades)
        Me.Controls.Add(Me.lstgrades)
        Me.Controls.Add(Me.btngrades)
        Me.Controls.Add(Me.txtaboveaverage)
        Me.Controls.Add(Me.btnabove)
        Me.Controls.Add(Me.lblscores)
        Me.Controls.Add(Me.lstscores)
        Me.Controls.Add(Me.btnscores)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmscores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnscores As System.Windows.Forms.Button
    Friend WithEvents lstscores As System.Windows.Forms.ListBox
    Friend WithEvents lblscores As System.Windows.Forms.Label
    Friend WithEvents btnabove As System.Windows.Forms.Button
    Friend WithEvents txtaboveaverage As System.Windows.Forms.TextBox
    Friend WithEvents btngrades As System.Windows.Forms.Button
    Friend WithEvents lstgrades As System.Windows.Forms.ListBox
    Friend WithEvents lblgrades As System.Windows.Forms.Label

End Class
