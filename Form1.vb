Public Class Form1
    ' Declare intGuess as an integer
    Dim intGuess As Integer

    ' Declare a variable to assign the random number to
    Dim intRandomNumber As Integer

    ' Declare a loop counter variable to hold the number of attempts until correct answer is guessed and its values are added to Accumulator variable
    Dim intCount As Integer

    ' Declare an Accumulator variable to hold the number of total attempts the user made
    Dim intTotal As Integer

    ' Declare and create a randomn number
    Dim rand As New Random
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Assign a random integer in the range of 1 To 100 to the variable

        intCount = intCount + 1
        ' Assign input of txtGuessBox to intGuess
        intGuess = CInt(txtGuessBox.Text)

        If intGuess = intRandomNumber Then
            ' If its correct make place intCount into intTotal variable
            lblMessage.Text = ("BINGO! It took you " & intCount & " attempt(s)")
        Else
            If intGuess > intRandomNumber Then
                lblMessage.Text = ("Too high, try again.")
                ' Increment the intCount for each loop
                intCount = intCount + 1
            Else
                lblMessage.Text = ("Too low, try again.")
                ' Increment the intCount for each loop
                intCount = intCount + 1
            End If
        End If
    End Sub
End Class
