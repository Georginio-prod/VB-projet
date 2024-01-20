Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Google.Protobuf.WellKnownTypes


Public Class Membre

    Dim db As New MyDb()

    'ajout d'un nouveau membre 

    Public Function addMembre(ByVal Nom As String, ByVal Prenoms As String, ByVal Sexes As String, ByVal Email As String, ByVal Numero As Integer, ByVal Photo As Byte())

        Dim query As String = "INSERT INTO `membre`(`Nom`, `Prenoms`, `Sexes`, `Numero`, `Email`, `Photo`) VALUES (@Nom, @Prenoms,@sexes, @Numero, @Email, @Photo)"
        Dim params(5) As MySqlParameter

        params(0) = New MySqlParameter("@Nom", MySqlDbType.VarChar)
        params(0).Value = Nom

        params(1) = New MySqlParameter("@Prenoms", MySqlDbType.VarChar)
        params(1).Value = Prenoms

        params(2) = New MySqlParameter("@Sexes", MySqlDbType.VarChar)
        params(2).Value = Sexes

        params(3) = New MySqlParameter("@Email", MySqlDbType.VarChar)
        params(3).Value = Email

        params(4) = New MySqlParameter("@Numero", MySqlDbType.Int32)
        params(4).Value = Numero

        params(5) = New MySqlParameter("@Photo", MySqlDbType.LongBlob)
        params(5).Value = Photo



        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Edit membre

    Public Function editMembre(ByVal Nom As String, ByVal Prenoms As String, ByVal Sexes As String, ByVal Email As String, ByVal Numero As Integer, ByVal Photo As Byte())

        Dim query As String = "UPDATE `membre` SET `Id`=@Id,`Nom`=@Nom,`Prenoms`=@Prenoms,`Sexes`=@Sexes,`Numero`=@Numero,`Email`=@Email,`Photo`=@Photo WHERE 1"
        Dim params(5) As MySqlParameter

        params(0) = New MySqlParameter("@Nom", MySqlDbType.VarChar)
        params(0).Value = Nom

        params(1) = New MySqlParameter("@Prenoms", MySqlDbType.VarChar)
        params(1).Value = Prenoms

        params(2) = New MySqlParameter("@Sexes", MySqlDbType.VarChar)
        params(2).Value = Sexes

        params(3) = New MySqlParameter("@Email", MySqlDbType.VarChar)
        params(3).Value = Email

        params(4) = New MySqlParameter("@Numero", MySqlDbType.Int32)
        params(4).Value = Numero

        params(5) = New MySqlParameter("@Photo", MySqlDbType.LongBlob)
        params(5).Value = Photo



        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    'dete membre
    Public Function deleteMembre(ByVal id As Integer) As Boolean
        Dim query As String = "DELETE FROM `membre` WHERE `id` = @Id"
        Dim paramas(0) As MySqlParameter

        paramas(0) = New MySqlParameter("@id", MySqlDbType.Int32)
        paramas(0).Value = id

        If db.setData(query, paramas).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getMembreById(ByVal membreId As Integer) As DataTable
        Try
            Dim selectQuery As String = "SELECT * FROM `membre` WHERE id = @id"

            Dim params(0) As MySqlParameter
            params(0) = New MySqlParameter("@id", MySqlDbType.Int32)
            params(0).Value = membreId

            ' Assurez-vous de remplacer "db.getData" par votre méthode de récupération de données
            Dim tableMembre As DataTable = db.getData(selectQuery, params)

            Return tableMembre
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            MessageBox.Show($"Une erreur s'est produite lors de la récupération des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function



    'pour récupérer les éléments du tableau
    Public Function getAllMembre() As DataTable
        Dim selectQuery As String = "SELECT * FROM `membre`"
        Dim tableMembre As DataTable = db.getData(selectQuery, Nothing)
        Return tableMembre
    End Function
End Class
