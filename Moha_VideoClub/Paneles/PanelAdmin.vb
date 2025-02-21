Imports System.Windows.Forms

Module PanelAdmin
    Dim panelGestion As New Panel
    Dim toolStrip As New ToolStrip

    Public Sub InicializarPanelAdmin(form As Form)
        ' Configurar el panel principal
        CrearPanel(panelGestion, New Size(600, 500), New Point(219, 30))

        ' Crear y agregar el menú tipo barra de herramientas
        CrearToolStrip(panelGestion)

        ' Agregar el panel al formulario
        form.Controls.Add(panelGestion)
    End Sub

    Private Sub CrearToolStrip(panel As Panel)
        toolStrip = New ToolStrip()

        ' Crear los elementos del menú
        Dim btnAgregar As New ToolStripButton("Agregar", Nothing, AddressOf AccionAgregar)
        Dim btnModificar As New ToolStripButton("Modificar", Nothing, AddressOf AccionModificar)
        Dim btnEliminar As New ToolStripButton("Eliminar", Nothing, AddressOf AccionEliminar)

        ' Agregar los elementos al ToolStrip
        toolStrip.Items.Add(btnAgregar)
        toolStrip.Items.Add(btnModificar)
        toolStrip.Items.Add(btnEliminar)

        ' Configuración visual
        toolStrip.Dock = DockStyle.Top ' Fijamos el menú arriba en el panel

        ' Agregar el ToolStrip al panel
        panel.Controls.Add(toolStrip)
    End Sub

    Private Sub CrearPanel(panel As Panel, size As Size, location As Point)
        panel.Size = size
        panel.Location = location
    End Sub

    ' Métodos de acción
    Private Sub AccionAgregar(sender As Object, e As EventArgs)
        MessageBox.Show("Agregar presionado")
    End Sub

    Private Sub AccionModificar(sender As Object, e As EventArgs)
        MessageBox.Show("Modificar presionado")
    End Sub

    Private Sub AccionEliminar(sender As Object, e As EventArgs)
        MessageBox.Show("Eliminar presionado")
    End Sub

End Module




