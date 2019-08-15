Public Class frmsuperbowl
    'read in from file
    Dim winners() As String = IO.File.ReadAllLines("winners.txt")


    Private Sub btnallwinners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallwinners.Click

        lstwinners.Items.Clear() 'removes an prior data in list

        'set order to alphabetical, remove duplicates
        Dim TeamQuery = From Team In winners
                        Order By Team Ascending
                        Select Team
                        Distinct

        'each query item is added to list 1stwinners
        For Each Team As String In TeamQuery
            lstwinners.Items.Add(Team)
        Next

    End Sub

    Private Sub btnwinnersB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwinnersB.Click
        lstwinners.Items.Clear()  'clear list

        'search for index of "B", select, skip any -1 (false)
        Dim searchquery = From team In winners
                          Where (team.IndexOf("B") <> -1)
                                    Order By winners Ascending
                                    Select team
        For Each team In searchquery
            lstwinners.Items.Add(team)   'add any selected items to list
        Next


    End Sub

    Private Sub btnnumofwins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnumofwins.Click
        lstwinners.Items.Clear()   'clear list

        Dim TeamQuery = From Team In winners
                        Select Team
                        Distinct
        For Each Team As String In TeamQuery
            lstwinners.Items.Add(Team & " " & numwins(Team)) 'sets list item to add to list, show times
        Next
    End Sub

    ' function for list item to add, displays the number of times a team appears in the list
    Function numwins(ByVal nm As String) As Integer

        Dim q = From winner In winners
                Where winner = nm
                Select winner
        Return q.Count()  'returns the count of wins for certain team
    End Function

    ' clears list
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        lstwinners.Items.Clear()

    End Sub


End Class
