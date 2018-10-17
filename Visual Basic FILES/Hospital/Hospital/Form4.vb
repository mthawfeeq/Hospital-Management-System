Imports System.Data
Imports Oracle.DataAccess.Client 'ODP.NET Oracle Managed Provider
Imports Oracle.DataAccess.Types
Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oradb As String = "Data Source=licetorcl; User ID=IT36; Password=licet;"
        Dim conn As New OracleConnection(oradb)
        Dim rowsupdated As Integer
        conn.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "Insert into patient values(" & Val(TextBox1.Text) & ",'" & TextBox2.Text & "'," & Val(TextBox3.Text) & ",'" & ListBox1.SelectedItem.ToString() & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        rowsupdated = cmd.ExecuteNonQuery()
        If (rowsupdated = 0) Then
            MessageBox.Show("Record not inserted")
        Else
            MessageBox.Show("Success!")
        End If
        conn.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class