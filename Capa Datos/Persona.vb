Public Class Persona
    Inherits Modelo

    Public IdPersona As String
    Public Nombre As String
    Public Apellido As String
    Public Telefono As String
    Public Mail As String
    Public FechaHoraCreacion As DateTime
    Public Activo As Boolean

    Public Sub Alta()
        Comando.CommandText = "INSERT INTO Servicio VALUES(" + Me.IdPersona + ",'" + Me.Nombre + "','" + Me.Apellido + "', '" + Me.Telefono + "', '" + Me.Mail + "','" + Me.FechaHoraCreacion + "','" + Me.Activo + "')"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM Servicio WHERE id = " + Me.IdPersona
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Modificar()
        Comando.CommandText = "UPDATE Servicio SET nombre = '" + Me.Nombre + "', apellido ='" + Me.Apellido + "',telefono ='" + Me.Telefono + "', mail = '" + Me.Mail + "', fechaHoraCreacion = '" + Me.FechaHoraCreacion + "', activo = '" + Me.Activo + "' WHERE servicio = " + Me.IdPersona
        Comando.ExecuteNonQuery()
    End Sub

    Public Function Listar(id As String)
        Comando.CommandText = "SELECT * FROM Persona WHERE id = " + id
        Reader = Comando.ExecuteReader()
        Return Reader
    End Function
End Class
