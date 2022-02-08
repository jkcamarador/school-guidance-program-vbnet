Public Class Remarks
    Private Sub remarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.remarks1 = "" Then
            Label16.Visible = True
        End If

        Panel1.AutoScroll = True
        Panel1.VerticalScroll.Visible = True
        Panel1.HorizontalScroll.Visible = True

        Label4.Text = Form1.firstname
        Label2.Text = Form1.surname
        Label3.Text = Form1.lastname
        Label1.Text = Form1.remarks1
        Label15.Text = Form1.stdno
        Label14.Text = Form1.bday
        Label13.Text = Form1.gender1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.addedit = 1
        Me.Close()
        If Form1.sectionmenu = 11 Or Form1.sectionmenu = 14 Then
            remarksform.Show()
        ElseIf Form1.sectionmenu = 12 Or Form1.sectionmenu = 15 Then
            remarksform2.Show()
        Else
            remarksform3.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.remarks1 = "" Then
            MessageBox.Show("Nothing to edit")
        Else
            Form1.addedit = 2
            Me.Close()
            If Form1.sectionmenu = 11 Or Form1.sectionmenu = 14 Then
                remarksform.Show()
            ElseIf Form1.sectionmenu = 12 Or Form1.sectionmenu = 15 Then
                remarksform2.Show()
            Else
                remarksform3.Show()
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        If Form1.sectionmenu = 11 Then
            G11StudentsList.Show()
        ElseIf Form1.sectionmenu = 13 Then
            RandomRemarks.Show()
        ElseIf Form1.sectionmenu = 14 Or Form1.sectionmenu = 15 Then
            Form2.Show()
        Else
            G12StudentsList.Show()
        End If
    End Sub
End Class