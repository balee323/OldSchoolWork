Public Class FrmBachDegree

    Dim BachDegrees() As String  'global variable

    Private Sub FrmBachDegree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim BachDegrees() As String

        BachDegrees = IO.File.ReadAllLines("degrees.txt") 'read in all of the data from file

    End Sub



    Private Sub BtnTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTable.Click

        Dim Splits(3) As String 'need to have 4 slots 


        'Formats listbox
        Dim ColumnSpacing As String = "{0, -30}{1, 10}{2, 10}" 'column(s) and spacing

        'MessageBox.Show(ColumnSpacing)



        'putting headers to the columns
        LstBachDegree.Items.Add("Bachelor Degrees Conferred in Certain Fields")
        LstBachDegree.Items.Add("_____________________________________________________") 'adding a line
        LstBachDegree.Items.Add(" ") 'adding a space
        LstBachDegree.Items.Add(String.Format(ColumnSpacing, "Field of Study", "1981", "2011"))
        LstBachDegree.Items.Add("----------------------------------------------------- ") 'adding dashed line
        LstBachDegree.Items.Add(" ") 'adding a space



        'Place list from degrees.txt in listbox

        Dim i As Integer = 0

        ' MessageBox.Show("Items: " & BachDegrees.Count())

        Do While (i <= (BachDegrees.Count - 1)) 'adding to split

            'For i As Integer = 0 To BachDegrees(i).Count - 1
            Splits = Split(BachDegrees(i), ",")  'split using , as deliminator

            LstBachDegree.Items.Add(String.Format(ColumnSpacing, Splits(0), Splits(1), Splits(2)))

            i = i + 1

        Loop


        LstBachDegree.Items.Add("----------------------------------------------------- ") 'adding dashed line
        LstBachDegree.Items.Add(" ")
        LstBachDegree.Items.Add("Source: U.S. National Center of Educational Services.")

    End Sub

    Private Sub btnpercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPercent.Click


        Dim ColumnSpacing As String = "{0, -30}{1, 15}" 'column(s) and spacing

        Dim Splits(3) As String 'need to have 4 slots 

        Dim PercentChange As Double = 0
        Dim TempNum As Double = 0


        LstBachDegree.Items.Add("Percent Change in Bachelor Degrees Conferred")
        LstBachDegree.Items.Add(" ")
        LstBachDegree.Items.Add(String.Format(ColumnSpacing, "Field of Study", "% Change (1981-2011)"))
        LstBachDegree.Items.Add(" ")

        Dim i As Integer = 0

        Do While (i <= (BachDegrees.Count - 1)) 'adding to split

            'For i As Integer = 0 To BachDegrees(i).Count - 1
            Splits = Split(BachDegrees(i), ",")  'split using , as deliminator




            TempNum = (CDbl(Splits(2)) - CDbl(Splits(1)))

            PercentChange = TempNum / CDbl(Splits(1))
            


            'MessageBox.Show(Splits(1) & "  " & Splits(2))

            'LstBachDegree.Items.Add(String.Format(ColumnSpacing, (CDbl(PercentChange))))

            LstBachDegree.Items.Add(String.Format(ColumnSpacing, Splits(0), FormatPercent(CDbl(PercentChange))))

            i = i + 1

            PercentChange = 0
        Loop


    End Sub


    Private Sub BtnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnd.Click

        End

    End Sub

    
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click


        LstBachDegree.Items.Clear()
        TxtSeachBox.Clear()
        'LstResult.Items.Clear() 'I keep getting an error on this??? I am not sure why!

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click


        'LstResult.Items.Clear() 'I keep getting an error on this??? I am not sure why!

        Dim search As String = TxtSeachBox.Text 'setting search word to uppercase and sets to search variable

        search = search.ToUpper
        'can't comment on the query, getting errors, strange...!!

        Dim SearchQuery = From Name In BachDegrees
                          Where (Name.IndexOf(search) <> -1)
                          Order By Name Ascending
                          Select DegreeField(Name)
        LstResult.DataSource = SearchQuery.ToList   'entire row should appear



    End Sub

    Function DegreeField(ByVal Str As String) As String
        'did not use this function

        Dim Splits(3) As String 'need to have 4 slots

        Splits = Split(Str, ",")  'split using , as deliminator

        Return ("The number of degrees in " & Splits(0) & " in 1981: " & Splits(1) & " and in 2011: " & Splits(2)) 'returns just the degree field

    End Function

    Private Sub BtnHisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHisto.Click



        Dim ColumnSpacing As String = "{0, -30}{1, -15}" 'column(s) and spacing

        Dim Splits(3) As String 'need to have 4 slots 

        Dim Total2011 As Double = 0 'for degrees in 2011
        Dim HistoStr As String = ""
        Dim TempStr As String = ""


        LstBachDegree.Items.Add("Percent Change in Bachelor Degrees Conferred")
        LstBachDegree.Items.Add(" ")
        LstBachDegree.Items.Add(String.Format(ColumnSpacing, "Field of Study", "per 10,000 degrees"))
        LstBachDegree.Items.Add(" ")

        Dim i As Integer = 0

        Do While (i <= (BachDegrees.Count - 1)) 'adding to split

            'For i As Integer = 0 To BachDegrees(i).Count - 1
            Splits = Split(BachDegrees(i), ",")  'split using , as deliminator



            Total2011 = (CDbl(Splits(2)))  'for 2011 degrees

            While (Total2011 >= 10000)
                TempStr = "*"
                HistoStr = TempStr + HistoStr
                Total2011 = Total2011 - 10000 'removes 10000 each iteration
            End While



            'LstBachDegree.Items.Add(String.Format(ColumnSpacing, (CDbl(PercentChange))))

            LstBachDegree.Items.Add(String.Format(ColumnSpacing, Splits(0), HistoStr))

            i = i + 1

            Total2011 = 0 'resets
            HistoStr = "" 'resets
            TempStr = ""  'resets

        Loop




    End Sub
End Class




