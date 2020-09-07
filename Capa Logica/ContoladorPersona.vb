Public Module ContoladorPersona
    Public Sub Alta(id As String, nombre As String, apellido As String, mail As String, fhcreacion As DateTime, activo As Boolean, telefono As String)

        Dim p As New Capa_Datos.Persona

        p.IdPersona = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Telefono = telefono
        p.Mail = mail
        p.FechaHoraCreacion = fhcreacion
        p.Activo = activo
        p.Alta()

    End Sub
    Public Sub Borrar(id As String)

        Dim p As New Capa_Datos.Persona

        p.IdPersona = id
        p.Borrar()

    End Sub
    Public Sub Modificar(id As String, nombre As String, apellido As String, telefono As String, mail As String, fhcreacion As DateTime, activo As Boolean)

        Dim p As New Capa_Datos.Persona

        p.IdPersona = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Telefono = telefono
        p.Mail = mail
        p.FechaHoraCreacion = fhcreacion
        p.Activo = activo
        p.Modificar()

    End Sub

    Public Function Listar(id As String)
        Dim p As New Capa_Datos.Persona
        Return p.Listar(id)

    End Function


End Module
