Imports System.ComponentModel

Public Class Authors_List_Form


    Dim author As New Authors()

    Dim bookForm As New Book_Form()

    Public Sub New(mBkfrm As Book_Form)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        bookForm = mBkfrm

    End Sub
    Private Sub Authors_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1_authors.DataSource = author.getAllAuthors()

        ' Mise en page du DataGridView
        DataGridView1_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView1_authors.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
        DataGridView1_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1_authors.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView1_authors.EnableHeadersVisualStyles = False


        'suppression de certain colone
        DataGridView1_authors.Columns(3).Visible = False
        DataGridView1_authors.Columns(4).Visible = False

    End Sub

    Private Sub DataGridView1_authors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_authors.CellClick


    End Sub

    Private Sub DataGridView1_authors_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_authors.CellDoubleClick
        Dim id As String = DataGridView1_authors.CurrentRow.Cells(0).Value.ToString()
        Dim Nom As String = DataGridView1_authors.CurrentRow.Cells(1).Value.ToString()
        Dim prenoms As String = DataGridView1_authors.CurrentRow.Cells(2).Value.ToString()
        Dim fulname As String = Nom + "" + prenoms

        bookForm.Guna2TextBox_auteur.Text = fulname
        bookForm.Button_select.Text = id

        Me.Close()
    End Sub

    Private Sub DataGridView1_authors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_authors.CellContentClick

    End Sub
End Class