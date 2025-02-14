'Falta la logica de inicio y creacion de cuenta y conectar con la base de datos para un mejor listado.

Public Class Form1
    Dim TipoInicioSesion As String
    Dim TipoCrearUsuario As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCrearUsuario.Hide()
        Panel3.Hide()
    End Sub

    '-------------------BACK END----------------------
    ' Parte donde me encargo de la logica del proyecto aunque tambien tiene algunas cosas de front.

    ' Evento para el inicio de sesion
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim usuario As String = txtUsuario.Text
        Dim Contrasena As String = txtContrasena.Text

        Form2.Show()
        limpiar()
        Me.Hide()

        If TipoInicioSesion = "socio" Then
            If usuario = "socio" And Contrasena = "123" Then
                'Despues implementar la logica de socio
                Form2.Show()
                limpiar()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o Contraseña incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf TipoInicioSesion = "admin" Then
            'Despues implementar La logica de admin
            If usuario = "admin" And Contrasena = "123" Then
                MessageBox.Show("Conectado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Usuario o Contraseña incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Porfavor Seleccione Admin o Socio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Evento para la creacion de una cuenta
    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        If ComprobarDatos() = False Then
            If TipoCrearUsuario = "admin" Or TipoCrearUsuario = "socio" Then
                pnlCrearUsuario.Hide()
                limpiar()
                Panel3.Show()
            Else
                MessageBox.Show("Porfavor Seleccione Admin o Socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Porfavor rellene los espacios ROJOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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

    'Posible refactorizacion del metodo
    Private Function ComprobarDatos() As Boolean
        Dim noAprobado As Boolean = False
        If txtNombreCompletoCrear.Text = "" Then
            Label3.ForeColor = Color.FromArgb(255, 0, 0)
            noAprobado = True
        Else
            Label3.ForeColor = SystemColors.ControlText
        End If

        If txtUsuarioCrear.Text = "" Then
            Label5.ForeColor = Color.FromArgb(255, 0, 0)
            noAprobado = True
        Else
            Label5.ForeColor = SystemColors.ControlText
        End If

        If txtCorreoCrear.Text = "" Then
            Label4.ForeColor = Color.FromArgb(255, 0, 0)
            noAprobado = True
        Else
            Label4.ForeColor = SystemColors.ControlText
        End If

        If txtContrasenaCrear.Text = "" Then
            Label6.ForeColor = Color.FromArgb(255, 0, 0)
            noAprobado = True
        Else
            Label6.ForeColor = SystemColors.ControlText
        End If

        If txtFechaNacCrear.Text = "" Then
            Label7.ForeColor = Color.FromArgb(255, 0, 0)
            noAprobado = True
        Else
            Label7.ForeColor = SystemColors.ControlText
        End If

        Return noAprobado

    End Function

    '-------------------FRONT END----------------------
    'Parte donde me encargo de cambiar de colores a labels y todo lo que tiene que ver con la interfaz de usuario
    Private Sub lblSocio_Click(sender As Object, e As EventArgs) Handles lblSocio.Click
        lblSocio.ForeColor = SystemColors.Highlight
        lblAdmin.ForeColor = SystemColors.ControlText
        TipoInicioSesion = "socio"
    End Sub

    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        lblAdmin.ForeColor = SystemColors.Highlight
        lblSocio.ForeColor = SystemColors.ControlText
        TipoInicioSesion = "admin"
    End Sub

    Private Sub lblCrearCuenta_Click(sender As Object, e As EventArgs) Handles lblCrearCuenta.Click
        pnlCrearUsuario.Show()
        Panel3.Hide()
    End Sub

    Private Sub lblSocioCrear_Click(sender As Object, e As EventArgs) Handles lblSocioCrear.Click
        lblSocioCrear.ForeColor = SystemColors.Highlight
        lblAdminCrear.ForeColor = SystemColors.ControlText
        TipoCrearUsuario = "socio"
    End Sub

    Private Sub lblAdminCrear_Click(sender As Object, e As EventArgs) Handles lblAdminCrear.Click
        lblAdminCrear.ForeColor = SystemColors.Highlight
        lblSocioCrear.ForeColor = SystemColors.ControlText
        TipoCrearUsuario = "admin"
    End Sub

    Private Sub lblCrearCuenta_MouseEnter(sender As Object, e As EventArgs) Handles lblCrearCuenta.MouseEnter
        lblCrearCuenta.ForeColor = SystemColors.Highlight
    End Sub

    Private Sub lblCrearCuenta_MouseLeave(sender As Object, e As EventArgs) Handles lblCrearCuenta.MouseLeave
        lblCrearCuenta.ForeColor = SystemColors.ControlText
    End Sub
End Class
