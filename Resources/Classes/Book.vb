Imports MySql.Data.MySqlClient

Public Class Book
    Dim db As New MyDb()

    Public Function addBook(ByVal Isbn As String, ByVal Titre As String, ByVal Auteur As String, ByVal Genre As String,
                            ByVal Editeur As String, ByVal Pulier As Date, ByVal Type_Livre As String,
                            ByVal Quantite As Integer, ByVal Prix As Double, ByVal Date_Recu As Date) As Boolean

        Dim query As String = "INSERT INTO `books`(`Isbn`, `Title`, `Auteur_id`, `Genre_id`, `Editeur`, 
                                `DatePublier`, `TypeLivre`, `Quantite`, `DateRecu`, `Prix`) VALUES (@Isbn, @Title,
                            @Auteur_id, @Genre_id, @Editeur, @DatePublier, @TypeLivre, @Quantite, @DateRecu, @Prix)"
        Dim params(9) As MySqlParameter

        params(0) = New MySqlParameter("@Isbn", MySqlDbType.VarChar)
        params(0).Value = Isbn

        params(1) = New MySqlParameter("@Title", MySqlDbType.VarChar)
        params(1).Value = Titre

        params(2) = New MySqlParameter("@Auteur_id", MySqlDbType.VarChar)
        params(2).Value = Auteur

        params(3) = New MySqlParameter("@Genre_id", MySqlDbType.VarChar)
        params(3).Value = Genre

        params(4) = New MySqlParameter("@Editeur", MySqlDbType.VarChar)
        params(4).Value = Editeur

        params(5) = New MySqlParameter("@Datepublier", MySqlDbType.Date)
        params(5).Value = Pulier

        params(6) = New MySqlParameter("@TypeLivre", MySqlDbType.VarChar)
        params(6).Value = Type_Livre

        params(7) = New MySqlParameter("@Quantite", MySqlDbType.Int32)
        params(7).Value = Quantite

        params(8) = New MySqlParameter("@Prix", MySqlDbType.Double)
        params(8).Value = Prix

        params(9) = New MySqlParameter("@DateRecu", MySqlDbType.Date)
        params(9).Value = Date_Recu

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function getBookById(bookId As Integer) As DataTable
            Try
                ' Remplacez "YourConnectionStringHere" par votre chaîne de connexion SQL
                Using connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=;Database=vb_library_db")
                    connection.Open()

                    Dim dataTable As New DataTable()

                    ' Remplacez la requête SQL avec celle adaptée à votre structure de base de données
                    Dim sql As String = "SELECT `id`, `isbn`, `title`, `auteur_id`, `genre_id`, `editeur`, `datePublier`, `typeLivre`, `quantite`, `dateRecu`, `prix` FROM `books` WHERE `id` = @bookId"

                    Using command As New MySqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@bookId", bookId)

                        Using adapter As New MySqlDataAdapter(command)
                            adapter.Fill(dataTable)
                        End Using
                    End Using

                    Return dataTable
                End Using
            Catch ex As Exception
                ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
                MessageBox.Show($"Une erreur s'est produite lors de la récupération des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function



    ' Edit d'auteur
    Public Function editBook(ByVal Isbn As String, ByVal Titre As String, ByVal Auteur As String, ByVal Genre As String,
                            ByVal Editeur As String, ByVal Pulier As Date, ByVal Type_Livre As String,
                            ByVal Quantite As Integer, ByVal Prix As Double, ByVal Date_Recu As Date)

        Dim query As String = "UPDATE `books` SET `Id`=@Id,`Isbn`=@Isbn,`Title`=@Title,`Auteur_id`=@Auteur_id
                            ,`Genre_id`=@Genre_id,`Editeur`=@Editeur,`DatePublier`=@DatePublier,`TypeLivre`=@TypeLivre,`Quantite`=@Quatite,
                                `DateRecu`= DateRecu,`Prix`=@Prix WHERE 1"

        Dim params(9) As MySqlParameter


        params(0) = New MySqlParameter("@Isbn", MySqlDbType.VarChar)
        params(0).Value = Isbn

        params(1) = New MySqlParameter("@Title", MySqlDbType.VarChar)
        params(1).Value = Titre

        params(2) = New MySqlParameter("@Auteur_id", MySqlDbType.VarChar)
        params(2).Value = Auteur

        params(3) = New MySqlParameter("@Genre_id", MySqlDbType.VarChar)
        params(3).Value = Genre

        params(4) = New MySqlParameter("@Editeur", MySqlDbType.VarChar)
        params(4).Value = Editeur

        params(5) = New MySqlParameter("@Datepublier", MySqlDbType.Date)
        params(5).Value = Pulier

        params(6) = New MySqlParameter("@TypeLivre", MySqlDbType.VarChar)
        params(6).Value = Type_Livre

        params(7) = New MySqlParameter("@Quantite", MySqlDbType.Int32)
        params(7).Value = Quantite

        params(8) = New MySqlParameter("@Prix", MySqlDbType.Double)
        params(8).Value = Prix

        params(9) = New MySqlParameter("@DateRecu", MySqlDbType.Date)
        params(9).Value = Date_Recu

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function deleteBook(ByVal id As Integer) As Boolean
        Dim query As String = "DELETE FROM `books` WHERE `id` = @id"
        Dim paramas(0) As MySqlParameter

        paramas(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        paramas(0).Value = id

        If db.setData(query, paramas).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    'pour récupérer les éléments du tableau
    Public Function getAllBook() As DataTable
        Dim selectQuery As String = "SELECT * FROM `books`"
        Dim tableBook As DataTable = db.getData(selectQuery, Nothing)
        Return tableBook
    End Function

    Public Function bookQuantity(ByVal Id As Integer)

        Dim query As String = "UPDATE `books` SET  `quantite`=quantite - 1  WHERE `Id`=@Id"

        Dim params(0) As MySqlParameter


        params(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        params(0).Value = Id



        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
