<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(User_Form))
        Panel1 = New Panel()
        RadioButton1 = New RadioButton()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        DataGridView_authors = New DataGridView()
        TextBox1_id = New Guna.UI2.WinForms.Guna2TextBox()
        Label7 = New Label()
        Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Label6 = New Label()
        Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Label5 = New Label()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView_authors, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DataGridView_authors)
        Panel1.Controls.Add(TextBox1_id)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Guna2TextBox5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Guna2TextBox4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Guna2TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Guna2TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1011, 555)
        Panel1.TabIndex = 0
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(863, 299)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(128, 25)
        RadioButton1.TabIndex = 27
        RadioButton1.TabStop = True
        RadioButton1.Text = "Status Admin"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button3.Font = New Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(347, 286)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 38)
        Button3.TabIndex = 26
        Button3.Text = "Supprimez"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Button2.Location = New Point(182, 286)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 38)
        Button2.TabIndex = 25
        Button2.Text = "Modifiez"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(16, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 38)
        Button1.TabIndex = 24
        Button1.Text = "Ajoutez"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView_authors
        ' 
        DataGridView_authors.AllowUserToAddRows = False
        DataGridView_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_authors.BackgroundColor = Color.Teal
        DataGridView_authors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_authors.Location = New Point(3, 330)
        DataGridView_authors.Name = "DataGridView_authors"
        DataGridView_authors.RowTemplate.Height = 25
        DataGridView_authors.Size = New Size(999, 223)
        DataGridView_authors.TabIndex = 23
        ' 
        ' TextBox1_id
        ' 
        TextBox1_id.CustomizableEdges = CustomizableEdges1
        TextBox1_id.DefaultText = ""
        TextBox1_id.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox1_id.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox1_id.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox1_id.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox1_id.Enabled = False
        TextBox1_id.FillColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1_id.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox1_id.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1_id.ForeColor = Color.Black
        TextBox1_id.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox1_id.Location = New Point(472, 117)
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.PasswordChar = ChrW(0)
        TextBox1_id.PlaceholderForeColor = Color.Silver
        TextBox1_id.PlaceholderText = ""
        TextBox1_id.ReadOnly = True
        TextBox1_id.SelectedText = ""
        TextBox1_id.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        TextBox1_id.Size = New Size(117, 29)
        TextBox1_id.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(401, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 21)
        Label7.TabIndex = 21
        Label7.Text = "Id :"
        ' 
        ' Guna2TextBox5
        ' 
        Guna2TextBox5.CustomizableEdges = CustomizableEdges3
        Guna2TextBox5.DefaultText = ""
        Guna2TextBox5.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox5.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox5.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox5.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox5.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox5.Location = New Point(101, 217)
        Guna2TextBox5.Name = "Guna2TextBox5"
        Guna2TextBox5.PasswordChar = ChrW(0)
        Guna2TextBox5.PlaceholderText = ""
        Guna2TextBox5.SelectedText = ""
        Guna2TextBox5.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox5.Size = New Size(200, 34)
        Guna2TextBox5.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(657, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 21)
        Label6.TabIndex = 9
        Label6.Text = "Mot de passe"
        ' 
        ' Guna2TextBox4
        ' 
        Guna2TextBox4.CustomizableEdges = CustomizableEdges5
        Guna2TextBox4.DefaultText = ""
        Guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Location = New Point(101, 142)
        Guna2TextBox4.Name = "Guna2TextBox4"
        Guna2TextBox4.PasswordChar = ChrW(0)
        Guna2TextBox4.PlaceholderText = ""
        Guna2TextBox4.SelectedText = ""
        Guna2TextBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox4.Size = New Size(200, 34)
        Guna2TextBox4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(702, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 21)
        Label5.TabIndex = 7
        Label5.Text = "Pseudo"
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.CustomizableEdges = CustomizableEdges7
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(791, 142)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2TextBox3.Size = New Size(200, 34)
        Guna2TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(11, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 5
        Label4.Text = "Prénoms"
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.CustomizableEdges = CustomizableEdges9
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(791, 217)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2TextBox2.Size = New Size(200, 34)
        Guna2TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(40, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 21)
        Label3.TabIndex = 3
        Label3.Text = "Nom"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1002, 111)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(287, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(460, 111)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(76, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 91)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(233, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 27)
        Label1.TabIndex = 0
        Label1.Text = "Utilisateur "
        ' 
        ' User_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 553)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "User_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User_Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView_authors, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView_authors As DataGridView
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
