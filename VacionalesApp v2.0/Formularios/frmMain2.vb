Public Class frmMain2

    Private IsBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Botones'
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Dim resultado As Integer = MessageBox.Show("¿Desea salir del programa?", "Advertencia!", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Application.Exit()
        Else

        End If

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
    '----------'
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnRestaurar.Visible = False
        PanelLateral.Height = btnInicio.Height
        Timer1.Start()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PanelLateral.Height = btnInicio.Height
        PanelLateral.Top = btnInicio.Top
        FrmInicio1.BringToFront()
    End Sub

    Private Sub btnAgregarClientes_Click(sender As Object, e As EventArgs) Handles btnAgregarClientes.Click
        PanelLateral.Height = btnAgregarClientes.Height
        PanelLateral.Top = btnAgregarClientes.Top
        FrmAgregarClientes1.BringToFront()
    End Sub

    Private Sub btnAgregarDesarrollo_Click(sender As Object, e As EventArgs) Handles btnAgregarDesarrollo.Click
        PanelLateral.Height = btnAgregarDesarrollo.Height
        PanelLateral.Top = btnAgregarDesarrollo.Top
        FrmAgregarDesarrollo1.BringToFront()
    End Sub

    Private Sub btnVerClientes_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        PanelLateral.Height = btnVerClientes.Height
        PanelLateral.Top = btnVerClientes.Top
        FrmVerClientes1.BringToFront()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        PanelLateral.Height = btnConsultas.Height
        PanelLateral.Top = btnConsultas.Top
        FrmConsultaDias1.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now.ToLongTimeString
        Label2.Text = Now.ToLongDateString

    End Sub

    Private Sub PanelEncabezado_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEncabezado.MouseDown
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub PanelEncabezado_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelEncabezado.MouseUp
        If e.Button = MouseButtons.Left Then
            IsBeingDragged = False
        End If
    End Sub

    Private Sub PanelEncabezado_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelEncabezado.MouseMove
        If IsBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PanelEncabezado_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PanelEncabezado.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then

            btnMaximizar.Visible = False
            btnRestaurar.Visible = True
            Me.WindowState = FormWindowState.Maximized

        ElseIf Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal
            btnRestaurar.Visible = False
            btnMaximizar.Visible = True

        End If
    End Sub
End Class