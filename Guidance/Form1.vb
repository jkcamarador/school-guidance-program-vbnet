Public Class Form1
    Public addedit As Integer
    Public secname As String
    Public section As Integer
    Public firstname As String
    Public lastname As String
    Public surname As String
    Public stdno As String
    Public bday As String
    Public gender1 As String
    Public remarks1 As String
    Public sectionmenu As Integer
    Public grsec As String
    Public sched As Image
    Public tablename As String
    Public no1 As Integer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sectionmenu = 11
        grade11.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sectionmenu = 12
        grade12.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Remarks.Show()
        Me.Hide()
    End Sub
End Class
