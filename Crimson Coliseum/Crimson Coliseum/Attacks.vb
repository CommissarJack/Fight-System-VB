Public Class Attacks
    Public Shared energy As Integer
    Public Shared playerTurn As Boolean
    Public Shared potion As Integer

    Private Sub endTurnbtn_Click(sender As Object, e As EventArgs) Handles endTurnbtn.Click
        playerTurn = False
        Arena.energy = 5

    End Sub

    Private Sub PotionATK_Click(sender As Object, e As EventArgs) Handles PotionATK.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        potionLBL.Text = "Uses: " & potion & vbNewLine & "Energy: 3"
    End Sub
End Class