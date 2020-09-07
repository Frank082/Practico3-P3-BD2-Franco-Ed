Public Class AltaServicios
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        Try
            Capa_Logica.ControladorServicios.Alta(TextBoxId.Text, TextBoxNom.Text, TextBoxCosMen.Text, TexBoxFHCreacion.Text, TextBoxActivo.Text, ComBoxTipo.Text)
            MsgBox("Servicio agregado")
        Catch ex As Exception
            MsgBox("Fallo al insertar el servicio")
        End Try

    End Sub

    Private Sub AltaServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class