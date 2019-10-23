Public Class entProducto
    Private _idproducto
    Private _nomproducto
    Private _precioventa
    Private _stock
    Private _presentacion
    Private _estado
    Public objCategoria As entCategoria

    Public Property idproducto As String
        Get
            Return _idproducto
        End Get
        Set(value As String)
            _idproducto = value
        End Set
    End Property
    Public Property nomproducto As String
        Get
            Return _nomproducto
        End Get
        Set(value As String)
            _nomproducto = value
        End Set
    End Property
    Public Property precioventa As Double
        Get
            Return _precioventa
        End Get
        Set(value As Double)
            _precioventa = value
        End Set
    End Property
    Public Property stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
    Public Property presentacion As String
        Get
            Return _presentacion
        End Get
        Set(value As String)
            _presentacion = value
        End Set
    End Property
    Public Property estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
    

    
    
End Class
