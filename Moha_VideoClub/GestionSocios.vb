Public Class GestionSocios
    Private Sub GestionSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
    End Sub
    'Evento para consultar los socios 
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim idSocio As String = txtIdSocio.Text

        'Comprobar el id de socio no este nulo y que sea numerico
        If Not String.IsNullOrWhiteSpace(idSocio) AndAlso IsNumeric(idSocio) Then
            Dim socioId As Integer = Convert.ToInt32(idSocio)
            Dim socio As Socio = ConexionDB.obtenerSocioPorId(socioId)

            If socio IsNot Nothing Then
                txtNombre.Text = socio.NombreCompleto
                txtUsuario.Text = socio.Usuario
                txtCorreo.Text = socio.Correo
                txtFechaNac.Text = socio.FechaNacimiento
                txtAlquileres.Text = $"{socio.Alquileres.Count} ({alquileresActivos(socio)})"
            Else
                MessageBox.Show("No se encontró un socio con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Por favor, introduce un ID válido que sea numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Evento para eliminar un socio
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idSocio As String = txtIdSocio.Text

        If Not String.IsNullOrWhiteSpace(idSocio) AndAlso IsNumeric(idSocio) Then
            Dim socioId As Integer = Convert.ToInt32(idSocio)
            If ConexionDB.eliminarSocio(socioId) Then
                MessageBox.Show("Socio eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ConexionDB.eliminarAlquileres(socioId, "socio")
                LimpiarCampos()
            Else
                MessageBox.Show("No se pudo eliminar el socio. Puede que no exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, introduce un ID válido que sea numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function alquileresActivos(socio As Socio) As Integer
        Dim contador As Integer = 0

        Try
            If socio.Alquileres IsNot Nothing AndAlso socio.Alquileres.Count > 0 Then
                For Each alquiler In socio.Alquileres
                    If alquiler.Estado = "Alquilada" Then
                        contador += 1
                    End If
                Next
            End If
        Catch ex As Exception
            Return 0
        End Try

        Return contador
    End Function


    Private Sub LimpiarCampos()
        txtIdSocio.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        txtCorreo.Clear()
        txtFechaNac.Clear()
        txtAlquileres.Clear()
    End Sub

    Private Sub pBoxAtras_Click(sender As Object, e As EventArgs) Handles pBoxAtras.Click
        Me.Hide()
        UIAdministrador.Show()
    End Sub

    Private Sub pBoxInfo_Click(sender As Object, e As EventArgs) Handles pBoxInfo.Click
        MessageBox.Show("Ingrese solo el ID para gestionar." & vbCrLf &
                    "En los alquileres mostramos: Número de alquileres total (activos).",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
