﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPemeriksaanBarang
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPemeriksaanBarang))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.cmbjenisbarang = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbstatuspemeriksaan = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource5.Name = "Data_Pemeriksaan"
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_Pengajuan_Barang.Data_Pemeriksaan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 159)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1050, 470)
        Me.ReportViewer1.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 43)
        Me.Panel1.TabIndex = 40
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1023, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(27, 17)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 11)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(282, 22)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "Laporan Pemeriksaan Barang"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Location = New System.Drawing.Point(786, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(101, 28)
        Me.Panel2.TabIndex = 77
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(48, 7)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(25, 13)
        Me.BunifuCustomLabel5.TabIndex = 18
        Me.BunifuCustomLabel5.Text = "Cari"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton2.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.search
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(4, 4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton2.Size = New System.Drawing.Size(24, 20)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 17
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel11.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel11.Controls.Add(Me.BunifuImageButton7)
        Me.Panel11.Location = New System.Drawing.Point(679, 124)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(101, 28)
        Me.Panel11.TabIndex = 76
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(44, 7)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(36, 13)
        Me.BunifuCustomLabel8.TabIndex = 18
        Me.BunifuCustomLabel8.Text = "Bersih"
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.BlueViolet
        Me.BunifuImageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuImageButton7.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.refresh
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(4, 4)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuImageButton7.Size = New System.Drawing.Size(24, 20)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 17
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel14.Controls.Add(Me.cmbjenisbarang)
        Me.Panel14.Location = New System.Drawing.Point(230, 66)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(164, 30)
        Me.Panel14.TabIndex = 75
        '
        'cmbjenisbarang
        '
        Me.cmbjenisbarang.BackColor = System.Drawing.Color.BlueViolet
        Me.cmbjenisbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbjenisbarang.ForeColor = System.Drawing.Color.White
        Me.cmbjenisbarang.FormattingEnabled = True
        Me.cmbjenisbarang.Items.AddRange(New Object() {"--Pilih Jenis Barang--", "Alat Tulis Kantor", "Elektronik", "Peralatan Kebersihan", "Peralatan Kebun", "Lainnya"})
        Me.cmbjenisbarang.Location = New System.Drawing.Point(0, 5)
        Me.cmbjenisbarang.Name = "cmbjenisbarang"
        Me.cmbjenisbarang.Size = New System.Drawing.Size(161, 21)
        Me.cmbjenisbarang.TabIndex = 12
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(227, 50)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(68, 13)
        Me.BunifuCustomLabel4.TabIndex = 74
        Me.BunifuCustomLabel4.Text = "Jenis Barang"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 106)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(84, 13)
        Me.BunifuCustomLabel2.TabIndex = 73
        Me.BunifuCustomLabel2.Text = "Sampai Tanggal"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(13, 50)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(68, 13)
        Me.BunifuCustomLabel1.TabIndex = 72
        Me.BunifuCustomLabel1.Text = "Dari Tanggal"
        '
        'tglakhir
        '
        Me.tglakhir.Location = New System.Drawing.Point(12, 122)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(200, 20)
        Me.tglakhir.TabIndex = 71
        '
        'tglawal
        '
        Me.tglawal.Location = New System.Drawing.Point(13, 66)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(200, 20)
        Me.tglawal.TabIndex = 70
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel3.Controls.Add(Me.cmbstatuspemeriksaan)
        Me.Panel3.Location = New System.Drawing.Point(230, 122)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 30)
        Me.Panel3.TabIndex = 79
        '
        'cmbstatuspemeriksaan
        '
        Me.cmbstatuspemeriksaan.BackColor = System.Drawing.Color.BlueViolet
        Me.cmbstatuspemeriksaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbstatuspemeriksaan.ForeColor = System.Drawing.Color.White
        Me.cmbstatuspemeriksaan.FormattingEnabled = True
        Me.cmbstatuspemeriksaan.Items.AddRange(New Object() {"--Pilih Jenis Barang--", "Alat Tulis Kantor", "Elektronik", "Peralatan Kebersihan", "Peralatan Kebun", "Lainnya"})
        Me.cmbstatuspemeriksaan.Location = New System.Drawing.Point(0, 5)
        Me.cmbstatuspemeriksaan.Name = "cmbstatuspemeriksaan"
        Me.cmbstatuspemeriksaan.Size = New System.Drawing.Size(161, 21)
        Me.cmbstatuspemeriksaan.TabIndex = 12
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(227, 106)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(101, 13)
        Me.BunifuCustomLabel6.TabIndex = 78
        Me.BunifuCustomLabel6.Text = "Status Pemeriksaan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Pengajuan_Barang.My.Resources.Resources.pemkot_jpeg11
        Me.PictureBox1.Location = New System.Drawing.Point(895, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'LaporanPemeriksaanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 629)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.tglakhir)
        Me.Controls.Add(Me.tglawal)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaporanPemeriksaanBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanPemeriksaanBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbstatuspemeriksaan As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents cmbjenisbarang As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
