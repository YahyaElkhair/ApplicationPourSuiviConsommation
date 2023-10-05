Imports System.Data.OleDb

Public Class CreationCompte

    Dim provider As String = "Provider=Microsoft.ace.oledb.12.0 ; Data source = C:\Users\yahya\OneDrive\Bureau\ALL\RapportStage\Suivi_Consommation-20230909T220447Z-001\Suivi_Consommation\Suivi_ConsommationDB.accdb"
    Dim cnn As New OleDbConnection(provider)
    Dim sql As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listeMp() As String = {"Un mot de passe fort contient : ", "- Au mois 6 caractère.", "- Au mois un alphabet en majuscule.", "- Au mois une caractére spécial. EX : (&,@,*,.).", "- Au mois un Nombre."}
        ListBox1.Items.AddRange(listeMp)
    End Sub



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


    Private Sub MotPTextBox_TextChanged(sender As Object, e As EventArgs) Handles MotPTextBox.GotFocus
        ListBox1.Visible = True
    End Sub


    Private Sub MotPTextBox_LosteFocus(sender As Object, e As EventArgs) Handles MotPTextBox.LostFocus
        ListBox1.Visible = False
    End Sub
    Private Sub validerb_Click(sender As Object, e As EventArgs) Handles validerb.Click

        Dim cni As String = CinTextBox.Text
        Dim nom As String = NomPTextBox.Text
        Dim prenom As String = PrenomTextBox.Text
        Dim motp1 As String = MotPTextBox.Text
        Dim motp2 As String = MotP2TextBox.Text

        Dim TailleMotp As Integer = MotPTextBox.TextLength


        cnn.Open()
        sql = "SELECT * FROM Utilisateur WHERE CNI = @CNI"
        Dim cmd As New OleDbCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@CNI", cni)
        Dim r1 As OleDbDataReader = cmd.ExecuteReader()


        If cni = "" Or nom = "" Or prenom = "" Or motp1 = "" Or motp2 = "" Then
            MessageBox.Show("Veuillez remplir toutes les champs demandés")
        Else
            ' Vérification du CIN
            If r1.HasRows Then
                Label11.Text = "*le CNI " & "(" & cni & ")" & " existe déjà"
                Label11.ForeColor = Color.FromArgb(255, 107, 107)
                CinTextBox.BackColor = Color.FromArgb(255, 107, 107)
            Else
                Label11.Text = ""
                CinTextBox.BackColor = Color.FromArgb(225, 237, 240)
            End If

            ' Vérification de la longueur du mot de passe
            If TailleMotp < 6 Then
                Label12.Text = "*le mot de passe est très court"
                Label12.ForeColor = Color.FromArgb(255, 107, 107)
                MotPTextBox.BackColor = Color.FromArgb(255, 107, 107)
                Label13.Text = "*le mot de passe est très court"
                Label13.ForeColor = Color.FromArgb(255, 107, 107)
                MotP2TextBox.BackColor = Color.FromArgb(255, 107, 107)
            Else
                ' Vérification de la force du mot de passe
                If BonMotPasse(motp1) = False Then
                    Label12.Text = "*le mot de passe n'est pas fort"
                    Label12.ForeColor = Color.FromArgb(255, 107, 107)
                    MotPTextBox.BackColor = Color.FromArgb(255, 107, 107)
                Else
                    Label12.Text = ""
                    MotPTextBox.BackColor = Color.FromArgb(225, 237, 240)
                End If

                ' Vérification de la correspondance des mots de passe
                If motp1 <> motp2 Then
                    Label13.Text = "*le mot de passe n'est pas le même"
                    Label13.ForeColor = Color.FromArgb(255, 107, 107)
                    MotP2TextBox.BackColor = Color.FromArgb(255, 107, 107)
                Else
                    Label13.Text = ""
                    MotP2TextBox.BackColor = Color.FromArgb(225, 237, 240)
                End If

                ' Toutes les conditions sont satisfaites
                If motp1 = motp2 And BonMotPasse(motp1) And Not r1.HasRows Then
                    sql = "INSERT INTO Utilisateur (CNI, Nom, Prenom, MotPasse) VALUES (@cni, @nom, @prenom, @motp1)"
                    Dim cmd1 As New OleDbCommand(sql, cnn)
                    cmd1.Parameters.AddWithValue("CNI", cni)
                    cmd1.Parameters.AddWithValue("Nom", nom)
                    cmd1.Parameters.AddWithValue("Prenom", prenom)
                    cmd1.Parameters.AddWithValue("MotPasse", motp1)

                    cmd1.ExecuteNonQuery()

                    MessageBox.Show("Votre compte est créé avec succé")

                    CinTextBox.Text = ""
                    NomPTextBox.Text = ""
                    PrenomTextBox.Text = ""
                    MotPTextBox.Text = ""
                    MotP2TextBox.Text = ""

                    Me.Hide()
                    Form1.Show()
                End If
            End If
        End If

        cnn.Close()
    End Sub



    Private Sub retourb_Click(sender As Object, e As EventArgs) Handles retourb.Click
        CinTextBox.Clear()
        NomPTextBox.Clear()
        PrenomTextBox.Clear()
        MotPTextBox.Clear()
        MotP2TextBox.Clear()
        Me.Hide()
        Form1.Show()
    End Sub


End Class