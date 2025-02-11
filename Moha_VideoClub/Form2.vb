Imports System.Threading

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        restablecerColor()
    End Sub
    '------------------------------Back-End-----------------------------------
    Private Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click
        restablecerColor()
        btnAlquilar.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        restablecerColor()
        btnDevolver.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnConsultarPelis_Click(sender As Object, e As EventArgs) Handles btnConsultarPelis.Click
        restablecerColor()
        btnConsultarPelis.BackColor = Color.FromArgb(224, 224, 224)
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
        Me.Hide()
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
End Class