Imports System.Data.SqlClient
Imports System.IO

Public Class FrmAddEmpleado

    Dim empleado As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Dim idEmpleado As Integer
    Sub llenarGrid()
        DgvEmpleado.DataSource = empleado.GetData
        DgvEmpleado.Refresh()
    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        'Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)
        llenarGrid()

    End Sub

    Private Sub BtnGuardarEmp_Click(sender As Object, e As EventArgs) Handles BtnGuardarEmp.Click
        Try
            Dim nombres As String = TxtNombre.Text
            Dim apellidos As String = TxtApellido.Text
            Dim cedula As String = TxtCedula.Text
            Dim fotoEmp As New MemoryStream
            PBEmp.Image.Save(fotoEmp, format:=PBEmp.Image.RawFormat)
            Dim fechaNac As DateTime = DTPNac.Value
            Dim direccion As String = TxtDireccion.Text
            Dim telefono As String = TxtTel.Text
            Dim correo As String = TxtCorreo.Text
            Dim correoInst As String = TxtCorreoInst.Text
            Dim username As String = nombres.Replace(" ", "") & Math.Ceiling(Rnd() * 20)
            Dim pwpin As String = "123"
            Dim estado As Integer = 1
            empleado.InsertarEmpleado(nombres, apellidos, cedula, fotoEmp.ToArray(), fechaNac, direccion, telefono, correo, correoInst, username, pwpin, estado)
            llenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub BtnEliminarEmp_Click(sender As Object, e As EventArgs) Handles BtnEliminarEmp.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este empleado?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                empleado.EliminarEmpleado(idEmpleado)
                llenarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEditarEmp_Click(sender As Object, e As EventArgs) Handles BtnEditarEmp.Click
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            TxtNombre.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtApellido.Text)) Then
            MsgBox("Los apellidos requieren ser ingresados", MsgBoxStyle.Critical, "ERROR")
            TxtApellido.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtCedula.Text)) Then
            MsgBox("La cedula requiere ser ingresada", MsgBoxStyle.Critical, "ERROR")
            TxtCedula.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtCorreo.Text)) Then
            MsgBox("Correo vacio", MsgBoxStyle.Critical, "ERROR")
            TxtCorreo.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtTel.Text)) Then
            MsgBox("Telefono vacio", MsgBoxStyle.Critical, "ERROR")
            TxtTel.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtCorreoInst.Text)) Then
            MsgBox("Institucional vacio", MsgBoxStyle.Critical, "ERROR")
            TxtCorreoInst.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtDireccion.Text)) Then
            MsgBox("Direccion", MsgBoxStyle.Critical, "ERROR")
            TxtDireccion.Focus()
            Exit Sub
        End If

        Dim nombre As String = TxtNombre.Text.Trim
        Dim apellido As String = TxtApellido.Text.Trim
        Dim cedula As String = TxtCedula.Text.Trim
        Dim correo As String = TxtCorreo.Text.Trim
        Dim telefono As String = TxtTel.Text.Trim
        Dim correoInstitucional As String = TxtCorreoInst.Text.Trim
        Dim direccion As String = TxtDireccion.Text.Trim

        empleado.EditarEmpleado(nombre, apellido, cedula, direccion, telefono, correo, correoInstitucional, 2, idEmpleado)
        llenarGrid()

    End Sub

    Private Sub DgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleado.DoubleClick
        Try
            Dim fila As Integer = DgvEmpleado.CurrentRow.Index
            Dim imagen() As Byte

            idEmpleado = DgvEmpleado.Item(0, fila).Value
            TxtNombre.Text = DgvEmpleado.Item(1, fila).Value
            TxtApellido.Text = DgvEmpleado.Item(2, fila).Value
            TxtCedula.Text = DgvEmpleado.Item(3, fila).Value
            imagen = DgvEmpleado.Item(4, fila).Value
            Dim memoria As New MemoryStream(imagen)
            PBEmp.Image = Image.FromStream(memoria)
            DTPNac.Value = DgvEmpleado.Item(5, fila).Value
            TxtDireccion.Text = DgvEmpleado.Item(6, fila).Value
            TxtTel.Text = DgvEmpleado.Item(7, fila).Value
            TxtCorreo.Text = DgvEmpleado.Item(8, fila).Value
            TxtCorreoInst.Text = DgvEmpleado.Item(9, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub PBEmp_Click(sender As Object, e As EventArgs) Handles PBEmp.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            PBEmp.Image = Image.FromFile(op.FileName)
        End If
    End Sub

    Private Sub BtnNewEmp_Click(sender As Object, e As EventArgs) Handles BtnNewEmp.Click

        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCedula.Text = ""
        TxtCorreo.Text = ""
        TxtTel.Text = ""
        TxtCorreoInst.Text = ""
        TxtDireccion.Text = ""
        PBEmp.Image = Nothing
        DTPNac.ResetText()

        Me.Mostrar()
    End Sub

    Private Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click
        FrmAsignarCargo.Show()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

    End Sub
End Class