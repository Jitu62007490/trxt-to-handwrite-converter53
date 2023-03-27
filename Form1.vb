Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, r, t, rad, si As Integer
        p = TextBox1.Text
        r = TextBox2.Text
        If RadioButton1.Checked = True Then
            TextBox3.Text = 1
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = 2
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = 3
        End If
        rad = TextBox3.Text
        si = (p * r * rad) / 100
        TextBox4.Text = si
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
