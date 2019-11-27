Imports CapaNegocio
Imports CapaEntidad
Public Class frmVenta
    Dim objneg As New negProducto
    Dim objent As New entProducto
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegProducto As New negProducto
        cmbProducto.DataSource = objnegProducto.mostrar()
        cmbProducto.DisplayMember = "nomproducto"
        cmbProducto.ValueMember = "idproducto"
        dgvDetalle.Columns.Add("idproducto", "idproducto")
        dgvDetalle.Columns.Add("nomproducto", "nombproducto")
        dgvDetalle.Columns.Add("cantidadproducto", "cantidadproducto")
        dgvDetalle.Columns.Add("precioproducto", "precioproducto")
        dgvDetalle.Columns.Add("subtaotalproducto", "subtotalproducto")
        dgvDetalle.Columns(0).Visible = False
    End Sub
#Region "boton agregar,texto,cellclick"

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        objent = objneg.cargar(Me.cmbProducto.SelectedValue(0))
        txtPrecio.Text = objent.precioventa
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim cantidad As Integer
        cantidad = Val(txtCantidad.Text)
        If cantidad <= objent.stock Then
            Dim subtotal As Double
            subtotal = Val(txtCantidad.Text) * Val(txtPrecio.Text)
            dgvDetalle.Rows.Add(cmbProducto.SelectedValue, cmbProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal)
            Dim montot As Double
            montot = subtotal + Val(txtMontoTotal.Text)
            txtMontoTotal.Text = montot
           


        Else
            MsgBox("no hay suficiente stock")
        End If
    End Sub

    Private Sub txtnomCliente_TextChanged(sender As Object, e As EventArgs) Handles txtnomCliente.TextChanged
        Dim objneg As New negCliente
        If txtnomCliente.TextLength > 3 Then
            dgvcliente.DataSource = objneg.buscar(txtnomCliente.Text)
            dgvcliente.Visible = True
        Else
            dgvcliente.Visible = False
        End If
    End Sub

    Private Sub dgvcliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcliente.CellClick
        Dim i As Integer
        i = dgvcliente.CurrentRow.Index
        txtIdCliente.Text = dgvcliente.Item(0, i).Value()
        txtnomCliente.Text = dgvcliente.Item(1, i).Value()
        dgvcliente.Visible = False
    End Sub
