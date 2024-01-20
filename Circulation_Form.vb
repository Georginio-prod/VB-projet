Imports System.IO
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium

Public Class Circulation_Form
    Dim circulation As New Circulation()

    Dim book As New Book()
    Dim membre As New Membre()

    Private Sub Circulation_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView_liste.DataSource = circulation.getAll("")

    End Sub


    'recherche livre 
    Private Sub ButtonR_Livre_Click(sender As Object, e As EventArgs) Handles ButtonR_Livre.Click

        Dim id As Integer = Guna2NumericUpDown1.Value
        Dim table As DataTable = book.getBookById(id)

        If table.Rows.Count > 0 Then

            Label8_Titre.Text = table.Rows(0)(2).ToString()
            Label8_Titre.ForeColor = Color.DeepSkyBlue

            'voir la disponibilté 
            If circulation.checkBookAvailability(id) Then

                Label6.Text = "YES"
                Label6.ForeColor = Color.White

            Else

                Label6.Text = "NO"
                Label6.ForeColor = Color.Red
            End If
        Else
            ' Gérez le cas où aucun livre correspondant n'est trouvé pour l'ID spécifié
            'MessageBox.Show("Livre introuvable pour l'ID spécifié.")
            Label8_Titre.Text = "le livre n'existe pas"
            Label8_Titre.ForeColor = Color.Red

            Label6.Text = "NO"
            Label6.ForeColor = Color.Red
        End If


    End Sub

    Private Sub ButtonR_membre_Click(sender As Object, e As EventArgs) Handles ButtonR_membre.Click

        Dim id As Integer = Guna2NumericUpDown3_IDM.Value
        Dim table As DataTable = membre.getMembreById(id)

        If table.Rows.Count > 0 Then

            Label9.Text = table.Rows(0)(1).ToString() + "" + table.Rows(0)(2).ToString()
            Label9.ForeColor = Color.DeepSkyBlue
        Else
            ' Gérez le cas où aucun livre correspondant n'est trouvé pour l'ID spécifié
            'MessageBox.Show("Livre introuvable pour l'ID spécifié.")
            Label9.Text = "le membre n'existe pas"
            Label9.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label8_Titre_Click(sender As Object, e As EventArgs) Handles Label8_Titre.Click

        Dim id As Integer = Guna2NumericUpDown1.Value
        Dim bookC As New BookCard_Form(id)
        bookC.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Enreg.Click

        Try
            Dim booksId As Integer = Guna2NumericUpDown1.Value
            Dim membreId As Integer = Guna2NumericUpDown3_IDM.Value
            Dim issueDate As Date = Guna2DateTimePicker2.Value
            Dim returnDate As Date = Guna2DateTimePicker1.Value

            ' Vérifier si le livre existe
            If book.getBookById(booksId).Rows.Count > 0 Then
                ' Vérifier si le membre existe
                If membre.getMembreById(membreId).Rows.Count > 0 Then
                    ' Vérifier si le livre est disponible
                    If circulation.CheckBookAvailability(booksId) Then
                        ' Vérifier si le livre est déjà prêté à ce membre
                        If circulation.isBookIssuedByToThisMember(booksId, membreId) Then
                            MessageBox.Show("Une copie de ce livre est toujours prêtée à ce membre", "Livre toujours emprunté.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            ' Ajouter le livre
                            If circulation.issue(booksId, membreId, issueDate, returnDate) Then
                                MessageBox.Show("Le livre a été ajouté avec succès", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Une erreur s'est produite lors de l'ajout du livre", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Else
                        MessageBox.Show("Ce livre n'est pas disponible actuellement", "Pas Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("L'ID du membre est indisponible", "Indisponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Ce livre n'est pas encore disponible", "Indisponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button_Intg_Click(sender As Object, e As EventArgs) Handles Button_Intg.Click

        DataGridView_liste.DataSource = circulation.getAll("")

    End Sub

    Private Sub Button_dis_Click(sender As Object, e As EventArgs) Handles Button_dis.Click

        DataGridView_liste.DataSource = circulation.getAll("distribuer")
    End Sub

    Private Sub Button_Rap_Click(sender As Object, e As EventArgs) Handles Button_Rap.Click

        DataGridView_liste.DataSource = circulation.getAll("rapporter")
    End Sub

    Private Sub Button_eg_Click(sender As Object, e As EventArgs) Handles Button_eg.Click

        DataGridView_liste.DataSource = circulation.getAll("Egarer")
    End Sub

    'exporter
    Private Sub Button_Tel_Click(sender As Object, e As EventArgs) Handles Button_Tel.Click
        ' Création d'une instance du composant SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()

        ' Définition du filtre du type de fichier et du titre
        saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        saveFileDialog.Title = "Enregistrer le fichier exporté"

        ' Affichage de la boîte de dialogue
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Utilisation du chemin choisi par l'utilisateur
            Dim filepath As String = saveFileDialog.FileName

            ' Utilisation d'un objet StreamWriter pour écrire dans le fichier
            Dim writer As New StreamWriter(filepath)

            Try
                ' Parcourt les lignes du DataGridView et écrit dans le fichier
                For i As Integer = 0 To DataGridView_liste.RowCount - 1
                    Dim id As String = DataGridView_liste.Rows(i).Cells(0).Value.ToString()
                    Dim membre_id As String = DataGridView_liste.Rows(i).Cells(1).Value.ToString()
                    Dim book_id As String = DataGridView_liste.Rows(i).Cells(2).Value.ToString()
                    Dim issue_date As String = DataGridView_liste.Rows(i).Cells(3).Value.ToString()
                    Dim return_date As String = DataGridView_liste.Rows(i).Cells(4).Value.ToString()
                    Dim status As String = DataGridView_liste.Rows(i).Cells(5).Value.ToString()

                    ' Écrit l'ID, le nom complet et une ligne de séparation dans le fichier
                    writer.WriteLine(id + " - " + membre_id + " - " + book_id + " - " + issue_date + " - " + return_date)
                    writer.WriteLine()
                    writer.WriteLine("----------------------------------")
                Next

                ' Affiche un message indiquant que le fichier a été exporté avec succès
                MessageBox.Show("Fichier exporté avec succès", "Exportation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Gère les exceptions en affichant un message d'erreur
                MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ferme le StreamWriter pour libérer les ressources
                writer.Close()
            End Try
        End If
    End Sub

    'btn return 
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim id As Integer = Guna2NumericUpDown3.Value
            Dim issueDate As Date = Guna2DateTimePicker3_R.Value
            Dim returnDate As Date = Guna2DateTimePicker4_Rt.Value
            Dim status As String = "rapporter"
            Dim note As String = RichTextBox1.Text

            If issueDate > returnDate Then
                MessageBox.Show("le retour n'est pas encore effectué", "date error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If circulation.ChangeStatus(id, status, issueDate, returnDate, note) Then
                    MessageBox.Show("Retour", "change Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Staut inchagé", "change Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'la selection dans la page de retour
    Private Sub DataGridView_liste_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_liste.CellClick

        Dim booksId As Integer = Convert.ToInt32(DataGridView_liste.CurrentRow.Cells(2).Value.ToString())
        Dim membreId As Integer = Convert.ToInt32(DataGridView_liste.CurrentRow.Cells(1).Value.ToString())
        Guna2NumericUpDown3.Value = Convert.ToDecimal(DataGridView_liste.CurrentRow.Cells(0).Value) ' Conversion en décimal si nécessaire
        Label_titreR.Text = book.getBookById(booksId).Rows(0)(2).ToString()
        Label_membreR.Text = membre.getMembreById(membreId).Rows(0)(1).ToString() & " " & membre.getMembreById(membreId).Rows(0)(2).ToString()
        Guna2DateTimePicker4_Rt.Value = Convert.ToDateTime(DataGridView_liste.CurrentRow.Cells(4).Value) ' Conversion en date si nécessaire
        Guna2DateTimePicker3_R.Value = Convert.ToDateTime(DataGridView_liste.CurrentRow.Cells(3).Value) ' Conversion en date si nécessaire
        RichTextBox1.Text = DataGridView_liste.CurrentRow.Cells(6).Value
        Label8.Text = DataGridView_liste.CurrentRow.Cells(5).Value


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim id As Integer = Guna2NumericUpDown3.Value
            Dim issueDate As Date = Guna2DateTimePicker3_R.Value
            Dim returnDate As Date = Guna2DateTimePicker4_Rt.Value
            Dim status As String = "Egarer"
            Dim note As String = RichTextBox1.Text
            Dim bookId As String = Label8.Text

            If circulation.ChangeStatus(id, status, issueDate, returnDate, note) Then
                MessageBox.Show("Livre perdu ", "change Status", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("Staut inchagé", "change Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class