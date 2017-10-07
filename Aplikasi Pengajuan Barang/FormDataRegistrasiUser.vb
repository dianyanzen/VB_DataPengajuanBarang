Imports System.Data
Imports System.Data.OleDb
Public Class FormDataRegistrasiUser
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

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
    End Sub
    Sub bersih()
        txtusername.Text = ""
        txtnamalgkp.Text = ""
        txtpassword.Text = ""
        txtpassword2.Text = ""
    End Sub

    Private Sub FormDataRegistrasiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
    End Sub
    Sub save()
        konek()
        Try
            If txtnamalgkp.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtpassword.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtpassword2.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtusername.Text = "" Then
                MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical, "Perhatian")
            ElseIf txtpassword.Text <> txtpassword2.Text Then
                MsgBox("Password Tidak Sama", MsgBoxStyle.Critical, "Perhatian")
            Else
                OleDb = "select * from login where username = '" & txtusername.Text & "'"
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
                    OleDb = "insert into login values('" & txtusername.Text & "','" & txtpassword.Text & "',0 ,'" & txtnamalgkp.Text & "')"
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        save()
        Me.Hide()
        FormMaster.Hide()
        FormLogin.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Hide()
        FormMaster.Hide()
        FormLogin.Show()
    End Sub
End Class