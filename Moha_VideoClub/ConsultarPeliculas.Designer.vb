<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarPeliculas
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
        ListView1 = New ListView()
        clmIdPelicula = New ColumnHeader()
        clmNombrePelicula = New ColumnHeader()
        clmDirector = New ColumnHeader()
        clmAnio = New ColumnHeader()
        clmGenero = New ColumnHeader()
        clmDuracion = New ColumnHeader()
        clmStock = New ColumnHeader()
        pBoxAtras = New PictureBox()
        CType(pBoxAtras, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(353, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 26)
        Label1.TabIndex = 0
        Label1.Text = "Consultar Peliculas"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {clmIdPelicula, clmNombrePelicula, clmDirector, clmAnio, clmGenero, clmDuracion, clmStock})
        ListView1.Location = New Point(49, 54)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(881, 473)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' clmIdPelicula
        ' 
        clmIdPelicula.Text = "Id"
        ' 
        ' clmNombrePelicula
        ' 
        clmNombrePelicula.Text = "Nombre Pelicula"
        clmNombrePelicula.Width = 120
        ' 
        ' clmDirector
        ' 
        clmDirector.Text = "Director"
        clmDirector.Width = 120
        ' 
        ' clmAnio
        ' 
        clmAnio.Text = "Año"
        clmAnio.Width = 120
        ' 
        ' clmGenero
        ' 
        clmGenero.Text = "Genero"
        clmGenero.Width = 120
        ' 
        ' clmDuracion
        ' 
        clmDuracion.Text = "Duracion"
        clmDuracion.Width = 120
        ' 
        ' clmStock
        ' 
        clmStock.Text = "Stock"
        clmStock.Width = 120
        ' 
        ' pBoxAtras
        ' 
        pBoxAtras.Cursor = Cursors.Hand
        pBoxAtras.Image = My.Resources.Resources.atras
        pBoxAtras.Location = New Point(12, 12)
        pBoxAtras.Name = "pBoxAtras"
        pBoxAtras.Size = New Size(42, 31)
        pBoxAtras.SizeMode = PictureBoxSizeMode.Zoom
        pBoxAtras.TabIndex = 57
        pBoxAtras.TabStop = False
        ' 
        ' ConsultarPeliculas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 539)
        Controls.Add(pBoxAtras)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Name = "ConsultarPeliculas"
        Text = "ConsultarPeliculas"
        CType(pBoxAtras, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents clmIdPelicula As ColumnHeader
    Friend WithEvents clmNombrePelicula As ColumnHeader
    Friend WithEvents clmDirector As ColumnHeader
    Friend WithEvents clmGenero As ColumnHeader
    Friend WithEvents clmAnio As ColumnHeader
    Friend WithEvents clmDuracion As ColumnHeader
    Friend WithEvents clmStock As ColumnHeader
    Friend WithEvents pBoxAtras As PictureBox
End Class
