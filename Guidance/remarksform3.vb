Public Class remarksform3
    Private Sub remarksform3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.firstname
        Label2.Text = Form1.surname
        Label3.Text = Form1.lastname
        Label10.Text = Form1.stdno
        Label11.Text = Form1.bday
        Label12.Text = Form1.gender1
        Label9.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        If Form1.addedit = 2 Then
            RichTextBox1.Text = Form1.remarks1
        ElseIf Form1.addedit = 1 Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(RichTextBox1.Text) Then
            MessageBox.Show("You must fill in the text field first")
        Else
            Dim conn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim deletename As String
            deletename = Label10.Text
            conn.ConnectionString = “Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\RandomStudents.mdb”
            'delete info from database
            Try
                conn.Open()
                sqlquery.Connection = conn

                sqlquery.CommandText = "DELETE FROM Random WHERE StudentNo='" & deletename & "';"

                sqlquery.ExecuteNonQuery()
                conn.Close()

                If conn.State = ConnectionState.Open Then
                    MsgBox(“MS Database Connected!”)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'update database
            Try
                conn.Open()
                sqlquery.Connection = conn

                If Form1.addedit = 2 Then
                    sqlquery.CommandText = "INSERT INTO Random (GradeAndSection, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks) VALUES ('" & Form1.grsec & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "');"

                ElseIf Form1.addedit = 1 Then
                    sqlquery.CommandText = "INSERT INTO Random (Number_, GradeAndSection, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks) VALUES ('" & Form1.no1 & "','" & Form1.grsec & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "');"
                End If

                sqlquery.ExecuteNonQuery()
                conn.Close()
                If conn.State = ConnectionState.Open Then
                    MsgBox(“MS Database Connected!”)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Successfully added to remarks")
            RandomRemarks.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Remarks.Show()
    End Sub
End Class