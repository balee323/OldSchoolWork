VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "ThisOutlookSession"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = True
Private WithEvents Items As Outlook.Items
Attribute Items.VB_VarHelpID = -1





Private Sub Application_Startup()
  'Dim olApp As Outlook.Application
  Dim objNS As Outlook.NameSpace
  Set olApp = Outlook.Application
  Set objNS = olApp.GetNamespace("MAPI")
  ' default local Inbox
  Set Items = objNS.GetDefaultFolder(olFolderInbox).Items
End Sub
Private Sub Items_ItemAdd(ByVal item As Object)

  On Error GoTo ErrorHandler
  Dim Msg As Outlook.MailItem
  If TypeName(item) = "MailItem" Then
    Set Msg = item
    
    Dim searchTerm As String
    searchTerm = "*task*"
    searchTerm = UCase(searchTerm)
    
    Dim EmailSubLine As String
    EmailSubLine = Msg.Subject
    EmailSubLine = UCase(Msg.Subject)
    
    
    If EmailSubLine Like searchTerm Then
    ' ******************
    ' do something here
     ' ******************
     'MsgBox ("Works")
     
     Dim copy As New CopyEmailToFolder
     copy.CopyToFolder Msg  'works

     
     End If
     
  End If
ProgramExit:
  Exit Sub
ErrorHandler:
  MsgBox Err.Number & " - " & Err.Description
  Resume ProgramExit
End Sub





