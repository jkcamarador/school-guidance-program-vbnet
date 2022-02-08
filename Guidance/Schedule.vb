Public Class Schedule
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.secname
        PictureBox3.Image = (Form1.sched)
        PictureBox3.Location = New Point((Panel1.Width / 2) - (PictureBox3.Width / 2), (Panel1.Height / 2) - (PictureBox3.Height / 2))
        Label1.Location = New Point((Panel2.Width / 2) - (Label1.Width / 2), (Panel2.Height / 2) - (Label1.Height / 2))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
        If Form1.sectionmenu = 11 Then
            G11StudentsList.Show()
        Else
            G12StudentsList.Show()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        If Form1.sectionmenu = 11 Then
            G11StudentsList.Show()
        Else
            G12StudentsList.Show()
        End If
    End Sub
End Class