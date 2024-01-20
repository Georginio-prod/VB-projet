Public Class Genre_Form
    Dim genre As New Genre()

    Private Sub Button_add_Click_1(sender As Object, e As EventArgs) Handles Button_add.Click
        Try
            Dim genreName As String = TextBox_name.Text.Trim()

            If genreName.Equals("") Then
                MessageBox.Show("Veuillez entrer le nom du genre.")
            Else
                If genre.AddGenre(genreName) Then
                    MessageBox.Show("Le genre a été ajouté avec succès.")
                    RefreshDataGridView()

                    TextBox1_id.Text = ""
                    TextBox_name.Text = ""
                Else
                    MessageBox.Show("Le genre existe déjà ou une erreur est survenue.")
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub Button_Edit_Click_1(sender As Object, e As EventArgs) Handles Button_Edit.Click
        Try
            Dim id As Integer = Convert.ToInt32(TextBox1_id.Text)
            Dim genreName As String = TextBox_name.Text.Trim()

            If genreName.Equals("") Then
                MessageBox.Show("Veuillez entrer le nom du genre.")
            Else
                If genre.EditGenre(id, genreName) Then
                    MessageBox.Show("Le genre a été modifié avec succès.")
                    RefreshDataGridView()

                    TextBox1_id.Text = ""
                    TextBox_name.Text = ""
                Else
                    MessageBox.Show("Le genre n'existe pas ou une erreur est survenue.")
                End If
            End If
        Catch ex As FormatException
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub Button_Sup_Click_1(sender As Object, e As EventArgs) Handles Button_Sup.Click
        Try
            Dim id As Integer = Convert.ToInt32(TextBox1_id.Text)

            ' Afficher une boîte de dialogue de confirmation
            Dim confirmation As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce genre ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                If genre.deleteGenre(id) Then
                    MessageBox.Show("Le genre a été supprimé avec succès.")
                    RefreshDataGridView()

                    TextBox1_id.Text = ""
                    TextBox_name.Text = ""

                Else
                    MessageBox.Show("Le genre n'existe pas ou une erreur est survenue.")
                End If
            End If

        Catch ex As FormatException
            MessageBox.Show("Veuillez entrer un ID valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        Try
            ' Utilisez le DataGridView existant pour l'actualisation
            DataGridView1.DataSource = genre.getAllGenre()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub HandleException(ex As Exception)
        MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Genre_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label_genre.Image = Image.FromFile("C:\Users\Georginio\Desktop\Projets\VB\Gestion\IMAGES\genre.png")

        RefreshDataGridView()

        'mise en page du dataGrid
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Ariel", 14, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView1.EnableHeadersVisualStyles = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1_id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox_name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub
End Class
