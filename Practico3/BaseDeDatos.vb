'Importamos librerías sql y sqlClient
Imports System.Data.Sql
Imports System.Data.SqlClient
Module BaseDeDatos

    'Declaro variables
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Sub New() 'Procedimiento para la conexión a base de datos a traves de un constructor
        Try
            cn = New SqlConnection("")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Error en la conexion:" + ex.ToString)
        End Try


    End Sub

    Sub llenarGrilla(ByVal dgv As DataGridView)
        Try
            'llena DataGridView con los registros de la tabla Persona
            'adaptador = New SqlDataAdapter("Select * From Persona.IdPersona", cn)
            adaptador = New SqlDataAdapter("Select Persona.IdPersona,Nombre,Apellido,Mail,FechaHoraCreacion,Activo from Persona inner join PersonaTel on Persona.IdPersona=PersonaTel.IdPersona", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al llenar la grilla:" + ex.ToString)
        End Try
    End Sub
    Sub consultaDinamica(ByVal id As String, ByVal dgv As DataGridView)
        Try
            'busca por id y se actualiza a medida que se va ingresando el Nº de identidad en DataGridView
            adaptador = New SqlDataAdapter("Select * from Persona where IdPersona like '" & "%" + id + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta en la grilla:" + ex.ToString)
        End Try
    End Sub
End Module

