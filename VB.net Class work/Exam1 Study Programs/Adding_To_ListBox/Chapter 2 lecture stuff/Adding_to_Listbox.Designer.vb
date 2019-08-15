<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListDisplay = New System.Windows.Forms.ListBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListDisplay
        '
        Me.ListDisplay.FormattingEnabled = True
        Me.ListDisplay.Location = New System.Drawing.Point(12, 100)
        Me.ListDisplay.Name = "ListDisplay"
        Me.ListDisplay.Size = New System.Drawing.Size(279, 95)
        Me.ListDisplay.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(141, 58)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add to List"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(23, 13)
        Me.TxtInput.Multiline = True
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(109, 38)
        Me.TxtInput.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 263)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ListDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListDisplay As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtInput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
