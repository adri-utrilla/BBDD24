Public Class Pais

    Public Property IdPais As String

    Public Property NombrePais As String

    Public Property HabitantesPais As Integer

    Public ReadOnly Property PaDAO As PaisDAO

    Public Sub New()
        Me.PaDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaDAO = New PaisDAO
        Me.IdPais = id
    End Sub

    Public Sub LeerPaises()
        Me.PaDAO.LeerTodos()
    End Sub

    Public Sub LeerPais()
        Me.PaDAO.Leer(Me)
    End Sub
    Public Function InsertarPais() As Integer
        Return Me.PaDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaDAO.Borrar(Me)
    End Function

End Class
