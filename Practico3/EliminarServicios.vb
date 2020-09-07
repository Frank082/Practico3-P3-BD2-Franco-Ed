Public Class EliminarServicios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            Capa_Logica.ControladorContrataciones.Borrar(TextBoxIdSer.Text)
            MsgBox("Servicio borrado")
        Catch ex As Exception
            MsgBox("Fallo al borrar servicio")
        End Try
    End Sub

    Private Sub EliminarContrataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class