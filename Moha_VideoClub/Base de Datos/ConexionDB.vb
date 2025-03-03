Imports System.Data.SQLite
Imports System.IO
Module ConexionDB
    Dim nombreBaseDatos As String = "Data Source=C:\Users\mohap\source\repos\Moha_VideoClub\moha_gestion_peliculas.db;Version=3;"
    Public Conexion As SQLiteConnection
    Sub conexionBaseDatosSQLite()
        Try
            Conexion = New SQLiteConnection(nombreBaseDatos)
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try
    End Sub
    Public Sub DesconectarBD()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()

            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

    'Consulta para obtener todas las peliculas
    Public Function obtenerPeliculas() As List(Of Pelicula)
        Dim listaPeliculas As New List(Of Pelicula)
        Try
            Dim consulta As String = "SELECT * FROM pelicula"

            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            Dim dt As New DataTable()
                adaptador.Fill(dt)


                For Each fila As DataRow In dt.Rows
                Dim peli As New Pelicula(
                    Convert.ToInt32(fila("id_pelicula")),
                    fila("nombre").ToString,
                    convertirAImagen(CType(fila("imagen"), Byte())),
                    fila("director").ToString(),
                    Convert.ToInt32(fila("anio")),
                    fila("genero").ToString(),
                    Convert.ToInt32(fila("duracion")),
                    Convert.ToInt32(fila("stock"))
                    )
                peli.Trailer = fila("video").ToString
                    listaPeliculas.Add(peli)
                Next
                Return listaPeliculas
        Catch ex As Exception
            MsgBox("Error al consultar películas: " & ex.Message)
            Return Nothing
        End Try
    End Function

    'Consulta para obtenertodos los alquileres o uno solo
    Public Function obtenerAlquileres(id As Integer) As List(Of Alquiler)
        Dim listaAlquileres As New List(Of Alquiler)
        Dim consulta As String
        'Si es -1 devuelve todos los alquileres
        If (id = -1) Then
            consulta = "SELECT * FROM gestion_usuario"
        Else
            consulta = "SELECT * FROM gestion_usuario where id_usuario = @id_usuario"
        End If
        listaAlquileres.Clear()

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@id_usuario", id)
            Dim dt As New DataTable()
            adaptador.Fill(dt)

            For Each fila As DataRow In dt.Rows
                Dim alquiler As New Alquiler(
                        Convert.ToInt32(fila("id_gestion")),
                        Convert.ToInt32(fila("id_pelicula")),
                        Convert.ToInt32(fila("id_usuario")),
                        fila("fecha").ToString,
                        fila("estado").ToString,
                        Convert.ToInt32(fila("veces_alquilada")))
                listaAlquileres.Add(alquiler)
            Next
            Return listaAlquileres
        Catch ex As Exception
            MsgBox("Error al consultar clientes: " & ex.Message)
            Return Nothing
        End Try
    End Function

    'Obtener todos los usuarios
    Public Function obtenerUsuarios() As List(Of Persona)
        Dim listaPersonas As New List(Of Persona)
        Dim consulta As String = "SELECT * FROM persona"

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            Dim dt As New DataTable()
            adaptador.Fill(dt)

            'Separar las Personas y añadirlos como instancia de socio o administrador
            For Each fila As DataRow In dt.Rows
                If fila("tipo").ToString() = "socio" Then
                    Dim persona As New Socio(
                        Convert.ToInt32(fila("id")),
                        fila("nombre").ToString,
                        fila("usuario").ToString,
                        fila("contrasena").ToString,
                        fila("correo").ToString,
                        fila("fecha_nacimiento").ToString)
                    listaPersonas.Add(persona)
                Else
                    Dim persona As New Administrador(
                        Convert.ToInt32(fila("id")),
                        fila("nombre").ToString,
                        fila("usuario").ToString,
                        fila("contrasena").ToString,
                        fila("correo").ToString,
                        fila("fecha_nacimiento").ToString)
                    listaPersonas.Add(persona)
                End If
            Next
            Return listaPersonas
        Catch ex As Exception
            MsgBox("Error al consultar clientes: " & ex.Message)
            Return Nothing
        End Try
    End Function

    'Obtener un unico socio por su id
    Public Function obtenerSocioPorId(id As Integer) As Socio
        Dim socio As Socio = Nothing
        Dim consulta As String = "SELECT * FROM persona WHERE id = @id AND tipo = 'socio'"

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@id", id)

            Dim dt As New DataTable()
            adaptador.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim fila As DataRow = dt.Rows(0)
                socio = New Socio(
                Convert.ToInt32(fila("id")),
                Convert.ToString(fila("nombre")),
                Convert.ToString(fila("usuario")),
                "", ' Contraseña no se devuelve
                Convert.ToString(fila("correo")),
                Convert.ToString(fila("fecha_nacimiento"))
            )
                socio.Alquileres = obtenerAlquileres(socio.Id) ' Cargar los alquileres asociados
            End If
        Catch ex As Exception
            MsgBox("Error al consultar socio: " & ex.Message)
        End Try

        Return socio
    End Function

    'Eliminar un unico socio
    Public Function eliminarSocio(id As Integer) As Boolean
        Dim consulta As String = "DELETE FROM persona WHERE id = @id"

        Try
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id", id)

            Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
            Return filasAfectadas > 0 ' Retorna true si se eliminó algún registro
        Catch ex As Exception
            MsgBox("Error al eliminar socio: " & ex.Message)
            Return False
        End Try
    End Function

    'eliminar un alquiler
    Public Function eliminaralquiler(id As Integer) As Boolean
        Dim consulta As String = "DELETE FROM gestion_usuario WHERE id_gestion = @id"

        Try
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id", id)

            Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            MsgBox("Error al eliminar alquiler: " & ex.Message)
            Return False
        End Try
    End Function

    'obtener peliculas alquiladas
    Public Function obtenerPeliculasAlquiladas(idUsuario As Integer) As List(Of Pelicula)
        Dim listaPeliculas As New List(Of Pelicula)

        Dim consulta As String = "
        SELECT p.* 
        FROM pelicula p
        INNER JOIN gestion_usuario g ON p.id_pelicula = g.id_pelicula
        WHERE g.id_usuario = @id_usuario AND g.estado = 'Alquilada'"

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            obtenerResultadoConsulta(adaptador, idUsuario, listaPeliculas)

        Catch ex As Exception
            MsgBox("Error al obtener películas alquiladas: " & ex.Message)
        End Try

        Return listaPeliculas
    End Function
    'obtener peliculas no alquiladas
    Public Function obtenerPeliculasNoAlquiladas(idUsuario As Integer) As List(Of Pelicula)
        Dim listaPeliculas As New List(Of Pelicula)

        Dim consulta As String = "
            SELECT * FROM pelicula
            WHERE id_pelicula NOT IN (
                SELECT id_pelicula 
                FROM gestion_usuario WHERE id_usuario =@id_usuario And estado = 'Alquilada'
                );
            "

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            obtenerResultadoConsulta(adaptador, idUsuario, listaPeliculas)
        Catch ex As Exception
            MsgBox("Error al obtener películas no alquiladas: " & ex.StackTrace)
        End Try

        Return listaPeliculas
    End Function

    'Metodo auxiliar para obtener el resultado de una consulta.
    Private Sub obtenerResultadoConsulta(adaptador As SQLiteDataAdapter, idUsuario As Integer, listaPeliculas As List(Of Pelicula))
        adaptador.SelectCommand.Parameters.AddWithValue("@id_usuario", idUsuario)

        Dim dt As New DataTable()
        adaptador.Fill(dt)

        For Each fila As DataRow In dt.Rows
            Dim peli As New Pelicula(
            Convert.ToInt32(fila("id_pelicula")),
            fila("nombre").ToString(),
            convertirAImagen(CType(fila("imagen"), Byte())),
            fila("director").ToString(),
            Convert.ToInt32(fila("anio")),
            fila("genero").ToString(),
            Convert.ToInt32(fila("duracion")),
            Convert.ToInt32(fila("stock"))
        )
            peli.Trailer = fila("video").ToString()
            listaPeliculas.Add(peli)
        Next
    End Sub

    'crear un usuario
    Public Sub crearUsuario(persona As Persona)
        Dim tipo As String
        If TypeOf persona Is Socio Then
            tipo = "socio"
        ElseIf TypeOf persona Is Administrador Then
            tipo = "admin"
        End If
        Try
            Dim consulta As String = "INSERT INTO persona(usuario, nombre, contrasena, correo, fecha_nacimiento, tipo) VALUES (@usuario, @nombre, @contrasena, @correo, @fecha_nacimiento, @tipo)"

            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@usuario", persona.Usuario)
                comando.Parameters.AddWithValue("@nombre", persona.NombreCompleto)
                comando.Parameters.AddWithValue("@contrasena", persona.Contrasena)
                comando.Parameters.AddWithValue("@correo", persona.Correo)
                comando.Parameters.AddWithValue("@fecha_nacimiento", persona.FechaNacimiento)
                comando.Parameters.AddWithValue("@tipo", tipo)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al crear una persona: " & ex.Message)
        End Try
    End Sub

    'crear un alquiler
    Public Sub crearAlquiler(alquiler As Alquiler)
        Try
            Dim consulta As String = "Insert into gestion_usuario(id_pelicula, id_usuario, fecha, estado, veces_alquilada) values (@id_pelicula, @id_usuario, @fecha, @estado, @veces_alquilada)"
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id_pelicula", alquiler.IdPelicula)
            comando.Parameters.AddWithValue("@id_usuario", alquiler.IdSocio)
            comando.Parameters.AddWithValue("@fecha", alquiler.FechaAlquiler)
            comando.Parameters.AddWithValue("@estado", alquiler.Estado)
            comando.Parameters.AddWithValue("@veces_alquilada", alquiler.vecesAlquilada)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al crear el alquiler: " & ex.Message)
        End Try
    End Sub
    '------------------Gestionar Peliculas----------------------
    'Metodo que sirve para crear una pelicula
    Public Sub crearPelicula(Pelicula As Pelicula)
        Try
            Dim consulta As String = "insert into pelicula(nombre, imagen, director, anio, genero, duracion, stock, video) values (@nombre, @imagen, @director, @anio, @genero, @duracion, @stock, @video)"
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@nombre", Pelicula.Nombre)
            comando.Parameters.AddWithValue("@imagen", ConvertirABytes(Pelicula.Imagen))
            comando.Parameters.AddWithValue("@director", Pelicula.Director)
            comando.Parameters.AddWithValue("@anio", Pelicula.Anio)
            comando.Parameters.AddWithValue("@genero", Pelicula.Genero)
            comando.Parameters.AddWithValue("@duracion", Pelicula.Duracion)
            comando.Parameters.AddWithValue("@stock", Pelicula.Stock)
            If (Pelicula.Trailer <> "") Then
                comando.Parameters.AddWithValue("@video", Pelicula.Trailer)
            Else
                comando.Parameters.AddWithValue("@video", "")
            End If
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al crear la pelicula: " & ex.Message)
        End Try
    End Sub

    ' eliminar una pelicula de la base de datos.
    Public Sub eliminarPelicula(id As Integer)
        Try
            Dim consulta As String = "DELETE FROM pelicula WHERE id_pelicula = @id_pelicula"
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id_pelicula", id)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar la película: " & ex.Message)
        End Try
    End Sub

    ' Modificar una pelicula
    Public Sub modificarPelicula(pelicula As Pelicula)
        Try
            Dim consulta As String = "UPDATE pelicula SET " +
                              "nombre = COALESCE(NULLIF(@nombre, ''), nombre), " +
                              "imagen = COALESCE(NULLIF(@imagen, ''), imagen), " +
                              "director = COALESCE(NULLIF(@director, ''), director), " +
                              "anio = COALESCE(NULLIF(@anio, -1), anio), " +
                              "genero = COALESCE(NULLIF(@genero, ''), genero), " +
                              "duracion = COALESCE(NULLIF(@duracion, -1), duracion), " +
                              "stock = COALESCE(NULLIF(@stock, -1), stock), " +
                              "video = COALESCE(NULLIF(@video, ''), video) " +
                              "WHERE id_pelicula = @id_pelicula"
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id_pelicula", pelicula.Id)
            comando.Parameters.AddWithValue("@nombre", pelicula.Nombre)
            comando.Parameters.AddWithValue("@imagen", ConvertirABytes(pelicula.Imagen))
            comando.Parameters.AddWithValue("@director", pelicula.Director)
            comando.Parameters.AddWithValue("@anio", If(pelicula.Anio > 0, pelicula.Anio, -1))
            comando.Parameters.AddWithValue("@genero", pelicula.Genero)
            comando.Parameters.AddWithValue("@duracion", If(pelicula.Duracion > 0, pelicula.Duracion, -1))
            comando.Parameters.AddWithValue("@stock", If(pelicula.Stock >= 0, pelicula.Stock, -1))
            comando.Parameters.AddWithValue("@video", If(pelicula.Trailer <> "", pelicula.Trailer, ""))
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al modificar la película: " & ex.Message)
        End Try
    End Sub

    ' Obtener una unica pelicula por su id
    Public Function obtenerPeliculaPorId(id As Integer) As Pelicula
        Dim pelicula As Pelicula = Nothing
        Try
            Dim consulta As String = "SELECT * FROM pelicula WHERE id_pelicula = @id_pelicula"
            Dim adapter As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            adapter.SelectCommand.Parameters.AddWithValue("@id_pelicula", id)

            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)
                pelicula = New Pelicula(
                Convert.ToInt32(row("id_pelicula")),
                Convert.ToString(row("nombre")),
                convertirAImagen(row("imagen")),
                Convert.ToString(row("director")),
                Convert.ToInt32(row("anio")),
                Convert.ToString(row("genero")),
                Convert.ToInt32(row("duracion")),
                Convert.ToInt32(row("stock"))
            )
                pelicula.Trailer = Convert.ToString(row("video"))
            End If
        Catch ex As Exception
            MsgBox("Error al obtener la película: " & ex.Message)
        End Try
        Return pelicula
    End Function

    ' Eliminar alquiler en caso de borrar una pelicula o un socio
    Public Sub eliminarAlquileres(id As Integer, gestion As String)
        Dim consulta As String = If(gestion = "socio", "DELETE FROM gestion_usuario WHERE id_usuario = @id", "DELETE FROM gestion_usuario WHERE id_pelicula = @id")
        Try
            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al eliminar la película: " & ex.Message)
        End Try
    End Sub


    Public Sub actualizarGestionYPelicula(idGestion As Integer, tipoGestion As String, idPelicula As Integer)
        Dim consultaGestion As String
        Dim consultaPelicula As String
        Dim fechaHoy As String = DateTime.Now.ToString("dd/MM/yyyy")

        ' Definir consultas según el tipo de gestión
        If tipoGestion = "Alquilar" Then
            consultaGestion = "UPDATE gestion_usuario SET veces_alquilada = veces_alquilada + 1, estado = 'Alquilada', fecha = @fecha WHERE id_gestion = @id_gestion"
            consultaPelicula = "UPDATE pelicula SET stock = stock - 1 WHERE id_pelicula = @id_pelicula"
        ElseIf tipoGestion = "Devolver" Then
            consultaGestion = "UPDATE gestion_usuario SET estado = 'Devuelta', fecha = @fecha WHERE id_gestion = @id_gestion"
            consultaPelicula = "UPDATE pelicula SET stock = stock + 1 WHERE id_pelicula = @id_pelicula"
        Else
            MessageBox.Show("Tipo de gestión no válido.")
            Exit Sub
        End If

        ' Conexión y transacción
        Dim conexion As SQLiteConnection = ConexionDB.Conexion
        Dim transaccion As SQLiteTransaction = conexion.BeginTransaction()

        Try
            ' Actualizar tabla gestion_usuario
            Using comandoGestion As New SQLiteCommand(consultaGestion, conexion, transaccion)
                comandoGestion.Parameters.AddWithValue("@id_gestion", idGestion)
                comandoGestion.Parameters.AddWithValue("@fecha", fechaHoy) ' Asignar la fecha actual
                comandoGestion.ExecuteNonQuery()
            End Using

            ' Actualizar tabla pelicula
            Using comandoPelicula As New SQLiteCommand(consultaPelicula, conexion, transaccion)
                comandoPelicula.Parameters.AddWithValue("@id_pelicula", idPelicula)
                comandoPelicula.ExecuteNonQuery()
            End Using

            ' Confirmar transacción
            transaccion.Commit()
        Catch ex As Exception
            ' Si hay un error, deshacer cambios
            transaccion.Rollback()
            MessageBox.Show("Error al actualizar: " & ex.Message)
        End Try
    End Sub



    ' convertir byte que sale de la base de datos a image
    Private Function convertirAImagen(imageBytes As Byte()) As Image
        If imageBytes IsNot Nothing Then
            Using ms As New MemoryStream(imageBytes)
                Return Image.FromStream(ms)
            End Using
        Else
            Return Nothing
        End If
    End Function
    ' convertir imagen de la aplicacion para insertar a la base de datos como byte
    Public Function ConvertirABytes(img As Image) As Byte()
        If img Is Nothing Then Return Nothing

        Using ms As New MemoryStream()
            ' Clonar la imagen antes de guardarla
            Dim imagenClonada As Image = New Bitmap(img)
            imagenClonada.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
End Module
