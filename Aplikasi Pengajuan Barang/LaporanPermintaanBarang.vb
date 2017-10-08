Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class LaporanPermintaanBarang
    Public OleDb, koneksi, query As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel, ttabelcari As New DataTable
    Public nama_petugas As String
    Dim DataSetName As String = "Data_Permintaan"
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_barang.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub
    Sub getjenisbarang()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct jenis_barang from data_permintaan order by jenis_barang", conn)
            rd = cmd.ExecuteReader()
            cmbjenisbarang.Items.Clear()
            cmbjenisbarang.Items.Add("--Pilih Jenis Barang--")
            While rd.Read()
                cmbjenisbarang.Items.Add(rd("jenis_barang"))
            End While
            cmbjenisbarang.Text = "--Pilih Jenis Barang--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub getjabatan()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct nama_pemohon from data_permintaan order by nama_pemohon", conn)
            rd = cmd.ExecuteReader()
            cmbjabatan.Items.Clear()
            cmbjabatan.Items.Add("--Pilih Pemohon--")
            While rd.Read()
                cmbjabatan.Items.Add(rd("nama_pemohon"))
            End While
            cmbjabatan.Text = "--Pilih Pemohon--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub tampil()
        konek()
        conn.Open()
        dtadapter = New OleDb.OleDbDataAdapter("select kode_permintaan,nama_barang,nama_pemohon,kode_permintaan,jumlah,jenis_barang,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,dibuat_oleh,kode_barang from data_permintaan where 1=1 order by kode_permintaan asc", koneksi)
        ttabel.Clear()
        ttabel = New DataTable
        ttabel.Clear()
        dtadapter.Fill(ttabel)
        Dim datasource As New ReportDataSource(DataSetName, ttabel)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
        conn.Close()
    End Sub

    Sub cari()
        konek()
        Me.ReportViewer1.Clear()
        Try
            Dim nowdate As String = String.Format("{0:d/MM/yyyy}", DateTime.Now)
            'Dim Akhir = tglakhir.Value.ToString("MM/d/yyyy")
            'Dim Awal = tglawal.Value.ToString("MM/d/yyyy")
            Dim Akhir = tglakhir.Value.ToString("d/MM/yyyy")
            Dim Awal = tglawal.Value.ToString("d/MM/yyyy")
            conn.Close()
            conn.Open()
            query = "select kode_permintaan,nama_barang,nama_pemohon,kode_permintaan,jumlah,jenis_barang,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,dibuat_oleh,kode_barang from data_permintaan where 1=1"
            If Akhir <> nowdate And Awal <> nowdate Then
                query = query + " and tanggal_input between #" & Awal & "# and #" & Akhir & "#"
            End If
            If cmbjenisbarang.Text <> "--Pilih Jenis Barang--" Then
                query = query + " and jenis_barang = '" & cmbjenisbarang.Text & "'"
            End If
            If cmbjabatan.Text <> "--Pilih Pemohon--" Then
                query = query + " and nama_pemohon = '" & cmbjabatan.Text & "'"
            End If
            query = query + " order by kode_permintaan asc"
            'MsgBox(query)
            dtadapter = New OleDb.OleDbDataAdapter(query, koneksi)
            ttabel.Clear()
            ttabel = New DataTable
            ttabel.Clear()
            dtadapter.Fill(ttabel)
            Dim datasource As New ReportDataSource(DataSetName, ttabel)
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()
            'Me.Show()
            conn.Close()
        Catch ex As Exception
            tampil()
        End Try

    End Sub
    Sub bersih()
        getjenisbarang()
        getjabatan()
    End Sub

    Private Sub LaporanPermintaanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        cari()
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click
        cari()
    End Sub
End Class