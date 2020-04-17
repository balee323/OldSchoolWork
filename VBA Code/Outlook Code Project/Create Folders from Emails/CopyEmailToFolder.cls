VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "CopyEmailToFolder"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False


Sub CopyToFolder(MyItem As Outlook.MailItem)
 
   'MsgBox ("Copy to Folder Works")
 
 Dim myNameSpace As Outlook.NameSpace
 
 Dim myFolder As Outlook.folder
 
 Dim myNewFolder As Outlook.folder
 
 Dim myMovedItem As Outlook.MailItem
 

  
 
 Set myNameSpace = Application.GetNamespace("MAPI")
 
Set myFolder = myNameSpace.GetDefaultFolder(olFolderInbox)
 
  On Error GoTo ErrorHandler
 
Set myNewFolder = myFolder.Folders.Add("Testing_Save")




ErrorHandler:
'MsgBox "This folder already exists!"

Resume Next




Set myNewFolder = myFolder.Folders("Testing_Save")

Set myMovedItem = MyItem
MyItem.Move myNewFolder

 
 
 
 

 
 
End Sub




Sub CopyToFolderNoParam()
 
   MsgBox ("Copy to Folder Works")

 
End Sub
