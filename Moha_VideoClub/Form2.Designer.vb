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
        btnAtencion = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnAlquilar.FlatAppearance.BorderSize = 0
        btnAlquilar.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnAlquilar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnAlquilar.FlatStyle = FlatStyle.Flat
        btnAlquilar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAlquilar.Location = New Point(1, 96)
        btnAlquilar.Name = "btnAlquilar"
        btnAlquilar.Size = New Size(217, 50)
        btnAlquilar.TabIndex = 5
        btnAlquilar.Text = "Alquilar"
        btnAlquilar.UseVisualStyleBackColor = False
        ' 
        ' btnDevolver
        ' 
        btnDevolver.BackColor = SystemColors.Control
        btnDevolver.FlatAppearance.BorderSize = 0
        btnDevolver.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnDevolver.FlatStyle = FlatStyle.Flat
        btnDevolver.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDevolver.Location = New Point(0, 152)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(217, 50)
        btnDevolver.TabIndex = 6
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = False
        ' 
        ' btnHistorial
        ' 
        btnHistorial.BackColor = SystemColors.Control
        btnHistorial.FlatAppearance.BorderSize = 0
        btnHistorial.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnHistorial.FlatStyle = FlatStyle.Flat
        btnHistorial.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        btnConsultarPelis.FlatAppearance.BorderSize = 0
        btnConsultarPelis.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnConsultarPelis.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnConsultarPelis.FlatStyle = FlatStyle.Flat
        btnConsultarPelis.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConsultarPelis.Location = New Point(0, 208)
        btnConsultarPelis.Name = "btnConsultarPelis"
        btnConsultarPelis.Size = New Size(217, 50)
        btnConsultarPelis.TabIndex = 7
        btnConsultarPelis.Text = "Peliculas"
        btnConsultarPelis.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = SystemColors.Control
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.Location = New Point(0, 377)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(217, 50)
        btnCerrarSesion.TabIndex = 10
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnAtencion
        ' 
        btnAtencion.BackColor = SystemColors.Control
        btnAtencion.FlatAppearance.BorderSize = 0
        btnAtencion.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnAtencion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnAtencion.FlatStyle = FlatStyle.Flat
        btnAtencion.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAtencion.Location = New Point(0, 321)
        btnAtencion.Name = "btnAtencion"
        btnAtencion.Size = New Size(217, 50)
        btnAtencion.TabIndex = 9
        btnAtencion.Text = "Atencion"
        btnAtencion.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 539)
        Controls.Add(btnCerrarSesion)
        Controls.Add(btnAtencion)
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
    Friend WithEvents PictureBox2 As PictureBox
End Class
