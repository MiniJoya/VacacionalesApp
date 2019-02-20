Imports MySql.Data.MySqlClient

Public Class frmAgregarDesarrollo

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Comando.Connection = Conexion
        If txtDesarrollo.Text = "" Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtDesarrollo.Focus()
        Else

            Try

                If Conexion.State = ConnectionState.Closed Then

                    Conexion.Open()

                    sql = "INSERT INTO desarrollos(Desarrollo)
                         VALUES('" + txtDesarrollo.Text + "')"
                    Comando = New MySqlCommand(sql, Conexion)
                    Reader = Comando.ExecuteReader
                    MessageBox.Show("Desarrollo registrado con exito")
                    txtDesarrollo.ResetText()

                    Conexion.Close()

                    Conexion.Open()

                    Comando.CommandText = "SELECT * FROM desarrollos"

                    Dim dbDataSet As New DataTable
                    Dim bSource As New BindingSource

                    Adaptador.SelectCommand = Comando
                    Adaptador.Fill(dbDataSet)
                    bSource.DataSource = dbDataSet
                    tablaConsulta.DataSource = bSource
                    Adaptador.Update(dbDataSet)
                    tablaConsulta.Columns(0).HeaderText = "ID"
                    tablaConsulta.Columns(1).HeaderText = "Desarrollo"

                    Conexion.Close()

                End If
            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString)

            End Try


        End If


    End Sub

    Private Sub frmAgregarDesarrollo_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ConnectionState.Open Then
            Conexion.Close()
        Else

            Comando.Connection = Conexion

            Comando.CommandText = "SELECT * FROM desarrollos"

            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            Adaptador.SelectCommand = Comando
            Adaptador.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            tablaConsulta.DataSource = bSource
            Adaptador.Update(dbDataSet)
            tablaConsulta.Columns(0).HeaderText = "ID"
            tablaConsulta.Columns(1).HeaderText = "Desarrollo"

            Conexion.Close()

        End If
    End Sub
End Class
