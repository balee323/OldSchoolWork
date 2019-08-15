Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Num1 As Integer
        Dim Num2 As Integer

        Num1 = CInt(TextBox1.Text)
        Num2 = CInt(TextBox2.Text)



        If (Num1) > (Num2) Then
            TextBox3.Text = "Number 1 is greater"
        Else
            TextBox3.Text = "Number 2 is greater"
        End If)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class
