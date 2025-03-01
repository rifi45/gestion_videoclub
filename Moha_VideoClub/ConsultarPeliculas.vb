Public Class ConsultarPeliculas

    Private Sub pBoxAtras_Click(sender As Object, e As EventArgs) Handles pBoxAtras.Click
        Me.Hide()
        UIAdministrador.Show()
    End Sub
    Private Sub ConsultarPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        Try
            agregarAListView()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error inseperado" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub agregarAListView()
        Dim listaPeliculas = ConexionDB.obtenerPeliculas

        For Each peli In listaPeliculas
            Dim item As New ListViewItem(peli.Id.ToString())
            item.SubItems.Add(peli.Nombre)
            item.SubItems.Add(peli.Director)
            item.SubItems.Add(peli.Genero)
            item.SubItems.Add(peli.Anio)
            item.SubItems.Add(peli.Duracion)
            item.SubItems.Add(peli.Stock)
            ListView1.Items.Add(item)
        Next
    End Sub
End Class