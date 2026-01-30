Public Class Form2
    Private Sub btnPDFElegir_Click(sender As Object, e As EventArgs) Handles btnPDFElegir.Click
        Dim ofd As New OpenFileDialog()

        ofd.Filter = "PDF Files (*.pdf)|*.pdf"
        ofd.Title = "Select a PDF file"

        If ofd.ShowDialog() = DialogResult.OK Then
            AxAcroPDF1.LoadFile(ofd.FileName)
            AxAcroPDF1.src = ofd.FileName
        End If
    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF1.Enter

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class