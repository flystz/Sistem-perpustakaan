Public Class perpustakaan

    'variabel global koleksibuku
    Public Shared KoleksiBuku As KoleksiBuku
    Public Shared selectedTableKoleksi
    'Dim selectedTableKoleksi
    Dim selectedTableKoleksiNama

    'Public Shared update As update

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'manggil class koleksibuku
        KoleksiBuku = New KoleksiBuku()
        ReloadDataTableDatabase()
        'UpdateDataTableArrayList()

        'update = New update()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim tambah_koleksi = New tambah_koleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If (ListBoxKoleksi.SelectedIndex = -1) Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            Dim hapus_koleksi = New hapus_koleksi()
            hapus_koleksi.Show()
        End If
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah_koleksi = New tambah_koleksi()
        tambah_koleksi.Show()
    End Sub

    'ni di komen pas ada database
    Private Sub perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ListBoxKoleksi.Items.Clear()

        'For Each koll In KoleksiBuku.getKoleksiItem
        'ListBoxKoleksi.Items.Add(koll)
        'Next


        'UpdateDataTableArrayList()

    End Sub


    Public Sub UpdateDataTableArrayList()
        DataGridViewDB.Rows.Clear()
        For Each rowKoleksi In KoleksiBuku.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(4),
                                         rowKoleksi(3),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridViewDB.Rows.Add(dataTable)
        Next
    End Sub

    'ni dah ga dipake diganti yg db
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'selectedTableKoleksi = DataGridView1.CurrentRow.Index
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        'Dim dataselected = KoleksiBuku.getKoleksiDataTable.Item(selectedTableKoleksi)

        Dim dataselected As List(Of String) = KoleksiBuku.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        KoleksiBuku.GSFoto = dataselected(2)

        KoleksiBuku.GSNama = dataselected(1)
        KoleksiBuku.GSJenis = dataselected(5)
        KoleksiBuku.GSDeskripsi = dataselected(3)
        KoleksiBuku.GSPenerbit = dataselected(4)
        KoleksiBuku.GSTahunTerbit = dataselected(6)
        KoleksiBuku.GSLokasiRak = dataselected(7)
        KoleksiBuku.GSTanggal = dataselected(8)
        KoleksiBuku.GSStock = dataselected(9)
        KoleksiBuku.GSBahasa = dataselected(10)

        'MessageBox.Show(dataselected(10).ToString)
        Dim data_koleksi As List(Of String) = KoleksiBuku.ConvertStringToKoleksi(dataselected(11))

        For Each info_tambah In data_koleksi
            KoleksiBuku.AddKategori(info_tambah)
        Next

        Dim infoTambah = New info_tambah_koleksi()
        infoTambah.Show()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDB.DataSource = KoleksiBuku.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim dataselected As List(Of String) = KoleksiBuku.GetDataKoleksiByIDDatabase(selectedTableKoleksi)
        MessageBox.Show(selectedTableKoleksi)
        KoleksiBuku.GSFoto = dataselected(2)

        KoleksiBuku.GSNama = dataselected(1)
        KoleksiBuku.GSJenis = dataselected(5)
        KoleksiBuku.GSDeskripsi = dataselected(3)
        KoleksiBuku.GSPenerbit = dataselected(4)
        KoleksiBuku.GSTahunTerbit = dataselected(6)
        KoleksiBuku.GSLokasiRak = dataselected(7)
        KoleksiBuku.GSTanggal = dataselected(8)
        KoleksiBuku.GSStock = dataselected(9)
        KoleksiBuku.GSBahasa = dataselected(10)

        'MessageBox.Show(dataselected(10).ToString)
        Dim data_kategori As List(Of String) = KoleksiBuku.ConvertStringToKoleksi(dataselected(11))

        For Each info_kategori In data_kategori
            KoleksiBuku.AddKategori(info_kategori)
        Next

        'ni error aneh bisanya form tambah koleksi
        UpdateKoleksi.Show()

    End Sub

    Private Sub DataGridViewDB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDB.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewDB.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New hapus_koleksi()
        formHapus.Show()
    End Sub


End Class