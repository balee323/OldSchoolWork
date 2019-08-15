<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPay
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
        Me.BtnBestPay = New System.Windows.Forms.Button()
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.LblBestOption = New System.Windows.Forms.Label()
        Me.Lbl100Day = New System.Windows.Forms.Label()
        Me.LblDouble = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblOr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBestPay
        '
        Me.BtnBestPay.Location = New System.Drawing.Point(26, 150)
        Me.BtnBestPay.Name = "BtnBestPay"
        Me.BtnBestPay.Size = New System.Drawing.Size(466, 33)
        Me.BtnBestPay.TabIndex = 2
        Me.BtnBestPay.Text = "Display Best Option"
        Me.BtnBestPay.UseVisualStyleBackColor = True
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(26, 234)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.Size = New System.Drawing.Size(466, 22)
        Me.TxtDisplay.TabIndex = 1
        '
        'LblBestOption
        '
        Me.LblBestOption.AutoSize = True
        Me.LblBestOption.Location = New System.Drawing.Point(23, 214)
        Me.LblBestOption.Name = "LblBestOption"
        Me.LblBestOption.Size = New System.Drawing.Size(134, 17)
        Me.LblBestOption.TabIndex = 2
        Me.LblBestOption.Text = "Your best option is: "
        '
        'Lbl100Day
        '
        Me.Lbl100Day.AutoSize = True
        Me.Lbl100Day.Location = New System.Drawing.Point(9, 37)
        Me.Lbl100Day.Name = "Lbl100Day"
        Me.Lbl100Day.Size = New System.Drawing.Size(247, 17)
        Me.Lbl100Day.TabIndex = 5
        Me.Lbl100Day.Text = "Option 1: $100 each day for 10 days?"
        '
        'LblDouble
        '
        Me.LblDouble.AutoSize = True
        Me.LblDouble.Location = New System.Drawing.Point(9, 114)
        Me.LblDouble.Name = "LblDouble"
        Me.LblDouble.Size = New System.Drawing.Size(374, 17)
        Me.LblDouble.TabIndex = 6
        Me.LblDouble.Text = "Option 2: $1 Starting then doubling each day for 10 days?"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(417, 69)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblOr
        '
        Me.LblOr.AutoSize = True
        Me.LblOr.Location = New System.Drawing.Point(59, 75)
        Me.LblOr.Name = "LblOr"
        Me.LblOr.Size = New System.Drawing.Size(24, 17)
        Me.LblOr.TabIndex = 7
        Me.LblOr.Text = "Or"
        '
        'FrmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 311)
        Me.Controls.Add(Me.LblOr)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblDouble)
        Me.Controls.Add(Me.Lbl100Day)
        Me.Controls.Add(Me.LblBestOption)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.BtnBestPay)
        Me.Name = "FrmPay"
        Me.Text = "Which pay option is Best for 10 days?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBestPay As System.Windows.Forms.Button
    Friend WithEvents TxtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents LblBestOption As System.Windows.Forms.Label
    Friend WithEvents Lbl100Day As System.Windows.Forms.Label
    Friend WithEvents LblDouble As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblOr As System.Windows.Forms.Label

End Class
