Imports System.Threading

'Falta crear los panels de cada apartado con su logica, obtener datos del primer form y conectarse a la database.
'Consultar Paso de informacion de un form a otro.
Public Class Form2
    Dim listaPeliculas As New List(Of Pelicula)
    Dim CheckBoxes As New List(Of CheckBox)
    Dim CheckBoxesSeleccionados As Integer
    Dim btnAccion As New Button
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restablecerColor()
        PeliculasPrueba()
    End Sub
    '------------------------------Back-End-----------------------------------
    Private Sub PeliculasPrueba()
        Dim imagenPorDefecto As Image = SystemIcons.Application.ToBitmap()

        ' Agregar 5 películas
        listaPeliculas.Add(New Pelicula("Inception", imagenPorDefecto, "Christopher Nolan", "2010", "Ciencia Ficción", 148, 5))
        listaPeliculas.Add(New Pelicula("Titanic", imagenPorDefecto, "James Cameron", "1997", "Romance", 195, 3))
        listaPeliculas.Add(New Pelicula("Avatar", imagenPorDefecto, "James Cameron", "2009", "Ciencia Ficción", 162, 7))
        listaPeliculas.Add(New Pelicula("El Padrino", imagenPorDefecto, "Francis Ford Coppola", "1972", "Crimen", 175, 4))
        listaPeliculas.Add(New Pelicula("Interstellar", imagenPorDefecto, "Christopher Nolan", "2014", "Ciencia Ficción", 169, 6))
    End Sub

    '------------------------------Front-End-----------------------------------
    'metodo para restablecer los colores de button
    Private Sub restablecerColor()
        btnAlquilar.BackColor = SystemColors.Control
        btnConsultarPelis.BackColor = SystemColors.Control
        btnDevolver.BackColor = SystemColors.Control
        btnHistorial.BackColor = SystemColors.Control
        btnAtencion.BackColor = SystemColors.Control
        btnCerrarSesion.BackColor = SystemColors.Control
    End Sub

    '-----------------------------------Button-Events------------------------------------------

    Private Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click
        Panels.limpiar()
        restablecerColor()
        btnAlquilar.BackColor = Color.FromArgb(224, 224, 224)

        Panels.panelPrincipal(Me, "Alquilar")
        Panels.anadirLinearPanel()

        Panels.anadirPanelListaPeliculas(listaPeliculas, "Alquilar")

    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        Panels.limpiar()
        restablecerColor()
        btnDevolver.BackColor = Color.FromArgb(224, 224, 224)

        Panels.panelPrincipal(Me, "Devolver")
        Panels.anadirLinearPanel()

        Panels.anadirPanelListaPeliculas(listaPeliculas, "Devolver")
    End Sub

    Private Sub btnConsultarPelis_Click(sender As Object, e As EventArgs) Handles btnConsultarPelis.Click
        Panels.limpiar()
        restablecerColor()
        btnConsultarPelis.BackColor = Color.FromArgb(224, 224, 224)

        Panels.panelPrincipal(Me, "Peliculas")
        Panels.anadirLinearPanel()

        Panels.anadirPanelListaPeliculas(listaPeliculas, "Peliculas")
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        restablecerColor()
        btnHistorial.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnAtencion_Click(sender As Object, e As EventArgs) Handles btnAtencion.Click
        restablecerColor()
        btnAtencion.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        restablecerColor()
        btnCerrarSesion.BackColor = Color.FromArgb(224, 224, 224)
        Thread.Sleep(100)
        Form1.Show()
        restablecerColor()
        Me.Hide()
    End Sub
End Class