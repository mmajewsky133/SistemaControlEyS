<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcadoEyS
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
        Me.BtnMarcarE = New System.Windows.Forms.Button()
        Me.BtnMarcarS = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblComMarcado = New System.Windows.Forms.Label()
        Me.BtnMarcar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.RegistroAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroAsistenciaTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter()
        Me.IdRegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrabajadasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustMotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMarcarE
        '
        Me.BtnMarcarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarE.Location = New System.Drawing.Point(209, 223)
        Me.BtnMarcarE.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMarcarE.Name = "BtnMarcarE"
        Me.BtnMarcarE.Size = New System.Drawing.Size(268, 97)
        Me.BtnMarcarE.TabIndex = 11
        Me.BtnMarcarE.Text = "Marcar Entrada"
        Me.BtnMarcarE.UseVisualStyleBackColor = True
        '
        'BtnMarcarS
        '
        Me.BtnMarcarS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarS.Location = New System.Drawing.Point(614, 223)
        Me.BtnMarcarS.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMarcarS.Name = "BtnMarcarS"
        Me.BtnMarcarS.Size = New System.Drawing.Size(268, 97)
        Me.BtnMarcarS.TabIndex = 12
        Me.BtnMarcarS.Text = "Marcar Salida"
        Me.BtnMarcarS.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAtras.Location = New System.Drawing.Point(873, 27)
        Me.BtnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(181, 34)
        Me.BtnAtras.TabIndex = 13
        Me.BtnAtras.Text = "Regresar"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(589, 671)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 46)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "XX"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(494, 671)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(53, 46)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "XX"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(400, 671)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(53, 46)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(557, 674)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 39)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(462, 674)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 39)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = ":"
        '
        'LblComMarcado
        '
        Me.LblComMarcado.AutoSize = True
        Me.LblComMarcado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblComMarcado.Location = New System.Drawing.Point(404, 78)
        Me.LblComMarcado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblComMarcado.Name = "LblComMarcado"
        Me.LblComMarcado.Size = New System.Drawing.Size(271, 29)
        Me.LblComMarcado.TabIndex = 19
        Me.LblComMarcado.Text = "[ Cedula del empleado ]"
        '
        'BtnMarcar
        '
        Me.BtnMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcar.Location = New System.Drawing.Point(454, 382)
        Me.BtnMarcar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMarcar.Name = "BtnMarcar"
        Me.BtnMarcar.Size = New System.Drawing.Size(175, 62)
        Me.BtnMarcar.TabIndex = 21
        Me.BtnMarcar.Text = "Marcar"
        Me.BtnMarcar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRegDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraEntradaDataGridViewTextBoxColumn, Me.HoraSalidaDataGridViewTextBoxColumn, Me.HorasTrabajadasDataGridViewTextBoxColumn, Me.HorasExtraDataGridViewTextBoxColumn, Me.JustMotivoDataGridViewTextBoxColumn, Me.JustDescDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.IdEmpDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistroAsistenciaBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(747, 182)
        Me.DataGridView1.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 203)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros de asistencia: "
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.5!)
        Me.TextBox4.Location = New System.Drawing.Point(316, 124)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(446, 35)
        Me.TextBox4.TabIndex = 24
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroAsistenciaBindingSource
        '
        Me.RegistroAsistenciaBindingSource.DataMember = "registroAsistencia"
        Me.RegistroAsistenciaBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'RegistroAsistenciaTableAdapter
        '
        Me.RegistroAsistenciaTableAdapter.ClearBeforeFill = True
        '
        'IdRegDataGridViewTextBoxColumn
        '
        Me.IdRegDataGridViewTextBoxColumn.DataPropertyName = "idReg"
        Me.IdRegDataGridViewTextBoxColumn.HeaderText = "idReg"
        Me.IdRegDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdRegDataGridViewTextBoxColumn.Name = "IdRegDataGridViewTextBoxColumn"
        Me.IdRegDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRegDataGridViewTextBoxColumn.Visible = False
        Me.IdRegDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 125
        '
        'HoraEntradaDataGridViewTextBoxColumn
        '
        Me.HoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.HeaderText = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraEntradaDataGridViewTextBoxColumn.Name = "HoraEntradaDataGridViewTextBoxColumn"
        Me.HoraEntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraEntradaDataGridViewTextBoxColumn.Width = 125
        '
        'HoraSalidaDataGridViewTextBoxColumn
        '
        Me.HoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.HeaderText = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraSalidaDataGridViewTextBoxColumn.Name = "HoraSalidaDataGridViewTextBoxColumn"
        Me.HoraSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'HorasTrabajadasDataGridViewTextBoxColumn
        '
        Me.HorasTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "horasTrabajadas"
        Me.HorasTrabajadasDataGridViewTextBoxColumn.HeaderText = "horasTrabajadas"
        Me.HorasTrabajadasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HorasTrabajadasDataGridViewTextBoxColumn.Name = "HorasTrabajadasDataGridViewTextBoxColumn"
        Me.HorasTrabajadasDataGridViewTextBoxColumn.ReadOnly = True
        Me.HorasTrabajadasDataGridViewTextBoxColumn.Width = 125
        '
        'HorasExtraDataGridViewTextBoxColumn
        '
        Me.HorasExtraDataGridViewTextBoxColumn.DataPropertyName = "horasExtra"
        Me.HorasExtraDataGridViewTextBoxColumn.HeaderText = "horasExtra"
        Me.HorasExtraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HorasExtraDataGridViewTextBoxColumn.Name = "HorasExtraDataGridViewTextBoxColumn"
        Me.HorasExtraDataGridViewTextBoxColumn.ReadOnly = True
        Me.HorasExtraDataGridViewTextBoxColumn.Width = 125
        '
        'JustMotivoDataGridViewTextBoxColumn
        '
        Me.JustMotivoDataGridViewTextBoxColumn.DataPropertyName = "justMotivo"
        Me.JustMotivoDataGridViewTextBoxColumn.HeaderText = "justMotivo"
        Me.JustMotivoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JustMotivoDataGridViewTextBoxColumn.Name = "JustMotivoDataGridViewTextBoxColumn"
        Me.JustMotivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.JustMotivoDataGridViewTextBoxColumn.Visible = False
        Me.JustMotivoDataGridViewTextBoxColumn.Width = 125
        '
        'JustDescDataGridViewTextBoxColumn
        '
        Me.JustDescDataGridViewTextBoxColumn.DataPropertyName = "justDesc"
        Me.JustDescDataGridViewTextBoxColumn.HeaderText = "justDesc"
        Me.JustDescDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JustDescDataGridViewTextBoxColumn.Name = "JustDescDataGridViewTextBoxColumn"
        Me.JustDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.JustDescDataGridViewTextBoxColumn.Visible = False
        Me.JustDescDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn.Visible = False
        Me.IdEmpDataGridViewTextBoxColumn.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(26, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 35)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Marcado de asistencia"
        '
        'FrmMarcadoEyS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 766)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnMarcar)
        Me.Controls.Add(Me.LblComMarcado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnMarcarS)
        Me.Controls.Add(Me.BtnMarcarE)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMarcadoEyS"
        Me.Text = "Marcado de Entrada y Salida"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMarcarE As Button
    Friend WithEvents BtnMarcarS As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblComMarcado As Label
    Friend WithEvents BtnMarcar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents RegistroAsistenciaBindingSource As BindingSource
    Friend WithEvents RegistroAsistenciaTableAdapter As BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter
    Friend WithEvents IdRegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasTrabajadasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasExtraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustMotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
