Public Class entDetalleVenta
    Private _idproducto
    Private _idventa
    Private _cantidad
    Private _costo

   
    Public Property idproducto As String
        Get
            Return _idproducto
        End Get
        Set(value As String)
            _idproducto = value
        End Set
    End Property
    Public Property idventa As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property costo As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property
    
End Class
