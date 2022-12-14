<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.OpenImageKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.RdEng = New System.Windows.Forms.RadioButton()
        Me.RdInd = New System.Windows.Forms.RadioButton()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.DateTimePickerKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxRak = New System.Windows.Forms.TextBox()
        Me.TextBoxTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnUpdatefoto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pictfoto = New System.Windows.Forms.PictureBox()
        Me.GroupBoxKategori.SuspendLayout()
        Me.GroupBoxBahasa.SuspendLayout()
        CType(Me.Pictfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.ChkBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.ChkTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSosial)
        Me.GroupBoxKategori.Controls.Add(Me.ChkSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(471, 479)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Size = New System.Drawing.Size(179, 129)
        Me.GroupBoxKategori.TabIndex = 95
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
        'OpenImageKoleksi
        '
        Me.OpenImageKoleksi.FileName = "OpenFileDialog1"
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(364, 635)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(99, 23)
        Me.BtnUpdateKoleksi.TabIndex = 94
        Me.BtnUpdateKoleksi.Text = "Update Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RdEng)
        Me.GroupBoxBahasa.Controls.Add(Me.RdInd)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(471, 379)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(179, 86)
        Me.GroupBoxBahasa.TabIndex = 92
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
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(471, 344)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxStock.TabIndex = 91
        '
        'DateTimePickerKoleksi
        '
        Me.DateTimePickerKoleksi.Location = New System.Drawing.Point(471, 312)
        Me.DateTimePickerKoleksi.Name = "DateTimePickerKoleksi"
        Me.DateTimePickerKoleksi.Size = New System.Drawing.Size(179, 23)
        Me.DateTimePickerKoleksi.TabIndex = 90
        '
        'TextBoxRak
        '
        Me.TextBoxRak.Location = New System.Drawing.Point(471, 279)
        Me.TextBoxRak.Name = "TextBoxRak"
        Me.TextBoxRak.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxRak.TabIndex = 89
        '
        'TextBoxTahunTerbit
        '
        Me.TextBoxTahunTerbit.Location = New System.Drawing.Point(471, 248)
        Me.TextBoxTahunTerbit.Name = "TextBoxTahunTerbit"
        Me.TextBoxTahunTerbit.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxTahunTerbit.TabIndex = 88
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(471, 218)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxPenerbit.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(313, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Kategori"
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(471, 130)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(179, 80)
        Me.RichTextBoxDeskripsi.TabIndex = 86
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(471, 95)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(179, 23)
        Me.ComboBoxJenis.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(313, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(471, 64)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(179, 23)
        Me.TextBoxNama.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Jenis Koleksi"
        '
        'BtnUpdatefoto
        '
        Me.BtnUpdatefoto.Location = New System.Drawing.Point(170, 187)
        Me.BtnUpdatefoto.Name = "BtnUpdatefoto"
        Me.BtnUpdatefoto.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdatefoto.TabIndex = 74
        Me.BtnUpdatefoto.Text = "Tambah"
        Me.BtnUpdatefoto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(157, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Update Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Nama Koleksi"
        '
        'Pictfoto
        '
        Me.Pictfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pictfoto.Location = New System.Drawing.Point(159, 67)
        Me.Pictfoto.Name = "Pictfoto"
        Me.Pictfoto.Size = New System.Drawing.Size(100, 114)
        Me.Pictfoto.TabIndex = 73
        Me.Pictfoto.TabStop = False
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 662)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.DateTimePickerKoleksi)
        Me.Controls.Add(Me.TextBoxRak)
        Me.Controls.Add(Me.TextBoxTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnUpdatefoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pictfoto)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        CType(Me.Pictfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents OpenImageKoleksi As OpenFileDialog
    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents RdEng As RadioButton
    Friend WithEvents RdInd As RadioButton
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents DateTimePickerKoleksi As DateTimePicker
    Friend WithEvents TextBoxRak As TextBox
    Friend WithEvents TextBoxTahunTerbit As TextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnUpdatefoto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pictfoto As PictureBox
End Class
