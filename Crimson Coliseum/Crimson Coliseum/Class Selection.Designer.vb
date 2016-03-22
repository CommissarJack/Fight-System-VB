<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Class_Selection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Class_Selection))
        Me.ClassDesc = New System.Windows.Forms.Label()
        Me.JuggernautSelect = New System.Windows.Forms.Button()
        Me.ArcherSelect = New System.Windows.Forms.Button()
        Me.MageSelect = New System.Windows.Forms.Button()
        Me.BeserkerSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HPLab = New System.Windows.Forms.Label()
        Me.ATKLab = New System.Windows.Forms.Label()
        Me.DEFLab = New System.Windows.Forms.Label()
        Me.SPDLab = New System.Windows.Forms.Label()
        Me.AGLLab = New System.Windows.Forms.Label()
        Me.MNLab = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClassDesc
        '
        Me.ClassDesc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClassDesc.Location = New System.Drawing.Point(12, 9)
        Me.ClassDesc.Name = "ClassDesc"
        Me.ClassDesc.Size = New System.Drawing.Size(649, 171)
        Me.ClassDesc.TabIndex = 0
        Me.ClassDesc.Text = resources.GetString("ClassDesc.Text")
        '
        'JuggernautSelect
        '
        Me.JuggernautSelect.Location = New System.Drawing.Point(12, 183)
        Me.JuggernautSelect.Name = "JuggernautSelect"
        Me.JuggernautSelect.Size = New System.Drawing.Size(157, 111)
        Me.JuggernautSelect.TabIndex = 1
        Me.JuggernautSelect.Text = "Juggernaut"
        Me.JuggernautSelect.UseVisualStyleBackColor = True
        '
        'ArcherSelect
        '
        Me.ArcherSelect.Location = New System.Drawing.Point(175, 183)
        Me.ArcherSelect.Name = "ArcherSelect"
        Me.ArcherSelect.Size = New System.Drawing.Size(157, 111)
        Me.ArcherSelect.TabIndex = 2
        Me.ArcherSelect.Text = "Archer"
        Me.ArcherSelect.UseVisualStyleBackColor = True
        '
        'MageSelect
        '
        Me.MageSelect.Location = New System.Drawing.Point(338, 183)
        Me.MageSelect.Name = "MageSelect"
        Me.MageSelect.Size = New System.Drawing.Size(157, 111)
        Me.MageSelect.TabIndex = 3
        Me.MageSelect.Text = "Mage"
        Me.MageSelect.UseVisualStyleBackColor = True
        '
        'BeserkerSelect
        '
        Me.BeserkerSelect.Location = New System.Drawing.Point(504, 183)
        Me.BeserkerSelect.Name = "BeserkerSelect"
        Me.BeserkerSelect.Size = New System.Drawing.Size(157, 111)
        Me.BeserkerSelect.TabIndex = 4
        Me.BeserkerSelect.Text = "Beseker"
        Me.BeserkerSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(667, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Stats"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(667, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "HP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label2, "Your lifeforce. If this number reaches 0, you lose.")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label3.Location = New System.Drawing.Point(667, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ATK"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label3, "Your base damage added on to your weapon.")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.Location = New System.Drawing.Point(667, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DEF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label4, "Base damage removed after recieving damage")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label5.Location = New System.Drawing.Point(667, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SPD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label5, "The amount of tiles you can move per turn.")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label6.Location = New System.Drawing.Point(667, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 31)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "AGL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label6, "Dodge Chance")
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label7.Location = New System.Drawing.Point(667, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "MNA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label7, "Your Mana (Only applies to mages).")
        '
        'HPLab
        '
        Me.HPLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.HPLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HPLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.HPLab.Location = New System.Drawing.Point(730, 63)
        Me.HPLab.Name = "HPLab"
        Me.HPLab.Size = New System.Drawing.Size(53, 31)
        Me.HPLab.TabIndex = 12
        Me.HPLab.Text = "0"
        Me.HPLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ATKLab
        '
        Me.ATKLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ATKLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ATKLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.ATKLab.Location = New System.Drawing.Point(730, 103)
        Me.ATKLab.Name = "ATKLab"
        Me.ATKLab.Size = New System.Drawing.Size(53, 31)
        Me.ATKLab.TabIndex = 13
        Me.ATKLab.Text = "0"
        Me.ATKLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DEFLab
        '
        Me.DEFLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DEFLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DEFLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.DEFLab.Location = New System.Drawing.Point(730, 143)
        Me.DEFLab.Name = "DEFLab"
        Me.DEFLab.Size = New System.Drawing.Size(53, 31)
        Me.DEFLab.TabIndex = 14
        Me.DEFLab.Text = "0"
        Me.DEFLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SPDLab
        '
        Me.SPDLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SPDLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SPDLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.SPDLab.Location = New System.Drawing.Point(730, 183)
        Me.SPDLab.Name = "SPDLab"
        Me.SPDLab.Size = New System.Drawing.Size(53, 31)
        Me.SPDLab.TabIndex = 15
        Me.SPDLab.Text = "0"
        Me.SPDLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AGLLab
        '
        Me.AGLLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AGLLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AGLLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.AGLLab.Location = New System.Drawing.Point(730, 223)
        Me.AGLLab.Name = "AGLLab"
        Me.AGLLab.Size = New System.Drawing.Size(53, 31)
        Me.AGLLab.TabIndex = 16
        Me.AGLLab.Text = "0"
        Me.AGLLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MNLab
        '
        Me.MNLab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MNLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MNLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.MNLab.Location = New System.Drawing.Point(730, 263)
        Me.MNLab.Name = "MNLab"
        Me.MNLab.Size = New System.Drawing.Size(53, 31)
        Me.MNLab.TabIndex = 17
        Me.MNLab.Text = "0"
        Me.MNLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Confirm
        '
        Me.Confirm.Enabled = False
        Me.Confirm.Location = New System.Drawing.Point(12, 300)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(764, 39)
        Me.Confirm.TabIndex = 18
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Class_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(788, 346)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.MNLab)
        Me.Controls.Add(Me.AGLLab)
        Me.Controls.Add(Me.SPDLab)
        Me.Controls.Add(Me.DEFLab)
        Me.Controls.Add(Me.ATKLab)
        Me.Controls.Add(Me.HPLab)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BeserkerSelect)
        Me.Controls.Add(Me.MageSelect)
        Me.Controls.Add(Me.ArcherSelect)
        Me.Controls.Add(Me.JuggernautSelect)
        Me.Controls.Add(Me.ClassDesc)
        Me.Name = "Class_Selection"
        Me.Text = "Class_Selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClassDesc As System.Windows.Forms.Label
    Friend WithEvents JuggernautSelect As System.Windows.Forms.Button
    Friend WithEvents ArcherSelect As System.Windows.Forms.Button
    Friend WithEvents MageSelect As System.Windows.Forms.Button
    Friend WithEvents BeserkerSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HPLab As System.Windows.Forms.Label
    Friend WithEvents ATKLab As System.Windows.Forms.Label
    Friend WithEvents DEFLab As System.Windows.Forms.Label
    Friend WithEvents SPDLab As System.Windows.Forms.Label
    Friend WithEvents AGLLab As System.Windows.Forms.Label
    Friend WithEvents MNLab As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Confirm As System.Windows.Forms.Button
End Class
