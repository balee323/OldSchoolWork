Public Class frmscores
    'declare the array and load its values from the text file 
    Dim strscores() As String = IO.File.ReadAllLines("data.txt")


    Private Sub btnscores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscores.Click
        'list all scores in the list box when btn scores in clicked
        lstscores.DataSource = strscores
    End Sub

    Private Sub btnabove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabove.Click

        'Declare another numeric array of the same size to be able to perform mathematical computations on the array elements
        Dim scores(19) As Integer

        'Use a loop to convert each element to numeric type and assign it to numeric array
        For i As Integer = 0 To scores.Count - 1
            scores(i) = CInt(strscores(i))
        Next

        ' calculate scores average
        Dim average As Integer
        average = CInt(scores.Average)

        ' use a loop to count how many scores are above average and display the total in the text box
        Dim num As Integer = 0
        For i As Integer = 0 To scores.Count - 1
            If scores(i) > average Then
                num += 1
                txtaboveaverage.Text = CStr(num)

            End If
        Next

    End Sub

    Private Sub btngrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrades.Click
        'declair a numeric array
        

        Dim i As Integer = 0

        Dim scores(20) As Integer




        While (i <= strscores.Count - 1)  'setting input array to scores array elements

            scores(i) = CInt(strscores(i))

            'testing
            'MessageBox.Show(CStr(scores(i))) 'works

            i = i + 1

        End While



        Dim NumOfA As Integer = 0
        Dim NumOfB As Integer = 0
        Dim NumOfC As Integer = 0
        Dim NumOfD As Integer = 0
        Dim NumOfF As Integer = 0






        'use a loop to process array elements

        i = 0 'reset

        Do While (i <= scores.Count - 1)


            If (scores(i) >= 90) And (scores(i) <= 100) Then
                NumOfA += 1
                'lstgrades.Items.Add(NumOfA & "" & "A's")
                i = i + 1
            End If

            If (scores(i) >= 80) And (scores(i) <= 89) Then
                NumOfB += 1
                'lstgrades.Items.Add(NumOfB & "" & "Bs")

            End If

            If scores(i) >= 70 And scores(i) <= 79 Then
                NumOfC += 1
                'lstgrades.Items.Add(NumOfC & "" & "Cs")

            End If

            If scores(i) >= 60 And scores(i) <= 69 Then
                NumOfD += 1
                'lstgrades.Items.Add(NumOfD & "" & "Ds")

            End If

            If scores(i) >= 0 And scores(i) <= 59 Then
                NumOfF += 1
                'lstgrades.Items.Add(NumOfF & "" & "Fs")

            End If

            'Next

            i = i + 1

        Loop

        lstgrades.Items.Add(NumOfA & "" & "A's")
        lstgrades.Items.Add(NumOfB & "" & "Bs")
        lstgrades.Items.Add(NumOfC & "" & "Cs")
        lstgrades.Items.Add(NumOfD & "" & "Ds")
        lstgrades.Items.Add(NumOfF & "" & "Fs")


    End Sub


End Class
