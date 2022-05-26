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
        Me.RegistroAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RegistroAsistenciaTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMarcarE
        '
        Me.BtnMarcarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarE.Location = New System.Drawing.Point(157, 181)
        Me.BtnMarcarE.Name = "BtnMarcarE"
        Me.BtnMarcarE.Size = New System.Drawing.Size(201, 79)
        Me.BtnMarcarE.TabIndex = 11
        Me.BtnMarcarE.Text = "Marcar Entrada"
        Me.BtnMarcarE.UseVisualStyleBackColor = True
        '
        'BtnMarcarS
        '
        Me.BtnMarcarS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarS.Location = New System.Drawing.Point(460, 181)
        Me.BtnMarcarS.Name = "BtnMarcarS"
        Me.BtnMarcarS.Size = New System.Drawing.Size(201, 79)
        Me.BtnMarcarS.TabIndex = 12
        Me.BtnMarcarS.Text = "Marcar Salida"
        Me.BtnMarcarS.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAtras.Location = New System.Drawing.Point(655, 22)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(136, 28)
        Me.BtnAtras.TabIndex = 13
        Me.BtnAtras.Text = "Regresar"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(442, 545)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(41, 38)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "XX"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(370, 545)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(41, 38)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "XX"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(300, 545)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(41, 38)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 548)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 548)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = ":"
        '
        'LblComMarcado
        '
        Me.LblComMarcado.AutoSize = True
        Me.LblComMarcado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblComMarcado.Location = New System.Drawing.Point(303, 63)
        Me.LblComMarcado.Name = "LblComMarcado"
        Me.LblComMarcado.Size = New System.Drawing.Size(211, 24)
        Me.LblComMarcado.TabIndex = 19
        Me.LblComMarcado.Text = "[ Cedula del empleado ]"
        '
        'BtnMarcar
        '
        Me.BtnMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcar.Location = New System.Drawing.Point(340, 310)
        Me.BtnMarcar.Name = "BtnMarcar"
        Me.BtnMarcar.Size = New System.Drawing.Size(131, 50)
        Me.BtnMarcar.TabIndex = 21
        Me.BtnMarcar.Text = "Marcar"
        Me.BtnMarcar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(561, 148)
        Me.DataGridView1.TabIndex = 22
        '
        'RegistroAsistenciaBindingSource
        '
        Me.RegistroAsistenciaBindingSource.DataMember = "registroAsistencia"
        Me.RegistroAsistenciaBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 377)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(565, 165)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros de asistencia: "
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.5!)
        Me.TextBox4.Location = New System.Drawing.Point(237, 101)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(336, 29)
        Me.TextBox4.TabIndex = 24
        '
        'RegistroAsistenciaTableAdapter
        '
        Me.RegistroAsistenciaTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(20, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 29)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Marcado de asistencia"
        '
        'FrmMarcadoEyS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 622)
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
        Me.Name = "FrmMarcadoEyS"
        Me.Text = "Marcado de Entrada y Salida"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents Label3 As Label
End Class
