Public Class AltaPersona
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Capa_Logica.ContoladorPersona.Alta(TextBoxId.Text, TextBoxNom.Text, TextBoxAp.Text, TextBoxTel.Text, TextBoxMail.Text, TextBoxFHCrea.Text, TextBoxActivo.Text)
            MsgBox("Persona agregada")
        Catch ex As Exception
            MsgBox("Fallo al insertar la persona")
        End Try
    End Sub

    Private Sub AltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class