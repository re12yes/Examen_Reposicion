<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaVehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdBuscar = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.IdVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chasis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(477, 396)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(118, 32)
        Me.btnSeleccionar.TabIndex = 9
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(57, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(645, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'grdBuscar
        '
        Me.grdBuscar.AllowUserToAddRows = False
        Me.grdBuscar.AllowUserToDeleteRows = False
        Me.grdBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVehiculo, Me.marca, Me.modelo, Me.year, Me.motor, Me.Chasis})
        Me.grdBuscar.Location = New System.Drawing.Point(12, 32)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.ReadOnly = True
        Me.grdBuscar.Size = New System.Drawing.Size(690, 345)
        Me.grdBuscar.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(601, 396)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'IdVehiculo
        '
        Me.IdVehiculo.DataPropertyName = "IdVehiculo"
        Me.IdVehiculo.HeaderText = "ID"
        Me.IdVehiculo.Name = "IdVehiculo"
        Me.IdVehiculo.ReadOnly = True
        Me.IdVehiculo.Visible = False
        Me.IdVehiculo.Width = 50
        '
        'marca
        '
        Me.marca.DataPropertyName = "Marca"
        Me.marca.HeaderText = "MARCA"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 210
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "Modelo"
        Me.modelo.HeaderText = "MODELO"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'year
        '
        Me.year.DataPropertyName = "Year"
        Me.year.HeaderText = "AÑO"
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        Me.year.Width = 125
        '
        'motor
        '
        Me.motor.DataPropertyName = "Numero_motor"
        Me.motor.HeaderText = "MOTOR"
        Me.motor.Name = "motor"
        Me.motor.ReadOnly = True
        Me.motor.Width = 150
        '
        'Chasis
        '
        Me.Chasis.DataPropertyName = "Chasis"
        Me.Chasis.HeaderText = "CHASIS"
        Me.Chasis.Name = "Chasis"
        Me.Chasis.ReadOnly = True
        Me.Chasis.Width = 120
        '
        'FormBusquedaVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "FormBusquedaVehiculo"
        Me.Text = "FormBusquedaVehiculo"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdBuscar As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents IdVehiculo As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents year As DataGridViewTextBoxColumn
    Friend WithEvents motor As DataGridViewTextBoxColumn
    Friend WithEvents Chasis As DataGridViewTextBoxColumn
End Class
