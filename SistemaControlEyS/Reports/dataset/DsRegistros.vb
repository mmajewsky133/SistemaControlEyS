Partial Class DsRegistros
    Partial Public Class DepartamentoDataTable
        Private Sub DepartamentoDataTable_DepartamentoRowChanging(sender As Object, e As DepartamentoRowChangeEvent) Handles Me.DepartamentoRowChanging

        End Sub

    End Class

    Partial Public Class DtEmpleadoDataTable
        Private Sub DtEmpleadoDataTable_DtEmpleadoRowChanging(sender As Object, e As DtEmpleadoRowChangeEvent) Handles Me.DtEmpleadoRowChanging

        End Sub

        Private Sub DtEmpleadoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cedulaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
