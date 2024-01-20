<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCard_Form
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(163, 21)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 24)
        Label1.TabIndex = 44
        Label1.Text = "Isbn"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(163, 62)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 24)
        Label2.TabIndex = 45
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(163, 107)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 24)
        Label3.TabIndex = 46
        Label3.Text = "Quabtite"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(163, 151)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 24)
        Label4.TabIndex = 47
        Label4.Text = "Prix"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(163, 187)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 24)
        Label5.TabIndex = 48
        Label5.Text = "Date Reçu"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 24)
        Label6.TabIndex = 49
        Label6.Text = "Isbn"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(12, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 24)
        Label7.TabIndex = 50
        Label7.Text = "Titre"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(12, 107)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 24)
        Label8.TabIndex = 51
        Label8.Text = "Quantité"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(12, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 24)
        Label9.TabIndex = 52
        Label9.Text = "Prix"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(12, 187)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 24)
        Label10.TabIndex = 53
        Label10.Text = "Date Reçu"
        ' 
        ' BookCard_Form
        ' 
        AutoScaleDimensions = New SizeF(12F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(279, 241)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        ForeColor = Color.White
        Margin = New Padding(5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BookCard_Form"
        Text = "BookCard"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
