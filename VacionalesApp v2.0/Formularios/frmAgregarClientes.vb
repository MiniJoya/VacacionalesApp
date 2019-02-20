Imports MySql.Data.MySqlClient

Public Class frmAgregarClientes
    Dim Datos As String
    Dim Estado As String
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Comando.Connection = Conexion

        If txtNombre.Text = "" Or txtContrato.Text = "" Or txtDepartamento.Text = "" Or txtDias.Text = "" Then
            MessageBox.Show("Ingrese los datos solicitados, no deje ningun campo vacio!")
        Else

            Try

                If Conexion.State = ConnectionState.Closed Then

                    Conexion.Open()

                    sql = "INSERT INTO clientes(no_contrato, nombre, desarrollo, departamento, FechaInicioContrato, FechaFinalContrato,EstadoAct) VALUES('" + txtContrato.Text + "','" + txtNombre.Text + "','" & Datos & "','" + txtDepartamento.Text + "','" + DateInicio.Value.ToString("yyyy-MM-dd") + "','" + DateTerminacion.Value.ToString("yyyy-MM-dd") + "','" + Estado + "')"
                    Comando = New MySqlCommand(sql, Conexion)
                    Reader = Comando.ExecuteReader
                    MessageBox.Show("Cliente registrado con exito")
                    Conexion.Close()

                    Conexion.Open()
                    sql = "INSERT INTO dias(no_contrato, totaldias, diasdisp) VALUES('" + txtContrato.Text + "','" + txtDias.Text + "','" + txtDias.Text + "')"
                    Comando = New MySqlCommand(sql, Conexion)
                    Reader = Comando.ExecuteReader
                    Conexion.Close()


                    txtContrato.ResetText()
                    txtDepartamento.ResetText()
                    txtNombre.ResetText()
                    cmbDesarrollo.ResetText()
                    DateInicio.ResetText()
                    DateTerminacion.ResetText()
                    txtDias.ResetText()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtNombre.ResetText()
        cmbDesarrollo.ResetText()
        txtDepartamento.ResetText()
        DateInicio.ResetText()
        DateTerminacion.ResetText()
        txtContrato.ResetText()
        txtDias.ResetText()
        BoxSi.Checked = False
        BoxNo.Checked = False
        txtNombre.Focus()

    End Sub

    Private Sub BoxSi_CheckedChanged(sender As Object, e As EventArgs) Handles BoxSi.CheckedChanged
        Estado = "Activado"
    End Sub

    Private Sub BoxNo_CheckedChanged(sender As Object, e As EventArgs) Handles BoxNo.CheckedChanged
        Estado = "Desactivado"
    End Sub

    Private Sub frmAgregarClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Llenado()
    End Sub


    Private Sub cmbDesarrollo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDesarrollo.SelectedIndexChanged
        Datos = cmbDesarrollo.Text()
    End Sub

    Public Sub Llenado()
        Dim DA As New MySqlDataAdapter("SELECT * FROM `desarrollos` ORDER BY `desarrollos`.`Desarrollo` ASC", Conexion)
        Dim DT As New DataTable
        DA.Fill(DT)
        cmbDesarrollo.DataSource = DT
        cmbDesarrollo.DisplayMember = "Desarrollo"
        cmbDesarrollo.ValueMember = "Desarrollo"

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Llenado()
    End Sub

    Private Sub txtContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrato.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo numerico", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDias.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo numerico", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
End Class
