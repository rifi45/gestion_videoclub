'Formulario que sirve para la gestion de Socios y sus alquileres.
Public Class Form2
    Public socioIniciado As Socio
    Dim listaPeliculas As New List(Of Pelicula)
    Dim peliculasAAlquilar As New List(Of Pelicula)
    Dim PeliculasAlquiladas As List(Of Pelicula)
    Dim CheckBoxes As New List(Of CheckBox)
    Dim CheckBoxesSeleccionados As Integer
    Dim btnAccion As New Button

    'Al iniciar el formulario se consultan lista de peliculas de cada Socio y sus alquileres
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restablecerColor()
        panelHistorico.Hide()
        lblNombre.Text = socioIniciado.NombreCompleto
        lblUser.Text = socioIniciado.Usuario

        ' iniciar el proyecto en la parte de peliculas
        fijarBtnColor(btnConsultarPelis)
        iniciarPanel(listaPeliculas, "Peliculas")

        PanelSocio.socioIniciado = socioIniciado

        listaPeliculas = ConexionDB.obtenerPeliculas
        socioIniciado.actualizarAlquileres()
    End Sub
    'Click Alquilar peliculas
    Public Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click
        peliculasAAlquilar = ConexionDB.obtenerPeliculasNoAlquiladas(socioIniciado.Id)
        fijarBtnColor(btnAlquilar)
        iniciarPanel(peliculasAAlquilar, "Alquilar")
        socioIniciado.actualizarAlquileres()
        listaPeliculas = ConexionDB.obtenerPeliculas
    End Sub

    'Click devolver peliculas
    Public Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        PeliculasAlquiladas = ConexionDB.obtenerPeliculasAlquiladas(socioIniciado.Id)
        fijarBtnColor(btnDevolver)
        iniciarPanel(PeliculasAlquiladas, "Devolver")
        socioIniciado.actualizarAlquileres()
        listaPeliculas = ConexionDB.obtenerPeliculas
    End Sub

    'Click consultar Peliculas
    Public Sub btnConsultarPelis_Click(sender As Object, e As EventArgs) Handles btnConsultarPelis.Click
        fijarBtnColor(btnConsultarPelis)
        iniciarPanel(listaPeliculas, "Peliculas")
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        ActualizarHistorial("Historico")
    End Sub

    'Click para Cerrar Sesion
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        fijarBtnColor(btnCerrarSesion)
        PanelSocio.limpiar()

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lblAlquiladas_Click(sender As Object, e As EventArgs) Handles lblAlquiladas.Click
        ActualizarHistorial("Alquilada")
    End Sub

    Private Sub lblDevueltas_Click(sender As Object, e As EventArgs) Handles lblDevueltas.Click
        ActualizarHistorial("Devuelta")
    End Sub

    'Metodo para iniciar el listView de historico
    Private Sub ActualizarHistorial(alquilerEstado As String)
        'Actualizar el estado de alquileres despues de alquilar o devolver una pelicula
        socioIniciado.Alquileres = ConexionDB.obtenerAlquileres(socioIniciado.Id)
        establecerColoresHistorico(alquilerEstado)
        Dim alquileres As New List(Of Alquiler)
        Dim Contador As Integer = 0

        ListView1.Items.Clear()

        alquileres = socioIniciado.Alquileres

        If alquileres IsNot Nothing AndAlso alquileres.Count > 0 Then
            For Each alquiler In alquileres
                Dim peli As Pelicula = devolverPeliculaId(alquiler.IdPelicula)

                If peli IsNot Nothing AndAlso (alquiler.Estado = alquilerEstado Or alquilerEstado = "Historico") Then
                    Dim item As New ListViewItem((Contador + 1).ToString())
                    item.SubItems.Add(peli.Nombre)
                    item.SubItems.Add(peli.Director)
                    item.SubItems.Add(alquiler.FechaAlquiler)
                    item.SubItems.Add(alquiler.Estado)
                    item.SubItems.Add(alquiler.vecesAlquilada)
                    ListView1.Items.Add(item)

                    Contador += 1
                End If
            Next
        Else
            MessageBox.Show("No se encontraron alquileres para este socio.")
        End If
    End Sub
    'Metodo para devolver una pelicula por su ID
    Private Function devolverPeliculaId(Id_pelicula As Integer) As Pelicula
        Dim pelicula As Pelicula = Nothing

        For Each peliculaLista In listaPeliculas
            If peliculaLista.Id = Id_pelicula Then
                pelicula = peliculaLista
                Exit For
            End If
        Next

        Return pelicula
    End Function
    ' metodo para fijar color en un boton
    Private Sub fijarBtnColor(btn As Button)
        panelHistorico.Hide()
        restablecerColor()
        btn.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
    ' metodo para iniciar los paneles
    Private Sub iniciarPanel(listaPeliculas As List(Of Pelicula), accion As String)
        PanelSocio.limpiar()
        PanelSocio.panelPrincipal(Me, accion)
        PanelSocio.anadirLinearPanel()
        PanelSocio.anadirPanelListaPeliculas(listaPeliculas, accion)
    End Sub
    ' metodo para organizar los colores de el boton historico
    Private Sub establecerColoresHistorico(alquilerEstado As String)
        lblAlquiladas.ForeColor = If(alquilerEstado = "Alquilada", SystemColors.Highlight, SystemColors.ControlText)
        lblDevueltas.ForeColor = If(alquilerEstado = "Devuelta", SystemColors.Highlight, SystemColors.ControlText)
        If alquilerEstado = "Historico" Then
            restablecerColor()
            btnHistorial.BackColor = Color.FromArgb(224, 224, 224)
            panelHistorico.Show()
            lblAlquiladas.ForeColor = SystemColors.ControlText
            lblDevueltas.ForeColor = SystemColors.ControlText
        End If
    End Sub
    ' metodo para restablecer el color de los botones y dejarlo en color inclickable
    Private Sub restablecerColor()
        Dim color As Color = SystemColors.Control
        btnAlquilar.BackColor = color
        btnConsultarPelis.BackColor = color
        btnDevolver.BackColor = color
        btnHistorial.BackColor = color
        btnCerrarSesion.BackColor = color
    End Sub
End Class