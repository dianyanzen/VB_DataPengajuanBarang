Imports System.Data
Imports System.Data.OleDb
Public Class FormMaster
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dian Yanzen\Documents\Visual Studio 2013\Projects\Aplikasi Pengajuan Barang\Aplikasi Pengajuan Barang\bin\Debug\db_barang.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Try
            konek()
            conn.Close()
            conn.Open()
            OleDb = "update login set is_active ='0'  where 1=1"
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            cmd.ExecuteNonQuery()
            Me.Hide()
            FormLogin.Show()
            conn.Close()
        Catch ex As Exception
            Me.Hide()
            FormLogin.Show()
        End Try
        
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FormDataBarang.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        FormDataPemohonvb.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        FormPermintaanBarang.Show()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        FormPemeriksaanBarang.Show()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        FormPenerimaanBarang.Show()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        FormDataRegistrasiUser.Show()
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        LaporanDataBarang.Show()
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        LaporanDataPemohon.Show()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        LaporanPermintaanBarang.Show()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        LaporanPemeriksaanBarang.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        LaporanPenerimaanBarang.Show()
    End Sub
End Class