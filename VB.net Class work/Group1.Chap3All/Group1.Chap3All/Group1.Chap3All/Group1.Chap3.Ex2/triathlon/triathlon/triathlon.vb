
'Rename VB Form
'Set Option to Strict variable
'Be sure to comment
'Submit assignment correctly
'Set calc?? field to read only



Public Class triathlon

    'Declaring global constant variables for exercise rates
    'Global variables can be accessed by all sections of the code.  
    'Once set, global variables are constant. 

    Dim runningRate As Integer = 475  'calories per hour
    Dim cyclingRate As Integer = 200  'calories per hour
    Dim swimmingRate As Integer = 275 'calories per hour

    'Declaring global variables for user data
    'Ideally global variables should not be used, instead subroutines or functions should be 
    'used to keep data and programming modular and compartmentalized.
    'There are many advantages to using modular programming.

    Dim runningTime As Double
    Dim cyclingTime As Double
    Dim swimmingTime As Double
    Dim poundsLost As Double




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompute.Click

        'local string variable used to temporarly store user entered data.

        Dim Temp As String  'using one string as temp variable

        'variables not being used.
        'Dim TempRunning As String
        'Dim TempCycling As String
        'Dim TempSwimming As String

        'used for troubleshooting
        'TempCycling = TxtCycling.Text()
        'TempRunning = TxtRunning.Text()
        'TempSwimming = TxtSwimming.Text()

        'this code displays entered data in raw string format:

        'TxtLost.Text() = "This is what you entered:" & TempSwimming & " " & TempCycling & " " & TempRunning




        Temp = TxtCycling.Text() 'set textbox entry to String reference Temp.

        cyclingTime = Double.Parse(Temp) 'converts Temp to double data type and assigns the value to cyclingTime



        Temp = TxtRunning.Text()

        runningTime = Double.Parse(Temp) 'converts Temp to double data type and assigns the value to runningTime

        Temp = TxtSwimming.Text()

        'swimmingTime = Double.Parse(Temp)  'does same conversion factor as Convert method and vice versa

        swimmingTime = CDbl(Temp)


        
        'Dim poundsLost As Double

        'calculates pounds lost by cycling, running, and swimming
        poundsLost = ((cyclingRate * cyclingTime) + (runningRate * runningTime) + (swimmingRate * swimmingTime)) / 3500




        'set decimal point to 2 decimal places
        TxtLost.Text() = "Total pounds lost:  " & String.Format("{0:f2}", (poundsLost))





    End Sub
End Class
