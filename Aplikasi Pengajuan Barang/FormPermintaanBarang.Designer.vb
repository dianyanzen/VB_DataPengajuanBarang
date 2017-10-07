<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPermintaanBarang
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPermintaanBarang))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmbnamapemohon = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbnamabarang = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtkodepermintaan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtjenisbarang = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel6.Controls.Add(Me.cmbnamapemohon)
        Me.Panel6.Location = New System.Drawing.Point(16, 179)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(216, 30)
        Me.Panel6.TabIndex = 46
        '
        'cmbnamapemohon
        '
        Me.cmbnamapemohon.BackColor = System.Drawing.Color.BlueViolet
        Me.cmbnamapemohon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbnamapemohon.ForeColor = System.Drawing.Color.White
        Me.cmbnamapemohon.FormattingEnabled = True
        Me.cmbnamapemohon.Items.AddRange(New Object() {"--Pilih Jenis Barang--", "Alat Tulis Kantor", "Elektronik", "Peralatan Kebersihan", "Peralatan Kebun", "Lainnya"})
        Me.cmbnamapemohon.Location = New System.Drawing.Point(0, 5)
        Me.cmbnamapemohon.Name = "cmbnamapemohon"
        Me.cmbnamapemohon.Size = New System.Drawing.Size(216, 21)
        Me.cmbnamapemohon.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel2.Controls.Add(Me.cmbnamabarang)
        Me.Panel2.Location = New System.Drawing.Point(16, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 30)
        Me.Panel2.TabIndex = 39
        '
        'cmbnamabarang
        '
        Me.cmbnamabarang.BackColor = System.Drawing.Color.BlueViolet
        Me.cmbnamabarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbnamabarang.ForeColor = System.Drawing.Color.White
        Me.cmbnamabarang.FormattingEnabled = True
        Me.cmbnamabarang.Items.AddRange(New Object() {"--Pilih Jenis Barang--", "Alat Tulis Kantor", "Elektronik", "Peralatan Kebersihan", "Peralatan Kebun", "Lainnya"})
        Me.cmbnamabarang.Location = New System.Drawing.Point(0, 5)
        Me.cmbnamabarang.Name = "cmbnamabarang"
        Me.cmbnamabarang.Size = New System.Drawing.Size(216, 21)
        Me.cmbnamabarang.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Location = New System.Drawing.Point(273, 75)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 30)
        Me.Panel4.TabIndex = 52
        '
        'txtjumlah
        '
        Me.txtjumlah.BackColor = System.Drawing.Color.BlueViolet
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.ForeColor = System.Drawing.Color.White
        Me.txtjumlah.Location = New System.Drawing.Point(15, 5)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(184, 19)
        Me.txtjumlah.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.BlueViolet
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(0, 8)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 13)
        Me.TextBox3.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel3.Controls.Add(Me.txtkodepermintaan)
        Me.Panel3.Location = New System.Drawing.Point(16, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(216, 30)
        Me.Panel3.TabIndex = 40
        '
        'txtkodepermintaan
        '
        Me.txtkodepermintaan.BackColor = System.Drawing.Color.BlueViolet
        Me.txtkodepermintaan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtkodepermintaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodepermintaan.ForeColor = System.Drawing.Color.White
        Me.txtkodepermintaan.Location = New System.Drawing.Point(10, 5)
        Me.txtkodepermintaan.Name = "txtkodepermintaan"
        Me.txtkodepermintaan.ReadOnly = True
        Me.txtkodepermintaan.Size = New System.Drawing.Size(184, 19)
        Me.txtkodepermintaan.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 43)
        Me.Panel1.TabIndex = 37
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 11)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(238, 22)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "Form Permintaan Barang"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel8.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel8.Controls.Add(Me.BunifuImageButton4)
        Me.Panel8.Location = New System.Drawing.Point(101, 233)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(79, 28)
        Me.Panel8.TabIndex = 55
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(31, 7)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(42, 13)
        Me.BunifuCustomLabel8.TabIndex = 16
        Me.BunifuCustomLabel8.Text = "Simpan"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel7.Controls.Add(Me.BunifuImageButton2)
        Me.Panel7.Location = New System.Drawing.Point(16, 233)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(79, 28)
        Me.Panel7.TabIndex = 54
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(35, 7)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(25, 13)
        Me.BunifuCustomLabel7.TabIndex = 16
        Me.BunifuCustomLabel7.Text = "Edit"
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg.GridColor = System.Drawing.Color.White
        Me.dg.Location = New System.Drawing.Point(0, 267)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(738, 176)
        Me.dg.TabIndex = 53
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel9.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel9.Controls.Add(Me.BunifuImageButton5)
        Me.Panel9.Location = New System.Drawing.Point(184, 233)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(79, 28)
        Me.Panel9.TabIndex = 56
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(31, 7)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(38, 13)
        Me.BunifuCustomLabel9.TabIndex = 16
        Me.BunifuCustomLabel9.Text = "Hapus"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel10.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel10.Controls.Add(Me.BunifuImageButton6)
        Me.Panel10.Location = New System.Drawing.Point(269, 233)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(79, 28)
        Me.Panel10.TabIndex = 57
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(31, 7)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(37, 13)
        Me.BunifuCustomLabel10.TabIndex = 16
        Me.BunifuCustomLabel10.Text = "Keluar"
        '
        'txtjenisbarang
        '
        Me.txtjenisbarang.BackColor = System.Drawing.Color.BlueViolet
        Me.txtjenisbarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtjenisbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenisbarang.ForeColor = System.Drawing.Color.White
        Me.txtjenisbarang.Location = New System.Drawing.Point(15, 5)
        Me.txtjenisbarang.Name = "txtjenisbarang"
        Me.txtjenisbarang.ReadOnly = True
        Me.txtjenisbarang.Size = New System.Drawing.Size(184, 19)
        Me.txtjenisbarang.TabIndex = 2
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(13, 163)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(83, 13)
        Me.BunifuCustomLabel6.TabIndex = 49
        Me.BunifuCustomLabel6.Text = "Nama Pemohon"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel11.Controls.Add(Me.BunifuImageButton7)
        Me.Panel11.Controls.Add(Me.txt_cari)
        Me.Panel11.Location = New System.Drawing.Point(538, 233)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(182, 28)
        Me.Panel11.TabIndex = 42
        '
        'txt_cari
        '
        Me.txt_cari.BackColor = System.Drawing.Color.BlueViolet
        Me.txt_cari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.ForeColor = System.Drawing.Color.White
        Me.txt_cari.Location = New System.Drawing.Point(15, 5)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(138, 19)
        Me.txt_cari.TabIndex = 1
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(270, 114)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(68, 13)
        Me.BunifuCustomLabel5.TabIndex = 50
        Me.BunifuCustomLabel5.Text = "Jenis Barang"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.BlueViolet
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(0, 8)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 13)
        Me.TextBox6.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.BlueViolet
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(15, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(184, 19)
        Me.TextBox5.TabIndex = 1
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(270, 59)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel4.TabIndex = 45
        Me.BunifuCustomLabel4.Text = "Jumlah"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 108)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(72, 13)
        Me.BunifuCustomLabel2.TabIndex = 44
        Me.BunifuCustomLabel2.Text = "Nama Barang"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(13, 59)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(88, 13)
        Me.BunifuCustomLabel1.TabIndex = 41
        Me.BunifuCustomLabel1.Text = "Kode Permintaan"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel5.Controls.Add(Me.txtjenisbarang)
        Me.Panel5.Controls.Add(Me.TextBox6)
        Me.Panel5.Controls.Add(Me.TextBox5)
        Me.Panel5.Location = New System.Drawing.Point(273, 130)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(216, 30)
        Me.Panel5.TabIndex = 43
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(702, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(27, 17)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton4.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.save
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(4, 3)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton4.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 15
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton2.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.edit
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(4, 3)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 15
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.pemkot_jpeg11
        Me.PictureBox1.Location = New System.Drawing.Point(548, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton5.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.trash_o
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(4, 3)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton5.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 15
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton6.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.sign_out
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(4, 3)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton6.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 15
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton7.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.search
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(158, 4)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton7.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 17
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'FormPermintaanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 443)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPermintaanBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPermintaanBarang"
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtkodepermintaan As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtjenisbarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents cmbnamapemohon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbnamabarang As System.Windows.Forms.ComboBox
End Class
