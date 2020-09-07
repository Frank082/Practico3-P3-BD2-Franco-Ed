Public Class Servicio
    Inherits Modelo

    Public IdServicio As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String
    Public FechaHoraCreacion As DateTime
    Public Activo As Boolean

    Public Sub Alta()
        Comando.CommandText = "INSERT INTO Servicio VALUES(" + Me.IdServicio + ",'" + Me.Nombre + "','" + Me.CostoMensual + "','" + Me.Tipo + "','" + Me.FechaHoraCreacion + "','" + Me.Activo + "')"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM Servicio WHERE id = " + Me.IdServicio
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Modificar()
        Comando.CommandText = "UPDATE Servicio SET nombre = '" + Me.Nombre + "', costo ='" + Me.CostoMensual + "', tipo = '" + Me.Tipo + "', fechaHoraCreacion = '" + Me.FechaHoraCreacion + "', activo = '" + Me.Activo + "' WHERE servicio = " + Me.IdServicio
        Comando.ExecuteNonQuery()
    End Sub

    Public Function Listar(id As String)
        Comando.CommandText = "SELECT * FROM Servicio WHERE id = c.IdServicio"
        Reader = Comando.ExecuteReader()
        Return Reader
    End Function


End Class
