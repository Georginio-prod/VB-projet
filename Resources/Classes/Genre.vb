Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class Genre
    Dim db As New MyDb()

    ' Fonction pour ajouter un nouveau genre
    Public Function AddGenre(ByVal name As String) As Boolean
        Dim query As String = "INSERT INTO `genre`(`name`) VALUES (@nm)"
        Dim paramas(0) As MySqlParameter

        paramas(0) = New MySqlParameter("@nm", MySqlDbType.VarChar)
        paramas(0).Value = name

        If db.setData(query, paramas).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Fonction pour éditer un genre
    Public Function EditGenre(ByVal id As Integer, ByVal name As String) As Boolean
        Dim query As String = "UPDATE `genre` SET `name`=@nm WHERE `id` =@id"
        Dim paramas(1) As MySqlParameter

        paramas(0) = New MySqlParameter("@nm", MySqlDbType.VarChar)
        paramas(0).Value = name
        paramas(1) = New MySqlParameter("@id", MySqlDbType.Int32)
        paramas(1).Value = id

        If db.setData(query, paramas).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Fonction pour supprimer un genre
    Public Function deleteGenre(ByVal id As Integer) As Boolean
        Dim query As String = "DELETE FROM `genre` WHERE `id` = @id"
        Dim paramas(0) As MySqlParameter

        paramas(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        paramas(0).Value = id

        If db.setData(query, paramas).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Fonction pour obtenir tous les genres
    Public Function getAllGenre() As DataTable
        Dim selectQuery As String = "SELECT * FROM `genre`"


        Dim tableGenre As DataTable = db.getData(selectQuery, Nothing)
        Return tableGenre

        'Catch ex As Exception
        ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
        'MessageBox.Show($"Une erreur s'est produite lors de la récupération des genres : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Return tableGenre
        'End Try
    End Function
End Class
