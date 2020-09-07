Public Class ListarServicios
    Private Sub ListarServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtAcept_Click(sender As Object, e As EventArgs) Handles BtAcept.Click
        Try

            Dim tabla As New DataTable
            tabla.Load(Capa_Logica.ControladorServicios.Listar(TextBoxSer.Text))
            DataGridView1.DataSource = tabla
            MsgBox("Servicio listado")
        Catch ex As Exception
            MsgBox("Fallo al listar servicio")
        End Try
    End Sub


End Class