VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} UserForm1 
   Caption         =   "Add Email To Task Details"
   ClientHeight    =   1290
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4335
   OleObjectBlob   =   "UserForm1.frx":0000
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "UserForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim AddEmail As New AddEmail
Dim taskDetails As String


Private Sub CommandButton1_Click()

If (Not TextBox1.Text = "") And IsNumeric(TextBox1.Text) Then

MsgBox ("Attached to task" & TextBox1.Text)


'getConnected


UpdateTaskDetails

End


Else
MsgBox ("Invalid Task Number")
End If

End Sub



Private Sub UpdateTaskDetails()
  AddEmail.SaveTaskDetails (CInt(TextBox1.Text))
End Sub


Private Sub UserForm_Initialize()
     ' 0 = manual, 1 = center, 2 = center screen, 3 = windowsDefault

  ' Me.StartUpPosition = 3
   

Me.StartUpPosition = 0
Me.Top = Application.ActiveWindow.Top + 150
Me.Left = Application.ActiveWindow.Left + 150


TextBox1.SetFocus

End Sub
