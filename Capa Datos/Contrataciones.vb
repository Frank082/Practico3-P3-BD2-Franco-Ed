Public Class Contrataciones
    Inherits Modelo

    Public IdPersona As String
    Public IdServicio As String
    Public FechaCreacion As Date
    Public FechaContratacion As Date
    Public FinContratacion As Date

    Public Sub Alta()
        Comando.CommandText = "INSERT INTO Contrata VALUES(" + Me.IdPersona + ",'" + Me.IdServicio + "',now(),'" + Me.FechaContratacion + "','" + Me.FinContratacion + "')"
        Comando.ExecuteNonQuery()
    End Sub
    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM Contrata WHERE id = " + Me.IdPersona
        Comando.ExecuteNonQuery()
    End Sub
    Public Sub Modificar()
        Comando.CommandText = "UPDATE Contrata SET idp = '" + Me.IdPersona + "', ids ='" + Me.IdServicio + "', fcreacion = '" + Me.FechaCreacion + "', fcontrata = '" + Me.FechaContratacion + "', fincontrata = '" + Me.FinContratacion + "' WHERE servicio = " + Me.IdPersona
        Comando.ExecuteNonQuery()
    End Sub
    Public Function Listar(idp As String)
        Comando.CommandText = "SELECT * FROM Contrata WHERE id = s.IdPersona"
        Reader = Comando.ExecuteReader()
        Return Reader
    End Function


End Class
