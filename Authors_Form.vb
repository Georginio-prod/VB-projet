Imports System.IO
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium

Public Class Authors_Form
    Dim author As New Authors()
    Private writer As Object

    Private Sub Authors_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auteur.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\auteur.png")

        ' Définir AutoGenerateColumns sur True
        DataGridView_authors.AutoGenerateColumns = True

        ' Charger les données dans le DataGridView
        DataGridView_authors.DataSource = author.getAllAuthors()

        ' Afficher les en-têtes de colonne
        DataGridView_authors.ColumnHeadersVisible = True



        ' Mise en page du DataGridView
        DataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView_authors.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
        DataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView_authors.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView_authors.EnableHeadersVisualStyles = False

        AddHandler DataGridView_authors.CellClick, AddressOf DataGridView_authors_CellClick

        'récupère le nombre d'auteur présent 
        Label_total.Text = Convert.ToString(DataGridView_authors.Rows.Count) + "Authors"

        Button_telecharger.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\book-32.png")
        Button_showAuteur.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\book-25.png")

    End Sub

    ' Bouton pour l'ajout
    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click

        Dim Name As String = TextBox_firstname.Text.Trim()
        Dim Prenoms As String = TextBox_prenom.Text.Trim()
        Dim Education As String = TextBox_education.Text
        Dim Bio As String = RichTextBox_bio.Text

        If name.Equals("") Then

            MessageBox.Show("Entrez le nom de l'Auteur ", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf prenoms.Equals("") Then

            MessageBox.Show("Entrez le prenoms de l'auteur", "Empty prenoms", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            If author.addAuthor(Name, Prenoms, Education, Bio) Then
                MessageBox.Show("Ajout réussi", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DataGridView_authors.DataSource = author.getAllAuthors()

                'récupère le nombre d'auteur présent 
                Label_total.Text = Convert.ToString(DataGridView_authors.Rows.Count) + "Authors"

            Else
                MessageBox.Show("Ajout invalide")
            End If
        End If

    End Sub



    'selection dans le tableau 
    Private Sub DataGridView_authors_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If DataGridView_authors.CurrentRow IsNot Nothing AndAlso DataGridView_authors.CurrentRow.Index <> -1 Then
                TextBox1_id.Text = DataGridView_authors.CurrentRow.Cells(0).Value.ToString()
                TextBox_firstname.Text = DataGridView_authors.CurrentRow.Cells(1).Value.ToString()
                TextBox_prenom.Text = DataGridView_authors.CurrentRow.Cells(2).Value.ToString()
                TextBox_education.Text = DataGridView_authors.CurrentRow.Cells(3).Value.ToString()
                RichTextBox_bio.Text = DataGridView_authors.CurrentRow.Cells(4).Value.ToString()
            Else
                ' La ligne actuelle est null ou la cellule sélectionnée est vide
                ' Gérer cette situation (par exemple, effacer les champs)
                TextBox1_id.Text = ""
                TextBox_firstname.Text = ""
                TextBox_prenom.Text = ""
                TextBox_education.Text = ""
                RichTextBox_bio.Text = ""
            End If
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            'MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'configuration du but editer
    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click

        Dim Name As String = TextBox_firstname.Text.Trim()
        Dim Prenoms As String = TextBox_prenom.Text.Trim()
        Dim Education As String = TextBox_education.Text
        Dim Bio As String = RichTextBox_bio.Text

        Try

            Dim id As Integer = Convert.ToInt32(TextBox1_id.Text)
            If name.Equals("") Then

                MessageBox.Show("Entrez le nom de l'Auteur ", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf prenoms.Equals("") Then

                MessageBox.Show("Entrez le prenoms de l'auteur", "Empty prenoms", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else

                If author.editAuthor(id, Name, Prenoms, Education, Bio) Then
                    MessageBox.Show("Modification réussi", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    DataGridView_authors.DataSource = author.getAllAuthors()
                Else
                    MessageBox.Show("Modification invalide")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_sup_Click(sender As Object, e As EventArgs) Handles Button_sup.Click
        Try

            Dim id As Integer = Convert.ToInt32(TextBox1_id.Text)

            'message de confirmation 
            If MessageBox.Show("Voulez vous vraiment supprimer?", "confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If author.deleteAuthor(id) Then
                    MessageBox.Show("Suppression", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    TextBox1_id.Text = ""
                    TextBox_firstname.Text = ""
                    TextBox_prenom.Text = ""
                    TextBox_education.Text = ""
                    RichTextBox_bio.Text = ""

                    DataGridView_authors.DataSource = author.getAllAuthors()

                    'récupère le nombre d'auteur présent 
                    Label_total.Text = Convert.ToString(DataGridView_authors.Rows.Count) + "Authors"

                Else
                    MessageBox.Show("Suppression invalide", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'liste des auteurs
    Private Sub Button_showAuteur_Click(sender As Object, e As EventArgs) Handles Button_showAuteur.Click

        '


    End Sub

    'télécharger les fichier 
    Private Sub Button_telecharger_Click(sender As Object, e As EventArgs) Handles Button_telecharger.Click
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
                For i As Integer = 0 To DataGridView_authors.RowCount - 1
                    Dim id As String = DataGridView_authors.Rows(i).Cells(0).Value.ToString()
                    Dim name As String = DataGridView_authors.Rows(i).Cells(1).Value.ToString()
                    Dim prenoms As String = DataGridView_authors.Rows(i).Cells(2).Value.ToString()
                    Dim fullName As String = name + " " + prenoms  ' Ajout d'un espace entre le nom et le prénom

                    ' Écrit l'ID, le nom complet et une ligne de séparation dans le fichier
                    writer.WriteLine($"ID: {id}")
                    writer.WriteLine($"Nom complet: {fullName}")
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


End Class
