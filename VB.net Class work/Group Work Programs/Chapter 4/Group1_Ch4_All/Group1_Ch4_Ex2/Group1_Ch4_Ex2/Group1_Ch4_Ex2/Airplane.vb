Public Class Airplane

    Private Sub btnflight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnflight.Click

        'Pop up a message box if someone does not put in correct data.

        If lstfrom.Text = lstto.Text Then
            MessageBox.Show("Your arrival city must be different from you destination city.")
        End If
        If lstfrom.Text = "" Then
            MessageBox.Show("You must pick an airport to fly from.")
        End If
        If lstto.Text = "" Then
            MessageBox.Show("You must pick a destination.")
        End If

        'Input data into textbox to show the destination and arrival point of flights.

        txtflight.Text = "You are flying from " & lstfrom.Text & " " & "to " & lstto.Text



    End Sub
End Class
