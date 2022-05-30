Public Class FrmSeeDepartamento
    Dim dep As New BDAsistenciasEySDataSetTableAdapters.RptDepartamentoTableAdapter
    Dim tblDep As New BDAsistenciasEySDataSet.RptDepartamentoDataTable

    Dim IdSelected

    Private Sub FrmSeeDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.departamento)
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Departamento' table. You can move, or remove it, as needed.
    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub BtnSeeReport_Click(sender As Object, e As EventArgs) Handles BtnSeeReport.Click
        dep.Fill(tblDep)
        VerReporte(tblDep, "DsDepartamento", "RptDepartamento.rdlc")
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDepartamentos.CellClick
        Dim rowindex = DgvDepartamentos.CurrentCell.RowIndex

        IdSelected = CInt(DgvDepartamentos.Rows(rowindex).Cells(0).Value.ToString())
        Me.TxtDepSelct.Text = IdSelected
    End Sub

    Private Sub BtnAddDep_Click(sender As Object, e As EventArgs) Handles BtnAddDep.Click
        If Me.TxtDepSelct Is "" Then
            MsgBox("No se ha seleccionado ningun cargo", MsgBoxStyle.Critical, "ERROR")
            'ElseIf
            'Mandar IdSelected a frmAddDepCargo
        End If
    End Sub
End Class