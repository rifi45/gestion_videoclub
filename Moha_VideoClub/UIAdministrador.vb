Public Class UIAdministrador
    Public adminAccedido As Persona
    ' variable para controlar el acceso al form Alquileres
    Dim accederAlquileres As Integer = 0
    Private Sub UIAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mensajeBienvenida()
    End Sub

    Private Sub SociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem.Click
        Me.Hide()
        GestionSocios.Show()
    End Sub

    Private Sub PeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeliculaToolStripMenuItem.Click
        Me.Hide()
        GestionPeliculas.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Form1.Form1_Load(Nothing, Nothing)
        Form1.Show()
    End Sub

    Private Sub PeliculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeliculasToolStripMenuItem.Click
        Me.Hide()
        ConsultarPeliculas.Show()
    End Sub

    Private Sub AlquileresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquileresToolStripMenuItem.Click
        Me.Hide()
        'para si ya se ha accedido a este form, poder volver a cargar el load
        If accederAlquileres > 0 Then
            Alquileres.Alquileres_Load(Nothing, Nothing)
        End If
        accederAlquileres += 1
        Alquileres.Show()
    End Sub


    Public Sub mensajeBienvenida()
        'Crear y agregar los mensajes al panel
        panelBienvenida.Controls.Add(CrearLabel("Bienvenido " & adminAccedido.NombreCompleto, 80, 10, 14, FontStyle.Bold))
        panelBienvenida.Controls.Add(CrearLabel("Tenemos " & ConexionDB.obtenerPeliculas().Count & " Películas disponibles", 80, 50))
        panelBienvenida.Controls.Add(CrearLabel("Contamos con " & ConexionDB.obtenerUsuarios().Count & " usuarios dados de alta", 70, 90))
        panelBienvenida.Controls.Add(CrearLabel("Se han realizado " & ConexionDB.obtenerAlquileres(-1).Count & " alquileres", 95, 130))
    End Sub

    'Funcion para crear Labels con formato estándar
    Private Function CrearLabel(texto As String, x As Integer, y As Integer, Optional tamañoFuente As Integer = 10, Optional estilo As FontStyle = FontStyle.Regular) As Label
        Return New Label With {
        .Text = texto,
        .Location = New Point(x, y),
        .Font = New Font("Lucida Bright", tamañoFuente, estilo),
        .AutoSize = True,
        .TextAlign = ContentAlignment.MiddleCenter
    }
    End Function
End Class