Public Class FrmPay



    Private Sub BtnBestPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBestPay.Click


        Dim Iterator As Integer = 1 'iterator variable
        Dim NumOfTimes As Integer = 10  'for 10 days

        Dim PayHundredDay As Double = 0  'for 100 dollars a day
        Dim PayDouble As Double = 0  'for doubling pay

        Dim TempPay As Double = 0   'temporary variable for 

        Dim Option1 As Double = 0 'variable for option1
        Dim Option2 As Double = 0 'variable for option2

        Dim Difference As Double = 0 'difference in best option
        Dim BestOption As String = ""
        Dim MoreMoney As String = "The difference is: "



        '=================================================================================================


        'Option1

        Do While (NumOfTimes >= 1)

            TempPay = 100
            PayHundredDay = TempPay + PayHundredDay
            NumOfTimes = NumOfTimes - 1
        Loop

        Option1 = PayHundredDay


        'MessageBox.Show(("Option 1: ") & FormatCurrency(CStr(PayHundredDay))


        '================================================================================

        'Option 2

        TempPay = 1 'set initially to $1
        NumOfTimes = 10 'set back to 10 times for 10 days

        Do While (NumOfTimes >= 1) 'runs through 9 times an adds each loop iteration


            PayDouble = TempPay + PayDouble '$1, $3, 7, etc.. until 1023

            TempPay = (TempPay * 2)   '$2

            NumOfTimes = NumOfTimes - 1
        Loop

        Option2 = PayDouble

        TempPay = 0 'set back to zero for next loop

        'MessageBox.Show(("Option 2: ") & FormatCurrency(CStr(PayDouble)))

        '=============================================================================

        'choosing best option
        If (Option1 > Option2) Then
            BestOption = "Option 1, " & FormatCurrency(CStr(Option1)) & ", is best choice. "

        ElseIf (Option1 < Option2) Then
            BestOption = "Option 2, " & FormatCurrency(CStr(Option2)) & ", is best choice. "

        Else
            BestOption = "error  "
        End If



        Difference = Diff(Option1, Option2) 'using a function for find the difference in option 1 and 2

        Display(BestOption, MoreMoney, Difference)  'using subprocedure to displa



        '=================================================================================================

      
    End Sub

    Sub Display(ByVal BestOption As String, ByVal MoreMoney As String, ByVal Difference As Double)

        TxtDisplay.Text = BestOption & MoreMoney & FormatCurrency(CStr(Difference)) & "."

    End Sub



    Function Diff(ByVal Option1 As Double, ByVal Option2 As Double) As Double

        Dim Difference As Double

        Difference = Math.Abs(Option1 - Option2)  'returns the absolute value, want a positive result

        Return Difference

    End Function


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End 'ends program
    End Sub


End Class
