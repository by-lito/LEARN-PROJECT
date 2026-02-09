<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbColores = New System.Windows.Forms.GroupBox()
        Me.rbAzul = New System.Windows.Forms.RadioButton()
        Me.rbVerde = New System.Windows.Forms.RadioButton()
        Me.rbAmarillo = New System.Windows.Forms.RadioButton()
        Me.rbRojo = New System.Windows.Forms.RadioButton()
        Me.rbBlanco = New System.Windows.Forms.RadioButton()
        Me.gbPosicion = New System.Windows.Forms.GroupBox()
        Me.rbPosCentro = New System.Windows.Forms.RadioButton()
        Me.rbPosAbajo = New System.Windows.Forms.RadioButton()
        Me.rbPosArriba = New System.Windows.Forms.RadioButton()
        Me.gbTamanio = New System.Windows.Forms.GroupBox()
        Me.rbTamFull = New System.Windows.Forms.RadioButton()
        Me.rbTamNormal = New System.Windows.Forms.RadioButton()
        Me.rbTamPequenio = New System.Windows.Forms.RadioButton()
        Me.btnPDF = New System.Windows.Forms.Button()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbColores.SuspendLayout()
        Me.gbPosicion.SuspendLayout()
        Me.gbTamanio.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbImagen
        '
        Me.pcbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbImagen.Image = Global._02_03.My.Resources.Resources._550e3548298b2533cb172ea7a3919dff
        Me.pcbImagen.Location = New System.Drawing.Point(0, 0)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(514, 469)
        Me.pcbImagen.TabIndex = 3
        Me.pcbImagen.TabStop = False
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestablecer.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestablecer.Location = New System.Drawing.Point(312, 418)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(84, 23)
        Me.btnRestablecer.TabIndex = 4
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(416, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbColores
        '
        Me.gbColores.BackColor = System.Drawing.Color.Transparent
        Me.gbColores.Controls.Add(Me.rbAzul)
        Me.gbColores.Controls.Add(Me.rbVerde)
        Me.gbColores.Controls.Add(Me.rbAmarillo)
        Me.gbColores.Controls.Add(Me.rbRojo)
        Me.gbColores.Controls.Add(Me.rbBlanco)
        Me.gbColores.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbColores.Location = New System.Drawing.Point(15, 12)
        Me.gbColores.Name = "gbColores"
        Me.gbColores.Size = New System.Drawing.Size(476, 42)
        Me.gbColores.TabIndex = 6
        Me.gbColores.TabStop = False
        Me.gbColores.Text = "Colores"
        '
        'rbAzul
        '
        Me.rbAzul.AutoSize = True
        Me.rbAzul.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAzul.Location = New System.Drawing.Point(400, 20)
        Me.rbAzul.Name = "rbAzul"
        Me.rbAzul.Size = New System.Drawing.Size(46, 18)
        Me.rbAzul.TabIndex = 4
        Me.rbAzul.TabStop = True
        Me.rbAzul.Text = "Azul"
        Me.rbAzul.UseVisualStyleBackColor = True
        '
        'rbVerde
        '
        Me.rbVerde.AutoSize = True
        Me.rbVerde.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVerde.Location = New System.Drawing.Point(303, 20)
        Me.rbVerde.Name = "rbVerde"
        Me.rbVerde.Size = New System.Drawing.Size(50, 18)
        Me.rbVerde.TabIndex = 3
        Me.rbVerde.TabStop = True
        Me.rbVerde.Text = "Verde"
        Me.rbVerde.UseVisualStyleBackColor = True
        '
        'rbAmarillo
        '
        Me.rbAmarillo.AutoSize = True
        Me.rbAmarillo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAmarillo.Location = New System.Drawing.Point(206, 20)
        Me.rbAmarillo.Name = "rbAmarillo"
        Me.rbAmarillo.Size = New System.Drawing.Size(66, 18)
        Me.rbAmarillo.TabIndex = 2
        Me.rbAmarillo.TabStop = True
        Me.rbAmarillo.Text = "Amarillo"
        Me.rbAmarillo.UseVisualStyleBackColor = True
        '
        'rbRojo
        '
        Me.rbRojo.AutoSize = True
        Me.rbRojo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRojo.Location = New System.Drawing.Point(110, 20)
        Me.rbRojo.Name = "rbRojo"
        Me.rbRojo.Size = New System.Drawing.Size(47, 18)
        Me.rbRojo.TabIndex = 1
        Me.rbRojo.TabStop = True
        Me.rbRojo.Text = "Rojo"
        Me.rbRojo.UseVisualStyleBackColor = True
        '
        'rbBlanco
        '
        Me.rbBlanco.AutoSize = True
        Me.rbBlanco.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlanco.Location = New System.Drawing.Point(7, 20)
        Me.rbBlanco.Name = "rbBlanco"
        Me.rbBlanco.Size = New System.Drawing.Size(57, 18)
        Me.rbBlanco.TabIndex = 0
        Me.rbBlanco.TabStop = True
        Me.rbBlanco.Text = "Blanco"
        Me.rbBlanco.UseVisualStyleBackColor = True
        '
        'gbPosicion
        '
        Me.gbPosicion.BackColor = System.Drawing.Color.Transparent
        Me.gbPosicion.Controls.Add(Me.rbPosCentro)
        Me.gbPosicion.Controls.Add(Me.rbPosAbajo)
        Me.gbPosicion.Controls.Add(Me.rbPosArriba)
        Me.gbPosicion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPosicion.Location = New System.Drawing.Point(15, 60)
        Me.gbPosicion.Name = "gbPosicion"
        Me.gbPosicion.Size = New System.Drawing.Size(296, 44)
        Me.gbPosicion.TabIndex = 7
        Me.gbPosicion.TabStop = False
        Me.gbPosicion.Text = "Posición"
        '
        'rbPosCentro
        '
        Me.rbPosCentro.AutoSize = True
        Me.rbPosCentro.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPosCentro.Location = New System.Drawing.Point(201, 20)
        Me.rbPosCentro.Name = "rbPosCentro"
        Me.rbPosCentro.Size = New System.Drawing.Size(57, 18)
        Me.rbPosCentro.TabIndex = 2
        Me.rbPosCentro.TabStop = True
        Me.rbPosCentro.Text = "Centro"
        Me.rbPosCentro.UseVisualStyleBackColor = True
        '
        'rbPosAbajo
        '
        Me.rbPosAbajo.AutoSize = True
        Me.rbPosAbajo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPosAbajo.Location = New System.Drawing.Point(104, 20)
        Me.rbPosAbajo.Name = "rbPosAbajo"
        Me.rbPosAbajo.Size = New System.Drawing.Size(52, 18)
        Me.rbPosAbajo.TabIndex = 1
        Me.rbPosAbajo.TabStop = True
        Me.rbPosAbajo.Text = "Abajo"
        Me.rbPosAbajo.UseVisualStyleBackColor = True
        '
        'rbPosArriba
        '
        Me.rbPosArriba.AutoSize = True
        Me.rbPosArriba.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPosArriba.Location = New System.Drawing.Point(7, 20)
        Me.rbPosArriba.Name = "rbPosArriba"
        Me.rbPosArriba.Size = New System.Drawing.Size(54, 18)
        Me.rbPosArriba.TabIndex = 0
        Me.rbPosArriba.TabStop = True
        Me.rbPosArriba.Text = "Arriba"
        Me.rbPosArriba.UseVisualStyleBackColor = True
        '
        'gbTamanio
        '
        Me.gbTamanio.BackColor = System.Drawing.Color.Transparent
        Me.gbTamanio.Controls.Add(Me.rbTamFull)
        Me.gbTamanio.Controls.Add(Me.rbTamNormal)
        Me.gbTamanio.Controls.Add(Me.rbTamPequenio)
        Me.gbTamanio.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTamanio.Location = New System.Drawing.Point(15, 110)
        Me.gbTamanio.Name = "gbTamanio"
        Me.gbTamanio.Size = New System.Drawing.Size(296, 41)
        Me.gbTamanio.TabIndex = 8
        Me.gbTamanio.TabStop = False
        Me.gbTamanio.Text = "Tamaño"
        '
        'rbTamFull
        '
        Me.rbTamFull.AutoSize = True
        Me.rbTamFull.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTamFull.Location = New System.Drawing.Point(201, 20)
        Me.rbTamFull.Name = "rbTamFull"
        Me.rbTamFull.Size = New System.Drawing.Size(57, 18)
        Me.rbTamFull.TabIndex = 2
        Me.rbTamFull.TabStop = True
        Me.rbTamFull.Text = "Grande"
        Me.rbTamFull.UseVisualStyleBackColor = True
        '
        'rbTamNormal
        '
        Me.rbTamNormal.AutoSize = True
        Me.rbTamNormal.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTamNormal.Location = New System.Drawing.Point(104, 20)
        Me.rbTamNormal.Name = "rbTamNormal"
        Me.rbTamNormal.Size = New System.Drawing.Size(60, 18)
        Me.rbTamNormal.TabIndex = 1
        Me.rbTamNormal.TabStop = True
        Me.rbTamNormal.Text = "Normal"
        Me.rbTamNormal.UseVisualStyleBackColor = True
        '
        'rbTamPequenio
        '
        Me.rbTamPequenio.AutoSize = True
        Me.rbTamPequenio.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTamPequenio.Location = New System.Drawing.Point(7, 20)
        Me.rbTamPequenio.Name = "rbTamPequenio"
        Me.rbTamPequenio.Size = New System.Drawing.Size(64, 18)
        Me.rbTamPequenio.TabIndex = 0
        Me.rbTamPequenio.TabStop = True
        Me.rbTamPequenio.Text = "Pequeño"
        Me.rbTamPequenio.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDF.Location = New System.Drawing.Point(15, 179)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(84, 23)
        Me.btnPDF.TabIndex = 9
        Me.btnPDF.Text = "PDF Form"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._02_03.My.Resources.Resources._550e3548298b2533cb172ea7a3919dff
        Me.ClientSize = New System.Drawing.Size(514, 469)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.gbTamanio)
        Me.Controls.Add(Me.gbPosicion)
        Me.Controls.Add(Me.gbColores)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRestablecer)
        Me.Controls.Add(Me.pcbImagen)
        Me.Name = "Form1"
        Me.Text = "Cambio de Fondo"
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbColores.ResumeLayout(False)
        Me.gbColores.PerformLayout()
        Me.gbPosicion.ResumeLayout(False)
        Me.gbPosicion.PerformLayout()
        Me.gbTamanio.ResumeLayout(False)
        Me.gbTamanio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbColores As GroupBox
    Friend WithEvents rbAzul As RadioButton
    Friend WithEvents rbVerde As RadioButton
    Friend WithEvents rbAmarillo As RadioButton
    Friend WithEvents rbRojo As RadioButton
    Friend WithEvents rbBlanco As RadioButton
    Friend WithEvents gbPosicion As GroupBox
    Friend WithEvents rbPosCentro As RadioButton
    Friend WithEvents rbPosAbajo As RadioButton
    Friend WithEvents rbPosArriba As RadioButton
    Friend WithEvents gbTamanio As GroupBox
    Friend WithEvents rbTamFull As RadioButton
    Friend WithEvents rbTamNormal As RadioButton
    Friend WithEvents rbTamPequenio As RadioButton
    Friend WithEvents btnPDF As Button
End Class
