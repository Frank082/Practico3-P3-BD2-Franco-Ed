Public Module ControladorServicios
    Public Sub Alta(id As String, nombre As String, costo As String, tipo As String, fechaHoraCreacion As DateTime, activo As Boolean)

        Dim c As New Capa_Datos.Servicio
        c.IdServicio = id
        c.Nombre = nombre
        c.CostoMensual = costo
        c.Tipo = tipo
        c.FechaHoraCreacion = fechaHoraCreacion
        c.Activo = activo
        c.Alta()

    End Sub
    Public Sub Borrar(id As String)

        Dim c As New Capa_Datos.Servicio

        c.IdServicio = id
        c.Borrar()

    End Sub

    Public Sub Modificar(id As String, nombre As String, costo As String, tipo As String, fechaHoraCreacion As DateTime, activo As Boolean)

        Dim c As New Capa_Datos.Servicio

        c.IdServicio = id
        c.Nombre = nombre
        c.CostoMensual = costo
        c.Tipo = tipo
        c.FechaHoraCreacion = fechaHoraCreacion
        c.Activo = activo
        c.Modificar()

    End Sub

    Public Function Listar(id As String)
        Dim c As New Capa_Datos.Servicio
        Return c.Listar(id)

    End Function

End Module
