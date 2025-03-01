Public Class Alquileres
    Public Sub Alquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarAlquileres()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim idAlquiler As Integer = Convert.ToInt32(selectedItem.SubItems(0).Text)
            ConexionDB.eliminaralquiler(idAlquiler)
            MessageBox.Show("Se ha eliminado el alquiler correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrarAlquileres()
        End If
    End Sub

    Private Sub mostrarAlquileres()
        Dim listaAlquileres As List(Of Alquiler) = ConexionDB.obtenerAlquileres(-1)
        Dim listaPeliculas As List(Of Pelicula) = ConexionDB.obtenerPeliculas()

        ListView1.Items.Clear()

        For Each alquiler In listaAlquileres
            Dim peli As Pelicula = devolverPeliculaId(listaPeliculas, alquiler.IdPelicula)

            If peli IsNot Nothing Then
                Dim item As New ListViewItem(alquiler.IdAlquiler)
                item.SubItems.Add(alquiler.IdSocio)
                item.SubItems.Add(peli.Nombre)
                item.SubItems.Add(peli.Director)
                item.SubItems.Add(alquiler.FechaAlquiler)
                item.SubItems.Add(alquiler.Estado)
                item.SubItems.Add(alquiler.vecesAlquilada)
                ListView1.Items.Add(item)
            End If
        Next
    End Sub

    Private Function devolverPeliculaId(listaPeliculas As List(Of Pelicula), Id_pelicula As Integer) As Pelicula
        Dim pelicula As Pelicula = Nothing

        For Each peliculaLista In listaPeliculas
            If peliculaLista.Id = Id_pelicula Then
                pelicula = peliculaLista
                Exit For
            End If
        Next

        Return pelicula
    End Function
    Private Sub pBoxAtras_Click(sender As Object, e As EventArgs) Handles pBoxAtras.Click
        Me.Hide()
        UIAdministrador.Show()
    End Sub

    Private Sub pBoxInfo_Click_1(sender As Object, e As EventArgs) Handles pBoxInfo.Click
        MessageBox.Show("Haga Click en el Id para seleccionar la pelicula a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class