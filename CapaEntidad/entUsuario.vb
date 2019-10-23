Public Class entUsuario
    Private _idusuario As String
    Private _nombre As String
    Private _tipousuario As String
    Private _clave As String
    Private _estado As Boolean
    Public Property idusuario As String
        Get
            Return _idusuario
        End Get
        Set(value As String)
            _idusuario = value
        End Set
    End Property
    Public Property nombres As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    Public Property tipousuarios As String
        Get
            Return _tipousuario
        End Get
        Set(value As String)
            _tipousuario = value
        End Set
    End Property
    Public Property clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
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
