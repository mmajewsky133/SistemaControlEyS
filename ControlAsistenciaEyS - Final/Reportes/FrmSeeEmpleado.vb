Public Class FrmSeeEmpleado
    Dim emp As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Dim tblEmp As New BDAsistenciasEySDataSet.empleadoDataTable

    Private Sub FrmSeeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)

    End Sub
    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub BtnSeeReport_Click(sender As Object, e As EventArgs) Handles BtnSeeReport.Click
        emp.Fill(tblEmp)
        VerReporte(tblEmp, "DsEmpleados", "C:\Reportes\RptEmpleados.rdlc")
    End Sub
End Class