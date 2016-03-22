Public Class HomePage

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles LoadSave.Click

    End Sub

    Private Sub Play_Click(sender As System.Object, e As System.EventArgs) Handles Start.Click
        Warning.Show()
        Me.Close()

    End Sub

    Shared Sub [end]()
        Throw New NotImplementedException
    End Sub

End Class
