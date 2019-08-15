Public Class FrmHello



    Private Sub BtnRepeats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepeats.Click


        Dim Iterator As Integer = 1
        Dim NumOfTimes As Integer = 0
        Dim WordStr As String = ""
        Dim WordStrBuild As String = ""
        Dim WordOk As Boolean = False 'for okaying verified string value
        Dim NumOK As Boolean = False 'for okaying verified integer value

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
            WordOk = True  'The string is not numerical, and passes as a word

        End If



        'trying to let a textbox be re-enterd
        If (WordOk = True) Then
            WordStr = TxtWord.Text  'otherwise string containted in the textbox is referenced to WordStr
        End If


        '=================================================================================================


        'check for blank entry in TxtReats Textbox
        If TxtRepeats.Text = ("") Then
            MessageBox.Show("Repeats Entry is blank, Please enter an integer between 1 and 20")
            TxtRepeats.Clear()
            NumOK = False

            'check for non-numerical entry in TxtRepeats Textbox
        ElseIf Not IsNumeric(TxtRepeats.Text) Then
            MessageBox.Show("You entered a non-numeric, Please enter an integer between 1 and 20")       
            TxtRepeats.Clear()
            NumOK = False

        Else
            NumOK = True 'String data is numeric and passes to new statements
        End If


        'trying to let a textbox be re-enterd
        If (NumOK = True) Then
            NumOfTimes = CInt(TxtRepeats.Text)  'otherwise string containted in the textbox is referenced to WordStr
        End If



        Do While ((NumOK = True) And ((NumOfTimes > 20) Or (NumOfTimes) <= 0)) 'this loop verifies that the integer is <= 20
            MessageBox.Show("Please enter an Integer value between 1 and 20")
            TxtRepeats.Clear()

            'NumOfTimes = CInt(InputBox("Please Enter an integer between 1 and 20")) 'allowing user to re-enter
            TxtRepeats.Text = (InputBox("Please Enter an integer between 1 and 20")) 'allowing user to re-enter

            'have second check for numeric value
            If IsNumeric(TxtRepeats.Text) Then 'checks for numerical values after request for number re-entry
                NumOfTimes = CInt(TxtRepeats.Text)
            End If

        Loop


        '=================================================================================================

        'Section builds a giant string from the user entered string

        Do While (Iterator <= NumOfTimes)

            WordStrBuild = WordStr + (WordStrBuild)  'makes one big string that keeps adding the user-word to itself
            Iterator = (Iterator + 1)  'iterator variable, each run of the loop, 1 gets added to iterator variable

        Loop

        TxtDisplay.Text = WordStrBuild  'displayed in textBox as a large string 
        Iterator = 1 'sets iterator back to 1 (I know 0 is the technical starting point).

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        'clears all textboxes
        TxtDisplay.Clear()
        TxtRepeats.Clear()
        TxtWord.Clear()


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End 'ends program
    End Sub
End Class
