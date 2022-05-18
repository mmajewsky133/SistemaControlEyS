Imports System.Data.SqlClient


Public Class FrmAddEmpleado

    Dim empleado As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter

    Sub llenarGrid()
        DgvEmpleado.DataSource = empleado.GetData
        DgvEmpleado.Refresh()
    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        'Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)
        llenarGrid()

    End Sub

    Private Sub BtnGuardarEmp_Click(sender As Object, e As EventArgs) Handles BtnGuardarEmp.Click
        Try
            Dim nombres As String = TxtNombre.Text
            Dim apellidos As String = TxtApellido.Text
            Dim cedula As String = TxtCedula.Text
            Dim fotoEmp As String
            Dim fechaNac As String
            Dim direccion As String = TxtDireccion.Text
            Dim telefono As String = TxtTel.Text
            Dim correo As String = TxtCorreo.Text
            Dim correoInst As String = TxtCorreoInst.Text
            Dim username As String = nombres & Math.Ceiling(Rnd() * 20)
            Dim pwpin As String = "123"
            Dim estado As Integer = 1
            empleado.InsertarTemporal(nombres, apellidos, cedula, direccion, telefono, correo, correoInst, username, pwpin, estado)
            llenarGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnEliminarEmp_Click(sender As Object, e As EventArgs) Handles BtnEliminarEmp.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class