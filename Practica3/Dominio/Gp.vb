Public Class Gp
    Public Property IdGP As Integer
    Public Property DenominacionGP As String
    Public Property PaisGP As Pais

    Public ReadOnly Property GPDAO As GpDAO
    Public Sub New()
        Me.GPDAO = New GpDAO
    End Sub
    Public Sub New(idGP As Integer)
        Me.GPDAO = New GpDAO
        Me.IdGP = idGP
    End Sub
    Public Sub LeerTodosGPs()
        Me.GPDAO.LeerTodos()
    End Sub
    Public Sub LeerGp()
        Me.GPDAO.Leer(Me)
    End Sub
    Public Function InsertarGp() As Integer
        Return Me.GPDAO.Insertar(Me)
    End Function
    Public Function ActualizarGp() As Integer
        Return Me.GPDAO.Actualizar(Me)
    End Function
    Public Function BorrarGp() As Integer
        Return Me.GPDAO.Borrar(Me)
    End Function
End Class
