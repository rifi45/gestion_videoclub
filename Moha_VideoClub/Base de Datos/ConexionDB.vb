Imports System.Data.SQLite
Imports System.IO
Module ConexionDB
    Dim nombreBaseDatos As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mohap\OneDrive\Documentos\2ºDAM\DesInt\moha_gestion_peliculas.db"
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
                MsgBox("Conexión cerrada correctamente.")

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

            Using adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
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
            End Using
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
            Using adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
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
            End Using
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
            Using adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
                Dim dt As New DataTable()
                adaptador.Fill(dt)

                For Each fila As DataRow In dt.Rows
                    Dim persona As New Persona(
                        Convert.ToInt32(fila("id")),
                        fila("nombre").ToString,
                        fila("usuario").ToString,
                        fila("contrasena").ToString,
                        fila("correo").ToString,
                        fila("fecha_nacimiento").ToString,
                        fila("tipo").ToString())
                    listaPersonas.Add(persona)
                Next
            End Using
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
            Using adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
                obtenerResultadoConsulta(adaptador, idUsuario, listaPeliculas)
            End Using
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
            Using adaptador As New SQLiteDataAdapter(consulta, ConexionDB.Conexion)
                obtenerResultadoConsulta(adaptador, idUsuario, listaPeliculas)
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener películas no alquiladas: " & ex.Message)
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
        Try
            Dim consulta As String = "INSERT INTO persona(usuario, nombre, contrasena, correo, fecha_nacimiento, tipo) VALUES (@usuario, @nombre, @contrasena, @correo, @fecha_nacimiento, @tipo)"

            Using comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
                comando.Parameters.AddWithValue("@usuario", persona.Usuario)
                comando.Parameters.AddWithValue("@nombre", persona.NombreCompleto)
                comando.Parameters.AddWithValue("@contrasena", persona.Contrasena)
                comando.Parameters.AddWithValue("@correo", persona.Correo)
                comando.Parameters.AddWithValue("@fecha_nacimiento", persona.FechaNacimiento)
                comando.Parameters.AddWithValue("@tipo", persona.Tipo)
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error al crear una persona: " & ex.StackTrace)
        End Try
    End Sub
    Public Sub crearAlquiler(alquiler As Alquiler)
        Dim consulta As String = ""
    End Sub
    Private Sub actualizarPelicula(tipoGestion As String, idPelicula As Integer)
        Try
            Dim consultaAlquilar = "UPDATE pelicula SET stock = stock - 1 WHERE id_pelicula = @id_pelicula"
            Dim consultaDevolver = "UPDATE pelicula SET stock = stock + 1 WHERE id_pelicula = @id_pelicula"

            Dim consulta As String = If(tipoGestion = "Alquilada", consultaAlquilar, consultaDevolver)

            Dim comando As New SQLiteCommand(consulta, ConexionDB.Conexion)
            comando.Parameters.AddWithValue("@id_pelicula", idPelicula)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar una pelicula" + ex.Message)
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
