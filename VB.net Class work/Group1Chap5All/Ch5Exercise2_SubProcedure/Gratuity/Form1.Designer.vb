<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGratuity
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
        Me.BtnTip = New System.Windows.Forms.Button()
        Me.TxtJob = New System.Windows.Forms.TextBox()
        Me.TxtBill = New System.Windows.Forms.TextBox()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.TxtTip = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblOccu = New System.Windows.Forms.Label()
        Me.LblTip = New System.Windows.Forms.Label()
        Me.LblAmt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTip
        '
        Me.BtnTip.Location = New System.Drawing.Point(169, 200)
        Me.BtnTip.Name = "BtnTip"
        Me.BtnTip.Size = New System.Drawing.Size(142, 29)
        Me.BtnTip.TabIndex = 3
        Me.BtnTip.Text = "Compute Tip"
        Me.BtnTip.UseVisualStyleBackColor = True
        '
        'TxtJob
        '
        Me.TxtJob.Location = New System.Drawing.Point(259, 46)
        Me.TxtJob.Name = "TxtJob"
        Me.TxtJob.Size = New System.Drawing.Size(100, 22)
        Me.TxtJob.TabIndex = 0
        '
        'TxtBill
        '
        Me.TxtBill.Location = New System.Drawing.Point(259, 103)
        Me.TxtBill.Name = "TxtBill"
        Me.TxtBill.Size = New System.Drawing.Size(100, 22)
        Me.TxtBill.TabIndex = 1
        '
        'TxtMessage
        '
        Me.TxtMessage.Location = New System.Drawing.Point(86, 242)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ReadOnly = True
        Me.TxtMessage.Size = New System.Drawing.Size(273, 22)
        Me.TxtMessage.TabIndex = 3
        Me.TxtMessage.TabStop = False
        '
        'TxtTip
        '
        Me.TxtTip.Location = New System.Drawing.Point(259, 154)
        Me.TxtTip.Name = "TxtTip"
        Me.TxtTip.Size = New System.Drawing.Size(100, 22)
        Me.TxtTip.TabIndex = 2
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(384, 302)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(12, 302)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'LblOccu
        '
        Me.LblOccu.AutoSize = True
        Me.LblOccu.Location = New System.Drawing.Point(86, 51)
        Me.LblOccu.Name = "LblOccu"
        Me.LblOccu.Size = New System.Drawing.Size(139, 17)
        Me.LblOccu.TabIndex = 7
        Me.LblOccu.Text = "Person's Occupation"
        '
        'LblTip
        '
        Me.LblTip.AutoSize = True
        Me.LblTip.Location = New System.Drawing.Point(86, 159)
        Me.LblTip.Name = "LblTip"
        Me.LblTip.Size = New System.Drawing.Size(105, 17)
        Me.LblTip.TabIndex = 8
        Me.LblTip.Text = "Tip Percentage"
        '
        'LblAmt
        '
        Me.LblAmt.AutoSize = True
        Me.LblAmt.Location = New System.Drawing.Point(86, 108)
        Me.LblAmt.Name = "LblAmt"
        Me.LblAmt.Size = New System.Drawing.Size(78, 17)
        Me.LblAmt.TabIndex = 9
        Me.LblAmt.Text = "Bill Amount"
        '
        'FrmGratuity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 337)
        Me.Controls.Add(Me.LblAmt)
        Me.Controls.Add(Me.LblTip)
        Me.Controls.Add(Me.LblOccu)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtTip)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.TxtBill)
        Me.Controls.Add(Me.TxtJob)
        Me.Controls.Add(Me.BtnTip)
        Me.Name = "FrmGratuity"
        Me.Text = "Gratuity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTip As System.Windows.Forms.Button
    Friend WithEvents TxtJob As System.Windows.Forms.TextBox
    Friend WithEvents TxtBill As System.Windows.Forms.TextBox
    Friend WithEvents TxtMessage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTip As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblOccu As System.Windows.Forms.Label
    Friend WithEvents LblTip As System.Windows.Forms.Label
    Friend WithEvents LblAmt As System.Windows.Forms.Label

End Class
