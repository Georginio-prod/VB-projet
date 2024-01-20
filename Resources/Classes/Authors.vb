Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class Authors
    Dim db As New MyDb()

    ' Ajout d'auteur
    Public Function addAuthor(ByVal name As String, ByVal prenoms As String, ByVal Education As String, ByVal bio As String)
        Dim query As String = "INSERT INTO `authors`(`name`, `prenoms`, `education`, `bio`) VALUES (@name, @prenoms, @education, @bio)"
        Dim params(3) As MySqlParameter

        params(0) = New MySqlParameter("@name", MySqlDbType.VarChar)
        params(0).Value = name

        params(1) = New MySqlParameter("@prenoms", MySqlDbType.VarChar)
        params(1).Value = prenoms

        params(2) = New MySqlParameter("@education", MySqlDbType.VarChar)
        params(2).Value = Education

        params(3) = New MySqlParameter("@bio", MySqlDbType.VarChar)
        params(3).Value = bio

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Edit d'auteur
    Public Function editAuthor(ByVal id As Integer, ByVal name As String, ByVal prenoms As String, ByVal Education As String, ByVal bio As String)
        Dim query As String = "UPDATE `authors` SET `id`=@id,`name`=@name,`prenoms`= @prenoms,`education`=@education,`bio`=@bio WHERE 1"
        Dim params(4) As MySqlParameter

        params(0) = New MySqlParameter("@name", MySqlDbType.VarChar)
        params(0).Value = name

        params(1) = New MySqlParameter("@prenoms", MySqlDbType.VarChar)
        params(1).Value = prenoms

        params(2) = New MySqlParameter("@education", MySqlDbType.VarChar)
        params(2).Value = Education

        params(3) = New MySqlParameter("@bio", MySqlDbType.VarChar)
        params(3).Value = bio

        params(4) = New MySqlParameter("@id", MySqlDbType.Int32)
        params(4).Value = id

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function deleteAuthor(ByVal id As Integer) As Boolean
        Dim query As String = "DELETE FROM `authors` WHERE `id` = @id"
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
    Public Function getAllAuthors() As DataTable
        Dim selectQuery As String = "SELECT * FROM `authors`"
        Dim tableAuthors As DataTable = db.getData(selectQuery, Nothing)
        Return tableAuthors
    End Function

    'récupérer les id de l'auteur

    Public Function getAllAuthorById(ByVal authorId As Integer) As DataTable

        Dim selectQuery As String = "SELECT * FROM `authors` WHERE `id` =@id"

        Dim params(0) As MySqlParameter

        params(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        params(0).Value = authorId

        Dim authorData As DataTable = db.getData(selectQuery, params)

        Return authorData
    End Function
End Class
