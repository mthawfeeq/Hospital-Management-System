Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oradb As String = "Data Source=licetorcl; User ID=IT36; Password=licet;"
        Dim conn As New OracleConnection(oradb)
        Dim rowsupdated As Integer
        conn.Open()
        Dim cmd As New OracleCommand
        Dim cmd1 As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "Delete from patient where ID=" & TextBox1.Text
        rowsupdated = cmd.ExecuteNonQuery()
        If (rowsupdated <> 0) Then
            MessageBox.Show("Record deleted!")
        Else
            MessageBox.Show("Not deleted!")
        End If
        conn.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class