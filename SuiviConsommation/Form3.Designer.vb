<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableauBordForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TableauBordForm))
        Panel1 = New Panel()
        NvMotPButton = New Button()
        DeconnoxionButton = New Button()
        SimulationCButton = New Button()
        NvConsommation = New Button()
        TableBordB = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(110), CByte(137))
        Panel1.Controls.Add(NvMotPButton)
        Panel1.Controls.Add(DeconnoxionButton)
        Panel1.Controls.Add(SimulationCButton)
        Panel1.Controls.Add(NvConsommation)
        Panel1.Controls.Add(TableBordB)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(135, 421)
        Panel1.TabIndex = 0
        ' 
        ' NvMotPButton
        ' 
        NvMotPButton.Cursor = Cursors.Hand
        NvMotPButton.Dock = DockStyle.Top
        NvMotPButton.FlatAppearance.BorderColor = Color.Silver
        NvMotPButton.FlatAppearance.BorderSize = 0
        NvMotPButton.FlatStyle = FlatStyle.Flat
        NvMotPButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NvMotPButton.ForeColor = Color.White
        NvMotPButton.Image = CType(resources.GetObject("NvMotPButton.Image"), Image)
        NvMotPButton.Location = New Point(0, 289)
        NvMotPButton.Name = "NvMotPButton"
        NvMotPButton.Size = New Size(135, 55)
        NvMotPButton.TabIndex = 6
        NvMotPButton.Text = "Chnager mot de passe"
        NvMotPButton.TextImageRelation = TextImageRelation.ImageBeforeText
        NvMotPButton.UseVisualStyleBackColor = True
        ' 
        ' DeconnoxionButton
        ' 
        DeconnoxionButton.Cursor = Cursors.Hand
        DeconnoxionButton.Dock = DockStyle.Bottom
        DeconnoxionButton.FlatAppearance.BorderColor = Color.Silver
        DeconnoxionButton.FlatAppearance.BorderSize = 0
        DeconnoxionButton.FlatStyle = FlatStyle.Flat
        DeconnoxionButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DeconnoxionButton.ForeColor = Color.White
        DeconnoxionButton.Image = CType(resources.GetObject("DeconnoxionButton.Image"), Image)
        DeconnoxionButton.Location = New Point(0, 376)
        DeconnoxionButton.Name = "DeconnoxionButton"
        DeconnoxionButton.Size = New Size(135, 45)
        DeconnoxionButton.TabIndex = 5
        DeconnoxionButton.Text = "Se déconnecter"
        DeconnoxionButton.TextImageRelation = TextImageRelation.ImageBeforeText
        DeconnoxionButton.UseVisualStyleBackColor = True
        ' 
        ' SimulationCButton
        ' 
        SimulationCButton.Cursor = Cursors.Hand
        SimulationCButton.Dock = DockStyle.Top
        SimulationCButton.FlatAppearance.BorderColor = Color.Silver
        SimulationCButton.FlatAppearance.BorderSize = 0
        SimulationCButton.FlatStyle = FlatStyle.Flat
        SimulationCButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SimulationCButton.ForeColor = Color.White
        SimulationCButton.Image = CType(resources.GetObject("SimulationCButton.Image"), Image)
        SimulationCButton.Location = New Point(0, 234)
        SimulationCButton.Name = "SimulationCButton"
        SimulationCButton.Size = New Size(135, 55)
        SimulationCButton.TabIndex = 4
        SimulationCButton.Text = "Simulation de Consommation"
        SimulationCButton.TextImageRelation = TextImageRelation.ImageBeforeText
        SimulationCButton.UseVisualStyleBackColor = True
        ' 
        ' NvConsommation
        ' 
        NvConsommation.Cursor = Cursors.Hand
        NvConsommation.Dock = DockStyle.Top
        NvConsommation.FlatAppearance.BorderColor = Color.Silver
        NvConsommation.FlatAppearance.BorderSize = 0
        NvConsommation.FlatStyle = FlatStyle.Flat
        NvConsommation.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NvConsommation.ForeColor = Color.White
        NvConsommation.Image = CType(resources.GetObject("NvConsommation.Image"), Image)
        NvConsommation.Location = New Point(0, 182)
        NvConsommation.Name = "NvConsommation"
        NvConsommation.Size = New Size(135, 52)
        NvConsommation.TabIndex = 3
        NvConsommation.Text = " Nouvelle      Consommation"
        NvConsommation.TextImageRelation = TextImageRelation.ImageBeforeText
        NvConsommation.UseVisualStyleBackColor = True
        ' 
        ' TableBordB
        ' 
        TableBordB.Cursor = Cursors.Hand
        TableBordB.Dock = DockStyle.Top
        TableBordB.FlatAppearance.BorderColor = Color.Silver
        TableBordB.FlatAppearance.BorderSize = 0
        TableBordB.FlatStyle = FlatStyle.Flat
        TableBordB.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TableBordB.ForeColor = Color.White
        TableBordB.Image = CType(resources.GetObject("TableBordB.Image"), Image)
        TableBordB.Location = New Point(0, 130)
        TableBordB.Name = "TableBordB"
        TableBordB.Size = New Size(135, 52)
        TableBordB.TabIndex = 2
        TableBordB.Text = "Tableau de Bord"
        TableBordB.TextAlign = ContentAlignment.MiddleRight
        TableBordB.TextImageRelation = TextImageRelation.ImageBeforeText
        TableBordB.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(135, 130)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 21)
        Label2.TabIndex = 2
        Label2.Text = "Consommation"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 30)
        Label1.TabIndex = 1
        Label1.Text = "Suivi"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(24, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 58)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(206), CByte(214), CByte(224))
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(135, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 420)
        Panel3.TabIndex = 2
        ' 
        ' TableauBordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 421)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        Name = "TableauBordForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tableaux de Bord"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableBordB As Button
    Friend WithEvents DeconnoxionButton As Button
    Friend WithEvents SimulationCButton As Button
    Friend WithEvents NvConsommation As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NvMotPButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
End Class
