<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.LoadSave = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Name = "Label1"
        '
        'Start
        '
        resources.ApplyResources(Me.Start, "Start")
        Me.Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Start.Name = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'LoadSave
        '
        resources.ApplyResources(Me.LoadSave, "LoadSave")
        Me.LoadSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LoadSave.Name = "LoadSave"
        Me.LoadSave.UseVisualStyleBackColor = False
        '
        'Options
        '
        resources.ApplyResources(Me.Options, "Options")
        Me.Options.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Options.Name = "Options"
        Me.Options.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        resources.ApplyResources(Me.ExitButton, "ExitButton")
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HomePage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.LoadSave)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HomePage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents LoadSave As System.Windows.Forms.Button
    Friend WithEvents Options As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
