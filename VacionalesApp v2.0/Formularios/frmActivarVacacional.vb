Imports MySql.Data.MySqlClient

Public Class frmActivarVacacional

    Private Sub frmActivarVacacional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Enabled = False
        txtDesarrollo.Enabled = False
        txtDepartamento.Enabled = False

        If rdSi.Checked Then
            DateTerminacion.Enabled = False
            txtDias.Enabled = False
        End If
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If rdNo.Checked Then

            If txtContrato.Text = "" Or txtDepartamento.Text = "" Or txtDesarrollo.Text = "" Or txtNombre.Text = "" Then

                MessageBox.Show("Porfavor llene todos los campos")

            Else

                Try
                    Comando.Connection = Conexion



                    Conexion.Open()
                    Comando.CommandText = "INSERT INTO activacion(fechainicioact, fechafinalact, no_contrato, dias_consumidos, Indefinido)
                        VALUES('" + DateInicio.Value.ToString("yyyy-MM-dd") + "','" + DateTerminacion.Value.ToString("yyyy-MM-dd") + "','" + txtContrato.Text + "','" + txtDias.Text + "','" + "No" + "')"
                    Reader = Comando.ExecuteReader
                    MessageBox.Show("Actualizado con exito")
                    Conexion.Close()

                    Conexion.Open()
                    Comando.CommandText = "UPDATE dias SET diasconsum = '" + txtDias.Text + "' WHERE no_contrato = '" + txtContrato.Text + "'"
                    Reader = Comando.ExecuteReader
                    Conexion.Close()

                    Conexion.Open()
                    Comando.CommandText = "UPDATE dias SET diasdisp = diasDisp - diasconsum WHERE no_contrato = '" + txtContrato.Text + "'"
                    Reader = Comando.ExecuteReader
                    Conexion.Close()

                    txtNombre.ResetText()
                    txtDesarrollo.ResetText()
                    txtDepartamento.ResetText()
                    txtDias.ResetText()
                    txtContrato.ResetText()



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        ElseIf rdSi.Checked Then

            If txtContrato.Text = "" Or txtDepartamento.Text = "" Or txtDesarrollo.Text = "" Or txtNombre.Text = "" Then

                MessageBox.Show("Porfavor llene todos los campos")

            Else
                Try

                    Comando.Connection = Conexion



                    Conexion.Open()
                    Comando.CommandText = "INSERT INTO activacion(FechaInicioAct, no_contrato, Indefinido )
                VALUES('" + DateInicio.Value.ToString("yyyy-MM-dd") + "','" + txtContrato.Text + "','" + "Si" + "')"
                    Reader = Comando.ExecuteReader
                    MessageBox.Show("Actualizado con exito")
                    Conexion.Close()

                    txtNombre.ResetText()
                    txtDesarrollo.ResetText()
                    txtDepartamento.ResetText()
                    txtDias.ResetText()
                    txtContrato.ResetText()



                Catch ex As Exception
            MsgBox(ex.Message)
            End Try
        End If

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Comando.Connection = Conexion


            Conexion.Open()
                Comando.CommandText = "SELECT no_contrato, nombre, desarrollo, departamento FROM clientes 
                WHERE no_contrato = '" + txtContrato.Text + "'"
                Reader = Comando.ExecuteReader

                While Reader.Read()

                    txtNombre.Text = Reader.GetString("nombre")
                    txtDesarrollo.Text = Reader.GetString("desarrollo")
                    txtDepartamento.Text = Reader.GetString("departamento")

                End While

                Conexion.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
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

    Private Sub rdSi_GotFocus(sender As Object, e As EventArgs) Handles rdSi.GotFocus
        txtDias.Enabled = False
        DateTerminacion.Enabled = False
    End Sub

    Private Sub rdSi_LostFocus(sender As Object, e As EventArgs) Handles rdSi.LostFocus
        txtDias.Enabled = True
        DateTerminacion.Enabled = True
    End Sub
End Class
