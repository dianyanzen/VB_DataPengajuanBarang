Imports System.Data
Imports System.Data.OleDb
Public Class FormPemeriksaanBarang
    Public stat_pm As String
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
   
    Private Sub kodepemeriksaan()
        Dim NomOt As String = ""
        konek()

        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT TOP 1 right(kode_pemeriksaan,3) + 1 as kode_pemeriksaan FROM data_pemeriksaan ORDER BY kode_pemeriksaan DESC ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Select Case rd!kode_pemeriksaan
                    Case Is <= 9
                        NomOt = "PMK" & "00" & rd!kode_pemeriksaan
                    Case Is <= 99
                        NomOt = "PMK" & "0" & rd!kode_pemeriksaan
                End Select
            Else
                'tabel kosong
                NomOt = "PMK" & "001"
            End If

            txtkodepemeriksaan.Text = NomOt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub getkodepermintaan()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct kode_permintaan from data_permintaan order by kode_permintaan", conn)
            rd = cmd.ExecuteReader()
            cmbkodepermintaan.Items.Clear()
            cmbkodepermintaan.Items.Add("--Pilih Kode Permintaan--")
            While rd.Read()
                cmbkodepermintaan.Items.Add(rd("kode_permintaan"))
            End While
            cmbkodepermintaan.Text = "--Pilih Kode Permintaan--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub bersih()
        kodepemeriksaan()
        getkodepermintaan()
        txtnamabarang.Text = ""
        txt_cari.Text = ""
        txtjenisbarang.Text = ""
        txtnamabarang.Text = ""
        txtnamapemohon.Text = ""
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox3.Checked = False
            stat_pm = "Disetujui"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            stat_pm = "Ditolak"
        End If

    End Sub
    Sub savebtn()
        konek()
        petugas_input()
        Dim nowdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Try
            If txtkodepemeriksaan.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf cmbkodepermintaan.Text = "--Pilih Kode Permintaan--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf CheckBox3.Checked = False And CheckBox2.Checked = False Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            Else
                If CheckBox3.Checked = True Then
                    stat_pm = "Ditolak"
                ElseIf CheckBox3.Checked = False Then
                    stat_pm = "Disetujui"
                Else
                    stat_pm = "Ditolak"
                End If
                OleDb = "select * from data_pemeriksaan where kode_pemeriksaan = '" & txtkodepemeriksaan.Text & "' or kode_permintaan = '" & cmbkodepermintaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    MsgBox("Data Sudah Ada Atau Kode Permintaan Sudah Di Ajukan !", MsgBoxStyle.Critical, "Perhatian")
                    rd.Close()
                    conn.Close()
                    bersih()
                Else
                    conn.Close()
                    conn.Open()
                    OleDb = "insert into data_pemeriksaan values('" & txtkodepemeriksaan.Text & "','" & txtnamabarang.Text & "','" & txtnamapemohon.Text & "','" & cmbkodepermintaan.Text & "' ,'" & txtjumlah.Text & "','" & txtjenisbarang.Text & "','" & stat_pm & "','" & nowdate & "','" & nama_petugas & "')"
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
        If txtkodepemeriksaan.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf cmbkodepermintaan.Text = "--Pilih Kode Permintaan--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf CheckBox3.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        Else
            Try
                If CheckBox3.Checked = True Then
                    stat_pm = "Ditolak"
                ElseIf CheckBox3.Checked = False Then
                    stat_pm = "Disetujui"
                Else
                    stat_pm = "Ditolak"
                End If
                OleDb = "select * from data_pemeriksaan where kode_pemeriksaan = '" & txtkodepemeriksaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    conn.Close()
                    conn.Open()
                    OleDb = "update data_pemeriksaan set nama_barang ='" & txtnamabarang.Text & "' , nama_pemohon ='" & txtnamapemohon.Text & "',kode_permintaan ='" & cmbkodepermintaan.Text & "', jumlah ='" & txtjumlah.Text & "', jenis_barang ='" & txtjenisbarang.Text & "', status_pemeriksaan ='" & stat_pm & "'  where kode_pemeriksaan ='" & txtkodepemeriksaan.Text & "'"
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
            OleDb = "select * from data_pemeriksaan where kode_pemeriksaan = '" & txtkodepemeriksaan.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "delete from data_pemeriksaan where kode_pemeriksaan ='" & txtkodepemeriksaan.Text & "'"
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
            OleDb = "select * from data_pemeriksaan where kode_pemeriksaan = '" & txt_cari.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtkodepemeriksaan.Text = RTrim(rd("kode_pemeriksaan"))
                txtnamabarang.Text = RTrim(rd("nama_barang"))
                cmbkodepermintaan.Text = RTrim(rd("kode_permintaan"))
                txtjumlah.Text = RTrim(rd("jumlah"))
                txtnamapemohon.Text = RTrim(rd("nama_pemohon"))
                txtjenisbarang.Text = RTrim(rd("jenis_barang"))
                stat_pm = RTrim(rd("status_pemeriksaan"))
                If stat_pm = "Ditolak" Then
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

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub
    Sub tampil()
        konek()
        Try
            dtadapter = New OleDb.OleDbDataAdapter("select * from data_pemeriksaan order by kode_pemeriksaan asc", koneksi)
            ttabel = New DataTable
            dtadapter.Fill(ttabel)
            dg.DataSource = ttabel

            dg.Columns(0).HeaderText = "Kode Pemeriksaan"
            dg.Columns(1).HeaderText = "Nama Barang"
            dg.Columns(2).HeaderText = "Nama Pemohon"
            dg.Columns(3).HeaderText = "Kode Permintaan"
            dg.Columns(4).HeaderText = "Jumlah Barang"
            dg.Columns(5).HeaderText = "Jenis Barang"
            dg.Columns(6).HeaderText = "Status Pemeriksaan"
            dg.Columns(7).HeaderText = "Tanggal Input"
            dg.Columns(8).HeaderText = "Petugas Input"

            dg.AutoResizeColumns()
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
  
    Private Sub cmbkodepermintaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkodepermintaan.SelectedIndexChanged
        konek()
        Try
            If cmbkodepermintaan.Text <> "--Pilih Kode Permintaan--" And is_search = False Then
                OleDb = "select top 1 nama_pemohon, nama_barang, jenis_barang, jumlah from data_permintaan where kode_permintaan = '" & cmbkodepermintaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    txtnamabarang.Text = RTrim(rd("nama_barang"))
                    txtnamapemohon.Text = RTrim(rd("nama_pemohon"))
                    txtjumlah.Text = RTrim(rd("jumlah"))
                    txtjenisbarang.Text = RTrim(rd("jenis_barang"))
                Else
                    MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
                End If
                conn.Close()
            ElseIf is_search = True Then
                is_search = False
            Else
                txtjumlah.Text = ""
                txtjenisbarang.Text = ""
                txtnamabarang.Text = ""
            End If
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

    Private Sub FormPemeriksaanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        ubah()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.Click
        ubah()
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

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        hapus()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel9_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel9.Click
        hapus()
        tampil()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        is_search = True
        txtkodepemeriksaan.Text = dg.CurrentRow.Cells(0).Value
        txtnamabarang.Text = dg.CurrentRow.Cells(1).Value
        txtnamapemohon.Text = dg.CurrentRow.Cells(2).Value
        cmbkodepermintaan.Text = dg.CurrentRow.Cells(3).Value
        txtjumlah.Text = dg.CurrentRow.Cells(4).Value
        txtjenisbarang.Text = dg.CurrentRow.Cells(5).Value
        stat_pm = dg.CurrentRow.Cells(6).Value
        If stat_pm = "Ditolak" Then
            CheckBox3.Checked = True
        Else
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        cari()
    End Sub

  
End Class