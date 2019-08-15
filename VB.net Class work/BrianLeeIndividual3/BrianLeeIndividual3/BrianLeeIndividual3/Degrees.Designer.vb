<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBachDegree
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
        Me.BtnTable = New System.Windows.Forms.Button()
        Me.BtnPercent = New System.Windows.Forms.Button()
        Me.BtnHisto = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.LstBachDegree = New System.Windows.Forms.ListBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.TxtSeachBox = New System.Windows.Forms.TextBox()
        Me.lblfield = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnTable
        '
        Me.BtnTable.Location = New System.Drawing.Point(13, 13)
        Me.BtnTable.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTable.Name = "BtnTable"
        Me.BtnTable.Size = New System.Drawing.Size(100, 55)
        Me.BtnTable.TabIndex = 1
        Me.BtnTable.Text = "Table of Degress"
        Me.BtnTable.UseVisualStyleBackColor = True
        '
        'BtnPercent
        '
        Me.BtnPercent.Location = New System.Drawing.Point(154, 13)
        Me.BtnPercent.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPercent.Name = "BtnPercent"
        Me.BtnPercent.Size = New System.Drawing.Size(100, 55)
        Me.BtnPercent.TabIndex = 2
        Me.BtnPercent.Text = "Percent Changes"
        Me.BtnPercent.UseVisualStyleBackColor = True
        '
        'BtnHisto
        '
        Me.BtnHisto.Location = New System.Drawing.Point(291, 14)
        Me.BtnHisto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHisto.Name = "BtnHisto"
        Me.BtnHisto.Size = New System.Drawing.Size(101, 54)
        Me.BtnHisto.TabIndex = 3
        Me.BtnHisto.Text = "Histogram"
        Me.BtnHisto.UseVisualStyleBackColor = True
        '
        'BtnEnd
        '
        Me.BtnEnd.Location = New System.Drawing.Point(717, 266)
        Me.BtnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(100, 55)
        Me.BtnEnd.TabIndex = 4
        Me.BtnEnd.Text = "Exit"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'LstBachDegree
        '
        Me.LstBachDegree.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBachDegree.FormattingEnabled = True
        Me.LstBachDegree.ItemHeight = 18
        Me.LstBachDegree.Location = New System.Drawing.Point(13, 79)
        Me.LstBachDegree.Margin = New System.Windows.Forms.Padding(4)
        Me.LstBachDegree.Name = "LstBachDegree"
        Me.LstBachDegree.Size = New System.Drawing.Size(804, 130)
        Me.LstBachDegree.TabIndex = 5
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(13, 217)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(100, 28)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'TxtSeachBox
        '
        Me.TxtSeachBox.Location = New System.Drawing.Point(121, 223)
        Me.TxtSeachBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSeachBox.Name = "TxtSeachBox"
        Me.TxtSeachBox.Size = New System.Drawing.Size(696, 22)
        Me.TxtSeachBox.TabIndex = 9
        '
        'lblfield
        '
        Me.lblfield.AutoSize = True
        Me.lblfield.Location = New System.Drawing.Point(118, 249)
        Me.lblfield.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfield.Name = "lblfield"
        Me.lblfield.Size = New System.Drawing.Size(89, 17)
        Me.lblfield.TabIndex = 10
        Me.lblfield.Text = "Degree Field"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 326)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Degree Field"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(716, 14)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(101, 54)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'LstResult
        '
        Me.LstResult.FormattingEnabled = True
        Me.LstResult.ItemHeight = 16
        Me.LstResult.Location = New System.Drawing.Point(12, 269)
        Me.LstResult.Name = "LstResult"
        Me.LstResult.Size = New System.Drawing.Size(698, 52)
        Me.LstResult.TabIndex = 14
        '
        'FrmBachDegree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 367)
        Me.Controls.Add(Me.LstResult)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblfield)
        Me.Controls.Add(Me.TxtSeachBox)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.LstBachDegree)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnHisto)
        Me.Controls.Add(Me.BtnPercent)
        Me.Controls.Add(Me.BtnTable)
        Me.Name = "FrmBachDegree"
        Me.Text = "bachelor degrees conferred in 1981 and 2011."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTable As System.Windows.Forms.Button
    Friend WithEvents BtnPercent As System.Windows.Forms.Button
    Friend WithEvents BtnHisto As System.Windows.Forms.Button
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents LstBachDegree As System.Windows.Forms.ListBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents TxtSeachBox As System.Windows.Forms.TextBox
    Friend WithEvents lblfield As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LstResult As System.Windows.Forms.ListBox

End Class
