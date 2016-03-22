Public Class Story_And_Character_Name

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles UserName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Name = UserName.Text
        Class_Selection.Visible = True

        Me.Close()

    End Sub
End Class