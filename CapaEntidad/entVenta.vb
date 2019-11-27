Public Class entVenta
    Private _idventa
    Private _fecha
    Private _idcliente
    Private _tipodoc
    Private _monto
    Private _estado
    Public detallev As New List(Of entDetalleVenta)
    Public Property idventa As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property
    Public Property idcliente As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
        End Set
    End Property
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property tipodoc As String
        Get
            Return _tipodoc
        End Get
        Set(value As String)
            _tipodoc = value
        End Set
    End Property
    Public Property monto As Double
        Get
            Return _monto
        End Get
        Set(value As Double)
            _monto = value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Sub New()
        detallev = New List(Of entDetalleVenta)
    End Sub
End Class
