Public Class EliminarPersona
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Capa_Logica.ContoladorPersona.Borrar(TextBoxIdPer.Text)
            MsgBox("Persona borrada")
        Catch ex As Exception
            MsgBox("Fallo al borrar persona")
        End Try
    End Sub

    Private Sub EliminarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class