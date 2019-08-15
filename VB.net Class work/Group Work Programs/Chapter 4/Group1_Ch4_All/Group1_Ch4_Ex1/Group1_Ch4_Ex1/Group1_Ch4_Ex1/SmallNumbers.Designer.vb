<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmallNumbers
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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.lblnum3 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum3 = New System.Windows.Forms.TextBox()
        Me.btnsmall = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(21, 31)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(72, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "First Number: "
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(21, 78)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(90, 13)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "Second Number: "
        '
        'lblnum3
        '
        Me.lblnum3.AutoSize = True
        Me.lblnum3.Location = New System.Drawing.Point(21, 136)
        Me.lblnum3.Name = "lblnum3"
        Me.lblnum3.Size = New System.Drawing.Size(77, 13)
        Me.lblnum3.TabIndex = 2
        Me.lblnum3.Text = "Third Number: "
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(163, 23)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 3
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(163, 78)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 4
        '
        'txtnum3
        '
        Me.txtnum3.Location = New System.Drawing.Point(163, 128)
        Me.txtnum3.Name = "txtnum3"
        Me.txtnum3.Size = New System.Drawing.Size(100, 20)
        Me.txtnum3.TabIndex = 5
        '
        'btnsmall
        '
        Me.btnsmall.Location = New System.Drawing.Point(71, 178)
        Me.btnsmall.Name = "btnsmall"
        Me.btnsmall.Size = New System.Drawing.Size(151, 23)
        Me.btnsmall.TabIndex = 6
        Me.btnsmall.Text = "Display Smallest Number"
        Me.btnsmall.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(24, 228)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(239, 20)
        Me.txtanswer.TabIndex = 7
        '
        'SmallNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 293)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btnsmall)
        Me.Controls.Add(Me.txtnum3)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum3)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "SmallNumbers"
        Me.Text = "Small Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnum1 As System.Windows.Forms.Label
    Friend WithEvents lblnum2 As System.Windows.Forms.Label
    Friend WithEvents lblnum3 As System.Windows.Forms.Label
    Friend WithEvents txtnum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnum3 As System.Windows.Forms.TextBox
    Friend WithEvents btnsmall As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox

End Class
