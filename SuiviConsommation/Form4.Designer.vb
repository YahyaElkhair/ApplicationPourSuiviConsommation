<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableauBordF
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
        Dim ChartArea2 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series4 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea1 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series2 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Panel3 = New Panel()
        ValiderB = New Button()
        Panel4 = New Panel()
        ListBox1 = New ListBox()
        ElectriciteRadioButton = New RadioButton()
        EauRadioButton = New RadioButton()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        EauChart = New DataVisualization.Charting.Chart()
        ElectricteChart = New DataVisualization.Charting.Chart()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(EauChart, ComponentModel.ISupportInitialize).BeginInit()
        CType(ElectricteChart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(206), CByte(214), CByte(224))
        Panel3.Controls.Add(ValiderB)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(ElectriciteRadioButton)
        Panel3.Controls.Add(EauRadioButton)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 420)
        Panel3.TabIndex = 4
        ' 
        ' ValiderB
        ' 
        ValiderB.BackColor = Color.Lime
        ValiderB.Cursor = Cursors.Hand
        ValiderB.Dock = DockStyle.Bottom
        ValiderB.FlatStyle = FlatStyle.Popup
        ValiderB.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ValiderB.Location = New Point(0, 395)
        ValiderB.Name = "ValiderB"
        ValiderB.Size = New Size(559, 25)
        ValiderB.TabIndex = 10
        ValiderB.Text = "Afficher mes données"
        ValiderB.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(ListBox1)
        Panel4.Controls.Add(ElectricteChart)
        Panel4.Controls.Add(EauChart)
        Panel4.Location = New Point(0, 130)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(559, 259)
        Panel4.TabIndex = 9
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.FormattingEnabled = True
        ListBox1.HorizontalScrollbar = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(407, 82)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(152, 165)
        ListBox1.TabIndex = 11
        ListBox1.Visible = False
        ' 
        ' ElectriciteRadioButton
        ' 
        ElectriciteRadioButton.AutoSize = True
        ElectriciteRadioButton.Location = New Point(338, 90)
        ElectriciteRadioButton.Name = "ElectriciteRadioButton"
        ElectriciteRadioButton.Size = New Size(76, 19)
        ElectriciteRadioButton.TabIndex = 7
        ElectriciteRadioButton.TabStop = True
        ElectriciteRadioButton.Text = "Eléctricité"
        ElectriciteRadioButton.UseVisualStyleBackColor = True
        ' 
        ' EauRadioButton
        ' 
        EauRadioButton.AutoSize = True
        EauRadioButton.Location = New Point(250, 89)
        EauRadioButton.Name = "EauRadioButton"
        EauRadioButton.Size = New Size(44, 19)
        EauRadioButton.TabIndex = 6
        EauRadioButton.TabStop = True
        EauRadioButton.Text = "Eau"
        EauRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(4, 89)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 20)
        Label5.TabIndex = 5
        Label5.Text = "Choisir le type de consommation :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.ItemHeight = 15
        ComboBox1.Location = New Point(442, 54)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(105, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(4, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(439, 20)
        Label4.TabIndex = 3
        Label4.Text = "Choisir une année pour afficher votre consommation de cette année"
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
        ' EauChart
        ' 
        EauChart.BackColor = Color.FromArgb(CByte(75), CByte(207), CByte(250))
        ChartArea2.Name = "ChartArea1"
        EauChart.ChartAreas.Add(ChartArea2)
        EauChart.Dock = DockStyle.Fill
        Legend2.Name = "Legend1"
        EauChart.Legends.Add(Legend2)
        EauChart.Location = New Point(0, 0)
        EauChart.Name = "EauChart"
        EauChart.Palette = DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series3.BackSecondaryColor = Color.White
        Series3.BorderWidth = 0
        Series3.ChartArea = "ChartArea1"
        Series3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Volume en m3"
        Series4.ChartArea = "ChartArea1"
        Series4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Series4.IsValueShownAsLabel = True
        Series4.LabelForeColor = Color.ForestGreen
        Series4.Legend = "Legend1"
        Series4.Name = "Montant"
        EauChart.Series.Add(Series3)
        EauChart.Series.Add(Series4)
        EauChart.Size = New Size(559, 259)
        EauChart.TabIndex = 10
        EauChart.Text = "Chart1"
        EauChart.Visible = False
        ' 
        ' ElectricteChart
        ' 
        ElectricteChart.BackColor = Color.FromArgb(CByte(75), CByte(207), CByte(250))
        ChartArea1.Name = "ChartArea1"
        ElectricteChart.ChartAreas.Add(ChartArea1)
        ElectricteChart.Dock = DockStyle.Fill
        Legend1.Name = "Legend1"
        ElectricteChart.Legends.Add(Legend1)
        ElectricteChart.Location = New Point(0, 0)
        ElectricteChart.Name = "ElectricteChart"
        ElectricteChart.Palette = DataVisualization.Charting.ChartColorPalette.Excel
        Series1.BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series1.BackSecondaryColor = Color.White
        Series1.BorderWidth = 0
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Volume en KWH"
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = Color.IndianRed
        Series2.Legend = "Legend1"
        Series2.Name = "Montant"
        ElectricteChart.Series.Add(Series1)
        ElectricteChart.Series.Add(Series2)
        ElectricteChart.Size = New Size(559, 259)
        ElectricteChart.TabIndex = 15
        ElectricteChart.Text = "Chart1"
        ElectricteChart.Visible = False
        ' 
        ' TableauBordF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 420)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(559, 420)
        MinimumSize = New Size(559, 420)
        Name = "TableauBordF"
        Text = "Tbeau de Bord"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(EauChart, ComponentModel.ISupportInitialize).EndInit()
        CType(ElectricteChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents ValiderB As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ElectriciteRadioButton As RadioButton
    Friend WithEvents EauRadioButton As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ElectricteChart As DataVisualization.Charting.Chart
    Friend WithEvents EauChart As DataVisualization.Charting.Chart
End Class
