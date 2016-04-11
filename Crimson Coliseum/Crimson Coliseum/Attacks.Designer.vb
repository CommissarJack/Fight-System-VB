<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attacks
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
        Me.endTurnbtn = New System.Windows.Forms.Button()
        Me.JabATK = New System.Windows.Forms.Button()
        Me.SlashATK = New System.Windows.Forms.Button()
        Me.EnrageATK = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PotionATK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.potionLBL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'endTurnbtn
        '
        Me.endTurnbtn.Location = New System.Drawing.Point(12, 12)
        Me.endTurnbtn.Name = "endTurnbtn"
        Me.endTurnbtn.Size = New System.Drawing.Size(92, 23)
        Me.endTurnbtn.TabIndex = 8
        Me.endTurnbtn.Text = "End Turn"
        Me.ToolTip1.SetToolTip(Me.endTurnbtn, "It does what it says")
        Me.endTurnbtn.UseVisualStyleBackColor = True
        '
        'JabATK
        '
        Me.JabATK.Location = New System.Drawing.Point(12, 41)
        Me.JabATK.Name = "JabATK"
        Me.JabATK.Size = New System.Drawing.Size(92, 23)
        Me.JabATK.TabIndex = 9
        Me.JabATK.Text = "Jab"
        Me.ToolTip1.SetToolTip(Me.JabATK, "A long range jab that trades Range for Damage")
        Me.JabATK.UseVisualStyleBackColor = True
        '
        'SlashATK
        '
        Me.SlashATK.Location = New System.Drawing.Point(12, 70)
        Me.SlashATK.Name = "SlashATK"
        Me.SlashATK.Size = New System.Drawing.Size(92, 23)
        Me.SlashATK.TabIndex = 10
        Me.SlashATK.Text = "Slash"
        Me.ToolTip1.SetToolTip(Me.SlashATK, "An average ranged attack that is average in damage")
        Me.SlashATK.UseVisualStyleBackColor = True
        '
        'EnrageATK
        '
        Me.EnrageATK.Location = New System.Drawing.Point(12, 99)
        Me.EnrageATK.Name = "EnrageATK"
        Me.EnrageATK.Size = New System.Drawing.Size(92, 23)
        Me.EnrageATK.TabIndex = 10
        Me.EnrageATK.Text = "Enrage"
        Me.ToolTip1.SetToolTip(Me.EnrageATK, "A boost of attack for 3 turns")
        Me.EnrageATK.UseVisualStyleBackColor = True
        '
        'PotionATK
        '
        Me.PotionATK.Location = New System.Drawing.Point(12, 128)
        Me.PotionATK.Name = "PotionATK"
        Me.PotionATK.Size = New System.Drawing.Size(92, 23)
        Me.PotionATK.TabIndex = 10
        Me.PotionATK.Text = "Potions"
        Me.ToolTip1.SetToolTip(Me.PotionATK, "Heal yourself")
        Me.PotionATK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Energy/Uses"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Energy: 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Energy: 3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Energy: 4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'potionLBL
        '
        Me.potionLBL.AutoSize = True
        Me.potionLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potionLBL.Location = New System.Drawing.Point(110, 131)
        Me.potionLBL.Name = "potionLBL"
        Me.potionLBL.Size = New System.Drawing.Size(53, 16)
        Me.potionLBL.TabIndex = 11
        Me.potionLBL.Text = "Uses: 3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Attacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 165)
        Me.Controls.Add(Me.potionLBL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PotionATK)
        Me.Controls.Add(Me.EnrageATK)
        Me.Controls.Add(Me.SlashATK)
        Me.Controls.Add(Me.JabATK)
        Me.Controls.Add(Me.endTurnbtn)
        Me.Name = "Attacks"
        Me.Text = "Attacks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents endTurnbtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents JabATK As Button
    Friend WithEvents SlashATK As Button
    Friend WithEvents EnrageATK As Button
    Friend WithEvents PotionATK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents potionLBL As Label
    Friend WithEvents Timer1 As Timer
End Class
