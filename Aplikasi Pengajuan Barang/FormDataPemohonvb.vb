Imports System.Data
Imports System.Data.OleDb
Public Class FormDataPemohonvb
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public nama_petugas As String
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
    Sub bersih()
        txt_cari.Text = ""
        txt_kodepemohon.Text = ""
        txtnmpemohon.Text = ""
        kodepemohon()
        cmbjabatan.Text = "--Pilih Jabatan--"
    End Sub
    Private Sub kodepemohon()
        Dim NomOt As String = ""
        konek()

        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT TOP 1 right(kode_pemohon,3) + 1 as kode_pemohon FROM data_pemohon ORDER BY kode_pemohon DESC ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Select Case rd!kode_pemohon
                    Case Is <= 9
                        NomOt = "PMH" & "00" & rd!kode_pemohon
                    Case Is <= 99
                        NomOt = "PMH" & "0" & rd!kode_pemohon
                End Select
            Else
                'tabel kosong
                NomOt = "PMH" & "001"
            End If

            txt_kodepemohon.Text = NomOt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub tampil()
        konek()
        Try
            dtadapter = New OleDb.OleDbDataAdapter("select * from data_pemohon order by kode_pemohon asc", koneksi)
            ttabel = New DataTable
            dtadapter.Fill(ttabel)
            dg.DataSource = ttabel

            dg.Columns(0).HeaderText = "Kode Pemohon"
            dg.Columns(1).HeaderText = "Nama Pemohon"
            dg.Columns(2).HeaderText = "Jabatan"
            dg.Columns(3).HeaderText = "Tanggal Input"
            dg.Columns(4).HeaderText = "Petugas Input"

            dg.AutoResizeColumns()
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub savebtn()
        konek()
        petugas_input()
        Dim nowdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Try
            If txt_kodepemohon.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtnmpemohon.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
                txtnmpemohon.Focus()
            ElseIf cmbjabatan.Text = "--Pilih Jabatan--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
                cmbjabatan.Focus()
            Else
                OleDb = "select * from data_pemohon where kode_pemohon = '" & txt_kodepemohon.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    MsgBox("Data Sudah Ada !", MsgBoxStyle.Critical, "Perhatian")
                    rd.Close()
                    conn.Close()
                Else
                    conn.Close()
                    conn.Open()
                    OleDb = "insert into data_pemohon values('" & txt_kodepemohon.Text & "','" & txtnmpemohon.Text & "','" & cmbjabatan.Text & "' ,'" & nowdate & "','" & nama_petugas & "')"
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
        If txt_kodepemohon.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf txtnmpemohon.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            txtnmpemohon.Focus()
        ElseIf cmbjabatan.Text = "--Pilih Jabatan--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            cmbjabatan.Focus()
        Else
            Try
                OleDb = "select * from data_pemohon where kode_pemohon = '" & txt_kodepemohon.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    conn.Close()
                    conn.Open()
                    OleDb = "update data_pemohon set nama_pemohon ='" & txtnmpemohon.Text & "' , jabatan ='" & cmbjabatan.Text & "' where kode_pemohon ='" & txt_kodepemohon.Text & "'"
                    cmd = New OleDb.OleDbCommand(OleDb, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Rubah", MsgBoxStyle.Information, "Update Data")
                    rd.Close()
                    conn.Close()
                    bersih()
                Else
                    MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub cari()
        konek()
        Try
            OleDb = "select * from data_pemohon where kode_pemohon = '" & txt_cari.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txt_kodepemohon.Text = RTrim(rd("kode_pemohon"))
                txtnmpemohon.Text = RTrim(rd("nama_pemohon"))
                cmbjabatan.Text = RTrim(rd("jabatan"))
            Else
                MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub hapus()
        Try
            OleDb = "select * from data_pemohon where kode_pemohon = '" & txt_kodepemohon.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "delete from data_pemohon where kode_pemohon ='" & txt_kodepemohon.Text & "'"
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Hapus Data")
                bersih()
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")
                conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormDataPemohonvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
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

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        savebtn()
        tampil()

    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        savebtn()
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

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        cari()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        hapus()
        tampil()

    End Sub

    Private Sub BunifuCustomLabel9_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel9.Click
        hapus()
        tampil()
    End Sub
    Private Sub dg_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dg.DoubleClick
        txt_kodepemohon.Text = dg.CurrentRow.Cells(0).Value
        txtnmpemohon.Text = dg.CurrentRow.Cells(1).Value
        cmbjabatan.Text = dg.CurrentRow.Cells(2).Value
    End Sub
End Class