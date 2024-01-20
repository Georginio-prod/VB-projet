Imports System.IO
Imports Org.BouncyCastle.Crypto.Digests

Public Class BookCard_Form
    Dim book As New Book()
    Dim bookId As Integer
    Public Sub New(ByVal id As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bookId = id

    End Sub
    Private Sub BookCard_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim table As DataTable = book.getBookById(bookId)

        Label1.Text = table(0)("Isbn")
        Label2.Text = table(0)("Title")
        Label3.Text = table(0)("Quantite")
        Label4.Text = table(0)("Prix")
        Label5.Text = table(0)("DateRecu")

        '' Dim cover As Byte() = table.Rows(0)("Photo")
        ' Dim ms As New MemoryStream(photo)
        ' Guna2PictureBox1.Image = Image.FromStream(ms)
    End Sub


End Class