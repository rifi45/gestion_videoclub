'Clase Socio que hereda de Persona
Public Class Socio
    Inherits Persona

    'Atributo propio de la clase Socio
    Private _alquileres As New List(Of Alquiler)

    Public Sub New(id As Integer, nombreCompleto As String, usuario As String, contrasena As String, correo As String, fechaNacimiento As String)
        MyBase.New(id, nombreCompleto, usuario, contrasena, correo, fechaNacimiento)
    End Sub

    Public Sub actualizarAlquileres()
        _alquileres = ConexionDB.obtenerAlquileres(Me.Id)
    End Sub

    ' Propiedad para acceder a los alquileres
    Public Property Alquileres As List(Of Alquiler)
        Get
            Return _alquileres
        End Get
        Set(value As List(Of Alquiler))
            _alquileres = value
        End Set
    End Property
End Class

