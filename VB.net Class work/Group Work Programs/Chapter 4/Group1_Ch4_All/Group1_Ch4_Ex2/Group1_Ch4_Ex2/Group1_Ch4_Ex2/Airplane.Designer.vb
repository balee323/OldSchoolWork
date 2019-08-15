<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Airplane
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
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lstfrom = New System.Windows.Forms.ListBox()
        Me.lstto = New System.Windows.Forms.ListBox()
        Me.txtflight = New System.Windows.Forms.TextBox()
        Me.btnflight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.Location = New System.Drawing.Point(36, 37)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(45, 16)
        Me.lblfrom.TabIndex = 0
        Me.lblfrom.Text = "From: "
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(184, 37)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(31, 16)
        Me.lblto.TabIndex = 1
        Me.lblto.Text = "To: "
        '
        'lstfrom
        '
        Me.lstfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstfrom.FormattingEnabled = True
        Me.lstfrom.ItemHeight = 15
        Me.lstfrom.Items.AddRange(New Object() {"AUS", "BOS", "BWI", "DFW", "JFK", "LAX", "MIA", "ORD", "SFO"})
        Me.lstfrom.Location = New System.Drawing.Point(39, 70)
        Me.lstfrom.Name = "lstfrom"
        Me.lstfrom.Size = New System.Drawing.Size(69, 154)
        Me.lstfrom.TabIndex = 2
        '
        'lstto
        '
        Me.lstto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstto.FormattingEnabled = True
        Me.lstto.ItemHeight = 15
        Me.lstto.Items.AddRange(New Object() {"AUS", "BOS", "BWI", "DFW", "JFK", "LAX", "MIA", "ORD", "SFO"})
        Me.lstto.Location = New System.Drawing.Point(172, 70)
        Me.lstto.Name = "lstto"
        Me.lstto.Size = New System.Drawing.Size(70, 154)
        Me.lstto.TabIndex = 3
        '
        'txtflight
        '
        Me.txtflight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtflight.Location = New System.Drawing.Point(25, 243)
        Me.txtflight.Name = "txtflight"
        Me.txtflight.ReadOnly = True
        Me.txtflight.Size = New System.Drawing.Size(299, 21)
        Me.txtflight.TabIndex = 4
        '
        'btnflight
        '
        Me.btnflight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnflight.Location = New System.Drawing.Point(276, 92)
        Me.btnflight.Name = "btnflight"
        Me.btnflight.Size = New System.Drawing.Size(75, 76)
        Me.btnflight.TabIndex = 5
        Me.btnflight.Text = "Book Flight"
        Me.btnflight.UseVisualStyleBackColor = True
        '
        'Airplane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 330)
        Me.Controls.Add(Me.btnflight)
        Me.Controls.Add(Me.txtflight)
        Me.Controls.Add(Me.lstto)
        Me.Controls.Add(Me.lstfrom)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Name = "Airplane"
        Me.Text = "Airplane Reservations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lstfrom As System.Windows.Forms.ListBox
    Friend WithEvents lstto As System.Windows.Forms.ListBox
    Friend WithEvents txtflight As System.Windows.Forms.TextBox
    Friend WithEvents btnflight As System.Windows.Forms.Button

End Class
