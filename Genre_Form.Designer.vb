<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Genre_Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Genre_Form))
        Panel1 = New Panel()
        Label_genre = New Label()
        Button_Edit = New Button()
        Button_add = New Button()
        Button_Sup = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1_id = New Guna.UI2.WinForms.Guna2TextBox()
        TextBox_name = New Guna.UI2.WinForms.Guna2TextBox()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Location = New Point(-2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(991, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label_genre
        ' 
        Label_genre.AutoSize = True
        Label_genre.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label_genre.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_genre.ForeColor = Color.White
        Label_genre.Location = New Point(114, 27)
        Label_genre.Name = "Label_genre"
        Label_genre.Size = New Size(161, 41)
        Label_genre.TabIndex = 7
        Label_genre.Text = "Catégorie"
        ' 
        ' Button_Edit
        ' 
        Button_Edit.BackColor = Color.Teal
        Button_Edit.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Edit.ForeColor = Color.Black
        Button_Edit.Location = New Point(378, 353)
        Button_Edit.Name = "Button_Edit"
        Button_Edit.Size = New Size(88, 39)
        Button_Edit.TabIndex = 1
        Button_Edit.Text = "Editez"
        Button_Edit.TextAlign = ContentAlignment.TopCenter
        Button_Edit.UseVisualStyleBackColor = False
        ' 
        ' Button_add
        ' 
        Button_add.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_add.ForeColor = Color.White
        Button_add.Location = New Point(203, 353)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(102, 39)
        Button_add.TabIndex = 2
        Button_add.Text = "Ajoutez"
        Button_add.TextAlign = ContentAlignment.TopCenter
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_Sup
        ' 
        Button_Sup.BackColor = Color.Red
        Button_Sup.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Sup.ForeColor = Color.White
        Button_Sup.Location = New Point(535, 353)
        Button_Sup.Name = "Button_Sup"
        Button_Sup.Size = New Size(126, 39)
        Button_Sup.TabIndex = 3
        Button_Sup.Text = "Supprimez"
        Button_Sup.TextAlign = ContentAlignment.TopCenter
        Button_Sup.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(161, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 30)
        Label1.TabIndex = 6
        Label1.Text = "Id :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(161, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 30)
        Label2.TabIndex = 7
        Label2.Text = "Name :"
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
        TextBox1_id.Location = New Point(283, 174)
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.PasswordChar = ChrW(0)
        TextBox1_id.PlaceholderForeColor = Color.Silver
        TextBox1_id.PlaceholderText = ""
        TextBox1_id.ReadOnly = True
        TextBox1_id.SelectedText = ""
        TextBox1_id.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        TextBox1_id.Size = New Size(117, 36)
        TextBox1_id.TabIndex = 8
        ' 
        ' TextBox_name
        ' 
        TextBox_name.CustomizableEdges = CustomizableEdges3
        TextBox_name.DefaultText = ""
        TextBox_name.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        TextBox_name.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        TextBox_name.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_name.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        TextBox_name.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_name.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_name.ForeColor = Color.Black
        TextBox_name.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TextBox_name.Location = New Point(283, 257)
        TextBox_name.Name = "TextBox_name"
        TextBox_name.PasswordChar = ChrW(0)
        TextBox_name.PlaceholderText = ""
        TextBox_name.SelectedText = ""
        TextBox_name.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        TextBox_name.Size = New Size(306, 36)
        TextBox_name.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.Teal
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(721, 130)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(254, 262)
        DataGridView1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label_genre)
        Panel2.Location = New Point(387, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 100)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Genre_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(988, 452)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox_name)
        Controls.Add(TextBox1_id)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_Sup)
        Controls.Add(Button_add)
        Controls.Add(Button_Edit)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Genre_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Genre_Form"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_Sup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_genre As Label
    Friend WithEvents TextBox1_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
