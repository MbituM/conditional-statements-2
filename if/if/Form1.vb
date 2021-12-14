Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = txtnum.Text
        If (num < 5) Then
            MessageBox.Show("no room available")
        ElseIf (num >= 5 And num <= 20) Then
            MessageBox.Show("room A2")

        ElseIf (num >= 21 And num <= 30) Then
            MessageBox.Show("lab 4")

        ElseIf (num >= 31 And num <= 60) Then
            MessageBox.Show("Lab 1")

        ElseIf (num >= 61 And num <= 100) Then
            MessageBox.Show("Lab 3")
        Else
            MessageBox.Show("no room available")

        End If

    End Sub
End Class
