<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPeliculas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnModificar = New Button()
        btnConsultar = New Button()
        btnEliminar = New Button()
        btnAgregar = New Button()
        Label1 = New Label()
        pBoxImagen = New PictureBox()
        Portada = New Label()
        Label3 = New Label()
        txtNombre = New TextBox()
        Panel6 = New Panel()
        Label2 = New Label()
        txtDirector = New TextBox()
        Panel1 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        txtAnio = New TextBox()
        Panel3 = New Panel()
        Label6 = New Label()
        txtDuracion = New TextBox()
        Panel4 = New Panel()
        Label7 = New Label()
        txtStock = New TextBox()
        Panel5 = New Panel()
        Label8 = New Label()
        txtTrailer = New TextBox()
        Panel7 = New Panel()
        cBoxGenero = New ComboBox()
        Label9 = New Label()
        txtIdPelicula = New TextBox()
        Panel2 = New Panel()
        pBoxAtras = New PictureBox()
        pBoxInfo = New PictureBox()
        CType(pBoxImagen, ComponentModel.ISupportInitialize).BeginInit()
        CType(pBoxAtras, ComponentModel.ISupportInitialize).BeginInit()
        CType(pBoxInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnModificar
        ' 
        btnModificar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar.Location = New Point(290, 460)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(158, 48)
        btnModificar.TabIndex = 57
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConsultar.Location = New Point(516, 460)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(158, 48)
        btnConsultar.TabIndex = 56
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(742, 460)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(158, 48)
        btnEliminar.TabIndex = 55
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(69, 460)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(158, 48)
        btnAgregar.TabIndex = 54
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(402, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 26)
        Label1.TabIndex = 58
        Label1.Text = "Gestion Pelicula"
        ' 
        ' pBoxImagen
        ' 
        pBoxImagen.BackColor = SystemColors.ControlLight
        pBoxImagen.BorderStyle = BorderStyle.FixedSingle
        pBoxImagen.Location = New Point(255, 64)
        pBoxImagen.Name = "pBoxImagen"
        pBoxImagen.Size = New Size(117, 172)
        pBoxImagen.SizeMode = PictureBoxSizeMode.Zoom
        pBoxImagen.TabIndex = 59
        pBoxImagen.TabStop = False
        ' 
        ' Portada
        ' 
        Portada.AutoSize = True
        Portada.Font = New Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Portada.Location = New Point(126, 64)
        Portada.Name = "Portada"
        Portada.Size = New Size(77, 17)
        Portada.TabIndex = 60
        Portada.Text = "Portada *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(126, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 18)
        Label3.TabIndex = 63
        Label3.Text = "Nombre *"
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = SystemColors.Control
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(126, 325)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(286, 31)
        txtNombre.TabIndex = 61
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(126, 358)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(286, 1)
        Panel6.TabIndex = 62
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(126, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 66
        Label2.Text = "Director *"
        ' 
        ' txtDirector
        ' 
        txtDirector.BackColor = SystemColors.Control
        txtDirector.BorderStyle = BorderStyle.None
        txtDirector.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDirector.Location = New Point(126, 399)
        txtDirector.Multiline = True
        txtDirector.Name = "txtDirector"
        txtDirector.Size = New Size(286, 31)
        txtDirector.TabIndex = 64
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(126, 432)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(286, 1)
        Panel1.TabIndex = 65
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(582, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 18)
        Label4.TabIndex = 69
        Label4.Text = "Genero *"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(582, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 18)
        Label5.TabIndex = 72
        Label5.Text = "Año *"
        ' 
        ' txtAnio
        ' 
        txtAnio.BackColor = SystemColors.Control
        txtAnio.BorderStyle = BorderStyle.None
        txtAnio.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAnio.Location = New Point(582, 164)
        txtAnio.Multiline = True
        txtAnio.Name = "txtAnio"
        txtAnio.Size = New Size(286, 31)
        txtAnio.TabIndex = 70
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(582, 197)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(286, 1)
        Panel3.TabIndex = 71
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(582, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 18)
        Label6.TabIndex = 75
        Label6.Text = "Duracion *"
        ' 
        ' txtDuracion
        ' 
        txtDuracion.BackColor = SystemColors.Control
        txtDuracion.BorderStyle = BorderStyle.None
        txtDuracion.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDuracion.Location = New Point(582, 241)
        txtDuracion.Multiline = True
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(286, 31)
        txtDuracion.TabIndex = 73
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(582, 274)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(286, 1)
        Panel4.TabIndex = 74
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(582, 290)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 18)
        Label7.TabIndex = 78
        Label7.Text = "Stock *"
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = SystemColors.Control
        txtStock.BorderStyle = BorderStyle.None
        txtStock.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStock.Location = New Point(582, 313)
        txtStock.Multiline = True
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(286, 31)
        txtStock.TabIndex = 76
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(582, 346)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(286, 1)
        Panel5.TabIndex = 77
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(582, 363)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 18)
        Label8.TabIndex = 81
        Label8.Text = "Trailer enlace"
        ' 
        ' txtTrailer
        ' 
        txtTrailer.BackColor = SystemColors.Control
        txtTrailer.BorderStyle = BorderStyle.None
        txtTrailer.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTrailer.Location = New Point(582, 386)
        txtTrailer.Multiline = True
        txtTrailer.Name = "txtTrailer"
        txtTrailer.Size = New Size(286, 31)
        txtTrailer.TabIndex = 79
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(582, 419)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(286, 1)
        Panel7.TabIndex = 80
        ' 
        ' cBoxGenero
        ' 
        cBoxGenero.FormattingEnabled = True
        cBoxGenero.Location = New Point(582, 94)
        cBoxGenero.Name = "cBoxGenero"
        cBoxGenero.Size = New Size(286, 28)
        cBoxGenero.TabIndex = 83
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(126, 221)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 18)
        Label9.TabIndex = 86
        Label9.Text = "id Pelicula*"
        ' 
        ' txtIdPelicula
        ' 
        txtIdPelicula.BackColor = SystemColors.Control
        txtIdPelicula.BorderStyle = BorderStyle.None
        txtIdPelicula.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdPelicula.Location = New Point(126, 244)
        txtIdPelicula.Multiline = True
        txtIdPelicula.Name = "txtIdPelicula"
        txtIdPelicula.Size = New Size(286, 31)
        txtIdPelicula.TabIndex = 84
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(126, 277)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(286, 1)
        Panel2.TabIndex = 85
        ' 
        ' pBoxAtras
        ' 
        pBoxAtras.Cursor = Cursors.Hand
        pBoxAtras.Image = My.Resources.Resources.atras
        pBoxAtras.Location = New Point(12, 12)
        pBoxAtras.Name = "pBoxAtras"
        pBoxAtras.Size = New Size(42, 31)
        pBoxAtras.SizeMode = PictureBoxSizeMode.Zoom
        pBoxAtras.TabIndex = 87
        pBoxAtras.TabStop = False
        ' 
        ' pBoxInfo
        ' 
        pBoxInfo.Cursor = Cursors.Hand
        pBoxInfo.Image = My.Resources.Resources.boton_de_informacion
        pBoxInfo.Location = New Point(914, 12)
        pBoxInfo.Name = "pBoxInfo"
        pBoxInfo.Size = New Size(42, 42)
        pBoxInfo.SizeMode = PictureBoxSizeMode.Zoom
        pBoxInfo.TabIndex = 88
        pBoxInfo.TabStop = False
        ' 
        ' GestionPeliculas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 538)
        Controls.Add(pBoxInfo)
        Controls.Add(pBoxAtras)
        Controls.Add(Label9)
        Controls.Add(txtIdPelicula)
        Controls.Add(Panel2)
        Controls.Add(cBoxGenero)
        Controls.Add(Label8)
        Controls.Add(txtTrailer)
        Controls.Add(Panel7)
        Controls.Add(Label7)
        Controls.Add(txtStock)
        Controls.Add(Panel5)
        Controls.Add(Label6)
        Controls.Add(txtDuracion)
        Controls.Add(Panel4)
        Controls.Add(Label5)
        Controls.Add(txtAnio)
        Controls.Add(Panel3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(txtDirector)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(txtNombre)
        Controls.Add(Panel6)
        Controls.Add(Portada)
        Controls.Add(pBoxImagen)
        Controls.Add(Label1)
        Controls.Add(btnModificar)
        Controls.Add(btnConsultar)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Name = "GestionPeliculas"
        Text = "GestionPeliculas"
        CType(pBoxImagen, ComponentModel.ISupportInitialize).EndInit()
        CType(pBoxAtras, ComponentModel.ISupportInitialize).EndInit()
        CType(pBoxInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pBoxImagen As PictureBox
    Friend WithEvents Portada As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTrailer As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cBoxGenero As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdPelicula As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pBoxAtras As PictureBox
    Friend WithEvents pBoxInfo As PictureBox
End Class
