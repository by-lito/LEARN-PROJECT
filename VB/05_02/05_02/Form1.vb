Imports System.Data.SqlClient

Imports System.Data


    Public Class Form1


        Dim connectionString As String = "Server=DAM209\SQLEXPRESS;Database=VideojuegosDB;Integrated Security=True;"

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                CargarGeneros()
                CargarPlataformas()
                CargarVideojuegos()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al iniciar: " & ex.Message)
            End Try
        End Sub

        ' Cargar los géneros en el ComboBox
        Private Sub CargarGeneros()
            Using cn As New SqlConnection(connectionString)
                Dim sql As String = "SELECT GeneroID, Nombre FROM Genero ORDER BY Nombre"
                Using cmd As New SqlCommand(sql, cn)
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cmbGenero.DisplayMember = "Nombre"
                    cmbGenero.ValueMember = "GeneroID"
                    cmbGenero.DataSource = dt
                End Using
            End Using
        End Sub

        ' Cargar las plataformas en el ComboBox
        Private Sub CargarPlataformas()
            Using cn As New SqlConnection(connectionString)
                Dim sql As String = "SELECT PlataformaID, Nombre FROM Plataforma ORDER BY Nombre"
                Using cmd As New SqlCommand(sql, cn)
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    cmbPlataforma.DisplayMember = "Nombre"
                    cmbPlataforma.ValueMember = "PlataformaID"
                    cmbPlataforma.DataSource = dt
                End Using
            End Using
        End Sub

        ' Cargar videojuegos en DataGridView
        Private Sub CargarVideojuegos(Optional filtro As String = "")
            Using cn As New SqlConnection(connectionString)
                Dim sql As String = "SELECT v.VideojuegoID, v.Titulo, g.Nombre AS Genero, p.Nombre AS Plataforma, v.FechaLanzamiento, v.Precio, v.Desarrollador, v.GeneroID, v.PlataformaID " &
                                "FROM Videojuego v " &
                                "INNER JOIN Genero g ON v.GeneroID = g.GeneroID " &
                                "INNER JOIN Plataforma p ON v.PlataformaID = p.PlataformaID "

                If Not String.IsNullOrWhiteSpace(filtro) Then
                    sql &= "WHERE v.Titulo LIKE @filtro "
                End If

                sql &= "ORDER BY v.Titulo"

                Using cmd As New SqlCommand(sql, cn)
                    If Not String.IsNullOrWhiteSpace(filtro) Then
                        cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    End If

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvVideojuegos.DataSource = dt

                    ' Ocultar columnas de ID foráneo si se quiere, pero mantenerlas para operaciones
                    If dgvVideojuegos.Columns.Contains("GeneroID") Then
                        dgvVideojuegos.Columns("GeneroID").Visible = False
                    End If
                    If dgvVideojuegos.Columns.Contains("PlataformaID") Then
                        dgvVideojuegos.Columns("PlataformaID").Visible = False
                    End If
                End Using
            End Using
        End Sub

        ' Limpiar campos del formulario
        Private Sub LimpiarCampos()
            txtVideojuegoID.Text = ""
            txtTitulo.Text = ""
            If cmbGenero.Items.Count > 0 Then cmbGenero.SelectedIndex = 0
            If cmbPlataforma.Items.Count > 0 Then cmbPlataforma.SelectedIndex = 0
            dtpFechaLanzamiento.Value = DateTime.Now
            dtpFechaLanzamiento.Checked = False ' permite un "null" visual si ShowCheckBox = True
            txtPrecio.Text = ""
            txtDesarrollador.Text = ""
        End Sub

        ' Evento clic: Cargar / Refrescar
        Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
            Try
                CargarGeneros()
                CargarPlataformas()
                CargarVideojuegos()
                MessageBox.Show("Datos cargados.")
            Catch ex As Exception
                MessageBox.Show("Error al cargar: " & ex.Message)
            End Try
        End Sub

        ' Agregar nuevo videojuego
        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
            Try
                Using cn As New SqlConnection(connectionString)
                    cn.Open()
                    Dim sql As String = "INSERT INTO Videojuego (Titulo, GeneroID, PlataformaID, FechaLanzamiento, Precio, Desarrollador) " &
                                    "VALUES (@Titulo, @GeneroID, @PlataformaID, @FechaLanzamiento, @Precio, @Desarrollador)"
                    Using cmd As New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim())
                        cmd.Parameters.AddWithValue("@GeneroID", Convert.ToInt32(cmbGenero.SelectedValue))
                        cmd.Parameters.AddWithValue("@PlataformaID", Convert.ToInt32(cmbPlataforma.SelectedValue))

                        If dtpFechaLanzamiento.ShowCheckBox AndAlso Not dtpFechaLanzamiento.Checked Then
                            cmd.Parameters.AddWithValue("@FechaLanzamiento", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@FechaLanzamiento", dtpFechaLanzamiento.Value.Date)
                        End If

                        If String.IsNullOrWhiteSpace(txtPrecio.Text) Then
                            cmd.Parameters.AddWithValue("@Precio", DBNull.Value)
                        Else
                            Dim precioDecimal As Decimal
                            If Decimal.TryParse(txtPrecio.Text, precioDecimal) Then
                                cmd.Parameters.AddWithValue("@Precio", precioDecimal)
                            Else
                                MessageBox.Show("Precio inválido.")
                                Return
                            End If
                        End If

                        If String.IsNullOrWhiteSpace(txtDesarrollador.Text) Then
                            cmd.Parameters.AddWithValue("@Desarrollador", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@Desarrollador", txtDesarrollador.Text.Trim())
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                CargarVideojuegos()
                LimpiarCampos()
                MessageBox.Show("Videojuego agregado.")
            Catch ex As Exception
                MessageBox.Show("Error al agregar: " & ex.Message)
            End Try
        End Sub

        ' Actualizar videojuego seleccionado
        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                If String.IsNullOrWhiteSpace(txtVideojuegoID.Text) Then
                    MessageBox.Show("Selecciona un videojuego para actualizar.")
                    Return
                End If

                Dim id As Integer = Convert.ToInt32(txtVideojuegoID.Text)

                Using cn As New SqlConnection(connectionString)
                    cn.Open()
                    Dim sql As String = "UPDATE Videojuego SET Titulo=@Titulo, GeneroID=@GeneroID, PlataformaID=@PlataformaID, FechaLanzamiento=@FechaLanzamiento, Precio=@Precio, Desarrollador=@Desarrollador WHERE VideojuegoID=@ID"
                    Using cmd As New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim())
                        cmd.Parameters.AddWithValue("@GeneroID", Convert.ToInt32(cmbGenero.SelectedValue))
                        cmd.Parameters.AddWithValue("@PlataformaID", Convert.ToInt32(cmbPlataforma.SelectedValue))

                        If dtpFechaLanzamiento.ShowCheckBox AndAlso Not dtpFechaLanzamiento.Checked Then
                            cmd.Parameters.AddWithValue("@FechaLanzamiento", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@FechaLanzamiento", dtpFechaLanzamiento.Value.Date)
                        End If

                        If String.IsNullOrWhiteSpace(txtPrecio.Text) Then
                            cmd.Parameters.AddWithValue("@Precio", DBNull.Value)
                        Else
                            Dim precioDecimal As Decimal
                            If Decimal.TryParse(txtPrecio.Text, precioDecimal) Then
                                cmd.Parameters.AddWithValue("@Precio", precioDecimal)
                            Else
                                MessageBox.Show("Precio inválido.")
                                Return
                            End If
                        End If

                        If String.IsNullOrWhiteSpace(txtDesarrollador.Text) Then
                            cmd.Parameters.AddWithValue("@Desarrollador", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@Desarrollador", txtDesarrollador.Text.Trim())
                        End If

                        cmd.Parameters.AddWithValue("@ID", id)

                        Dim filas As Integer = cmd.ExecuteNonQuery()
                        If filas = 0 Then
                            MessageBox.Show("No se actualizó (ID no encontrado).")
                        End If
                    End Using
                End Using

                CargarVideojuegos()
                LimpiarCampos()
                MessageBox.Show("Videojuego actualizado.")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message)
            End Try
        End Sub

        ' Eliminar videojuego
        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            Try
                If String.IsNullOrWhiteSpace(txtVideojuegoID.Text) Then
                    MessageBox.Show("Selecciona un videojuego para eliminar.")
                    Return
                End If

                If MessageBox.Show("¿Seguro que deseas eliminar este videojuego?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return
                End If

                Dim id As Integer = Convert.ToInt32(txtVideojuegoID.Text)

                Using cn As New SqlConnection(connectionString)
                    cn.Open()
                    Dim sql As String = "DELETE FROM Videojuego WHERE VideojuegoID = @ID"
                    Using cmd As New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@ID", id)
                        Dim filas As Integer = cmd.ExecuteNonQuery()
                        If filas = 0 Then
                            MessageBox.Show("No se eliminó (ID no encontrado).")
                        End If
                    End Using
                End Using

                CargarVideojuegos()
                LimpiarCampos()
                MessageBox.Show("Videojuego eliminado.")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try
        End Sub

        ' Limpiar
        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarCampos()
        End Sub
        Private Sub btnLimpiar2_Click(sender As Object, e As EventArgs) Handles btnLimpiar2.Click
            LimpiarCampos()
        End Sub

        ' Al seleccionar fila en el DataGridView, cargamos los datos en los controles
        Private Sub dgvVideojuegos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVideojuegos.SelectionChanged
            Try
                If dgvVideojuegos.SelectedRows.Count > 0 Then
                    Dim row As DataGridViewRow = dgvVideojuegos.SelectedRows(0)
                    If row.Cells("VideojuegoID").Value IsNot Nothing Then
                        txtVideojuegoID.Text = row.Cells("VideojuegoID").Value.ToString()
                        txtTitulo.Text = If(row.Cells("Titulo").Value IsNot Nothing, row.Cells("Titulo").Value.ToString(), "")
                        If dgvVideojuegos.Columns.Contains("GeneroID") Then
                            Dim genIDObj = row.Cells("GeneroID").Value
                            If genIDObj IsNot Nothing AndAlso Not IsDBNull(genIDObj) Then cmbGenero.SelectedValue = Convert.ToInt32(genIDObj)
                        End If
                        If dgvVideojuegos.Columns.Contains("PlataformaID") Then
                            Dim platIDObj = row.Cells("PlataformaID").Value
                            If platIDObj IsNot Nothing AndAlso Not IsDBNull(platIDObj) Then cmbPlataforma.SelectedValue = Convert.ToInt32(platIDObj)
                        End If
                        Dim fechaObj = row.Cells("FechaLanzamiento").Value
                        If fechaObj IsNot Nothing AndAlso Not IsDBNull(fechaObj) Then
                            dtpFechaLanzamiento.Value = Convert.ToDateTime(fechaObj)
                            dtpFechaLanzamiento.Checked = True
                        Else
                            dtpFechaLanzamiento.Checked = False
                        End If

                        Dim precioObj = row.Cells("Precio").Value
                        txtPrecio.Text = If(precioObj IsNot Nothing AndAlso Not IsDBNull(precioObj), precioObj.ToString(), "")

                        txtDesarrollador.Text = If(row.Cells("Desarrollador").Value IsNot Nothing, row.Cells("Desarrollador").Value.ToString(), "")
                    End If
                End If
            Catch ex As Exception
                ' No hacer crash por selección
            End Try
        End Sub

        ' (Opcional) Buscar por titulo si implementas txtBuscar y btnBuscar
        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            Try
                Dim criterio As String = txtBuscar.Text.Trim()
                CargarVideojuegos(criterio)
            Catch ex As Exception
                MessageBox.Show("Error al buscar: " & ex.Message)
            End Try
        End Sub

        Private Sub txtDesarrollador_TextChanged()

        End Sub

    End Class

