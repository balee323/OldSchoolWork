Public Class String_Methods

    Dim UserString As String




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnter.Click

        UserString = TxtInput.Text

        TxtCurrent.Text = (UserString)

        TxtInput.ReadOnly = True

        TxtIndexOf.ReadOnly = False
        TxtLength.ReadOnly = False
        TxtSubString.ReadOnly = False
        TxtToUpper.ReadOnly = False
        TxtTrim.ReadOnly = False



    End Sub

    Private Sub BtnIndexOf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIndexOf.Click

        Dim UserChoosen As String = ""
        Dim StrIndex As Integer

        UserChoosen = TxtIndexOf.Text 'Sets the user Entered string to UserChoosen String Reference Variable

        TxtIndexOf.Clear()



        StrIndex = UserString.IndexOf(UserChoosen)


        TxtIndexOf.Text = CStr(StrIndex)  'Show integer location of user entered search string


    End Sub

    Private Sub BtnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear1.Click

        TxtIndexOf.Clear()

    End Sub

    Private Sub BtnSubstring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubstring.Click

        Dim Start As Integer = 0

        Dim StrSub As String

        Start = CInt(TxtSubString.Text()) 'Sets the user Entered Integer as Substring starting point

        TxtSubString.Clear()

        StrSub = UserString.Substring(Start)

        TxtSubString.Text = StrSub

        UserString = StrSub

        TxtCurrent.Text = UserString  'Show current state of String

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TxtSubString.Clear()
    End Sub





    Private Sub BtnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrim.Click


        Dim StrTrim As String = ""

        StrTrim = UserString.Trim

        TxtTrim.Text = StrTrim

        UserString = StrTrim

        TxtCurrent.Text = UserString



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TxtTrim.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim StrUpper As String

        StrUpper = UserString.ToUpper

        TxtToUpper.Text = StrUpper

        UserString = StrUpper

        TxtCurrent.Text = UserString



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TxtToUpper.Clear()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim StrLength As Integer

        StrLength = UserString.Length

        TxtLength.Text = CStr(StrLength)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TxtLength.Clear()
    End Sub

    Private Sub BtnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnd.Click
        End
    End Sub
End Class
