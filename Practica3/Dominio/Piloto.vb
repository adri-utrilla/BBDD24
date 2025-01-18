Public Class Piloto
    Public Property IdPiloto As Integer
    Public Property NombrePiloto As String
    Public Property ApellidoPiloto As String
    Public Property PaisPiloto As Pais

    Public ReadOnly PiDAO As PilotoDAO

    Public Sub New()
        Me.PiDAO = New PilotoDAO
    End Sub

    Public Sub New(id As Integer)
        Me.PiDAO = New PilotoDAO
        Me.IdPiloto = id
    End Sub

    Public Sub LeerPilotos()
        Me.PiDAO.LeerTodos()
    End Sub

    Public Sub LeerPiloto()
        Me.PiDAO.Leer(Me)
    End Sub
    Public Function InsertarPiloto() As Integer
        Return Me.PiDAO.Insertar(Me)
    End Function

    Public Function ActualizarPiloto() As Integer
        Return Me.PiDAO.Actualizar(Me)
    End Function

    Public Function BorrarPiloto() As Integer
        Return Me.PiDAO.Borrar(Me)
    End Function

End Class
