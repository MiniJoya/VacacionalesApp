Imports MySql.Data.MySqlClient

Public Class frmModificarActivacion

    Private Sub frmModificarActivacion_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ConnectionState.Open Then
            Conexion.Close()
        Else

            Comando.Connection = Conexion

            Conexion.Open()

            Comando.CommandText = "SELECT activacion.id_activacion, clientes.no_contrato, clientes.nombre, clientes.desarrollo, clientes.departamento, activacion.FechaInicioAct, activacion.FechaFinalAct, activacion.Indefinido FROM clientes, activacion WHERE activacion.no_contrato = clientes.no_contrato And activacion.Indefinido = '" + "Si" + "'"

            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            Adaptador.SelectCommand = Comando
            Adaptador.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            tablaConsulta.DataSource = bSource
            Adaptador.Update(dbDataSet)
            tablaConsulta.Columns(0).HeaderText = "ID Activacion"
            tablaConsulta.Columns(1).HeaderText = "Numero de Contrato"
            tablaConsulta.Columns(2).HeaderText = "Nombre"
            tablaConsulta.Columns(3).HeaderText = "Desarrollo"
            tablaConsulta.Columns(4).HeaderText = "Departamento"
            tablaConsulta.Columns(5).HeaderText = "Fecha Inicio Activacion"
            tablaConsulta.Columns(6).HeaderText = "Fecha Final Activacion"
            tablaConsulta.Columns(7).HeaderText = "¿Indefinido?"

            Conexion.Close()

            txtActivacionID.Enabled = False
            txtContrato.Enabled = False
            txtNombre.Enabled = False
            txtDesarrollo.Enabled = False
            txtDepartamento.Enabled = False
            DateInicio.Enabled = False

        End If

    End Sub

    Private Sub tablaConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaConsulta.CellClick
        If (e.RowIndex <> -1) Then

            Dim index As Integer

            index = e.RowIndex
            Dim SelectedRow As DataGridViewRow
            SelectedRow = tablaConsulta.Rows(index)

            txtActivacionID.Text = SelectedRow.Cells(0).Value.ToString()
            txtContrato.Text = SelectedRow.Cells(1).Value.ToString()
            txtNombre.Text = SelectedRow.Cells(2).Value.ToString()
            txtDesarrollo.Text = SelectedRow.Cells(3).Value.ToString()
            txtDepartamento.Text = SelectedRow.Cells(4).Value.ToString()
            DateInicio.Text = SelectedRow.Cells(5).Value.ToString()
            DateTerminacion.Text = SelectedRow.Cells(6).Value.ToString()

        Else
            txtContrato.Text = ""
            txtNombre.Text = ""
            txtDesarrollo.Text = ""
            txtDepartamento.Text = ""
            DateInicio.Text = ""
            DateTerminacion.Text = ""
            DateTerminacion.Focus()
        End If


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        If ConnectionState.Open Then
            Conexion.Close()
        Else
            Try

                Comando.Connection = Conexion

                Conexion.Open()
                Comando.CommandText = "UPDATE activacion SET FechaFinalAct = '" + DateTerminacion.Value.ToString("yyyy-MM-dd") + "', dias_consumidos = '" + txtDias.Text + "', Indefinido = '" + "No" + "' WHERE id_activacion = '" + txtActivacionID.Text + "'"
                Reader = Comando.ExecuteReader
                Conexion.Close()

                Conexion.Open()
                Comando.CommandText = "UPDATE dias SET dias.DiasConsum = '" + txtDias.Text + "' WHERE no_contrato = '" + txtContrato.Text + "'"
                Reader = Comando.ExecuteReader
                Conexion.Close()

                Conexion.Open()
                Comando.CommandText = "UPDATE dias SET dias.DiasDisp = dias.DiasDisp - dias.DiasConsum WHERE no_contrato = '" + txtContrato.Text + "'"
                Reader = Comando.ExecuteReader
                Conexion.Close()



                Conexion.Open()

                Comando.CommandText = "SELECT activacion.id_activacion, clientes.no_contrato, clientes.nombre, clientes.desarrollo, clientes.departamento, activacion.FechaInicioAct, activacion.FechaFinalAct, activacion.Indefinido FROM clientes, activacion WHERE activacion.no_contrato = clientes.no_contrato And activacion.Indefinido = '" + "Si" + "'"

                Dim dbDataSet As New DataTable
                Dim bSource As New BindingSource

                Adaptador.SelectCommand = Comando
                Adaptador.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                tablaConsulta.DataSource = bSource
                Adaptador.Update(dbDataSet)
                tablaConsulta.Columns(0).HeaderText = "ID Activacion"
                tablaConsulta.Columns(1).HeaderText = "Numero de Contrato"
                tablaConsulta.Columns(2).HeaderText = "Nombre"
                tablaConsulta.Columns(3).HeaderText = "Desarrollo"
                tablaConsulta.Columns(4).HeaderText = "Departamento"
                tablaConsulta.Columns(5).HeaderText = "Fecha Inicio Activacion"
                tablaConsulta.Columns(6).HeaderText = "Fecha Final Activacion"
                tablaConsulta.Columns(7).HeaderText = "¿Indefinido?"

                Conexion.Close()

                MessageBox.Show("La modificacion ha sido realizada con exito")

                txtActivacionID.Text = ""
                txtContrato.Text = ""
                txtDepartamento.Text = ""
                txtDesarrollo.Text = ""
                txtDias.Text = ""
                txtNombre.Text = ""
                DateInicio.ResetText()
                DateTerminacion.ResetText()

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        If Conexion.State = ConnectionState.Open Then

            Conexion.Close()
        Else
            Try

                Comando.Connection = Conexion

                Conexion.Open()

                Comando.CommandText = "SELECT activacion.id_activacion, clientes.no_contrato, clientes.nombre, clientes.desarrollo, clientes.departamento, activacion.FechaInicioAct, activacion.FechaFinalAct, activacion.Indefinido FROM clientes, activacion WHERE activacion.no_contrato = clientes.no_contrato And activacion.Indefinido = '" + "Si" + "'"

                Dim dbDataSet As New DataTable
                Dim bSource As New BindingSource

                Adaptador.SelectCommand = Comando
                Adaptador.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                tablaConsulta.DataSource = bSource
                Adaptador.Update(dbDataSet)
                tablaConsulta.Columns(0).HeaderText = "ID Activacion"
                tablaConsulta.Columns(1).HeaderText = "Numero de Contrato"
                tablaConsulta.Columns(2).HeaderText = "Nombre"
                tablaConsulta.Columns(3).HeaderText = "Desarrollo"
                tablaConsulta.Columns(4).HeaderText = "Departamento"
                tablaConsulta.Columns(5).HeaderText = "Fecha Inicio Activacion"
                tablaConsulta.Columns(6).HeaderText = "Fecha Final Activacion"
                tablaConsulta.Columns(7).HeaderText = "¿Indefinido?"

                Conexion.Close()


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class