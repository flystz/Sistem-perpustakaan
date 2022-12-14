<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_koleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pictfoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahfoto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxRak = New System.Windows.Forms.TextBox()
        Me.DateTimePickerKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.RdEng = New System.Windows.Forms.RadioButton()
        Me.RdInd = New System.Windows.Forms.RadioButton()
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Pictfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBahasa.SuspendLayout()
        Me.GroupBoxKategori.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Koleksi"
        '
        'Pictfoto
        '
        Me.Pictfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pictfoto.Location = New System.Drawing.Point(14, 42)
        Me.Pictfoto.Name = "Pictfoto"
        Me.Pictfoto.Size = New System.Drawing.Size(100, 114)
        Me.Pictfoto.TabIndex = 1
        Me.Pictfoto.TabStop = False
        '
        'BtnTambahfoto
        '
        Me.BtnTambahfoto.Location = New System.Drawing.Point(25, 162)
        Me.BtnTambahfoto.Name = "BtnTambahfoto"
        Me.BtnTambahfoto.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahfoto.TabIndex = 2
        Me.BtnTambahfoto.Text = "Tambah"
        Me.BtnTambahfoto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(168, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Bahasa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(168, 447)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Kategori"
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(226, 613)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(99, 23)
        Me.BtnTambahKoleksi.TabIndex = 13
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(326, 39)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxNama.TabIndex = 14
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(326, 70)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(179, 23)
        Me.ComboBoxJenis.TabIndex = 15
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(326, 105)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(179, 80)
        Me.RichTextBoxDeskripsi.TabIndex = 16
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(326, 193)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxPenerbit.TabIndex = 17
        '
        'TextBoxTahunTerbit
        '
        Me.TextBoxTahunTerbit.Location = New System.Drawing.Point(326, 223)
        Me.TextBoxTahunTerbit.Name = "TextBoxTahunTerbit"
        Me.TextBoxTahunTerbit.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxTahunTerbit.TabIndex = 18
        '
        'TextBoxRak
        '
        Me.TextBoxRak.Location = New System.Drawing.Point(326, 254)
        Me.TextBoxRak.Name = "TextBoxRak"
        Me.TextBoxRak.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxRak.TabIndex = 19
        '
        'DateTimePickerKoleksi
        '
        Me.DateTimePickerKoleksi.Location = New System.Drawing.Point(326, 287)
        Me.DateTimePickerKoleksi.Name = "DateTimePickerKoleksi"
        Me.DateTimePickerKoleksi.Size = New System.Drawing.Size(179, 23)
        Me.DateTimePickerKoleksi.TabIndex = 20
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(326, 319)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxStock.TabIndex = 21
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RdEng)
        Me.GroupBoxBahasa.Controls.Add(Me.RdInd)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(326, 354)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(179, 86)
        Me.GroupBoxBahasa.TabIndex = 22
        Me.GroupBoxBahasa.TabStop = False
        Me.GroupBoxBahasa.Text = "Bahasa"
        '
        'RdEng
        '
        Me.RdEng.AutoSize = True
        Me.RdEng.Location = New System.Drawing.Point(11, 52)
        Me.RdEng.Name = "RdEng"
        Me.RdEng.Size = New System.Drawing.Size(101, 19)
        Me.RdEng.TabIndex = 1
        Me.RdEng.TabStop = True
        Me.RdEng.Text = "Bahasa Inggris"
        Me.RdEng.UseVisualStyleBackColor = True
        '
        'RdInd
        '
        Me.RdInd.AutoSize = True
        Me.RdInd.Location = New System.Drawing.Point(11, 27)
        Me.RdInd.Name = "RdInd"
        Me.RdInd.Size = New System.Drawing.Size(116, 19)
        Me.RdInd.TabIndex = 0
        Me.RdInd.TabStop = True
        Me.RdInd.Text = "Bahasa Indonesia"
        Me.RdInd.UseVisualStyleBackColor = True
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.ChkBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.ChkTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSosial)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(326, 447)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Size = New System.Drawing.Size(179, 129)
        Me.GroupBoxKategori.TabIndex = 23
        Me.GroupBoxKategori.TabStop = False
        Me.GroupBoxKategori.Text = "Kategori"
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(20, 98)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(65, 19)
        Me.ChkBudaya.TabIndex = 3
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(20, 73)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.ChkTeknologi.TabIndex = 2
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(20, 48)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(56, 19)
        Me.ChkSosial.TabIndex = 1
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(20, 23)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(53, 19)
        Me.ChkSains.TabIndex = 0
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tambah_koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(577, 648)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.DateTimePickerKoleksi)
        Me.Controls.Add(Me.TextBoxRak)
        Me.Controls.Add(Me.TextBoxTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambahfoto)
        Me.Controls.Add(Me.Pictfoto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tambah_koleksi"
        Me.Text = "tambah_koleksi"
        CType(Me.Pictfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Pictfoto As PictureBox
    Friend WithEvents BtnTambahfoto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents TextBoxTahunTerbit As TextBox
    Friend WithEvents TextBoxRak As TextBox
    Friend WithEvents DateTimePickerKoleksi As DateTimePicker
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents RdEng As RadioButton
    Friend WithEvents RdInd As RadioButton
    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
