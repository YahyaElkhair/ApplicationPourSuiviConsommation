<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouvelleConsommationForm
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
        Dim ChartArea3 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series5 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series6 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea4 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend4 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series7 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series8 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Panel3 = New Panel()
        Label7 = New Label()
        VolumeTextBox = New TextBox()
        Label6 = New Label()
        AjouterButton = New Button()
        Panel1 = New Panel()
        ElectricteChart = New DataVisualization.Charting.Chart()
        EauChart = New DataVisualization.Charting.Chart()
        MontantTextBox = New TextBox()
        Label5 = New Label()
        MoisComboBox = New ComboBox()
        Label4 = New Label()
        ElectriciteRadioButton = New RadioButton()
        EauRadioButton = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        AnneeComboBox = New ComboBox()
        Label3 = New Label()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ElectricteChart, ComponentModel.ISupportInitialize).BeginInit()
        CType(EauChart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(206), CByte(214), CByte(224))
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(VolumeTextBox)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(AjouterButton)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(MontantTextBox)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(MoisComboBox)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(ElectriciteRadioButton)
        Panel3.Controls.Add(EauRadioButton)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(AnneeComboBox)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 420)
        Panel3.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(3, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 20)
        Label7.TabIndex = 18
        Label7.Text = "Montant en DH"
        ' 
        ' VolumeTextBox
        ' 
        VolumeTextBox.Location = New Point(267, 113)
        VolumeTextBox.Name = "VolumeTextBox"
        VolumeTextBox.Size = New Size(268, 23)
        VolumeTextBox.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(58, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 16
        Label6.Visible = False
        ' 
        ' AjouterButton
        ' 
        AjouterButton.BackColor = Color.PaleGreen
        AjouterButton.Cursor = Cursors.Hand
        AjouterButton.FlatStyle = FlatStyle.Flat
        AjouterButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AjouterButton.Location = New Point(212, 390)
        AjouterButton.Name = "AjouterButton"
        AjouterButton.Size = New Size(162, 23)
        AjouterButton.TabIndex = 15
        AjouterButton.Text = "Ajouter"
        AjouterButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ElectricteChart)
        Panel1.Controls.Add(EauChart)
        Panel1.Location = New Point(0, 174)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(559, 210)
        Panel1.TabIndex = 14
        ' 
        ' ElectricteChart
        ' 
        ElectricteChart.BackColor = Color.FromArgb(CByte(75), CByte(207), CByte(250))
        ChartArea3.Name = "ChartArea1"
        ElectricteChart.ChartAreas.Add(ChartArea3)
        ElectricteChart.Dock = DockStyle.Fill
        Legend3.Name = "Legend1"
        ElectricteChart.Legends.Add(Legend3)
        ElectricteChart.Location = New Point(0, 0)
        ElectricteChart.Name = "ElectricteChart"
        ElectricteChart.Palette = DataVisualization.Charting.ChartColorPalette.Excel
        Series5.BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series5.BackSecondaryColor = Color.White
        Series5.BorderWidth = 0
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Volume en KWH"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Montant"
        ElectricteChart.Series.Add(Series5)
        ElectricteChart.Series.Add(Series6)
        ElectricteChart.Size = New Size(559, 210)
        ElectricteChart.TabIndex = 18
        ElectricteChart.Text = "Chart1"
        ElectricteChart.Visible = False
        ' 
        ' EauChart
        ' 
        EauChart.BackColor = Color.FromArgb(CByte(75), CByte(207), CByte(250))
        ChartArea4.Name = "ChartArea1"
        EauChart.ChartAreas.Add(ChartArea4)
        EauChart.Dock = DockStyle.Fill
        Legend4.Name = "Legend1"
        EauChart.Legends.Add(Legend4)
        EauChart.Location = New Point(0, 0)
        EauChart.Name = "EauChart"
        EauChart.Palette = DataVisualization.Charting.ChartColorPalette.Pastel
        Series7.BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series7.BackSecondaryColor = Color.White
        Series7.BorderWidth = 0
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Volume en m3"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series8.LabelBorderWidth = 0
        Series8.Legend = "Legend1"
        Series8.Name = "Montant"
        Series8.YValuesPerPoint = 2
        EauChart.Series.Add(Series7)
        EauChart.Series.Add(Series8)
        EauChart.Size = New Size(559, 210)
        EauChart.TabIndex = 15
        EauChart.Text = "Chart1"
        EauChart.Visible = False
        ' 
        ' MontantTextBox
        ' 
        MontantTextBox.Location = New Point(267, 143)
        MontantTextBox.Name = "MontantTextBox"
        MontantTextBox.Size = New Size(268, 23)
        MontantTextBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(3, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 20)
        Label5.TabIndex = 12
        Label5.Text = "Volume"
        ' 
        ' MoisComboBox
        ' 
        MoisComboBox.Cursor = Cursors.Hand
        MoisComboBox.FlatStyle = FlatStyle.Flat
        MoisComboBox.FormattingEnabled = True
        MoisComboBox.IntegralHeight = False
        MoisComboBox.ItemHeight = 15
        MoisComboBox.Location = New Point(266, 44)
        MoisComboBox.Name = "MoisComboBox"
        MoisComboBox.Size = New Size(269, 23)
        MoisComboBox.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(3, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 20)
        Label4.TabIndex = 10
        Label4.Text = "Choisir le moi de consommation"
        ' 
        ' ElectriciteRadioButton
        ' 
        ElectriciteRadioButton.AutoSize = True
        ElectriciteRadioButton.Location = New Point(427, 81)
        ElectriciteRadioButton.Name = "ElectriciteRadioButton"
        ElectriciteRadioButton.Size = New Size(76, 19)
        ElectriciteRadioButton.TabIndex = 9
        ElectriciteRadioButton.TabStop = True
        ElectriciteRadioButton.Text = "Eléctricité"
        ElectriciteRadioButton.UseVisualStyleBackColor = True
        ' 
        ' EauRadioButton
        ' 
        EauRadioButton.AutoSize = True
        EauRadioButton.Location = New Point(321, 83)
        EauRadioButton.Name = "EauRadioButton"
        EauRadioButton.Size = New Size(44, 19)
        EauRadioButton.TabIndex = 8
        EauRadioButton.TabStop = True
        EauRadioButton.Text = "Eau"
        EauRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(3, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 20)
        Label2.TabIndex = 7
        Label2.Text = "Choisir le type de consommation"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(3, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 20)
        Label1.TabIndex = 6
        Label1.Text = "Choisir l'année de consommation"
        ' 
        ' AnneeComboBox
        ' 
        AnneeComboBox.Cursor = Cursors.Hand
        AnneeComboBox.FlatStyle = FlatStyle.Flat
        AnneeComboBox.FormattingEnabled = True
        AnneeComboBox.IntegralHeight = False
        AnneeComboBox.ItemHeight = 15
        AnneeComboBox.Location = New Point(266, 4)
        AnneeComboBox.Name = "AnneeComboBox"
        AnneeComboBox.Size = New Size(269, 23)
        AnneeComboBox.TabIndex = 5
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
        ' NouvelleConsommationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 420)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(559, 420)
        MinimumSize = New Size(559, 420)
        Name = "NouvelleConsommationForm"
        Text = "Nouvelle Consommation "
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(ElectricteChart, ComponentModel.ISupportInitialize).EndInit()
        CType(EauChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents VolumeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AjouterButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ElectricteChart As DataVisualization.Charting.Chart
    Friend WithEvents EauChart As DataVisualization.Charting.Chart
    Friend WithEvents MontantTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MoisComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ElectriciteRadioButton As RadioButton
    Friend WithEvents EauRadioButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AnneeComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
