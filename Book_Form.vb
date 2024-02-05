Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Book_Form
    Private ReadOnly dtgList As Object
    Dim genre As New Genre()
    Dim book As New Book()

    Private Sub Book_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Définir AutoGenerateColumns sur True
        DataGridView_Book.AutoGenerateColumns = True

        ' Charger les données dans le DataGridView
        DataGridView_Book.DataSource = book.getAllBook()

        ' Afficher les en-têtes de colonne
        DataGridView_Book.ColumnHeadersVisible = True

        ' Mise en page du DataGridView
        DataGridView_Book.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView_Book.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular)
        DataGridView_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView_Book.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView_Book.EnableHeadersVisualStyles = False

        AddHandler DataGridView_Book.CellClick, AddressOf DataGridView_Book_CellClick

        'AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellContentClick
        ' Initialisation des contrôles dans la deuxième page (PageListe)
        DataGridView_Book.AutoGenerateColumns = True
        DataGridView_Book.DataSource = book.getAllBook()
        DataGridView_Book.ColumnHeadersVisible = True
        DataGridView_Book.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView_Book.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Regular)
        DataGridView_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView_Book.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView_Book.EnableHeadersVisualStyles = False
        AddHandler DataGridView_Book.CellClick, AddressOf DataGridView_Book_CellClick


        Guna2ComboBox_genre.DataSource = genre.getAllGenre()
        Guna2ComboBox_genre.DisplayMember = "Name"
        Guna2ComboBox_genre.ValueMember = "id"


        Guna2TextBox_recherche.PlaceholderText = "En fonction de title/isbn/auteur"

    End Sub

    ' Pour sélectionner les auteurs depuis le formulaire d'auteur
    Private Sub Button_select_Click(sender As Object, e As EventArgs) Handles Button_select.Click

        Dim authorsF As New Authors_List_Form(Me)
        authorsF.ShowDialog()
        Try
            If DataGridView_Book.CurrentRow IsNot Nothing AndAlso DataGridView_Book.CurrentRow.Index <> -1 Then
                Guna2TextBox_isbn.Text = DataGridView_Book.CurrentRow.Cells(0).Value.ToString()
                Guna2TextBox_auteur.Text = DataGridView_Book.CurrentRow.Cells(1).Value.ToString()
                Guna2TextBox_editeur.Text = DataGridView_Book.CurrentRow.Cells(2).Value.ToString()
                Guna2ComboBox_genre.Text = DataGridView_Book.CurrentRow.Cells(3).Value.ToString()
                Guna2ComboBox_typelivre.Text = DataGridView_Book.CurrentRow.Cells(4).Value.ToString()
                Guna2DateTimePicker2_daterecu.Text = DataGridView_Book.CurrentRow.Cells(5).Value.ToString()
                Guna2DateTimePicker_datePublier.Text = DataGridView_Book.CurrentRow.Cells(6).Value.ToString()
                Guna2TextBox_title.Text = DataGridView_Book.CurrentRow.Cells(7).Value.ToString()
                Guna2NumericUpDown1_quantiter.Text = DataGridView_Book.CurrentRow.Cells(8).Value.ToString()
                Guna2TextBox_prix.Text = DataGridView_Book.CurrentRow.Cells(9).Value.ToString()





            Else
                ' La ligne actuelle est null ou la cellule sélectionnée est vide
                ' Gérer cette situation (par exemple, effacer les champs)
                Guna2TextBox_prix.Text = ""
                Guna2TextBox_isbn.Text = ""
                Guna2TextBox_auteur.Text = ""
                Guna2TextBox_editeur.Text = ""
                Guna2ComboBox_genre.Text = ""
                Guna2ComboBox_typelivre.Text = ""
                Guna2DateTimePicker2_daterecu.Text = ""
                Guna2DateTimePicker2_daterecu.Text = ""
                Guna2DateTimePicker_datePublier.Text = ""
                Guna2TextBox_title.Text = ""
                Guna2NumericUpDown1_quantiter.Text = ""
            End If
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            'MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button_enregistrer_Click(sender As Object, e As EventArgs) Handles Button_enregistre.Click
        Try
            ' Récupération des valeurs des contrôles
            Dim isbn As String = Guna2TextBox_isbn.Text.Trim()
            Dim title As String = Guna2TextBox_title.Text.Trim()
            Dim auteur_id As String = Guna2TextBox_auteur.Text.Trim()
            Dim genre_id As String = Guna2ComboBox_genre.Text.Trim()
            Dim prix As Double = Convert.ToDouble(Guna2TextBox_prix.Text)
            Dim quantite As Integer = Convert.ToInt32(Guna2NumericUpDown1_quantiter.Value)
            Dim type_livre As String = Guna2ComboBox_typelivre.Text.Trim()
            Dim datePublier As Date = Guna2DateTimePicker_datePublier.Value
            Dim dateRecu As Date = Guna2DateTimePicker2_daterecu.Value
            Dim Editeur As String = Guna2TextBox_editeur.Text.Trim()

            ' Vérification des champs obligatoires
            If String.IsNullOrEmpty(isbn) OrElse String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(auteur_id) OrElse String.IsNullOrEmpty(genre_id) OrElse String.IsNullOrEmpty(Editeur) Then
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Appel de la méthode d'ajout du livre
            If book.addBook(isbn, title, auteur_id, genre_id, Editeur, datePublier, type_livre, quantite, prix, dateRecu) Then
                MessageBox.Show("Le livre a été ajouté avec succès")

                DataGridView_Book.DataSource = book.getAllBook()
                'DataGridView1.DataSource = book.getAllBook()

                ' Réinitialiser les champs
                ResetFields()

            Else
                MessageBox.Show("Erreur lors de l'ajout du livre")
            End If

        Catch ex As FormatException
            MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les valeurs entrées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Réinitialiser les champs du formulaire
    Private Sub ResetFields()
        Guna2TextBox_prix.Text = ""
        Guna2TextBox_isbn.Text = ""
        Guna2TextBox_auteur.Text = ""
        Guna2TextBox_editeur.Text = ""
        Guna2ComboBox_genre.Text = ""
        Guna2ComboBox_typelivre.Text = ""
        Guna2DateTimePicker2_daterecu.Text = ""
        Guna2DateTimePicker_datePublier.Text = ""
        Guna2TextBox_title.Text = ""
        Guna2NumericUpDown1_quantiter.Text = ""
        TextBox1_id.Text = ""
    End Sub

    ' Gérer le clic sur une cellule du DataGridView
    Private Sub DataGridView_Book_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Book.CellClick
        Try
            If DataGridView_Book.CurrentRow IsNot Nothing AndAlso DataGridView_Book.CurrentRow.Index <> -1 Then
                TextBox1_id.Text = DataGridView_Book.CurrentRow.Cells(0).Value.ToString()
                Guna2TextBox_isbn.Text = DataGridView_Book.CurrentRow.Cells(1).Value.ToString()
                Guna2TextBox_title.Text = DataGridView_Book.CurrentRow.Cells(2).Value.ToString()
                Guna2TextBox_auteur.Text = DataGridView_Book.CurrentRow.Cells(3).Value.ToString()
                Guna2ComboBox_genre.Text = DataGridView_Book.CurrentRow.Cells(4).Value.ToString()
                Guna2TextBox_prix.Text = DataGridView_Book.CurrentRow.Cells(10).Value.ToString()
                Guna2TextBox_editeur.Text = DataGridView_Book.CurrentRow.Cells(5).Value.ToString()
                Guna2DateTimePicker_datePublier.Text = DataGridView_Book.CurrentRow.Cells(6).Value.ToString()
                Guna2ComboBox_typelivre.Text = DataGridView_Book.CurrentRow.Cells(7).Value.ToString()
                Guna2NumericUpDown1_quantiter.Text = DataGridView_Book.CurrentRow.Cells(8).Value.ToString()
                Guna2DateTimePicker2_daterecu.Text = DataGridView_Book.CurrentRow.Cells(9).Value.ToString()



            Else
                ' La ligne actuelle est null ou la cellule sélectionnée est vide
                ' Gérer cette situation (par exemple, effacer les champs)
                ResetFields()
            End If
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            'MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Button_supp_Click(sender As Object, e As EventArgs) Handles Button_supp.Click
        Try

            Dim id As Integer = Convert.ToInt32(TextBox1_id.Text)

            'message de confirmation 
            If MessageBox.Show("Voulez vous vraiment supprimer?", "confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If book.deleteBook(id) Then
                    MessageBox.Show("Suppression", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DataGridView_Book.DataSource = book.getAllBook()

                    ' Réinitialiser les champs
                    ResetFields()

                Else
                    MessageBox.Show("Suppression invalide", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReloadDtg(sql As String, dataGridView As DataGridView)
        Try
            ' Remplacez "YourConnectionStringHere" par votre chaîne de connexion SQL
            Using connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=;Database=vb_library_db")
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(sql, connection)
                    adapter.Fill(dataTable)
                End Using

                ' Assurez-vous que le DataGridView a été correctement configuré (AutoGenerateColumns, etc.)
                dataGridView.AutoGenerateColumns = True
                dataGridView.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite lors du chargement des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Le gestionnaire d'événements Guna2TextBox_recherche_TextChanged est corrigé
    Private Sub Guna2TextBox_recherche_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox_recherche.TextChanged
        Try
            Dim sql As String = "SELECT `id`, `isbn`, `title`, `auteur_id`, `genre_id`, `editeur`, `datePublier`, `typeLivre`, `quantite`, `dateRecu`, `prix` FROM `books` WHERE 1 AND (`title` Like '%" & Guna2TextBox_recherche.Text & "%' OR `auteur_id` Like '%" & Guna2TextBox_recherche.Text & "%' OR `isbn` Like '%" & Guna2TextBox_recherche.Text & "%')"

            ' Appeler la fonction ReloadDtg avec la requête SQL et la référence DataGridView_Book
            ReloadDtg(sql, DataGridView_Book)
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    'Private Sub Button_modifier_Click(sender As Object, e As EventArgs) Handles Button_modifier.Click
    'Try
    ' Récupération des valeurs des contrôles
    'Dim isbn As String = Guna2TextBox_isbn.Text.Trim()
    'Dim title As String = Guna2TextBox_title.Text.Trim()
    ' Dim auteur_id As String = Guna2TextBox_auteur.Text.Trim()
    '      Dim genre_id As String = Guna2ComboBox_genre.Text.Trim()
    '      Dim prix As Double = Convert.ToDouble(Guna2TextBox_prix.Text)
    ' Dim quantite As Integer = Convert.ToInt32(Guna2NumericUpDown1_quantiter.Value)
    'Dim type_livre As String = Guna2ComboBox_typelivre.Text.Trim()
    ' Dim datePublier As Date = Guna2DateTimePicker_datePublier.Value
    ' Dim dateRecu As Date = Guna2DateTimePicker2_daterecu.Value
    'Dim Editeur As String = Guna2TextBox_editeur.Text.Trim()

    ' Vérification des champs obligatoires
    'If String.IsNullOrEmpty(isbn) OrElse String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(auteur_id) OrElse String.IsNullOrEmpty(genre_id) OrElse String.IsNullOrEmpty(Editeur) Then
    '       MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' Exit Sub
    '   End If

    ' Récupérer les valeurs actuelles depuis le DataGridView
    ' Dim currentIsbn As String = DataGridView_Book.CurrentRow.Cells(0).Value.ToString()
    '   Dim currentTitle As String = DataGridView_Book.CurrentRow.Cells(7).Value.ToString()

    ' Vérifier si l'ISBN et le Titre n'ont pas été modifiés
    '  If isbn = currentIsbn AndAlso title = currentTitle Then
    ' L'ISBN et le Titre n'ont pas été modifiés, empêcher la modification
    '     MessageBox.Show("Veuillez modifier au moins l'ISBN ou le Titre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '   Else
    ' Appel de la méthode d'édition du livre
    '    If book.editBook(isbn, title, auteur_id, genre_id, Editeur, datePublier, type_livre, quantite, prix, dateRecu) Then
    '  MessageBox.Show("Le livre a été modifié avec succès")

    ' Actualiser le DataGridView
    '         DataGridView_Book.DataSource = book.getAllBook()

    ' Réinitialiser les champs
    '          ResetFields()

    '      Else
    '       MessageBox.Show("Erreur lors de la modification du livre")
    '      End If
    '   End If

    '    Catch ex As FormatException
    '    MessageBox.Show("Erreur de format dans les données saisies. Veuillez vérifier les valeurs entrées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '  Catch ex As Exception
    '      MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '   End Try
    ' End Sub

End Class
