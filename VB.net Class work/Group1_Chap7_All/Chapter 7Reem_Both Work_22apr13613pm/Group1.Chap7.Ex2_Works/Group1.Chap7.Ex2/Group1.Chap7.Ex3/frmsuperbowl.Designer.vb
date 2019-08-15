<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuperbowl
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
        Me.btnallwinners = New System.Windows.Forms.Button()
        Me.btnwinnersB = New System.Windows.Forms.Button()
        Me.btnnumofwins = New System.Windows.Forms.Button()
        Me.lstwinners = New System.Windows.Forms.ListBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnallwinners
        '
        Me.btnallwinners.Location = New System.Drawing.Point(40, 49)
        Me.btnallwinners.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnallwinners.Name = "btnallwinners"
        Me.btnallwinners.Size = New System.Drawing.Size(147, 90)
        Me.btnallwinners.TabIndex = 0
        Me.btnallwinners.Text = "Show All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Winners"
        Me.btnallwinners.UseVisualStyleBackColor = True
        '
        'btnwinnersB
        '
        Me.btnwinnersB.Location = New System.Drawing.Point(241, 49)
        Me.btnwinnersB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnwinnersB.Name = "btnwinnersB"
        Me.btnwinnersB.Size = New System.Drawing.Size(147, 90)
        Me.btnwinnersB.TabIndex = 1
        Me.btnwinnersB.Text = "Show Winners" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beginning With B"
        Me.btnwinnersB.UseVisualStyleBackColor = True
        '
        'btnnumofwins
        '
        Me.btnnumofwins.Location = New System.Drawing.Point(440, 49)
        Me.btnnumofwins.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnumofwins.Name = "btnnumofwins"
        Me.btnnumofwins.Size = New System.Drawing.Size(137, 90)
        Me.btnnumofwins.TabIndex = 2
        Me.btnnumofwins.Text = "Show Winners by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Numbers of Wins"
        Me.btnnumofwins.UseVisualStyleBackColor = True
        '
        'lstwinners
        '
        Me.lstwinners.FormattingEnabled = True
        Me.lstwinners.ItemHeight = 16
        Me.lstwinners.Location = New System.Drawing.Point(181, 194)
        Me.lstwinners.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstwinners.Name = "lstwinners"
        Me.lstwinners.Size = New System.Drawing.Size(251, 260)
        Me.lstwinners.TabIndex = 3
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(474, 472)
        Me.Btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(137, 28)
        Me.Btnclear.TabIndex = 4
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'frmsuperbowl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 513)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.lstwinners)
        Me.Controls.Add(Me.btnnumofwins)
        Me.Controls.Add(Me.btnwinnersB)
        Me.Controls.Add(Me.btnallwinners)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmsuperbowl"
        Me.Text = "Super Bowl"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnallwinners As System.Windows.Forms.Button
    Friend WithEvents btnwinnersB As System.Windows.Forms.Button
    Friend WithEvents btnnumofwins As System.Windows.Forms.Button
    Friend WithEvents lstwinners As System.Windows.Forms.ListBox
    Friend WithEvents Btnclear As System.Windows.Forms.Button

End Class
