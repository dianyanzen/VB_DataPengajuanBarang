Imports System.Data
Imports System.Data.OleDb
Public Class FormDataBarang
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
        txtjumlah.Text = ""
        txtnmbarang.Text = ""
        kodebarang()
        cmbjenis.Text = "--Pilih Jenis Barang--"
    End Sub
    Sub tampil()
        konek()
        Try
            dtadapter = New OleDb.OleDbDataAdapter("select * from data_barang order by kode_barang asc", koneksi)
            ttabel = New DataTable
            dtadapter.Fill(ttabel)
            dg.DataSource = ttabel

            dg.Columns(0).HeaderText = "Kode Barang"
            dg.Columns(1).HeaderText = "Nama Barang"
            dg.Columns(2).HeaderText = "Jenis Barang"
            dg.Columns(3).HeaderText = "Jumlah Barang"
            dg.Columns(4).HeaderText = "Tanggal Input"
            dg.Columns(5).HeaderText = "Petugas Input"

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
            If txtkodebarang.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtnmbarang.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
                txtnmbarang.Focus()
            ElseIf txtjumlah.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
                txtjumlah.Focus()
            ElseIf cmbjenis.Text = "--Pilih Jenis Barang--" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
                cmbjenis.Focus()
            Else
                OleDb = "select * from data_barang where kode_barang = '" & txtkodebarang.Text & "'"
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
                    OleDb = "insert into data_barang values('" & txtkodebarang.Text & "','" & txtnmbarang.Text & "','" & cmbjenis.Text & "' ,'" & txtjumlah.Text & "','" & nowdate & "','" & nama_petugas & "')"
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
    Private Sub kodebarang()
        Dim NomOt As String = ""
        konek()

        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT TOP 1 right(kode_barang,3) + 1 as kode_barang FROM data_barang ORDER BY kode_barang DESC ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                Select Case rd!kode_barang
                    Case Is <= 9
                        NomOt = "BRG" & "00" & rd!kode_barang
                    Case Is <= 99
                        NomOt = "BRG" & "0" & rd!kode_barang
                End Select
            Else
                'tabel kosong
                NomOt = "BRG" & "001"
            End If

            txtkodebarang.Text = NomOt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub cari()
        konek()
        Try
            OleDb = "select * from data_barang where kode_barang = '" & txt_cari.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtkodebarang.Text = RTrim(rd("kode_barang"))
                txtnmbarang.Text = RTrim(rd("nama_barang"))
                txtjumlah.Text = RTrim(rd("jumlah_barang"))
                cmbjenis.Text = RTrim(rd("jenis_barang"))
            Else
                MsgBox("Data Tidak Ada !", MsgBoxStyle.Critical, "Perhatian")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ubah()
        konek()
        If txtkodebarang.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
        ElseIf txtnmbarang.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            txtnmbarang.Focus()
        ElseIf txtjumlah.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            txtjumlah.Focus()
        ElseIf cmbjenis.Text = "--Pilih Jenis Barang--" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            cmbjenis.Focus()
        Else
            Try
                OleDb = "select * from data_barang where kode_barang = '" & txtkodebarang.Text & "'"
                conn.Open()
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                rd = cmd.ExecuteReader
                If rd.Read Then
                    conn.Close()
                    conn.Open()
                    OleDb = "update data_barang set nama_barang ='" & txtnmbarang.Text & "' , jenis_barang ='" & cmbjenis.Text & "', jumlah_barang ='" & txtjumlah.Text & "' where kode_barang ='" & txtkodebarang.Text & "'"
                    cmd = New OleDb.OleDbCommand(OleDb, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Rubah", MsgBoxStyle.Information, "Update Data")
                    bersih()
                    rd.Close()
                    conn.Close()

                Else
                    MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")
                    conn.Close()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub hapus()
        Try
            OleDb = "select * from data_barang where kode_barang = '" & txtkodebarang.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "delete from data_barang where kode_barang ='" & txtkodebarang.Text & "'"
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Hapus Data")
                bersih()
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Error")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub


    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
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

  
    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
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
    Private Sub dg_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dg.DoubleClick
        txtkodebarang.Text = dg.CurrentRow.Cells(0).Value
        txtnmbarang.Text = dg.CurrentRow.Cells(1).Value
        txtjumlah.Text = dg.CurrentRow.Cells(3).Value
        cmbjenis.Text = dg.CurrentRow.Cells(2).Value
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        bersih()
        Me.Hide()
    End Sub
End Class