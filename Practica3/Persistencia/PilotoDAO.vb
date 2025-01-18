Public Class PilotoDAO

    Public ReadOnly Property Pilotos As Collection

    Public Sub New()
        Me.Pilotos = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim p As Piloto
        Dim pa As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM pilotos ORDER BY IdPiloto")
        For Each aux In col
            p = New Piloto(aux(1)) With {
                .NombrePiloto = aux(2).ToString,
                .ApellidoPiloto = aux(3).ToString
            }
            pa = New Pais(aux(4).ToString)
            Try
                pa.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            p.PaisPiloto = pa
            Me.Pilotos.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Piloto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM pilotos WHERE IdPais='" & p.IdPiloto & "';")
        For Each aux In col
            p.NombrePiloto = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO pilotos VALUES ('" & p.NombrePiloto & "', '" & p.ApellidoPiloto & "','" & p.PaisPiloto.IdPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE pilotos SET NombrePiloto='" & p.NombrePiloto & "', ApellidoPiloto='" & p.ApellidoPiloto & "' WHERE IdPiloto='" & p.IdPiloto & "';")
    End Function

    Public Function Borrar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM pilotos WHERE IdPiloto='" & p.IdPiloto & "';")
    End Function

End Class
