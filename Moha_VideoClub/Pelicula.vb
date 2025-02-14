Public Class Pelicula
    ' Atributos privados
    Private _id As Integer
    Private _nombre As String
    Private _imagen As Image
    Private _director As String
    Private _anio As String
    Private _genero As String
    Private _duracion As Integer
    Private _stock As Integer

    ' Constructor
    Public Sub New(nombre As String, imagen As Image, director As String, anio As String, genero As String, duracion As Integer, stock As Integer)
        Me._nombre = nombre
        Me._imagen = imagen
        Me._director = director
        Me._anio = anio
        Me._genero = genero
        Me._duracion = duracion
        Me._stock = stock
    End Sub

    ' Propiedades
    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Imagen As Image
        Get
            Return _imagen
        End Get
        Set(value As Image)
            _imagen = value
        End Set
    End Property

    Public Property Director As String
        Get
            Return _director
        End Get
        Set(value As String)
            _director = value
        End Set
    End Property

    Public Property Anio As String
        Get
            Return _anio
        End Get
        Set(value As String)
            _anio = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property

    Public Property Duracion As Integer
        Get
            Return _duracion
        End Get
        Set(value As Integer)
            _duracion = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
End Class

