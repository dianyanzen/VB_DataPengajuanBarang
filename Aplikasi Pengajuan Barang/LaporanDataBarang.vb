﻿Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class LaporanDataBarang
    Public OleDb, koneksi, query As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel, ttabelcari As New DataTable
    Public nama_petugas As String
    Dim DataSetName As String = "Data_Barang"
   
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
            cmd = New OleDbCommand("select distinct jenis_barang from data_barang order by jenis_barang", conn)
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
    Sub bersih()
        getjenisbarang()
    End Sub
    Sub tampil()
        konek()
        conn.Open()
        dtadapter = New OleDb.OleDbDataAdapter("select kode_barang,nama_barang,jenis_barang,jumlah_barang,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,dibuat_oleh from data_barang where 1=1 order by kode_barang asc", koneksi)
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
            query = "select kode_barang,nama_barang,jenis_barang,jumlah_barang,Format([tanggal_input],'dd/mm/yyyy') as tanggal_input,dibuat_oleh from data_barang where 1=1"
            If Akhir <> nowdate And Awal <> nowdate Then
                query = query + " and tanggal_input between #" & Awal & "# and #" & Akhir & "#"
            End If
            If cmbjenisbarang.Text <> "--Pilih Jenis Barang--" Then
                query = query + " and jenis_barang = '" & cmbjenisbarang.Text & "'"
            End If
            query = query + " order by kode_barang asc"
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

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        bersih()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        bersih()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        bersih()
        tampil()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        cari()
    End Sub

    Private Sub LaporanDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampil()
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click
        cari()
    End Sub
End Class