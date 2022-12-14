Public Class info_tambah_koleksi

    Public Sub New()

        'ListBoxKategori.Items.Clear()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PictureBoxFoto.Load(perpustakaan.KoleksiBuku.GSFoto)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage

        LblNama.Text = perpustakaan.KoleksiBuku.GSNama
        LblDeskripsi.Text = perpustakaan.KoleksiBuku.GSDeskripsi
        LblPenerbit.Text = perpustakaan.KoleksiBuku.GSPenerbit
        LblTahunTerbit.Text = perpustakaan.KoleksiBuku.GSTahunTerbit
        LblRak.Text = perpustakaan.KoleksiBuku.GSLokasiRak
        LblTglMasuk.Text = perpustakaan.KoleksiBuku.GSTahunTerbit
        LblStock.Text = perpustakaan.KoleksiBuku.GSStock
        LblJenis.Text = perpustakaan.KoleksiBuku.GSJenis
        LblBahasa.Text = perpustakaan.KoleksiBuku.GSBahasa

        For Each info_tambah In perpustakaan.KoleksiBuku.getKategoriItem
            ListBoxKategori.Items.Add(info_tambah)
        Next

        ' For Each kel In perpustakaan.KoleksiBuku.GSKategori
        'ListBoxKategori.Items.Add(kel)
        'Next

        perpustakaan.KoleksiBuku.GSKategori.Clear()

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Dim add_item = perpustakaan.KoleksiBuku.GSNama
        perpustakaan.ListBoxKoleksi.Items.Add(add_item)
        Me.Close()
    End Sub
End Class