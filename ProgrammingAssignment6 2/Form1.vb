Public Class frmGoAndTellMissions


    Public missionsArray() As String = IO.File.ReadAllLines("easterndiv_mission.txt")


    '************************
    ' Form Load
    '************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuAscending.Checked = True
        mnuDescending.Checked = False
        mnuAll.Checked = True
        mnuEurope.Checked = False
        mnuMiddleEast.Checked = False
        mnuSouthAmerica.Checked = False
        mnuUnitedStates.Checked = False

        Dim query = From line In missionsArray
            Let Last = line.Split(","c)(0)
            Let First = line.Split(","c)(1)
            Let State = line.Split(","c)(2)
            Let Age = line.Split(","c)(3)
            Let YearsOfService = line.Split(","c)(4)
            Let Location = line.Split(","c)(5)
            Order By Last Ascending
            Select Last, First, State, Age, YearsOfService, Location

        dgvDisplay.DataSource = query.ToList()

    End Sub

    'Text files will display in descending order by last name

    Private Sub mnuDescending_Click(sender As Object, e As EventArgs) Handles mnuDescending.Click
        mnuAscending.Checked = False
        mnuDescending.Checked = True

        Dim query = From line In missionsArray
            Let Last = line.Split(","c)(0)
            Let First = line.Split(","c)(1)
            Let State = line.Split(","c)(2)
            Let Age = line.Split(","c)(3)
            Let YearsOfService = line.Split(","c)(4)
            Let Location = line.Split(","c)(5)
            Order By Last Descending
            Select Last, First, State, Age, YearsOfService, Location

        dgvDisplay.DataSource = query.ToList()

    End Sub

    'Text files will display in ascending order by last name

    Private Sub mnuAscending_Click(sender As Object, e As EventArgs) Handles mnuAscending.Click

        mnuAscending.Checked = True
        mnuDescending.Checked = False


        Dim query = From line In missionsArray
            Let Last = line.Split(","c)(0)
            Let First = line.Split(","c)(1)
            Let State = line.Split(","c)(2)
            Let Age = line.Split(","c)(3)
            Let YearsOfService = line.Split(","c)(4)
            Let Location = line.Split(","c)(5)
            Order By Last Ascending
            Select Last, First, State, Age, YearsOfService, Location

        dgvDisplay.DataSource = query.ToList()

    End Sub

    'All text files will display in ascending order

    Private Sub mnuAll_Click(sender As Object, e As EventArgs) Handles mnuAll.Click
        mnuAscending.Checked = True
        mnuDescending.Checked = False

        If mnuAscending.Checked Then

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        Else

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        End If


    End Sub

    'Only text files located in Europe will display

    Private Sub mnuEurope_Click(sender As Object, e As EventArgs) Handles mnuEurope.Click
        mnuEurope.Checked = True
        mnuMiddleEast.Checked = False
        mnuSouthAmerica.Checked = False
        mnuUnitedStates.Checked = False
        mnuAll.Checked = False



        'If ascending is not checked the text files will display in descending order
        If mnuAscending.Checked Then

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "Europe"
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        Else

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "Europe"
                Order By Last Descending
                Select Last, First, State, Age, YearsOfService, Location

            'Display text files located in Europe
            dgvDisplay.DataSource = query.ToList()

        End If


    End Sub

    'Only text files located in the Middle East will display
    Private Sub mnuMiddleEast_Click(sender As Object, e As EventArgs) Handles mnuMiddleEast.Click
        mnuMiddleEast.Checked = True
        mnuEurope.Checked = False
        mnuSouthAmerica.Checked = False
        mnuUnitedStates.Checked = False
        mnuAll.Checked = False


        'If ascending is not checked the text files will display in descending order
        If mnuAscending.Checked Then

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "Middle East"
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        Else

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "Middle East"
                Order By Last Descending
                Select Last, First, State, Age, YearsOfService, Location

            'Display text files located in Middle East
            dgvDisplay.DataSource = query.ToList()

        End If

    End Sub

    'Only text files located in South America will display
    Private Sub mnuSouthAmerica_Click(sender As Object, e As EventArgs) Handles mnuSouthAmerica.Click
        mnuSouthAmerica.Checked = True
        mnuEurope.Checked = False
        mnuMiddleEast.Checked = False
        mnuUnitedStates.Checked = False
        mnuAll.Checked = False


        'If ascending is not checked the text files will display in descending order
        If mnuAscending.Checked Then


            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "South America"
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        Else

            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "South America"
                Order By Last Descending
                Select Last, First, State, Age, YearsOfService, Location

            'Display text files located in South America
            dgvDisplay.DataSource = query.ToList()

        End If

    End Sub

    'Text files located in the United States will display
    Private Sub mnuUnitedStates_Click(sender As Object, e As EventArgs) Handles mnuUnitedStates.Click
        mnuUnitedStates.Checked = True
        mnuEurope.Checked = False
        mnuMiddleEast.Checked = False
        mnuSouthAmerica.Checked = False
        mnuAll.Checked = False


        'If ascending is not checked the text files will display in descending order
        If mnuAscending.Checked Then


            Dim query = From line In missionsArray
                Let Last = line.Split(","c)(0)
                Let First = line.Split(","c)(1)
                Let State = line.Split(","c)(2)
                Let Age = line.Split(","c)(3)
                Let YearsOfService = line.Split(","c)(4)
                Let Location = line.Split(","c)(5)
                Where Location = "United States"
                Order By Last Ascending
                Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        Else
            Dim query = From line In missionsArray
              Let Last = line.Split(","c)(0)
              Let First = line.Split(","c)(1)
              Let State = line.Split(","c)(2)
              Let Age = line.Split(","c)(3)
              Let YearsOfService = line.Split(","c)(4)
              Let Location = line.Split(","c)(5)
              Where Location = "United States"
              Order By Last Descending
              Select Last, First, State, Age, YearsOfService, Location

            dgvDisplay.DataSource = query.ToList()

        End If


    End Sub

    'user will be prompted to input last name to search

    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click

        Dim searchCriteria
        'Ask for last name
        searchCriteria = InputBox("Enter last name")

        Dim query = From line In missionsArray
              Let Last = line.Split(","c)(0)
              Let First = line.Split(","c)(1)
              Let State = line.Split(","c)(2)
              Let Age = line.Split(","c)(3)
              Let YearsOfService = line.Split(","c)(4)
              Let Location = line.Split(","c)(5)
              Where Last = searchCriteria
              Select Last, First, State, Age, YearsOfService, Location

        dgvDisplay.DataSource = query.ToList()

    End Sub


    'Exit out of application when clicked
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

End Class
