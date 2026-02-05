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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.tabAlumnos = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.tabMatriculas = New System.Windows.Forms.TabPage()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Matriculas1 = New Miguel.Matriculas()
        Me.dgvMatriculas = New System.Windows.Forms.DataGridView()
        Me.TabPrincipal.SuspendLayout()
        Me.tabAlumnos.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMatriculas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.tabAlumnos)
        Me.TabPrincipal.Controls.Add(Me.tabMatriculas)
        Me.TabPrincipal.Controls.Add(Me.TabPage1)
        Me.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(1200, 569)
        Me.TabPrincipal.TabIndex = 0
        '
        'tabAlumnos
        '
        Me.tabAlumnos.Controls.Add(Me.Label4)
        Me.tabAlumnos.Controls.Add(Me.btnEliminar)
        Me.tabAlumnos.Controls.Add(Me.btnRegistrar)
        Me.tabAlumnos.Controls.Add(Me.dtpFechaNacimiento)
        Me.tabAlumnos.Controls.Add(Me.Label3)
        Me.tabAlumnos.Controls.Add(Me.Label2)
        Me.tabAlumnos.Controls.Add(Me.Label1)
        Me.tabAlumnos.Controls.Add(Me.txtDNI)
        Me.tabAlumnos.Controls.Add(Me.txtApellidos)
        Me.tabAlumnos.Controls.Add(Me.txtNombre)
        Me.tabAlumnos.Controls.Add(Me.dgvAlumnos)
        Me.tabAlumnos.Location = New System.Drawing.Point(4, 22)
        Me.tabAlumnos.Name = "tabAlumnos"
        Me.tabAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlumnos.Size = New System.Drawing.Size(1192, 543)
        Me.tabAlumnos.TabIndex = 0
        Me.tabAlumnos.Text = "Alumnos"
        Me.tabAlumnos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(885, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(669, 63)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 32)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(493, 63)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(94, 32)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(997, 13)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(169, 24)
        Me.dtpFechaNacimiento.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(692, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(728, 13)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(145, 24)
        Me.txtDNI.TabIndex = 3
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(359, 13)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(291, 24)
        Me.txtApellidos.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(71, 13)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 24)
        Me.txtNombre.TabIndex = 1
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlumnos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlumnos.GridColor = System.Drawing.Color.White
        Me.dgvAlumnos.Location = New System.Drawing.Point(6, 123)
        Me.dgvAlumnos.MultiSelect = False
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlumnos.Size = New System.Drawing.Size(1183, 417)
        Me.dgvAlumnos.TabIndex = 0
        '
        'tabMatriculas
        '
        Me.tabMatriculas.Controls.Add(Me.dgvMatriculas)
        Me.tabMatriculas.Controls.Add(Me.btnMatricular)
        Me.tabMatriculas.Controls.Add(Me.Label6)
        Me.tabMatriculas.Controls.Add(Me.Label5)
        Me.tabMatriculas.Controls.Add(Me.cmbCurso)
        Me.tabMatriculas.Controls.Add(Me.cmbAlumno)
        Me.tabMatriculas.Location = New System.Drawing.Point(4, 22)
        Me.tabMatriculas.Name = "tabMatriculas"
        Me.tabMatriculas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMatriculas.Size = New System.Drawing.Size(1192, 543)
        Me.tabMatriculas.TabIndex = 1
        Me.tabMatriculas.Text = "Matrículas"
        Me.tabMatriculas.UseVisualStyleBackColor = True
        '
        'btnMatricular
        '
        Me.btnMatricular.BackColor = System.Drawing.Color.Black
        Me.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatricular.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnMatricular.ForeColor = System.Drawing.Color.White
        Me.btnMatricular.Location = New System.Drawing.Point(107, 357)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(107, 49)
        Me.btnMatricular.TabIndex = 4
        Me.btnMatricular.Text = "MATRICULAR"
        Me.btnMatricular.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(60, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(60, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Alumno"
        '
        'cmbCurso
        '
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(143, 136)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(121, 27)
        Me.cmbCurso.TabIndex = 1
        '
        'cmbAlumno
        '
        Me.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlumno.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Location = New System.Drawing.Point(143, 83)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(121, 27)
        Me.cmbAlumno.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1192, 543)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Informes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Matriculas1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1186, 537)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'dgvMatriculas
        '
        Me.dgvMatriculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMatriculas.BackgroundColor = System.Drawing.Color.White
        Me.dgvMatriculas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatriculas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMatriculas.GridColor = System.Drawing.Color.White
        Me.dgvMatriculas.Location = New System.Drawing.Point(315, 3)
        Me.dgvMatriculas.MultiSelect = False
        Me.dgvMatriculas.Name = "dgvMatriculas"
        Me.dgvMatriculas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMatriculas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMatriculas.Size = New System.Drawing.Size(873, 534)
        Me.dgvMatriculas.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 569)
        Me.Controls.Add(Me.TabPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(1216, 608)
        Me.MinimumSize = New System.Drawing.Size(1216, 608)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Matriculas"
        Me.TabPrincipal.ResumeLayout(False)
        Me.tabAlumnos.ResumeLayout(False)
        Me.tabAlumnos.PerformLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMatriculas.ResumeLayout(False)
        Me.tabMatriculas.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents tabAlumnos As TabPage
    Friend WithEvents tabMatriculas As TabPage
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMatricular As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Matriculas1 As Matriculas
    Friend WithEvents dgvMatriculas As DataGridView
End Class
