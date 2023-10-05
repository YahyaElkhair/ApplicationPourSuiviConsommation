
Public Class TableauBordForm



    Public Property UserCIN As String



    Dim tableBordform1 As New TableauBordF()
    Dim NvConsommationform As New NouvelleConsommationForm()
    Dim SimulationConsommation As New SimulationConsommationForm()
    Dim NvMP As New ChangementMotPForm()
    Private Sub TableauBordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableBordform1.TopLevel = False
        Panel3.Controls.Add(tableBordform1)
        NvConsommationform.Hide()
        SimulationConsommation.Hide()
        NvMP.Hide()
        tableBordform1.UserCIN = UserCIN
        tableBordform1.Show()
    End Sub




    Private Sub TableBordB_Click(sender As Object, e As EventArgs) Handles TableBordB.Click
        tableBordform1.TopLevel = False
        Panel3.Controls.Add(tableBordform1)
        NvConsommationform.Hide()
        SimulationConsommation.Hide()
        NvMP.Hide()
        tableBordform1.UserCIN = UserCIN
        tableBordform1.Show()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NvConsommation.Click
        NvConsommationform.TopLevel = False
        Panel3.Controls.Add(NvConsommationform)
        tableBordform1.Hide()
        SimulationConsommation.Hide()
        NvMP.Hide()
        NvConsommationform.UserCIN = UserCIN
        NvConsommationform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SimulationCButton.Click
        SimulationConsommation.TopLevel = False
        Panel3.Controls.Add(SimulationConsommation)
        tableBordform1.Hide()
        NvConsommationform.Hide()
        NvMP.Hide()
        SimulationConsommation.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles NvMotPButton.Click
        NvMP.TopLevel = False
        Panel3.Controls.Add(NvMP)
        SimulationConsommation.Hide()
        tableBordform1.Hide()
        NvConsommationform.Hide()
        NvMP.UserCIN = UserCIN
        NvMP.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DeconnoxionButton.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class