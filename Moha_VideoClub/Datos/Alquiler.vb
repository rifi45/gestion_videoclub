Public Class Alquiler
    Private _id_alquiler As Integer
    Private _id_Pelicula As Integer
    Private _id_socio As Integer
    Private _fecha As String
    Private _estado As String
    Private _veces_alquilada As Integer

    ' Constructor
    Public Sub New(idAlquiler As Integer, idPelicula As Integer, idSocio As Integer, fecha As String, estado As String, vecesAlquilada As Integer)
        Me._id_alquiler = idAlquiler
        Me._id_Pelicula = idPelicula
        Me._id_socio = idSocio
        Me._fecha = fecha
        Me._estado = estado
        Me._veces_alquilada = vecesAlquilada
    End Sub

    Public Property IdAlquiler As Integer
        Get
            Return _id_alquiler
        End Get
        Set(value As Integer)
            _id_alquiler = value
        End Set
    End Property

    Public Property IdPelicula As Integer
        Get
            Return _id_Pelicula
        End Get
        Set(value As Integer)
            _id_Pelicula = value
        End Set
    End Property

    Public Property IdSocio As Integer
        Get
            Return _id_socio
        End Get
        Set(value As Integer)
            _id_socio = value
        End Set
    End Property

    Public Property FechaAlquiler As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property vecesAlquilada As Integer
        Get
            Return _veces_alquilada
        End Get
        Set(value As Integer)
            _veces_alquilada = value
        End Set
    End Property

End Class

