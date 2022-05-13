<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainAdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoinstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlAsistenciaDataSet = New ControlAsistenciaEyS___Final.ControlAsistenciaDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManejoDeOpcionesAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaEySToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EmpleadosTableAdapter = New ControlAsistenciaEyS___Final.ControlAsistenciaDataSetTableAdapters.EmpleadosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdempDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoinstDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'IdempDataGridViewTextBoxColumn
        '
        Me.IdempDataGridViewTextBoxColumn.DataPropertyName = "id_emp"
        Me.IdempDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdempDataGridViewTextBoxColumn.Name = "IdempDataGridViewTextBoxColumn"
        Me.IdempDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdempDataGridViewTextBoxColumn.Width = 50
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CorreoinstDataGridViewTextBoxColumn
        '
        Me.CorreoinstDataGridViewTextBoxColumn.DataPropertyName = "correo_inst"
        Me.CorreoinstDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoinstDataGridViewTextBoxColumn.Name = "CorreoinstDataGridViewTextBoxColumn"
        Me.CorreoinstDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoinstDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ControlAsistenciaDataSet
        '
        'ControlAsistenciaDataSet
        '
        Me.ControlAsistenciaDataSet.DataSetName = "ControlAsistenciaDataSet"
        Me.ControlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.GestionToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeEmpleadosToolStripMenuItem, Me.ReporteDeCargosToolStripMenuItem, Me.ReporteDeDepartamentosToolStripMenuItem, Me.ReporteDeRolesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'ReporteDeCargosToolStripMenuItem
        '
        Me.ReporteDeCargosToolStripMenuItem.Name = "ReporteDeCargosToolStripMenuItem"
        Me.ReporteDeCargosToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReporteDeCargosToolStripMenuItem.Text = "Reporte de Cargos"
        '
        'ReporteDeDepartamentosToolStripMenuItem
        '
        Me.ReporteDeDepartamentosToolStripMenuItem.Name = "ReporteDeDepartamentosToolStripMenuItem"
        Me.ReporteDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReporteDeDepartamentosToolStripMenuItem.Text = "Reporte de Departamentos"
        '
        'ReporteDeRolesToolStripMenuItem
        '
        Me.ReporteDeRolesToolStripMenuItem.Name = "ReporteDeRolesToolStripMenuItem"
        Me.ReporteDeRolesToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReporteDeRolesToolStripMenuItem.Text = "Reporte de Roles"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeCargosToolStripMenuItem, Me.GestionDeDepartamentosToolStripMenuItem, Me.GestionDeRolesToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados"
        '
        'GestionDeCargosToolStripMenuItem
        '
        Me.GestionDeCargosToolStripMenuItem.Name = "GestionDeCargosToolStripMenuItem"
        Me.GestionDeCargosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeCargosToolStripMenuItem.Text = "Gestion de Cargos"
        '
        'GestionDeDepartamentosToolStripMenuItem
        '
        Me.GestionDeDepartamentosToolStripMenuItem.Name = "GestionDeDepartamentosToolStripMenuItem"
        Me.GestionDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeDepartamentosToolStripMenuItem.Text = "Gestion de Departamentos"
        '
        'GestionDeRolesToolStripMenuItem
        '
        Me.GestionDeRolesToolStripMenuItem.Name = "GestionDeRolesToolStripMenuItem"
        Me.GestionDeRolesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeRolesToolStripMenuItem.Text = "Gestion de Roles"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManejoDeOpcionesAdminToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ManejoDeOpcionesAdminToolStripMenuItem
        '
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Name = "ManejoDeOpcionesAdminToolStripMenuItem"
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Text = "Manejo de Opciones (Admin)"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaEySToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'SistemaEySToolStripMenuItem
        '
        Me.SistemaEySToolStripMenuItem.Name = "SistemaEySToolStripMenuItem"
        Me.SistemaEySToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SistemaEySToolStripMenuItem.Text = "Sistema EyS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Acceso Rapido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(79, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(577, 30)
        Me.TextBox1.TabIndex = 6
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'FrmMainAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 551)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMainAdminMenu"
        Me.Text = "Control de Asistencias - Panel de Control"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ControlAsistenciaDataSet As ControlAsistenciaDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ControlAsistenciaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaEySToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoinstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManejoDeOpcionesAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeRolesToolStripMenuItem As ToolStripMenuItem
End Class
