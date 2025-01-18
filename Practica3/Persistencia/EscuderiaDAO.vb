Public Class EscuderiaDAO
    Public ReadOnly Property Escuderias As Collection
    Private pa As Pais

    Public Sub New()
        Me.Escuderias = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim es As Escuderia
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM escuderias ORDER BY IdEscuderia")
        For Each aux In col
            es = New Escuderia(aux(1))
            es.NombreEscuderia = aux(2).ToString
            p = New Pais(aux(3).ToString)
            es.PaisEscuderias = p
            es.FechaCreacion = Format(Date.Parse(aux(4).ToString), "yyyy-MM-dd")
            Me.Escuderias.Add(es)
        Next
    End Sub

    Public Sub Leer(ByRef es As Escuderia)
        Dim p As Pais
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM escuderias WHERE IdEscuderia='" & es.IdEscuderia & "';")
        For Each aux In col
            p = New Pais(aux(3).ToString)
            es.PaisEscuderias = p
            es.FechaCreacion = Format(Date.Parse(aux(4).ToString), "yyyy-MM-dd")
            Me.Escuderias.Add(es)
        Next
    End Sub

    Public Function Insertar(ByVal es As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO escuderias VALUES ('" & es.IdEscuderia & "', '" & es.NombreEscuderia & "', '" & es.PaisEscuderias.IdPais & "', '" & es.FechaCreacion & "');")
    End Function

    Public Function Actualizar(ByVal es As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE escuderias SET NombreEscuderia='" & es.NombreEscuderia & "', IdPais='" & es.PaisEscuderias.IdPais & "', FechaCreacion='" & es.FechaCreacion & "' WHERE IdEscuderia='" & es.IdEscuderia & "';")
    End Function

    Public Function Borrar(ByVal es As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM escuderias WHERE IdEscuderia='" & es.IdEscuderia & "';")
    End Function
End Class
