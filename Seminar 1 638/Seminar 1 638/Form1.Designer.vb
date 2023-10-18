<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.txtPrenume = New System.Windows.Forms.TextBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btnAfiseazaNume = New System.Windows.Forms.Button()
        Me.btnAdaugaStudent = New System.Windows.Forms.Button()
        Me.btnCalcule = New System.Windows.Forms.Button()
        Me.btnAfiseazaDinLista = New System.Windows.Forms.Button()
        Me.lblNumeComplet = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNrNepromovati = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNrPromovati = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNrStudenti = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNotaMaxima = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNotaMinima = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstNote = New System.Windows.Forms.ListBox()
        Me.lstNume = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nota"
        '
        'txtNume
        '
        Me.txtNume.Location = New System.Drawing.Point(116, 18)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(152, 22)
        Me.txtNume.TabIndex = 3
        '
        'txtPrenume
        '
        Me.txtPrenume.Location = New System.Drawing.Point(116, 50)
        Me.txtPrenume.Name = "txtPrenume"
        Me.txtPrenume.Size = New System.Drawing.Size(152, 22)
        Me.txtPrenume.TabIndex = 4
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(116, 84)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(152, 22)
        Me.txtNota.TabIndex = 5
        '
        'btnAfiseazaNume
        '
        Me.btnAfiseazaNume.BackColor = System.Drawing.Color.LightCoral
        Me.btnAfiseazaNume.Location = New System.Drawing.Point(338, 13)
        Me.btnAfiseazaNume.Name = "btnAfiseazaNume"
        Me.btnAfiseazaNume.Size = New System.Drawing.Size(381, 26)
        Me.btnAfiseazaNume.TabIndex = 6
        Me.btnAfiseazaNume.Text = "Afiseaza nume complet"
        Me.btnAfiseazaNume.UseVisualStyleBackColor = False
        '
        'btnAdaugaStudent
        '
        Me.btnAdaugaStudent.Location = New System.Drawing.Point(338, 81)
        Me.btnAdaugaStudent.Name = "btnAdaugaStudent"
        Me.btnAdaugaStudent.Size = New System.Drawing.Size(123, 29)
        Me.btnAdaugaStudent.TabIndex = 7
        Me.btnAdaugaStudent.Text = "Adauga student"
        Me.btnAdaugaStudent.UseVisualStyleBackColor = True
        '
        'btnCalcule
        '
        Me.btnCalcule.Location = New System.Drawing.Point(596, 81)
        Me.btnCalcule.Name = "btnCalcule"
        Me.btnCalcule.Size = New System.Drawing.Size(123, 29)
        Me.btnCalcule.TabIndex = 8
        Me.btnCalcule.Text = "Calcule"
        Me.btnCalcule.UseVisualStyleBackColor = True
        '
        'btnAfiseazaDinLista
        '
        Me.btnAfiseazaDinLista.Location = New System.Drawing.Point(467, 81)
        Me.btnAfiseazaDinLista.Name = "btnAfiseazaDinLista"
        Me.btnAfiseazaDinLista.Size = New System.Drawing.Size(123, 29)
        Me.btnAfiseazaDinLista.TabIndex = 9
        Me.btnAfiseazaDinLista.Text = "Afiseaza din lista"
        Me.btnAfiseazaDinLista.UseVisualStyleBackColor = True
        '
        'lblNumeComplet
        '
        Me.lblNumeComplet.AutoSize = True
        Me.lblNumeComplet.Location = New System.Drawing.Point(335, 53)
        Me.lblNumeComplet.Name = "lblNumeComplet"
        Me.lblNumeComplet.Size = New System.Drawing.Size(102, 17)
        Me.lblNumeComplet.TabIndex = 10
        Me.lblNumeComplet.Text = "Nume complet:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lstNote)
        Me.GroupBox1.Controls.Add(Me.lstNume)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 298)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sinteza"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNrNepromovati)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblNrPromovati)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblNrStudenti)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblNotaMaxima)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblNotaMinima)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblMedia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 265)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lblNrNepromovati
        '
        Me.lblNrNepromovati.AutoSize = True
        Me.lblNrNepromovati.Location = New System.Drawing.Point(176, 164)
        Me.lblNrNepromovati.Name = "lblNrNepromovati"
        Me.lblNrNepromovati.Size = New System.Drawing.Size(16, 17)
        Me.lblNrNepromovati.TabIndex = 11
        Me.lblNrNepromovati.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Numar nepromovati"
        '
        'lblNrPromovati
        '
        Me.lblNrPromovati.AutoSize = True
        Me.lblNrPromovati.Location = New System.Drawing.Point(176, 135)
        Me.lblNrPromovati.Name = "lblNrPromovati"
        Me.lblNrPromovati.Size = New System.Drawing.Size(16, 17)
        Me.lblNrPromovati.TabIndex = 9
        Me.lblNrPromovati.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Numar promovati"
        '
        'lblNrStudenti
        '
        Me.lblNrStudenti.AutoSize = True
        Me.lblNrStudenti.Location = New System.Drawing.Point(176, 107)
        Me.lblNrStudenti.Name = "lblNrStudenti"
        Me.lblNrStudenti.Size = New System.Drawing.Size(16, 17)
        Me.lblNrStudenti.TabIndex = 7
        Me.lblNrStudenti.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Numar studenti"
        '
        'lblNotaMaxima
        '
        Me.lblNotaMaxima.AutoSize = True
        Me.lblNotaMaxima.Location = New System.Drawing.Point(176, 78)
        Me.lblNotaMaxima.Name = "lblNotaMaxima"
        Me.lblNotaMaxima.Size = New System.Drawing.Size(16, 17)
        Me.lblNotaMaxima.TabIndex = 5
        Me.lblNotaMaxima.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Maxim"
        '
        'lblNotaMinima
        '
        Me.lblNotaMinima.AutoSize = True
        Me.lblNotaMinima.Location = New System.Drawing.Point(176, 51)
        Me.lblNotaMinima.Name = "lblNotaMinima"
        Me.lblNotaMinima.Size = New System.Drawing.Size(16, 17)
        Me.lblNotaMinima.TabIndex = 3
        Me.lblNotaMinima.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Minim"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(176, 22)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(16, 17)
        Me.lblMedia.TabIndex = 1
        Me.lblMedia.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Media"
        '
        'lstNote
        '
        Me.lstNote.FormattingEnabled = True
        Me.lstNote.ItemHeight = 16
        Me.lstNote.Items.AddRange(New Object() {"7", "9", "2", "10"})
        Me.lstNote.Location = New System.Drawing.Point(177, 24)
        Me.lstNote.Name = "lstNote"
        Me.lstNote.Size = New System.Drawing.Size(54, 260)
        Me.lstNote.TabIndex = 1
        '
        'lstNume
        '
        Me.lstNume.FormattingEnabled = True
        Me.lstNume.ItemHeight = 16
        Me.lstNume.Items.AddRange(New Object() {"Popescu Ion", "Stanescu George", "Antonescu Andra", "Georgescu Ana"})
        Me.lstNume.Location = New System.Drawing.Point(16, 24)
        Me.lstNume.Name = "lstNume"
        Me.lstNume.Size = New System.Drawing.Size(146, 260)
        Me.lstNume.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNumeComplet)
        Me.Controls.Add(Me.btnAfiseazaDinLista)
        Me.Controls.Add(Me.btnCalcule)
        Me.Controls.Add(Me.btnAdaugaStudent)
        Me.Controls.Add(Me.btnAfiseazaNume)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtPrenume)
        Me.Controls.Add(Me.txtNume)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNume As TextBox
    Friend WithEvents txtPrenume As TextBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents btnAfiseazaNume As Button
    Friend WithEvents btnAdaugaStudent As Button
    Friend WithEvents btnCalcule As Button
    Friend WithEvents btnAfiseazaDinLista As Button
    Friend WithEvents lblNumeComplet As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstNote As ListBox
    Friend WithEvents lstNume As ListBox
    Friend WithEvents lblNrNepromovati As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblNrPromovati As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNrStudenti As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNotaMaxima As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNotaMinima As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents Label4 As Label
End Class
