Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.ImageLocation = "logo.jpg"
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        playerName = getPlayerName()

        If playerName = "" Then
            lblError.Text = "Your name can only contain letters and a character length between 3-10."
        Else
            frmGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Function getPlayerName() As String
        Dim playerName As String
        Dim validation As Boolean

        playerName = txtPlayerName.Text
        validation = validatePlayerName(playerName)

        If validation = False Then
            playerName = ""
        End If

        Return playerName
    End Function

    Private Function validatePlayerName(playerName As String) As Boolean
        Dim validation As Boolean
        Dim nameLength As Integer

        validation = True
        nameLength = playerName.Length - 1

        If playerName.Length >= 3 And playerName.Length <= 10 Then
            For i = 0 To nameLength
                Select Case playerName(i)
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
End Class