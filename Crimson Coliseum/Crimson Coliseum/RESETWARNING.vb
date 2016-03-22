Public Class Warning

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        HomePage.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Story_And_Character_Name.Visible = True
        Me.Close()

    End Sub

    Private Sub WarningLabel_Click(sender As System.Object, e As System.EventArgs) Handles WarningLabel.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Warning_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class