#End Region
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idventa As Integer
        Dim fecha As Date
        Dim idcliente As Integer
        Dim tipodoc As String
        Dim monto As Double
        Dim estado As String
        idventa = Val(txtidVenta.Text)
        fecha = DateTimePicker1.Text
        idcliente = Val(txtIdCliente.Text)
        tipodoc = cmbTipoDoc.Text
        monto = Val(txtMontoTotal.Text)
        estado = cmbEstadoDoc.Text
        Dim objentVenta As New entVenta
        objentVenta.idventa = idventa
        objentVenta.fecha = fecha
        objentVenta.idcliente = idcliente
        objentVenta.tipodoc = tipodoc
        objentVenta.monto = monto
        objentVenta.estado = estado
        ''Metodo de ingreso con lista sin verificar
        'Dim lisVenta As New List(Of entDetalleVenta)
        ' ''llenar datos al detalle venta
        'Dim objentDV As New entDetalleVenta
        'For a = 0 To dgvDetalle.Rows.Count - 2
        '    objentDV.idventa = Integer.Parse(txtidVenta.Text)
        '    objentDV.idproducto = dgvDetalle.Rows.Item(a).Cells(0).Value.ToString
        '    objentDV.cantidad = dgvDetalle.Rows.Item(a).Cells(2).Value
        '    objentDV.costo = dgvDetalle.Rows.Item(a).Cells(3).Value
        '    MsgBox(objentDV.idproducto)
        '    lisVenta.Add(objentDV)
        'Next
        'objentVenta.detallev = lisVenta
        'Dim objnegventa As New negVenta
        'Dim validar = objnegventa.nuevaVenta(objentVenta)
        'If (validar) Then
        '    MsgBox("Venta registrada")
        '    limpiarDatos()
        'Else
        '    MsgBox("Error")
        'End If




        Dim objnegventa As New negVenta
        ''MsgBox(objentVenta.fecha)
        If dgvDetalle.Rows.Count > 1 Then
            Dim validar = objnegventa.nuevaVenta(objentVenta)
            If (validar) Then
                MsgBox("Venta registrada")
                ''envio a la tabla detalleventa
                For Each Fila As DataGridViewRow In dgvDetalle.Rows
                    '//O puedes almacenar el valor en una base de datos o mostrarlo en un textbox
                    Try
                        Dim objentDV As New entDetalleVenta
                        objentDV.idproducto = Fila.Cells("idproducto").Value.ToString
                        objentDV.idventa = Val(txtidVenta.Text)
                        objentDV.cantidad = Fila.Cells("cantidadproducto").Value
                        objentDV.costo = Fila.Cells("precioproducto").Value
                        Dim validarDV = objnegventa.detalleVenta(objentDV)
                    Catch ex As Exception
                        MsgBox("Todo esta registrado")
                    End Try
                Next
            Else
                MsgBox("Error al registrar venta")
            End If
            ''fin de envio a la tabla detalleventa

            'For i As Integer = 0 To dgvDetalle.Rows.Count
            '    Dim objentDV As New entDetalleVenta
            '    objentDV.idproducto = dgvDetalle.Rows.Item(i).Cells("idproducto").Value.ToString
            '    objentDV.idventa = Val(txtidVenta.Text)
            '    objentDV.cantidad = dgvDetalle.Rows.Item(i).Cells("cantidadproducto").Value
            '    objentDV.costo = dgvDetalle.Rows.Item(i).Cells("precioproducto").Value
            '    Dim validarDV = objnegventa.detalleVenta(objentDV)
            '    If (validar) Then
            '        MsgBox("Detalle Venta registrada")

            '    End If
            'Next
            '
            limpiarDatos()

        Else
            MsgBox("Debe de agregar productos para completar la venta")
        End If
    End Sub

    Private Sub cmbTipoDoc_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoDoc.SelectedValueChanged
        If (cmbTipoDoc.Text = "Factura") Then
            'MsgBox("es una factura bro")
            cmbEstadoDoc.Items.Add("Aceptada F")
            cmbEstadoDoc.Items.Add("Rechazada F")
            cmbEstadoDoc.Items.Add("En proceso F")
            cmbEstadoDoc.Items.Remove("Aceptada B")
            cmbEstadoDoc.Items.Remove("Rechazada B")
            cmbEstadoDoc.Items.Remove("En proceso B")
        ElseIf (cmbTipoDoc.Text = "Boleta") Then
            'MsgBox("es una boleta bro")
            cmbEstadoDoc.Items.Add("Aceptada B")
            cmbEstadoDoc.Items.Add("Rechazada B")
            cmbEstadoDoc.Items.Add("En proceso B")
            cmbEstadoDoc.Items.Remove("Aceptada F")
            cmbEstadoDoc.Items.Remove("Rechazada F")
            cmbEstadoDoc.Items.Remove("En proceso F")
        End If
    End Sub
    Sub limpiarDatos()
        txtidVenta.Clear()
        txtIdCliente.Clear()
        txtnomCliente.Clear()
        txtCantidad.Clear()
        txtMontoTotal.Clear()
        dgvDetalle.Rows.Clear()
    End Sub

    
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim objneg As New negVenta
        DataGridView1.DataSource = objneg.listar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objneg As New negVenta
        Dim id As Integer
        id = Val(txtidventab.Text)
        DataGridView1.DataSource = objneg.buscar(id)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim objneg As New negVenta
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        txtidVenta.Text = DataGridView1.Item(0, i).Value()
        DateTimePicker1.Text = DataGridView1.Item(1, i).Value()
        txtIdCliente.Text = DataGridView1.Item(2, i).Value()
        cmbTipoDoc.Text = DataGridView1.Item(3, i).Value()
        cmbEstadoDoc.Text = DataGridView1.Item(5, i).Value()
        txtMontoTotal.Text = DataGridView1.Item(4, i).Value()
        txtnomCliente.Text = DataGridView1.Item(6, i).Value()
        dgvDetalle.Columns.Clear()
        dgvDetalle.DataSource = objneg.listardgv(id)
    End Sub
End Class