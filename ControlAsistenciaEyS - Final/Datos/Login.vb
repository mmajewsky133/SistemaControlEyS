Public Class Login

    Function VerificarCreds(ByVal user As String, ByVal pw As String) As Boolean

        Dim admin As New ControlAsistenciaDataSetTableAdapters.AdminTableAdapter

        Dim creds() As String = {user, pw}

        For Each lista As DataRow In admin.ObtenerAdminCreds.Rows

            If lista.ItemArray Is creds Then
                Return True
            End If

        Next

        Return False

    End Function

End Class
