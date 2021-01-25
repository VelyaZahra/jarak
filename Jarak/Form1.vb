Public Class Form1
    Private Per As New Bisa
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        Per.Kecepatan = CDec(txtkecepatan.Text)
        Per.Waktu = CDec(txtwaktu.Text)
        txtHasil.Text = Per.Hasil

    End Sub
End Class
