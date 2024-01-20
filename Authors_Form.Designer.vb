<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authors_Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Authors_Form))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        auteur = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox_education = New Guna.UI2.WinForms.Guna2TextBox()
        TextBox_prenom = New Guna.UI2.WinForms.Guna2TextBox()
        Button_add = New Button()
        Button_sup = New Button()
        Button_edit = New Button()
        RichTextBox_bio = New RichTextBox()
        TextBox1_id = New Guna.UI2.WinForms.Guna2TextBox()
        DataGridView_authors = New DataGridView()
        Button_telecharger = New Button()
        Button_showAuteur = New Button()
        Label_total = New Label()
        TextBox_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView_authors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1166, 122)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(auteur)
        Panel2.Location = New Point(412, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(311, 100)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(28, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' auteur
        ' 
        auteur.AutoSize = True
        auteur.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        auteur.ForeColor = Color.White
        auteur.Location = New Point(156, 26)
        auteur.Name = "auteur"
        auteur.Size = New Size(148, 48)
        auteur.TabIndex = 1
        auteur.Text = "Auteurs" & vbCrLf
        auteur.TextAlign = ContentAlignment.TopRight
        auteur.UseCompatibleTextRendering = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 30)
        Label1.TabIndex = 1
        Label1.Text = "Id :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 231)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 30)
        Label2.TabIndex = 4
        Label2.Text = "Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 30)
        Label3.TabIndex = 6
        Label3.Text = "Prenoms :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 397)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 30)
        Label4.TabIndex = 8
        Label4.Text = "Education :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 476)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 30)
        Label5.TabIndex = 10
        Label5.Text = "Bio :"
        ' 
        ' TextBox_education
        ' 
        TextBox_education.CustomizableEdges = CustomizableEdges1
        TextBox_education.DefaultText = ""
        TextBox_education.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox_education.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox_education.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_education.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_education.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_education.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_education.ForeColor = Color.Black
        TextBox_education.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_education.Location = New Point(176, 397)
        TextBox_education.Name = "TextBox_education"
        TextBox_education.PasswordChar = ChrW(0)
        TextBox_education.PlaceholderForeColor = Color.Black
        TextBox_education.PlaceholderText = ""
        TextBox_education.SelectedText = ""
        TextBox_education.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        TextBox_education.Size = New Size(313, 36)
        TextBox_education.TabIndex = 13
        ' 
        ' TextBox_prenom
        ' 
        TextBox_prenom.CustomizableEdges = CustomizableEdges3
        TextBox_prenom.DefaultText = ""
        TextBox_prenom.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox_prenom.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox_prenom.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_prenom.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_prenom.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_prenom.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_prenom.ForeColor = Color.Black
        TextBox_prenom.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_prenom.Location = New Point(176, 305)
        TextBox_prenom.Name = "TextBox_prenom"
        TextBox_prenom.PasswordChar = ChrW(0)
        TextBox_prenom.PlaceholderForeColor = Color.Black
        TextBox_prenom.PlaceholderText = ""
        TextBox_prenom.SelectedText = ""
        TextBox_prenom.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        TextBox_prenom.Size = New Size(313, 36)
        TextBox_prenom.TabIndex = 14
        ' 
        ' Button_add
        ' 
        Button_add.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_add.ForeColor = Color.White
        Button_add.Location = New Point(199, 582)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(110, 34)
        Button_add.TabIndex = 16
        Button_add.Text = "Ajoutez"
        Button_add.TextAlign = ContentAlignment.TopCenter
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_sup
        ' 
        Button_sup.BackColor = Color.White
        Button_sup.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_sup.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button_sup.Location = New Point(1015, 582)
        Button_sup.Name = "Button_sup"
        Button_sup.Size = New Size(121, 34)
        Button_sup.TabIndex = 17
        Button_sup.Text = "Supprimez"
        Button_sup.TextAlign = ContentAlignment.TopCenter
        Button_sup.UseVisualStyleBackColor = False
        ' 
        ' Button_edit
        ' 
        Button_edit.BackColor = Color.Transparent
        Button_edit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_edit.Location = New Point(350, 582)
        Button_edit.Name = "Button_edit"
        Button_edit.Size = New Size(119, 34)
        Button_edit.TabIndex = 18
        Button_edit.Text = "Editez"
        Button_edit.TextAlign = ContentAlignment.TopCenter
        Button_edit.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox_bio
        ' 
        RichTextBox_bio.Location = New Point(176, 476)
        RichTextBox_bio.Name = "RichTextBox_bio"
        RichTextBox_bio.Size = New Size(313, 96)
        RichTextBox_bio.TabIndex = 19
        RichTextBox_bio.Text = ""
        ' 
        ' TextBox1_id
        ' 
        TextBox1_id.CustomizableEdges = CustomizableEdges5
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
        TextBox1_id.Location = New Point(176, 155)
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.PasswordChar = ChrW(0)
        TextBox1_id.PlaceholderForeColor = Color.Silver
        TextBox1_id.PlaceholderText = ""
        TextBox1_id.ReadOnly = True
        TextBox1_id.SelectedText = ""
        TextBox1_id.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        TextBox1_id.Size = New Size(117, 36)
        TextBox1_id.TabIndex = 20
        ' 
        ' DataGridView_authors
        ' 
        DataGridView_authors.AllowUserToAddRows = False
        DataGridView_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_authors.BackgroundColor = Color.Teal
        DataGridView_authors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_authors.Location = New Point(511, 136)
        DataGridView_authors.Name = "DataGridView_authors"
        DataGridView_authors.RowTemplate.Height = 25
        DataGridView_authors.Size = New Size(638, 436)
        DataGridView_authors.TabIndex = 21
        ' 
        ' Button_telecharger
        ' 
        Button_telecharger.BackColor = Color.Transparent
        Button_telecharger.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_telecharger.ForeColor = Color.White
        Button_telecharger.Location = New Point(715, 582)
        Button_telecharger.Name = "Button_telecharger"
        Button_telecharger.Size = New Size(160, 34)
        Button_telecharger.TabIndex = 22
        Button_telecharger.Text = "Téléchargez"
        Button_telecharger.TextAlign = ContentAlignment.TopCenter
        Button_telecharger.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_telecharger.UseVisualStyleBackColor = False
        ' 
        ' Button_showAuteur
        ' 
        Button_showAuteur.BackColor = Color.Transparent
        Button_showAuteur.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_showAuteur.ForeColor = Color.White
        Button_showAuteur.Location = New Point(539, 582)
        Button_showAuteur.Name = "Button_showAuteur"
        Button_showAuteur.Size = New Size(156, 34)
        Button_showAuteur.TabIndex = 23
        Button_showAuteur.Text = "Auteurs"
        Button_showAuteur.TextAlign = ContentAlignment.TopCenter
        Button_showAuteur.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_showAuteur.UseVisualStyleBackColor = False
        ' 
        ' Label_total
        ' 
        Label_total.AutoSize = True
        Label_total.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_total.ForeColor = Color.White
        Label_total.Location = New Point(881, 582)
        Label_total.Name = "Label_total"
        Label_total.Size = New Size(104, 30)
        Label_total.TabIndex = 24
        Label_total.Text = "0 auteurs"
        Label_total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox_firstname
        ' 
        TextBox_firstname.CustomizableEdges = CustomizableEdges7
        TextBox_firstname.DefaultText = ""
        TextBox_firstname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox_firstname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox_firstname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_firstname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_firstname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_firstname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_firstname.ForeColor = Color.Black
        TextBox_firstname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_firstname.Location = New Point(176, 225)
        TextBox_firstname.Name = "TextBox_firstname"
        TextBox_firstname.PasswordChar = ChrW(0)
        TextBox_firstname.PlaceholderForeColor = Color.Black
        TextBox_firstname.PlaceholderText = ""
        TextBox_firstname.SelectedText = ""
        TextBox_firstname.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        TextBox_firstname.Size = New Size(313, 36)
        TextBox_firstname.TabIndex = 15
        ' 
        ' Authors_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1161, 628)
        Controls.Add(Label_total)
        Controls.Add(Button_showAuteur)
        Controls.Add(Button_telecharger)
        Controls.Add(DataGridView_authors)
        Controls.Add(TextBox1_id)
        Controls.Add(RichTextBox_bio)
        Controls.Add(Button_edit)
        Controls.Add(Button_sup)
        Controls.Add(Button_add)
        Controls.Add(TextBox_firstname)
        Controls.Add(TextBox_prenom)
        Controls.Add(TextBox_education)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Authors_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Authors_Form"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView_authors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents auteur As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_education As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox_prenom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_sup As Button
    Friend WithEvents Button_edit As Button
    Friend WithEvents RichTextBox_bio As RichTextBox
    Friend WithEvents TextBox1_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView_authors As DataGridView
    Friend WithEvents Button_telecharger As Button
    Friend WithEvents Button_showAuteur As Button
    Friend WithEvents Label_total As Label
    Friend WithEvents TextBox_firstname As Guna.UI2.WinForms.Guna2TextBox
End Class
