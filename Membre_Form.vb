Imports System.IO

Public Class Membre_Form

    Dim membre As New Membre()

    Private Sub Membre_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button_select.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\icons8-upload-48.png")
        'Guna2PictureBox1.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\tof.jpg")

        ' Définir AutoGenerateColumns sur True
        DataGridView_membre.AutoGenerateColumns = True

        ' Charger les données dans le DataGridView
        DataGridView_membre.DataSource = membre.getAllMembre()

        ' Afficher les en-têtes de colonne
        DataGridView_membre.ColumnHeadersVisible = True



        ' Mise en page du DataGridView
        DataGridView_membre.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView_membre.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
        DataGridView_membre.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView_membre.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView_membre.EnableHeadersVisualStyles = False

        AddHandler DataGridView_membre.CellClick, AddressOf DataGridView_membre_CellClick


        Label_total1.Text = Convert.ToString(DataGridView_membre.Rows.Count) + "Membre"


    End Sub

    Private Sub Button_select_Click(sender As Object, e As EventArgs) Handles Button_select.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Choose Image (*.jpg;*.png;*gif)|*.jpg;*.png;*gif"

        If opf.ShowDialog() = DialogResult.OK Then

            Guna2PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1_Id.Text = ""
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox5.Text = ""
        'RadioButton1.Text = ""
        'RadioButton2.Text = ""
        Guna2PictureBox1.Image = Nothing


    End Sub

    Private Sub DataGridView_membre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_membre.CellClick

        Try
            If DataGridView_membre.CurrentRow IsNot Nothing AndAlso DataGridView_membre.CurrentRow.Index <> -1 Then
                TextBox1_Id.Text = DataGridView_membre.CurrentRow.Cells(0).Value.ToString()
                Guna2TextBox5.Text = DataGridView_membre.CurrentRow.Cells(1).Value.ToString()
                Guna2TextBox3.Text = DataGridView_membre.CurrentRow.Cells(2).Value.ToString()
                Panel3.Text = DataGridView_membre.CurrentRow.Cells(3).Value.ToString()
                Guna2TextBox2.Text = DataGridView_membre.CurrentRow.Cells(4).Value.ToString()
                Guna2TextBox1.Text = DataGridView_membre.CurrentRow.Cells(5).Value.ToString()


                ' Guna2PictureBox1.Image = DataGridView_membre.CurrentRow.Cells(6).Value.ToByte()

            Else
                ' La ligne actuelle est null ou la cellule sélectionnée est vide
                ' Gérer cette situation (par exemple, effacer les champs)
                TextBox1_Id.Text = ""
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
                Guna2TextBox3.Text = ""
                Guna2TextBox5.Text = ""
                'RadioButton1.Text = ""
                'RadioButton2.Text = ""
                Guna2PictureBox1.Image = Nothing

            End If
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            'MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_ajt_Click(sender As Object, e As EventArgs) Handles Button_ajt.Click
        Try
            Dim Nom As String = Guna2TextBox1.Text.Trim()
            Dim Prenoms As String = Guna2TextBox3.Text.Trim()
            Dim Sexes As String

            If RadioButton1.Checked Then
                Sexes = "Homme"
            ElseIf RadioButton2.Checked Then
                Sexes = "Femme"
            End If

            Dim Email As String = Guna2TextBox5.Text.Trim()
            Dim Numero As Integer

            ' Vérifier si Guna2TextBox2 contient une valeur numérique
            If Integer.TryParse(Guna2TextBox2.Text, Numero) Then

                If Guna2PictureBox1.Image IsNot Nothing Then ' Vérifier si une image a été ajoutée
                    Dim stream As New MemoryStream()
                    Guna2PictureBox1.Image.Save(stream, Guna2PictureBox1.Image.RawFormat)

                    ' Vérifier si l'image est vide avant de tenter la conversion en tableau de bytes
                    If stream.Length > 0 Then
                        Dim Photo As Byte() = stream.ToArray()

                        If Nom.Equals("") Then
                            MessageBox.Show("Entrez le nom du Membre", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ElseIf Prenoms.Equals("") Then
                            MessageBox.Show("Entrez le prénom", "Empty prénom", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        ElseIf Email.Equals("") Then
                            MessageBox.Show("Entrez l'Email", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Else
                            If membre.addMembre(Nom, Prenoms, Sexes, Email, Numero, Photo) Then
                                MessageBox.Show("Ajout réussi", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                TextBox1_Id.Text = ""
                                Guna2TextBox1.Text = ""
                                Guna2TextBox2.Text = ""
                                Guna2TextBox3.Text = ""
                                Guna2TextBox5.Text = ""
                                'RadioButton1.Text = ""
                                'RadioButton2.Text = ""
                                Guna2PictureBox1.Image = Nothing

                                DataGridView_membre.DataSource = membre.getAllMembre()

                                Label_total1.Text = Convert.ToString(DataGridView_membre.Rows.Count) + "Membre"
                            Else
                                MessageBox.Show("Ajout invalide")
                            End If
                        End If
                    Else
                        MessageBox.Show("L'image ne peut pas être vide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Veuillez ajouter une image du membre.", "Image manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Le numéro doit être une valeur numérique", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As FormatException
            MessageBox.Show($"Erreur de format : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub


    'suppression
    Private Sub Button_suppre_Click(sender As Object, e As EventArgs) Handles Button_suppre.Click
        Try
            Dim id As Integer = Convert.ToInt32(TextBox1_Id.Text)

            'message de confirmation 
            If MessageBox.Show("Voulez vous vraiment supprimer?", "confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If membre.deleteMembre(id) Then
                    MessageBox.Show("Suppression", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    TextBox1_Id.Text = ""
                    Guna2TextBox1.Text = ""
                    Guna2TextBox2.Text = ""
                    Guna2TextBox3.Text = ""
                    Guna2TextBox5.Text = ""
                    'RadioButton1.Text = ""
                    'RadioButton2.Text = ""
                    Guna2PictureBox1.Image = Nothing


                    DataGridView_membre.DataSource = membre.getAllMembre()

                    Label_total1.Text = Convert.ToString(DataGridView_membre.Rows.Count) + "Membre"


                Else
                    MessageBox.Show("Suppression invalide", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_exporte.Click
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
                For i As Integer = 0 To DataGridView_membre.RowCount - 1
                    Dim Id As String = DataGridView_membre.Rows(i).Cells(0).Value.ToString()
                    Dim Nom As String = DataGridView_membre.Rows(i).Cells(1).Value.ToString()
                    Dim Prenoms As String = DataGridView_membre.Rows(i).Cells(2).Value.ToString()
                    Dim Sexes As String = DataGridView_membre.Rows(i).Cells(3).Value.ToString()
                    Dim Email As String = DataGridView_membre.Rows(i).Cells(5).Value.ToString()
                    Dim Numero As Integer = Convert.ToInt32(DataGridView_membre.Rows(i).Cells(4).Value)


                    Dim fullName As String = Nom + " " + Prenoms  ' Ajout d'un espace entre le nom et le prénom

                    ' Écrit l'ID, le nom complet et une ligne de séparation dans le fichier
                    writer.WriteLine($"ID: {Id}")
                    writer.WriteLine($"Nom complet: {fullName}")
                    writer.WriteLine($"Email: {Email}")
                    writer.WriteLine($"Sexes: {Sexes}")
                    writer.WriteLine($"Numero: {Numero}")
                    'writer.WriteLine($"Nume: {Numero}")
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

    Private Sub Panel3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class