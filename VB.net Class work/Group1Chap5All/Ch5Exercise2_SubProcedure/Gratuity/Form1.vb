Public Class FrmGratuity


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTip.Click

        Dim Occu As String = "null"

        Dim Amt As Double = 0
        Dim TipPer As Double = 0
        Dim TipAmt As Double = 0


        If IsNumeric(TxtJob.Text()) Then

            MessageBox.Show("Error, You entered a Number, please re-enter")

        Else

            Occu = TxtJob.Text  'assigns occupation to reference variable occu

        End If



        If IsNumeric(TxtBill.Text()) Then

            Amt = CDbl(TxtBill.Text)

        Else
            MessageBox.Show("Please enter a Number")
        End If



        If IsNumeric(TxtTip.Text()) Then

            TipPer = (CDbl(TxtTip.Text) / 100)  'dividing by 100 to get percentage in decimal format

        Else
            MessageBox.Show("Please enter a Number")
        End If



        Tip(Amt, TipPer, Occu)  'SubProcedure call   Passing Number by value


    End Sub

    Sub Tip(ByVal num1 As Double, ByVal num2 As Double, ByVal Occu As String)   'no return value as Sub Procedure

        Dim TipAmt As Double = 0

        TipAmt = num1 * num2

        'no return value

        TxtMessage.Text = "Tip the " & Occu & " " & CStr(FormatCurrency(TipAmt))

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtJob.Clear()
        TxtBill.Clear()   'clears all textboxes
        TxtTip.Clear()
        TxtMessage.Clear()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End    'exits program
    End Sub

End Class




