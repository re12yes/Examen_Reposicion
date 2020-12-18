<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grbPosicion = New System.Windows.Forms.GroupBox()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtchasis = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.lblchasis = New System.Windows.Forms.Label()
        Me.txtmotor = New System.Windows.Forms.TextBox()
        Me.lblmotor = New System.Windows.Forms.Label()
        Me.lblmodelo = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbPosicion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPosicion
        '
        Me.grbPosicion.Controls.Add(Me.lblPosicion)
        Me.grbPosicion.Controls.Add(Me.btnUltimo)
        Me.grbPosicion.Controls.Add(Me.btnSiguiente)
        Me.grbPosicion.Controls.Add(Me.btnAnterior)
        Me.grbPosicion.Controls.Add(Me.btnPrimero)
        Me.grbPosicion.Location = New System.Drawing.Point(12, 215)
        Me.grbPosicion.Name = "grbPosicion"
        Me.grbPosicion.Size = New System.Drawing.Size(506, 64)
        Me.grbPosicion.TabIndex = 33
        Me.grbPosicion.TabStop = False
        Me.grbPosicion.Text = "Posicion"
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosicion.Location = New System.Drawing.Point(245, 24)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(44, 16)
        Me.lblPosicion.TabIndex = 5
        Me.lblPosicion.Text = "1 de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(405, 14)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 46)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(324, 14)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 46)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(119, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(90, 46)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(36, 12)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(75, 46)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnNuevo)
        Me.grbEdicion.Location = New System.Drawing.Point(12, 287)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(506, 64)
        Me.grbEdicion.TabIndex = 32
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(348, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 46)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(267, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 46)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(171, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 46)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(88, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 46)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtchasis)
        Me.grbDatos.Controls.Add(Me.txtmodelo)
        Me.grbDatos.Controls.Add(Me.lblchasis)
        Me.grbDatos.Controls.Add(Me.txtmotor)
        Me.grbDatos.Controls.Add(Me.lblmotor)
        Me.grbDatos.Controls.Add(Me.lblmodelo)
        Me.grbDatos.Controls.Add(Me.txtmarca)
        Me.grbDatos.Controls.Add(Me.txtyear)
        Me.grbDatos.Controls.Add(Me.lblyear)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Location = New System.Drawing.Point(12, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(506, 197)
        Me.grbDatos.TabIndex = 31
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos vehiculo"
        '
        'txtchasis
        '
        Me.txtchasis.Location = New System.Drawing.Point(88, 158)
        Me.txtchasis.Name = "txtchasis"
        Me.txtchasis.Size = New System.Drawing.Size(228, 20)
        Me.txtchasis.TabIndex = 17
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(88, 50)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(228, 20)
        Me.txtmodelo.TabIndex = 16
        '
        'lblchasis
        '
        Me.lblchasis.AutoSize = True
        Me.lblchasis.Location = New System.Drawing.Point(15, 161)
        Me.lblchasis.Name = "lblchasis"
        Me.lblchasis.Size = New System.Drawing.Size(64, 13)
        Me.lblchasis.TabIndex = 15
        Me.lblchasis.Text = "Serie chasis"
        '
        'txtmotor
        '
        Me.txtmotor.Location = New System.Drawing.Point(88, 125)
        Me.txtmotor.Name = "txtmotor"
        Me.txtmotor.Size = New System.Drawing.Size(228, 20)
        Me.txtmotor.TabIndex = 13
        '
        'lblmotor
        '
        Me.lblmotor.AutoSize = True
        Me.lblmotor.Location = New System.Drawing.Point(15, 128)
        Me.lblmotor.Name = "lblmotor"
        Me.lblmotor.Size = New System.Drawing.Size(60, 13)
        Me.lblmotor.TabIndex = 12
        Me.lblmotor.Text = "Serie motor"
        '
        'lblmodelo
        '
        Me.lblmodelo.AutoSize = True
        Me.lblmodelo.Location = New System.Drawing.Point(16, 53)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblmodelo.Size = New System.Drawing.Size(42, 13)
        Me.lblmodelo.TabIndex = 10
        Me.lblmodelo.Text = "Modelo"
        Me.lblmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(88, 19)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(228, 20)
        Me.txtmarca.TabIndex = 5
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(88, 87)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(228, 20)
        Me.txtyear.TabIndex = 3
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Location = New System.Drawing.Point(15, 90)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(26, 13)
        Me.lblyear.TabIndex = 2
        Me.lblyear.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 359)
        Me.Controls.Add(Me.grbPosicion)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbPosicion.ResumeLayout(False)
        Me.grbPosicion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPosicion As GroupBox
    Friend WithEvents lblPosicion As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtmotor As TextBox
    Friend WithEvents lblmotor As Label
    Friend WithEvents lblmodelo As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents lblyear As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtchasis As TextBox
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents lblchasis As Label
End Class
