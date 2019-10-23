Public Class entCategoria
    Private _idcategoria
    Private _nomcategoria
    Private _estado
    Public Property idcategoria As Integer
        Get
            Return _idcategoria
        End Get
        Set(value As Integer)
            _idcategoria = value
        End Set
    End Property
    Public Property nomcategoria As String
        Get
            Return _nomcategoria
        End Get
        Set(value As String)
            _nomcategoria = value
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
