Public Class Add_5_Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click, Btn1.Click
        Dim Number As Double = 0
        Dim NewNumber As Double = 0
        Number = CDbl(TextBox1.Text)


        TextBox1.ReadOnly = True

        NewNumber = Add5(Number)  'function call   Passing Number by value

        TxtTotal.Text = CStr(NewNumber)


    End Sub

    Function Add5(ByVal num1 As Double) As Double

        Dim NewNum As Double = 0

        NewNum = num1 + 5

        Return NewNum
    End Function


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TextBox1.Clear()
        TxtTotal.Clear()
        TextBox1.ReadOnly = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class




