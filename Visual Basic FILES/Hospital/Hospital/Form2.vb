Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Patient" And TextBox2.Text = "Password" Then
            Form3.Show()
        Else
            MsgBox("Please enter a valid username!")
        End If
    End Sub
End Class