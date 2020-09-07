Public Class EliminarContrataciones
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Capa_Logica.ControladorContrataciones.Borrar(TextBoxElimID.Text)
            MsgBox("Contrato borrado")
        Catch ex As Exception
            MsgBox("Fallo al borrar contrato")
        End Try
    End Sub

    Private Sub EliminarContrataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class