Public Class AltaContrataciones
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        Try
            Capa_Logica.ControladorContrataciones.Alta(TextBoxIDPer.Text, TextBoxIDSer.Text, TextBoxFecCon.Text, TextBoxFinCon.Text)
            MsgBox("Contrato agregado")
        Catch ex As Exception
            MsgBox("Fallo al insertar contrato")
        End Try

    End Sub

    Private Sub AltaContrataciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class