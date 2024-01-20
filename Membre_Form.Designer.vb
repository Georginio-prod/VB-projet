<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membre_Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Membre_Form))
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DataGridView_membre = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Label6 = New Label()
        TextBox1_Id = New Guna.UI2.WinForms.Guna2TextBox()
        Label7 = New Label()
        Label8 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Button_select = New Button()
        Button_ajt = New Button()
        Button_suppre = New Button()
        Label_total1 = New Label()
        Button1 = New Button()
        Button_exporte = New Button()
        Panel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView_membre, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1103, 101)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(435, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(319, 95)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(156, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 41)
        Label1.TabIndex = 0
        Label1.Text = "Membres"
        ' 
        ' DataGridView_membre
        ' 
        DataGridView_membre.AllowUserToAddRows = False
        DataGridView_membre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_membre.BackgroundColor = Color.Teal
        DataGridView_membre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_membre.Location = New Point(429, 107)
        DataGridView_membre.Name = "DataGridView_membre"
        DataGridView_membre.RowTemplate.Height = 25
        DataGridView_membre.Size = New Size(668, 487)
        DataGridView_membre.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(22, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 22)
        Label2.TabIndex = 24
        Label2.Text = "Id :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(22, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 22)
        Label3.TabIndex = 26
        Label3.Text = "Nom :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(22, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 22)
        Label4.TabIndex = 28
        Label4.Text = "Prenoms :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(22, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 22)
        Label5.TabIndex = 30
        Label5.Text = "Numero :"
        ' 
        ' Guna2TextBox5
        ' 
        Guna2TextBox5.BackColor = Color.Transparent
        Guna2TextBox5.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TextBox5.BorderRadius = 10
        Guna2TextBox5.CustomizableEdges = CustomizableEdges13
        Guna2TextBox5.DefaultText = ""
        Guna2TextBox5.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox5.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox5.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox5.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox5.ForeColor = Color.Black
        Guna2TextBox5.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox5.Location = New Point(137, 161)
        Guna2TextBox5.Name = "Guna2TextBox5"
        Guna2TextBox5.PasswordChar = ChrW(0)
        Guna2TextBox5.PlaceholderForeColor = Color.Black
        Guna2TextBox5.PlaceholderText = ""
        Guna2TextBox5.SelectedText = ""
        Guna2TextBox5.ShadowDecoration.BorderRadius = 10
        Guna2TextBox5.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Guna2TextBox5.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox5.ShadowDecoration.Depth = 40
        Guna2TextBox5.ShadowDecoration.Enabled = True
        Guna2TextBox5.Size = New Size(216, 30)
        Guna2TextBox5.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(22, 379)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 22)
        Label6.TabIndex = 32
        Label6.Text = "Email :"
        ' 
        ' TextBox1_Id
        ' 
        TextBox1_Id.BackColor = Color.Transparent
        TextBox1_Id.BorderRadius = 10
        TextBox1_Id.CustomizableEdges = CustomizableEdges15
        TextBox1_Id.DefaultText = ""
        TextBox1_Id.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox1_Id.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox1_Id.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox1_Id.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox1_Id.Enabled = False
        TextBox1_Id.FillColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1_Id.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox1_Id.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1_Id.ForeColor = Color.Black
        TextBox1_Id.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox1_Id.Location = New Point(137, 113)
        TextBox1_Id.Name = "TextBox1_Id"
        TextBox1_Id.PasswordChar = ChrW(0)
        TextBox1_Id.PlaceholderForeColor = Color.Silver
        TextBox1_Id.PlaceholderText = ""
        TextBox1_Id.ReadOnly = True
        TextBox1_Id.SelectedText = ""
        TextBox1_Id.ShadowDecoration.BorderRadius = 10
        TextBox1_Id.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TextBox1_Id.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        TextBox1_Id.ShadowDecoration.Depth = 40
        TextBox1_Id.ShadowDecoration.Enabled = True
        TextBox1_Id.Size = New Size(117, 28)
        TextBox1_Id.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(22, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 22)
        Label7.TabIndex = 35
        Label7.Text = "Sexes :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(22, 439)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 22)
        Label8.TabIndex = 36
        Label8.Text = "Photo :"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton1.Location = New Point(11, 11)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(91, 26)
        RadioButton1.TabIndex = 37
        RadioButton1.TabStop = True
        RadioButton1.Text = "Homme"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton2.Location = New Point(117, 11)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(88, 26)
        RadioButton2.TabIndex = 39
        RadioButton2.TabStop = True
        RadioButton2.Text = "Femme"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges17
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(137, 371)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderForeColor = Color.Black
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.BorderRadius = 10
        Guna2TextBox1.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2TextBox1.ShadowDecoration.Depth = 40
        Guna2TextBox1.ShadowDecoration.Enabled = True
        Guna2TextBox1.Size = New Size(216, 30)
        Guna2TextBox1.TabIndex = 39
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackColor = Color.Transparent
        Guna2TextBox2.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TextBox2.BorderRadius = 10
        Guna2TextBox2.CustomizableEdges = CustomizableEdges19
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox2.ForeColor = Color.Black
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(137, 325)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderForeColor = Color.Black
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.BorderRadius = 10
        Guna2TextBox2.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2TextBox2.ShadowDecoration.Depth = 40
        Guna2TextBox2.ShadowDecoration.Enabled = True
        Guna2TextBox2.Size = New Size(216, 30)
        Guna2TextBox2.TabIndex = 40
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.BackColor = Color.Transparent
        Guna2TextBox3.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TextBox3.BorderRadius = 10
        Guna2TextBox3.CustomizableEdges = CustomizableEdges21
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox3.ForeColor = Color.Black
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(137, 211)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderForeColor = Color.Black
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.BorderRadius = 10
        Guna2TextBox3.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2TextBox3.ShadowDecoration.Depth = 40
        Guna2TextBox3.ShadowDecoration.Enabled = True
        Guna2TextBox3.Size = New Size(216, 30)
        Guna2TextBox3.TabIndex = 41
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.BorderRadius = 10
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges23
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(137, 421)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.BorderRadius = 10
        Guna2PictureBox1.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Guna2PictureBox1.ShadowDecoration.Depth = 40
        Guna2PictureBox1.ShadowDecoration.Enabled = True
        Guna2PictureBox1.Size = New Size(155, 155)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 42
        Guna2PictureBox1.TabStop = False
        ' 
        ' Button_select
        ' 
        Button_select.BackColor = Color.White
        Button_select.Font = New Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        Button_select.Location = New Point(298, 466)
        Button_select.Name = "Button_select"
        Button_select.Size = New Size(118, 35)
        Button_select.TabIndex = 43
        Button_select.Text = "Select"
        Button_select.TextAlign = ContentAlignment.MiddleRight
        Button_select.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_select.UseVisualStyleBackColor = False
        ' 
        ' Button_ajt
        ' 
        Button_ajt.BackColor = Color.White
        Button_ajt.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_ajt.Location = New Point(56, 611)
        Button_ajt.Name = "Button_ajt"
        Button_ajt.Size = New Size(100, 36)
        Button_ajt.TabIndex = 44
        Button_ajt.Text = "Ajoutez"
        Button_ajt.UseVisualStyleBackColor = False
        ' 
        ' Button_suppre
        ' 
        Button_suppre.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button_suppre.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_suppre.ForeColor = Color.White
        Button_suppre.Location = New Point(940, 611)
        Button_suppre.Name = "Button_suppre"
        Button_suppre.Size = New Size(126, 36)
        Button_suppre.TabIndex = 45
        Button_suppre.Text = "Supprimez"
        Button_suppre.UseVisualStyleBackColor = False
        ' 
        ' Label_total1
        ' 
        Label_total1.AutoSize = True
        Label_total1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_total1.ForeColor = Color.White
        Label_total1.Location = New Point(800, 611)
        Label_total1.Name = "Label_total1"
        Label_total1.Size = New Size(104, 30)
        Label_total1.TabIndex = 47
        Label_total1.Text = "0 auteurs"
        Label_total1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(215, 611)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 36)
        Button1.TabIndex = 48
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button_exporte
        ' 
        Button_exporte.BackColor = Color.White
        Button_exporte.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_exporte.Location = New Point(497, 611)
        Button_exporte.Name = "Button_exporte"
        Button_exporte.Size = New Size(198, 36)
        Button_exporte.TabIndex = 49
        Button_exporte.Text = "Exportez le fichiers"
        Button_exporte.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(RadioButton1)
        Panel3.Controls.Add(RadioButton2)
        Panel3.FillColor = Color.White
        Panel3.Location = New Point(137, 258)
        Panel3.Name = "Panel3"
        Panel3.ShadowColor = Color.Black
        Panel3.Size = New Size(216, 46)
        Panel3.TabIndex = 50
        ' 
        ' Membre_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1100, 659)
        Controls.Add(Panel3)
        Controls.Add(Button_exporte)
        Controls.Add(Button1)
        Controls.Add(Label_total1)
        Controls.Add(Button_suppre)
        Controls.Add(Button_ajt)
        Controls.Add(Button_select)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2TextBox3)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox1_Id)
        Controls.Add(Guna2TextBox5)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView_membre)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Membre_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Membre_Form"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView_membre, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView_membre As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1_Id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Button_select As Button
    Friend WithEvents Button_ajt As Button
    Friend WithEvents Button_suppre As Button
    Friend WithEvents Label_total1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_exporte As Button
    Friend WithEvents Panel3 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
