VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "AddEmail"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False

Dim MyConn As ADODB.Connection
Dim taskDetails As String
Dim emailText As String



Sub getConnected()

Set MyConn = New ADODB.Connection
'Set myCommand = New ADODB.Command
'Set myRecordSet = New ADODB.Recordset

 'Open Connection'
        
        'production
          MyConn.ConnectionString = "Provider=SQLOLEDB; Data Source=SQL2000; Database=ProjectControl; Integrated Security=SSPI"
       
        'testing
      '    MyConn.ConnectionString = "Provider=SQLOLEDB; Data Source=SQL2000; Database=ProjectControlVerify; Integrated Security=SSPI"
             
        MyConn.Open
                                     
       If (MyConn.State = adStateOpen) Then
    '  MsgBox "Connected, query Successful"
       Else
        MsgBox "Not Connected"
       End If
       
End Sub


Function getTaskDetails(TaskNum As Integer) As String
'Dim taskDetails As String


getConnected

Set myCommand = New ADODB.Command
Set myRecordset = New ADODB.Recordset

   Set myCommand.ActiveConnection = MyConn
   
     Dim query As String
     query = "select detail from task where taskID = " & TaskNum & " "
     
    ' MsgBox (query)

        myCommand.CommandText = query

      myCommand.CommandType = adCmdText
      myCommand.Execute
    
    Set myRecordset.ActiveConnection = MyConn
    myRecordset.Open myCommand


     Do Until myRecordset.EOF
       taskDetails = strOutput + myRecordset.Fields("detail")
       myRecordset.MoveNext
    Loop

  '  MsgBox (taskDetails)

getTaskDetails = taskDetails  'returns taskDetails

End Function


Sub SaveTaskDetails(TaskNum As Integer)

getTaskDetails (TaskNum)


Set myCommand = New ADODB.Command
Set myRecordset = New ADODB.Recordset

   Set myCommand.ActiveConnection = MyConn
   
    AddEmailItemContent
 
     Dim query As String
    ' query = "update task  set detail = ( '" & taskDetails & "')  where taskID = " & TaskNum & " "
    
  '  query = "declare @Details varchar(8000) set @Details ='" & taskDetails & "' update task  set detail = (@Details)  where taskID = " & TaskNum & " "
      
      query = "spUpdateTaskDetails @TaskDetails = '" & taskDetails & "' , @taskID= " & TaskNum & ""
      
      
      
      
     
   '  MsgBox (query)
     
   '  UserForm1.TextBox2.Text = query

        myCommand.CommandText = query

      myCommand.CommandType = adCmdText
      myCommand.Execute
    
    
    Set myRecordset.ActiveConnection = MyConn
    myRecordset.Open myCommand
    
    closeConn

  '  MsgBox (taskDetails)

End Sub

Sub AddEmailItemContent()
    


   Dim olItem As Outlook.MailItem
   
    
        
     'Set olItem = ActiveExplorer.Selection.Item(1)  'works
   
    'for current open Window
    'Set olItem = Outlook.ActiveWindow.CurrentItem
    
    
    
    If Outlook.Application.ActiveWindow = Application.ActiveExplorer Then
    
     Set olItem = Outlook.ActiveExplorer.Selection.item(1)    'works
    
    ElseIf Outlook.Application.ActiveWindow = Application.ActiveWindow Then
    
        'for current open Window
    Set olItem = Outlook.ActiveWindow.CurrentItem

    End If
    
    
         
    emailText = "Subject: " & olItem.Subject
     emailText = emailText & vbCrLf & "Date: " & olItem.ReceivedTime
    emailText = emailText & vbCrLf & "CC: " & olItem.CC
    emailText = emailText & vbCrLf & "To: " & olItem.To
    emailText = emailText & vbCrLf & "From: " & olItem.SenderName
    'emailText = emailText & vbCrLf & olItem.rec & vbCrLf
    emailText = emailText & vbCrLf & vbCrLf & olItem.Body & vbCrLf & vbCrLf
    
    
    taskDetails = taskDetails & vbCrLf & "----------------------------" & vbCrLf & "Attached Email" & vbCrLf & emailText & vbCrLf & "----------------------------"
    
    
    
    
    
    Const QUOTE = """"
    
  '    taskDetails = Replace(taskDetails, """", QUOTE)
    
  '  taskDetails = Replace(taskDetails, "'", "")  'works
   
    '  taskDetails = Replace(taskDetails, "'", "|")
      
      taskDetails = Replace(taskDetails, """", Chr(34))
      
      
        taskDetails = Replace(taskDetails, "'", "''")
    
    
End Sub


Sub closeConn()
MyConn.Close
End Sub





