<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblNombre = New Label()
        lblUser = New Label()
        Panel2 = New Panel()
        btnAlquilar = New Button()
        btnDevolver = New Button()
        btnHistorial = New Button()
        btnConsultarPelis = New Button()
        btnCerrarSesion = New Button()
        panelHistorico = New Panel()
        lblDevueltas = New Label()
        lblAlquiladas = New Label()
        Panel4 = New Panel()
        Label1 = New Label()
        ListView1 = New ListView()
        clmNumero = New ColumnHeader()
        clmPelicuka = New ColumnHeader()
        clmDirector = New ColumnHeader()
        clmFechaAlquiler = New ColumnHeader()
        clmEstado = New ColumnHeader()
        clmVecesAlquilada = New ColumnHeader()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelHistorico.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(219, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 520)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.hombre
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(67, 22)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(107, 19)
        lblNombre.TabIndex = 2
        lblNombre.Text = "nombreeee"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Lucida Bright", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = SystemColors.ControlText
        lblUser.Location = New Point(67, 53)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(83, 15)
        lblUser.TabIndex = 3
        lblUser.Text = "@nombreee"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(12, 95)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(190, 1)
        Panel2.TabIndex = 4
        ' 
        ' btnAlquilar
        ' 
        btnAlquilar.BackColor = SystemColors.Control
        btnAlquilar.Cursor = Cursors.Hand
        btnAlquilar.FlatAppearance.BorderSize = 0
        btnAlquilar.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnAlquilar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnAlquilar.FlatStyle = FlatStyle.Flat
        btnAlquilar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAlquilar.ForeColor = SystemColors.Highlight
        btnAlquilar.Location = New Point(0, 152)
        btnAlquilar.Name = "btnAlquilar"
        btnAlquilar.Size = New Size(217, 50)
        btnAlquilar.TabIndex = 5
        btnAlquilar.Text = "Alquilar"
        btnAlquilar.UseVisualStyleBackColor = False
        ' 
        ' btnDevolver
        ' 
        btnDevolver.BackColor = SystemColors.Control
        btnDevolver.Cursor = Cursors.Hand
        btnDevolver.FlatAppearance.BorderSize = 0
        btnDevolver.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnDevolver.FlatStyle = FlatStyle.Flat
        btnDevolver.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDevolver.ForeColor = SystemColors.Highlight
        btnDevolver.Location = New Point(0, 208)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(217, 50)
        btnDevolver.TabIndex = 6
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = False
        ' 
        ' btnHistorial
        ' 
        btnHistorial.BackColor = SystemColors.Control
        btnHistorial.Cursor = Cursors.Hand
        btnHistorial.FlatAppearance.BorderSize = 0
        btnHistorial.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnHistorial.FlatStyle = FlatStyle.Flat
        btnHistorial.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHistorial.ForeColor = SystemColors.Highlight
        btnHistorial.Location = New Point(0, 264)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(217, 50)
        btnHistorial.TabIndex = 8
        btnHistorial.Text = "Historial"
        btnHistorial.UseVisualStyleBackColor = False
        ' 
        ' btnConsultarPelis
        ' 
        btnConsultarPelis.BackColor = SystemColors.Control
        btnConsultarPelis.Cursor = Cursors.Hand
        btnConsultarPelis.FlatAppearance.BorderSize = 0
        btnConsultarPelis.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnConsultarPelis.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnConsultarPelis.FlatStyle = FlatStyle.Flat
        btnConsultarPelis.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConsultarPelis.ForeColor = SystemColors.Highlight
        btnConsultarPelis.Location = New Point(1, 98)
        btnConsultarPelis.Name = "btnConsultarPelis"
        btnConsultarPelis.Size = New Size(217, 50)
        btnConsultarPelis.TabIndex = 7
        btnConsultarPelis.Text = "Peliculas"
        btnConsultarPelis.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = SystemColors.Control
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = SystemColors.Highlight
        btnCerrarSesion.Location = New Point(1, 320)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(217, 50)
        btnCerrarSesion.TabIndex = 10
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' panelHistorico
        ' 
        panelHistorico.Controls.Add(lblDevueltas)
        panelHistorico.Controls.Add(lblAlquiladas)
        panelHistorico.Controls.Add(Panel4)
        panelHistorico.Controls.Add(Label1)
        panelHistorico.Controls.Add(ListView1)
        panelHistorico.Location = New Point(224, 12)
        panelHistorico.Name = "panelHistorico"
        panelHistorico.Size = New Size(744, 527)
        panelHistorico.TabIndex = 11
        ' 
        ' lblDevueltas
        ' 
        lblDevueltas.AutoSize = True
        lblDevueltas.Cursor = Cursors.Hand
        lblDevueltas.Font = New Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDevueltas.Location = New Point(636, 37)
        lblDevueltas.Name = "lblDevueltas"
        lblDevueltas.Size = New Size(83, 20)
        lblDevueltas.TabIndex = 14
        lblDevueltas.Text = "Devueltas"
        ' 
        ' lblAlquiladas
        ' 
        lblAlquiladas.AutoSize = True
        lblAlquiladas.Cursor = Cursors.Hand
        lblAlquiladas.Font = New Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlquiladas.Location = New Point(533, 37)
        lblAlquiladas.Name = "lblAlquiladas"
        lblAlquiladas.Size = New Size(90, 20)
        lblAlquiladas.TabIndex = 13
        lblAlquiladas.Text = "Alquiladas"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(629, 32)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1, 25)
        Panel4.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(14, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 23)
        Label1.TabIndex = 1
        Label1.Text = "Historico"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {clmNumero, clmPelicuka, clmDirector, clmFechaAlquiler, clmEstado, clmVecesAlquilada})
        ListView1.Location = New Point(14, 83)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(719, 437)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' clmNumero
        ' 
        clmNumero.Text = "Nº"
        clmNumero.Width = 30
        ' 
        ' clmPelicuka
        ' 
        clmPelicuka.Text = "Titulo"
        clmPelicuka.Width = 150
        ' 
        ' clmDirector
        ' 
        clmDirector.Text = "Director"
        clmDirector.Width = 140
        ' 
        ' clmFechaAlquiler
        ' 
        clmFechaAlquiler.Text = "Fecha Alquiler"
        clmFechaAlquiler.Width = 110
        ' 
        ' clmEstado
        ' 
        clmEstado.Text = "Estado"
        clmEstado.Width = 100
        ' 
        ' clmVecesAlquilada
        ' 
        clmVecesAlquilada.Text = "Veces Alquilada"
        clmVecesAlquilada.Width = 100
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 539)
        Controls.Add(panelHistorico)
        Controls.Add(btnCerrarSesion)
        Controls.Add(btnHistorial)
        Controls.Add(btnConsultarPelis)
        Controls.Add(btnDevolver)
        Controls.Add(btnAlquilar)
        Controls.Add(Panel2)
        Controls.Add(lblUser)
        Controls.Add(lblNombre)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelHistorico.ResumeLayout(False)
        panelHistorico.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAlquilar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnConsultarPelis As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnAtencion As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelHistorico As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDevueltas As Label
    Friend WithEvents lblAlquiladas As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents clmPelicuka As ColumnHeader
    Friend WithEvents clmDirector As ColumnHeader
    Friend WithEvents clmFechaAlquiler As ColumnHeader
    Friend WithEvents clmNumero As ColumnHeader
    Friend WithEvents clmId As ColumnHeader
    Friend WithEvents clmEstado As ColumnHeader
    Friend WithEvents clmVecesAlquilada As ColumnHeader
End Class
