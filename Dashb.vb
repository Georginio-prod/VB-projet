Public Class dashb
    Private Sub Dashb_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            Debug.WriteLine("Dashb_Shown: Dashb window shown.")
            Dim lgnForm As New Login_Form(Me)
            lgnForm.Show()
            Me.Enabled = True
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dashb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configuration des images
        Button_auteurs.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\auteur.png")
        Button_genre.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\genre.png")
        Button_livre.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\book.png")
        Button_membre.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\member.png")
        Button_emprunt.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\sinchronize-24.png")
        'Button_users.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\user.png")




    End Sub

    Private Sub Button_genre_Click(sender As Object, e As EventArgs) Handles Button_genre.Click

        Dim genreF As New Genre_Form()
        genreF.Show()


    End Sub

    Private Sub Button_auteurs_Click(sender As Object, e As EventArgs) Handles Button_auteurs.Click

        Dim authorsF As New Authors_Form()
        authorsF.Show()

    End Sub

    Private Sub Button_livre_Click(sender As Object, e As EventArgs) Handles Button_livre.Click

        Dim bookF As New Book_Form()
        bookF.Show()
    End Sub

    Private Sub Button_membre_Click(sender As Object, e As EventArgs) Handles Button_membre.Click
        Dim membreF As New Membre_Form()
        membreF.Show()
    End Sub

    Private Sub Button_emprunt_Click(sender As Object, e As EventArgs) Handles Button_emprunt.Click
        Dim circulationF As New Circulation_Form()
        circulationF.Show()
    End Sub

    'Private Sub Button_users_Click(sender As Object, e As EventArgs) Handles Button_users.Click
    'Dim userF As New User_Form()
    '   userF.Show()
    'End Sub
End Class
