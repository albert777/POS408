﻿

Public Class frmAppliance
    'Author: Michael Lender

    'FileName Lender_POS_Individual_WK2_v2.3

    '    The user should be able to accomplish the following:
    'Enter the cost per kilowatt-hour.
    'Select from a list of home appliances which includes appliances.
    'Refrigerator
    'TV
    'Space Heater
    'Fan
    'Dryer
    'Oven
    'Enter the power needed in kilowatts (kW) for the selected appliance.
    'Enter the number of hours used per day for the selected appliance.
    'If the washer is selected, enter both the number of gallons of water used by the washer per hour and the cost per gallon.
    'The program should do the following:
    'Validate that the data entered has the correct format, and is within a reasonable range.
    'Calculate and display the cost for operating a home appliance as soon as the data is entered.
    'Create a listing area to display each of the following for each appliance entered:
    'Home appliance
    'Number of hours per day
    'Cost
    'Display and update the total cost of all appliances, as soon as a new entry is added to the listing area.

    'June 24, 2016
    'Declares variables for calculation purposes


    '*****If adding any statements or calculations that go off of selecteditem values for lstAppliance, take note of the number of spaces
    'at the end of each item.  Spaces are put in place to allow the vbtab to properly line up columns without making the lstOutput field too wide
    'for application*******

    Dim dblKwhCost As Double

    Dim dblKwh As Double

    Dim dblHoursUsed As Double

    Dim dblTotal As Double

    Dim dblGallons As Double

    Dim dblGallonCost As Double

    Dim dblDailyTotal As Double

    Dim i As Integer = 0

    Dim strDefault As String

    Dim intLine As Integer

    Dim intSelectedAppliance As Integer

    'Reads defaults.txt into array for the auto selection of default kWh values
    Dim lines() As String = System.IO.File.ReadAllLines("defaults.txt")

    

    'Sets default values of text boxes to "0" when the form is loaded
    Public Sub frmAppliance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeControls()
        '****this feature will be added in a future version.  the purpose of this is to allow the user to select the desired default value file.  For now it is commented out
        'it currently works but there is a Known issue loading anything other than a file named defaults on start.  The next version upgrade will enable this feature*****


        'Prompts user to select the default power rating file.  
        'MessageBox.Show("Please Select a default power rating file path before proceeding.  If you do not know what you are doing, DO NOT select a file other than Defaults.txt, the defaults you save will not load next time you open the application.")

        'Opens the open file dialog to allow user to select the default file for default ratings.  Having the user select the default file means they can save the application
        'and the default file stored in any folder and have the computer find them so long as they are together.  
        'If lblFilePath.Text = "Defaults.txt" Then

        'Dim openFilePath As New OpenFileDialog()
        ''Sets the default file location to the debug folder
        'openfileFilePath.InitialDirectory = "\bin\debug"
        'openfileFilePath.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'openfileFilePath.FilterIndex = 2
        'openfileFilePath.RestoreDirectory = True
        'Me.Show()


        'End If

        'If openfileFilePath.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '    'lblfilepath.text is changed to the file path of the selected database
        '    lblFilePath.Text = openfileFilePath.FileName
        'End If

        'Sets dblDailyTotal to 0 on form load
        dblDailyTotal = 0

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Try Catch statement added to prevent user from entering multiple decimal points and crashing the application due to the 
        'text box entry not being valid
        Try
            'Converts txtKwhCost to a double so that the input data in the textbox is now a number and can be used in calculations
            dblKwhCost = CDbl(txtKwhCost.Text)

            'Converts txtKwh to a double so that the input data in the textbox is now a number and can be used in calculations
            dblKwh = CDbl(txtKwh.Text)

            'Converts txtHoursUsedto a double so that the input data in the textbox is now a number and can be used in calculations
            dblHoursUsed = CDbl(txtHoursUsed.Text)

            'Converts txtGallonCost Decimal so that the input data in the textbox is now a number and can be used in calculations.  Visual studios design properties are used to ensure 
            'user only enters a maximum of 5 characters, including the decimal point
            dblGallonCost = CDec(txtGallonCost.Text)

            'Converts txtGallons to a double so that the input data in the textbox is now a number and can be used in calculations
            dblGallons = CDbl(txtGallons.Text)

            'Verifies that an item is selected from the appliance list
            If lstAppliance.SelectedIndex = -1 Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please Select an appliance from the list")

                'Verifies that dblKwhCost is between .01 and .99
            ElseIf dblKwhCost < 0.01 Or dblKwhCost > 0.99 Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please enter a Cost Per kWh Greater than or equal to .01 and less than .99")

                'Verifies that the dblKwh is between .01 and 30
            ElseIf (dblKwh <= 0 Or dblKwh > 30) Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please enter a kWh value between 0 and 30 ")

                'Verifies that dblHours used is between 0 and 24
            ElseIf (dblHoursUsed <= 0 Or dblHoursUsed > 24) Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please Enter daily hours used between 0 and 24")

                'Verifies that dblGallons is between 0 and 50
            ElseIf lstAppliance.SelectedItem.ToString.Trim() = "Washer" And dblGallons <= 0 Or dblGallons >= 50 Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please Enter Gallons Used Per Hour between 0 and 50")

                'Verifies that intGallonCost is between .001 and .01
            ElseIf lstAppliance.SelectedItem.ToString.Trim() = "Washer" And dblGallonCost < 0.001 Or dblGallonCost > 0.01 Then

                'Beep() plays audible error tone to help alert the user that there is an error
                Beep()
                MessageBox.Show("Please Enter per gallon cost .001 and .01")

                'If all textboxes validate, the calculation is run and the total cost is displayed to the user
            Else

                'Math includes the water cost because if washer isn't selected, the value will be 0 and that doesn't change the total for other appliance types
                dblTotal = (dblKwhCost * dblKwh * dblHoursUsed) + (dblGallons * dblGallonCost * dblHoursUsed)


                dblDailyTotal = dblDailyTotal + dblTotal

                txtDailyCost.Text = dblDailyTotal.ToString("c")

                txtTotalCost.Text = dblTotal.ToString("c")





                'Inserts daily cost for all appliances to the top of lstOutput for saving in text file
                lstOutput.Items.Insert(0, ("              Daily Cost For All Appliances " & vbTab & txtDailyCost.Text.ToString()))

                lstOutput.Items.Add(lstAppliance.SelectedItem.ToString() & vbTab & "Hours Used" & vbTab & dblHoursUsed.ToString & vbTab & "Cost " & dblTotal.ToString("c"))
                txtKwhCost.Text = "0"
                txtKwh.Text = "0"
                txtHoursUsed.Text = "0"
                txtGallonCost.Text = "0"

                lstAppliance.SelectedIndex = 0

            End If

            'If Statement added to remove the old txt.TotalCost item in lstOutput and ensure that only one
            'copy of lstOutput is at the top of the lstOutput at index 0.  without this, the txtTotalCost was added 
            'to index 0 of lstOutput and created multiple Total Cost entries in the lstOutput.  If statement only 
            'triggers on the second and subsequent calculations
            If lstOutput.Items.Count > 2 Then
                lstOutput.Items.RemoveAt(1)
            End If

        Catch ex As Exception
            'Beep() plays audible error tone to help alert the user that there is an error
            'Catch is to prevent crash.  it alerts the user what they need to do for each text box
            Beep()
            MessageBox.Show("Please enter a valid number in text boxes.  Take care to verify that you did not enter more than one decimal point per box.  Please enter numbers or a single '.' only.  " & ex.Message)



        Finally

        End Try

    End Sub
    'Validates input so that only numbers or a "." can be entered in the text box and also allows the user to use the backspace key to correct their input if they make a mistake
    'All other keystrokes will be ignored
    'Mead, G. (2009). How to Restrict TextBox Input. Retrieved from http://vbcity.com/blogs/xtab/archive/2009/06/08/restrictiong-textbox-input.aspx
    Private Sub txtKwhCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKwhCost.KeyPress, txtKwh.KeyPress, txtHoursUsed.KeyPress, txtGallons.KeyPress, txtGallonCost.KeyPress
        e.Handled = True

        If e.KeyChar Like "[.1234567890]" _
            Or e.KeyChar = Chr(&H8) Then
            'following code instructs the application to not accept the keystroke because it does not match the required input range
            e.Handled = False
        Else
            'Beep() plays audible error tone to help alert the user that there is an error
            Beep()
            MessageBox.Show("Please enter numbers or a '.' only. ")


        End If
    End Sub





    'Closes Application when the user clicks Close

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    'Clears form by calling InitializeControls(), which sets all textboxes to 0, resets lstOutput and sets appliance to the top of the list
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        InitializeControls()

    End Sub

    'Checks to see if a null value is entered in txtKwhCost when focus is lost on txtKwhCost.  If a null value is present, the field is reset to 0.  The keystroke verification
    'prevents spaces from being left so no check needs to be done for spaces as there is no way to put a space in the textbox.  This code is neccesary because
    'the backspace key creates a potential situation that would allow the user to delete the default 0 and leave a null value, crashing the program on btnCalculate execution
    Private Sub txtKwhCost_LostFocus(sender As Object, e As EventArgs) Handles txtKwhCost.LostFocus
        If txtKwhCost.Text = "" Then
            txtKwhCost.Text = "0"


        End If
    End Sub
    'Checks to see if a null value is entered in txtKwh when focus is lost on txtKwh.  If a null value is present, the field is reset to 0.  The keystroke verification
    'prevents spaces from being left so no check needs to be done for spaces as there is no way to put a space in the textbox.  This code is neccesary because
    'the backspace key creates a potential situation that would allow the user to delete the default 0 and leave a null value, crashing the program on btnCalculate execution
    Private Sub txtKwh_LostFocus(sender As Object, e As EventArgs) Handles txtKwh.LostFocus
        If txtKwh.Text = "" Then
            txtKwh.Text = "0"


        End If
    End Sub
    'Checks to see if a null value is entered in txtHoursUsed when focus is lost on txtHoursUsed.  If a null value is present, the field is reset to 0.  The keystroke verification
    'prevents spaces from being left so no check needs to be done for spaces as there is no way to put a space in the textbox.  This code is neccesary because
    'the backspace key creates a potential situation that would allow the user to delete the default 0 and leave a null value, crashing the program on btnCalculate execution
    Private Sub txtHoursUsed_LostFocus(sender As Object, e As EventArgs) Handles txtHoursUsed.LostFocus
        If txtHoursUsed.Text = "" Then
            txtHoursUsed.Text = "0"


        End If
    End Sub

    'Checks to see if a null value is entered in txtGallons when focus is lost on txtGallons.  If a null value is present, the field is reset to 0.  The keystroke verification
    'prevents spaces from being left so no check needs to be done for spaces as there is no way to put a space in the textbox.  This code is neccesary because
    'the backspace key creates a potential situation that would allow the user to delete the default 0 and leave a null value, crashing the program on btnCalculate execution
    Private Sub txtGallons_LostFocus(sender As Object, e As EventArgs) Handles txtGallons.LostFocus
        If txtGallons.Text = "" Then
            txtGallons.Text = "0"


        End If
    End Sub
    'Checks to see if a null value is entered in txtGallonCost when focus is lost on txtGallonCost.  If a null value is present, the field is reset to 0.  The keystroke verification
    'prevents spaces from being left so no check needs to be done for spaces as there is no way to put a space in the textbox.  This code is neccesary because
    'the backspace key creates a potential situation that would allow the user to delete the default 0 and leave a null value, crashing the program on btnCalculate execution
    Private Sub txtGallonCost_LostFocus(sender As Object, e As EventArgs) Handles txtGallonCost.LostFocus
        If txtGallonCost.Text = "" Then
            txtGallonCost.Text = "0"


        End If
    End Sub


    Private Sub InitializeControls()
        'Sets all values to zero for text boxes, dblDailyTotal and dblTotal as well as sets lstAppliance to index 0
        'Also resets the text on the lblDailyCost and lblTotalCost
        'Used on startup and when the form is cleared.  
        

        txtKwhCost.Text = "0"
        txtKwh.Text = "0"
        txtHoursUsed.Text = "0"
        txtGallonCost.Text = "0"
        txtGallons.Text = "0"
        txtGallons.Text = "0"
        txtTotalCost.Text = "0"
        txtDailyCost.Text = "0"
        
        lstAppliance.SelectedIndex = 0
        dblDailyTotal = 0
        dblTotal = 0
        lstOutput.Items.Clear()

    End Sub

   
    'Determines if washer was selected.  If washer is selected the user is instructed to enter gallons used per hour and cost per gallon
    'If the user selects washer, enters values and then changes the appliance to anything other than washer, txtGallonCost and txtGallons are set to 0 
    'to prevent the calculation from being performed with water values for an appliance that doesn't need them
    Public Sub lstAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAppliance.SelectedIndexChanged
      

        If lstAppliance.SelectedItem.ToString.Trim() = "Washer" Then
            txtGallonCost.Enabled = True
            txtGallons.Enabled = True
        Else : txtGallonCost.Enabled = False
            txtGallons.Enabled = False
            txtGallonCost.Text = "0"
            txtGallons.Text = "0"

        End If



        'intSelectedAppliance = lstAppliance.SelectedIndex


    End Sub

    'ContextMenustrip added to prevent users from pasting non allowed characters into the textboxes by right clicking and selecting paste.
    'copy function allowed to stay in case the user wants to copy a number for whatever reason they have.  The keypress code earlier in the
    ' form prevents the user from using ctrl V.  Try catch that is in the btnCalculate code is still needed to prevent multiple "." from being entered

    Private Sub CopyToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
    End Sub



    Public Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Calls the saveDialog to allow the user to save the output of the lstAppliance box

        'Filter is in place to default to text file
        saveDialog.Filter = "TXT Files (*.txt*)|*.txt"
        If saveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            'If the user clicks ok on save file the data is written to the file
            Dim lines(lstOutput.Items.Count - 1) As String
            lstOutput.Items.CopyTo(lines, 0)
            IO.File.WriteAllLines(saveDialog.FileName, lines)

        End If

    End Sub



    Public Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        'Converts txtKwh to a double so that the input data in the textbox is now a number and can be used in calculations
        dblKwh = CDbl(txtKwh.Text)
        'Dim lines() As String = System.IO.File.ReadAllLines("defaults.txt")
        If (dblKwh <= 0 Or dblKwh > 30) Then

            'Beep() plays audible error tone to help alert the user that there is an error
            Beep()
            MessageBox.Show("Please enter a Kwh value between 0 and 30 ")
        Else
            'sets value of intline to the index number of the selected item.  this allows the application to know
            'which line to save the default rating to so that it can read it next time the application is used
            intLine = lstAppliance.SelectedIndex

            'allows the app to know what was in the textbox for txtKwh.text so it can write it to file
            lines(intLine) = txtKwh.Text

            'actually writes the value to the file set in 
            System.IO.File.WriteAllLines(lblFilePath.Text, lines)
            'file path for the default file is \Lender_pos408_Individual_WK2_v2\Lender_pos408_Individual_WK2_v2\bin\defaults.txt
        End If
    End Sub






    Private Sub lstAppliance_LostFocus(sender As Object, e As EventArgs) Handles lstAppliance.LostFocus
        'This whole sub was put in lost focus so that the user could set a default value and save it 
        'and still have it load next time they picked that applicance without having to exit the application due to it loading during form load 
        'Points the filestream to the filepath set in lblfilepath in the open file dialog when the app was started  Coded this way to allow for a future
        'version to allow the user to choose their default file and save it anywhere they want.  It will work in conjunction with an open file dialog that will alter the 
        'lblFilePath.text and all the code will still work.  
        Dim fsDefaults As New System.IO.FileStream(lblFilePath.Text, IO.FileMode.Open)

        'Reads the file that fsDefaults opened
        Dim srDefaults As New System.IO.StreamReader(fsDefaults)

        'Creates a list of data from the streamreader in an array
        Dim List As New List(Of String)
        'keeps reading lines from the file until an empty line is hit
        Do While srDefaults.Peek >= 0
            List.Add(srDefaults.ReadLine)
        Loop

        Dim arrDefaults As String() = List.ToArray

        fsDefaults.Close()

        srDefaults.Close()


        fsDefaults = New System.IO.FileStream(lblFilePath.Text, IO.FileMode.Open)

        srDefaults = New System.IO.StreamReader(fsDefaults)
        'Creates an array arrStream as a string
        Dim arrStream As String()
        'Sets Index as 0 for counting
        Dim Index As Integer = 0

        'Performs loop until all items are loaded
        Do While srDefaults.Peek >= 0
            'Preserves previous data so that it isn't overwritten as the string is read into the array
            ReDim Preserve arrStream(Index)
            arrStream(Index) = srDefaults.ReadLine
            'Counter
            Index += 1
        Loop

        'Closes the 
        'fsDefaults.Close()

        fsDefaults.Close()
        'ArrString shows a warning in visual studio but is not an issue.  arrStream gets it's index from the selected index in lstAppliance
        'The Selected index ensures that the txtKwh is directed to the correct line in the array
        txtKwh.Text = arrStream(lstAppliance.SelectedIndex)
    End Sub
End Class