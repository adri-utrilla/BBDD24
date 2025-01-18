Public Class GpDAO
    Public ReadOnly Property Gps As Collection
    Public Sub New()
        Me.Gps = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim Gp As Gp
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM gps ORDER BY IdGP")
        For Each aux In col
            Gp = New Gp(aux(1)) With {
                .DenominacionGP = aux(2).ToString
            }
            p = New Pais(aux(3).ToString)
            Try
                p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Gp.PaisGP = p
            Me.Gps.Add(Gp)
        Next
    End Sub

    Public Sub Leer(ByRef gp As Gp)
        Dim p As Pais
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM gps WHERE IdGP='" & gp.IdGP & "';")
        For Each aux In col
            gp.DenominacionGP = aux(2).ToString
            p = New Pais(aux(3).ToString)
            Try
                p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            gp.PaisGP = p
        Next
    End Sub

    Public Function Insertar(ByVal gp As Gp) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO gps VALUES ('" & gp.IdGP & "', '" & gp.DenominacionGP & "','" & gp.PaisGP.IdPais & "');")
    End Function

    Public Function Actualizar(ByVal gp As Gp) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE gps SET DenominacionGP='" & gp.DenominacionGP & "' WHERE IdGP='" & gp.IdGP & "', País='" & gp.PaisGP.IdPais & "'';")
    End Function

    Public Function Borrar(ByVal gp As Gp) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM gps WHERE IdGP='" & gp.IdGP & "';")
    End Function
End Class
