Public Class ModificarContrataciones
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Capa_Logica.ControladorContrataciones.Modificar(TextBoxIDPer.Text, TextBoxIDSer.Text, TextBoxFCrea.Text, TextBoxFCon.Text, TbFeFinCon.Text)
            MsgBox("Servicio modificado")
        Catch ex As Exception
            MsgBox("Fallo al modificar el servicio")
        End Try
    End Sub
End Class