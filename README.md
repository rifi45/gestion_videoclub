# Moha VideoClub
Moha VideoClub es una aplicación de escritorio desarrollada en **Visual Basic .NET** con **SQLite** como base de datos. Permite a los usuarios alquilar y devolver películas, gestionar socios y consultar historiales de alquiler.

## A TENER EN CUENTA
Por favor, tenga en cuenta las rutas.
    Hay que cambiar las rutas para un funcionamiento correcto, abajo en el **apartado de estructura** del proyecto se indicarán las clases en cursiva y subrayadas donde se tiene que hacer el cambio de ruta.

Para visualizar los trailers, cambia la ruta en la columna video de la tabla película en el usuario, puesto que se guarda su ruta.

## Requisitos del proyecto
- **Visual Studio**
    - Utilizamos *Visual Studio* para el desarrollo de este proyecto, con el código en VB.Net
	```
	Microsoft Visual Studio Community 2022 (64 bits) - Current
	Versión 17.11.4
	```
    
- **SQLite**
    - Hemos utilizado SQLite para este proyecto, una base de datos relacional realizando consultas en SQL
	```
	«DB Browser for SQLite» Versión 3.12.2
	Compilado para x86_64-little_endian-llp64, ejecutándose en x86_64
	Versión de Qt 5.12.8
	Versión de SQLite 3.35.5.
	```
- **Windows Media Player**
    - Para la reproducción de trailers de las películas.

## Diseño de la Interfaz

La interfaz de la aplicación está diseñada para ser fácil de usar, con una barra de navegación accesible que permite al usuario moverse entre las distintas secciones de la aplicación.

### Parte Socio:
La sección de **Socio** está diseñada pensando en la facilidad de uso y la accesibilidad. Se centra en proporcionar una experiencia visual clara y simple para el usuario común, con un diseño amigable. El objetivo es que los socios puedan realizar sus acciones sin dificultad, incluso sin experiencia técnica. 

Para mejorar la **experiencia del usuario (UX)**, se ha utilizado una paleta de colores suaves, como tonos de azul y blanco. Además, se ha hecho un esfuerzo por mostrar las funcionalidades de manera intuitiva, con iconos claros y botones destacados que faciliten la navegación.

### Parte Administrador:
La sección de **Administrador** está diseñada pensando en la eficiencia y la profesionalidad. Dado que los administradores necesitan realizar funciones más complejas como la gestión de usuarios, películas y alquileres, la interfaz es más estructurada y orientada a la productividad. El diseño es clásico y funcional, con menús desplegables, formularios para agregar o modificar datos, y paneles informativos para ver estadísticas rápidas.

## Estructura del Proyecto
### Carpetas
#### Base de Datos
- <u>***ConexionDB.vb***</u>(Cambio de ruta de la base de datos)
Aquí es donde controlamos nuestra base de datos y nos conectamos a ella y hacemos ciertas consultas.

#### Datos
Aquí tenemos las clases que definen los datos de nuestro proyecto.
- **Pelicula.vb**
Clase que define a las películas
- **Alquiler.vb**
Clase que define a los alquileres
- **Persona.vb**
Clase que define a una persona y de ella heredan dos otras clases
    - **Socio.vb** Clase que define a nuestros socios
    - **Administrador.vb** Clase para nuestros administradores

#### Paneles
- **PanelSocios.vb** 
Aquí es donde tengo la lógica de los paneles usados en la parte de Socio

#### Forms
###### Parte Socio 
- **Form1** 
Formulario donde se inicia sesión y se crea la cuenta de un nuevo usuario

- **Form2**
Formulario donde podemos conectarnos solo si somos socios y realizar alquileres, devoluciones, consultas de películas y ver el historial del socio.

- **Form3**
Es un mini formulario donde podemos ver la información de una película y poder reproducir su Trailer en caso de que tenga.

###### Parte Administrador

- **UIAdministrador**
Aquí es donde tenemos la parte de administrador, y de ella podemos hacer gestiones. Solo accede a ella el administrador

- <u>***GestionPeliculas***</u>(Cambio de la ruta de generos.txt)
Aquí es donde gestionamos nuestras películas, podemos agregar, eliminar, actualizar y modificar una película.

- **GestionSocios**
Aquí es donde podemos ver la información de un socio, podemos eliminar al socio o solo consultar su información.

- **ConsultarPeliculas**
Aquí es donde podemos ver todas las películas.

- **Alquileres**
Aquí es donde podemos ver todos los alquileres y podemos eliminar uno.
## Base De Datos
Nuestra base de datos tiene 3 tablas para la gestion de este proyecto.

- **persona** : es una tabla que gestiona nuestros usuarios y separa al usuario según su tipo.
```sql
    CREATE TABLE "persona" (
	"id"	INTEGER,
	"nombre"	TEXT,
	"usuario"	TEXT NOT NULL UNIQUE,
	"contrasena"	TEXT NOT NULL,
	"correo"	TEXT,
	"fecha_nacimiento"	TEXT,
	"tipo"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
)
```
- **pelicula** : es la tabla que gestiona los datos de cada película, a destacar la columna video en la que no se guarda el BLOB se guarda un String para la ruta del video.
```sql
CREATE TABLE "pelicula" (
	"id_pelicula"	INTEGER,
	"nombre"	TEXT,
	"imagen"	BLOB,
	"director"	TEXT,
	"anio"	INTEGER,
	"genero"	TEXT,
	"duracion"	INTEGER,
	"stock"	INTEGER,
	"video"	TEXT,
	PRIMARY KEY("id_pelicula" AUTOINCREMENT)
)
```
- **gestion_usuario**: esta tabla es la que corresponde a nuestros alquileres.
```sql
    CREATE TABLE "gestion_usuario" (
        "id_gestion"	INTEGER,
        "id_pelicula"	INTEGER,
        "id_usuario"	INTEGER,
        "fecha"	TEXT,
        "estado"	TEXT,
        "veces_alquilada"	INTEGER,
        PRIMARY KEY("id_gestion" AUTOINCREMENT)
        )
```
## Resolución de Problemas

### El video no se reproduce en Windows Media Player
- Asegúrate de que la ruta del archivo del video sea correcta. Si el archivo está en una ubicación diferente, actualiza la ruta en la base de datos.
- Verifica que el control de Windows Media Player esté correctamente configurado.

### Errores comunes de base de datos
- Si tienes problemas con la base de datos, asegúrate de que la conexión esté correctamente configurada. Revisa que las rutas a las bases de datos sean correctas y que SQLite esté configurado correctamente en tu sistema.
