<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimulationConsommationForm
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
        Label1 = New Label()
        CommunComboBox = New ComboBox()
        UsageComboBox = New ComboBox()
        ElecPanel = New Panel()
        EauPanel = New Panel()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label9 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        ValiderButton = New Button()
        ConsommationTextBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        ElectriciteRadioButton = New RadioButton()
        EauRadioButton = New RadioButton()
        Label2 = New Label()
        Panel3.SuspendLayout()
        ElecPanel.SuspendLayout()
        EauPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel3.BackColor = Color.FromArgb(CByte(206), CByte(214), CByte(224))
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(CommunComboBox)
        Panel3.Controls.Add(UsageComboBox)
        Panel3.Controls.Add(ElecPanel)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(ValiderButton)
        Panel3.Controls.Add(ConsommationTextBox)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(ElectriciteRadioButton)
        Panel3.Controls.Add(EauRadioButton)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 420)
        Panel3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(398, 37)
        Label1.TabIndex = 22
        Label1.Text = "Simulation de Consommation"
        ' 
        ' CommunComboBox
        ' 
        CommunComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        CommunComboBox.Cursor = Cursors.Hand
        CommunComboBox.FlatStyle = FlatStyle.Flat
        CommunComboBox.FormattingEnabled = True
        CommunComboBox.IntegralHeight = False
        CommunComboBox.ItemHeight = 15
        CommunComboBox.Location = New Point(233, 184)
        CommunComboBox.Name = "CommunComboBox"
        CommunComboBox.Size = New Size(296, 23)
        CommunComboBox.TabIndex = 21
        CommunComboBox.Visible = False
        ' 
        ' UsageComboBox
        ' 
        UsageComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        UsageComboBox.Cursor = Cursors.Hand
        UsageComboBox.FlatStyle = FlatStyle.Flat
        UsageComboBox.FormattingEnabled = True
        UsageComboBox.IntegralHeight = False
        UsageComboBox.ItemHeight = 15
        UsageComboBox.Location = New Point(233, 146)
        UsageComboBox.Name = "UsageComboBox"
        UsageComboBox.Size = New Size(296, 23)
        UsageComboBox.TabIndex = 6
        ' 
        ' ElecPanel
        ' 
        ElecPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ElecPanel.BackColor = Color.White
        ElecPanel.Controls.Add(EauPanel)
        ElecPanel.Controls.Add(Label14)
        ElecPanel.Controls.Add(Label13)
        ElecPanel.Controls.Add(Label12)
        ElecPanel.Controls.Add(Label11)
        ElecPanel.Controls.Add(Label10)
        ElecPanel.Controls.Add(Label8)
        ElecPanel.Controls.Add(Label7)
        ElecPanel.Dock = DockStyle.Bottom
        ElecPanel.Location = New Point(0, 219)
        ElecPanel.Name = "ElecPanel"
        ElecPanel.Size = New Size(559, 167)
        ElecPanel.TabIndex = 20
        ElecPanel.Visible = False
        ' 
        ' EauPanel
        ' 
        EauPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        EauPanel.BackColor = Color.White
        EauPanel.Controls.Add(Label20)
        EauPanel.Controls.Add(Label19)
        EauPanel.Controls.Add(Label18)
        EauPanel.Controls.Add(Label17)
        EauPanel.Controls.Add(Label16)
        EauPanel.Controls.Add(Label9)
        EauPanel.Controls.Add(Label15)
        EauPanel.Dock = DockStyle.Bottom
        EauPanel.Location = New Point(0, 0)
        EauPanel.Name = "EauPanel"
        EauPanel.Size = New Size(559, 167)
        EauPanel.TabIndex = 33
        EauPanel.Visible = False
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(388, 87)
        Label20.Name = "Label20"
        Label20.Size = New Size(0, 25)
        Label20.TabIndex = 27
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.FromArgb(CByte(46), CByte(134), CByte(193))
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(12, 87)
        Label19.Name = "Label19"
        Label19.Size = New Size(361, 21)
        Label19.TabIndex = 26
        Label19.Text = "Total                                                                               :"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(391, 51)
        Label18.Name = "Label18"
        Label18.Size = New Size(0, 25)
        Label18.TabIndex = 25
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.FromArgb(CByte(46), CByte(134), CByte(193))
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(12, 51)
        Label17.Name = "Label17"
        Label17.Size = New Size(306, 21)
        Label17.TabIndex = 24
        Label17.Text = "Prix Unitiaire                                                   :"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(391, 16)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 25)
        Label16.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(46), CByte(134), CByte(193))
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(282, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 21)
        Label9.TabIndex = 23
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.FromArgb(CByte(46), CByte(134), CByte(193))
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(12, 16)
        Label15.Name = "Label15"
        Label15.Size = New Size(276, 21)
        Label15.TabIndex = 22
        Label15.Text = "Consommation D'eau en M3 (Tranche "
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(390, 108)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 25)
        Label14.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Red
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(12, 108)
        Label13.Name = "Label13"
        Label13.Size = New Size(365, 21)
        Label13.TabIndex = 24
        Label13.Text = "Total :                                                                               "
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(390, 62)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 25)
        Label12.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Red
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(12, 62)
        Label11.Name = "Label11"
        Label11.Size = New Size(362, 21)
        Label11.TabIndex = 22
        Label11.Text = "Prix Unitaire :                                                                 "
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(390, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 25)
        Label10.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Red
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(333, 16)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 21)
        Label8.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Red
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(12, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(325, 21)
        Label7.TabIndex = 2
        Label7.Text = "Consommation D'éléctricité en KWH (Tranche"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(124, 101)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 21)
        Label6.TabIndex = 19
        Label6.Visible = False
        ' 
        ' ValiderButton
        ' 
        ValiderButton.BackColor = Color.Lime
        ValiderButton.Cursor = Cursors.Hand
        ValiderButton.Dock = DockStyle.Bottom
        ValiderButton.FlatStyle = FlatStyle.Flat
        ValiderButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ValiderButton.Location = New Point(0, 386)
        ValiderButton.Name = "ValiderButton"
        ValiderButton.Size = New Size(559, 34)
        ValiderButton.TabIndex = 18
        ValiderButton.Text = "Valider"
        ValiderButton.UseVisualStyleBackColor = False
        ' 
        ' ConsommationTextBox
        ' 
        ConsommationTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ConsommationTextBox.BorderStyle = BorderStyle.FixedSingle
        ConsommationTextBox.Location = New Point(233, 99)
        ConsommationTextBox.Name = "ConsommationTextBox"
        ConsommationTextBox.Size = New Size(296, 23)
        ConsommationTextBox.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 21)
        Label5.TabIndex = 14
        Label5.Text = "Commune :"
        Label5.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 21)
        Label4.TabIndex = 13
        Label4.Text = "Consommation "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 21)
        Label3.TabIndex = 12
        Label3.Text = "Usage :"
        ' 
        ' ElectriciteRadioButton
        ' 
        ElectriciteRadioButton.AutoSize = True
        ElectriciteRadioButton.Location = New Point(449, 60)
        ElectriciteRadioButton.Name = "ElectriciteRadioButton"
        ElectriciteRadioButton.Size = New Size(76, 19)
        ElectriciteRadioButton.TabIndex = 11
        ElectriciteRadioButton.TabStop = True
        ElectriciteRadioButton.Text = "Eléctricité"
        ElectriciteRadioButton.UseVisualStyleBackColor = True
        ' 
        ' EauRadioButton
        ' 
        EauRadioButton.AutoSize = True
        EauRadioButton.Location = New Point(233, 59)
        EauRadioButton.Name = "EauRadioButton"
        EauRadioButton.Size = New Size(44, 19)
        EauRadioButton.TabIndex = 10
        EauRadioButton.TabStop = True
        EauRadioButton.Text = "Eau"
        EauRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 21)
        Label2.TabIndex = 1
        Label2.Text = "Type de consommation :"
        ' 
        ' SimulationConsommationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 420)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(559, 420)
        MinimumSize = New Size(559, 420)
        Name = "SimulationConsommationForm"
        Text = "Form6"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ElecPanel.ResumeLayout(False)
        ElecPanel.PerformLayout()
        EauPanel.ResumeLayout(False)
        EauPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents CommunComboBox As ComboBox
    Friend WithEvents UsageComboBox As ComboBox
    Friend WithEvents ElecPanel As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ValiderButton As Button
    Friend WithEvents ConsommationTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ElectriciteRadioButton As RadioButton
    Friend WithEvents EauRadioButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EauPanel As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
End Class
