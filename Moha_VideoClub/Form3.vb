Imports System.Data.Entity.Infrastructure.Design
Imports AxWMPLib

Public Class Form3
    Public Pelicula As New Pelicula

    Private panelInfo As Panel
    Private panelTrailer As Panel
    Private wmpPlayer As AxWindowsMediaPlayer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Detalles de la Película"
        Me.Size = New Size(500, 350)
        Me.BackColor = SystemColors.Control

        panelInfo = New Panel With {
            .Size = New Size(460, 325),
            .Location = New Point(20, 20),
            .BackColor = SystemColors.Control
        }
        Me.Controls.Add(panelInfo)

        Dim lblNombrePelicula As New Label With {
            .Text = Pelicula.Nombre,
            .Font = New Font("Lucida Bright", 14, FontStyle.Bold),
            .Location = New Point(10, 20),
            .AutoSize = True
        }

        panelInfo.Controls.Add(lblNombrePelicula)

        Dim labels As New List(Of Label) From {
            CrearLabel("Director:", 20, 70),
            CrearLabel("Año:", 20, 100),
            CrearLabel("Género:", 20, 130),
            CrearLabel("Duración:", 20, 160),
            CrearLabel("Stock:", 20, 190)
        }

        Dim valores As New List(Of Label) From {
            CrearLabel(Pelicula.Director, 130, 70),
            CrearLabel(Pelicula.Anio, 130, 100),
            CrearLabel(Pelicula.Genero, 130, 130),
            CrearLabel(Pelicula.Duracion.ToString() & " min", 130, 160),
            CrearLabel(Pelicula.Stock.ToString(), 130, 190),
            CrearLabel("Ver Trailer.", 350, 200, Color.Blue, True)
        }

        Dim imgReproducir As New PictureBox With {
            .Image = Image.FromFile("C:\Users\mohap\Downloads\tocar.png"),
            .Size = New Size(40, 40),
            .Location = New Point(370, 230),
            .SizeMode = PictureBoxSizeMode.Zoom
            }
        panelInfo.Controls.Add(imgReproducir)

        AddHandler imgReproducir.Click, AddressOf VerTrailer


        For Each lbl In labels.Concat(valores)
            panelInfo.Controls.Add(lbl)
        Next

        panelTrailer = New Panel With {
            .Size = New Size(460, 300),
            .Location = New Point(20, 20),
            .BackColor = SystemColors.Control,
            .BorderStyle = BorderStyle.FixedSingle,
            .Visible = False
        }
        Me.Controls.Add(panelTrailer)

        wmpPlayer = New AxWindowsMediaPlayer()
        wmpPlayer.Dock = DockStyle.Fill
        wmpPlayer.Enabled = True
        panelTrailer.Controls.Add(wmpPlayer)
    End Sub
    Private Function CrearLabel(texto As String, x As Integer, y As Integer, Optional color As Color = Nothing, Optional esEnlace As Boolean = False) As Label
        Dim lbl As New Label With {
            .Text = texto,
            .Location = New Point(x, y),
            .Font = New Font("Lucida Bright", 10),
            .AutoSize = True,
            .ForeColor = If(color = Nothing, Color.Black, color)
        }

        Return lbl
    End Function

    Private Sub VerTrailer(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(Pelicula.Trailer) Then
            panelInfo.Visible = False
            panelTrailer.Visible = True
            wmpPlayer.URL = Pelicula.Trailer
            wmpPlayer.Ctlcontrols.play()
        Else
            MessageBox.Show("No hay un tráiler disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class



