Public Class FrmAddEmpleado

    Dim emp As New ControlAsistenciaDataSetTableAdapters.EmpleadosTableAdapter
    Dim dep As New ControlAsistenciaDataSetTableAdapters.DepartamentoTableAdapter

    Private Sub FrmAddEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbxDep.DataSource = dep.ObtenerDepartamentos
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)
    End Sub

    Private Sub BtnNewEmp_Click(sender As Object, e As EventArgs) Handles BtnNewEmp.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardarEmp_Click(sender As Object, e As EventArgs) Handles BtnGuardarEmp.Click
        Dim Nombre As String = TxtNombre.Text
        Dim Apellido As String = TxtApellido.Text
        Dim Cedula As String = TxtCedula.Text
        Dim Cel As String = TxtTel.Text
        Dim Correo As String = TxtCorreo.Text
        Dim CorreoInst As String = TxtCorreoInst.Text
        Dim Dir As String = TxtDireccion.Text
        Dim DepSelected As Integer = CmbxDep.SelectedIndex

        emp.InsertarEmpleado(Cedula, Nombre, Apellido, Date.Now.Date, Dir, Cel, Correo, CorreoInst, DepSelected, 1, 1)

    End Sub

    Private Sub BtnEditarEmp_Click(sender As Object, e As EventArgs) Handles BtnEditarEmp.Click

    End Sub

    Private Sub BtnEliminarEmp_Click(sender As Object, e As EventArgs) Handles BtnEliminarEmp.Click

    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCedula.Text = ""
        TxtCorreo.Text = ""
        TxtCorreoInst.Text = ""
        TxtDireccion.Text = ""
        CmbxDep.Text = ""
        PBEmp.Refresh()
    End Sub
End Class