Public Class Class_Selection
    Dim HP As Integer
    Dim ATK As Integer
    Dim DEF As Integer
    Dim SPD As Integer
    Dim AGL As Integer
    Dim MNA As Integer
    Private Sub Class_Selection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub MNLab_Click(sender As System.Object, e As System.EventArgs) Handles MNLab.Click

    End Sub

    Private Sub JuggernautSelect_Click(sender As System.Object, e As System.EventArgs) Handles JuggernautSelect.Click
        HPLab.Text = 30
        ATKLab.Text = 2
        DEFLab.Text = 3
        SPDLab.Text = 1
        AGLLab.Text = 1 'maybe 0 
        MNLab.Text = 0
        Confirm.Enabled = True
    End Sub

    Private Sub ArcherSelect_Click(sender As System.Object, e As System.EventArgs) Handles ArcherSelect.Click
        HPLab.Text = 10
        ATKLab.Text = 2
        DEFLab.Text = 1 'maybe 0
        SPDLab.Text = 3
        AGLLab.Text = 1 'maybe 2
        MNLab.Text = 0
        Confirm.Enabled = True
    End Sub

    Private Sub MageSelect_Click(sender As System.Object, e As System.EventArgs) Handles MageSelect.Click
        HPLab.Text = 15
        ATKLab.Text = 3
        DEFLab.Text = 1
        SPDLab.Text = 2
        AGLLab.Text = 1
        MNLab.Text = 200
        Confirm.Enabled = True
    End Sub

    Private Sub BeserkerSelect_Click(sender As System.Object, e As System.EventArgs) Handles BeserkerSelect.Click
        HPLab.Text = 20
        ATKLab.Text = 4 'maybe 3
        DEFLab.Text = 3
        SPDLab.Text = 2
        AGLLab.Text = 1
        MNLab.Text = 0
        Confirm.Enabled = True
    End Sub

    Private Sub Confirm_Click(sender As System.Object, e As System.EventArgs) Handles Confirm.Click
        HP = HPLab.Text
        ATK = ATKLab.Text
        DEF = DEFLab.Text
        SPD = SPDLab.Text
        AGL = AGLLab.Text
        MNA = MNLab.Text
        MainPage.Visible = True
        Me.Close()

    End Sub
End Class