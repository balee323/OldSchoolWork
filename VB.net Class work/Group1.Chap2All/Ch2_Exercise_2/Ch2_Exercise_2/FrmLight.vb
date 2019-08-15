Public Class FrmLight

    'Private Sub TxtRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRed.TabIndexChanged


    Private Sub TxtRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRed.Click

        'TxtRed.Visible = False

        TxtRed.BackColor = Color.Red
        TxtGreen.BackColor = Color.Gray
        TxtYellow.BackColor = Color.Gray

        TxtStatus.Text = "Red"

    End Sub

    'Private Sub TxtYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYellow.TabIndexChanged

    Private Sub TxtYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYellow.Click

        'TxtYellow.Visible = False

        TxtRed.BackColor = Color.Gray
        TxtYellow.BackColor = Color.Yellow
        TxtGreen.BackColor = Color.Gray

        TxtStatus.Text = "Yellow"

    End Sub

    'Private Sub TxtGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGreen.TabIndexChanged

    Private Sub TxtGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGreen.Click

        'TxtGreen.Visible = False

        TxtYellow.BackColor = Color.Gray
        TxtGreen.BackColor = Color.Green
        TxtRed.BackColor = Color.Gray

        TxtStatus.Text = "Green"

    End Sub

    Private Sub TxtRed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRed.TextChanged

    End Sub
End Class
