﻿Imports System.Data.SqlClient
Public Class datConexion
    Public cnn As SqlConnection
    Private _BaseDatos As String
    Private _Servidor As String
    Public Property BaseDatos As String
        Get
            Return _BaseDatos
        End Get
        Set(value As String)
            _BaseDatos = value
        End Set
    End Property
    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property
    Public Function Conectar(usuario As String, contrasena As String,
                             autenticacion As Boolean) As Boolean
        Dim cadena As String
        cadena = "Data Source=" + _Servidor + ";Initial Catalog=" + _BaseDatos
        If autenticacion Then
            cadena = cadena & ";Integrated Security=True"
        Else
            cadena = cadena & ";User Id=" & usuario &
                ";Password=" & contrasena
        End If
        Try
            cnn = New SqlConnection(cadena)
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub New()
        _Servidor = "FAPCOD\SQLEXPRESS"
        _BaseDatos = "Ventas"
        cnn = New SqlConnection
    End Sub

End Class
