
Public Class Form2
    Public choice As Integer
    Public event1 As Integer = 1
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Button11.Visible = False
        Button10.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Button11.Visible = True
        Button10.Visible = False
        Panel3.Visible = False
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel7.BackColor = Color.FromArgb(10, Color.Black)
        Button10.Visible = False
        Panel7.AutoScroll = True
        Panel7.VerticalScroll.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.sectionmenu = 11
        grade11.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.sectionmenu = 12
        grade12.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        RandomRemarks.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel8.Visible = True
        If Panel3.Visible = True Then
            Button10.Visible = False
            Panel3.Visible = False
            Button11.Visible = True
        End If
        PictureBox14.Image = PictureBox11.Image
        If event1 = 1 Then
            Label2.Visible = True
        ElseIf event1 = 2 Then
            Label3.Visible = True
        ElseIf event1 = 3 Then
            Label8.Visible = True
        ElseIf event1 = 4 Then
            Label9.Visible = True
        ElseIf event1 = 5 Then
            Label10.Visible = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Panel8.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        choice = 2
        Form1.lastname = TextBox2.Text
        SearchResult2.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        choice = 1
        Form1.stdno = TextBox1.Text
        SearchResult2.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button11.Visible = True
        Button10.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Visible = False
        Button10.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If event1 = 2 Then
            PictureBox11.Image = My.Resources.event1
            PictureBox12.Image = My.Resources.event2
            PictureBox13.Image = My.Resources.event3
            event1 = 1
            Button13.Visible = False
        ElseIf event1 = 3 Then
            PictureBox11.Image = My.Resources.event4
            PictureBox12.Image = My.Resources.event5
            PictureBox13.Image = My.Resources.event6
            event1 = 2

        ElseIf event1 = 4 Then
            PictureBox11.Image = My.Resources.event7
            PictureBox12.Image = My.Resources.event8
            PictureBox13.Image = My.Resources.event9
            event1 = 3

        ElseIf event1 = 5 Then
            PictureBox11.Image = My.Resources.event12
            PictureBox12.Image = My.Resources.event10
            PictureBox13.Image = My.Resources.event11
            event1 = 4
            Button14.Visible = True
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If event1 = 1 Then
            PictureBox11.Image = My.Resources.event4
            PictureBox12.Image = My.Resources.event5
            PictureBox13.Image = My.Resources.event6
            event1 = 2
            Button13.Visible = True
        ElseIf event1 = 2 Then
            PictureBox11.Image = My.Resources.event7
            PictureBox12.Image = My.Resources.event8
            PictureBox13.Image = My.Resources.event9
            event1 = 3
        ElseIf event1 = 3 Then
            PictureBox11.Image = My.Resources.event12
            PictureBox12.Image = My.Resources.event10
            PictureBox13.Image = My.Resources.event11
            event1 = 4
        ElseIf event1 = 4 Then
            PictureBox11.Image = My.Resources.event13
            PictureBox12.Image = My.Resources.event14
            PictureBox13.Image = My.Resources.event15
            event1 = 5
            Button14.Visible = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 13 Then
                choice = 2
                Form1.lastname = TextBox2.Text
                SearchResult2.ShowDialog()
            End If
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 13 Then
                choice = 1
                Form1.stdno = TextBox1.Text
                SearchResult2.ShowDialog()
            End If
        End If
    End Sub
End Class