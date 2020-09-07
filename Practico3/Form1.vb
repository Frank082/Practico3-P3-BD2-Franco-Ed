Public Class Form1


    Private Sub CotrataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotrataToolStripMenuItem.Click
        'Abre formulario
        AltaPersona.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        'Abre formulario
        ModificarPersona.ShowDialog()
    End Sub

    Private Sub PersonalTelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalTelToolStripMenuItem.Click
        'Abre formulario
        EliminarPersona.ShowDialog()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        'Abre formulario
        ListarPersona.ShowDialog()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        'Abre formulario
        ListarServicios.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'Abre formulario
        EliminarServicios.ShowDialog()
    End Sub

    Private Sub ModuificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModuificarToolStripMenuItem.Click
        'Abre formulario
        ModificarServicios.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        'Abre formulario
        AltaServicios.ShowDialog()
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        'Abre formulario
        ListarContrataciones.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        'Abre formulario
        EliminarContrataciones.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        'Abre formulario
        ModificarContrataciones.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        'Abre formulario
        AltaContrataciones.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Codigo para adaptar el formulario al tamaño y posición del escritorio
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

End Class
