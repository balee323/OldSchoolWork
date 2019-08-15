Public Class Ch5Ex1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

  


    Private Sub BtnTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTip.Click, BtnTip.Click

        Dim Occu As String

        Dim Amt As Double = 0
        Dim TipPer As Double = 0
        Dim TipAmt As Double = 0




        If IsNumeric(TxtJob.Text()) Then

            MessageBox.Show("Error, You entered a Number")

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



        TipAmt = Tip(Amt, TipPer)  'function call   Passing Number by value

        TxtMessage.Text = "Tip the " & Occu & " " & CStr(FormatCurrency(TipAmt))


    End Sub

    Function Tip(ByVal num1 As Double, ByVal num2 As Double) As Double

        Dim TipAmt As Double = 0

        TipAmt = num1 * num2

        Return TipAmt

    End Function

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtJob.Clear()
        TxtBill.Clear()
        TxtTip.Clear()
        TxtMessage.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnd.Click
        End
    End Sub

    

End Class




