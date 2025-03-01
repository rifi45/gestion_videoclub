<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquileres
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
        clmNumero = New ColumnHeader()
        clmidSocio = New ColumnHeader()
        clmPelicuka = New ColumnHeader()
        clmDirector = New ColumnHeader()
        clmFechaAlquiler = New ColumnHeader()
        clmEstado = New ColumnHeader()
        clmVecesAlquilada = New ColumnHeader()
        btnEliminar = New Button()
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
        Label1.Location = New Point(443, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 26)
        Label1.TabIndex = 1
        Label1.Text = "Alquileres"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {clmNumero, clmidSocio, clmPelicuka, clmDirector, clmFechaAlquiler, clmEstado, clmVecesAlquilada})
        ListView1.Location = New Point(70, 72)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(844, 388)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' clmNumero
        ' 
        clmNumero.Text = "Nº"
        clmNumero.Width = 30
        ' 
        ' clmidSocio
        ' 
        clmidSocio.Text = "Id Socio"
        clmidSocio.Width = 100
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
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(433, 486)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(128, 41)
        btnEliminar.TabIndex = 8
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' pBoxAtras
        ' 
        pBoxAtras.Cursor = Cursors.Hand
        pBoxAtras.Image = My.Resources.Resources.atras
        pBoxAtras.Location = New Point(12, 12)
        pBoxAtras.Name = "pBoxAtras"
        pBoxAtras.Size = New Size(42, 31)
        pBoxAtras.SizeMode = PictureBoxSizeMode.Zoom
        pBoxAtras.TabIndex = 58
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
        ' Alquileres
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 539)
        Controls.Add(pBoxInfo)
        Controls.Add(pBoxAtras)
        Controls.Add(btnEliminar)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Name = "Alquileres"
        Text = "Alquileres"
        CType(pBoxAtras, ComponentModel.ISupportInitialize).EndInit()
        CType(pBoxInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents clmNumero As ColumnHeader
    Friend WithEvents clmPelicuka As ColumnHeader
    Friend WithEvents clmDirector As ColumnHeader
    Friend WithEvents clmFechaAlquiler As ColumnHeader
    Friend WithEvents clmEstado As ColumnHeader
    Friend WithEvents clmVecesAlquilada As ColumnHeader
    Friend WithEvents btnEliminar As Button
    Friend WithEvents clmidSocio As ColumnHeader
    Friend WithEvents pBoxAtras As PictureBox
    Friend WithEvents pBoxInfo As PictureBox
End Class
