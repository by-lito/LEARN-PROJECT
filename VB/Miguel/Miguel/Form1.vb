Imports System.Data.SqlClient

Public Class Form1

        ' CADENA DE CONEXION A SQL SERVER
        Dim conexion As New SqlConnection(
        "Data Source=DAM209\SQLEXPRESS;Initial Catalog=GestionMatriculas;Integrated Security=True"
    )

        ' AL CARGAR EL FORMULARIO CARGAMOS LOS DATOS
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarAlumnos()
            CargarCursos()
            CargarAlumnosCombo()
            CargarMatriculas()
        End Sub

        ' CARGAR ALUMNOS EN EL DATAGRIDVIEW
        Sub CargarAlumnos()
            Dim da As New SqlDataAdapter("SELECT * FROM Alumnos", conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvAlumnos.DataSource = dt
        End Sub

        ' CARGAR CURSOS EN EL COMBOBOX
        Sub CargarCursos()
            Dim da As New SqlDataAdapter("SELECT * FROM Cursos", conexion)
            Dim dt As New DataTable
            da.Fill(dt)

            cmbCurso.DataSource = dt
            cmbCurso.DisplayMember = "NombreCurso"
            cmbCurso.ValueMember = "IdCurso"
        End Sub

        ' CARGAR ALUMNOS EN EL COMBOBOX DE MATRICULAS
        Sub CargarAlumnosCombo()
            Dim da As New SqlDataAdapter(
            "SELECT IdAlumno, Nombre + ' ' + Apellidos AS Alumno FROM Alumnos", conexion)

            Dim dt As New DataTable
            da.Fill(dt)

            cmbAlumno.DataSource = dt
            cmbAlumno.DisplayMember = "Alumno"
            cmbAlumno.ValueMember = "IdAlumno"
        End Sub

        ' CARGAR MATRÍCULAS EN EL DATAGRIDVIEW
        Sub CargarMatriculas()
            Dim da As New SqlDataAdapter(
        "SELECT m.IdMatricula,
                a.Nombre + ' ' + a.Apellidos AS Alumno,
                c.NombreCurso AS Curso,
                c.Precio,
                m.FechaMatricula
         FROM Matriculas m
         JOIN Alumnos a ON m.IdAlumno = a.IdAlumno
         JOIN Cursos c ON m.IdCurso = c.IdCurso",
        conexion)

            Dim dt As New DataTable
            da.Fill(dt)
            dgvMatriculas.DataSource = dt
        End Sub

    ' REGISTRAR UN ALUMNO NUEVO
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        ' VALIDAR CAMPOS VACIOS
        If txtNombre.Text = "" Or txtApellidos.Text = "" Or txtDNI.Text = "" Then
            MessageBox.Show("Rellena todos los campos")
            Exit Sub
        End If

        ' VALIDAR FORMATO DNI
        If Not ValidarDNI(txtDNI.Text) Then
            MessageBox.Show("DNI NO VALIDO. DEBE SER 8 NUMEROS Y UNA LETRA.")
            Exit Sub
        End If

        ' VALIDAR SI DNI YA EXISTE
        If DNIExiste(txtDNI.Text) Then
            MessageBox.Show("EL DNI YA ESTA REGISTRADO")
            Exit Sub
        End If

        Dim cmd As New SqlCommand(
    "INSERT INTO Alumnos (Nombre, Apellidos, DNI, FechaNacimiento)
     VALUES (@Nombre,@Apellidos,@DNI,@Fecha)", conexion)

        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text)
        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text)
        cmd.Parameters.AddWithValue("@Fecha", dtpFechaNacimiento.Value)

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        ' RECARGAR DATOS Y LIMPIAR CAMPOS
        CargarAlumnos()
        CargarAlumnosCombo()
        LimpiarCampos()

        MessageBox.Show("Alumno registrado correctamente")
    End Sub



    ' AL SELECCIONAR UN ALUMNO CARGAR SUS DATOS
    Private Sub dgvAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellClick
        If e.RowIndex >= 0 Then
            txtNombre.Text = dgvAlumnos.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            txtApellidos.Text = dgvAlumnos.Rows(e.RowIndex).Cells("Apellidos").Value.ToString()
            txtDNI.Text = dgvAlumnos.Rows(e.RowIndex).Cells("DNI").Value.ToString()

            ' VALIDAR QUE FECHA NO SEA NULL
            If IsDBNull(dgvAlumnos.Rows(e.RowIndex).Cells("FechaNacimiento").Value) Then
                dtpFechaNacimiento.Value = Date.Today
            Else
                dtpFechaNacimiento.Value = dgvAlumnos.Rows(e.RowIndex).Cells("FechaNacimiento").Value
            End If
        End If
    End Sub


    ' ELIMINAR ALUMNO SELECCIONADO
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            If dgvAlumnos.SelectedRows.Count = 0 Then Exit Sub

            Dim id As Integer = dgvAlumnos.SelectedRows(0).Cells("IdAlumno").Value

            Dim cmd As New SqlCommand(
        "DELETE FROM Alumnos WHERE IdAlumno=@Id", conexion)

            cmd.Parameters.AddWithValue("@Id", id)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            ' RECARGAR DATOS Y LIMPIAR CAMPOS
            CargarAlumnos()
            CargarAlumnosCombo()
            LimpiarCampos()
        End Sub

        ' MATRICULAR ALUMNO EN UN CURSO
        Private Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click

            ' VALIDAR SELECCION DE ALUMNO Y CURSO
            If cmbAlumno.SelectedIndex = -1 Or cmbCurso.SelectedIndex = -1 Then
                MessageBox.Show("Selecciona alumno y curso")
                Exit Sub
            End If

            ' INSERTAR LA MATRICULA
            Dim cmd As New SqlCommand(
        "INSERT INTO Matriculas (IdAlumno, IdCurso, FechaMatricula)
         VALUES (@Alumno,@Curso,GETDATE())", conexion)

            cmd.Parameters.AddWithValue("@Alumno", cmbAlumno.SelectedValue)
            cmd.Parameters.AddWithValue("@Curso", cmbCurso.SelectedValue)

            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()

            MessageBox.Show("Matrícula realizada correctamente")

            ' RECARGAR DATOS DE MATRICULAS
            CargarMatriculas()
        End Sub

    ' LIMPIAR LOS CAMPOS DE TEXTO
    Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtDNI.Clear()
        dtpFechaNacimiento.Value = Date.Today
    End Sub

    Function ValidarDNI(dni As String) As Boolean
        Dim patron As String = "^\d{8}[A-Za-z]$"
        Return System.Text.RegularExpressions.Regex.IsMatch(dni, patron)
    End Function

    Function DNIExiste(dni As String) As Boolean
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Alumnos WHERE DNI = @DNI", conexion)
        cmd.Parameters.AddWithValue("@DNI", dni)

        conexion.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conexion.Close()

        Return (count > 0)
    End Function



    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabMatriculas.Click

        End Sub

    End Class


