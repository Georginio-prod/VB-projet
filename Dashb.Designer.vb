<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashb
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
        Panel1 = New Panel()
        Label1 = New Label()
        Button_livre = New Button()
        Button_emprunt = New Button()
        Button_membre = New Button()
        Button_auteurs = New Button()
        Button_genre = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button_livre)
        Panel1.Controls.Add(Button_emprunt)
        Panel1.Controls.Add(Button_membre)
        Panel1.Controls.Add(Button_auteurs)
        Panel1.Controls.Add(Button_genre)
        Panel1.Location = New Point(-1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1217, 116)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(425, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 42)
        Label1.TabIndex = 6
        Label1.Text = "Welcome To LIBRARY"
        ' 
        ' Button_livre
        ' 
        Button_livre.ForeColor = Color.White
        Button_livre.Location = New Point(522, 70)
        Button_livre.Name = "Button_livre"
        Button_livre.Size = New Size(206, 35)
        Button_livre.TabIndex = 4
        Button_livre.Text = "Livres"
        Button_livre.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_livre.UseVisualStyleBackColor = True
        ' 
        ' Button_emprunt
        ' 
        Button_emprunt.ForeColor = Color.White
        Button_emprunt.Location = New Point(1008, 70)
        Button_emprunt.Name = "Button_emprunt"
        Button_emprunt.Size = New Size(187, 35)
        Button_emprunt.TabIndex = 3
        Button_emprunt.Text = "Emprunt"
        Button_emprunt.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_emprunt.UseVisualStyleBackColor = True
        ' 
        ' Button_membre
        ' 
        Button_membre.ForeColor = Color.White
        Button_membre.Location = New Point(778, 70)
        Button_membre.Name = "Button_membre"
        Button_membre.Size = New Size(190, 35)
        Button_membre.TabIndex = 2
        Button_membre.Text = "Membres"
        Button_membre.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_membre.UseVisualStyleBackColor = True
        ' 
        ' Button_auteurs
        ' 
        Button_auteurs.ForeColor = Color.White
        Button_auteurs.Location = New Point(277, 70)
        Button_auteurs.Name = "Button_auteurs"
        Button_auteurs.Size = New Size(190, 35)
        Button_auteurs.TabIndex = 1
        Button_auteurs.Text = "Auteurs"
        Button_auteurs.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_auteurs.UseVisualStyleBackColor = True
        ' 
        ' Button_genre
        ' 
        Button_genre.ForeColor = Color.White
        Button_genre.Location = New Point(13, 70)
        Button_genre.Name = "Button_genre"
        Button_genre.Size = New Size(202, 35)
        Button_genre.TabIndex = 0
        Button_genre.Text = "Catégorie"
        Button_genre.TextImageRelation = TextImageRelation.ImageBeforeText
        Button_genre.UseVisualStyleBackColor = True
        ' 
        ' dashb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkCyan
        ClientSize = New Size(1216, 638)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dashb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashb"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_livre As Button
    Friend WithEvents Button_emprunt As Button
    Friend WithEvents Button_membre As Button
    Friend WithEvents Button_auteurs As Button
    Friend WithEvents Button_genre As Button
    Friend WithEvents Label1 As Label
End Class
