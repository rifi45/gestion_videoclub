Module Panels
    Public panelPrin As New Panel
    Dim linearPanel As New FlowLayoutPanel
    Dim mapaPeliculas As New Dictionary(Of Pelicula, CheckBox)
    Dim _peliculasSeleccionadas As New List(Of Pelicula)
    Public btnAccion As New Button

    Public Sub panelPrincipal(form As Form, Accion As String)
        Dim lblTitulo As New Label
        lblTitulo.Text = ""
        panelPrin.Size = New Size(600, 500)
        panelPrin.AutoScroll = False
        panelPrin.Location = New Point(219, 1)

        If Accion <> "Peliculas" Then
            btnAccion.Text = Accion
            btnAccion.Size = New Size(100, 40)
            btnAccion.Location = New Point(460, 11)
            btnAccion.Font = New Font("Lucida Bright", 10, FontStyle.Bold)


            RemoveHandler btnAccion.Click, AddressOf btnAccion_Click
            AddHandler btnAccion.Click, AddressOf btnAccion_Click

            panelPrin.Controls.Add(btnAccion)
        End If

        lblTitulo.Font = New Font("Lucida Bright", 12, FontStyle.Bold)
        lblTitulo.Location = New Point(20, 25)
        lblTitulo.AutoSize = True
        lblTitulo.Text = Accion

        panelPrin.Controls.Add(lblTitulo)

        form.Controls.Add(panelPrin)
    End Sub
    Public Sub anadirLinearPanel()
        linearPanel.Size = New Size(590, 350)
        linearPanel.Location = New Point(1, 65)

        linearPanel.AutoScroll = True

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
            panelPeli.Size = New Size(590, 130)
            panelPeli.Location = New Point(219, 1)
            panelPeli.BackColor = Color.FromArgb(224, 224, 224)

            'diseño imagen
            imgPelicula.Size = New Size(100, 80)
            imgPelicula.Location = New Point(15, 12)
            imgPelicula.Image = pelicula.Imagen
            imgPelicula.SizeMode = PictureBoxSizeMode.AutoSize

            panelPeli.Controls.Add(imgPelicula)

            'Diseño Labels
            nombrePelicula.Location = New Point(159, 20)
            nombrePelicula.Font = New Font("Lucida Bright", 12, FontStyle.Bold)
            nombrePelicula.Text = pelicula.Nombre
            director.Location = New Point(159, 60)
            director.Font = New Font("Lucida Bright", 10)
            director.Text = pelicula.Director
            anio.Location = New Point(159, 100)
            anio.Font = New Font("Lucida Bright", 10)
            anio.Text = (pelicula.Anio).ToString

            panelPeli.Controls.Add(nombrePelicula)
            panelPeli.Controls.Add(director)
            panelPeli.Controls.Add(anio)

            If (accion <> "Peliculas") Then
                check.Location = New Point(520, 50)
                panelPeli.Controls.Add(check)
            End If


            mapaPeliculas.Add(pelicula, check)

            linearPanel.Controls.Add(panelPeli)

        Next
    End Sub

    Public Sub limpiar()
        linearPanel.Controls.Clear()
        panelPrin.Controls.Clear()

        mapaPeliculas.Clear()
        _peliculasSeleccionadas.Clear()
        btnAccion.Controls.Clear()


        linearPanel.Refresh()
    End Sub

    Public ReadOnly Property PeliculasSeleccionadas As List(Of Pelicula)
        Get
            For Each check As KeyValuePair(Of Pelicula, CheckBox) In mapaPeliculas
                If check.Value.Checked Then
                    _peliculasSeleccionadas.Add(check.Key)
                End If
            Next

            Return _peliculasSeleccionadas
        End Get
    End Property

    Private Sub btnAccion_Click(sender As Object, e As EventArgs)
        If btnAccion.Text = "Alquilar" Then
            MessageBox.Show("Has alquilado las películas seleccionadas.")
        ElseIf btnAccion.Text = "Devolver" Then
            MessageBox.Show("Has devuelto las películas seleccionadas.")
        Else
            MessageBox.Show("Acción no definida: " & btnAccion.Text)
        End If
    End Sub
End Module
