<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perpustakaan))
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasiRak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggalTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bahasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.DataGridViewDB = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 15
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(203, 64)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(381, 154)
        Me.ListBoxKoleksi.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripBtnTambahKoleksi"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripBtnHapusKoleksi"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaKoleksi, Me.jenisKoleksi, Me.penerbit, Me.deskripsi, Me.tahunTerbit, Me.lokasiRak, Me.tanggalTerbit, Me.stock, Me.bahasa, Me.kategori})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(800, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'namaKoleksi
        '
        Me.namaKoleksi.HeaderText = "Nama Koleksi"
        Me.namaKoleksi.Name = "namaKoleksi"
        '
        'jenisKoleksi
        '
        Me.jenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.jenisKoleksi.Name = "jenisKoleksi"
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.Name = "penerbit"
        '
        'deskripsi
        '
        Me.deskripsi.HeaderText = "Deskripsi"
        Me.deskripsi.Name = "deskripsi"
        '
        'tahunTerbit
        '
        Me.tahunTerbit.HeaderText = "Tahun Terbit"
        Me.tahunTerbit.Name = "tahunTerbit"
        '
        'lokasiRak
        '
        Me.lokasiRak.HeaderText = "Lokasi Rak"
        Me.lokasiRak.Name = "lokasiRak"
        '
        'tanggalTerbit
        '
        Me.tanggalTerbit.HeaderText = "Tanggal Masuk"
        Me.tanggalTerbit.Name = "tanggalTerbit"
        '
        'stock
        '
        Me.stock.HeaderText = "Stok"
        Me.stock.Name = "stock"
        '
        'bahasa
        '
        Me.bahasa.HeaderText = "Bahasa"
        Me.bahasa.Name = "bahasa"
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSelect.Location = New System.Drawing.Point(627, 409)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(80, 29)
        Me.BtnSelect.TabIndex = 4
        Me.BtnSelect.Text = "Show"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUpdate.Location = New System.Drawing.Point(538, 409)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(83, 29)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRemove.Location = New System.Drawing.Point(713, 409)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(87, 29)
        Me.BtnRemove.TabIndex = 6
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'DataGridViewDB
        '
        Me.DataGridViewDB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDB.Location = New System.Drawing.Point(0, 236)
        Me.DataGridViewDB.Name = "DataGridViewDB"
        Me.DataGridViewDB.RowTemplate.Height = 25
        Me.DataGridViewDB.Size = New System.Drawing.Size(800, 150)
        Me.DataGridViewDB.TabIndex = 7
        '
        'perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewDB)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "perpustakaan"
        Me.Text = "perpustakaan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents tahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents lokasiRak As DataGridViewTextBoxColumn
    Friend WithEvents tanggalTerbit As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents bahasa As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents DataGridViewDB As DataGridView
End Class
