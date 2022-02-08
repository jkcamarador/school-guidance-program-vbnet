Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AutoScroll = False
        Me.VerticalScroll.Visible = False
        Me.HorizontalScroll.Visible = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class