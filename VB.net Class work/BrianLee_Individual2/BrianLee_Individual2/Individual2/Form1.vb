Public Class FrmInvoice

    '============================================================================
    '                         Variables
    '============================================================================

    Private Sub BtnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrder.Click

        Dim TempName As String = ""
        Dim FirstName As String
        Dim LastName As String
        Dim Address As String
        Dim City As String
        Dim State As String
        Dim Zip As Integer

        Dim Chairs As Integer
        Dim Sofas As Integer
        Dim Total As Double
        Dim Taxes As Double


        '============================================================================
        '                         First and Last Name
        '============================================================================

        If IsNumeric(TxtName) Then
            MessageBox.Show("You Entered a Number for Name, please re-enter.")  'checking for numerical values

        Else
            TempName = TxtName.Text  'true if non-numerical data entered
        End If


        LastName = LastNameFunc(TempName)  'function returns last Name
        FirstName = FirstNameFunc(TempName) 'function returns first Name

        ' LastName = TempName.Substring(0, TempName.IndexOf(",")) 'Starting location is 0
        'FirstName = TempName.Substring(TempName.IndexOf(",") + 1) 'Starting location is at ","

        ' MessageBox.Show("First Name: " & FirstName & vbCrLf & "Last Name: " & LastName)

        '-----------------------

        TxtAddress.ReadOnly = False

        Address = TxtAddress.Text

        '============================================================================
        '                         City, State, and Zip
        '============================================================================
        'Make substrings and check each one.

        'Checking City, State, and Zipcode for correct data type

        'Creating temporary Strings to contain data for user entry

        Dim TempCityStateZip As String    'all temporary variables
        Dim TempCity As String
        Dim TempState As String
        Dim TempZipcode As String




        TempCityStateZip = TxtCityStateZip.Text

        TempCity = TempCityStateZip.Substring(0, TempCityStateZip.IndexOf(","))   'IndexOf returns an integer value
        'Substring starts at position 0, and ends at index of ","

        MessageBox.Show("City: " & TempCity)  'correct

        TempState = TempCityStateZip.Substring(TempCityStateZip.IndexOf(",") + 1, TempCityStateZip.IndexOf(",") - 2)
        'Substring starts at position of "," +1, and ends at postition "," -2 

        MessageBox.Show("State: " & TempState)  'correct

        TempZipcode = TempCityStateZip.Substring(TempCityStateZip.Length - 5)
        'Substring starts at TempCityStateZip string Lenght minus 5 (for zipcode length)

        MessageBox.Show("Zipcode: " & TempZipcode) 'correct

        '===============================================================================
        '               Checking City, State, and Zip for correctness"
        '===============================================================================

        'checking for non-numerical values for City
        If IsNumeric(TempCity) Then
            MessageBox.Show("You Entered a Number for City, please re-enter.")

        Else
            City = TempCity
        End If

        '---------

        'checking for non-numerical values for State
        If IsNumeric(TempState) Then
            MessageBox.Show("You Entered a Number for State, please re-enter.")

        Else
            State = TempState
        End If

        '--------------

        'checking for numerical values for ZipCode
        If IsNumeric(TempState) Then

            Zip = CInt(TempZipcode)

        Else
            MessageBox.Show("You Entered a non-number for Zipcode, please re-enter.")

        End If
        '============================================================================
        '                         Num of Chairs
        '============================================================================

        Chairs = NumChairs()



        '============================================================================
        '                         Num of Sofas
        '============================================================================


        Sofas = NumSofas()


        '============================================================================
        '                         Calculate Total
        '============================================================================

        Total = TotalCost(Chairs, Sofas)  'SubProcedure that generates order Invoice

        '============================================================================
        '                         Calculate Tax
        '============================================================================

        Taxes = TotalTax(Total)  'SubProcedure that generates order Invoice




        '============================================================================
        '                         Create Invoice
        '============================================================================






    End Sub
    '============================================================================
    '                        Functions!!!
    '============================================================================

    Function LastNameFunc(ByVal TempName As String) As String

        Dim LastName As String

        LastName = TempName.Substring(0, TempName.IndexOf(",")) 'Starting location is 0


        MessageBox.Show("Last Name: " & LastName)

        Return LastName

    End Function

    Function FirstNameFunc(ByVal TempName As String) As String

        Dim FirstName As String

        FirstName = TempName.Substring(TempName.IndexOf(",") + 1) 'Starting location is at ","


        MessageBox.Show("First Name: " & FirstName)

        Return FirstName

    End Function



    Function NumChairs() As Integer

        Dim Chairs As Integer

        If (IsNumeric(TxtNumChairs)) Then
            Chairs = CInt(TxtNumChairs.Text)
        Else
            MessageBox.Show("Please enter a number.")

        End If

        Return Chairs

    End Function

    Function NumSofas() As Integer

        Dim Sofas As Integer

        If (IsNumeric(TxtNumSofas)) Then
            Sofas = CInt(TxtNumSofas.Text)
        Else
            MessageBox.Show("Please enter a number.")

        End If

        Return Sofas

    End Function

    Function TotalCost(ByVal Num1 As Integer, ByVal Num2 As Integer) As Double   'returns cost

        Dim Cost As Double

        'num1 = chairs  = $350 EA
        'num2 = sofas   =  $925 EA
        'cost = cost of sofas and chair

        Cost = (Num1 * 350) + (Num2 * 925)




        Return Cost


    End Function

    Function TotalTax(ByVal Num1 As Double) As Double   'returns total taxes

        Dim Tax As Double
        Dim TaxRate As Double = 0.05

        Tax = Num1 * TaxRate

        Return Tax

    End Function

End Class
