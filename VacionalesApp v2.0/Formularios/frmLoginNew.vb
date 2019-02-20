Public Class frmLoginNew

    Private IsBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Comando.Connection = Conexion

        Try
            Conexion.Open()

            Comando.CommandText = "SELECT * FROM usuarios WHERE user = '" + txtUser.Text + "' AND pass = '" + txtPass.Text + "'"

            Reader = Comando.ExecuteReader

            If Reader.HasRows <> False Then
                Reader.Read()
                MessageBox.Show("Bienvenido al sistema " & txtUser.Text & " VMnet Internet")
                Me.Hide()
                If txtUser.Text = "admin" And txtPass.Text = "admin" Then
                    frmMain.ShowDialog()
                Else
                    frmMain2.ShowDialog()
                End If
            Else
                lblError.Visible = True
                txtUser.Clear()
                txtPass.Clear()
                txtUser.Focus()
            End If
            Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmLoginNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUser.Select()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub frmLoginNew_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = False
        End If
    End Sub

    Private Sub frmLoginNew_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub frmLoginNew_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel_Logo_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Logo.MouseMove
        If IsBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Panel_Logo_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Logo.MouseUp
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = False
        End If
    End Sub

    Private Sub Panel_Logo_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Logo.MouseDown
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
End Class