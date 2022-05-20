Public Class FrmAddDepartamento

    Dim departamento As New BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Dim idDepartamento As Integer

    Sub llenarGrid()
        DgvDepartamento.DataSource = departamento.GetData
        DgvDepartamento.Refresh()
    End Sub
    Sub Mostrar()
        Me.Focus()
    End Sub
    Private Sub FrmAddDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.departamento)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim nombreDep As String = TxtDepartamento.Text
            Dim extTel As String = TxtExtension.Text
            Dim correo As String = TxtCorreo.Text
            Dim estado As Integer = 1
            'Posiblemente eliminemos estado de la BD'
            departamento.InsertarDepartamento(nombreDep, extTel, correo, estado)
            llenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este departamento?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                departamento.EliminarDepartamento(idDepartamento)
                llenarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvDepartamento_DoubleClick(sender As Object, e As EventArgs) Handles DgvDepartamento.DoubleClick
        Try
            Dim fila As Integer = DgvDepartamento.CurrentRow.Index

            idDepartamento = DgvDepartamento.Item(0, fila).Value
            TxtDepartamento.Text = DgvDepartamento.Item(1, fila).Value
            TxtExtension.Text = DgvDepartamento.Item(2, fila).Value
            TxtCorreo.Text = DgvDepartamento.Item(3, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TxtDepartamento.Text)) Then
            MsgBox("No puede quedar vacío el nombre del departamento", MsgBoxStyle.Critical, "ERROR")
            TxtDepartamento.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtExtension.Text)) Then
            MsgBox("Una extension requiere ser ingresada", MsgBoxStyle.Critical, "ERROR")
            TxtExtension.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtCorreo.Text)) Then
            MsgBox("El correo debe ser ingresado", MsgBoxStyle.Critical, "ERROR")
            TxtCorreo.Focus()
            Exit Sub
        End If

        Dim nombreDep As String = TxtDepartamento.Text.Trim
        Dim extension As String = TxtExtension.Text.Trim
        Dim correo As String = TxtCorreo.Text.Trim

        departamento.EditarDepartamento(nombreDep, extension, correo, idDepartamento)
        llenarGrid()

    End Sub
End Class