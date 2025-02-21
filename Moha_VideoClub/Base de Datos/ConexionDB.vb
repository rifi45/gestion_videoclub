Imports System.Data.SQLite
Imports System.IO
Module ConexionDB
    Dim nombreBaseDatos As String = "Data Source=C:\Users\mohap\OneDrive\Documentos\2ºDAM\DesInt\moha_gestion_peliculas.db;Version=3;"
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

    '----Consultas a la base de datos----
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
                    convertirImagen(CType(fila("imagen"), Byte())),
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

    Public Function obtenerAlquileres(id As Integer) As List(Of Alquiler)
        Dim listaAlquileres As New List(Of Alquiler)
        Dim consulta As String = "SELECT * FROM gestion_usuario where id_usuario = @id_usuario"
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
    Public Function obtenerUsuarios() As List(Of Persona)
        Dim listaPersonas As New List(Of Persona)
        Dim consulta As String = "SELECT * FROM persona"

        Try
            Dim adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
            Dim dt As New DataTable()
                adaptador.Fill(dt)

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

    Private Sub obtenerResultadoConsulta(adaptador As SQLiteDataAdapter, idUsuario As Integer, listaPeliculas As List(Of Pelicula))
        adaptador.SelectCommand.Parameters.AddWithValue("@id_usuario", idUsuario)

        Dim dt As New DataTable()
        adaptador.Fill(dt)

        For Each fila As DataRow In dt.Rows
            Dim peli As New Pelicula(
            Convert.ToInt32(fila("id_pelicula")),
            fila("nombre").ToString(),
            convertirImagen(CType(fila("imagen"), Byte())),
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

    '----Insertar a la base de datos
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

    Public Sub actualizarGestionYPelicula(idGestion As Integer, tipoGestion As String, idPelicula As Integer)
        Dim consultaGestion As String
        Dim consultaPelicula As String

        ' Definir consultas según el tipo de gestión
        If tipoGestion = "Alquilar" Then
            consultaGestion = "UPDATE gestion_usuario SET veces_alquilada = veces_alquilada + 1, estado = 'Alquilada' WHERE id_gestion = @id_gestion"
            consultaPelicula = "UPDATE pelicula SET stock = stock - 1 WHERE id_pelicula = @id_pelicula"
        ElseIf tipoGestion = "Devolver" Then
            consultaGestion = "UPDATE gestion_usuario SET estado = 'Devuelta' WHERE id_gestion = @id_gestion"
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


    Private Function convertirImagen(imageBytes As Byte()) As Image
        If imageBytes IsNot Nothing Then
            Using ms As New MemoryStream(imageBytes)
                Return Image.FromStream(ms) ' Retorna la imagen
            End Using
        Else
            Return Nothing
        End If
    End Function
End Module
