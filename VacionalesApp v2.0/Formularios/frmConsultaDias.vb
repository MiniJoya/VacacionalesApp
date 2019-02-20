Public Class frmConsultaDias

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Comando.Connection = Conexion

        If txtNoContrato.Text = "" Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtNoContrato.Focus()
        Else

            Try
                Conexion.Open()

                Comando.CommandText = "SELECT nombre, desarrollo, departamento FROM clientes WHERE no_contrato = '" + txtNoContrato.Text + "'"
                Reader = Comando.ExecuteReader

                While Reader.Read()

                    txtNomCliente.Text = Reader.GetString("nombre")
                    txtDesarrollo.Text = Reader.GetString("desarrollo")
                    txtDepartamento.Text = Reader.GetString("departamento")

                End While

                Conexion.Close()

                Conexion.Open()

                Comando.CommandText = "SELECT DiasDisp FROM dias WHERE no_contrato = '" + txtNoContrato.Text + "'"
                Reader = Comando.ExecuteReader

                While Reader.Read()

                    lblDiasRestantes.Text = Reader.GetInt32("DiasDisp")
                    If lblDiasRestantes.Text <= 0 Then
                        MessageBox.Show("Se acabo el contrato, ocupa renovacion!")
                    End If

                End While

                Conexion.Close()

                'Tabla
                Conexion.Open()

                Comando.CommandText = "SELECT no_contrato, FechaInicioAct, FechaFinalAct, dias_consumidos FROM activacion WHERE no_contrato = '" + txtNoContrato.Text + "'"

                'Tabla
                Dim dbDataSet As New DataTable
                Dim bSource As New BindingSource
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                tablaConsulta.DataSource = bSource
                Adaptador.Update(dbDataSet)
                tablaConsulta.Columns(0).HeaderText = "Numero de Contrato"
                tablaConsulta.Columns(1).HeaderText = "Fecha de Inicio de Activacion"
                tablaConsulta.Columns(2).HeaderText = "Fecha Final de Activacion"
                tablaConsulta.Columns(3).HeaderText = "Dias Totales Consumidos"

                Conexion.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

        End If
    End Sub

    Private Sub txtNoContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoContrato.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo numerico", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Class
