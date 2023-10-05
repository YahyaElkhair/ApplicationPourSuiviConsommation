Imports System.Data.OleDb

Public Class NouvelleConsommationForm

    Dim provider As String = "Provider=Microsoft.ace.oledb.12.0 ; Data source = C:\Users\yahya\OneDrive\Bureau\ALL\RapportStage\Suivi_Consommation-20230909T220447Z-001\Suivi_Consommation\Suivi_ConsommationDB.accdb"
    Dim cnn As New OleDbConnection(provider)
    Dim sql As String

    Public Property UserCIN As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        Dim annee As Integer = currentDate.Year
        Dim listeannee() As String = New String(annee - 1971) {}

        Dim listemois() As String = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"}
        MoisComboBox.Items.AddRange(listemois)

        For i As Integer = 1971 To annee
            listeannee(i - 1971) = i.ToString()
        Next

        AnneeComboBox.Items.AddRange(listeannee)

        ElectricteChart.Titles.Add("Consommation d'éléctricté")
        EauChart.Titles.Add("Consommation d'eau")

    End Sub

    Private Sub EauRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EauRadioButton.CheckedChanged
        Label6.Text = "en M3"
        Label6.Visible = True
    End Sub

    Private Sub ElectriciteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ElectriciteRadioButton.CheckedChanged
        Label6.Text = "en KWH"
        Label6.Visible = True

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AjouterButton.Click
        Dim choixannee As String = AnneeComboBox.SelectedItem
        Dim choixmoi As String = MoisComboBox.SelectedItem
        Dim volume As String = VolumeTextBox.Text
        Dim montant As String = MontantTextBox.Text
        Dim type As String


        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim caracteres As String = "!@#$%^&*()-_+=[{]}\|;:',<>/?`~ "
        Dim result1 As Boolean = False
        Dim result2 As Boolean = False

        For Each element As Char In volume
            If alphabet.Contains(element) Then
                result1 = True
                Exit For
            ElseIf caracteres.Contains(element) Then
                result1 = True
                Exit For
            End If
        Next

        For Each element As Char In montant
            If alphabet.Contains(element) Then
                result2 = True
                Exit For
            ElseIf caracteres.Contains(element) Then
                result2 = True
                Exit For
            End If
        Next


        If choixannee = "" Then
            MessageBox.Show("Choisir une année")
        ElseIf choixmoi = "" Then
            MessageBox.Show("Choisir un moi")
        ElseIf Not EauRadioButton.Checked And Not ElectriciteRadioButton.Checked Then
            MessageBox.Show("Choisir un type de consommation")
        ElseIf VolumeTextBox.Text = "" Then
            MessageBox.Show("Saisir le volume")
        ElseIf MontantTextBox.Text = "" Then
            MessageBox.Show("Saisir le montant de votre consommation")
        ElseIf result1 Then
            MessageBox.Show("Saisir juste un ou des nombres dans le volume")

        ElseIf result2 Then
            MessageBox.Show("Saisir juste un ou des nombres dans le montant")

        Else
            cnn.Open()
            Dim cmd As New OleDbCommand

            If EauRadioButton.Checked Then
                type = "Eau"
                sql = "SELECT CNI FROM Consommations WHERE CNI = @CNI AND TypeConsommation = @TypeConsommation"
                Dim cmd2 As New OleDbCommand(sql, cnn)
                cmd2.Parameters.AddWithValue("@CNI", UserCIN)
                cmd2.Parameters.AddWithValue("@TypeConsommation", type)

                Dim r As OleDbDataReader = cmd2.ExecuteReader()

                sql = "SELECT Annee FROM Consommations WHERE Annee = @Annee AND TypeConsommation = @TypeConsommation"
                Dim cmd3 As New OleDbCommand(sql, cnn)
                cmd3.Parameters.AddWithValue("@Annee", choixannee)
                cmd3.Parameters.AddWithValue("@TypeConsommation", type)

                Dim r2 As OleDbDataReader = cmd3.ExecuteReader()

                sql = "SELECT Moi FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation = @TypeConsommation"
                Dim cmmd As New OleDbCommand(sql, cnn)
                cmmd.Parameters.AddWithValue("@CNI", UserCIN)
                cmmd.Parameters.AddWithValue("@Annee", choixannee)
                cmmd.Parameters.AddWithValue("@Moi", choixmoi)
                cmmd.Parameters.AddWithValue("@TypeConsommation", type)
                Dim r3 As OleDbDataReader = cmmd.ExecuteReader()

                If Not r2.HasRows() Then

                    ' Supprimer toutes les données de la série "Volume en m3"
                    EauChart.Series("Volume en m3").Points.Clear()

                    ' Supprimer toutes les données de la série "Montant"
                    EauChart.Series("Montant").Points.Clear()
                End If

                If Not r.HasRows Or Not r2.HasRows Or Not r3.HasRows() Then
                    sql = "INSERT INTO Consommations (CNI,TypeConsommation ,Annee ,Moi) VALUES (@UserCIN,@type ,@choixannee, @choixmoi)"
                    Dim cmd1 As New OleDbCommand(sql, cnn)
                    cmd1.Parameters.AddWithValue("@UserCIN", UserCIN)
                    cmd1.Parameters.AddWithValue("@type", type)
                    cmd1.Parameters.AddWithValue("@choixannee", choixannee)
                    cmd1.Parameters.AddWithValue("@choixmoi", choixmoi)
                    cmd1.ExecuteNonQuery()
                End If

                Select Case choixmoi
                    Case "Janvier"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"

                        EauChart.Series("Volume en m3").Points.AddXY("Janvier", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)


                    Case "Février"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"

                        EauChart.Series("Volume en m3").Points.AddXY("Février", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)


                    Case "Mars"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"

                        EauChart.Series("Volume en m3").Points.AddXY("Mars", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Avril"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Avril", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)


                    Case "Mai"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Mai", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Juin"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Juin", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Juillet"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Juillet", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Aout"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Aout", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Septembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Septembre", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Octobre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Octobre", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Novembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Novembre", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                    Case "Décembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        EauChart.Series("Volume en m3").Points.AddXY("Décembre", volume)
                        EauChart.Series("Montant").Points.AddXY("", montant)

                End Select
                ElectricteChart.Visible = False
                EauChart.Visible = True

            Else

                type = "Electricite"
                sql = "SELECT CNI FROM Consommations WHERE CNI = @CNI AND TypeConsommation = @TypeConsommation"
                Dim cmd2 As New OleDbCommand(sql, cnn)
                cmd2.Parameters.AddWithValue("@CNI", UserCIN)
                cmd2.Parameters.AddWithValue("@TypeConsommation", type)
                Dim r As OleDbDataReader = cmd2.ExecuteReader()

                sql = "SELECT Annee FROM Consommations WHERE Annee = @Annee AND TypeConsommation = @TypeConsommation"
                Dim cmd3 As New OleDbCommand(sql, cnn)
                cmd3.Parameters.AddWithValue("@Annee", choixannee)
                cmd3.Parameters.AddWithValue("@TypeConsommation", type)
                Dim r2 As OleDbDataReader = cmd3.ExecuteReader()

                sql = "SELECT Moi FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation = @TypeConsommation"
                Dim cmmd As New OleDbCommand(sql, cnn)
                cmmd.Parameters.AddWithValue("@CNI", UserCIN)
                cmmd.Parameters.AddWithValue("@Annee", choixannee)
                cmmd.Parameters.AddWithValue("@Moi", choixmoi)
                cmmd.Parameters.AddWithValue("@TypeConsommation", type)
                Dim r3 As OleDbDataReader = cmmd.ExecuteReader()

                If Not r2.HasRows() Then

                    ' Supprimer toutes les données de la série "Volume en m3"
                    ElectricteChart.Series("Volume en KWH").Points.Clear()

                    ' Supprimer toutes les données de la série "Montant"
                    ElectricteChart.Series("Montant").Points.Clear()
                End If

                If Not r.HasRows Or Not r2.HasRows Or Not r3.HasRows() Then

                    sql = "INSERT INTO Consommations (CNI,TypeConsommation ,Annee ,Moi) VALUES (@UserCIN,@type ,@choixannee, @choixmoi)"
                    Dim cmd1 As New OleDbCommand(sql, cnn)
                    cmd1.Parameters.AddWithValue("@UserCIN", UserCIN)
                    cmd1.Parameters.AddWithValue("@type", type)
                    cmd1.Parameters.AddWithValue("@choixannee", choixannee)
                    cmd1.Parameters.AddWithValue("@choixmoi", choixmoi)
                    cmd1.ExecuteNonQuery()


                End If

                Select Case choixmoi
                    Case "Janvier"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Janvier", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Février"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"

                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Février", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)


                    Case "Mars"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"

                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Mars", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Avril"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Avril", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)


                    Case "Mai"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Mai", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Juin"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Juin", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Juillet"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Juillet", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Aout"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Aout", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Septembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Septembre", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Octobre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Octobre", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Novembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @TypeConsommation"


                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Novembre", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                    Case "Décembre"
                        sql = "UPDATE Consommations SET VolumeConsommation = @volume , Montant = @montant WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi AND TypeConsommation= @type"

                        ElectricteChart.Series("Volume en KWH").Points.AddXY("Décembre", volume)
                        ElectricteChart.Series("Montant").Points.AddXY("", montant)

                End Select
                ElectricteChart.Visible = True
                EauChart.Visible = False

            End If
            cmd.Connection = cnn
            cmd.CommandText = sql

            cmd.Parameters.AddWithValue("@volume", volume)
            cmd.Parameters.AddWithValue("@montant", montant)
            cmd.Parameters.AddWithValue("@CNI", UserCIN)
            cmd.Parameters.AddWithValue("@Annee", choixannee)
            cmd.Parameters.AddWithValue("@Moi", choixmoi)
            cmd.Parameters.AddWithValue("@type", type)

            cmd.ExecuteNonQuery()
            cnn.Close()

        End If
    End Sub

End Class