<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmordernumbers
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
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblzipcode = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtzipcode = New System.Windows.Forms.TextBox()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.lblordernumber = New System.Windows.Forms.Label()
        Me.txtordernumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(50, 51)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(88, 17)
        Me.lblfirstname.TabIndex = 0
        Me.lblfirstname.Text = "First Name"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(50, 96)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(80, 17)
        Me.lbllastname.TabIndex = 1
        Me.lbllastname.Text = "Last Name"
        '
        'lblzipcode
        '
        Me.lblzipcode.AutoSize = True
        Me.lblzipcode.Location = New System.Drawing.Point(50, 145)
        Me.lblzipcode.Name = "lblzipcode"
        Me.lblzipcode.Size = New System.Drawing.Size(80, 17)
        Me.lblzipcode.TabIndex = 2
        Me.lblzipcode.Text = "Zip Code "
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(147, 45)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(170, 23)
        Me.txtfirstname.TabIndex = 3
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(147, 90)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(170, 23)
        Me.txtlastname.TabIndex = 4
        '
        'txtzipcode
        '
        Me.txtzipcode.Location = New System.Drawing.Point(147, 139)
        Me.txtzipcode.Name = "txtzipcode"
        Me.txtzipcode.Size = New System.Drawing.Size(170, 23)
        Me.txtzipcode.TabIndex = 5
        '
        'btngenerate
        '
        Me.btngenerate.Location = New System.Drawing.Point(132, 197)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(198, 25)
        Me.btngenerate.TabIndex = 6
        Me.btngenerate.Text = "Generate Order Number"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'lblordernumber
        '
        Me.lblordernumber.AutoSize = True
        Me.lblordernumber.Location = New System.Drawing.Point(26, 261)
        Me.lblordernumber.Name = "lblordernumber"
        Me.lblordernumber.Size = New System.Drawing.Size(104, 17)
        Me.lblordernumber.TabIndex = 7
        Me.lblordernumber.Text = "Order Number"
        '
        'txtordernumber
        '
        Me.txtordernumber.Location = New System.Drawing.Point(147, 258)
        Me.txtordernumber.Name = "txtordernumber"
        Me.txtordernumber.Size = New System.Drawing.Size(170, 23)
        Me.txtordernumber.TabIndex = 8
        '
        'frmordernumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 344)
        Me.Controls.Add(Me.txtordernumber)
        Me.Controls.Add(Me.lblordernumber)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.txtzipcode)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.lblzipcode)
        Me.Controls.Add(Me.lbllastname)
        Me.Controls.Add(Me.lblfirstname)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmordernumbers"
        Me.Text = "Order Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblzipcode As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtzipcode As System.Windows.Forms.TextBox
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents lblordernumber As System.Windows.Forms.Label
    Friend WithEvents txtordernumber As System.Windows.Forms.TextBox

End Class
