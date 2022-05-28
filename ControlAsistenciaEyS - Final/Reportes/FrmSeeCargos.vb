﻿Public Class FrmSeeCargos
    Dim cargo As New BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Dim tblCargo As New BDAsistenciasEySDataSet.cargoDataTable

    Dim IdSelected

    Private Sub FrmSeeCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.cargo)

    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub BtnSeeReport_Click(sender As Object, e As EventArgs) Handles BtnSeeReport.Click
        cargo.Fill(tblCargo)
        VerReporte(tblCargo, "DsCargos", "RptCargos.rdlc")
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvCargos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCargos.CellClick
        Dim rowindex = DgvCargos.CurrentCell.RowIndex

        IdSelected = CInt(DgvCargos.Rows(rowindex).Cells(0).Value.ToString())
        Me.TxtCargSelct.Text = IdSelected
    End Sub

    Private Sub BtnAddDep_Click(sender As Object, e As EventArgs) Handles BtnAddDep.Click
        If Me.TxtCargSelct Is "" Then
            MsgBox("No se ha seleccionado ningun cargo", MsgBoxStyle.Critical, "ERROR")
            'ElseIf
            'Mandar IdSelected a frmAddDepCargo
        End If
    End Sub

    Private Sub BtnAddRol_Click(sender As Object, e As EventArgs) Handles BtnAddRol.Click
        If Me.TxtCargSelct Is "" Then
            MsgBox("No se ha seleccionado ningun cargo", MsgBoxStyle.Critical, "ERROR")
            'ElseIf
            'Mandar IdSelected a frmAddEmpCargo
        End If
    End Sub
End Class