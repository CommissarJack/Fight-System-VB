Public Class Arena
    Dim x As Integer
    Dim y As Integer
    Dim x1 As Integer
    Dim y1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Dim x3 As Integer
    Dim y3 As Integer
    Dim x4 As Integer
    Dim y4 As Integer
    Dim x5 As Integer
    Dim y5 As Integer
    Dim x6 As Integer
    Dim y6 As Integer
    Dim xn1 As Integer
    Dim yn1 As Integer
    Dim xn2 As Integer
    Dim yn2 As Integer
    Dim xn3 As Integer
    Dim yn3 As Integer
    Dim xn4 As Integer
    Dim yn4 As Integer
    Dim xn5 As Integer
    Dim yn5 As Integer
    Dim xn6 As Integer
    Dim yn6 As Integer
    Private Sub Arena_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        x4y2.BackColor = Color.Red

    End Sub


    Private Sub x0y0_Click(sender As System.Object, e As System.EventArgs) Handles x0y0.Click
        'If player Then 'in proximity length and heiht) (x & y) 
        'set attacks with x - range y - range
        'End If
    End Sub
    
    'Function for showing the player's coordinate.
    Public Function showPlayerCoordinate() As Boolean
    
        'According to the player's current coordinates
        If playerx = 0 And playery = 0 Then

            'Clear the whole grid
            clearCoordinates()

            'Make the player's current coordinate's picturebox show the player.
            x0y0.Image = player.Image

            'Show the town through the town's current coordinate picturebox.
            showTown1Coordinate()

        End If

        If playerx = 0 And playery = 1 Then
            clearCoordinates()
            x0y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 2 Then
            clearCoordinates()
            x0y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 0 Then
            clearCoordinates()
            x1y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 1 Then
            clearCoordinates()
            x1y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 2 Then
            clearCoordinates()
            x1y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 0 Then
            clearCoordinates()
            x2y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 1 Then
            clearCoordinates()
            x2y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 2 Then
            clearCoordinates()
            x2y2.Image = player.Image
            showTown1Coordinate()
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
        x2y1.Image = clear.Image
        x2y2.Image = clear.Image
        Return 0
    End Function
    
End Class
