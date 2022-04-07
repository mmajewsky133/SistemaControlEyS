<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcadoEmpE_S
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
        Me.BtnCerrarSesEmp = New System.Windows.Forms.Button()
        Me.LblTimeHour = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTimeMinute = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTimeSecond = New System.Windows.Forms.Label()
        Me.BtnMarcarEntrada = New System.Windows.Forms.Button()
        Me.BtnMarcar = New System.Windows.Forms.Button()
        Me.BtnMarcarSalida = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCerrarSesEmp
        '
        Me.BtnCerrarSesEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesEmp.Location = New System.Drawing.Point(12, 12)
        Me.BtnCerrarSesEmp.Name = "BtnCerrarSesEmp"
        Me.BtnCerrarSesEmp.Size = New System.Drawing.Size(98, 33)
        Me.BtnCerrarSesEmp.TabIndex = 0
        Me.BtnCerrarSesEmp.Text = "Salir"
        Me.BtnCerrarSesEmp.UseVisualStyleBackColor = True
        '
        'LblTimeHour
        '
        Me.LblTimeHour.AutoSize = True
        Me.LblTimeHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeHour.Location = New System.Drawing.Point(247, 14)
        Me.LblTimeHour.Name = "LblTimeHour"
        Me.LblTimeHour.Size = New System.Drawing.Size(52, 31)
        Me.LblTimeHour.TabIndex = 1
        Me.LblTimeHour.Text = "XX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'LblTimeMinute
        '
        Me.LblTimeMinute.AutoSize = True
        Me.LblTimeMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeMinute.Location = New System.Drawing.Point(316, 14)
        Me.LblTimeMinute.Name = "LblTimeMinute"
        Me.LblTimeMinute.Size = New System.Drawing.Size(52, 31)
        Me.LblTimeMinute.TabIndex = 3
        Me.LblTimeMinute.Text = "XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ":"
        '
        'LblTimeSecond
        '
        Me.LblTimeSecond.AutoSize = True
        Me.LblTimeSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeSecond.Location = New System.Drawing.Point(385, 14)
        Me.LblTimeSecond.Name = "LblTimeSecond"
        Me.LblTimeSecond.Size = New System.Drawing.Size(52, 31)
        Me.LblTimeSecond.TabIndex = 5
        Me.LblTimeSecond.Text = "XX"
        '
        'BtnMarcarEntrada
        '
        Me.BtnMarcarEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarcarEntrada.Location = New System.Drawing.Point(31, 94)
        Me.BtnMarcarEntrada.Name = "BtnMarcarEntrada"
        Me.BtnMarcarEntrada.Size = New System.Drawing.Size(167, 108)
        Me.BtnMarcarEntrada.TabIndex = 6
        Me.BtnMarcarEntrada.Text = "Entrada"
        Me.BtnMarcarEntrada.UseVisualStyleBackColor = True
        '
        'BtnMarcar
        '
        Me.BtnMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarcar.Location = New System.Drawing.Point(322, 250)
        Me.BtnMarcar.Name = "BtnMarcar"
        Me.BtnMarcar.Size = New System.Drawing.Size(98, 33)
        Me.BtnMarcar.TabIndex = 7
        Me.BtnMarcar.Text = "Marcar"
        Me.BtnMarcar.UseVisualStyleBackColor = True
        '
        'BtnMarcarSalida
        '
        Me.BtnMarcarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarcarSalida.Location = New System.Drawing.Point(253, 94)
        Me.BtnMarcarSalida.Name = "BtnMarcarSalida"
        Me.BtnMarcarSalida.Size = New System.Drawing.Size(167, 108)
        Me.BtnMarcarSalida.TabIndex = 8
        Me.BtnMarcarSalida.Text = "Salida"
        Me.BtnMarcarSalida.UseVisualStyleBackColor = True
        '
        'MarcadoEmpE_S
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 305)
        Me.Controls.Add(Me.BtnMarcarSalida)
        Me.Controls.Add(Me.BtnMarcar)
        Me.Controls.Add(Me.BtnMarcarEntrada)
        Me.Controls.Add(Me.LblTimeSecond)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTimeMinute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTimeHour)
        Me.Controls.Add(Me.BtnCerrarSesEmp)
        Me.Name = "MarcadoEmpE_S"
        Me.Text = "Marcado de Entrada / Salida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrarSesEmp As Button
    Friend WithEvents LblTimeHour As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTimeMinute As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTimeSecond As Label
    Friend WithEvents BtnMarcarEntrada As Button
    Friend WithEvents BtnMarcar As Button
    Friend WithEvents BtnMarcarSalida As Button
End Class
