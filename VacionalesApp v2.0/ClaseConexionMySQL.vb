Imports System.Configuration
Imports MySql.Data.MySqlClient

Module ClaseConexionMySQL

    Public StringConexion As String = ConfigurationManager.ConnectionStrings("ConexionMySQL").ToString()
    Public Conexion As MySqlConnection = New MySqlConnection(StringConexion)
    Public Comando As MySqlCommand = New MySqlCommand
    Public Adaptador As MySqlDataAdapter = New MySqlDataAdapter
    Public Reader As MySqlDataReader
    Public dt As DataTable
    Public sql As String

    Public Sub ConexionDB()

        Try
            Conexion.ConnectionString = StringConexion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
