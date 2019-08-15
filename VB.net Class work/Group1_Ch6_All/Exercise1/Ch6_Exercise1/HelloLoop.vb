Public Class FrmHello





    Private Sub BtnRepeats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepeats.Click



        Dim Iterator As Integer = 1
        Dim NumOfTimes As Integer = 0
        Dim WordStr As String = ""
        Dim WordStrBuild As String = ""
        Dim WordOk As Boolean = False 'for okaying verified string value
        Dim NumOK As Boolean = False 'for okaying verified integer value
        Dim Decision As String = "Y"
        '=================================================================================================


        'checking for empty textbox for TxtWord textbox

        If (TxtWord.Text) = "" Then
            MessageBox.Show("please enter a word in textbox")
            TxtWord.Clear()
            WordOk = False

        ElseIf IsNumeric(TxtWord.Text) Then
            MessageBox.Show("You entered a number, please enter a word.")
            WordOk = False
            TxtWord.Clear()
            Me.Focus()
        Else
            WordOk = True
            ' WordStr = TxtWord.Text  'otherwise string containted in the textbox is referenced to WordStr

        End If 'inner 




        'trying to let a textbox be re-enterd
        If (WordOk = True) Then
            WordStr = TxtWord.Text  'otherwise string containted in the textbox is referenced to WordStr
        End If


        '=================================================================================================


        'check for blank entry in TxtReats Textbox
        If TxtRepeats.Text = ("") Then
            MessageBox.Show("Repeats Entry is blank, Please enter an integer between 1 and 20")

            TxtRepeats.Clear()
            Me.Focus()
            NumOK = False

            'check for non-numerical entry in TxtRepeats Textbox
        ElseIf Not IsNumeric(TxtRepeats.Text) Then
            MessageBox.Show("You entered a non-numeric, Please enter an integer between 1 and 20")
            'Me.Close() 'kept getting an error message after this, compiler was running next lines of code
            ' End

            TxtRepeats.Clear()
            Me.Focus()
            NumOK = False

        Else
            NumOK = True
        End If


        'trying to let a textbox be re-enterd
        If (NumOK = True) Then
            NumOfTimes = CInt(TxtRepeats.Text)  'otherwise string containted in the textbox is referenced to WordStr
        End If


        Do While ((NumOK = True) And ((NumOfTimes > 20) Or (NumOfTimes) <= 0)) 'this loop verifies that the integer is <= 20
            MessageBox.Show("Please enter an Integer value between 1 and 20")
            TxtRepeats.Clear()
            'End
            NumOfTimes = CInt(InputBox("Please Enter an integer between 1 and 20")) 'allowing user to re-enter
            TxtRepeats.Text = CStr(NumOfTimes)
            Me.Focus()
        Loop


        '=================================================================================================



        Do While (Iterator <= NumOfTimes)

            ' MessageBox.Show("Hello")

            WordStrBuild = WordStr + (WordStrBuild)  'makes one big string that keeps adding "Hello" to itself
            Iterator = (Iterator + 1)  'iterator variable, each run of the loop, 1 gets added to iterator variable

        Loop

        TxtDisplay.Text = WordStrBuild  'displayed in textBox
        Iterator = 1

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtDisplay.Clear()
        TxtRepeats.Clear()
        TxtWord.Clear()


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub
End Class
