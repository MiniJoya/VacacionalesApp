Imports MySql.Data.MySqlClient
Imports VacionalesApp_v2._0.ClaseConexionMySQL


Public Class frmVerClientes

    Private Sub frmVerClientes_Load(sender As Object, e As EventArgs) Handles Me.Load

        Conexion.Close()

        ClaseConexionMySQL.Comando.Connection = Conexion

        Comando.CommandText = "SELECT no_contrato, nombre, desarrollo, departamento, fechainiciocontrato, fechafinalcontrato, estadoact FROM clientes"

        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Adaptador.SelectCommand = Comando
        Adaptador.Fill(dbDataSet)

        bSource.DataSource = dbDataSet
        tablaConsulta.DataSource = bSource
        Adaptador.Update(dbDataSet)
        tablaConsulta.Columns(0).HeaderText = "Numero de contrato"
        tablaConsulta.Columns(1).HeaderText = "Nombre del cliente"
        tablaConsulta.Columns(2).HeaderText = "Desarrollo"
        tablaConsulta.Columns(3).HeaderText = "Departamento"
        tablaConsulta.Columns(4).HeaderText = "Fecha de fnicio de activacion"
        tablaConsulta.Columns(5).HeaderText = "Fecha final de activacion"
        tablaConsulta.Columns(6).HeaderText = "Estado principal de activacion"

        Conexion.Close()

    End Sub

    Public Sub ConsultadinamicaContrato(ByVal Contrato As String, ByVal tablaConsulta As DataGridView)
        Try
            Dim DA As New MySqlDataAdapter("Select * from clientes where no_contrato like '" & "%" + Contrato + "%" & "'", Conexion)
            Dim DT As New DataTable
            DA.Fill(DT)
            tablaConsulta.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos:" + ex.ToString)
        End Try
    End Sub

    Public Sub ConsultadinamicaNombre(ByVal Contrato As String, ByVal tablaConsulta As DataGridView)
        Try
            Dim DA As New MySqlDataAdapter("Select * from clientes where nombre like '" & "%" + Contrato + "%" & "'", Conexion)
            Dim DT As New DataTable
            DA.Fill(DT)
            tablaConsulta.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos:" + ex.ToString)
        End Try
    End Sub

    Public Sub ConsultadinamicaDepartamento(ByVal Contrato As String, ByVal tablaConsulta As DataGridView)
        Try
            Dim DA As New MySqlDataAdapter("Select * from clientes where departamento like '" & "%" + Contrato + "%" & "'", Conexion)
            Dim DT As New DataTable
            DA.Fill(DT)
            tablaConsulta.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos:" + ex.ToString)
        End Try
    End Sub

    Public Sub ConsultadinamicaDesarrollo(ByVal Contrato As String, ByVal tablaConsulta As DataGridView)
        Try
            Dim DA As New MySqlDataAdapter("Select * from clientes where desarrollo like '" & "%" + Contrato + "%" & "'", Conexion)
            Dim DT As New DataTable
            DA.Fill(DT)
            tablaConsulta.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos:" + ex.ToString)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If Me.cmbTipo.SelectedIndex = 0 Then
            ConsultadinamicaContrato(txtBusqueda.Text, tablaConsulta)
        ElseIf Me.cmbTipo.SelectedIndex = 1 Then
            ConsultadinamicaNombre(txtBusqueda.Text, tablaConsulta)
        ElseIf Me.cmbTipo.SelectedIndex = 2 Then
            ConsultadinamicaDepartamento(txtBusqueda.Text, tablaConsulta)
        ElseIf Me.cmbTipo.SelectedIndex = 3 Then
            ConsultadinamicaDesarrollo(txtBusqueda.Text, tablaConsulta)
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        txtBusqueda.Clear()
    End Sub
End Class
