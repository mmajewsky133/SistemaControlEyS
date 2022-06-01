Public Class FrmSeeEmpleado
    Dim emp As New BDAsistenciasEySDataSetTableAdapters.RptTremendoEmpTableAdapter
    Dim tblEmp As New BDAsistenciasEySDataSet.RptTremendoEmpDataTable

    'Dim IdSelected

    Private Sub FrmSeeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.RptTremendoEmp' table. You can move, or remove it, as needed.
        Me.RptTremendoEmpTableAdapter.Fill(Me.BDAsistenciasEySDataSet.RptTremendoEmp)
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        Me.TxtEmpSelct.Text = ""
        GBRptEmpleado.Text = "Empleados: " & DgvEmpleados.Rows.Count.ToString - 1

    End Sub
    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub BtnSeeReport_Click(sender As Object, e As EventArgs) Handles BtnSeeReport.Click
        emp.Fill(tblEmp)
        VerReporte(tblEmp, "DsEmpleado", "RptEmpleado.rdlc")
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            Dim dato As String = TxtBuscar.Text & "%"
            DgvEmpleados.DataSource = emp.BuscarNombre(dato)
            DgvEmpleados.Refresh()
            GBRptEmpleado.Text = "Empleados similares: " & DgvEmpleados.Rows.Count.ToString - 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim rowindex = DgvEmpleados.CurrentCell.RowIndex

        'IdSelected = CInt(DgvEmpleados.Rows(rowindex).Cells(0).Value.ToString())
        'Me.TxtEmpSelct.Text = IdSelected
        'TxtEmpSelct.Text = DgvEmpleados.Rows(rowindex).Cells(1).Value.ToString()
    End Sub

    Private Sub BtnAddCargos_Click(sender As Object, e As EventArgs) Handles BtnAddCargos.Click

        If Me.TxtEmpSelct Is "" Then
            MsgBox("No se ha seleccionado ningun empleado", MsgBoxStyle.Critical, "ERROR")
            'ElseIf
            'Mandar IdSelected a frmAddEmpCargo
        End If
    End Sub
End Class