Imports CapaDatos
Imports CapaEntidad

Public Class negCliente
    Public Function buscar(nombre As String) As DataTable
        Dim objcli As New datCliente
        Return objcli.buscar(nombre)
    End Function
End Class
