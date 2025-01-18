Public Class Escuderia
    Public Property IdEscuderia As Integer
    Public Property NombreEscuderia As String
    Public Property PaisEscuderias As Pais
    Public Property FechaCreacion As Date
    Public ReadOnly Property EsDAO As EscuderiaDAO

    Public Sub New()
        Me.EsDAO = New EscuderiaDAO
    End Sub

    Public Sub New(IdEscuderia As Integer)
        Me.IdEscuderia = IdEscuderia
        Me.EsDAO = New EscuderiaDAO
    End Sub

    Public Sub LeerTodasEscuderias()
        Me.EsDAO.LeerTodas()
    End Sub

    Public Sub LeerEscuderia()
        Me.EsDAO.Leer(Me)
    End Sub

    Public Function InsertarEscuderia() As Integer
        Return Me.EsDAO.Insertar(Me)
    End Function

    Public Function ActualizarEscuderia() As Integer
        Return Me.EsDAO.Actualizar(Me)
    End Function

    Public Function BorrarEscuderia() As Integer
        Return Me.EsDAO.Borrar(Me)
    End Function
End Class
