Public Class SmallNumbers

    Private Sub btnsmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsmall.Click
       
        'Declare Variables

        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim answer As Double



        'Make sure that only numbers have been entered into text boxes using isnumeric function.

        If (IsNumeric(txtnum1.Text & txtnum2.Text & txtnum3.Text)) Then

            'Covert numbers into doubles to determine smallest
            num1 = CDbl(txtnum1.Text)
            num2 = CDbl(txtnum2.Text)
            num3 = CDbl(txtnum3.Text)
            ' answer = CDbl(txtanswer.Text)
        Else
            MessageBox.Show("Invalid Data. Please Enter a Number")
        End If


        'This is the Code to determine which number is the smallest.
        If num1 < num2 And num1 < num3 Then
            answer = num1

        ElseIf num2 < num1 And num2 < num3 Then
            answer = num2

        ElseIf num3 < num1 And num3 < num2 Then
            answer = num3
        End If

        txtanswer.Text = "The Smallest Number is " & answer

        'Clear textboxes

        txtnum1.Text = ""
        txtnum2.Text = ""
        txtnum3.Text = ""

    End Sub
End Class
