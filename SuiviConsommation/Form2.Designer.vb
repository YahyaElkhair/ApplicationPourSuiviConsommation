<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreationCompte
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CreationCompte))
        Panel1 = New Panel()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        MotP2TextBox = New TextBox()
        Label9 = New Label()
        MotPTextBox = New TextBox()
        validerb = New Button()
        retourb = New Button()
        Label8 = New Label()
        PrenomTextBox = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        NomPTextBox = New TextBox()
        Label3 = New Label()
        CinTextBox = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(99), CByte(205), CByte(218))
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(70, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(556, 397)
        Panel1.TabIndex = 9
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.LightGoldenrodYellow
        ListBox1.BorderStyle = BorderStyle.FixedSingle
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(0, 222)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(291, 77)
        ListBox1.TabIndex = 19
        ListBox1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(85, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 32)
        Label2.TabIndex = 3
        Label2.Text = "Consommation"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(144, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 32)
        Label1.TabIndex = 2
        Label1.Text = "Suivi"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 146)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(MotP2TextBox)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(MotPTextBox)
        Panel2.Controls.Add(validerb)
        Panel2.Controls.Add(retourb)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(PrenomTextBox)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(NomPTextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(CinTextBox)
        Panel2.Location = New Point(279, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(289, 393)
        Panel2.TabIndex = 0
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(18, 339)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 15)
        Label13.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 271)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 15)
        Label12.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(18, 92)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 15)
        Label11.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(18, 290)
        Label10.Name = "Label10"
        Label10.Size = New Size(148, 20)
        Label10.TabIndex = 15
        Label10.Text = "Valider Mot de passe"
        ' 
        ' MotP2TextBox
        ' 
        MotP2TextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        MotP2TextBox.BorderStyle = BorderStyle.FixedSingle
        MotP2TextBox.Location = New Point(18, 313)
        MotP2TextBox.Name = "MotP2TextBox"
        MotP2TextBox.Size = New Size(240, 23)
        MotP2TextBox.TabIndex = 14
        MotP2TextBox.UseSystemPasswordChar = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(18, 222)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 20)
        Label9.TabIndex = 13
        Label9.Text = "Mot de passe"
        ' 
        ' MotPTextBox
        ' 
        MotPTextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        MotPTextBox.BorderStyle = BorderStyle.FixedSingle
        MotPTextBox.Location = New Point(18, 245)
        MotPTextBox.Name = "MotPTextBox"
        MotPTextBox.Size = New Size(240, 23)
        MotPTextBox.TabIndex = 12
        MotPTextBox.UseSystemPasswordChar = True
        ' 
        ' validerb
        ' 
        validerb.BackColor = Color.FromArgb(CByte(10), CByte(110), CByte(137))
        validerb.Cursor = Cursors.Hand
        validerb.FlatStyle = FlatStyle.Flat
        validerb.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        validerb.ForeColor = Color.White
        validerb.Location = New Point(149, 357)
        validerb.Name = "validerb"
        validerb.Size = New Size(109, 36)
        validerb.TabIndex = 6
        validerb.Text = "Valider"
        validerb.UseVisualStyleBackColor = False
        ' 
        ' retourb
        ' 
        retourb.BackColor = Color.FromArgb(CByte(10), CByte(110), CByte(137))
        retourb.Cursor = Cursors.Hand
        retourb.FlatStyle = FlatStyle.Flat
        retourb.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        retourb.ForeColor = Color.White
        retourb.Location = New Point(18, 357)
        retourb.Name = "retourb"
        retourb.Size = New Size(109, 36)
        retourb.TabIndex = 5
        retourb.Text = "Retour"
        retourb.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(18, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 20)
        Label8.TabIndex = 11
        Label8.Text = "Prenom"
        ' 
        ' PrenomTextBox
        ' 
        PrenomTextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        PrenomTextBox.BorderStyle = BorderStyle.FixedSingle
        PrenomTextBox.CharacterCasing = CharacterCasing.Upper
        PrenomTextBox.Location = New Point(18, 188)
        PrenomTextBox.Name = "PrenomTextBox"
        PrenomTextBox.Size = New Size(240, 23)
        PrenomTextBox.TabIndex = 10
        PrenomTextBox.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(1), CByte(163), CByte(164))
        Label7.Location = New Point(3, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(271, 37)
        Label7.TabIndex = 9
        Label7.Text = "Creation de compte"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(18, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 4
        Label4.Text = "Nom"
        ' 
        ' NomPTextBox
        ' 
        NomPTextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        NomPTextBox.BorderStyle = BorderStyle.FixedSingle
        NomPTextBox.CharacterCasing = CharacterCasing.Upper
        NomPTextBox.Location = New Point(18, 134)
        NomPTextBox.Name = "NomPTextBox"
        NomPTextBox.Size = New Size(240, 23)
        NomPTextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(18, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 20)
        Label3.TabIndex = 2
        Label3.Text = "CNI"
        ' 
        ' CinTextBox
        ' 
        CinTextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        CinTextBox.BorderStyle = BorderStyle.FixedSingle
        CinTextBox.CharacterCasing = CharacterCasing.Upper
        CinTextBox.Location = New Point(18, 66)
        CinTextBox.Name = "CinTextBox"
        CinTextBox.Size = New Size(240, 23)
        CinTextBox.TabIndex = 1
        ' 
        ' CreationCompte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(644, 421)
        Controls.Add(Panel1)
        MaximumSize = New Size(660, 460)
        MinimumSize = New Size(660, 460)
        Name = "CreationCompte"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Creation de Compte"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents validerb As Button
    Friend WithEvents retourb As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents NomPTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CinTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MotPTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PrenomTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MotP2TextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
