<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionSocios
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
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtFechaNac = New TextBox()
        Panel10 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        txtAlquileres = New TextBox()
        Panel8 = New Panel()
        txtUsuario = New TextBox()
        Panel9 = New Panel()
        txtCorreo = New TextBox()
        Panel7 = New Panel()
        txtNombre = New TextBox()
        Panel6 = New Panel()
        btnEliminar = New Button()
        btnConsultar = New Button()
        Label2 = New Label()
        txtIdSocio = New TextBox()
        Panel1 = New Panel()
        pBoxAtras = New PictureBox()
        pBoxInfo = New PictureBox()
        CType(pBoxAtras, ComponentModel.ISupportInitialize).BeginInit()
        CType(pBoxInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(372, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 26)
        Label1.TabIndex = 0
        Label1.Text = "Gestion Socio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(528, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 18)
        Label7.TabIndex = 46
        Label7.Text = "Fecha De Nacimiento"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(528, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 18)
        Label6.TabIndex = 44
        Label6.Text = "Numero De Alquileres"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(528, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 18)
        Label5.TabIndex = 43
        Label5.Text = "Usuario"
        ' 
        ' txtFechaNac
        ' 
        txtFechaNac.BackColor = SystemColors.Control
        txtFechaNac.BorderStyle = BorderStyle.None
        txtFechaNac.Font = New Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFechaNac.Location = New Point(528, 370)
        txtFechaNac.Multiline = True
        txtFechaNac.Name = "txtFechaNac"
        txtFechaNac.ReadOnly = True
        txtFechaNac.Size = New Size(286, 31)
        txtFechaNac.TabIndex = 36
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.ActiveCaptionText
        Panel10.Location = New Point(528, 404)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(286, 1)
        Panel10.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(59, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 18)
        Label4.TabIndex = 42
        Label4.Text = "Correo Electronico"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(59, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 18)
        Label3.TabIndex = 41
        Label3.Text = "Nombre Completo"
        ' 
        ' txtAlquileres
        ' 
        txtAlquileres.BackColor = SystemColors.Control
        txtAlquileres.BorderStyle = BorderStyle.None
        txtAlquileres.Font = New Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAlquileres.Location = New Point(528, 255)
        txtAlquileres.Multiline = True
        txtAlquileres.Name = "txtAlquileres"
        txtAlquileres.ReadOnly = True
        txtAlquileres.Size = New Size(286, 31)
        txtAlquileres.TabIndex = 35
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(528, 288)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(286, 1)
        Panel8.TabIndex = 40
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = SystemColors.Control
        txtUsuario.BorderStyle = BorderStyle.None
        txtUsuario.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(528, 120)
        txtUsuario.Multiline = True
        txtUsuario.Name = "txtUsuario"
        txtUsuario.ReadOnly = True
        txtUsuario.Size = New Size(286, 31)
        txtUsuario.TabIndex = 33
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.ActiveCaptionText
        Panel9.Location = New Point(528, 153)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(286, 1)
        Panel9.TabIndex = 39
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = SystemColors.Control
        txtCorreo.BorderStyle = BorderStyle.None
        txtCorreo.Font = New Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCorreo.Location = New Point(59, 374)
        txtCorreo.Multiline = True
        txtCorreo.Name = "txtCorreo"
        txtCorreo.ReadOnly = True
        txtCorreo.Size = New Size(286, 31)
        txtCorreo.TabIndex = 34
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(59, 407)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(286, 1)
        Panel7.TabIndex = 38
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = SystemColors.Control
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(59, 255)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.ReadOnly = True
        txtNombre.Size = New Size(286, 31)
        txtNombre.TabIndex = 32
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(59, 288)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(286, 1)
        Panel6.TabIndex = 37
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(514, 443)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(158, 48)
        btnEliminar.TabIndex = 51
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Font = New Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConsultar.Location = New Point(233, 443)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(158, 48)
        btnConsultar.TabIndex = 52
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 55
        Label2.Text = "Id Socio *"
        ' 
        ' txtIdSocio
        ' 
        txtIdSocio.BackColor = SystemColors.Control
        txtIdSocio.BorderStyle = BorderStyle.None
        txtIdSocio.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdSocio.Location = New Point(59, 123)
        txtIdSocio.Multiline = True
        txtIdSocio.Name = "txtIdSocio"
        txtIdSocio.Size = New Size(286, 31)
        txtIdSocio.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(59, 156)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(286, 1)
        Panel1.TabIndex = 54
        ' 
        ' pBoxAtras
        ' 
        pBoxAtras.Cursor = Cursors.Hand
        pBoxAtras.Image = My.Resources.Resources.atras
        pBoxAtras.Location = New Point(12, 12)
        pBoxAtras.Name = "pBoxAtras"
        pBoxAtras.Size = New Size(42, 31)
        pBoxAtras.SizeMode = PictureBoxSizeMode.Zoom
        pBoxAtras.TabIndex = 56
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
        pBoxInfo.TabIndex = 89
        pBoxInfo.TabStop = False
        ' 
        ' GestionSocios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 539)
        Controls.Add(pBoxInfo)
        Controls.Add(pBoxAtras)
        Controls.Add(Label2)
        Controls.Add(txtIdSocio)
        Controls.Add(Panel1)
        Controls.Add(btnConsultar)
        Controls.Add(btnEliminar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtFechaNac)
        Controls.Add(Panel10)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAlquileres)
        Controls.Add(Panel8)
        Controls.Add(txtUsuario)
        Controls.Add(Panel9)
        Controls.Add(txtCorreo)
        Controls.Add(Panel7)
        Controls.Add(txtNombre)
        Controls.Add(Panel6)
        Controls.Add(Label1)
        Name = "GestionSocios"
        Text = "GestionAdmin"
        CType(pBoxAtras, ComponentModel.ISupportInitialize).EndInit()
        CType(pBoxInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAlquileres As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdSocio As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pBoxAtras As PictureBox
    Friend WithEvents pBoxInfo As PictureBox
End Class
