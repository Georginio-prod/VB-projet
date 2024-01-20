Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Login_Form
    Private dashb As Dashb

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(df As Dashb)
        InitializeComponent()
        dashb = df
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Text = "Username"
        TxtUsername.ForeColor = Color.Black

        TxtPassword.Text = "Password"
        TxtPassword.ForeColor = Color.Black
        TxtPassword.PasswordChar = "•"c ' Use '•' as the password character (note the 'c' to convert to Char)
    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        If TxtUsername.Text = "Username" Then
            TxtUsername.Text = ""
            TxtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        If TxtUsername.Text = "" Then
            TxtUsername.Text = "Username"
            TxtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus
        If TxtPassword.Text = "Password" Then
            TxtPassword.Text = ""
            TxtPassword.PasswordChar = "•"
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        If TxtPassword.Text = "" Then
            TxtPassword.Text = "Password"
            TxtPassword.ForeColor = Color.Black
            TxtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TxtPassword.PasswordChar = If(CheckBox1.Checked, ControlChars.NullChar, "•")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()

        Dim mydb As New MyDb()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass", mydb.getConnection)

        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Enter the Username", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(password) Then
            MessageBox.Show("Enter the Password", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                MessageBox.Show("Valider")
                If dashb IsNot Nothing Then
                    Enabled = True
                End If

                Me.Close()
            Else
                MessageBox.Show("Refus")
                'MessageBox.Show("Invalid username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


End Class
