Public Class FrmSeeCargos
    Dim cargo As New BDAsistenciasEySDataSetTableAdapters.RptCargoTableAdapter
    Dim tblCargo As New BDAsistenciasEySDataSet.RptCargoDataTable

    Dim IdSelected

    Private Sub FrmSeeCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.RptCargo' table. You can move, or remove it, as needed.
        Me.RptCargoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.RptCargo)
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.cargo)
        GBRptCargo.Text = "Cargos: " & DgvCargos.Rows.Count.ToString

    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub BtnSeeReport_Click(sender As Object, e As EventArgs) Handles BtnSeeReport.Click
        cargo.Fill(tblCargo)
        VerReporte(tblCargo, "DsCargo", "RptCargo.rdlc")
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try
            Dim dato As String = TxtBuscar.Text & "%"
            DgvCargos.DataSource = cargo.BuscarNombre(dato)
            DgvCargos.Refresh()
            GBRptCargo.Text = "Cargos similares: " & DgvCargos.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    'Private Sub DgvCargos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCargos.CellClick
    '    Dim rowindex = DgvCargos.CurrentCell.RowIndex

    '    IdSelected = CInt(DgvCargos.Rows(rowindex).Cells(0).Value.ToString())
    '    Me.TxtCargSelct.Text = IdSelected
    'End Sub

    'Private Sub BtnAddDep_Click(sender As Object, e As EventArgs)
    '    If Me.TxtCargSelct Is "" Then
    '        MsgBox("No se ha seleccionado ningun cargo", MsgBoxStyle.Critical, "ERROR")
    '        'ElseIf
    '        'Mandar IdSelected a frmAddDepCargo
    '    End If
    'End Sub

    'Private Sub BtnAddRol_Click(sender As Object, e As EventArgs)
    '    If Me.TxtCargSelct Is "" Then
    '        MsgBox("No se ha seleccionado ningun cargo", MsgBoxStyle.Critical, "ERROR")
    '        'ElseIf
    '        'Mandar IdSelected a frmAddEmpCargo
    '    End If
    'End Sub
End Class