Public Class UpdateKoleksi
    'Public Shared KoleksiBuku As KoleksiBuku
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'KoleksiBuku = New KoleksiBuku()

        Pictfoto.Load(perpustakaan.KoleksiBuku.GSFoto)
        Pictfoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerKoleksi.CustomFormat = "yyyy/MM/dd"
        TextBoxNama.Text = perpustakaan.KoleksiBuku.GSNama
        ComboBoxJenis.SelectedItem() = perpustakaan.KoleksiBuku.GSJenis
        RichTextBoxDeskripsi.Text = perpustakaan.KoleksiBuku.GSDeskripsi
        TextBoxPenerbit.Text = perpustakaan.KoleksiBuku.GSPenerbit
        TextBoxTahunTerbit.Text = perpustakaan.KoleksiBuku.GSTahunTerbit
        TextBoxRak.Text = perpustakaan.KoleksiBuku.GSLokasiRak
        DateTimePickerKoleksi.Value = perpustakaan.KoleksiBuku.GSTanggal
        TextBoxStock.Text = perpustakaan.KoleksiBuku.GSStock

        If String.Compare(perpustakaan.KoleksiBuku.GSBahasa, "Indonesia") = 0 Then
            RdInd.Checked = True
        ElseIf String.Compare(perpustakaan.KoleksiBuku.GSBahasa, "Inggris") = 0 Then
            RdEng.Checked = True
        End If

        For Each kategoriItem In perpustakaan.KoleksiBuku.getKategoriItem
            If String.Compare(kategoriItem, "Sains") = 0 Then
                ChkSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                ChkSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                ChkTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                ChkBudaya.Checked = True
            End If
        Next
        perpustakaan.KoleksiBuku.resetKategori()

    End Sub

    Private Sub BtnUpdatefoto_Click(sender As Object, e As EventArgs) Handles BtnUpdatefoto.Click
        OpenImageKoleksi.Title = "Open Foto"
        OpenImageKoleksi.Filter = "Image|*bmp|Image JPG|*.JPG|Image JPEG|*.JPEG|Image PNG|*.PJG|Image GIF|*.GIF|All Format|*.*"
        OpenImageKoleksi.ShowDialog()

        Dim pictKoleksiDir As String = OpenImageKoleksi.FileName

        Pictfoto.Load(pictKoleksiDir)
        Pictfoto.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.KoleksiBuku.GSFoto = pictKoleksiDir.ToString
        perpustakaan.KoleksiBuku.GSFoto = perpustakaan.KoleksiBuku.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        '' Set Value (isi) Variabel class dari textbox, richtextbox, dan radiobutton
        '' ==================================================

        perpustakaan.KoleksiBuku.GSNama = TextBoxNama.Text.ToString()
        perpustakaan.KoleksiBuku.GSJenis = ComboBoxJenis.SelectedItem().ToString()
        perpustakaan.KoleksiBuku.GSDeskripsi = RichTextBoxDeskripsi.Text.ToString()
        perpustakaan.KoleksiBuku.GSPenerbit = TextBoxPenerbit.Text.ToString()
        perpustakaan.KoleksiBuku.GSTahunTerbit = Integer.Parse(TextBoxTahunTerbit.Text)
        perpustakaan.KoleksiBuku.GSLokasiRak = TextBoxRak.Text.ToString()
        perpustakaan.KoleksiBuku.GSTanggal = DateTimePickerKoleksi.Value.ToString("dd - MMMM - yyyy")
        perpustakaan.KoleksiBuku.GSStock = Integer.Parse(TextBoxStock.Text)
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

        perpustakaan.KoleksiBuku.AddKoleksi(TextBoxNama.Text.ToString())

        '' buka form tambah
        '' ===================================================

        Dim convertedKoleksi = perpustakaan.KoleksiBuku.ConvertKoleksiToString(perpustakaan.KoleksiBuku.getKategoriItem)

        perpustakaan.KoleksiBuku.UpdateDataKoleksiByIDDatabase(perpustakaan.selectedTableKoleksi,
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

        Dim infoTambah = New info_tambah_koleksi() 'ini tu ngambil dri form
        infoTambah.Show()

        Me.Close()

    End Sub
End Class