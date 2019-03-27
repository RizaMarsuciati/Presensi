Imports System.Data.OleDb
Imports Sekolah

Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        BUKAKONEKSI()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        login()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
    Private Function getId() As String
        DTA = New OleDbDataAdapter("Select id_petugas from PETUGAS where nama_petugas='" + TxtUsername.Text + "' AND password='" + TxtPassword.Text + "'", BUKAKONEKSI)
        DTS = New DataSet()
        DTA.Fill(DTS, "PETUGAS")
        Dim baru = DTS.Tables("PETUGAS").Rows(0).Item(0)
        If baru = "0" Then
            MessageBox.Show("")
        Else
            Return baru
        End If
    End Function

    Private Function login()

        Dim Sql, user, pass As String
            user = TxtUsername.Text
            pass = TxtPassword.Text
            Call BUKAKONEKSI()
            Sql = "Select * from PETUGAS where nama_petugas='" + user + "' AND password='" + pass + "'"
            CMD = New OleDbCommand(Sql, koneksi)
            DTR = CMD.ExecuteReader()
            With FormBeranda
                .petugas = getId()
            End With

            If DTR.HasRows = True Then

                Dim tmp = TxtUsername.Text.Substring(0, 2)
                If tmp = "AD" Then
                    FormAdmin.Show()
                    Me.Hide()
                Else

                    FormBeranda.Show()
                    Me.Hide()
                End If


            Else
                MessageBox.Show("Username dan password salah", "Konfirmasi",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUsername.Focus()
            End If
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            TUTUPKONEKSI()
            CMD.Dispose()

    End Function
End Class
