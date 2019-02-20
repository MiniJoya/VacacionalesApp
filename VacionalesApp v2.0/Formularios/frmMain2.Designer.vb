<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain2))
        Me.PanelEncabezado = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnAgregarDesarrollo = New System.Windows.Forms.Button()
        Me.btnAgregarClientes = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.FrmInicio1 = New VacionalesApp_v2._0.frmInicio()
        Me.FrmAgregarDesarrollo1 = New VacionalesApp_v2._0.frmAgregarDesarrollo()
        Me.FrmVerClientes1 = New VacionalesApp_v2._0.frmVerClientes()
        Me.FrmConsultaDias1 = New VacionalesApp_v2._0.frmConsultaDias()
        Me.FrmAgregarClientes1 = New VacionalesApp_v2._0.frmAgregarClientes()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEncabezado.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEncabezado
        '
        Me.PanelEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelEncabezado.Controls.Add(Me.Label3)
        Me.PanelEncabezado.Controls.Add(Me.btnRestaurar)
        Me.PanelEncabezado.Controls.Add(Me.btnCerrar)
        Me.PanelEncabezado.Controls.Add(Me.btnMinimizar)
        Me.PanelEncabezado.Controls.Add(Me.btnMaximizar)
        Me.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.PanelEncabezado.Name = "PanelEncabezado"
        Me.PanelEncabezado.Size = New System.Drawing.Size(1184, 30)
        Me.PanelEncabezado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VMnet"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.ForeColor = System.Drawing.Color.White
        Me.btnRestaurar.Image = Global.VacionalesApp_v2._0.My.Resources.Resources.minimizar
        Me.btnRestaurar.Location = New System.Drawing.Point(1106, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 30)
        Me.btnRestaurar.TabIndex = 4
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.VacionalesApp_v2._0.My.Resources.Resources.cancelar
        Me.btnCerrar.Location = New System.Drawing.Point(1144, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 30)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = Global.VacionalesApp_v2._0.My.Resources.Resources.signo_menos
        Me.btnMinimizar.Location = New System.Drawing.Point(1068, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 30)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.ForeColor = System.Drawing.Color.White
        Me.btnMaximizar.Image = Global.VacionalesApp_v2._0.My.Resources.Resources.maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1106, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 30)
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PanelLateral)
        Me.Panel2.Controls.Add(Me.btnConsultas)
        Me.Panel2.Controls.Add(Me.btnVerClientes)
        Me.Panel2.Controls.Add(Me.btnAgregarDesarrollo)
        Me.Panel2.Controls.Add(Me.btnAgregarClientes)
        Me.Panel2.Controls.Add(Me.btnInicio)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 581)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 529)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelLateral.Location = New System.Drawing.Point(0, 44)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(10, 55)
        Me.PanelLateral.TabIndex = 2
        '
        'btnConsultas
        '
        Me.btnConsultas.FlatAppearance.BorderSize = 0
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.White
        Me.btnConsultas.Location = New System.Drawing.Point(12, 279)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(151, 52)
        Me.btnConsultas.TabIndex = 10
        Me.btnConsultas.Text = "Realizar Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnVerClientes
        '
        Me.btnVerClientes.FlatAppearance.BorderSize = 0
        Me.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerClientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.ForeColor = System.Drawing.Color.White
        Me.btnVerClientes.Location = New System.Drawing.Point(12, 221)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(151, 52)
        Me.btnVerClientes.TabIndex = 9
        Me.btnVerClientes.Text = "Ver Clientes"
        Me.btnVerClientes.UseVisualStyleBackColor = True
        '
        'btnAgregarDesarrollo
        '
        Me.btnAgregarDesarrollo.FlatAppearance.BorderSize = 0
        Me.btnAgregarDesarrollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDesarrollo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDesarrollo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarDesarrollo.Location = New System.Drawing.Point(12, 163)
        Me.btnAgregarDesarrollo.Name = "btnAgregarDesarrollo"
        Me.btnAgregarDesarrollo.Size = New System.Drawing.Size(151, 52)
        Me.btnAgregarDesarrollo.TabIndex = 7
        Me.btnAgregarDesarrollo.Text = "Agregar Desarrollo"
        Me.btnAgregarDesarrollo.UseVisualStyleBackColor = True
        '
        'btnAgregarClientes
        '
        Me.btnAgregarClientes.FlatAppearance.BorderSize = 0
        Me.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarClientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarClientes.ForeColor = System.Drawing.Color.White
        Me.btnAgregarClientes.Location = New System.Drawing.Point(12, 105)
        Me.btnAgregarClientes.Name = "btnAgregarClientes"
        Me.btnAgregarClientes.Size = New System.Drawing.Size(151, 52)
        Me.btnAgregarClientes.TabIndex = 6
        Me.btnAgregarClientes.Text = "Agregar Clientes"
        Me.btnAgregarClientes.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Location = New System.Drawing.Point(12, 47)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(151, 52)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'FrmInicio1
        '
        Me.FrmInicio1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmInicio1.BackColor = System.Drawing.Color.White
        Me.FrmInicio1.Location = New System.Drawing.Point(163, 30)
        Me.FrmInicio1.Name = "FrmInicio1"
        Me.FrmInicio1.Size = New System.Drawing.Size(1021, 581)
        Me.FrmInicio1.TabIndex = 7
        '
        'FrmAgregarDesarrollo1
        '
        Me.FrmAgregarDesarrollo1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmAgregarDesarrollo1.Location = New System.Drawing.Point(163, 30)
        Me.FrmAgregarDesarrollo1.Name = "FrmAgregarDesarrollo1"
        Me.FrmAgregarDesarrollo1.Size = New System.Drawing.Size(1021, 581)
        Me.FrmAgregarDesarrollo1.TabIndex = 6
        '
        'FrmVerClientes1
        '
        Me.FrmVerClientes1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmVerClientes1.Location = New System.Drawing.Point(163, 30)
        Me.FrmVerClientes1.Name = "FrmVerClientes1"
        Me.FrmVerClientes1.Size = New System.Drawing.Size(1021, 581)
        Me.FrmVerClientes1.TabIndex = 5
        '
        'FrmConsultaDias1
        '
        Me.FrmConsultaDias1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmConsultaDias1.Location = New System.Drawing.Point(163, 30)
        Me.FrmConsultaDias1.Name = "FrmConsultaDias1"
        Me.FrmConsultaDias1.Size = New System.Drawing.Size(1021, 581)
        Me.FrmConsultaDias1.TabIndex = 4
        '
        'FrmAgregarClientes1
        '
        Me.FrmAgregarClientes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmAgregarClientes1.Location = New System.Drawing.Point(163, 30)
        Me.FrmAgregarClientes1.Name = "FrmAgregarClientes1"
        Me.FrmAgregarClientes1.Size = New System.Drawing.Size(1021, 581)
        Me.FrmAgregarClientes1.TabIndex = 3
        '
        'Timer1
        '
        '
        'frmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.FrmInicio1)
        Me.Controls.Add(Me.FrmAgregarDesarrollo1)
        Me.Controls.Add(Me.FrmVerClientes1)
        Me.Controls.Add(Me.FrmConsultaDias1)
        Me.Controls.Add(Me.FrmAgregarClientes1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain2"
        Me.PanelEncabezado.ResumeLayout(False)
        Me.PanelEncabezado.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEncabezado As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents btnAgregarDesarrollo As Button
    Friend WithEvents btnAgregarClientes As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents FrmAgregarClientes1 As frmAgregarClientes
    Friend WithEvents FrmConsultaDias1 As frmConsultaDias
    Friend WithEvents FrmVerClientes1 As frmVerClientes
    Friend WithEvents FrmAgregarDesarrollo1 As frmAgregarDesarrollo
    Friend WithEvents FrmInicio1 As frmInicio
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
