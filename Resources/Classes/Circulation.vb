Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class Circulation

    Dim db As New MyDb()
    Dim book As New Book()
    Public Function issue(ByVal booksId As Integer, ByVal membreId As Integer, ByVal issueDate As Date, ByVal returnDate As Date)

        Dim query As String = "INSERT INTO `circulation`(`membre_id`, `books_id`, `issue_date`, `return_date`, `status`) VALUES (@membreId, @booksId, @issueDate, @returnDate, 'issued')"
        Dim params(3) As MySqlParameter

        params(0) = New MySqlParameter("@membreId", MySqlDbType.Int32)
        params(0).Value = membreId

        params(1) = New MySqlParameter("@booksId", MySqlDbType.Int32)
        params(1).Value = booksId

        params(2) = New MySqlParameter("@issueDate", MySqlDbType.Date)
        params(2).Value = issueDate

        params(3) = New MySqlParameter("@returnDate", MySqlDbType.Date)
        params(3).Value = returnDate



        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If

    End Function



    'fonction de retour de livre 
    Public Function ChangeStatus(ByVal Id As Integer, ByVal status As String, ByVal issueDate As Date, ByVal returnDate As Date, ByVal note As String) As Boolean
        Try
            Dim query As String = "UPDATE `circulation` SET `issue_date`=@issueDate, `return_date`=@returnDate, `status`=@status, `note`=@note WHERE `id`=@id"
            Dim params(4) As MySqlParameter

            params(0) = New MySqlParameter("@id", MySqlDbType.Int32)
            params(0).Value = Id

            params(1) = New MySqlParameter("@issueDate", MySqlDbType.Date)
            params(1).Value = issueDate

            params(2) = New MySqlParameter("@returnDate", MySqlDbType.Date)
            params(2).Value = returnDate

            params(3) = New MySqlParameter("@status", MySqlDbType.String)
            params(3).Value = status

            params(4) = New MySqlParameter("@note", MySqlDbType.Text)
            params(4).Value = note

            ' Utilisation de la méthode Equals pour comparer à 1 n'est pas nécessaire. On peut simplement vérifier si rowsAffected > 0.
            Dim rowsAffected As Integer = db.setData(query, params)

            Return rowsAffected > 0
        Catch ex As Exception
            ' Gérer l'exception ici, afficher un message d'erreur ou effectuer d'autres actions nécessaires
            Return False
        End Try
    End Function

    'fonction pour compté le nombre de livre
    Public Function countIssuedCopiesOfThisBook(ByVal booksId As Integer) As Integer
        Dim selectQuery As String = "SELECT * FROM `circulation` WHERE `books_id` =@id and status='issued'"

        Dim params(0) As MySqlParameter

        params(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        params(0).Value = booksId

        Dim count As Integer = db.getData(selectQuery, params).Rows.Count

        Return 0
    End Function

    'fonction pour vérifier si le livre est dispo
    Public Function CheckBookAvailability(ByVal bookId As Integer) As Boolean
        ' Récupérer la quantité totale de livres disponible en stock
        Dim availableQuantite As Integer = book.getBookById(bookId)(0)("quantite")

        ' Récupérer le nombre de copies déjà empruntées
        Dim issuedCopies As Integer = countIssuedCopiesOfThisBook(bookId)

        ' Vérifier si la quantité disponible est suffisante
        If availableQuantite > issuedCopies Then
            ' Le livre est disponible
            Return True
        Else
            ' Le livre n'est pas disponible
            Return False
        End If
    End Function


    Public Function isBookIssuedByToThisMember(ByVal booksId As Integer, ByVal membreId As Integer) As Integer
        Dim selectQuery As String = "SELECT * FROM `circulation` WHERE `books_id` =@booksId and membre_id=@membreId and status='issued'"

        Dim params(1) As MySqlParameter

        params(0) = New MySqlParameter("@booksId", MySqlDbType.Int32)
        params(0).Value = booksId

        params(1) = New MySqlParameter("@membreId", MySqlDbType.Int32)
        params(1).Value = booksId

        Dim count As Integer = db.getData(selectQuery, params).Rows.Count

        If count > 0 Then
            Return True

        Else
            Return False

        End If
    End Function

    Public Function getAll(ByVal status As String) As DataTable

        Dim selectQuery As String = "SELECT * FROM `circulation`"

        If Not status.Equals("") Then
            selectQuery = "SELECT * FROM `circulation` WHERE `status`='" + status + "'"
        End If

        Dim table As DataTable = db.getData(selectQuery, Nothing)
        Return table
    End Function
End Class
