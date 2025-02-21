Module PanelSocio
    Public panelPrin As New Panel
    Public socioIniciado As Socio
    Dim linearPanel As New FlowLayoutPanel
    Dim mapaPeliculas As New Dictionary(Of Pelicula, CheckBox)
    Dim _peliculasSeleccionadas As New List(Of Pelicula)
    Public btnAccion As New Button

    Public Sub panelPrincipal(form As Form, Accion As String)
        Dim lblTitulo As New Label
        CrearPanel(panelPrin, New Size(600, 500), New Point(219, 1))

        If Accion <> "Peliculas" Then
            btnAccion = CrearBoton(Accion, New Point(460, 11))
            btnAccion.Font = New Font("Lucida Bright", 10, FontStyle.Bold)

            RemoveHandler btnAccion.Click, AddressOf btnAccion_Click
            AddHandler btnAccion.Click, AddressOf btnAccion_Click

            panelPrin.Controls.Add(btnAccion)
        End If

        lblTitulo = CrearLabel(Accion, New Point(20, 25), 12, FontStyle.Bold)
        lblTitulo.ForeColor = SystemColors.Highlight
        panelPrin.Controls.Add(lblTitulo)

        form.Controls.Add(panelPrin)
    End Sub
    Public Sub anadirLinearPanel()
        linearPanel = New FlowLayoutPanel With {
            .Size = New Size(590, 350),
            .Location = New Point(1, 65),
            .AutoScroll = True
            }

        panelPrin.Controls.Add(linearPanel)
    End Sub

    Public Sub anadirPanelListaPeliculas(peliculas As List(Of Pelicula), accion As String)
        For Each pelicula In peliculas
            Dim panelPeli As New Panel
            Dim imgPelicula As New PictureBox
            Dim nombrePelicula As New Label
            Dim director As New Label
            Dim anio As New Label
            Dim check As New CheckBox

            'diseño del panel
            CrearPanel(panelPeli, New Size(590, 130), New Point(219, 1))
            panelPeli.BackColor = Color.FromArgb(224, 224, 224)

            'diseño imagen
            imgPelicula = CrearPictureBox(pelicula.Imagen, New Size(115, 120), New Point(15, 6))

            panelPeli.Controls.Add(imgPelicula)

            'Diseño Labels
            nombrePelicula = CrearLabel(pelicula.Nombre, New Point(159, 20), 12, FontStyle.Bold)
            director = CrearLabel(pelicula.Director, New Point(159, 50), 12, FontStyle.Regular)
            anio = CrearLabel(pelicula.Anio.ToString(), New Point(159, 80), 12, FontStyle.Regular)

            panelPeli.Controls.Add(nombrePelicula)
            panelPeli.Controls.Add(director)
            panelPeli.Controls.Add(anio)

            If (accion <> "Peliculas") Then
                check.Location = New Point(520, 50)
                panelPeli.Controls.Add(check)
            Else
                verTrailer(panelPeli, pelicula)
            End If

            mapaPeliculas.Add(pelicula, check)
            linearPanel.Controls.Add(panelPeli)
        Next
    End Sub

    Public Sub verTrailer(panel As Panel, pelicula As Pelicula)
        Dim imgVerDetalles As New PictureBox
        Dim image As Image = Image.FromFile("C:\Users\mohap\Downloads\avance.png")

        imgVerDetalles = CrearPictureBox(image, New Size(30, 25), New Point(520, 50))
        imgVerDetalles.Tag = pelicula

        AddHandler imgVerDetalles.Click, AddressOf imgVerDetalles_Click
        AddHandler imgVerDetalles.MouseEnter, AddressOf imgVerDetalles_MouseEnter
        AddHandler imgVerDetalles.MouseLeave, AddressOf imgVerDetalles_MouseLeave

        panel.Controls.Add(imgVerDetalles)
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs)
        Dim accion As String = btnAccion.Text

        If accion = "Alquilar" Then
            recorrerPeliculas("Alquilar")
            MessageBox.Show("Alquilada", "COOL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.btnAlquilar_Click(sender, e)
        Else
            recorrerPeliculas("Devolver")
            MessageBox.Show("Devuelta", "COOL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.btnDevolver_Click(sender, e)
        End If
    End Sub

    Private Sub recorrerPeliculas(gestion As String)
        If PeliculasSeleccionadas.Count > 0 Then
            For Each pelicula In PeliculasSeleccionadas
                gestionarAlquiler(pelicula, gestion)
            Next
        Else
            MessageBox.Show("No hay peliculas seleccionadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub gestionarAlquiler(pelicula As Pelicula, gestion As String)
        Dim estaEnBD As Boolean = False
        For Each alquiler In socioIniciado.Alquileres
            If (pelicula.Id = alquiler.IdPelicula) Then
                ConexionDB.actualizarGestionYPelicula(alquiler.IdAlquiler, gestion, pelicula.Id)
                estaEnBD = True
            End If
        Next

        If estaEnBD = False Then
            Dim fechaHoy As String = DateTime.Now.ToString("dd/MM/yyyy")
            Dim alquiler As New Alquiler(0, pelicula.Id, socioIniciado.Id, fechaHoy, "Alquilada", 1)
            ConexionDB.crearAlquiler(alquiler)
        End If
    End Sub
    Private Sub imgVerDetalles_Click(sender As Object, e As EventArgs)
        Dim img As PictureBox = DirectCast(sender, PictureBox)
        Dim peliculaSeleccionada As Pelicula = DirectCast(img.Tag, Pelicula)

        Form3.Pelicula = peliculaSeleccionada
        Form3.Show()
    End Sub


    Private Sub imgVerDetalles_MouseEnter(sender As Object, e As EventArgs)
        Dim img As PictureBox = DirectCast(sender, PictureBox)
        img.Cursor = Cursors.Hand
    End Sub

    Private Sub imgVerDetalles_MouseLeave(sender As Object, e As EventArgs)
        Dim img As PictureBox = DirectCast(sender, PictureBox)
        img.Cursor = Cursors.Hand
    End Sub

    'Propiedad para devolver las peliculas seleccionadas en el apartado de alquilar y devolver
    Public ReadOnly Property PeliculasSeleccionadas As List(Of Pelicula)
        Get
            _peliculasSeleccionadas.Clear()
            For Each check As KeyValuePair(Of Pelicula, CheckBox) In mapaPeliculas
                If check.Value.Checked Then
                    _peliculasSeleccionadas.Add(check.Key)
                End If
            Next

            Return _peliculasSeleccionadas
        End Get
    End Property

    '4 metodos que sirven para crear distintas vistas
    Private Function CrearLabel(texto As String, ubicacion As Point, tamañoFuente As Integer, estiloFuente As FontStyle) As Label
        Return New Label With {
            .Text = texto,
            .Font = New Font("Lucida Bright", tamañoFuente, estiloFuente),
            .AutoSize = True,
            .Location = ubicacion
            }
    End Function

    Private Function CrearBoton(texto As String, ubicacion As Point) As Button
        Return New Button With {
            .Text = texto,
            .Size = New Size(100, 40),
            .Font = New Font("Lucida Bright", 10, FontStyle.Bold),
            .Location = ubicacion
            }
    End Function

    Private Sub CrearPanel(panel As Panel, size As Size, location As Point)
        panel.Size = size
        panel.Location = location
    End Sub

    Private Function CrearPictureBox(imagen As Image, size As Size, location As Point) As PictureBox
        Return New PictureBox With {
            .Size = size,
            .Location = location,
            .Image = imagen,
            .SizeMode = PictureBoxSizeMode.Zoom
            }
    End Function
    'Metodo para limpiar y evitar duplicaciones
    Public Sub limpiar()
        linearPanel.Controls.Clear()
        panelPrin.Controls.Clear()
        mapaPeliculas.Clear()
        _peliculasSeleccionadas.Clear()
        btnAccion.Controls.Clear()
        linearPanel.Refresh()
    End Sub
End Module
