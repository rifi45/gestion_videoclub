'Clase Administrador que hereda de Persona
Public Class Administrador
    Inherits Persona

    Public Sub New(id As Integer, nombreCompleto As String, usuario As String, contrasena As String, correo As String, fechaNacimiento As String)
        MyBase.New(id, nombreCompleto, usuario, contrasena, correo, fechaNacimiento)
    End Sub
End Class
