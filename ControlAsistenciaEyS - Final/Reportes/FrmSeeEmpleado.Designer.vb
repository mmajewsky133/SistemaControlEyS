<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeEmpleado
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
        Me.EmpleadosTableAdapter = New ControlAsistenciaEyS___Final.ControlAsistenciaDataSetTableAdapters.EmpleadosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmpSelct = New System.Windows.Forms.TextBox()
        Me.BtnAddDep = New System.Windows.Forms.Button()
        Me.BtnAddCargos = New System.Windows.Forms.Button()
        Me.BtnAddRol = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdempDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoinstDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(733, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'IdempDataGridViewTextBoxColumn
        '
        Me.IdempDataGridViewTextBoxColumn.DataPropertyName = "id_emp"
        Me.IdempDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdempDataGridViewTextBoxColumn.Name = "IdempDataGridViewTextBoxColumn"
        Me.IdempDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdempDataGridViewTextBoxColumn.Width = 40
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorreoinstDataGridViewTextBoxColumn
        '
        Me.CorreoinstDataGridViewTextBoxColumn.DataPropertyName = "correo_inst"
        Me.CorreoinstDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoinstDataGridViewTextBoxColumn.Name = "CorreoinstDataGridViewTextBoxColumn"
        Me.CorreoinstDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoinstDataGridViewTextBoxColumn.Width = 250
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
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(79, 161)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(666, 30)
        Me.TxtBuscar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Empleado Seleccionado:"
        '
        'TxtEmpSelct
        '
        Me.TxtEmpSelct.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtEmpSelct.Location = New System.Drawing.Point(16, 106)
        Me.TxtEmpSelct.Name = "TxtEmpSelct"
        Me.TxtEmpSelct.ReadOnly = True
        Me.TxtEmpSelct.Size = New System.Drawing.Size(174, 30)
        Me.TxtEmpSelct.TabIndex = 9
        '
        'BtnAddDep
        '
        Me.BtnAddDep.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddDep.Location = New System.Drawing.Point(196, 106)
        Me.BtnAddDep.Name = "BtnAddDep"
        Me.BtnAddDep.Size = New System.Drawing.Size(189, 31)
        Me.BtnAddDep.TabIndex = 10
        Me.BtnAddDep.Text = "Asignar Departamento"
        Me.BtnAddDep.UseVisualStyleBackColor = True
        '
        'BtnAddCargos
        '
        Me.BtnAddCargos.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddCargos.Location = New System.Drawing.Point(571, 106)
        Me.BtnAddCargos.Name = "BtnAddCargos"
        Me.BtnAddCargos.Size = New System.Drawing.Size(174, 31)
        Me.BtnAddCargos.TabIndex = 11
        Me.BtnAddCargos.Text = "Asignar Cargos"
        Me.BtnAddCargos.UseVisualStyleBackColor = True
        '
        'BtnAddRol
        '
        Me.BtnAddRol.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddRol.Location = New System.Drawing.Point(391, 106)
        Me.BtnAddRol.Name = "BtnAddRol"
        Me.BtnAddRol.Size = New System.Drawing.Size(174, 31)
        Me.BtnAddRol.TabIndex = 12
        Me.BtnAddRol.Text = "Asignar Rol"
        Me.BtnAddRol.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Reporte y Manejo de Empleados"
        '
        'FrmSeeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 602)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAddRol)
        Me.Controls.Add(Me.BtnAddCargos)
        Me.Controls.Add(Me.BtnAddDep)
        Me.Controls.Add(Me.TxtEmpSelct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSeeEmpleado"
        Me.Text = "Control de Asistencias - Reporte de Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ControlAsistenciaDataSet As ControlAsistenciaDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ControlAsistenciaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents IdempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoinstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEmpSelct As TextBox
    Friend WithEvents BtnAddDep As Button
    Friend WithEvents BtnAddCargos As Button
    Friend WithEvents BtnAddRol As Button
    Friend WithEvents Label3 As Label
End Class
