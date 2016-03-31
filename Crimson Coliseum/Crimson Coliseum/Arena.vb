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

        If playerx = 1 And playery = 1 Then
            clearCoordinates()
            x1y1.Image = player.Image
        End If

        If playerx = 2 And playery = 1 Then
            clearCoordinates()
            x2y1.Image = player.Image
        End If

        If playerx = 3 And playery = 1 Then
            clearCoordinates()
            x3y1.Image = player.Image
        End If

        If playerx = 4 And playery = 1 Then
            clearCoordinates()
            x4y1.Image = player.Image
        End If

        If playerx = 5 And playery = 1 Then
            clearCoordinates()
            x5y1.Image = player.Image
        End If

        If playerx = 6 And playery = 1 Then
            clearCoordinates()
            x6y1.Image = player.Image
        End If

        If playerx = -1 And playery = -1 Then
            clearCoordinates()
            xn1yn1.Image = player.Image
        End If

        If playerx = -2 And playery = -1 Then
            clearCoordinates()
            xn2yn1.Image = player.Image
        End If

        If playerx = -3 And playery = -1 Then
            clearCoordinates()
            xn3yn1.Image = player.Image
        End If

        If playerx = -4 And playery = -1 Then
            clearCoordinates()
            xn4yn1.Image = player.Image
        End If

        If playerx = -5 And playery = -1 Then
            clearCoordinates()
            xn5yn1.Image = player.Image
        End If

        If playerx = -6 And playery = -1 Then
            clearCoordinates()
            xn6yn1.Image = player.Image
        End If

        If playerx = 1 And playery = -1 Then
            clearCoordinates()
            x1yn1.Image = player.Image
        End If

        If playerx = 2 And playery = -1 Then
            clearCoordinates()
            x2yn1.Image = player.Image
        End If

        If playerx = 3 And playery = -1 Then
            clearCoordinates()
            x3yn1.Image = player.Image
        End If

        If playerx = 4 And playery = -1 Then
            clearCoordinates()
            x4yn1.Image = player.Image
        End If

        If playerx = 5 And playery = -1 Then
            clearCoordinates()
            x5yn1.Image = player.Image
        End If

        If playerx = 6 And playery = -1 Then
            clearCoordinates()
            x6yn1.Image = player.Image
        End If

        If playerx = 0 And playery = -1 Then
            clearCoordinates()
            x0yn1.Image = player.Image
        End If

        If playerx = -1 And playery = -2 Then
            clearCoordinates()
            xn1yn2.Image = player.Image
        End If

        If playerx = -2 And playery = -2 Then
            clearCoordinates()
            xn2yn2.Image = player.Image
        End If

        If playerx = -3 And playery = -2 Then
            clearCoordinates()
            xn3yn2.Image = player.Image
        End If

        If playerx = -4 And playery = -2 Then
            clearCoordinates()
            xn4yn2.Image = player.Image
        End If

        If playerx = -5 And playery = -2 Then
            clearCoordinates()
            xn5yn2.Image = player.Image
        End If


        If playerx = 1 And playery = -2 Then
            clearCoordinates()
            x1yn2.Image = player.Image
        End If

        If playerx = 2 And playery = -2 Then
            clearCoordinates()
            x2yn2.Image = player.Image
        End If

        If playerx = 3 And playery = -2 Then
            clearCoordinates()
            x3yn2.Image = player.Image
        End If

        If playerx = 4 And playery = -2 Then
            clearCoordinates()
            x4yn2.Image = player.Image
        End If

        If playerx = 5 And playery = -2 Then
            clearCoordinates()
            x5yn2.Image = player.Image
        End If

        If playerx = 0 And playery = -2 Then
            clearCoordinates()
            x0yn2.Image = player.Image
        End If

        If playerx = -1 And playery = -3 Then
            clearCoordinates()
            xn1yn3.Image = player.Image
        End If

        If playerx = -2 And playery = -3 Then
            clearCoordinates()
            xn2yn3.Image = player.Image
        End If

        If playerx = -3 And playery = -3 Then
            clearCoordinates()
            xn3yn3.Image = player.Image
        End If

        If playerx = -4 And playery = -3 Then
            clearCoordinates()
            xn4yn3.Image = player.Image
        End If

        If playerx = -5 And playery = -3 Then
            clearCoordinates()
            xn5yn3.Image = player.Image
        End If


        If playerx = 1 And playery = -3 Then
            clearCoordinates()
            x1yn3.Image = player.Image
        End If

        If playerx = 2 And playery = -3 Then
            clearCoordinates()
            x2yn3.Image = player.Image
        End If

        If playerx = 3 And playery = -3 Then
            clearCoordinates()
            x3yn3.Image = player.Image
        End If

        If playerx = 4 And playery = -3 Then
            clearCoordinates()
            x4yn3.Image = player.Image
        End If

        If playerx = 5 And playery = -3 Then
            clearCoordinates()
            x5yn3.Image = player.Image
        End If

        If playerx = 0 And playery = -3 Then
            clearCoordinates()
            x0yn3.Image = player.Image
        End If

        If playerx = -1 And playery = -4 Then
            clearCoordinates()
            xn1yn4.Image = player.Image
        End If

        If playerx = -2 And playery = -4 Then
            clearCoordinates()
            xn2yn4.Image = player.Image
        End If

        If playerx = -3 And playery = -4 Then
            clearCoordinates()
            xn3yn4.Image = player.Image
        End If

        If playerx = -4 And playery = -4 Then
            clearCoordinates()
            xn4yn4.Image = player.Image
        End If

        If playerx = 1 And playery = -4 Then
            clearCoordinates()
            x1yn4.Image = player.Image
        End If

        If playerx = 2 And playery = -4 Then
            clearCoordinates()
            x2yn4.Image = player.Image
        End If

        If playerx = 3 And playery = -4 Then
            clearCoordinates()
            x3yn4.Image = player.Image
        End If

        If playerx = 4 And playery = -4 Then
            clearCoordinates()
            x4yn4.Image = player.Image
        End If

        If playerx = 0 And playery = -4 Then
            clearCoordinates()
            x0yn4.Image = player.Image
        End If

        If playerx = 0 And playery = -5 Then
            clearCoordinates()
            x0yn5.Image = player.Image
        End If

        If playerx = -1 And playery = -5 Then
            clearCoordinates()
            xn1yn5.Image = player.Image
        End If

        If playerx = -2 And playery = -5 Then
            clearCoordinates()
            xn2yn5.Image = player.Image
        End If

        If playerx = -3 And playery = -5 Then
            clearCoordinates()
            xn3yn5.Image = player.Image
        End If

        If playerx = 1 And playery = -5 Then
            clearCoordinates()
            x1yn5.Image = player.Image
        End If

        If playerx = 2 And playery = -5 Then
            clearCoordinates()
            x2yn5.Image = player.Image
        End If

        If playerx = 3 And playery = -5 Then
            clearCoordinates()
            x3yn5.Image = player.Image
        End If

        If playerx = 0 And playery = -5 Then
            clearCoordinates()
            x0yn5.Image = player.Image
        End If

        If playerx = 1 And playery = -6 Then
            clearCoordinates()
            x1yn6.Image = player.Image
        End If
        If playerx = 0 And playery = -6 Then
            clearCoordinates()
            x0yn6.Image = player.Image
        End If

        If playerx = -1 And playery = -6 Then
            clearCoordinates()
            xn1yn6.Image = player.Image
        End If

        If playerx = 0 And playery = 2 Then
            clearCoordinates()
            x0y2.Image = player.Image
        End If


        If playerx = 1 And playery = 2 Then
            clearCoordinates()
            x1y2.Image = player.Image
        End If

        If playerx = 2 And playery = 2 Then
            clearCoordinates()
            x2y2.Image = player.Image
        End If

        If playerx = 3 And playery = 2 Then
            clearCoordinates()
            x3y2.Image = player.Image
        End If

        If playerx = 4 And playery = 2 Then
            clearCoordinates()
            x4y2.Image = player.Image
        End If

        If playerx = 5 And playery = 2 Then
            clearCoordinates()
            x5y2.Image = player.Image
        End If

        If playerx = -1 And playery = 2 Then
            clearCoordinates()
            xn1y2.Image = player.Image
        End If

        If playerx = -2 And playery = 2 Then
            clearCoordinates()
            xn2y2.Image = player.Image
        End If

        If playerx = -3 And playery = 2 Then
            clearCoordinates()
            xn3y2.Image = player.Image
        End If

        If playerx = -4 And playery = 2 Then
            clearCoordinates()
            xn4y2.Image = player.Image
        End If

        If playerx = -5 And playery = 2 Then
            clearCoordinates()
            xn5y2.Image = player.Image
        End If

        If playerx = 0 And playery = 3 Then
            clearCoordinates()
            x0y3.Image = player.Image
        End If


        If playerx = 1 And playery = 3 Then
            clearCoordinates()
            x1y3.Image = player.Image
        End If

        If playerx = 2 And playery = 3 Then
            clearCoordinates()
            x2y3.Image = player.Image
        End If

        If playerx = 3 And playery = 3 Then
            clearCoordinates()
            x3y3.Image = player.Image
        End If

        If playerx = 4 And playery = 3 Then
            clearCoordinates()
            x4y3.Image = player.Image
        End If

        If playerx = 5 And playery = 3 Then
            clearCoordinates()
            x5y3.Image = player.Image
        End If

        If playerx = -1 And playery = 3 Then
            clearCoordinates()
            xn1y3.Image = player.Image
        End If

        If playerx = -2 And playery = 3 Then
            clearCoordinates()
            xn2y3.Image = player.Image
        End If

        If playerx = -3 And playery = 3 Then
            clearCoordinates()
            xn3y3.Image = player.Image
        End If

        If playerx = -4 And playery = 3 Then
            clearCoordinates()
            xn4y3.Image = player.Image
        End If

        If playerx = -5 And playery = 3 Then
            clearCoordinates()
            xn5y3.Image = player.Image
        End If

        If playerx = 0 And playery = 4 Then
            clearCoordinates()
            x0y4.Image = player.Image
        End If


        If playerx = 1 And playery = 4 Then
            clearCoordinates()
            x1y4.Image = player.Image
        End If

        If playerx = 2 And playery = 4 Then
            clearCoordinates()
            x2y4.Image = player.Image
        End If

        If playerx = 3 And playery = 4 Then
            clearCoordinates()
            x3y4.Image = player.Image
        End If

        If playerx = 4 And playery = 4 Then
            clearCoordinates()
            x4y4.Image = player.Image
        End If

        If playerx = -1 And playery = 4 Then
            clearCoordinates()
            xn1y4.Image = player.Image
        End If

        If playerx = -2 And playery = 4 Then
            clearCoordinates()
            xn2y4.Image = player.Image
        End If

        If playerx = -3 And playery = 4 Then
            clearCoordinates()
            xn3y4.Image = player.Image
        End If

        If playerx = -4 And playery = 4 Then
            clearCoordinates()
            xn4y4.Image = player.Image
        End If

        If playerx = 0 And playery = 5 Then
            clearCoordinates()
            x0y5.Image = player.Image
        End If


        If playerx = 1 And playery = 5 Then
            clearCoordinates()
            x1y5.Image = player.Image
        End If

        If playerx = 2 And playery = 5 Then
            clearCoordinates()
            x2y5.Image = player.Image
        End If

        If playerx = 3 And playery = 5 Then
            clearCoordinates()
            x3y5.Image = player.Image
        End If


        If playerx = -1 And playery = 5 Then
            clearCoordinates()
            xn1y5.Image = player.Image
        End If

        If playerx = -2 And playery = 5 Then
            clearCoordinates()
            xn2y5.Image = player.Image
        End If

        If playerx = -3 And playery = 5 Then
            clearCoordinates()
            xn3y5.Image = player.Image
        End If

        If playerx = 0 And playery = 6 Then
            clearCoordinates()
            x0y6.Image = player.Image
        End If


        If playerx = 1 And playery = 6 Then
            clearCoordinates()
            x1y6.Image = player.Image
        End If

        If playerx = -1 And playery = 6 Then
            clearCoordinates()
            xn1y6.Image = player.Image
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
        xn1yn1.Image = clear.Image
        xn2yn1.Image = clear.Image
        xn3yn1.Image = clear.Image
        xn4yn1.Image = clear.Image
        xn5yn1.Image = clear.Image
        xn6yn1.Image = clear.Image
        x1yn1.Image = clear.Image
        x2yn1.Image = clear.Image
        x3yn1.Image = clear.Image
        x4yn1.Image = clear.Image
        x5yn1.Image = clear.Image
        x6yn1.Image = clear.Image
        x0yn1.Image = clear.Image
        xn1yn2.Image = clear.Image
        xn2yn2.Image = clear.Image
        xn3yn2.Image = clear.Image
        xn4yn2.Image = clear.Image
        xn5yn2.Image = clear.Image
        x1yn2.Image = clear.Image
        x2yn2.Image = clear.Image
        x3yn2.Image = clear.Image
        x4yn2.Image = clear.Image
        x5yn2.Image = clear.Image
        x0yn2.Image = clear.Image
        xn1yn3.Image = clear.Image
        xn2yn3.Image = clear.Image
        xn3yn3.Image = clear.Image
        xn4yn3.Image = clear.Image
        xn5yn3.Image = clear.Image
        x1yn3.Image = clear.Image
        x2yn3.Image = clear.Image
        x3yn3.Image = clear.Image
        x4yn3.Image = clear.Image
        x5yn3.Image = clear.Image
        x0yn3.Image = clear.Image
        xn1yn4.Image = clear.Image
        xn2yn4.Image = clear.Image
        xn3yn4.Image = clear.Image
        xn4yn4.Image = clear.Image
        x1yn4.Image = clear.Image
        x2yn4.Image = clear.Image
        x3yn4.Image = clear.Image
        x4yn4.Image = clear.Image
        x0yn4.Image = clear.Image
        xn1yn5.Image = clear.Image
        xn2yn5.Image = clear.Image
        xn3yn5.Image = clear.Image
        x1yn5.Image = clear.Image
        x2yn5.Image = clear.Image
        x3yn5.Image = clear.Image
        x0yn5.Image = clear.Image
        x1yn6.Image = clear.Image
        x0yn6.Image = clear.Image
        xn1yn6.Image = clear.Image
        x1y2.Image = clear.Image
        x2y2.Image = clear.Image
        x3y2.Image = clear.Image
        x4y2.Image = clear.Image
        x5y2.Image = clear.Image
        xn1y2.Image = clear.Image
        xn2y2.Image = clear.Image
        xn3y2.Image = clear.Image
        xn4y2.Image = clear.Image
        xn5y2.Image = clear.Image
        x0y2.Image = clear.Image
        x1y3.Image = clear.Image
        x2y3.Image = clear.Image
        x3y3.Image = clear.Image
        x4y3.Image = clear.Image
        x5y3.Image = clear.Image
        xn1y3.Image = clear.Image
        xn2y3.Image = clear.Image
        xn3y3.Image = clear.Image
        xn4y3.Image = clear.Image
        xn5y3.Image = clear.Image
        x0y3.Image = clear.Image
        x1y4.Image = clear.Image
        x2y4.Image = clear.Image
        x3y4.Image = clear.Image
        x4y4.Image = clear.Image
        xn1y4.Image = clear.Image
        xn2y4.Image = clear.Image
        xn3y4.Image = clear.Image
        xn4y4.Image = clear.Image
        x0y4.Image = clear.Image
        x1y5.Image = clear.Image
        x2y5.Image = clear.Image
        x3y5.Image = clear.Image
        xn1y5.Image = clear.Image
        xn2y5.Image = clear.Image
        xn3y5.Image = clear.Image
        x0y5.Image = clear.Image
        x1y6.Image = clear.Image
        xn1y6.Image = clear.Image
        x0y6.Image = clear.Image


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
    Private Sub x0y1_Click(sender As System.Object, e As System.EventArgs) Handles x0y1.Click

        playerx = 0 : playery = 1

        showPlayerCoordinate()
    End Sub

    Private Sub x1y1_Click(sender As System.Object, e As System.EventArgs) Handles x1y1.Click
        'test shit to be removed later.
        playerx = 1 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x2y1_Click(sender As System.Object, e As System.EventArgs) Handles x2y1.Click
        playerx = 2 : playery = 1
        showPlayerCoordinate()
    End Sub


    Private Sub x3y1_Click(sender As System.Object, e As System.EventArgs) Handles x3y1.Click
        playerx = 3 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x4y1_Click(sender As System.Object, e As System.EventArgs) Handles x4y1.Click
        playerx = 4 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x5y1_Click(sender As System.Object, e As System.EventArgs) Handles x5y1.Click
        playerx = 5 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x6y1_Click(sender As System.Object, e As System.EventArgs) Handles x6y1.Click
        playerx = 6 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn1y1_Click(sender As System.Object, e As System.EventArgs) Handles xn1y1.Click
        playerx = -1 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y1_Click(sender As System.Object, e As System.EventArgs) Handles xn2y1.Click
        playerx = -2 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y1_Click(sender As System.Object, e As System.EventArgs) Handles xn3y1.Click
        playerx = -3 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y1_Click(sender As System.Object, e As System.EventArgs) Handles xn4y1.Click
        playerx = -4 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn5y1_Click(sender As System.Object, e As System.EventArgs) Handles xn5y1.Click
        playerx = -5 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub xn6y1_Click(sender As System.Object, e As System.EventArgs) Handles xn6y1.Click
        playerx = -6 : playery = 1
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn1_Click(sender As System.Object, e As System.EventArgs) Handles x0yn1.Click

        playerx = 0 : playery = -1

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn1_Click(sender As System.Object, e As System.EventArgs) Handles x1yn1.Click
        'test shit to be removed later.
        playerx = 1 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub x2yn1_Click(sender As System.Object, e As System.EventArgs) Handles x2yn1.Click
        playerx = 2 : playery = -1
        showPlayerCoordinate()
    End Sub


    Private Sub x3yn1_Click(sender As System.Object, e As System.EventArgs) Handles x3yn1.Click
        playerx = 3 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub x4yn1_Click(sender As System.Object, e As System.EventArgs) Handles x4yn1.Click
        playerx = 4 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub x5yn1_Click(sender As System.Object, e As System.EventArgs) Handles x5yn1.Click
        playerx = 5 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub x6yn1_Click(sender As System.Object, e As System.EventArgs) Handles x6yn1.Click
        playerx = 6 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn1yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn1.Click
        playerx = -1 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn2yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn2yn1.Click
        playerx = -2 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn3yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn3yn1.Click
        playerx = -3 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn4yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn4yn1.Click
        playerx = -4 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn5yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn5yn1.Click
        playerx = -5 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub xn6yn1_Click(sender As System.Object, e As System.EventArgs) Handles xn6yn1.Click
        playerx = -6 : playery = -1
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn2_Click(sender As System.Object, e As System.EventArgs) Handles x0yn2.Click

        playerx = 0 : playery = -2

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn2_Click(sender As System.Object, e As System.EventArgs) Handles x1yn2.Click
        'test shit to be removed later.
        playerx = 1 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub x2yn2_Click(sender As System.Object, e As System.EventArgs) Handles x2yn2.Click
        playerx = 2 : playery = -2
        showPlayerCoordinate()
    End Sub


    Private Sub x3yn2_Click(sender As System.Object, e As System.EventArgs) Handles x3yn2.Click
        playerx = 3 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub x4yn2_Click(sender As System.Object, e As System.EventArgs) Handles x4yn2.Click
        playerx = 4 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub x5yn2_Click(sender As System.Object, e As System.EventArgs) Handles x5yn2.Click
        playerx = 5 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub xn1yn2_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn2.Click
        playerx = -1 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub xn2yn2_Click(sender As System.Object, e As System.EventArgs) Handles xn2yn2.Click
        playerx = -2 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub xn3yn2_Click(sender As System.Object, e As System.EventArgs) Handles xn3yn2.Click
        playerx = -3 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub xn4yn2_Click(sender As System.Object, e As System.EventArgs) Handles xn4yn2.Click
        playerx = -4 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub xn5yn2_Click(sender As System.Object, e As System.EventArgs) Handles xn5yn2.Click
        playerx = -5 : playery = -2
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn3_Click(sender As System.Object, e As System.EventArgs) Handles x0yn3.Click

        playerx = 0 : playery = -3

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn3_Click(sender As System.Object, e As System.EventArgs) Handles x1yn3.Click
        'test shit to be removed later.
        playerx = 1 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub x2yn3_Click(sender As System.Object, e As System.EventArgs) Handles x2yn3.Click
        playerx = 2 : playery = -3
        showPlayerCoordinate()
    End Sub


    Private Sub x3yn3_Click(sender As System.Object, e As System.EventArgs) Handles x3yn3.Click
        playerx = 3 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub x4yn3_Click(sender As System.Object, e As System.EventArgs) Handles x4yn3.Click
        playerx = 4 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub x5yn3_Click(sender As System.Object, e As System.EventArgs) Handles x5yn3.Click
        playerx = 5 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub xn1yn3_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn3.Click
        playerx = -1 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub xn2yn3_Click(sender As System.Object, e As System.EventArgs) Handles xn2yn3.Click
        playerx = -2 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub xn3yn3_Click(sender As System.Object, e As System.EventArgs) Handles xn3yn3.Click
        playerx = -3 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub xn4yn3_Click(sender As System.Object, e As System.EventArgs) Handles xn4yn3.Click
        playerx = -4 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub xn5yn3_Click(sender As System.Object, e As System.EventArgs) Handles xn5yn3.Click
        playerx = -5 : playery = -3
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn4_Click(sender As System.Object, e As System.EventArgs) Handles x0yn4.Click

        playerx = 0 : playery = -4

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn4_Click(sender As System.Object, e As System.EventArgs) Handles x1yn4.Click
        'test shit to be removed later.
        playerx = 1 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub x2yn4_Click(sender As System.Object, e As System.EventArgs) Handles x2yn4.Click
        playerx = 2 : playery = -4
        showPlayerCoordinate()
    End Sub


    Private Sub x3yn4_Click(sender As System.Object, e As System.EventArgs) Handles x3yn4.Click
        playerx = 3 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub x4yn4_Click(sender As System.Object, e As System.EventArgs) Handles x4yn4.Click
        playerx = 4 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub xn1yn4_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn4.Click
        playerx = -1 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub xn2yn4_Click(sender As System.Object, e As System.EventArgs) Handles xn2yn4.Click
        playerx = -2 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub xn3yn4_Click(sender As System.Object, e As System.EventArgs) Handles xn3yn4.Click
        playerx = -3 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub xn4yn4_Click(sender As System.Object, e As System.EventArgs) Handles xn4yn4.Click
        playerx = -4 : playery = -4
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn5_Click(sender As System.Object, e As System.EventArgs) Handles x0yn5.Click

        playerx = 0 : playery = -5

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn5_Click(sender As System.Object, e As System.EventArgs) Handles x1yn5.Click
        'test shit to be removed later.
        playerx = 1 : playery = -5
        showPlayerCoordinate()
    End Sub

    Private Sub x2yn5_Click(sender As System.Object, e As System.EventArgs) Handles x2yn5.Click
        playerx = 2 : playery = -5
        showPlayerCoordinate()
    End Sub


    Private Sub x3yn5_Click(sender As System.Object, e As System.EventArgs) Handles x3yn5.Click
        playerx = 3 : playery = -5
        showPlayerCoordinate()
    End Sub

    Private Sub xn1yn5_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn5.Click
        playerx = -1 : playery = -5
        showPlayerCoordinate()
    End Sub

    Private Sub xn2yn5_Click(sender As System.Object, e As System.EventArgs) Handles xn2yn5.Click
        playerx = -2 : playery = -5
        showPlayerCoordinate()
    End Sub

    Private Sub xn3yn5_Click(sender As System.Object, e As System.EventArgs) Handles xn3yn5.Click
        playerx = -3 : playery = -5
        showPlayerCoordinate()
    End Sub

    Private Sub x0yn6_Click(sender As System.Object, e As System.EventArgs) Handles x0yn6.Click

        playerx = 0 : playery = -6

        showPlayerCoordinate()
    End Sub

    Private Sub x1yn6_Click(sender As System.Object, e As System.EventArgs) Handles x1yn6.Click
        'test shit to be removed later.
        playerx = 1 : playery = -6
        showPlayerCoordinate()
    End Sub
    Private Sub xn1yn6_Click(sender As System.Object, e As System.EventArgs) Handles xn1yn6.Click
        playerx = -1 : playery = -6
        showPlayerCoordinate()
    End Sub

    Private Sub x1y2_Click(sender As System.Object, e As System.EventArgs) Handles x1y2.Click
        'test shit to be removed later.
        playerx = 1 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub x2y2_Click(sender As System.Object, e As System.EventArgs) Handles x2y2.Click
        playerx = 2 : playery = 2
        showPlayerCoordinate()
    End Sub


    Private Sub x3y2_Click(sender As System.Object, e As System.EventArgs) Handles x3y2.Click
        playerx = 3 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub x4y2_Click(sender As System.Object, e As System.EventArgs) Handles x4y2.Click
        playerx = 4 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub x5y2_Click(sender As System.Object, e As System.EventArgs) Handles x5y2.Click
        playerx = 5 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub xn1y2_Click(sender As System.Object, e As System.EventArgs) Handles xn1y2.Click
        playerx = -1 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y2_Click(sender As System.Object, e As System.EventArgs) Handles xn2y2.Click
        playerx = -2 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y2_Click(sender As System.Object, e As System.EventArgs) Handles xn3y2.Click
        playerx = -3 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y2_Click(sender As System.Object, e As System.EventArgs) Handles xn4y2.Click
        playerx = -4 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub xn5y2_Click(sender As System.Object, e As System.EventArgs) Handles xn5y2.Click
        playerx = -5 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub x0y2_Click(sender As System.Object, e As System.EventArgs) Handles x0y2.Click
        'test shit to be removed later.
        playerx = 0 : playery = 2
        showPlayerCoordinate()
    End Sub

    Private Sub x1y3_Click(sender As System.Object, e As System.EventArgs) Handles x1y3.Click
        'test shit to be removed later.
        playerx = 1 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub x2y3_Click(sender As System.Object, e As System.EventArgs) Handles x2y3.Click
        playerx = 2 : playery = 3
        showPlayerCoordinate()
    End Sub


    Private Sub x3y3_Click(sender As System.Object, e As System.EventArgs) Handles x3y3.Click
        playerx = 3 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub x4y3_Click(sender As System.Object, e As System.EventArgs) Handles x4y3.Click
        playerx = 4 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub x5y3_Click(sender As System.Object, e As System.EventArgs) Handles x5y3.Click
        playerx = 5 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub xn1y3_Click(sender As System.Object, e As System.EventArgs) Handles xn1y3.Click
        playerx = -1 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y3_Click(sender As System.Object, e As System.EventArgs) Handles xn2y3.Click
        playerx = -2 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y3_Click(sender As System.Object, e As System.EventArgs) Handles xn3y3.Click
        playerx = -3 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y3_Click(sender As System.Object, e As System.EventArgs) Handles xn4y3.Click
        playerx = -4 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub xn5y3_Click(sender As System.Object, e As System.EventArgs) Handles xn5y3.Click
        playerx = -5 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub x0y3_Click(sender As System.Object, e As System.EventArgs) Handles x0y3.Click
        'test shit to be removed later.
        playerx = 0 : playery = 3
        showPlayerCoordinate()
    End Sub

    Private Sub x1y4_Click(sender As System.Object, e As System.EventArgs) Handles x1y4.Click
        'test shit to be removed later.
        playerx = 1 : playery = 4
        showPlayerCoordinate()
    End Sub

    Private Sub x2y4_Click(sender As System.Object, e As System.EventArgs) Handles x2y4.Click
        playerx = 2 : playery = 4
        showPlayerCoordinate()
    End Sub


    Private Sub x3y4_Click(sender As System.Object, e As System.EventArgs) Handles x3y4.Click
        playerx = 3 : playery = 4
        showPlayerCoordinate()
    End Sub

    Private Sub x4y4_Click(sender As System.Object, e As System.EventArgs) Handles x4y4.Click
        playerx = 4 : playery = 4
        showPlayerCoordinate()
    End Sub


    Private Sub xn1y4_Click(sender As System.Object, e As System.EventArgs) Handles xn1y4.Click
        playerx = -1 : playery = 4
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y4_Click(sender As System.Object, e As System.EventArgs) Handles xn2y4.Click
        playerx = -2 : playery = 4
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y4_Click(sender As System.Object, e As System.EventArgs) Handles xn3y4.Click
        playerx = -3 : playery = 4
        showPlayerCoordinate()
    End Sub

    Private Sub xn4y4_Click(sender As System.Object, e As System.EventArgs) Handles xn4y4.Click
        playerx = -4 : playery = 4
        showPlayerCoordinate()
    End Sub


    Private Sub x0y4_Click(sender As System.Object, e As System.EventArgs) Handles x0y4.Click
        'test shit to be removed later.
        playerx = 0 : playery = 4
        showPlayerCoordinate()
    End Sub


    Private Sub x1y5_Click(sender As System.Object, e As System.EventArgs) Handles x1y5.Click
        'test shit to be removed later.
        playerx = 1 : playery = 5
        showPlayerCoordinate()
    End Sub

    Private Sub x2y5_Click(sender As System.Object, e As System.EventArgs) Handles x2y5.Click
        playerx = 2 : playery = 5
        showPlayerCoordinate()
    End Sub


    Private Sub x3y5_Click(sender As System.Object, e As System.EventArgs) Handles x3y5.Click
        playerx = 3 : playery = 5
        showPlayerCoordinate()
    End Sub



    Private Sub xn1y5_Click(sender As System.Object, e As System.EventArgs) Handles xn1y5.Click
        playerx = -1 : playery = 5
        showPlayerCoordinate()
    End Sub

    Private Sub xn2y5_Click(sender As System.Object, e As System.EventArgs) Handles xn2y5.Click
        playerx = -2 : playery = 5
        showPlayerCoordinate()
    End Sub

    Private Sub xn3y5_Click(sender As System.Object, e As System.EventArgs) Handles xn3y5.Click
        playerx = -3 : playery = 5
        showPlayerCoordinate()
    End Sub
    Private Sub x0y5_Click(sender As System.Object, e As System.EventArgs) Handles x0y5.Click
        'test shit to be removed later.
        playerx = 0 : playery = 5
        showPlayerCoordinate()
    End Sub

    Private Sub x1y6_Click(sender As System.Object, e As System.EventArgs) Handles x1y6.Click
        'test shit to be removed later.
        playerx = 1 : playery = 6
        showPlayerCoordinate()
    End Sub




    Private Sub xn1y6_Click(sender As System.Object, e As System.EventArgs) Handles xn1y6.Click
        playerx = -1 : playery = 6
        showPlayerCoordinate()
    End Sub




    Private Sub x0y6_Click(sender As System.Object, e As System.EventArgs) Handles x0y6.Click
        'test shit to be removed later.
        playerx = 0 : playery = 6
        showPlayerCoordinate()
    End Sub
End Class



