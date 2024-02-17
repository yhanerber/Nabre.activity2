Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim a As Integer
        Dim b As Integer
        a = num1.Text
        b = num2.Text
        lblResult.Text = a - b
    End Sub
End Class
