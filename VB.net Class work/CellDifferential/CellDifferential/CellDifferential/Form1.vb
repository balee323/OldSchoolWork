Public Class Form1

    Dim Seg As Integer = 0
    Dim Lym As Integer = 0
    Dim Mono As Integer = 0
    Dim Eos As Integer = 0
    Dim Baso As Integer = 0
    Dim Band As Integer = 0
    Dim NRBC As Integer = 0

    Dim Total As Integer = 0




    Private Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInput.KeyPress

        TxtInput.Focus()

        Count(TxtInput.Text)
        TxtInput.Focus()
        TxtInput.Text = ""
        'MessageBox.Show(TxtInput.Text)
       


    End Sub


    Sub Count(ByVal Key As String)

        If TxtInput.Text = "/" And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Seg = Seg + 1
            TxtSeg.Text = Seg
            'TxtInput.Text = ""
        End If

        If TxtInput.Text = "." And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Lym = Lym + 1
            TxtLym.Text = Lym
            'TxtInput.Text = ""
        End If

        If TxtInput.Text = "," And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Mono = Mono + 1
            Txtmono.Text = Mono
            'TxtInput.Text = ""
        End If

        If TxtInput.Text = "m" And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Eos = Eos + 1
            TxtBaso.Text = Eos
            'TxtInput.Text = ""
        End If

        If TxtInput.Text = "n" And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Baso = Baso + 1
            TxtBaso.Text = Baso
            'TxtInput.Text = ""
        End If


        If TxtInput.Text = "b" And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            Band = Band + 1
            TxtBaso.Text = Band
            'TxtInput.Text = ""
        End If


        If TxtInput.Text = "'" And Total <= 100 Then
            ' MessageBox.Show("You pressed / ")
            Total = Total + 1
            TxtTotal.Text = Total
            NRBC = NRBC + 1
            TxtBaso.Text = NRBC
            'TxtInput.Text = ""
        End If


        If Total = 100 Then
            MessageBox.Show("Complete")
        End If




    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        TxtInput.Clear()
        TxtSeg.Clear()
        TxtTotal.Clear()
        TxtLym.Clear()
        TxtMono.Clear()
        TxtEos.Clear()
        TxtBaso.Clear()
        TxtBand.Clear()
        TxtInput.Focus()
        Total = 0
        Seg = 0
        Lym = 0
        Mono = 0
        Eos = 0
        Baso = 0
        Band = 0
        NRBC = 0


    End Sub
End Class
