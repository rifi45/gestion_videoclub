'Falta la creacion de usuario, solamente eroor en la base de datos al insertar consultar mañana.

Public Class Form1
    Dim TipoInicioSesion As String
    Dim TipoCrearUsuario As String
    Dim listaPersonas As New List(Of Persona)
    Dim personaIniciada As Persona
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCrearUsuario.Hide()
        Panel3.Hide()

        ConexionDB.conexionBaseDatosSQLite()
        listaPersonas = ConexionDB.obtenerUsuarios()

    End Sub

    ' Parte inicio de sesion y su logica
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        If String.IsNullOrEmpty(TipoInicioSesion) Then
            MessageBox.Show("Por favor, seleccione Admin o Socio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If comprobarInicio(usuario, contrasena, TipoInicioSesion) Then
            If TipoInicioSesion = "socio" Then
                inicioSocio()
            ElseIf TipoInicioSesion = "admin" Then
                inicioAdmin()
            End If
        Else
            MessageBox.Show("Usuario o Contraseña incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function comprobarInicio(usuario As String, contrasena As String, tipo As String) As Boolean
        For Each persona In listaPersonas
            If persona.Usuario = usuario AndAlso persona.Contrasena = contrasena Then
                If (TypeOf persona Is Socio AndAlso tipo = "socio") OrElse (TypeOf persona Is Administrador AndAlso tipo = "admin") Then
                    personaIniciada = persona
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub inicioSocio()
        Form2.socioIniciado = personaIniciada
        PanelSocio.socioIniciado = personaIniciada
        Form2.Form2_Load(Nothing, Nothing)
        Form2.Show()
        limpiar()
        Me.Hide()
    End Sub

    Private Sub inicioAdmin()
        UIAdministrador.Show()
    End Sub

    'Parte creacion de cuenta y su logica
    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        If ComprobarDatos() = False Then
            If TipoCrearUsuario = "admin" Or TipoCrearUsuario = "socio" Then
                Dim usuarioCreado As Boolean = crearUnUsuario()

                If usuarioCreado Then
                    MostrarPantallaInicio()
                    listaPersonas = ConexionDB.obtenerUsuarios()
                End If
            Else
                MessageBox.Show("Porfavor Seleccione Admin o Socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Porfavor rellene los espacios ROJOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function crearUnUsuario() As Boolean
        Dim nombreCompleto As String = txtNombreCompletoCrear.Text
        Dim usuario As String = txtUsuarioCrear.Text
        Dim correo As String = txtCorreoCrear.Text
        Dim contrasena As String = txtContrasenaCrear.Text
        Dim fecha As String = txtFechaNacCrear.Text
        Dim tipo As String = TipoCrearUsuario

        If Not comprobarNombreUsuario(usuario) Then
            MessageBox.Show("Nombre de usuario existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not comprobarCorreo(correo) Then
            MessageBox.Show("Formato Incorrecto, use <sus_datos>@gmail.com", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not comprobarFecha(fecha) Then
            MessageBox.Show("Formato Incorrecto, use <XX/XX/XXXX>", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Dim persona As Persona
        If (tipo = "socio") Then
            persona = New Socio(0, nombreCompleto, usuario, contrasena, correo, fecha)
        ElseIf (tipo = "admin") Then
            persona = New Administrador(0, nombreCompleto, usuario, contrasena, correo, fecha)
        End If

        ConexionDB.crearUsuario(persona)

        Return True
    End Function

    Private Function comprobarNombreUsuario(usuario As String) As Boolean
        Dim aprobado As Boolean = True
        For Each persona In listaPersonas
            If persona.Usuario = usuario Then
                aprobado = False
            End If
        Next

        Return aprobado
    End Function
    Private Function comprobarCorreo(correo As String) As Boolean
        Dim aprobado = False
        If correo.Contains("@gmail.com") Then
            aprobado = True
        End If
        Return aprobado
    End Function
    Private Function comprobarFecha(fecha As String) As Boolean
        Dim resultado As DateTime
        Return DateTime.TryParseExact(fecha, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, resultado)
    End Function

    Private Sub MostrarPantallaInicio()
        pnlCrearUsuario.Hide()
        panelIniciar.Show()
        Panel3.Show()
        limpiar()
    End Sub

    Private Sub limpiar()
        txtNombreCompletoCrear.Text = ""
        txtUsuarioCrear.Text = ""
        txtContrasena.Text = ""
        txtCorreoCrear.Text = ""
        txtFechaNacCrear.Text = ""
        txtUsuario.Text = ""
        txtContrasena.Text = ""
    End Sub

    'Funcion para comprobar los si todos los campos de crear usuarios estan rellenos si no pone el color de la label rojo
    Private Function ComprobarDatos() As Boolean
        Dim controles As New Dictionary(Of TextBox, Label) From {
        {txtNombreCompletoCrear, Label3},
        {txtUsuarioCrear, Label5},
        {txtCorreoCrear, Label4},
        {txtContrasenaCrear, Label6},
        {txtFechaNacCrear, Label7}
    }

        Dim noAprobado As Boolean = False

        For Each control In controles
            If control.Key.Text = "" Then
                control.Value.ForeColor = Color.Red
                noAprobado = True
            Else
                control.Value.ForeColor = SystemColors.ControlText
            End If
        Next

        Return noAprobado
    End Function

    '-------------------FRONT END----------------------
    'Parte donde me encargo de cambiar de colores a labels y todo lo que tiene que ver con la interfaz de usuario
    Private Sub lblSocio_Click(sender As Object, e As EventArgs) Handles lblSocio.Click
        elegirRol(lblSocio, lblAdmin, "socio", "iniciar")
    End Sub
    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        elegirRol(lblAdmin, lblSocio, "admin", "iniciar")
    End Sub
    Private Sub lblSocioCrear_Click(sender As Object, e As EventArgs) Handles lblSocioCrear.Click
        elegirRol(lblSocioCrear, lblAdminCrear, "socio", "crear")
    End Sub
    Private Sub lblAdminCrear_Click(sender As Object, e As EventArgs) Handles lblAdminCrear.Click
        elegirRol(lblAdminCrear, lblSocioCrear, "admin", "crear")
    End Sub
    Private Sub elegirRol(lblUno As Label, lblDos As Label, eleccion As String, Accion As String)
        lblUno.ForeColor = SystemColors.Highlight
        lblDos.ForeColor = SystemColors.ControlText
        If Accion = "iniciar" Then
            TipoInicioSesion = eleccion
        Else
            TipoCrearUsuario = eleccion
        End If
    End Sub

    Private Sub lblCrearCuenta_Click(sender As Object, e As EventArgs) Handles lblCrearCuenta.Click
        pnlCrearUsuario.Show()
        panelIniciar.Hide()
        Panel3.Hide()
    End Sub
    Private Sub lblCrearCuenta_MouseEnter(sender As Object, e As EventArgs) Handles lblCrearCuenta.MouseEnter
        lblCrearCuenta.ForeColor = SystemColors.Highlight
    End Sub

    Private Sub lblCrearCuenta_MouseLeave(sender As Object, e As EventArgs) Handles lblCrearCuenta.MouseLeave
        lblCrearCuenta.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub lblIniciar_MouseEnter(sender As Object, e As EventArgs) Handles lblIniciar.MouseEnter
        lblIniciar.ForeColor = SystemColors.Highlight
    End Sub

    Private Sub lblIniciar_MouseLeave(sender As Object, e As EventArgs) Handles lblIniciar.MouseLeave
        lblIniciar.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblIniciar.Click
        pnlCrearUsuario.Hide()
        panelIniciar.Show()
    End Sub
End Class
