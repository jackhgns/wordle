Public Class frmGame
    Dim arrKeyboard(28) As Button
    Dim arrWordInterface(5, 6) As Label
    Dim userInputTemp As String
    Dim userInput As String
    Dim attemptNumber As Integer
    Dim roundNumber As Integer
    Dim inputList(12946) As String
    Dim wordleList(2314) As String
    Dim chosenWord As String
    Dim result(4) As Integer
    Dim winStreak As Integer
    Dim wins As Integer

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup()
    End Sub

    Private Sub setup()
        'Setup the interface
        initialiseKeyboardArray()
        setupWordInterface()
        setKeyboardButtonLabels()

        lblPlayerName.Text = playerName
        inputList = getInputList()
        wordleList = getWordleList()

        game(wordleList, inputList)
        roundNumber = 1
    End Sub

    Private Sub game(ByRef wordleList() As String, ByRef inputList() As String)
        chosenWord = chooseAnswer(wordleList)
        lstOutput.Items.Add(chosenWord)
        attemptNumber = 1
        userInput = ""
        userInputTemp = ""
    End Sub

    Private Sub attempt(userInput As String)
        Dim resultString As String

        'Get the result
        result = guessAnswer(userInput, chosenWord, attemptNumber, inputList)
        resultString = String.Join("", result)
        attemptNumber = attemptNumber + 1

        userInput = ""
        userInputTemp = ""

        'When the round finishes...
        If attemptNumber > 6 Or resultString = "22222" Then
            updateScore(resultString, attemptNumber, chosenWord)
            resetGame()
        End If
    End Sub

    Private Sub resetGame()
        setupWordInterface()
        setKeyboardButtonLabels()
        game(wordleList, inputList)
    End Sub

    Private Sub initialiseKeyboardArray() 'Taken from the in-class activity: Hangman
        arrKeyboard(1) = btnA
        arrKeyboard(2) = btnB
        arrKeyboard(3) = btnC
        arrKeyboard(4) = btnD
        arrKeyboard(5) = btnE
        arrKeyboard(6) = btnF
        arrKeyboard(7) = btnG
        arrKeyboard(8) = btnH
        arrKeyboard(9) = btnI
        arrKeyboard(10) = btnJ
        arrKeyboard(11) = btnK
        arrKeyboard(12) = btnL
        arrKeyboard(13) = btnM
        arrKeyboard(14) = btnN
        arrKeyboard(15) = btnO
        arrKeyboard(16) = btnP
        arrKeyboard(17) = btnQ
        arrKeyboard(18) = btnR
        arrKeyboard(19) = btnS
        arrKeyboard(20) = btnT
        arrKeyboard(21) = btnU
        arrKeyboard(22) = btnV
        arrKeyboard(23) = btnW
        arrKeyboard(24) = btnX
        arrKeyboard(25) = btnY
        arrKeyboard(26) = btnZ
        arrKeyboard(27) = btnDelete
        arrKeyboard(28) = btnEnter
    End Sub

    Private Sub setKeyboardButtonLabels() 'Taken from the in-class activity: Hangman
        For i = 1 To 26
            arrKeyboard(i).BackColor = Color.FromArgb(240, 240, 240)
            arrKeyboard(i).Text = Strings.Chr(i + 64)
        Next i

        arrKeyboard(27).BackColor = Color.FromArgb(240, 240, 240)
        arrKeyboard(28).BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub setupWordInterface()
        arrWordInterface(1, 1) = lbl1
        arrWordInterface(2, 1) = lbl2
        arrWordInterface(3, 1) = lbl3
        arrWordInterface(4, 1) = lbl4
        arrWordInterface(5, 1) = lbl5
        arrWordInterface(1, 2) = lbl6
        arrWordInterface(2, 2) = lbl7
        arrWordInterface(3, 2) = lbl8
        arrWordInterface(4, 2) = lbl9
        arrWordInterface(5, 2) = lbl10
        arrWordInterface(1, 3) = lbl11
        arrWordInterface(2, 3) = lbl12
        arrWordInterface(3, 3) = lbl13
        arrWordInterface(4, 3) = lbl14
        arrWordInterface(5, 3) = lbl15
        arrWordInterface(1, 4) = lbl16
        arrWordInterface(2, 4) = lbl17
        arrWordInterface(3, 4) = lbl18
        arrWordInterface(4, 4) = lbl19
        arrWordInterface(5, 4) = lbl20
        arrWordInterface(1, 5) = lbl21
        arrWordInterface(2, 5) = lbl22
        arrWordInterface(3, 5) = lbl23
        arrWordInterface(4, 5) = lbl24
        arrWordInterface(5, 5) = lbl25
        arrWordInterface(1, 6) = lbl26
        arrWordInterface(2, 6) = lbl27
        arrWordInterface(3, 6) = lbl28
        arrWordInterface(4, 6) = lbl29
        arrWordInterface(5, 6) = lbl30

        For x = 1 To 5
            For y = 1 To 6
                arrWordInterface(x, y).Text = ""
                arrWordInterface(x, y).BackColor = Color.FromArgb(255, 255, 255)
                arrWordInterface(x, y).AutoSize = False
            Next y
        Next x
    End Sub

    Private Function getInputList() As String()
        Dim i As Integer
        Dim inputListTemp(0) As String
        Dim inputList(12946) As String

        FileSystem.FileOpen(1, "inputList.txt", OpenMode.Input) 'List taken from https://github.com/tabatkins/wordle-list/blob/main/words
        For i = 0 To 0
            FileSystem.Input(1, inputListTemp(i))
        Next i
        FileSystem.FileClose(1)

        inputList = Split(inputListTemp(0))

        Return inputList
    End Function

    Private Function getWordleList() As String()
        Dim i As Integer
        Dim wordleListTemp(0) As String
        Dim wordleList(2314) As String

        FileSystem.FileOpen(1, "wordleList.txt", OpenMode.Input) 'List taken from https://gist.github.com/cfreshman/cdcdf777450c5b5301e439061d29694c
        For i = 0 To 0
            FileSystem.Input(1, wordleListTemp(i))
        Next i
        FileSystem.FileClose(1)

        wordleList = Split(wordleListTemp(0))

        Return wordleList
    End Function

    Private Function chooseAnswer(wordleList()) As String
        Dim chosenWord As String
        Dim randomInt As Integer

        Randomize()
        randomInt = RandBetween(0, 2314)
        chosenWord = wordleList(randomInt)

        Return chosenWord
    End Function

    Public Function RandBetween(Low As Integer, High As Integer) As Integer
        RandBetween = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Private Sub getLetterKeyPresses(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        Dim letter As String

        If userInputTemp.Length <= 4 Then
            letter = Strings.Right(sender.name, 1)
            userInputTemp = userInputTemp & letter
            arrWordInterface(userInputTemp.Length, attemptNumber).Text = letter
        End If
    End Sub

    Private Sub getEnterKeyPress(sender As Object, e As EventArgs) Handles btnEnter.Click
        userInput = userInputTemp.ToLower
        attempt(userInput)
    End Sub

    Private Sub getDeleteKeyPress(sender As Object, e As EventArgs) Handles btnDelete.Click
        If userInputTemp.Length > 0 Then
            arrWordInterface(userInputTemp.Length, attemptNumber).Text = ""
            userInputTemp = userInputTemp.Trim().Remove(userInputTemp.Length - 1) 'Taken from https://stackoverflow.com/questions/2724487/trim-last-delimiter-of-a-string-in-vb-netEnd
        End If
    End Sub

    Public Function guessAnswer(ByVal userInput As String, ByVal chosenWord As String, ByRef attemptNumber As Integer, inputList() As String) As Integer()
        Dim inputValidation As Boolean
        Dim wordValidation As Boolean

        inputValidation = checkValidInput(userInput)
        wordValidation = checkValidWord(userInput, inputList)

        If inputValidation = False Then
            MsgBox("The word must be 5 letters.")
            clearLineDisplay(attemptNumber)
            attemptNumber = attemptNumber - 1
            result = {0, 0, 0, 0, 0}
        ElseIf wordValidation = False Then
            MsgBox("Word not found.")
            clearLineDisplay(attemptNumber)
            attemptNumber = attemptNumber - 1
            result = {0, 0, 0, 0, 0}
        Else
            result = checkLetters(chosenWord, userInput)
            updateDisplay(result, attemptNumber, userInput)
        End If

        Return result
    End Function

    Private Function checkValidInput(userInput As String) As Boolean
        Dim validation As Boolean

        If userInput.Length = 5 Then
            For i = 0 To 4
                Select Case userInput(i)
                    Case "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z"
                        validation = True
                    Case Else
                        validation = False
                        Exit For
                End Select
            Next i
        Else
            validation = False
        End If

        Return validation
    End Function

    Private Function checkValidWord(userInput As String, inputList() As String) As Boolean
        Dim validation As Boolean

        If inputList.Contains(userInput) Then
            validation = True
        Else
            validation = False
        End If

        Return validation
    End Function

    Private Function checkLetters(ByVal chosenWord As String, ByVal userInput As String) As Integer()
        Dim resultString As String
        Dim memoryList(4) As String

        memoryList = {" ", " ", " ", " ", " "}
        result = {0, 0, 0, 0, 0}

        For i = 0 To 4
            If chosenWord(i) = userInput(i) Then
                result(i) = 2
                memoryList(i) = userInput(i)
            Else
                result(i) = 0
            End If
        Next i

        For i = 0 To 4
            If chosenWord(i) <> userInput(i) And chosenWord.Contains(userInput(i)) Then
                result(i) = processDuplicates(chosenWord, i, userInput, memoryList)
            End If
        Next i

        memoryList = {" ", " ", " ", " ", " "}
        resultString = String.Join("", result)

        Return result
    End Function

    Private Function processDuplicates(ByVal chosenWord As String, ByVal i As Integer, userInput As String, ByRef memoryList As String()) As Integer
        Dim letterResult As Integer
        Dim memoryListStr As String
        Dim inputFreq As Integer
        Dim chosenFreq As Integer
        Dim memoryFreq As Integer

        inputFreq = checkFrequency(userInput, userInput(i))
        chosenFreq = checkFrequency(chosenWord, userInput(i))
        memoryListStr = String.Join("", memoryList)
        memoryFreq = checkFrequency(memoryListStr, userInput(i))

        If inputFreq = 1 Then
            letterResult = 1
        Else
            If memoryFreq >= chosenFreq Then
                letterResult = 0
            Else
                letterResult = 1
                memoryList(i) = userInput(i)
            End If
        End If

        Return letterResult
    End Function

    Private Function checkFrequency(input As String, letter As String) As Integer
        Dim frequency As Integer

        frequency = 0

        For i = 0 To 4
            If input(i) = letter Then
                frequency = frequency + 1
            End If
        Next i

        Return frequency
    End Function

    Private Sub updateDisplay(result As Integer(), attemptNumber As String, userInput As String)
        Dim tempLetter As String
        Dim tempLetterDigit As Integer

        For x = 1 To 5
            tempLetter = userInput(x - 1)
            tempLetterDigit = Asc(tempLetter) - 96 'Converts letters to digits (e.g. A -> 1, Z -> 26)
            arrWordInterface(x, attemptNumber).Text = tempLetter.ToUpper

            'Set background colours and checks to highlight the best colour for each letter key.
            If result(x - 1) = 2 Then
                arrWordInterface(x, attemptNumber).BackColor = Color.FromArgb(0, 240, 0)
                arrKeyboard(tempLetterDigit).BackColor = Color.FromArgb(0, 240, 0)
            ElseIf result(x - 1) = 1 Then
                arrWordInterface(x, attemptNumber).BackColor = Color.FromArgb(230, 230, 0)

                If arrKeyboard(tempLetterDigit).BackColor <> Color.FromArgb(0, 240, 0) Then
                    arrKeyboard(tempLetterDigit).BackColor = Color.FromArgb(230, 230, 0)
                End If
            Else
                arrWordInterface(x, attemptNumber).BackColor = Color.FromArgb(210, 210, 210)

                If arrKeyboard(tempLetterDigit).BackColor <> Color.FromArgb(0, 240, 0) And arrKeyboard(tempLetterDigit).BackColor <> Color.FromArgb(230, 230, 0) Then
                    arrKeyboard(tempLetterDigit).BackColor = Color.FromArgb(210, 210, 210)
                End If
            End If
        Next x
    End Sub

    Private Sub clearLineDisplay(attemptNumber As Integer)
        For x = 1 To 5
            arrWordInterface(x, attemptNumber).Text = ""
        Next
    End Sub

    Private Sub updateScore(resultString As String, attemptNumber As Integer, chosenWord As String)
        Dim winFlag As Boolean

        If resultString = "22222" And attemptNumber <= 6 Then
            winFlag = True
            MsgBox("You win!")
        Else
            winFlag = False
            MsgBox("The word was " & chosenWord & ".")
        End If

        roundNumber = updateGamesPlayed(roundNumber)
        winStreak = updateWinStreak(winStreak, winFlag)
        wins = updateWins(wins, winFlag)

        displayScore(wins, winStreak, roundNumber)
    End Sub

    Private Function updateGamesPlayed(roundNumber As Integer) As Integer
        roundNumber = roundNumber + 1
        Return roundNumber
    End Function

    Private Function updateWins(wins As Integer, winFlag As Integer) As Integer
        If winFlag = True Then
            wins = wins + 1
        End If
        Return wins
    End Function

    Private Function updateWinStreak(ByRef winStreak As Integer, ByRef winFlag As Boolean) As Integer
        If winFlag = True Then
            winStreak = winStreak + 1
        Else
            winStreak = 0
        End If

        Return winStreak
    End Function

    Private Sub displayScore(ByRef wins As Integer, ByRef winStreak As Integer, ByRef roundNumber As Integer)
        lblWins.Text = wins
        lblWinStreak.Text = winStreak
        lblTotalGames.Text = roundNumber - 1
    End Sub

End Class