Imports System.Data
Imports System.Data.OleDb
Public Class FormLogin
    Public OleDb, koneksi As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public Sub konek()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_barang.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub
    Sub login()
        Try
            konek()
            OleDb = "select * from login where username ='" & txtusername.Text & "' and password = '" & txtpassword.Text & "'"
            conn.Open()
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn.Close()
                conn.Open()
                OleDb = "update login set is_active ='1'  where username ='" & txtusername.Text & "' and password = '" & txtpassword.Text & "'"
                cmd = New OleDb.OleDbCommand(OleDb, conn)
                cmd.ExecuteNonQuery()
                Me.Hide()
                FormMaster.Show()
                rd.Close()
                conn.Close()
            Else
                MsgBox("Username Atau Password Salah !", MsgBoxStyle.Critical, "Perhatian")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Pencarian Gagal !!!, karena " & ex.Message)
        End Try
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        login()
    End Sub
    
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            konek()
            conn.Close()
            conn.Open()
            OleDb = "update login set is_active ='0'  where 1=1"
            cmd = New OleDb.OleDbCommand(OleDb, conn)
            cmd.ExecuteNonQuery()
            Me.Hide()
            conn.Close()
        Catch ex As Exception
            Me.Hide()
        End Try
    End Sub
End Class