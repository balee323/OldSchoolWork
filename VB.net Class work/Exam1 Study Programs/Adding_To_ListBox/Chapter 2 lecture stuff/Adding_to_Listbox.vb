Public Class Form1

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        Dim NumInt As Integer = 0

        NumInt = CInt(TxtInput.Text)  'converted the user entered data into an integer (data type checking not in place)

        ListDisplay.Items.Add(NumInt)   'ListBox method Items adds Datatype Integer to the list in vertically.

        TxtInput.Clear()   'Clears the textBox for data input

        ' TxtInput.Text = ""   'Another way to clear the textBox for data input

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End  'ends program
    End Sub
End Class
