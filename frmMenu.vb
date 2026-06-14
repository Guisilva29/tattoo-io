Public Class frmMenu
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim f As New frmClientes()
        f.Show()
    End Sub

    Private Sub btnAgendamentos_Click(sender As Object, e As EventArgs) Handles btnAgendamentos.Click
        Dim f As New frmAgendamentos()
        f.Show()
    End Sub

    Private Sub btnGaleria_Click(sender As Object, e As EventArgs) Handles btnGaleria.Click
        Dim f As New frmGaleria()
        f.Show()
    End Sub

    Private Sub btnIA_Click(sender As Object, e As EventArgs) Handles btnIA.Click
        Dim f As New frmIA()
        f.Show()
    End Sub



End Class
