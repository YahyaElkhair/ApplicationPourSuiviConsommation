<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        creerCompte = New Button()
        connexion = New Button()
        Label4 = New Label()
        MotPTextBox = New TextBox()
        Label3 = New Label()
        CinTextBox = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(12), CByte(56), CByte(73))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(107, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(491, 393)
        Panel1.TabIndex = 8
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
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(creerCompte)
        Panel2.Controls.Add(connexion)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(MotPTextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(CinTextBox)
        Panel2.Location = New Point(279, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(220, 393)
        Panel2.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(1), CByte(163), CByte(164))
        Label7.Location = New Point(7, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 45)
        Label7.TabIndex = 9
        Label7.Text = "Bienvenu"
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
        ' creerCompte
        ' 
        creerCompte.BackColor = Color.FromArgb(CByte(10), CByte(110), CByte(137))
        creerCompte.Cursor = Cursors.Hand
        creerCompte.FlatStyle = FlatStyle.Flat
        creerCompte.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        creerCompte.ForeColor = Color.White
        creerCompte.Location = New Point(7, 301)
        creerCompte.Name = "creerCompte"
        creerCompte.Size = New Size(194, 36)
        creerCompte.TabIndex = 6
        creerCompte.Text = "Créer un Compte"
        creerCompte.UseVisualStyleBackColor = False
        ' 
        ' connexion
        ' 
        connexion.BackColor = Color.FromArgb(CByte(10), CByte(110), CByte(137))
        connexion.Cursor = Cursors.Hand
        connexion.FlatStyle = FlatStyle.Flat
        connexion.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        connexion.ForeColor = Color.White
        connexion.Location = New Point(7, 259)
        connexion.Name = "connexion"
        connexion.Size = New Size(194, 36)
        connexion.TabIndex = 5
        connexion.Text = "Connexion"
        connexion.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(7, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 20)
        Label4.TabIndex = 4
        Label4.Text = "Mot de Passe"
        ' 
        ' MotPTextBox
        ' 
        MotPTextBox.BackColor = Color.FromArgb(CByte(225), CByte(237), CByte(240))
        MotPTextBox.BorderStyle = BorderStyle.FixedSingle
        MotPTextBox.Location = New Point(7, 196)
        MotPTextBox.Name = "MotPTextBox"
        MotPTextBox.Size = New Size(194, 23)
        MotPTextBox.TabIndex = 3
        MotPTextBox.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 97)
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
        CinTextBox.Location = New Point(7, 125)
        CinTextBox.Name = "CinTextBox"
        CinTextBox.Size = New Size(194, 23)
        CinTextBox.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(640, 417)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximumSize = New Size(660, 460)
        MinimumSize = New Size(660, 460)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Se Connecter"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CinTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MotPTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents connexion As Button
    Friend WithEvents creerCompte As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
