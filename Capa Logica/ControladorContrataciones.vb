Public Module ControladorContrataciones
    Public Sub Alta(idp As String, ids As String, fcontrata As Date, fincontrata As Date)

        Dim s As New Capa_Datos.Contrataciones

        s.IdPersona = idp
        s.IdServicio = ids
        s.FechaContratacion = fcontrata
        s.FinContratacion = fincontrata
        s.Alta()

    End Sub
    Public Sub Borrar(idp As String)

        Dim s As New Capa_Datos.Contrataciones
        s.IdPersona = idp
        s.Borrar()

    End Sub

    Public Sub Modificar(idp As String, ids As String, fcreacion As Date, fcontrata As Date, fincontrata As Date)

        Dim s As New Capa_Datos.Contrataciones

        s.IdPersona = idp
        s.IdServicio = ids
        s.FechaCreacion = fcreacion
        s.FechaContratacion = fcontrata
        s.FinContratacion = fincontrata
        s.Modificar()

    End Sub

    Public Function Listar(idp As String)
        Dim s As New Capa_Datos.Contrataciones
        Return s.Listar(idp)

    End Function

End Module
