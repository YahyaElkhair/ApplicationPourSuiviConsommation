Imports System.Net.Security
Imports FxResources.System.Data

Public Class SimulationConsommationForm
    Private Sub SimulationConsommationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EauRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EauRadioButton.CheckedChanged
        Label6.Text = " en M3 :"
        Label6.Visible = True

        Label5.Visible = True
        CommunComboBox.Visible = True

        Dim ListeUsageEau() As String = {"Usage maisonière", "Usage préférentielle", "Usage industriel", "Usage administratif"}
        UsageComboBox.Items.Clear()
        UsageComboBox.Items.AddRange(ListeUsageEau)

        Dim ListeCommun() As String = {"El Jadida", "Moulay Abdllah", "Sidi Bouzid", "Azemmour", "Oulad Frej", "Sidi Bennour", "Zmamra", "Bir Jdid", "Sidi Ismail", "Oulidia", "Oled Gannem"}
        CommunComboBox.Items.AddRange(ListeCommun)
    End Sub

    Private Sub ElectriciteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ElectriciteRadioButton.CheckedChanged
        Label5.Visible = False
        CommunComboBox.Visible = False
        Label6.Text = " en KWH :"
        Label6.Visible = True
        UsageComboBox.Items.Clear()
        Dim ListeUsageElec() As String = {"Usage maisonière", "Consommation Professionnelle", "Usage administratif"}
        UsageComboBox.Items.AddRange(ListeUsageElec)

    End Sub

    Private Sub ValiderButton_click(sender As Object, e As EventArgs) Handles ValiderButton.Click

        Dim consommation As String = ConsommationTextBox.Text
        Dim usage As String = UsageComboBox.SelectedItem
        Dim commun As String = CommunComboBox.SelectedItem
        Dim tranche As Integer
        Dim PrixUEau As Double
        Dim PrixUElec As Double
        Dim total As Double

        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim caracteres As String = "!@#$%^&*()-_+=[{]}\|;:',<>/?`~ "
        Dim result As Boolean = False

        For Each element As Char In consommation
            If alphabet.Contains(element) Then
                result = True
                Exit For
            ElseIf caracteres.Contains(element) Then
                result = True
                Exit For
            End If
        Next

        If Not EauRadioButton.Checked And Not ElectriciteRadioButton.Checked Then
            MessageBox.Show("Choisir un type de consommation")
        ElseIf consommation = "" Then
            MessageBox.Show("Saisir une valeur en consommation")
        ElseIf UsageComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Choisir un type d'usage")
        ElseIf CommunComboBox.Visible = True And CommunComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Choisir une commun")
        ElseIf result Then
            MessageBox.Show("Saisir juste un ou des nombres entier dans la consommation")
        Else
            If EauRadioButton.Checked Then

                If consommation >= 0 And consommation <= 6 Then
                    tranche = 1
                ElseIf consommation >= 7 And consommation <= 12 Then
                    tranche = 2
                ElseIf consommation >= 13 And consommation <= 20 Then
                    tranche = 3
                ElseIf consommation >= 21 And consommation <= 35 Then
                    tranche = 4
                Else
                    tranche = 5
                End If

                If usage = "Usage maisonière" Then
                    If commun = "El Jadida" Or commun = "Moulay Abdllah" Or commun = "Sidi Bouzid" Then
                        If tranche = 1 Then
                            PrixUEau = 3.306
                        ElseIf tranche = 2 Then
                            PrixUEau = 8.325
                        ElseIf tranche = 3 Then
                            PrixUEau = 10.325
                        ElseIf tranche = 4 Then
                            PrixUEau = 12.69
                        ElseIf tranche = 5 Then
                            PrixUEau = 12.744
                        End If
                    ElseIf commun = "Azemmour" Or commun = "Oulad Frej" Then
                        If tranche = 1 Then
                            PrixUEau = 2.643
                        ElseIf tranche = 2 Then
                            PrixUEau = 7.511
                        ElseIf tranche = 3 Then
                            PrixUEau = 7.511
                        ElseIf tranche = 4 Then
                            PrixUEau = 12.337
                        ElseIf tranche = 5 Then
                            PrixUEau = 12.401
                        End If
                    ElseIf commun = "Sidi Bennour" Or commun = "Zmamra" Or commun = "Bir Jdid" Or commun = "Sidi Ismail" Then
                        If tranche = 1 Then
                            PrixUEau = 2.643
                        ElseIf tranche = 2 Then
                            PrixUEau = 6.581
                        ElseIf tranche = 3 Then
                            PrixUEau = 6.581
                        ElseIf tranche = 4 Then
                            PrixUEau = 10.775
                        ElseIf tranche = 5 Then
                            PrixUEau = 10.839
                        End If
                    ElseIf commun = "Oulidia" Or commun = "Oled Gannem" Then
                        If tranche = 1 Then
                            PrixUEau = 2.696
                        ElseIf tranche = 2 Then
                            PrixUEau = 7.116
                        ElseIf tranche = 3 Then
                            PrixUEau = 7.116
                        ElseIf tranche = 4 Then
                            PrixUEau = 11.481
                        ElseIf tranche = 5 Then
                            PrixUEau = 11.545
                        End If
                    End If

                ElseIf usage = "Usage préférentielle" Then
                    If commun = "El Jadida" Or commun = "Moulay Abdllah" Or commun = "Sidi Bouzid" Then
                        PrixUEau = 7.693
                    ElseIf commun = "Azemmour" Or commun = "Oulad Frej" Then
                        PrixUEau = 7.982
                    ElseIf commun = "Sidi Bennour" Or commun = "Zmamra" Or commun = "Bir Jdid" Or commun = "Sidi Ismail" Then
                        PrixUEau = 7.501
                    ElseIf commun = "Oulidia" Or commun = "Oled Gannem" Then
                        PrixUEau = 6.645
                    End If
                ElseIf usage = "Usage industriel" Then
                    If commun = "El Jadida" Or commun = "Moulay Abdllah" Or commun = "Sidi Bouzid" Then
                        PrixUEau = 6.966
                    ElseIf commun = "Azemmour" Or commun = "Oulad Frej" Then
                        PrixUEau = 7.265
                    ElseIf commun = "Sidi Bennour" Or commun = "Zmamra" Or commun = "Bir Jdid" Or commun = "Sidi Ismail" Then
                        PrixUEau = 6.795
                    ElseIf commun = "Oulidia" Or commun = "Oled Gannem" Then
                        PrixUEau = 6.078
                    End If
                ElseIf usage = "Usage administratif" Then
                    If commun = "El Jadida" Or commun = "Moulay Abdllah" Or commun = "Sidi Bouzid" Then
                        PrixUEau = 12.744
                    ElseIf commun = "Azemmour" Or commun = "Oulad Frej" Then
                        PrixUEau = 12.401
                    ElseIf commun = "Sidi Bennour" Or commun = "Zmamra" Or commun = "Bir Jdid" Or commun = "Sidi Ismail" Then
                        PrixUEau = 10.839
                    ElseIf commun = "Oulidia" Or commun = "Oled Gannem" Then
                        PrixUEau = 11.545
                    End If
                End If

                total = CInt(consommation) * PrixUEau
                Label16.Text = consommation.ToString()
                Label9.Text = tranche.ToString() & ") :"
                Label18.Text = PrixUEau.ToString()
                Label20.Text = total.ToString("0.00") & " DH"
                EauPanel.Visible = True
                ElecPanel.Visible = True

            Else

                If usage = "Usage maisonière" Then
                    If consommation >= 0 And consommation <= 100 Then
                        tranche = 1
                    ElseIf consommation >= 101 And consommation <= 150 Then
                        tranche = 2
                    ElseIf consommation >= 151 And consommation <= 200 Then
                        tranche = 3
                    ElseIf consommation >= 201 And consommation <= 300 Then
                        tranche = 4
                    ElseIf consommation >= 301 And consommation <= 500 Then
                        tranche = 5
                    Else
                        tranche = 6

                    End If


                    If tranche = 1 Then
                        PrixUElec = 0.901
                    ElseIf tranche = 2 Then
                        PrixUElec = 1.0732
                    ElseIf tranche = 3 Then
                        PrixUElec = 1.1048
                    ElseIf tranche = 4 Then
                        PrixUElec = 1.1676
                    ElseIf tranche = 5 Then
                        PrixUElec = 1.3817
                    ElseIf tranche = 6 Then
                        PrixUElec = 1.5958
                    End If


                ElseIf usage = "Consommation Professionnelle" Then
                    If consommation >= 0 And consommation <= 150 Then
                        tranche = 1
                    Else
                        tranche = 2
                    End If


                    If tranche = 1 Then
                        PrixUElec = 1.5146
                    ElseIf tranche = 2 Then
                        PrixUElec = 1.709
                    End If
                ElseIf usage = "Usage administratif" Then
                    PrixUElec = 1.6452
                End If

                total = CInt(consommation) * PrixUElec

                Label8.Text = tranche.ToString() & ") : "

                Label10.Text = consommation.ToString()

                Label12.Text = PrixUElec.ToString()

                Label14.Text = total.ToString("0.00") & " DH"
                EauPanel.Visible = False
                ElecPanel.Visible = True
            End If
        End If



    End Sub


End Class