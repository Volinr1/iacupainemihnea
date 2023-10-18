Public Class Form1
    Private Sub btnAfiseazaNume_Click(sender As Object, e As EventArgs) Handles btnAfiseazaNume.Click
        Dim numeComplet As String
        numeComplet = "Numele complet: " & txtNume.Text & " " & txtPrenume.Text
        MsgBox(numeComplet)
        lblNumeComplet.Text = numeComplet
    End Sub

    Private Sub btnAdaugaStudent_Click(sender As Object, e As EventArgs) Handles btnAdaugaStudent.Click
        'If txtNume.Text = "" Then
        '    MsgBox("Completati numele")
        'Else
        '    If txtPrenume.Text = "" Then
        '        MsgBox("Completati prenumele")
        '    Else
        '        If txtNota.Text = "" Then
        '            MsgBox("Completati nota")
        '        Else
        '            If Not IsNumeric(txtNota.Text) Then
        '                MsgBox("Nota incorecta")
        '            Else
        '                If txtNota.Text < 1 Or txtNota.Text > 10 Then
        '                    MsgBox("Nota in afara intervalului 1-10")
        '                Else
        '                    If txtNota.Text < 5 Then
        '                        MsgBox("Student nepromovat")
        '                    Else
        '                        MsgBox("Student promovat")
        '                    End If
        '                    lstNume.Items.Add(txtNume.Text & " " & txtPrenume.Text)
        '                    lstNote.Items.Add(txtNota.Text)
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
        Dim bool As Boolean

        If txtNume.Text = "" Or txtPrenume.Text = "" Or txtNota.Text = "" Then
            MsgBox("Completati numele")
        ElseIf Not IsNumeric(txtNota.Text) Then
            MsgBox("Nota incorecta")
        ElseIf txtNota.Text < 1 Or txtNota.Text > 10 Then
            MsgBox("Nota in afara intervalului 1-10")
        ElseIf txtNota.Text < 5 Then
            MsgBox("Student nepromovat")
        Else MsgBox("Student promovat")
            bool = 1
        End If
        If bool = 1 Then
            lstNume.Items.Add(txtNume.Text & " " & txtPrenume.Text)
            lstNote.Items.Add(txtNota.Text)
        End If



    End Sub
End Class
