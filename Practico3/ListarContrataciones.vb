Public Class ListarContrataciones
    Private Sub BtListarCon_Click(sender As Object, e As EventArgs) Handles BtListarCon.Click

        Try
            Dim tabla As New DataTable
            tabla.Load(Capa_Logica.ControladorContrataciones.Listar(TBoxList.Text))
            DataGridView1.DataSource = tabla
            MsgBox("Contrato listado")
        Catch ex As Exception
            MsgBox("Fallo al listar el contrataciónes")
        End Try
    End Sub
End Class