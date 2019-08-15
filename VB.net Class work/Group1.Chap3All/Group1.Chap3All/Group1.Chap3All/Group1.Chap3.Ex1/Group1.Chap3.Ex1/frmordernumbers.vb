Public Class frmordernumbers

    'All coding within buttonClick event
    'Please overlook all the commenting.  The commmenting is for the benefit of our group. So
    'everyone understands the code.

    Private Sub btngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerate.Click




        '==============================================================================================
        '  Declaring variables


        '     We don't need these first 2 integer variables
        '      StringName.Text.IndexOf("2")   -- will search for "2" in the string.


        'Dim ThirdLetterOfFirstname As Integer = 0  'Integer Variable to store positon of searched character
        '  We don't need this variable.

        'Dim ThirdLetterOfLastname As Integer = 0 'Integer Variable to store positon of searched character
        '  We don't need this variable.



        Dim First2OfFirstname As String  'Stores substring of first name (first 2 letters)

        Dim First2OfLastname As String  'Stores substring of last name (first 2 letters)

        Dim len As Integer = 0 'Integer Variable for length of characters in zipcode 

        Dim last3 As String  'Stores substring for Zipcode last 3 digits

        '==============================================================================================



        ' ThirdLetterOfFirstname = txtfirstname.Text.IndexOf("2")  'We don't need this code, all it does is search for "2" and give its position


        '  For instance Lets try this.  I will search for "i" in my name.  It should show an integer location of 2 (actually 3, but starts at 0).
        'ThirdLetterOfFirstname = txtfirstname.Text.IndexOf("i")   'Just remove the comment to test this code, put it back to deactivate.

        
        'ThirdLetterOfLastname = txtlastname.Text.IndexOf("2")  'Dont need this code, it searches for "2", result is -1 if not found.




        '     extracting the first two letters of the first name
        First2OfFirstname = txtfirstname.Text.Substring(0, 2) 'Code generates a substring with starting postion 0 for 2 characters

        '     extracting the first two letters of the last name
        First2OfLastname = txtlastname.Text.Substring(0, 2)  'Code generates a substring with starting postion 0 for 2 characters





        '      extracting the last three digits of the zip code

        len = txtzipcode.Text.Length  'assigns an integer value for string length to variable len


        last3 = txtzipcode.Text.Substring(len - 3, 3)  'Will produce a substring staring at zipcode String length minus 3, for 3 characters
        '                                               So it basically starts at postion 2 and goes for 3 characters.         


        '=============Displaying OrderNumber in textbox and learning /troubleshooting statements=============

        '       concatenate pieces together in ordernumber tex box
        txtordernumber.Text = First2OfFirstname & First2OfLastname & last3   'Offical code




        '              Testing Codes for troubleshooting anf learning what methods do

        ' txtordernumber.Text = ThirdLetterOfFirstname   '  "-1" is displayed because "2" does not exist in string of first
        'txtordernumber.Text = ThirdLetterOfFirstname   '  Lets test for finding "i" in a name. 

      

    End Sub
End Class
