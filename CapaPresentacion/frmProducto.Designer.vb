<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.numPrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.nmStock = New System.Windows.Forms.NumericUpDown()
        CType(Me.numPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdProducto"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(84, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(84, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(84, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Presentacion"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(84, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtId.Location = New System.Drawing.Point(212, 37)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(154, 22)
        Me.txtId.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(212, 71)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 22)
        Me.txtNombre.TabIndex = 8
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPresentacion.Location = New System.Drawing.Point(212, 178)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(154, 22)
        Me.txtPresentacion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(84, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Categoria"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(212, 242)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(154, 24)
        Me.cmbCategoria.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(227, 356)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(166, 45)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(41, 356)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(166, 45)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(227, 305)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(166, 45)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(41, 305)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(166, 45)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'numPrecioVenta
        '
        Me.numPrecioVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numPrecioVenta.DecimalPlaces = 2
        Me.numPrecioVenta.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrecioVenta.Location = New System.Drawing.Point(213, 110)
        Me.numPrecioVenta.Name = "numPrecioVenta"
        Me.numPrecioVenta.Size = New System.Drawing.Size(153, 30)
        Me.numPrecioVenta.TabIndex = 19
        '
        'rbActivo
        '
        Me.rbActivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivo.ForeColor = System.Drawing.Color.White
        Me.rbActivo.Location = New System.Drawing.Point(213, 210)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(81, 24)
        Me.rbActivo.TabIndex = 20
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'rbInactivo
        '
        Me.rbInactivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInactivo.ForeColor = System.Drawing.Color.White
        Me.rbInactivo.Location = New System.Drawing.Point(297, 210)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(93, 24)
        Me.rbInactivo.TabIndex = 21
        Me.rbInactivo.TabStop = True
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'dgvProducto
        '
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Location = New System.Drawing.Point(438, 37)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.Size = New System.Drawing.Size(639, 339)
        Me.dgvProducto.TabIndex = 22
        '
        'nmStock
        '
        Me.nmStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nmStock.DecimalPlaces = 2
        Me.nmStock.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmStock.Location = New System.Drawing.Point(213, 142)
        Me.nmStock.Name = "nmStock"
        Me.nmStock.Size = New System.Drawing.Size(153, 30)
        Me.nmStock.TabIndex = 23
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1083, 441)
        Me.Controls.Add(Me.nmStock)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.rbInactivo)
        Me.Controls.Add(Me.rbActivo)
        Me.Controls.Add(Me.numPrecioVenta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPresentacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProducto"
        Me.Text = "frmProducto"
        CType(Me.numPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents numPrecioVenta As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents nmStock As System.Windows.Forms.NumericUpDown
End Class
