Public Class FrmAsignarCargo
    Dim cargoEmp As New BDAsistenciasEySDataSetTableAdapters.cargoEmpTableAdapter
    Dim emp As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Dim cargo As New BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Dim idCargoEmp As Integer
    Private Sub FrmAsignarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.cargo)
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.cargoEmp' table. You can move, or remove it, as needed.
        Me.CargoEmpTableAdapter.Fill(Me.BDAsistenciasEySDataSet.cargoEmp)
        llenarGrid()
        llenarCmbEmpleado()
        llenarCmbCargo()
    End Sub
    Sub llenarGrid()
        DgvCargoEmp.DataSource = cargoEmp.GetData
        DgvCargoEmp.Refresh()
    End Sub
    Sub llenarCmbEmpleado()
        CmbEmpleado.DataSource = emp.GetData
        CmbEmpleado.DisplayMember = "nombres"
        CmbEmpleado.ValueMember = "idEmp"
        CmbEmpleado.Refresh()
    End Sub

    Sub llenarCmbCargo()
        CmbCargo.DataSource = cargo.GetData
        CmbCargo.DisplayMember = "nombreCargo"
        CmbCargo.ValueMember = "idCargo"
        CmbCargo.Refresh()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim idEmpleado As Integer = CInt(CmbEmpleado.SelectedValue)
            Dim idCargo As Integer = CInt(CmbCargo.SelectedValue)

            cargoEmp.InsertarEmpleadoCargo(idEmpleado, idCargo)
            llenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvCargoEmp_DoubleClick(sender As Object, e As EventArgs) Handles DgvCargoEmp.DoubleClick
        Try
            Dim fila As Integer = DgvCargoEmp.CurrentRow.Index
            idCargoEmp = DgvCargoEmp.Item(0, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este cargo?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                cargoEmp.EliminarCargoEmp(idCargoEmp)
                llenarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class