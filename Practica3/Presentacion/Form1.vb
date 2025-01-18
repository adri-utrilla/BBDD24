Public Class Form1
    Public pa As Pais
    Public pi As Piloto
    Public gp As Gp
    Public es As Escuderia

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        Dim pAux As Pais
        Me.pa = New Pais
        Try
            Me.pa.LeerPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.pa.PaDAO.Paises
            Form1.tcfF1.lstPaises.Items.Add(pAux.IdPais & " - " & pAux.NombrePais & " - " & pAux.HabitantesPais)
        Next
    End Sub
End Class
