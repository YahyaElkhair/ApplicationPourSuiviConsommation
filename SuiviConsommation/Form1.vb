Imports System.Data.OleDb
Public Class Form1
    Dim provider As String = "Provider=Microsoft.ace.oledb.12.0 ; Data source = C:\Users\yahya\OneDrive\Bureau\ALL\RapportStage\Suivi_Consommation-20230909T220447Z-001\Suivi_Consommation\Suivi_ConsommationDB.accdb"
    Dim cnn As New OleDbConnection(provider)
    Dim sql As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connexion.Click
        Dim cni As String = CinTextBox.Text
        Dim motP As String = MotPTextBox.Text
        Dim motPDB As String
        cnn.Open()

        sql = "SELECT * FROM Utilisateur WHERE CNI = @CNI"

        Dim cmd As New OleDbCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@CNI", cni)
        Dim r1 As OleDbDataReader = cmd.ExecuteReader()

        sql = "SELECT MotPasse FROM Utilisateur WHERE CNI = @CNI"
        Dim cmd2 As New OleDbCommand(sql, cnn)
        cmd2.Parameters.AddWithValue("@CNI", cni)
        Dim r2 As OleDbDataReader = cmd2.ExecuteReader()



        If cni = "" Or motP = "" Then
            MessageBox.Show("Veuillez remplir toutes les champes demander")
        ElseIf Not r1.HasRows Then
            Label5.Text = "*le CNI " & "(" & cni & ")" & " n'est pas existe"
            Label5.ForeColor = Color.FromArgb(255, 107, 107)
            CinTextBox.BackColor = Color.FromArgb(255, 107, 107)

        ElseIf r1.HasRows Then
            Label5.Text = ""
            CinTextBox.BackColor = Color.FromArgb(225, 237, 240)
            r2.Read()
            motPDB = r2.GetString(0)
            r2.Close()
            If motP <> motPDB Then
                Label6.Text = "*le mot de passe est incorrect"
                Label6.ForeColor = Color.FromArgb(255, 107, 107)
                MotPTextBox.BackColor = Color.FromArgb(255, 107, 107)

            Else
                Label6.Text = ""
                MotPTextBox.BackColor = Color.FromArgb(225, 237, 240)

                Me.Hide()
                TableauBordForm.UserCIN = cni
                TableauBordForm.Show()
            End If
        End If
        cnn.Close()

    End Sub

    Private Sub creerCompte_Click(sender As Object, e As EventArgs) Handles creerCompte.Click
        Me.Hide()
        CreationCompte.Show()
    End Sub
End Class
