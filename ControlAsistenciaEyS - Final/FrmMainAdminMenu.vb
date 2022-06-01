Public Class FrmMainAdminMenu

    Dim empleado As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter


    Private Sub FrmMainAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        'Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)
        GBControl.Text = "Empleados similares: " & DgvAsistencia.Rows.Count.ToString - 1


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        FrmAdminLogin.Show()
        FrmAdminLogin.TxtUsuarioAdmin.Focus()
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            Dim dato As String = TxtBuscar.Text & "%"
            DgvAsistencia.DataSource = empleado.BuscarNombre(dato)
            DgvAsistencia.Refresh()
            GBControl.Text = "Empleados similares: " & DgvAsistencia.Rows.Count.ToString - 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub ReporteDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEmpleadosToolStripMenuItem.Click
        If (Not FrmSeeEmpleado.Visible) Then
            FrmSeeEmpleado.Show()
        Else
            FrmSeeEmpleado.Mostrar()
        End If
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        If (Not FrmAddEmpleado.Visible) Then
            FrmAddEmpleado.Show()
        Else
            FrmAddEmpleado.Mostrar()
        End If
    End Sub

    Private Sub SistemaEySToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaEySToolStripMenuItem.Click
        FrmMarcadoEyS.Show()
    End Sub

    Private Sub ReporteDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeDepartamentosToolStripMenuItem.Click
        If (Not FrmSeeDepartamento.Visible) Then
            FrmSeeDepartamento.Show()
        Else
            FrmSeeDepartamento.Mostrar()
        End If
    End Sub

    Private Sub GestionDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeDepartamentosToolStripMenuItem.Click
        If (Not FrmAddDepartamento.Visible) Then
            FrmAddDepartamento.Show()
        Else
            FrmAddDepartamento.Mostrar()
        End If
    End Sub

    Private Sub ReporteDeCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCargosToolStripMenuItem.Click
        If (Not FrmSeeCargos.Visible) Then
            FrmSeeCargos.Show()
        Else
            FrmSeeCargos.Mostrar()
        End If
    End Sub

    Private Sub GestionDeCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeCargosToolStripMenuItem.Click
        If (Not FrmAddCargo.Visible) Then
            FrmAddCargo.Show()
        Else
            FrmAddCargo.Mostrar()
        End If
    End Sub

    Private Sub ManejoDeOpcionesAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManejoDeOpcionesAdminToolStripMenuItem.Click
        If (Not FrmOpciones.Visible) Then
            FrmOpciones.Show()
        Else
            FrmOpciones.Mostrar()
        End If
    End Sub
End Class