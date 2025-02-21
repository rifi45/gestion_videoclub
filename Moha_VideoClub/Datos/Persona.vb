Public Class Persona
    Private _id As Integer
    Private _nombreCompleto As String
    Private _usuario As String
    Private _contrasena As String
    Private _correo As String
    Private _fechaNacimiento As String
    Private _tipo As String

    ' Constructor
    Public Sub New(id As Integer, nombreCompleto As String, usuario As String, contrasena As String, correo As String, fechaNacimiento As String)
        Me._id = id
        Me._nombreCompleto = nombreCompleto
        Me._usuario = usuario
        Me._contrasena = contrasena
        Me._correo = correo
        Me._fechaNacimiento = fechaNacimiento
    End Sub

    ' Getters y Setters
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _nombreCompleto
        End Get
        Set(value As String)
            _nombreCompleto = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property
End Class

