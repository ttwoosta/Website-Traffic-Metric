' Program Name: Website Traffic Metric
' Author:       Tu Tong
' Date:         November 11, 2017
' Purpose:      This Website Traffic Metric application find a average time
'               in seconds spent on the opening page of a company's website,
'               also called website traffic metrics or analytics. This market
'               research is used to improve the effectiveness of the site


' Turn off automatic conversion for values
Option Strict On

Public Class frmWebsiteTraffic

    '
    ' Summary:
    '     Indicates which value type of the input message
    Enum InputBoxResult
        Positive = 1
        Negative = -1
        Cancelled = -2
        NonNumeric = -3
    End Enum

    ' Summary:
    '     Returns a InputBoxResult value indicating input message string
    '     can be converted to a number or it's a non-numeric string
    '     or Cancel button clicked.
    ' Parameters:
    '     InputMessage:
    '       Required. string input message
    ' Returns:
    '     Returns a InputBoxResult value indicating input message string 
    '     can be converted To a positive number.
    Function convertToInputBoxResult(InputMessage As String) As InputBoxResult

        If InputMessage = "" Then
            Return InputBoxResult.Cancelled
        End If

        If IsNumeric(InputMessage) Then

            ' Validate that the entered value is a positive number
            If Convert.ToDecimal(InputMessage) > 0 Then
                Return InputBoxResult.Positive
            End If

            Return InputBoxResult.Negative
        End If

        Return InputBoxResult.NonNumeric
    End Function

    Private Sub btnVisitorAnalytics_Click(sender As Object, e As EventArgs) Handles btnVisitorAnalytics.Click
        ' The btnVisitorAnalytics_click event handler accepts and displays 
        ' up to 12 values of time in seconds spent on the opening webpage
        ' and then calculates and displays the average time spent

        ' Declare and initialize variables
        Dim strTimeEntered As String
        Dim intTimeEntered As Integer
        Dim decAverageTimeSpent As Decimal
        Dim decTotalTimeSpent As Decimal = 0D

        ' Declare message box constants
        Const cstrInputHeading As String = "Time spents"
        Const cstrNormalMessage As String = "Enter the time spent in seconds for visitor #"
        Const cstrNonNumericError As String = "Error - Enter a number for the time spent in seconds of visitor #"
        Const cstrNegativeError As String = "Error - Enter a positive number for the time spent in seconds of visitor #"

        ' Declare and initialize variables that
        ' use with the Input Box funciton call
        Dim strInputMessage As String = cstrNormalMessage
        Dim ipbResult As InputBoxResult

        Const cintMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 0

        ' This Do...Until loop allows the user enter the time spent in seconds
        ' up to 12 visitors. The loop terminates when the user has entered 12
        ' time values or the user clicks the Cancel button or Close button in
        ' the InputBox dialog
        Do Until intNumberOfEntries >= cintMaxNumberOfEntries

            ' Display the InputBox if the number of entries entered less than 12
            strTimeEntered = InputBox(strInputMessage & intNumberOfEntries + 1, cstrInputHeading, " ")

            ' convert time spent string entered to InputBoxResult
            ipbResult = convertToInputBoxResult(strTimeEntered)

            Select Case ipbResult
                Case InputBoxResult.Positive

                    ' convert the value entered from a string 
                    ' to the integer data type
                    intTimeEntered = Convert.ToInt32(strTimeEntered)

                    ' perform the processing when the user 
                    ' enters a valid time value
                    lstVisitorData.Items.Add(intTimeEntered)
                    decTotalTimeSpent += intTimeEntered
                    intNumberOfEntries += 1
                    strInputMessage = cstrNormalMessage

                Case InputBoxResult.Negative
                    ' Assign an error message if the user
                    ' enters a negative time value
                    strInputMessage = cstrNegativeError

                Case InputBoxResult.NonNumeric
                    ' Assign an error message if the user
                    ' enters a non numeric in the input box
                    strInputMessage = cstrNonNumericError

                Case InputBoxResult.Cancelled
                    ' terminate the Do...Until loop
                    ' if user clicks the Cancel button
                    Exit Do

            End Select

        Loop


        If intNumberOfEntries > 0 Then
            ' Calculate and display the average time spent
            decAverageTimeSpent = decTotalTimeSpent / intNumberOfEntries

            ' display the average time spent
            lblAverageTimeSpentLabel.Visible = True
            lblAverageTimeSpent.Visible = True
            lblAverageTimeSpent.Text = decAverageTimeSpent.ToString("F2") & " seconds"

        Else
            ' user did not enter any value
            MsgBox("No time spent in seconds value entered")

        End If

    End Sub
End Class
