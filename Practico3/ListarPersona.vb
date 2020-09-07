Public Class ListarPersona
    'instancia de la clase BaseDeDatos para poder acceder a los metodos que hay dentro de nuestra clase que es "llenarGrilla"
    'Dim obj As New BaseDeDatos

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'obj.consultaDinamica(TextBox1.Text, DataGridView1)
    End Sub

    Private Sub ListarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'obj.llenarGrilla(DataGridView1)

    End Sub

    Private Sub BtLisDat_Click(sender As Object, e As EventArgs) Handles BtLisDat.Click
        Try

            Dim tabla As New DataTable
            tabla.Load(Capa_Logica.ContoladorPersona.Listar(TextBox1.Text))
            DataGridView1.DataSource = tabla
            MsgBox("Persona listada")
        Catch ex As Exception
            MsgBox("Fallo al listar persona")
        End Try

    End Sub
End Class