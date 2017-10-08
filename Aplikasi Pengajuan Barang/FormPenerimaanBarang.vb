Imports System.Data
Imports System.Data.OleDb
Public Class FormPenerimaanBarang
    Public stat_prm As String
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public nama_petugas As String
    Public is_search As Boolean
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_barang.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub
    Private Sub FormPenerimaanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
    End Sub
    Public Sub petugas_input()
        konek()
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand("SELECT nama_user FROM login where is_active = 1", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            nama_petugas = rd!nama_user
        Else
            nama_petugas = ""
        End If
        conn.Close()
    End Sub
    Sub bersih()
        kodepenerimaan()
        getkodepemeriksaan()
        txtnamabarang.Text = ""
        txt_cari.Text = ""
        txtjenisbarang.Text = ""
        txtstatuspemeriksaan.Text = ""
        txtnamabarang.Text = ""
        txtnamapenerima.Text = ""
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub
    Sub tampil()
        konek()
        Try
            dtadapter = New OleDb.OleDbDataAdapter("select * from data_penerimaan order by kode_penerimaan asc", koneksi)
            ttabel = New DataTable
            dtadapter.Fill(ttabel)
            dg.DataSource = ttabel

            dg.Columns(0).HeaderText = "Kode Penerimaan"
            dg.Columns(1).HeaderText = "Nama Barang"
            dg.Columns(2).HeaderText = "Nama Penerima"
            dg.Columns(3).HeaderText = "Status Pemeriksaan"
            dg.Columns(4).HeaderText = "Kode Pemeriksaan"
            dg.Columns(5).HeaderText = "Jumlah Barang"
            dg.Columns(6).HeaderText = "Jenis Barang"
            dg.Columns(7).HeaderText = "Status Penerimaan"
            dg.Columns(8).HeaderText = "Tanggal Input"
            dg.Columns(9).HeaderText = "Petugas Input"

            dg.AutoResizeColumns()
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub kodepenerimaan()
        Dim NomOt As String = ""
        konek()

        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT TOP 1 right(kode_penerimaan,3) + 1 as kode_penerimaan FROM data_penerimaan ORDER BY kode_penerimaan DESC ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Select Case rd!kode_penerimaan
                    Case Is <= 9
                        NomOt = "PNR" & "00" & rd!kode_penerimaan
                    Case Is <= 99
                        NomOt = "PNR" & "0" & rd!kode_penerimaan
                End Select
            Else
                'tabel kosong
                NomOt = "PNR" & "001"
            End If

            txtkodepenerimaan.Text = NomOt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub getkodepemeriksaan()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct kode_pemeriksaan from data_pemeriksaan order by kode_pemeriksaan", conn)
            rd = cmd.ExecuteReader()
            cmbkodepemeriksaan.Items.Clear()
            cmbkodepemeriksaan.Items.Add("--Pilih Kode Pemeriksaan--")
            While rd.Read()
                cmbkodepemeriksaan.Items.Add(rd("kode_pemeriksaan"))
            End While
            cmbkodepemeriksaan.Text = "--Pilih Kode Pemeriksaan--"
            conn.Close()
           
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If txtstatuspemeriksaan.Text = "Ditolak" Then
            CheckBox2.Checked = False
            MsgBox("Data Yang Ditolak Tidak Dapat Di Kirim", MsgBoxStyle.Critical, "Kesalahan")
        End If
        If CheckBox2.Checked = True Then
            CheckBox3.Checked = False
            stat_prm = "Belum Dikirim"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            stat_prm = "Dikirim"
        End If
    End Sub
    Sub savebtn()
        konek()
        petugas_input()
        Dim nowdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Try
            If txtkodepenerimaan.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf cmbkodepemeriksaan.Text = "--Pilih Kode Pemeriksaan--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf CheckBox3.Checked = False And CheckBox2.Checked = False Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            Else
                If CheckBox3.Checked = True Then
                    stat_prm = "Belum Dikirim"
                ElseIf CheckBox3.Checked = False Then
                    stat_prm = "Dikirim"
                Else
                    stat_prm = "Belum Dikirim"
                End If
                OleDb = "select * from data_penerimaan where kode_penerimaan = '" & txtkodepenerimaan.Text & "' or kode_pemeriksaan = '" & cmbkodepemeriksaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    MsgBox("Data Sudah Ada Atau Kode Pemeriksaan Sudah Di Ajukan !", MsgBoxStyle.Critical, "Perhatian")
                    rd.Close()
                    conn.Close()
                    bersih()
                Else
                    conn.Close()
                    conn.Open()
                    OleDb = "insert into data_penerimaan values('" & txtkodepenerimaan.Text & "','" & txtnamabarang.Text & "','" & txtnamapenerima.Text & "','" & txtstatuspemeriksaan.Text & "','" & cmbkodepemeriksaan.Text & "' ,'" & txtjumlah.Text & "','" & txtjenisbarang.Text & "','" & stat_prm & "','" & nowdate & "','" & nama_petugas & "')"
                    cmd = New OleDb.OleDbCommand(OleDb, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Save Data")
                    bersih()
                    conn.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub ubah()
        konek()

        If txtkodepenerimaan.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf cmbkodepemeriksaan.Text = "--Pilih Kode Pemeriksaan--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf CheckBox3.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        Else
            If CheckBox3.Checked = True Then
                stat_prm = "Belum Dikirim"
            ElseIf CheckBox3.Checked = False Then
                stat_prm = "Dikirim"
            Else
                stat_prm = "Belum Dikirim"
            End If
            Try
                OleDb = "select * from data_penerimaan where kode_penerimaan = '" & txtkodepenerimaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    conn.Close()
                    conn.Open()
                    OleDb = "update data_penerimaan set nama_barang ='" & txtnamabarang.Text & "' , nama_penerima ='" & txtnamapenerima.Text & "', status_pemeriksaan ='" & txtstatuspemeriksaan.Text & "',kode_pemeriksaan ='" & cmbkodepemeriksaan.Text & "', jumlah ='" & txtjumlah.Text & "', jenis_barang ='" & txtjenisbarang.Text & "', status_penerimaan ='" & stat_prm & "'  where kode_penerimaan ='" & txtkodepenerimaan.Text & "'"
                    cmd = New OleDb.OleDbCommand(OleDb, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Rubah", MsgBoxStyle.Information, "Update Data")
                    bersih()
                    rd.Close()
                    conn.Close()
                    bersih()
                Else
                    MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")
                    conn.Close()
                    bersih()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub hapus()
        Try
            OleDb = "select * from data_penerimaan where kode_penerimaan = '" & txtkodepenerimaan.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "delete from data_penerimaan where kode_penerimaan ='" & txtkodepenerimaan.Text & "'"
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Hapus Data")
                bersih()
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")
                bersih()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub cari()
        konek()
        Try
            is_search = True
            OleDb = "select * from data_penerimaan where kode_penerimaan = '" & txt_cari.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtkodepenerimaan.Text = RTrim(rd("kode_penerimaan"))
                txtnamabarang.Text = RTrim(rd("nama_barang"))
                txtnamapenerima.Text = RTrim(rd("nama_penerima"))
                txtstatuspemeriksaan.Text = RTrim(rd("status_pemeriksaan"))
            cmbkodepemeriksaan.Text = RTrim(rd("kode_pemeriksaan"))
            txtjumlah.Text = RTrim(rd("jumlah"))
            txtjenisbarang.Text = RTrim(rd("jenis_barang"))
                stat_prm = RTrim(rd("status_penerimaan"))
                If stat_prm = "Belum Dikirim" Then
                    CheckBox3.Checked = True
                Else
                    CheckBox2.Checked = True
                End If
            Else
            MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
            is_search = False
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        cari()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        ubah()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.Click
        ubah()
        tampil()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        hapus()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel9_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel9.Click
        hapus()
        tampil()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        savebtn()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        savebtn()
        tampil()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        is_search = True
        txtkodepenerimaan.Text = dg.CurrentRow.Cells(0).Value
        txtnamabarang.Text = dg.CurrentRow.Cells(1).Value
        txtnamapenerima.Text = dg.CurrentRow.Cells(2).Value
        txtstatuspemeriksaan.Text = dg.CurrentRow.Cells(3).Value
        cmbkodepemeriksaan.Text = dg.CurrentRow.Cells(4).Value
        txtjumlah.Text = dg.CurrentRow.Cells(5).Value
        txtjenisbarang.Text = dg.CurrentRow.Cells(6).Value
        stat_prm = dg.CurrentRow.Cells(7).Value
        If stat_prm = "Belum Dikirim" Then
            CheckBox3.Checked = True
        Else
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub cmbkodepemeriksaan_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbkodepemeriksaan.SelectedIndexChanged
        konek()
        Try
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            If cmbkodepemeriksaan.Text <> "--Pilih Kode Pemeriksaan--" And is_search = False Then
                OleDb = "select top 1 nama_pemohon, nama_barang, jenis_barang, jumlah, status_pemeriksaan from data_pemeriksaan where kode_pemeriksaan = '" & cmbkodepemeriksaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    txtnamabarang.Text = RTrim(rd("nama_barang"))
                    txtnamapenerima.Text = RTrim(rd("nama_pemohon"))
                    txtjumlah.Text = RTrim(rd("jumlah"))
                    txtjenisbarang.Text = RTrim(rd("jenis_barang"))
                    Dim status_pemeriksaan As String = RTrim(rd("status_pemeriksaan"))
                    If status_pemeriksaan = "Ditolak" Then
                        txtstatuspemeriksaan.Text = "Ditolak"
                    Else
                        txtstatuspemeriksaan.Text = "Disetujui"
                    End If
                Else
                    MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
                End If
                conn.Close()
            ElseIf is_search = True Then
                is_search = False
            Else
                txtjumlah.Text = ""
                txtjenisbarang.Text = ""
                txtstatuspemeriksaan.Text = ""
                txtnamabarang.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class