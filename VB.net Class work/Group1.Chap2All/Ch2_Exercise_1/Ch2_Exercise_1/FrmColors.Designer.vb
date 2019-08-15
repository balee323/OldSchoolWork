<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColors
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
        Me.BtnRed = New System.Windows.Forms.Button()
        Me.BtnWhite = New System.Windows.Forms.Button()
        Me.BtnBlue = New System.Windows.Forms.Button()
        Me.BtnYellow = New System.Windows.Forms.Button()
        Me.TxtBox = New System.Windows.Forms.TextBox()
        Me.LblBack = New System.Windows.Forms.Label()
        Me.LblFore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRed
        '
        Me.BtnRed.Location = New System.Drawing.Point(210, 79)
        Me.BtnRed.Name = "BtnRed"
        Me.BtnRed.Size = New System.Drawing.Size(75, 23)
        Me.BtnRed.TabIndex = 0
        Me.BtnRed.Text = "Red"
        Me.BtnRed.UseVisualStyleBackColor = True
        '
        'BtnWhite
        '
        Me.BtnWhite.Location = New System.Drawing.Point(210, 190)
        Me.BtnWhite.Name = "BtnWhite"
        Me.BtnWhite.Size = New System.Drawing.Size(75, 23)
        Me.BtnWhite.TabIndex = 1
        Me.BtnWhite.Text = "White"
        Me.BtnWhite.UseVisualStyleBackColor = True
        '
        'BtnBlue
        '
        Me.BtnBlue.Location = New System.Drawing.Point(479, 79)
        Me.BtnBlue.Name = "BtnBlue"
        Me.BtnBlue.Size = New System.Drawing.Size(75, 23)
        Me.BtnBlue.TabIndex = 2
        Me.BtnBlue.Text = "Blue"
        Me.BtnBlue.UseVisualStyleBackColor = True
        '
        'BtnYellow
        '
        Me.BtnYellow.Location = New System.Drawing.Point(479, 190)
        Me.BtnYellow.Name = "BtnYellow"
        Me.BtnYellow.Size = New System.Drawing.Size(75, 23)
        Me.BtnYellow.TabIndex = 3
        Me.BtnYellow.Text = "Yellow"
        Me.BtnYellow.UseVisualStyleBackColor = True
        '
        'TxtBox
        '
        Me.TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox.Location = New System.Drawing.Point(210, 137)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(344, 27)
        Me.TxtBox.TabIndex = 4
        Me.TxtBox.Text = "Beautiful Day"
        Me.TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBack
        '
        Me.LblBack.AutoSize = True
        Me.LblBack.Location = New System.Drawing.Point(69, 79)
        Me.LblBack.Name = "LblBack"
        Me.LblBack.Size = New System.Drawing.Size(84, 17)
        Me.LblBack.TabIndex = 5
        Me.LblBack.Text = "Background"
        '
        'LblFore
        '
        Me.LblFore.AutoSize = True
        Me.LblFore.Location = New System.Drawing.Point(69, 196)
        Me.LblFore.Name = "LblFore"
        Me.LblFore.Size = New System.Drawing.Size(82, 17)
        Me.LblFore.TabIndex = 6
        Me.LblFore.Text = "Foreground"
        '
        'FrmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 316)
        Me.Controls.Add(Me.LblFore)
        Me.Controls.Add(Me.LblBack)
        Me.Controls.Add(Me.TxtBox)
        Me.Controls.Add(Me.BtnYellow)
        Me.Controls.Add(Me.BtnBlue)
        Me.Controls.Add(Me.BtnWhite)
        Me.Controls.Add(Me.BtnRed)
        Me.Name = "FrmColors"
        Me.Text = "Colorful Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRed As System.Windows.Forms.Button
    Friend WithEvents BtnWhite As System.Windows.Forms.Button
    Friend WithEvents BtnBlue As System.Windows.Forms.Button
    Friend WithEvents BtnYellow As System.Windows.Forms.Button
    Friend WithEvents TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents LblBack As System.Windows.Forms.Label
    Friend WithEvents LblFore As System.Windows.Forms.Label

End Class
