Public Class grade11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.section = 1
        Form1.sched = My.Resources.SECTION_1_ANM
        Form1.secname = Button1.Text
        Me.Close()
        G11StudentsList.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.section = 2
        Form1.sched = My.Resources.SECTION_1_AUT
        Form1.secname = Button2.Text
        Me.Close()
        G11StudentsList.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.section = 3
        Form1.sched = My.Resources.SECTION_1_BPO
        Form1.secname = Button3.Text
        Me.Close()
        G11StudentsList.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.section = 4
        Form1.sched = My.Resources.SECTION_1_CPG
        Form1.secname = Button4.Text
        Me.Close()
        G11StudentsList.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.section = 5
        Form1.sched = My.Resources.SECTION_1_CSS
        Form1.secname = Button5.Text
        Me.Close()
        G11StudentsList.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class