<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIAdministrador
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
        btnCerrarSesionAdmin = New Button()
        btnVerSocios = New Button()
        btnGestionarPelis = New Button()
        btnVerPeliculas = New Button()
        btnGestionarSocios = New Button()
        Panel2 = New Panel()
        lblUser = New Label()
        lblNombre = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnHistoricoAdmin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrarSesionAdmin
        ' 
        btnCerrarSesionAdmin.BackColor = SystemColors.Control
        btnCerrarSesionAdmin.Cursor = Cursors.Hand
        btnCerrarSesionAdmin.FlatAppearance.BorderSize = 0
        btnCerrarSesionAdmin.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnCerrarSesionAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCerrarSesionAdmin.FlatStyle = FlatStyle.Flat
        btnCerrarSesionAdmin.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesionAdmin.ForeColor = SystemColors.Highlight
        btnCerrarSesionAdmin.Location = New Point(-1, 370)
        btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin"
        btnCerrarSesionAdmin.Size = New Size(217, 50)
        btnCerrarSesionAdmin.TabIndex = 20
        btnCerrarSesionAdmin.Text = "Cerrar Sesion"
        btnCerrarSesionAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnVerSocios
        ' 
        btnVerSocios.BackColor = SystemColors.Control
        btnVerSocios.Cursor = Cursors.Hand
        btnVerSocios.FlatAppearance.BorderSize = 0
        btnVerSocios.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnVerSocios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnVerSocios.FlatStyle = FlatStyle.Flat
        btnVerSocios.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerSocios.ForeColor = SystemColors.Highlight
        btnVerSocios.Location = New Point(-1, 258)
        btnVerSocios.Name = "btnVerSocios"
        btnVerSocios.Size = New Size(217, 50)
        btnVerSocios.TabIndex = 19
        btnVerSocios.Text = "Consultar Socios"
        btnVerSocios.UseVisualStyleBackColor = False
        ' 
        ' btnGestionarPelis
        ' 
        btnGestionarPelis.BackColor = SystemColors.Control
        btnGestionarPelis.Cursor = Cursors.Hand
        btnGestionarPelis.FlatAppearance.BorderSize = 0
        btnGestionarPelis.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnGestionarPelis.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnGestionarPelis.FlatStyle = FlatStyle.Flat
        btnGestionarPelis.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGestionarPelis.ForeColor = SystemColors.Highlight
        btnGestionarPelis.Location = New Point(-3, 94)
        btnGestionarPelis.Name = "btnGestionarPelis"
        btnGestionarPelis.Size = New Size(217, 50)
        btnGestionarPelis.TabIndex = 18
        btnGestionarPelis.Text = "Gestionar Peliculas"
        btnGestionarPelis.UseVisualStyleBackColor = False
        ' 
        ' btnVerPeliculas
        ' 
        btnVerPeliculas.BackColor = SystemColors.Control
        btnVerPeliculas.Cursor = Cursors.Hand
        btnVerPeliculas.FlatAppearance.BorderSize = 0
        btnVerPeliculas.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnVerPeliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnVerPeliculas.FlatStyle = FlatStyle.Flat
        btnVerPeliculas.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerPeliculas.ForeColor = SystemColors.Highlight
        btnVerPeliculas.Location = New Point(-1, 202)
        btnVerPeliculas.Name = "btnVerPeliculas"
        btnVerPeliculas.Size = New Size(217, 50)
        btnVerPeliculas.TabIndex = 17
        btnVerPeliculas.Text = "Consultar Peliculas"
        btnVerPeliculas.UseVisualStyleBackColor = False
        ' 
        ' btnGestionarSocios
        ' 
        btnGestionarSocios.BackColor = SystemColors.Control
        btnGestionarSocios.Cursor = Cursors.Hand
        btnGestionarSocios.FlatAppearance.BorderSize = 0
        btnGestionarSocios.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnGestionarSocios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnGestionarSocios.FlatStyle = FlatStyle.Flat
        btnGestionarSocios.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGestionarSocios.ForeColor = SystemColors.Highlight
        btnGestionarSocios.Location = New Point(-1, 146)
        btnGestionarSocios.Name = "btnGestionarSocios"
        btnGestionarSocios.Size = New Size(217, 50)
        btnGestionarSocios.TabIndex = 16
        btnGestionarSocios.Text = "Gestionar Socios"
        btnGestionarSocios.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(15, 87)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(190, 1)
        Panel2.TabIndex = 15
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Lucida Bright", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = SystemColors.ControlText
        lblUser.Location = New Point(70, 48)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(83, 15)
        lblUser.TabIndex = 14
        lblUser.Text = "@nombreee"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(70, 17)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(107, 19)
        lblNombre.TabIndex = 13
        lblNombre.Text = "nombreeee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.hombre
        PictureBox1.Location = New Point(15, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(216, 7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 520)
        Panel1.TabIndex = 11
        ' 
        ' btnHistoricoAdmin
        ' 
        btnHistoricoAdmin.BackColor = SystemColors.Control
        btnHistoricoAdmin.Cursor = Cursors.Hand
        btnHistoricoAdmin.FlatAppearance.BorderSize = 0
        btnHistoricoAdmin.FlatAppearance.MouseDownBackColor = SystemColors.Control
        btnHistoricoAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnHistoricoAdmin.FlatStyle = FlatStyle.Flat
        btnHistoricoAdmin.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHistoricoAdmin.ForeColor = SystemColors.Highlight
        btnHistoricoAdmin.Location = New Point(-1, 314)
        btnHistoricoAdmin.Name = "btnHistoricoAdmin"
        btnHistoricoAdmin.Size = New Size(217, 50)
        btnHistoricoAdmin.TabIndex = 21
        btnHistoricoAdmin.Text = "Historico"
        btnHistoricoAdmin.UseVisualStyleBackColor = False
        ' 
        ' UIAdministrador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 540)
        Controls.Add(btnHistoricoAdmin)
        Controls.Add(btnCerrarSesionAdmin)
        Controls.Add(btnVerSocios)
        Controls.Add(btnGestionarPelis)
        Controls.Add(btnVerPeliculas)
        Controls.Add(btnGestionarSocios)
        Controls.Add(Panel2)
        Controls.Add(lblUser)
        Controls.Add(lblNombre)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "UIAdministrador"
        Text = "UIAdministrador"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrarSesionAdmin As Button
    Friend WithEvents btnVerSocios As Button
    Friend WithEvents btnGestionarPelis As Button
    Friend WithEvents btnVerPeliculas As Button
    Friend WithEvents btnGestionarSocios As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHistoricoAdmin As Button
End Class
