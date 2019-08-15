<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ch5Ex1
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
        Me.LblBill = New System.Windows.Forms.Label()
        Me.LblJob = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.TxtTip = New System.Windows.Forms.TextBox()
        Me.LblPercent = New System.Windows.Forms.Label()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnTip
        '
        Me.BtnTip.Location = New System.Drawing.Point(150, 197)
        Me.BtnTip.Name = "BtnTip"
        Me.BtnTip.Size = New System.Drawing.Size(171, 23)
        Me.BtnTip.TabIndex = 0
        Me.BtnTip.Text = "Compute Tip"
        Me.BtnTip.UseVisualStyleBackColor = True
        '
        'TxtJob
        '
        Me.TxtJob.Location = New System.Drawing.Point(240, 38)
        Me.TxtJob.Name = "TxtJob"
        Me.TxtJob.Size = New System.Drawing.Size(144, 20)
        Me.TxtJob.TabIndex = 1
        '
        'TxtBill
        '
        Me.TxtBill.Location = New System.Drawing.Point(240, 88)
        Me.TxtBill.Name = "TxtBill"
        Me.TxtBill.Size = New System.Drawing.Size(144, 20)
        Me.TxtBill.TabIndex = 4
        '
        'LblBill
        '
        Me.LblBill.AutoSize = True
        Me.LblBill.Location = New System.Drawing.Point(105, 95)
        Me.LblBill.Name = "LblBill"
        Me.LblBill.Size = New System.Drawing.Size(71, 13)
        Me.LblBill.TabIndex = 5
        Me.LblBill.Text = "Amount of Bill"
        '
        'LblJob
        '
        Me.LblJob.AutoSize = True
        Me.LblJob.Location = New System.Drawing.Point(71, 45)
        Me.LblJob.Name = "LblJob"
        Me.LblJob.Size = New System.Drawing.Size(105, 13)
        Me.LblJob.TabIndex = 6
        Me.LblJob.Text = "Person's Occupation"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(12, 296)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnEnd
        '
        Me.BtnEnd.Location = New System.Drawing.Point(343, 296)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 8
        Me.BtnEnd.Text = " Exit"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'TxtTip
        '
        Me.TxtTip.Location = New System.Drawing.Point(240, 143)
        Me.TxtTip.Name = "TxtTip"
        Me.TxtTip.Size = New System.Drawing.Size(144, 20)
        Me.TxtTip.TabIndex = 9
        '
        'LblPercent
        '
        Me.LblPercent.AutoSize = True
        Me.LblPercent.Location = New System.Drawing.Point(114, 150)
        Me.LblPercent.Name = "LblPercent"
        Me.LblPercent.Size = New System.Drawing.Size(62, 13)
        Me.LblPercent.TabIndex = 10
        Me.LblPercent.Text = "Percent Tip"
        '
        'TxtMessage
        '
        Me.TxtMessage.Location = New System.Drawing.Point(64, 251)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ReadOnly = True
        Me.TxtMessage.Size = New System.Drawing.Size(320, 20)
        Me.TxtMessage.TabIndex = 11
        '
        'Ch5Ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 331)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.LblPercent)
        Me.Controls.Add(Me.TxtTip)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblJob)
        Me.Controls.Add(Me.LblBill)
        Me.Controls.Add(Me.TxtBill)
        Me.Controls.Add(Me.TxtJob)
        Me.Controls.Add(Me.BtnTip)
        Me.Name = "Ch5Ex1"
        Me.Text = "Gratuities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTip As System.Windows.Forms.Button
    Friend WithEvents TxtJob As System.Windows.Forms.TextBox
    Friend WithEvents TxtBill As System.Windows.Forms.TextBox
    Friend WithEvents LblBill As System.Windows.Forms.Label
    Friend WithEvents LblJob As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents TxtTip As System.Windows.Forms.TextBox
    Friend WithEvents LblPercent As System.Windows.Forms.Label
    Friend WithEvents TxtMessage As System.Windows.Forms.TextBox

End Class
