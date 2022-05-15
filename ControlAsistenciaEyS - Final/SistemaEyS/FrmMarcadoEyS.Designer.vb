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
        Me.BtnMarcarE = New System.Windows.Forms.Button()
        Me.BtnMarcarS = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblComMarcado = New System.Windows.Forms.Label()
        Me.LblWarningMarcar = New System.Windows.Forms.Label()
        Me.BtnMarcar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnMarcarE
        '
        Me.BtnMarcarE.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarE.Location = New System.Drawing.Point(157, 147)
        Me.BtnMarcarE.Name = "BtnMarcarE"
        Me.BtnMarcarE.Size = New System.Drawing.Size(201, 141)
        Me.BtnMarcarE.TabIndex = 11
        Me.BtnMarcarE.Text = "Marcar Entrada"
        Me.BtnMarcarE.UseVisualStyleBackColor = True
        '
        'BtnMarcarS
        '
        Me.BtnMarcarS.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcarS.Location = New System.Drawing.Point(457, 147)
        Me.BtnMarcarS.Name = "BtnMarcarS"
        Me.BtnMarcarS.Size = New System.Drawing.Size(201, 141)
        Me.BtnMarcarS.TabIndex = 12
        Me.BtnMarcarS.Text = "Marcar Salida"
        Me.BtnMarcarS.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAtras.Location = New System.Drawing.Point(12, 12)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(136, 28)
        Me.BtnAtras.TabIndex = 13
        Me.BtnAtras.Text = "Regresar"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Miriam CLM", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(747, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(41, 39)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "XX"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Miriam CLM", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(676, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(41, 39)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "XX"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Miriam CLM", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(605, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(41, 39)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam CLM", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(723, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam CLM", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(652, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = ":"
        '
        'LblComMarcado
        '
        Me.LblComMarcado.AutoSize = True
        Me.LblComMarcado.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblComMarcado.Location = New System.Drawing.Point(385, 64)
        Me.LblComMarcado.Name = "LblComMarcado"
        Me.LblComMarcado.Size = New System.Drawing.Size(48, 21)
        Me.LblComMarcado.TabIndex = 19
        Me.LblComMarcado.Text = "[ ... ]"
        '
        'LblWarningMarcar
        '
        Me.LblWarningMarcar.AutoSize = True
        Me.LblWarningMarcar.Font = New System.Drawing.Font("Miriam CLM", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblWarningMarcar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblWarningMarcar.Location = New System.Drawing.Point(397, 85)
        Me.LblWarningMarcar.Name = "LblWarningMarcar"
        Me.LblWarningMarcar.Size = New System.Drawing.Size(24, 17)
        Me.LblWarningMarcar.TabIndex = 20
        Me.LblWarningMarcar.Text = "[ ]"
        '
        'BtnMarcar
        '
        Me.BtnMarcar.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMarcar.Location = New System.Drawing.Point(657, 388)
        Me.BtnMarcar.Name = "BtnMarcar"
        Me.BtnMarcar.Size = New System.Drawing.Size(131, 50)
        Me.BtnMarcar.TabIndex = 21
        Me.BtnMarcar.Text = "Marcar"
        Me.BtnMarcar.UseVisualStyleBackColor = True
        '
        'FrmMarcadoEyS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnMarcar)
        Me.Controls.Add(Me.LblWarningMarcar)
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
    Friend WithEvents LblWarningMarcar As Label
    Friend WithEvents BtnMarcar As Button
End Class
