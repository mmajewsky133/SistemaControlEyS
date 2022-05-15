Public Class FrmAddEmpleado

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)

    End Sub


End Class