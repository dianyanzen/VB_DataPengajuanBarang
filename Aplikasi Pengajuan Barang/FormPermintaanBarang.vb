Imports System.Data
Imports System.Data.OleDb
Public Class FormPermintaanBarang
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public nama_petugas As String
    Public is_search As Boolean
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dian Yanzen\Documents\Visual Studio 2013\Projects\Aplikasi Pengajuan Barang\Aplikasi Pengajuan Barang\bin\Debug\db_barang.mdb"
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
    Sub tampil()
        konek()
        Try
            dtadapter = New OleDb.OleDbDataAdapter("select * from data_permintaan order by kode_permintaan asc", koneksi)
            ttabel = New DataTable
            dtadapter.Fill(ttabel)
            dg.DataSource = ttabel

            dg.Columns(0).HeaderText = "Kode Permintaan"
            dg.Columns(1).HeaderText = "Nama Barang"
            dg.Columns(2).HeaderText = "Nama Pemohon"
            dg.Columns(3).HeaderText = "Jumlah Barang"
            dg.Columns(4).HeaderText = "Jenis Barang"
            dg.Columns(5).HeaderText = "Tanggal Input"
            dg.Columns(6).HeaderText = "Petugas Input"

            dg.AutoResizeColumns()
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub kodepermintaan()
        Dim NomOt As String = ""
        konek()

        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT TOP 1 right(kode_permintaan,3) + 1 as kode_permintaan FROM data_permintaan ORDER BY kode_permintaan DESC ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Select Case rd!kode_permintaan
                    Case Is <= 9
                        NomOt = "PRM" & "00" & rd!kode_permintaan
                    Case Is <= 99
                        NomOt = "PRM" & "0" & rd!kode_permintaan
                End Select
            Else
                'tabel kosong
                NomOt = "PRM" & "001"
            End If

            txtkodepermintaan.Text = NomOt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub getnamabarang()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct nama_barang from data_barang order by nama_barang", conn)
            rd = cmd.ExecuteReader()
            cmbnamabarang.Items.Clear()
            cmbnamabarang.Items.Add("--Pilih Nama Barang--")
            While rd.Read()
                cmbnamabarang.Items.Add(rd("nama_barang"))
            End While
            cmbnamabarang.Text = "--Pilih Nama Barang--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Private Sub getnamapemohon()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct nama_pemohon from data_pemohon order by nama_pemohon", conn)
            rd = cmd.ExecuteReader()
            cmbnamapemohon.Items.Clear()
            cmbnamapemohon.Items.Add("--Pilih Nama Pemohon--")
            While rd.Read()
                cmbnamapemohon.Items.Add(rd("nama_pemohon"))
            End While
            cmbnamapemohon.Text = "--Pilih Nama Pemohon--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub bersih()
        kodepermintaan()
        getnamabarang()
        getnamapemohon()
        txtjumlah.Text = ""
        txtjenisbarang.Text = ""
        txt_cari.Text = ""
    End Sub

    Private Sub cmbnamabarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnamabarang.SelectedIndexChanged
        konek()
        Try
            If cmbnamabarang.Text <> "--Pilih Nama Barang--" And is_search = False Then
                OleDb = "select top 1 jenis_barang, jumlah_barang from data_barang where nama_barang = '" & cmbnamabarang.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    txtjumlah.Text = RTrim(rd("jumlah_barang"))
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub savebtn()
        konek()
        petugas_input()
        Dim nowdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Try
            If txtkodepermintaan.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf cmbnamabarang.Text = "--Pilih Nama Barang--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf cmbnamapemohon.Text = "--Pilih Nama Pemohon--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            Else
                OleDb = "select * from data_permintaan where kode_permintaan = '" & txtkodepermintaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    MsgBox("Data Sudah Ada !", MsgBoxStyle.Critical, "Perhatian")
                    rd.Close()
                    conn.Close()
                    bersih()
                Else
                    conn.Close()
                    conn.Open()
                    OleDb = "insert into data_permintaan values('" & txtkodepermintaan.Text & "','" & cmbnamabarang.Text & "','" & cmbnamapemohon.Text & "' ,'" & txtjumlah.Text & "','" & txtjenisbarang.Text & "','" & nowdate & "','" & nama_petugas & "')"
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
        If txtkodepermintaan.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf cmbnamabarang.Text = "--Pilih Nama Barang--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf cmbnamapemohon.Text = "--Pilih Nama Pemohon--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        Else
            Try
                OleDb = "select * from data_permintaan where kode_permintaan = '" & txtkodepermintaan.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    conn.Close()
                    conn.Open()
                    OleDb = "update data_permintaan set nama_barang ='" & cmbnamabarang.Text & "' , nama_pemohon ='" & cmbnamapemohon.Text & "', jumlah ='" & txtjumlah.Text & "', jenis_barang ='" & txtjenisbarang.Text & "'  where kode_permintaan ='" & txtkodepermintaan.Text & "'"
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
            OleDb = "select * from data_permintaan where kode_permintaan = '" & txtkodepermintaan.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "delete from data_permintaan where kode_permintaan ='" & txtkodepermintaan.Text & "'"
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
            OleDb = "select * from data_permintaan where kode_permintaan = '" & txt_cari.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtkodepermintaan.Text = RTrim(rd("kode_permintaan"))
                cmbnamabarang.Text = RTrim(rd("nama_barang"))
                txtjumlah.Text = RTrim(rd("jumlah"))
                cmbnamapemohon.Text = RTrim(rd("nama_pemohon"))
                txtjenisbarang.Text = RTrim(rd("jenis_barang"))
            Else
                MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
                is_search = False
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormPermintaanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        bersih()
        Me.Hide()
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
        txtkodepermintaan.Text = dg.CurrentRow.Cells(0).Value
        cmbnamabarang.Text = dg.CurrentRow.Cells(1).Value
        cmbnamapemohon.Text = dg.CurrentRow.Cells(2).Value
        txtjumlah.Text = dg.CurrentRow.Cells(3).Value
        txtjenisbarang.Text = dg.CurrentRow.Cells(4).Value
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

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        cari()
    End Sub
End Class