Imports System.Data
Imports System.Data.SqlClient
Public Class db_conexion
    Dim miConexion As New SqlConnection
    Dim miCommand As New SqlCommand
    Dim miAdapter As New SqlDataAdapter
    Dim ds As New DataSet

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_autos.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
        parametrizacion()
    End Sub

    Private Sub parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@marca", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@modelo", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@year", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@motor", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@chasis", SqlDbType.Char).Value = ""
    End Sub

    Public Function datos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "SELECT * FROM vehiculos"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "vehiculos")

        Return ds
    End Function

    Public Function mantenimientoDatosVehiculos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO vehiculos (Marca,Modelo,Year,Numero_motor,Numero_chasis) VALUES (@marca,@modelo,@year,@motor,@chasis)"
            Case "actualizar"
                sql = "UPDATE vehiculos SET Marca=@marca,Modelo=@modelo,Year=@year,Numero_motor=@motor,Numero_chasis=@chasis WHERE IdVehiculo=@id"
            Case "eliminar"
                sql = "DELETE FROM vehiculos WHERE IdVehiculo=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@marca").Value = datos(1)
            miCommand.Parameters("@modelo").Value = datos(2)
            miCommand.Parameters("@year").Value = datos(3)
            miCommand.Parameters("@motor").Value = datos(4)
            miCommand.Parameters("@chasis").Value = datos(5)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Private Function executeSql(ByVal sql As String)
        Try
            miCommand.Connection = miConexion
            miCommand.CommandText = sql
            Return miCommand.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
