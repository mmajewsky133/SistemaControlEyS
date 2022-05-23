Public Class FrmAddCargo
    Dim cargo As New BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Dim departamento As New BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Dim idCargo As Integer
    Sub llenarGrid()
        DgvCargo.DataSource = cargo.GetData
        DgvCargo.Refresh()
        GBCargo.Text = "Cargos registrados: " + DgvCargo.Rows.Count.ToString
    End Sub
    Sub llenarCmbDepartamento()
        CmbDepartamento.DataSource = departamento.GetData
        CmbDepartamento.DisplayMember = "nombreDep"
        CmbDepartamento.ValueMember = "idDep"
        CmbDepartamento.Refresh()
    End Sub
    Sub Mostrar()
        Me.Focus()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim nombreCargo As String = TxtCargo.Text
            Dim descripcion As String = TxtDescripcion.Text
            Dim idDepartamento As Integer = CInt(CmbDepartamento.SelectedValue)

            cargo.InsertarCargo(nombreCargo, descripcion, idDepartamento, 1)
            llenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TxtCargo.Text)) Then
            MsgBox("No puede quedar vacío el nombre del cargo", MsgBoxStyle.Critical, "ERROR")
            TxtCargo.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtDescripcion.Text)) Then
            MsgBox("La descripcion debe ser ingresada", MsgBoxStyle.Critical, "ERROR")
            TxtDescripcion.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(CmbDepartamento.ValueMember)) Then
            MsgBox("Ingrese el id del departamento", MsgBoxStyle.Critical, "ERROR")
            'TxtIdDep.Focus()'
            Exit Sub
        End If

        Dim nombreCargo As String = TxtCargo.Text.Trim
        Dim descripcion As String = TxtDescripcion.Text.Trim
        'Dim idDepartamento As Integer = CInt(TxtIdDep.Text.Trim)'

        cargo.ActualizarCargo(nombreCargo, descripcion, 2, idCargo)

        llenarGrid()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este cargo?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                cargo.EliminarCargo(idCargo)
                llenarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvCargo_DoubleClick(sender As Object, e As EventArgs) Handles DgvCargo.DoubleClick
        Try
            Dim fila As Integer = DgvCargo.CurrentRow.Index

            idCargo = DgvCargo.Item(0, fila).Value
            TxtCargo.Text = DgvCargo.Item(1, fila).Value
            TxtDescripcion.Text = DgvCargo.Item(2, fila).Value
            'TxtIdDep.Text = DgvCargo.Item(3, fila).Value'

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub FrmAddCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.cargo)
        llenarGrid()
        llenarCmbDepartamento()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtCargo.Text = ""
        TxtDescripcion.Text = ""
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

    End Sub
End Class