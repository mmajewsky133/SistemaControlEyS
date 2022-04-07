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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManejoDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FormulariosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeAsistenciaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FormulariosToolStripMenuItem
        '
        Me.FormulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManejoDeCargosToolStripMenuItem, Me.PerfilDeEmpleadosToolStripMenuItem})
        Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
        Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.FormulariosToolStripMenuItem.Text = "Formularios"
        '
        'ManejoDeCargosToolStripMenuItem
        '
        Me.ManejoDeCargosToolStripMenuItem.Name = "ManejoDeCargosToolStripMenuItem"
        Me.ManejoDeCargosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManejoDeCargosToolStripMenuItem.Text = "Manejo de Cargos"
        '
        'PerfilDeEmpleadosToolStripMenuItem
        '
        Me.PerfilDeEmpleadosToolStripMenuItem.Name = "PerfilDeEmpleadosToolStripMenuItem"
        Me.PerfilDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PerfilDeEmpleadosToolStripMenuItem.Text = "Perfil de Empleados"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ControlDeAsistenciaToolStripMenuItem
        '
        Me.ControlDeAsistenciaToolStripMenuItem.Name = "ControlDeAsistenciaToolStripMenuItem"
        Me.ControlDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ControlDeAsistenciaToolStripMenuItem.Text = "Control de Asistencia"
        '
        'FrmMainAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMainAdminMenu"
        Me.Text = "Control de Entrada y Salida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManejoDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeAsistenciaToolStripMenuItem As ToolStripMenuItem
End Class
