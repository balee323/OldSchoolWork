Public Class FrmColors

    Private Sub FrmColors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBox.TextChanged

    End Sub

    Private Sub BtnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRed.Click
        TxtBox.BackColor = Color.Red
    End Sub

    Private Sub BtnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBlue.Click
        TxtBox.BackColor = Color.Blue
    End Sub

    Private Sub BtnWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWhite.Click
        TxtBox.ForeColor = Color.White
    End Sub

    Private Sub BtnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYellow.Click
        TxtBox.ForeColor = Color.Gold
    End Sub
End Class
