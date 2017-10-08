Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class LaporanPenerimaanBarang
    Public OleDb, koneksi, query As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel, ttabelcari As New DataTable
    Public nama_petugas As String
    Dim DataSetName As String = "Data_Penerimaan"
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
            cmd = New OleDbCommand("select distinct jenis_barang from data_penerimaan order by jenis_barang", conn)
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
    Sub getstatuspemeriksaan()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct status_pemeriksaan from data_penerimaan order by status_pemeriksaan", conn)
            rd = cmd.ExecuteReader()
            cmbpemeriksaan.Items.Clear()
            cmbpemeriksaan.Items.Add("--Pilih Status Pemeriksaan--")
            While rd.Read()
                cmbpemeriksaan.Items.Add(rd("status_pemeriksaan"))
            End While
            cmbpemeriksaan.Text = "--Pilih Status Pemeriksaan--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub getstatuspenerimaan()
        konek()
        Try
            conn.Close()
            conn.Open()
            'cmbjudulfilm.Items.Clear()
            cmd = New OleDbCommand("select distinct status_penerimaan from data_penerimaan order by status_penerimaan", conn)
            rd = cmd.ExecuteReader()
            cmbstatuspenerimaan.Items.Clear()
            cmbstatuspenerimaan.Items.Add("--Pilih Status Penerimaan--")
            While rd.Read()
                cmbstatuspenerimaan.Items.Add(rd("status_penerimaan"))
            End While
            cmbstatuspenerimaan.Text = "--Pilih Status Penerimaan--"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Sub bersih()
        getjenisbarang()
        getstatuspemeriksaan()
        getstatuspenerimaan()
    End Sub
    Sub tampil()
        konek()
        conn.Open()
        dtadapter = New OleDb.OleDbDataAdapter("select kode_penerimaan,nama_barang,nama_penerima,status_pemeriksaan,kode_pemeriksaan,jumlah,jenis_barang,status_penerimaan,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,diinput_oleh from data_penerimaan where 1=1 order by kode_penerimaan asc", koneksi)
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
            query = "select kode_penerimaan,nama_barang,nama_penerima,status_pemeriksaan,kode_pemeriksaan,jumlah,jenis_barang,status_penerimaan,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,diinput_oleh from data_penerimaan where 1=1"
            If Akhir <> nowdate And Awal <> nowdate Then
                query = query + " and tanggal_input between #" & Awal & "# and #" & Akhir & "#"
            End If
            If cmbjenisbarang.Text <> "--Pilih Jenis Barang--" Then
                query = query + " and jenis_barang = '" & cmbjenisbarang.Text & "'"
            End If
            If cmbpemeriksaan.Text <> "--Pilih Status Pemeriksaan--" Then
                query = query + " and status_pemeriksaan = '" & cmbpemeriksaan.Text & "'"
            End If
            If cmbstatuspenerimaan.Text <> "--Pilih Status Penerimaan--" Then
                query = query + " and status_penerimaan = '" & cmbstatuspenerimaan.Text & "'"
            End If
            query = query + " order by kode_penerimaan asc"
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
    Private Sub LaporanPenerimaanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        bersih()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        bersih()
        tampil()
    End Sub
End Class