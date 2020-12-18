Public Class Form1
    Dim objConexion As New db_conexion
    Dim dataTable As New DataTable
    Dim Accion As String = "nuevo"
    Dim Posicion As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatos()
        HabDescontrol(True)
    End Sub

    Sub ObtenerDatos()
        dataTable = objConexion.datos().tables("vehiculos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("IdVehiculo")}

        MostrarDatos()
    End Sub

    Sub MostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(Posicion).ItemArray(0).ToString()
            txtmarca.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
            txtmodelo.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
            txtyear.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
            txtmotor.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()
            txtchasis.Text = dataTable.Rows(Posicion).ItemArray(5).ToString()

            lblPosicion.Text = Posicion + 1 & " de " & dataTable.Rows.Count
        Else
            LimpiarDatos()
            MessageBox.Show("No hay registros que mostrar", "Registro Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub LimpiarDatos()
        txtmarca.Text = ""
        txtmodelo.Text = ""
        txtyear.Text = ""
        txtmotor.Text = ""
        txtchasis.Text = ""
    End Sub

    Sub HabDescontrol(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbPosicion.Enabled = estado
        btnEliminar.Enabled = estado
        btnBuscar.Enabled = estado
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "Nuevo" Then 'Nuevo
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "nuevo"

            HabDescontrol(False)
            LimpiarDatos()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosVehiculos(New String() {
                Me.Tag, txtmarca.Text, txtmodelo.Text, txtyear.Text, txtmotor.Text, txtchasis.Text
            }, Accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ObtenerDatos()
                HabDescontrol(True)
                btnNuevo.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        Posicion = 0
        MostrarDatos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If Posicion > 0 Then
            Posicion -= 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            MostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Posicion = dataTable.Rows.Count - 1
        MostrarDatos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then 'Modificar
            btnNuevo.Text = "Guardar"
            btnModificar.Text = "Cancelar"
            Accion = "actualizar"
            HabDescontrol(False)
        Else 'Cancelar
            ObtenerDatos()

            HabDescontrol(True)
            btnNuevo.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("¿Estas seguro de borrar este registro?", "Registro vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosVehiculos(New String() {Me.Tag}, "eliminar")
            If Posicion > 0 Then
                Posicion -= 1
            End If
            ObtenerDatos()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscarProducto As New FormBusquedaVehiculo
        objBuscarProducto.ShowDialog()
        If objBuscarProducto._idV > 0 Then
            Posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProducto._idV))
            MostrarDatos()
        End If
    End Sub
End Class
