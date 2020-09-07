Public Class ModificarServicios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtModificarSer.Click
        Try
            Capa_Logica.ControladorServicios.Modificar(TBoxId.Text, TBoxNom.Text, TBoxCosMen.Text, CBoxTipoSer.Text, TBoxFHCreacionSer.Text, TBoxActivo.Text)
            MsgBox("Servicio modificado")
        Catch ex As Exception
            MsgBox("Fallo al modificar el servicio")
        End Try

    End Sub

    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TBoxId.TextChanged

    End Sub
End Class