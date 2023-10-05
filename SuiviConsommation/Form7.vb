Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class ChangementMotPForm

    Dim provider As String = "Provider=Microsoft.ace.oledb.12.0 ; Data source = C:\Users\yahya\OneDrive\Bureau\ALL\RapportStage\Suivi_Consommation-20230909T220447Z-001\Suivi_Consommation\Suivi_ConsommationDB.accdb"
    Dim cnn As New OleDbConnection(provider)
    Dim sql As String

    Public Property UserCIN As String

    Function BonMotPasse(ByVal mp As String) As Boolean

        Dim nombrs As String = "123456789"
        Dim majuscule As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim caractaires As String = "!@#$%^&*()-_+=[{]}\|;:',<.>/?`~"


        Dim isnombre As Boolean = False
        Dim ismaj As Boolean = False
        Dim iscara As Boolean = False

        For i As Integer = 0 To mp.Length
            For Each element As Char In mp
                If nombrs.Contains(element) Then
                    isnombre = True
                ElseIf majuscule.Contains(element) Then
                    ismaj = True
                ElseIf caractaires.Contains(element) Then
                    iscara = True
                End If
            Next
        Next


        Return isnombre And ismaj And iscara
    End Function

    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        Dim acnmotp As String = AcMotpTextBox.Text
        Dim nvmp1 As String = NVmotPTextBox1.Text
        Dim nvmp2 As String = NVmotPTextBox2.Text
        Dim mpdb As String

        cnn.Open()

        sql = "SELECT MotPasse FROM Utilisateur WHERE CNI = @CNI"
        Dim cmd1 As New OleDbCommand(sql, cnn)
        cmd1.Parameters.AddWithValue("@CNI", UserCIN)
        Dim r As OleDbDataReader = cmd1.ExecuteReader()
        r.Read()
        mpdb = r.GetString(0)
        r.Close()

        If acnmotp = "" And nvmp1 = "" And nvmp2 = "" Then

            MessageBox.Show("Veuillez remplir toutes les champs demandés")

        Else

            If acnmotp <> mpdb Then
                Label6.Text = "*L'encienne mot de passe n'est pas correct"
                Label6.ForeColor = Color.FromArgb(255, 107, 107)
                AcMotpTextBox.BackColor = Color.FromArgb(255, 107, 107)
            Else
                Label6.Text = ""
                AcMotpTextBox.BackColor = Color.White
            End If

            If nvmp1.Length < 6 Then
                Label7.Text = "*Le mot de passe est trés court"
                Label7.ForeColor = Color.FromArgb(255, 107, 107)
                NVmotPTextBox1.BackColor = Color.FromArgb(255, 107, 107)
            Else
                Label7.Text = ""
                NVmotPTextBox1.BackColor = Color.White
            End If

            If Not BonMotPasse(nvmp1) Then
                Label7.Text = "*Le mot de passe n'est fort"
                Label7.ForeColor = Color.FromArgb(255, 107, 107)
                NVmotPTextBox1.BackColor = Color.FromArgb(255, 107, 107)
            Else
                Label7.Text = ""
                NVmotPTextBox1.BackColor = Color.White
            End If

            If nvmp1 <> nvmp2 Then
                Label8.Text = "*Le mot de passe n'est pas le même"
                Label8.ForeColor = Color.FromArgb(255, 107, 107)
                NVmotPTextBox2.BackColor = Color.FromArgb(255, 107, 107)
            Else
                Label8.Text = ""
                NVmotPTextBox2.BackColor = Color.White
            End If

            If acnmotp = mpdb And nvmp1.Length >= 6 And BonMotPasse(nvmp1) And nvmp1 = nvmp2 Then
                sql = "UPDATE Utilisateur SET MotPasse = @nvmp1 WHERE CNI = @CNI"
                Dim cmd2 As New OleDbCommand(sql, cnn)
                cmd2.Parameters.AddWithValue("@nvmp1", nvmp1)
                cmd2.Parameters.AddWithValue("@CNI", UserCIN)
                cmd2.ExecuteNonQuery()
                Label9.Text = "*Votre mot de passe est changer avec succé"
            End If
        End If
        cnn.Close()
    End Sub
End Class