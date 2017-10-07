Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class LaporanDataBarang
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public nama_petugas As String
    Dim DataSetName As String = "Data_Barang"
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dian Yanzen\Documents\Visual Studio 2013\Projects\Aplikasi Pengajuan Barang\Aplikasi Pengajuan Barang\bin\Debug\db_barang.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub
    Sub tampil()
        
    End Sub
    Private Sub LaporanDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        conn.Open()
        dtadapter = New OleDb.OleDbDataAdapter("select kode_barang,nama_barang,jenis_barang,jumlah_barang,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,dibuat_oleh from data_barang order by kode_barang asc", koneksi)
        ttabel = New DataTable
        ttabel.Clear()
        dtadapter.Fill(ttabel)
        Dim datasource As New ReportDataSource(DataSetName, ttabel)
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
        conn.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
    End Sub
End Class