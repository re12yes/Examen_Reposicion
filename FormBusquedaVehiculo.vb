Public Class FormBusquedaVehiculo
    Dim objConexion As New db_conexion
    Public _idV As Integer

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idV = 0
        Close()
    End Sub

    Private Sub FormBusquedaVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscar.DataSource = objConexion.datos().Tables("vehiculos").DefaultView
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        FiltrarDatosVehiculo(txtBuscar.Text)
        If e.KeyCode = 13 Then
            SeleccionVehiculo()
        End If
    End Sub

    Private Sub SeleccionVehiculo()
        _idV = grdBuscar.CurrentRow.Cells("IdVehiculo").Value.ToString()
        Close()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionVehiculo()
    End Sub
    Private Sub FiltrarDatosVehiculo(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscar.DataSource
        bs.Filter = "Marca like '%" & Valor & "%' or Modelo like '%" & Valor & "%'"
        grdBuscar.DataSource = bs
    End Sub
End Class