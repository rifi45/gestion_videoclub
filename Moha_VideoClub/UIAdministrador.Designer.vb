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
        MenuStrip1 = New MenuStrip()
        GestionesToolStripMenuItem = New ToolStripMenuItem()
        SociosToolStripMenuItem = New ToolStripMenuItem()
        PeliculaToolStripMenuItem = New ToolStripMenuItem()
        ConsultarToolStripMenuItem = New ToolStripMenuItem()
        PeliculasToolStripMenuItem = New ToolStripMenuItem()
        AlquileresToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesionToolStripMenuItem = New ToolStripMenuItem()
        panelBienvenida = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestionesToolStripMenuItem, ConsultarToolStripMenuItem, AlquileresToolStripMenuItem, CerrarSesionToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(968, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GestionesToolStripMenuItem
        ' 
        GestionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SociosToolStripMenuItem, PeliculaToolStripMenuItem})
        GestionesToolStripMenuItem.Name = "GestionesToolStripMenuItem"
        GestionesToolStripMenuItem.Size = New Size(87, 24)
        GestionesToolStripMenuItem.Text = "Gestiones"
        ' 
        ' SociosToolStripMenuItem
        ' 
        SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        SociosToolStripMenuItem.Size = New Size(142, 26)
        SociosToolStripMenuItem.Text = "Socio"
        ' 
        ' PeliculaToolStripMenuItem
        ' 
        PeliculaToolStripMenuItem.Name = "PeliculaToolStripMenuItem"
        PeliculaToolStripMenuItem.Size = New Size(142, 26)
        PeliculaToolStripMenuItem.Text = "Pelicula"
        ' 
        ' ConsultarToolStripMenuItem
        ' 
        ConsultarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeliculasToolStripMenuItem})
        ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        ConsultarToolStripMenuItem.Size = New Size(85, 24)
        ConsultarToolStripMenuItem.Text = "Consultar"
        ' 
        ' PeliculasToolStripMenuItem
        ' 
        PeliculasToolStripMenuItem.Name = "PeliculasToolStripMenuItem"
        PeliculasToolStripMenuItem.Size = New Size(148, 26)
        PeliculasToolStripMenuItem.Text = "Peliculas"
        ' 
        ' AlquileresToolStripMenuItem
        ' 
        AlquileresToolStripMenuItem.Name = "AlquileresToolStripMenuItem"
        AlquileresToolStripMenuItem.Size = New Size(89, 24)
        AlquileresToolStripMenuItem.Text = "Alquileres"
        ' 
        ' CerrarSesionToolStripMenuItem
        ' 
        CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        CerrarSesionToolStripMenuItem.Size = New Size(110, 24)
        CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        ' 
        ' panelBienvenida
        ' 
        panelBienvenida.Location = New Point(222, 122)
        panelBienvenida.Name = "panelBienvenida"
        panelBienvenida.Size = New Size(479, 270)
        panelBienvenida.TabIndex = 1
        ' 
        ' UIAdministrador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 540)
        Controls.Add(panelBienvenida)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "UIAdministrador"
        Text = "UIAdministrador"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquileresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelBienvenida As Panel
End Class
