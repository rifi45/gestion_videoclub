Imports System.Globalization
Imports Microsoft.VisualBasic.Devices

Public Class GestionPeliculas

    Private Sub GestionPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGeneros()
    End Sub
    'Evento para agregar las peliculas
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarCampos() Then
            Try
                Dim pelicula As New Pelicula(0, txtNombre.Text, pBoxImagen.Image, txtDirector.Text,
                                            Convert.ToInt32(txtAnio.Text), cBoxGenero.Text,
                                            Convert.ToInt32(txtDuracion.Text), Convert.ToInt32(txtStock.Text))

                If txtTrailer.Text <> "" Then
                    pelicula.Trailer = txtTrailer.Text
                End If

                ConexionDB.crearPelicula(pelicula)
                MessageBox.Show("Pelicula agregada con exito!.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error inesperado " + ex.Message() + ", Porfavor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        LimpiarCampos()
    End Sub

    'Evento para modificar las peliculas
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not String.IsNullOrWhiteSpace(txtIdPelicula.Text) Then
            Try
                Dim pelicula As New Pelicula(Convert.ToInt32(txtIdPelicula.Text), txtNombre.Text, pBoxImagen.Image, txtDirector.Text,
                                         If(String.IsNullOrWhiteSpace(txtAnio.Text), -1, Convert.ToInt32(txtAnio.Text)),
                                         cBoxGenero.Text,
                                         If(String.IsNullOrWhiteSpace(txtDuracion.Text), -1, Convert.ToInt32(txtDuracion.Text)),
                                         If(String.IsNullOrWhiteSpace(txtStock.Text), -1, Convert.ToInt32(txtStock.Text)))

                If txtTrailer.Text <> "" Then
                    pelicula.Trailer = txtTrailer.Text
                End If

                ConexionDB.modificarPelicula(pelicula)
                MessageBox.Show("Película modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error inesperado " + ex.Message + ", Por favor vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, ingresa el ID de la película que deseas modificar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        LimpiarCampos()
    End Sub

    'Evento para consultar las peliculas
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If String.IsNullOrWhiteSpace(txtIdPelicula.Text) Then
            MessageBox.Show("Por favor, ingresa el ID de la película que deseas consultar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idPelicula As Integer = Convert.ToInt32(txtIdPelicula.Text)
            Dim pelicula As Pelicula = ConexionDB.obtenerPeliculaPorId(idPelicula)
            If pelicula IsNot Nothing Then
                txtNombre.Text = pelicula.Nombre
                pBoxImagen.Image = pelicula.Imagen
                txtDirector.Text = pelicula.Director
                txtAnio.Text = pelicula.Anio.ToString()
                cBoxGenero.SelectedItem = pelicula.Genero
                txtDuracion.Text = pelicula.Duracion.ToString()
                txtStock.Text = pelicula.Stock.ToString()
                txtTrailer.Text = pelicula.Trailer
            Else
                MessageBox.Show("No se encontró la película con el ID proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al consultar la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdPelicula.Text) Then
            MessageBox.Show("Por favor, ingresa el ID de la película que deseas eliminar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idPelicula As Integer = Convert.ToInt32(txtIdPelicula.Text)
            ConexionDB.eliminarPelicula(idPelicula)
            MessageBox.Show("Película eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ConexionDB.eliminarAlquileres(idPelicula, "pelicula")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la película: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LimpiarCampos()
    End Sub
    'Al hacer Click sobre el picture box nos permite añadir una imagen desde los archivos
    Private Sub pBoxImagen_Click(sender As Object, e As EventArgs) Handles pBoxImagen.Click
        iniciarPictureBox()
    End Sub

    'Metodo que sirve para poder cargar una imagen Al PictureBox
    Private Sub iniciarPictureBox()
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pBoxImagen.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    'Funcion para comprobar que los datos estan rellenados
    Private Function ValidarCampos() As Boolean
        Dim controlesObligatorios As TextBox() = {txtNombre, txtDirector, txtAnio, txtDuracion, txtStock}
        For Each ctrl As TextBox In controlesObligatorios
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next

        If pBoxImagen.Image Is Nothing Then
            MessageBox.Show("Por favor, selecciona una imagen para la portada.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cBoxGenero.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un género.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return verificarNumericos()

        Return True
    End Function

    ' Funcion para validar si los numeros tienen el formato correcto
    Private Function verificarNumericos() As Boolean
        Dim anio, duracion, stock As Integer
        If Not Integer.TryParse(txtAnio.Text, anio) Then
            MessageBox.Show("El campo 'Año' debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Integer.TryParse(txtDuracion.Text, duracion) Then
            MessageBox.Show("El campo 'Duración' debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("El campo 'Stock' debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ' Metodo que sirve para obtener los genereos de un fichero
    Private Sub CargarGeneros()
        Try
            Dim rutaArchivo As String = "C:\Users\mohap\source\repos\Moha_VideoClub\recursos_externos\generos.txt"
            If System.IO.File.Exists(rutaArchivo) Then
                Dim generos As String() = System.IO.File.ReadAllLines(rutaArchivo)
                cBoxGenero.Items.Clear()
                cBoxGenero.Items.AddRange(generos)
            Else
                MessageBox.Show("El archivo de géneros no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los géneros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Limpiar los textboxes 
    Private Sub LimpiarCampos()
        txtIdPelicula.Clear()
        txtNombre.Clear()
        txtDirector.Clear()
        txtAnio.Clear()
        txtDuracion.Clear()
        txtStock.Clear()
        txtTrailer.Clear()
        cBoxGenero.SelectedIndex = -1
        pBoxImagen.Image = Nothing
    End Sub


    Private Sub pBoxAtras_Click(sender As Object, e As EventArgs) Handles pBoxAtras.Click
        Me.Hide()
        UIAdministrador.Show()
    End Sub

    Private Sub pBoxInfo_Click(sender As Object, e As EventArgs) Handles pBoxInfo.Click
        MessageBox.Show("Haga Click en la imagen para añadir peliculas." & vbCrLf &
                        "Para Consultar, Eliminar solo introduzca el id pelicula." & vbCrLf &
                        "Para Modificar introduzca el id pelicula y el dato a modificar", "Información",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class