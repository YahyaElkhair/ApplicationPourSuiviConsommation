Imports System.Data.OleDb
Public Class TableauBordF

    Dim provider As String = "Provider=Microsoft.ace.oledb.12.0 ; Data source = C:\Users\yahya\OneDrive\Bureau\ALL\RapportStage\Suivi_Consommation-20230909T220447Z-001\Suivi_Consommation\Suivi_ConsommationDB.accdb"
    Dim cnn As New OleDbConnection(provider)
    Dim sql As String

    Public Property UserCIN As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        Dim heur As Integer = currentDate.Hour
        Dim nom, prenom As String

        cnn.Open()
        sql = "SELECT Nom , Prenom FROM Utilisateur WHERE CNI = @CNI"
        Dim cmd As New OleDbCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@CNI", UserCIN)
        Dim r As OleDbDataReader = cmd.ExecuteReader()

        r.Read()
        nom = r.GetString(0)
        prenom = r.GetString(1)
        r.Close()


        If heur > 0 And heur < 12 Then
            Label3.Text = "Bonjour " & nom & " " & prenom
        Else
            Label3.Text = "Bonsoir " & nom & " " & prenom
        End If

        Dim anee As String = currentDate.Year
        Dim listeAnnee() As String = New String(anee - 1971) {}

        For i As Integer = 1971 To anee
            listeAnnee(i - 1971) = i.ToString()
        Next

        ComboBox1.Items.AddRange(listeAnnee)


        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ValiderB.Click
        Dim ChoixAnnee As String = ComboBox1.SelectedItem
        Dim VolumeC As String = 0
        Dim Montant As String = 0
        Dim type As String
        Dim i As Integer

        cnn.Open()
        If ChoixAnnee = "" Then
            MessageBox.Show("Choisir une année")
        ElseIf Not EauRadioButton.Checked And Not ElectriciteRadioButton.Checked Then
            MessageBox.Show("Choisir un type de consommation")
        Else

            If EauRadioButton.Checked Then
                type = "Eau"

                ' Supprimer toutes les données de la série "Volume en m3"
                EauChart.Series("Volume en m3").Points.Clear()
                ' Supprimer toutes les données de la série "Montant"
                EauChart.Series("Montant").Points.Clear()



                For i = 0 To 11
                    Dim monthName As String = DateAndTime.MonthName(i + 1, False)

                    sql = "SELECT VolumeConsommation , Montant FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND TypeConsommation = @TypeConsommation AND Moi = @Moi"
                    Dim cmd1 As New OleDbCommand(sql, cnn)
                    cmd1.Parameters.AddWithValue("CNI", UserCIN)
                    cmd1.Parameters.AddWithValue("@Annee", ChoixAnnee)
                    cmd1.Parameters.AddWithValue("@TypeConsommation", type)
                    cmd1.Parameters.AddWithValue("@Moi", monthName)
                    Dim r1 As OleDbDataReader = cmd1.ExecuteReader()


                    If r1.HasRows() Then
                        sql = "SELECT Moi FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi"
                        Dim cmmmd As New OleDbCommand(sql, cnn)

                        cmmmd.Parameters.AddWithValue("@CNI", UserCIN)
                        cmmmd.Parameters.AddWithValue("@Annee", ChoixAnnee)
                        cmmmd.Parameters.AddWithValue("@Moi", monthName)
                        Dim reader As OleDbDataReader = cmmmd.ExecuteReader()

                        If reader.HasRows() Then
                            r1.Read()
                            VolumeC = r1("VolumeConsommation")
                            Montant = r1("Montant")

                            EauChart.Series("Volume en m3").Points.AddXY(monthName, VolumeC)
                            EauChart.Series("Montant").Points.AddXY("", Montant)
                        Else
                            EauChart.Series("Volume en m3").Points.AddXY(monthName, 0)
                            EauChart.Series("Montant").Points.AddXY("", 0)
                        End If
                        r1.Close()
                    End If
                Next
                EauChart.Titles.Clear()
                EauChart.Titles.Add("Consommation d'eau en M3 pour l'année " & ChoixAnnee)

                'min max moy --------------------
                ListBox1.Items.Clear()
                Dim min, max As Integer
                Dim moy As Double
                Dim mi, mo, ma As String

                sql = "SELECT CNI FROM Consommations WHERE CNI = @CNI"
                Dim cmmd As New OleDbCommand(sql, cnn)
                cmmd.Parameters.AddWithValue("@CNI", UserCIN)
                Dim r11 As OleDbDataReader = cmmd.ExecuteReader()

                If r11.HasRows() Then
                    sql = "SELECT min(VolumeConsommation) AS minvolume , avg(VolumeConsommation) as moyvolume , max(VolumeConsommation) as maxvolume FROM Consommations WHERE CNI = @CNI AND TypeConsommation = @TypeConsommation"
                    Dim cmd As New OleDbCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@CNI", UserCIN)
                    cmd.Parameters.AddWithValue("@TypeConsommation", type)
                    Dim r As OleDbDataReader = cmd.ExecuteReader()
                    r.Read()
                    min = r("minvolume")
                    moy = r("moyvolume")
                    max = r("maxvolume")
                    mi = "Consommation minimale d'électricité en M3 : " & min
                    mo = "Moyenne de consommation d'électricité en M3: " & moy
                    ma = "Consommation max d'électricité en M3 : " & max
                    Dim listeC() As String = {mi, mo, ma, "Nb : ces valeurs pour toutes les années."}
                    ListBox1.Items.AddRange(listeC)
                    r.Close()
                Else
                    min = 0
                    moy = 0
                    max = 0
                    mi = "Consommation minimale d'électricité en M3 : " & min
                    mo = "Moyenne de consommation d'électricité en M3: " & moy
                    ma = "Consommation max d'électricité en M3 : " & max
                    Dim listeC() As String = {mi, mo, ma, "Nb : ces valeurs pour toutes les années."}
                    ListBox1.Items.AddRange(listeC)
                End If



                ListBox1.Visible = True
                EauChart.Visible = True
                ElectricteChart.Visible = False
                EauRadioButton.Checked = False

            ElseIf ElectriciteRadioButton.Checked Then
                type = "Electricite"

                ' Supprimer toutes les données de la série "Volume en KWH"
                ElectricteChart.Series("Volume en KWH").Points.Clear()

                ' Supprimer toutes les données de la série "Montant"
                ElectricteChart.Series("Montant").Points.Clear()



                For i = 0 To 11
                    Dim monthName As String = DateAndTime.MonthName(i + 1, False)

                    sql = "SELECT VolumeConsommation , Montant  FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND TypeConsommation = @TypeConsommation AND Moi = @Moi"
                    Dim cmd1 As New OleDbCommand(sql, cnn)
                    cmd1.Parameters.AddWithValue("CNI", UserCIN)
                    cmd1.Parameters.AddWithValue("@Annee", ChoixAnnee)
                    cmd1.Parameters.AddWithValue("@TypeConsommation", type)
                    cmd1.Parameters.AddWithValue("@Moi", monthName)

                    Dim r1 As OleDbDataReader = cmd1.ExecuteReader()
                    If r1.HasRows() Then
                        sql = "SELECT Moi FROM Consommations WHERE CNI = @CNI AND Annee = @Annee AND Moi = @Moi"
                        Dim cmmmd As New OleDbCommand(sql, cnn)
                        cmmmd.Parameters.AddWithValue("@CNI", UserCIN)
                        cmmmd.Parameters.AddWithValue("@Annee", ChoixAnnee)
                        cmmmd.Parameters.AddWithValue("@Moi", monthName)
                        Dim reader As OleDbDataReader = cmmmd.ExecuteReader()

                        If reader.HasRows() Then
                            r1.Read()
                            VolumeC = r1("VolumeConsommation")
                            Montant = r1("Montant")

                            ElectricteChart.Series("Volume en KWH").Points.AddXY(monthName, VolumeC)
                            ElectricteChart.Series("Montant").Points.AddXY("", Montant)
                            r1.Close()

                        Else
                            ElectricteChart.Series("Volume en KWH").Points.AddXY(monthName, 0)
                            ElectricteChart.Series("Montant").Points.AddXY("", 0)
                        End If
                    End If
                Next
                ElectricteChart.Titles.Clear()
                ElectricteChart.Titles.Add("Consommation d'éléctricté en KWH pour l'année " & ChoixAnnee)

                'min max moy ----------------------------------
                ListBox1.Items.Clear()

                Dim min, max As Integer
                Dim moy As Double
                Dim mi, mo, ma As String

                sql = "SELECT CNI FROM Consommations WHERE CNI = @CNI"
                Dim cmmd As New OleDbCommand(sql, cnn)
                cmmd.Parameters.AddWithValue("@CNI", UserCIN)
                Dim r11 As OleDbDataReader = cmmd.ExecuteReader()

                If r11.HasRows() Then
                    sql = "SELECT min(VolumeConsommation) AS minvolume , avg(VolumeConsommation) as moyvolume , max(VolumeConsommation) as maxvolume FROM Consommations WHERE CNI = @CNI AND TypeConsommation = @TypeConsommation"
                    Dim cmd As New OleDbCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@CNI", UserCIN)
                    cmd.Parameters.AddWithValue("@TypeConsommation", type)
                    Dim r As OleDbDataReader = cmd.ExecuteReader()
                    r.Read()
                    min = r("minvolume")
                    moy = r("moyvolume")
                    max = r("maxvolume")
                    mi = "Consommation minimale d'électricité en KWH : " & min
                    mo = "Moyenne de consommation d'électricité en KWH: " & moy
                    ma = "Consommation max d'électricité en KWH : " & max
                    Dim listeC() As String = {mi, mo, ma, "Nb : ces valeurs pour toutes les années."}
                    ListBox1.Items.AddRange(listeC)
                    r.Close()
                Else
                    min = 0
                    moy = 0
                    max = 0
                    mi = "Consommation minimale d'électricité en KWH : " & min
                    mo = "Moyenne de consommation d'électricité en KWH: " & moy
                    ma = "Consommation max d'électricité en KWH : " & max
                    Dim listeC() As String = {mi, mo, ma, "Nb : ces valeurs pour toutes les années."}
                    ListBox1.Items.AddRange(listeC)
                End If
            End If

        End If
        ListBox1.Visible = True
        EauChart.Visible = False
        ElectricteChart.Visible = True
        ElectriciteRadioButton.Checked = False
        cnn.Close()

    End Sub

End Class