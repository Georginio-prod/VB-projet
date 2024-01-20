<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authors_List_Form
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
        DataGridView1_authors = New DataGridView()
        Panel2 = New Panel()
        Label_authors = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1_authors, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1_authors)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 260)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1_authors
        ' 
        DataGridView1_authors.AllowUserToAddRows = False
        DataGridView1_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1_authors.BackgroundColor = Color.Teal
        DataGridView1_authors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1_authors.GridColor = Color.Black
        DataGridView1_authors.Location = New Point(0, 49)
        DataGridView1_authors.Name = "DataGridView1_authors"
        DataGridView1_authors.RowTemplate.Height = 25
        DataGridView1_authors.Size = New Size(310, 208)
        DataGridView1_authors.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel2.Controls.Add(Label_authors)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(310, 43)
        Panel2.TabIndex = 1
        ' 
        ' Label_authors
        ' 
        Label_authors.AutoSize = True
        Label_authors.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_authors.Location = New Point(121, 8)
        Label_authors.Name = "Label_authors"
        Label_authors.Size = New Size(79, 24)
        Label_authors.TabIndex = 0
        Label_authors.Text = "Auteurs"
        ' 
        ' Authors_List_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(311, 260)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Authors_List_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Authors_List_Form"
        Panel1.ResumeLayout(False)
        CType(DataGridView1_authors, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1_authors As DataGridView
    Friend WithEvents Label_authors As Label
End Class
