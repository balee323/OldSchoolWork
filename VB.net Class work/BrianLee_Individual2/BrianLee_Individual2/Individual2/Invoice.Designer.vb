<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoice
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
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtOrder = New System.Windows.Forms.TextBox()
        Me.TxtNumChairs = New System.Windows.Forms.TextBox()
        Me.TxtNumSofas = New System.Windows.Forms.TextBox()
        Me.TxtCityStateZip = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(147, 32)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(165, 22)
        Me.TxtName.TabIndex = 0
        '
        'TxtOrder
        '
        Me.TxtOrder.Location = New System.Drawing.Point(372, 32)
        Me.TxtOrder.Multiline = True
        Me.TxtOrder.Name = "TxtOrder"
        Me.TxtOrder.ReadOnly = True
        Me.TxtOrder.Size = New System.Drawing.Size(249, 223)
        Me.TxtOrder.TabIndex = 12
        Me.TxtOrder.TabStop = False
        '
        'TxtNumChairs
        '
        Me.TxtNumChairs.Location = New System.Drawing.Point(147, 186)
        Me.TxtNumChairs.Name = "TxtNumChairs"
        Me.TxtNumChairs.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumChairs.TabIndex = 3
        '
        'TxtNumSofas
        '
        Me.TxtNumSofas.Location = New System.Drawing.Point(147, 233)
        Me.TxtNumSofas.Name = "TxtNumSofas"
        Me.TxtNumSofas.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumSofas.TabIndex = 4
        '
        'TxtCityStateZip
        '
        Me.TxtCityStateZip.Location = New System.Drawing.Point(147, 130)
        Me.TxtCityStateZip.Name = "TxtCityStateZip"
        Me.TxtCityStateZip.Size = New System.Drawing.Size(165, 22)
        Me.TxtCityStateZip.TabIndex = 2
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(147, 83)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(165, 22)
        Me.TxtAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Last, First)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "City, State, Zip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chairs Ordered:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 34)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sofas Ordered:"
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(30, 296)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(101, 23)
        Me.BtnOrder.TabIndex = 5
        Me.BtnOrder.Text = "Process Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(236, 296)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(152, 23)
        Me.BtnClear.TabIndex = 6
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(486, 296)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(135, 23)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 369)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtCityStateZip)
        Me.Controls.Add(Me.TxtNumSofas)
        Me.Controls.Add(Me.TxtNumChairs)
        Me.Controls.Add(Me.TxtOrder)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "FrmInvoice"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrder As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumChairs As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumSofas As System.Windows.Forms.TextBox
    Friend WithEvents TxtCityStateZip As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnOrder As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
