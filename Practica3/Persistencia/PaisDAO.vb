Public Class PaisDAO

    Public ReadOnly Property Paises As Collection
    Private pi As Piloto
    Private Gps As Gp
    Private es As Escuderia

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM paises ORDER BY IdPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.NombrePais = aux(2).ToString
            p.HabitantesPais = aux(3)
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM paises WHERE IdPais='" & p.IdPais & "';")
        For Each aux In col
            p.NombrePais = aux(2).ToString
            p.HabitantesPais = aux(3)
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO paises VALUES ('" & p.IdPais & "', '" & p.NombrePais & "', " & p.HabitantesPais & ");")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE paises SET NombrePais='" & p.NombrePais & "' WHERE IdPais='" & p.IdPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM paises WHERE IdPais='" & p.IdPais & "';")
    End Function

End Class
