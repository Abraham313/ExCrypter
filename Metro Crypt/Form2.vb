Public Class Form2
    Private Sub XVisualButton1_Click(sender As Object, e As EventArgs) Handles XVisualButton1.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        Process.Start("http://ultimatenetwork.ru/")
    End Sub
End Class