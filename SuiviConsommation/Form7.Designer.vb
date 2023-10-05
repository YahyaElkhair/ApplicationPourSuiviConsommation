<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangementMotPForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel3 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Valider = New Button()
        Label5 = New Label()
        Label4 = New Label()
        NVmotPTextBox2 = New TextBox()
        NVmotPTextBox1 = New TextBox()
        AcMotpTextBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(206), CByte(214), CByte(224))
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Valider)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(NVmotPTextBox2)
        Panel3.Controls.Add(NVmotPTextBox1)
        Panel3.Controls.Add(AcMotpTextBox)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 420)
        Panel3.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(253, 289)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 25)
        Label9.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(289, 274)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(289, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(289, 162)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 12
        ' 
        ' Valider
        ' 
        Valider.BackColor = Color.Lime
        Valider.Cursor = Cursors.Hand
        Valider.Dock = DockStyle.Bottom
        Valider.FlatStyle = FlatStyle.Flat
        Valider.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Valider.Location = New Point(0, 385)
        Valider.Name = "Valider"
        Valider.Size = New Size(559, 35)
        Valider.TabIndex = 11
        Valider.Text = "Changer mon mot de passe"
        Valider.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(25, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(258, 21)
        Label5.TabIndex = 10
        Label5.Text = "Resaisir le nouveau mot de passe :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(28, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 21)
        Label4.TabIndex = 9
        Label4.Text = "Nouveau mot de passe :"
        ' 
        ' NVmotPTextBox2
        ' 
        NVmotPTextBox2.Location = New Point(289, 248)
        NVmotPTextBox2.Name = "NVmotPTextBox2"
        NVmotPTextBox2.Size = New Size(251, 23)
        NVmotPTextBox2.TabIndex = 8
        ' 
        ' NVmotPTextBox1
        ' 
        NVmotPTextBox1.Location = New Point(289, 195)
        NVmotPTextBox1.Name = "NVmotPTextBox1"
        NVmotPTextBox1.Size = New Size(251, 23)
        NVmotPTextBox1.TabIndex = 6
        ' 
        ' AcMotpTextBox
        ' 
        AcMotpTextBox.Location = New Point(289, 136)
        AcMotpTextBox.Name = "AcMotpTextBox"
        AcMotpTextBox.Size = New Size(251, 23)
        AcMotpTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(28, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 21)
        Label2.TabIndex = 3
        Label2.Text = "Ancienne mot de passe :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(396, 37)
        Label1.TabIndex = 2
        Label1.Text = "Changement de Mot de Passe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(112), CByte(161), CByte(255))
        Label3.Location = New Point(3, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 32)
        Label3.TabIndex = 1
        ' 
        ' ChangementMotPForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 420)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(559, 420)
        MinimumSize = New Size(559, 420)
        Name = "ChangementMotPForm"
        Text = "Form7"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NVmotPTextBox2 As TextBox
    Friend WithEvents NVmotPTextBox1 As TextBox
    Friend WithEvents AcMotpTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Valider As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
End Class
