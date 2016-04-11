Public Class MainPage

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Store.visible = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to enter the arena?", "something", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Arena.Visible = True
            Attacks.Visible = True
            Me.Close()
            'Open Form
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        DialogNurse.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Skill_Tree.Visible = True
        Me.Close()
    End Sub
End Class