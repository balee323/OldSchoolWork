Public Class FrmGrade

    Private Sub BtnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrade.Click

        Dim MidScore As Double = 0
        Dim FinScore As Double = 0


        If IsNumeric(CDbl(TxtMid.Text)) Then

            MidScore = CDbl(TxtMid.Text)
        Else

            MessageBox.Show("Please Enter Numeric Score.")

        End If



        If IsNumeric(CDbl(TxtFin.Text)) Then

            FinScore = CDbl(TxtFin.Text)
        Else

            MessageBox.Show("Please Enter Numeric Score.")

        End If


        Grade(MidScore, FinScore)


    End Sub

    Sub Grade(ByVal num1 As Double, ByVal num2 As Double)

        Dim AvgScore As Double


        AvgScore = (num1 + num2) / 2


        If (AvgScore < 60) Then

            TxtGrade.Text = (" Your Grade is an F!")


        ElseIf ((AvgScore) >= (60) And (AvgScore) <= (69)) Then

            TxtGrade.Text = (" Your Grade is a D!")


        ElseIf ((AvgScore) >= (70) And (AvgScore) <= (79)) Then

            TxtGrade.Text = (" Your Grade is an C!")

        ElseIf ((AvgScore) >= (80) And (AvgScore) <= (89)) Then

            TxtGrade.Text = (" Your Grade is a B!")

        ElseIf (AvgScore) >= (90) Then

            TxtGrade.Text = (" Your Grade is an A! Yeah!")

        End If




    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtFin.Clear()
        TxtMid.Clear()
        TxtGrade.Clear()
    End Sub
End Class


