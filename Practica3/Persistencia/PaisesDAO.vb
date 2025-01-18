Public Class PaisesDAO

    Public ReadOnly Property Paises As Collection
    Private pi As Pilotos
    Private Gps As GPs
    Private es As Escuderias

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim p As Paises
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY IdPais")
        For Each aux In col
            p = New Paises(aux(1).ToString)
            p.NombrePais = aux(2).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Paises)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE IdPais='" & p.IdPais & "';")
        For Each aux In col
            p.NombrePais = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Paises VALUES ('" & p.IdPais & "', '" & p.NombrePais & "');")
    End Function

    Public Function Actualizar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Paises SET NombrePais='" & p.NombrePais & "' WHERE IdPais='" & p.IdPais & "';")
    End Function

    Public Function Borrar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Pasises WHERE IdPais='" & p.IdPais & "';")
    End Function

End Class
