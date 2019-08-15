Public Class FrmGrade

    Private Sub BtnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrade.Click

        Dim MidScore As Double = 0
        Dim FinScore As Double = 0
        Dim LetterGrade As String




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


        LetterGrade = Grade(MidScore, FinScore)

        TxtGrade.Text = (" Your Grade is ") & LetterGrade


    End Sub

    Function Grade(ByVal num1 As Double, ByVal num2 As Double) As String

        Dim AvgScore As Double
        Dim LetterGrade As String = ""


        AvgScore = (num1 + num2) / 2


        If (AvgScore < 60) Then


            LetterGrade = "F"

        ElseIf ((AvgScore) >= (60) And (AvgScore) <= (69)) Then


            LetterGrade = "D"

        ElseIf ((AvgScore) >= (70) And (AvgScore) <= (79)) Then

            LetterGrade = "C"

        ElseIf ((AvgScore) >= (80) And (AvgScore) <= (89)) Then

            LetterGrade = "B"

        ElseIf (AvgScore) >= (90) Then

            LetterGrade = "A"

        End If

        Return LetterGrade


    End Function

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtFin.Clear()
        TxtMid.Clear()
        TxtGrade.Clear()
    End Sub
End Class


