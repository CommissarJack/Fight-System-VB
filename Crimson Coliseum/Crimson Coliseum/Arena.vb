Public Class Arena
    'Program done by Jacob Kessock
    'Coding of movement was done by Tony Dougal & Chandler 
    Dim playerx As Integer = 0
    Dim playery As Integer = 0
    Dim prevPlayerx As Integer = 0
    Dim PrevPlayery As Integer = 0
    Dim playerbx As Integer 'Variable that labels the last coordinate for the player
    Dim playerby As Integer 'Variable that labels the last coordinate for the player


    Private Sub Arena_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'show the player's location
        showPlayerCoordinate()

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        cordX.Text = "X cord: " & playerx
        cordY.Text = "Y cord: " & playery
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        x4y2.BackColor = Color.Red

    End Sub

    'Function for showing the player's coordinate.
    Public Function showPlayerCoordinate() As Boolean

        'According to the player's current coordinates
        'If playerx = 0 And playery = 0 Then

        'Clear the whole grid
        clearCoordinates()

        'Make the player's current coordinate's picturebox show the player.
        x0y0.Image = player.Image

        ' End If

        If playerx = 0 And playery = 1 Then
            clearCoordinates()
            x0y1.Image = player.Image
        End If

        If playerx = 0 And playery = 2 Then
            clearCoordinates()
            x0y2.Image = player.Image
        End If

        If playerx = 1 And playery = 0 Then
            clearCoordinates()
            x1y0.Image = player.Image
        End If

        If playerx = 1 And playery = 1 Then
            clearCoordinates()
            x1y1.Image = player.Image
        End If

        If playerx = 1 And playery = 2 Then
            clearCoordinates()
            x1y2.Image = player.Image
        End If

        If playerx = 2 And playery = 0 Then
            clearCoordinates()
            x2y0.Image = player.Image
        End If

        If playerx = 2 And playery = 1 Then
            clearCoordinates()
            x2y1.Image = player.Image
        End If

        If playerx = 2 And playery = 2 Then
            clearCoordinates()
            x2y2.Image = player.Image
        End If

        If playerx = 3 And playery = 0 Then
            clearCoordinates()
            x3y0.Image = player.Image
        End If

        If playerx = 4 And playery = 0 Then
            clearCoordinates()
            x4y0.Image = player.Image
        End If

        If playerx = 5 And playery = 0 Then
            clearCoordinates()
            x5y0.Image = player.Image
        End If

        If playerx = 6 And playery = 0 Then
            clearCoordinates()
            x6y0.Image = player.Image
        End If

        If playerx = -1 And playery = 0 Then
            clearCoordinates()
            xn1y0.Image = player.Image
        End If

        If playerx = -2 And playery = 0 Then
            clearCoordinates()
            xn2y0.Image = player.Image
        End If

        If playerx = -3 And playery = 0 Then
            clearCoordinates()
            xn3y0.Image = player.Image
        End If

        If playerx = -4 And playery = 0 Then
            clearCoordinates()
            xn4y0.Image = player.Image
        End If

        If playerx = -5 And playery = 0 Then
            clearCoordinates()
            xn5y0.Image = player.Image
        End If

        If playerx = -6 And playery = 0 Then
            clearCoordinates()
            xn6y0.Image = player.Image
        End If

        If playerx = -1 And playery = 1 Then
            clearCoordinates()
            xn1y1.Image = player.Image
        End If

        If playerx = -2 And playery = 1 Then
            clearCoordinates()
            xn2y1.Image = player.Image
        End If

        If playerx = -3 And playery = 1 Then
            clearCoordinates()
            xn3y1.Image = player.Image
        End If

        If playerx = -4 And playery = 1 Then
            clearCoordinates()
            xn4y1.Image = player.Image
        End If

        If playerx = -5 And playery = 1 Then
            clearCoordinates()
            xn5y1.Image = player.Image
        End If

        If playerx = -6 And playery = 1 Then
            clearCoordinates()
            xn6y1.Image = player.Image
        End If


        Return 0
    End Function 'End movement function

    'Function for clearing the whole fucking map.
    Public Function clearCoordinates() As Boolean
        x0y0.Image = clear.Image
        x0y1.Image = clear.Image
        x0y2.Image = clear.Image
        x1y0.Image = clear.Image
        x1y1.Image = clear.Image
        x1y2.Image = clear.Image
        x2y0.Image = clear.Image
        x3y0.Image = clear.Image
        x4y0.Image = clear.Image
        x5y0.Image = clear.Image
        x6y0.Image = clear.Image
        xn1y0.Image = clear.Image
        xn2y0.Image = clear.Image
        xn3y0.Image = clear.Image
        xn4y0.Image = clear.Image
        xn5y0.Image = clear.Image
        xn6y0.Image = clear.Image
        xn1y1.Image = clear.Image
        xn2y1.Image = clear.Image
        xn3y1.Image = clear.Image
        xn4y1.Image = clear.Image
        xn5y1.Image = clear.Image
        xn6y1.Image = clear.Image
        x1y1.Image = clear.Image
        x2y1.Image = clear.Image
        x3y1.Image = clear.Image
        x4y1.Image = clear.Image
        x5y1.Image = clear.Image
        x6y1.Image = clear.Image
        x2y1.Image = clear.Image
        x2y2.Image = clear.Image
        Return 0
    End Function

    'Function for clearing the last coordinate.
    Public Function clearLastCoordinate() As Boolean
        Select Case playerbx And playerby
            Case 0 And 0
                x0y0.Image = clear.Image
            Case 0 And 1
                x0y1.Image = clear.Image
            Case 0 And 2
                x0y2.Image = clear.Image
            Case 1 And 0
                x1y0.Image = clear.Image
            Case 1 And 1
                x1y1.Image = clear.Image
            Case 1 And 2
                x1y2.Image = clear.Image
            Case 2 And 0
                x2y0.Image = clear.Image
            Case 2 And 1
                x2y1.Image = clear.Image
            Case 2 And 2
                x2y2.Image = clear.Image
        End Select
        Return 0
    End Function 'End clearing function

    'Picturebox clicks =-=-=-=-=-=-=-=-
    Private Sub x0y0_Click(sender As System.Object, e As System.EventArgs) Handles x0y0.Click
        'If player Then 'in proximity length and heiht) (x & y) 
        'set attacks with x - range y - range
        'End If

        'test shit to be removed later.
        playerx = 0 : playery = 0

        showPlayerCoordinate()
    End Sub

    Private Sub x1y0_Click(sender As System.Object, e As System.EventArgs) Handles x1y0.Click
        'test shit to be removed later.
        playerx = 1 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub x2y0_Click(sender As System.Object, e As System.EventArgs) Handles x2y0.Click
        playerx = 2 : playery = 0
        showPlayerCoordinate()
    End Sub


    Private Sub x3y0_Click(sender As System.Object, e As System.EventArgs) Handles x3y0.Click
        playerx = 3 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub x4y0_Click(sender As System.Object, e As System.EventArgs) Handles x4y0.Click
        playerx = 4 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub x5y0_Click(sender As System.Object, e As System.EventArgs) Handles x5y0.Click
        playerx = 5 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub x6y0_Click(sender As System.Object, e As System.EventArgs) Handles x6y0.Click
        playerx = 6 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn1y0_Click(sender As System.Object, e As System.EventArgs) Handles xn1y0.Click
        playerx = -1 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y0_Click(sender As System.Object, e As System.EventArgs) Handles xn2y0.Click
        playerx = -2 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y0_Click(sender As System.Object, e As System.EventArgs) Handles xn3y0.Click
        playerx = -3 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y0_Click(sender As System.Object, e As System.EventArgs) Handles xn4y0.Click
        playerx = -4 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn5y0_Click(sender As System.Object, e As System.EventArgs) Handles xn5y0.Click
        playerx = -5 : playery = 0
        showPlayerCoordinate()
    End Sub

    Private Sub xn6y0_Click(sender As System.Object, e As System.EventArgs) Handles xn6y0.Click
        playerx = -6 : playery = 0
        showPlayerCoordinate()
    End Sub
    Private Sub x0y1_Click(sender As System.Object, e As System.EventArgs) Handles x0y0.Click

        playerx = 0 : playery = 1

        showPlayerCoordinate()
    End Sub

    Private Sub x1y1_Click(sender As System.Object, e As System.EventArgs) Handles x1y0.Click
        'test shit to be removed later.
        playerx = 1 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x2y1_Click(sender As System.Object, e As System.EventArgs) Handles x2y0.Click
        playerx = 2 : playery = 1
        showPlayerCoordinate()
    End Sub


    Private Sub x3y1_Click(sender As System.Object, e As System.EventArgs) Handles x3y0.Click
        playerx = 3 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x4y1_Click(sender As System.Object, e As System.EventArgs) Handles x4y0.Click
        playerx = 4 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x5y1_Click(sender As System.Object, e As System.EventArgs) Handles x5y0.Click
        playerx = 5 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x6y1_Click(sender As System.Object, e As System.EventArgs) Handles x6y0.Click
        playerx = 6 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn1y1_Click(sender As System.Object, e As System.EventArgs) Handles xn1y0.Click
        playerx = -1 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y1_Click(sender As System.Object, e As System.EventArgs) Handles xn2y0.Click
        playerx = -2 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y1_Click(sender As System.Object, e As System.EventArgs) Handles xn3y0.Click
        playerx = -3 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y1_Click(sender As System.Object, e As System.EventArgs) Handles xn4y0.Click
        playerx = -4 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn5y1_Click(sender As System.Object, e As System.EventArgs) Handles xn5y0.Click
        playerx = -5 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn6y1_Click(sender As System.Object, e As System.EventArgs) Handles xn6y0.Click
        playerx = -6 : playery = 1
        showPlayerCoordinate()
    End Sub
End Class
