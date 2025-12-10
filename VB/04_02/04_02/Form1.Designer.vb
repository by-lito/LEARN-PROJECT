<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        btnCargar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        dgvVideojuegos = New DataGridView()
        TabPage2 = New TabPage()
        txtVideojuegoID = New TextBox()
        btnLimpiar2 = New Button()
        btnActualizar = New Button()
        btnAgregar = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtDesarrollador = New TextBox()
        txtPrecio = New TextBox()
        dtpFechaLanzamiento = New DateTimePicker()
        txtTitulo = New TextBox()
        Label1 = New Label()
        cmbPlataforma = New ComboBox()
        cmbGenero = New ComboBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvVideojuegos, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        TabControl1.Location = New Point(13, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 426)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.DimGray
        TabPage1.Controls.Add(txtBuscar)
        TabPage1.Controls.Add(btnBuscar)
        TabPage1.Controls.Add(btnCargar)
        TabPage1.Controls.Add(btnEliminar)
        TabPage1.Controls.Add(btnLimpiar)
        TabPage1.Controls.Add(dgvVideojuegos)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 397)
        TabPage1.TabIndex = 0
        TabPage1.Text = "LISTADO"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(155, 38)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(147, 22)
        txtBuscar.TabIndex = 5
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(6, 15)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(143, 66)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(308, 15)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(143, 66)
        btnCargar.TabIndex = 3
        btnCargar.Text = "CARGAR"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(457, 15)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(143, 66)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(606, 15)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(143, 66)
        btnLimpiar.TabIndex = 1
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' dgvVideojuegos
        ' 
        dgvVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVideojuegos.Location = New Point(6, 101)
        dgvVideojuegos.Name = "dgvVideojuegos"
        dgvVideojuegos.Size = New Size(756, 291)
        dgvVideojuegos.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(255, 192, 255)
        TabPage2.Controls.Add(txtVideojuegoID)
        TabPage2.Controls.Add(btnLimpiar2)
        TabPage2.Controls.Add(btnActualizar)
        TabPage2.Controls.Add(btnAgregar)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(txtDesarrollador)
        TabPage2.Controls.Add(txtPrecio)
        TabPage2.Controls.Add(dtpFechaLanzamiento)
        TabPage2.Controls.Add(txtTitulo)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(cmbPlataforma)
        TabPage2.Controls.Add(cmbGenero)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 397)
        TabPage2.TabIndex = 1
        TabPage2.Text = "DATOS"
        ' 
        ' txtVideojuegoID
        ' 
        txtVideojuegoID.Enabled = False
        txtVideojuegoID.Location = New Point(474, 28)
        txtVideojuegoID.Name = "txtVideojuegoID"
        txtVideojuegoID.Size = New Size(200, 22)
        txtVideojuegoID.TabIndex = 15
        txtVideojuegoID.Visible = False
        ' 
        ' btnLimpiar2
        ' 
        btnLimpiar2.Location = New Point(22, 312)
        btnLimpiar2.Name = "btnLimpiar2"
        btnLimpiar2.Size = New Size(143, 66)
        btnLimpiar2.TabIndex = 14
        btnLimpiar2.Text = "LIMPIAR"
        btnLimpiar2.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(22, 157)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(152, 75)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(22, 18)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(152, 75)
        btnAgregar.TabIndex = 12
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(348, 320)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 16)
        Label6.TabIndex = 11
        Label6.Text = "DESARROLLADOR"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(398, 267)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 16)
        Label5.TabIndex = 10
        Label5.Text = "PRECIO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(361, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 16)
        Label4.TabIndex = 9
        Label4.Text = "LANZAMIENTO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(398, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 16)
        Label3.TabIndex = 8
        Label3.Text = "PLATAFORMA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(398, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 16)
        Label2.TabIndex = 7
        Label2.Text = "GENERO"
        ' 
        ' txtDesarrollador
        ' 
        txtDesarrollador.Location = New Point(474, 312)
        txtDesarrollador.Name = "txtDesarrollador"
        txtDesarrollador.Size = New Size(100, 22)
        txtDesarrollador.TabIndex = 6
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(474, 259)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 22)
        txtPrecio.TabIndex = 5
        ' 
        ' dtpFechaLanzamiento
        ' 
        dtpFechaLanzamiento.Location = New Point(474, 209)
        dtpFechaLanzamiento.Name = "dtpFechaLanzamiento"
        dtpFechaLanzamiento.Size = New Size(200, 22)
        dtpFechaLanzamiento.TabIndex = 4
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(474, 70)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(200, 22)
        txtTitulo.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(398, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 16)
        Label1.TabIndex = 2
        Label1.Text = "TITULO"
        ' 
        ' cmbPlataforma
        ' 
        cmbPlataforma.FormattingEnabled = True
        cmbPlataforma.Location = New Point(503, 147)
        cmbPlataforma.Name = "cmbPlataforma"
        cmbPlataforma.Size = New Size(121, 24)
        cmbPlataforma.TabIndex = 1
        ' 
        ' cmbGenero
        ' 
        cmbGenero.FormattingEnabled = True
        cmbGenero.Location = New Point(503, 107)
        cmbGenero.Name = "cmbGenero"
        cmbGenero.Size = New Size(171, 24)
        cmbGenero.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvVideojuegos, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvVideojuegos As DataGridView
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dtpFechaLanzamiento As DateTimePicker
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPlataforma As ComboBox
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents txtDesarrollador As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpiar2 As Button
    Friend WithEvents txtVideojuegoID As TextBox

End Class
