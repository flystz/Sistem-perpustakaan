Public Class hapus_koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LabelNama.Text = perpustakaan.KoleksiBuku.GSNama 'ini salah
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'perpustakaan.ListBoxKoleksi.Items.RemoveAt(perpustakaan.ListBoxKoleksi.SelectedIndex)

        perpustakaan.KoleksiBuku.DeleteDataKoleksiByIDDatabase(perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub

End Class