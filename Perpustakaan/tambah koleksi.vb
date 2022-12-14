Imports System.IO
Public Class tambah_koleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DateTimePickerKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerKoleksi.CustomFormat = "yyyy/MM/dd"

    End Sub

    'Public Shared nama As String
    'Public Shared jenis As String
    'Public Shared deskripsi As String
    'Public Shared penerbit As String
    'Public Shared tahunterbit As String
    'Public Shared lokasirak As String
    'Public Shared tanggal As String
    'Public Shared stock As String
    Public Shared bahasa As String
    'Public Shared kategori As String = ""
    'Public Shared kategori_arrlist As New List(Of String)
    'Public Shared foto As String

    Private Sub TextBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukin Huruf yaaa")
        End If
    End Sub

    Private Sub TextBoxPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPenerbit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukin Huruf yaaa")
        End If
    End Sub

    Private Sub TextBoxTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukin Angka yaaa")
        End If
    End Sub

    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukin Angka yaaa")
        End If
    End Sub

    Private Sub RdInd_CheckedChanged(sender As Object, e As EventArgs) Handles RdInd.CheckedChanged
        bahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RdEng_CheckedChanged(sender As Object, e As EventArgs) Handles RdEng.CheckedChanged
        bahasa = "Bahasa Inggris"
    End Sub

    Private Sub BtnTambahFoto_Click(sender As Object, e As EventArgs) Handles BtnTambahfoto.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*bmp|Image JPG|*.JPG|Image JPEG|*.JPEG|Image PNG|*.PJG|Image GIF|*.GIF|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim pictKoleksiDir As String = OpenFileDialog1.FileName

        Pictfoto.Load(pictKoleksiDir)
        Pictfoto.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.KoleksiBuku.GSFoto = pictKoleksiDir.ToString
        perpustakaan.KoleksiBuku.GSFoto = perpustakaan.KoleksiBuku.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        '' Set Value (isi) Variabel class dari textbox, richtextbox, dan radiobutton
        '' ==================================================

        perpustakaan.KoleksiBuku.GSNama = TextBoxNama.Text
        perpustakaan.KoleksiBuku.GSJenis = ComboBoxJenis.Text
        perpustakaan.KoleksiBuku.GSDeskripsi = RichTextBoxDeskripsi.Text
        perpustakaan.KoleksiBuku.GSPenerbit = TextBoxPenerbit.Text
        perpustakaan.KoleksiBuku.GSTahunTerbit = TextBoxTahunTerbit.Text
        perpustakaan.KoleksiBuku.GSLokasiRak = TextBoxRak.Text
        perpustakaan.KoleksiBuku.GSTanggal = DateTimePickerKoleksi.Value.ToString("dd - MMMM - yyyy")
        perpustakaan.KoleksiBuku.GSStock = TextBoxStock.Text
        'perpustakaan.KoleksiBuku.GSBahasa = GroupBoxBahasa.Text

        '' cek radiobutton bahasa value
        '' ===================================================
        If RdInd.Checked Then
            perpustakaan.KoleksiBuku.GSBahasa = "Indonesia"
        ElseIf RdEng.Checked Then
            perpustakaan.KoleksiBuku.GSBahasa = "Inggris"
        End If

        '' cek checkbox value
        '' ===================================================

        If ChkSains.Checked() Then
            perpustakaan.KoleksiBuku.GSKategori.Add("Sains")
        End If
        If ChkSosial.Checked() Then
            perpustakaan.KoleksiBuku.GSKategori.Add("Sosial")
        End If
        If ChkTeknologi.Checked() Then
            perpustakaan.KoleksiBuku.GSKategori.Add("Teknologi")
        End If
        If ChkBudaya.Checked() Then
            perpustakaan.KoleksiBuku.GSKategori.Add("Budaya")
        End If

        perpustakaan.KoleksiBuku.AddKoleksi(TextBoxNama.Text.ToString)

        '' buka form tambah
        '' ===================================================

        Dim convertedKoleksi = perpustakaan.KoleksiBuku.ConvertKoleksiToString(perpustakaan.KoleksiBuku.getKategoriItem)
        perpustakaan.KoleksiBuku.AddDataKoleksiDatabase(
            perpustakaan.KoleksiBuku.GSFoto,
            perpustakaan.KoleksiBuku.GSNama,
            perpustakaan.KoleksiBuku.GSJenis,
            perpustakaan.KoleksiBuku.GSDeskripsi,
            perpustakaan.KoleksiBuku.GSPenerbit,
            perpustakaan.KoleksiBuku.GSTahunTerbit,
            perpustakaan.KoleksiBuku.GSLokasiRak,
            perpustakaan.KoleksiBuku.GSTanggal,
            perpustakaan.KoleksiBuku.GSStock,
            perpustakaan.KoleksiBuku.GSBahasa,
            convertedKoleksi)

        Dim add_item = perpustakaan.KoleksiBuku.GSNama
        perpustakaan.ListBoxKoleksi.Items.Add(add_item)

        Dim info_koleksi = New info_tambah_koleksi()
        info_koleksi.Show()

        Me.Close()

    End Sub
End Class