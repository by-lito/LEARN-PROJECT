Public Class Form1
    Private Sub rbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlanco.CheckedChanged
        MyBase.BackgroundImage = My.Resources._550e3548298b2533cb172ea7a3919dff
        pcbImagen.Image = My.Resources._550e3548298b2533cb172ea7a3919dff
    End Sub

    Private Sub rbRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rbRojo.CheckedChanged

        pcbImagen.Image = My.Resources._915c02c81d58825397a41c35a1c746771

    End Sub

    Private Sub rbAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAmarillo.CheckedChanged

        pcbImagen.Image = My.Resources._54f5bef818aacedcf5c372e70dd97f71
    End Sub

    Private Sub rbVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rbVerde.CheckedChanged

        pcbImagen.Image = My.Resources.d7f8d2749fa8ac67e25b78afa2fd9af0
    End Sub

    Private Sub rbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rbAzul.CheckedChanged

        pcbImagen.Image = My.Resources._240638e4bdf46a7969175fff63bd718a
    End Sub

    Private Sub rbPosArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rbPosArriba.CheckedChanged
        pcbImagen.Dock = DockStyle.None
        pcbImagen.Location = New Point(150, 0)
    End Sub

    Private Sub rbPosAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPosAbajo.CheckedChanged
        pcbImagen.Dock = DockStyle.None
        pcbImagen.Location = New Point(150, 300)
    End Sub

    Private Sub rbPosCentro_CheckedChanged(sender As Object, e As EventArgs) Handles rbPosCentro.CheckedChanged
        pcbImagen.Dock = DockStyle.None
        pcbImagen.Location = New Point(150, 150)
    End Sub

    Private Sub rbTamPequenio_CheckedChanged(sender As Object, e As EventArgs) Handles rbTamPequenio.CheckedChanged
        pcbImagen.Dock = DockStyle.None
        pcbImagen.Size = New Size(50, 50)

    End Sub

    Private Sub rbTamNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbTamNormal.CheckedChanged
        pcbImagen.Dock = DockStyle.None
        pcbImagen.Size = New Size(200, 200)

    End Sub

    Private Sub rbTamFull_CheckedChanged(sender As Object, e As EventArgs) Handles rbTamFull.CheckedChanged
        pcbImagen.Dock = DockStyle.Fill
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        MyBase.BackgroundImage = My.Resources._550e3548298b2533cb172ea7a3919dff
        pcbImagen.Image = My.Resources._550e3548298b2533cb172ea7a3919dff
        pcbImagen.Dock = DockStyle.Fill
        rbBlanco.Checked = True
        rbTamFull.Checked = True
        rbPosCentro.Checked = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub pcbImagen_Click(sender As Object, e As EventArgs) Handles pcbImagen.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
