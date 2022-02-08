Public Class Unlisted
    Private Sub Unlisted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(RichTextBox1.Text) Or String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrEmpty(TextBox6.Text) Or String.IsNullOrEmpty(TextBox7.Text) Or String.IsNullOrEmpty(ComboBox1.Text) Or String.IsNullOrEmpty(ComboBox2.Text) Or String.IsNullOrEmpty(ComboBox3.Text) Then
            MessageBox.Show("You must fill in all of the text fields first", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Len(TextBox4.Text) < 9 Or Len(TextBox4.Text) > 9 Then
            MessageBox.Show("Invalid Student No.")
        ElseIf ComboBox1.Text <> "January" And ComboBox1.Text <> "February" And ComboBox1.Text <> "March" And ComboBox1.Text <> "April" And ComboBox1.Text <> "May" And ComboBox1.Text <> "June" And ComboBox1.Text <> "July" And ComboBox1.Text <> "August" And ComboBox1.Text <> "September" And ComboBox1.Text <> "October" And ComboBox1.Text <> "November" And ComboBox1.Text <> "December" Then
            MessageBox.Show("Invalid Month")
        ElseIf Len(TextBox5.Text) > 2 Then
            MessageBox.Show("Invalid Day")
        ElseIf Len(TextBox6.Text) > 4 Or Len(TextBox6.Text) < 4 Then
            MessageBox.Show("Invalid Year")
        ElseIf ComboBox2.Text <> "M" And ComboBox2.Text <> "F" And ComboBox2.Text <> "Male" And ComboBox2.Text <> "Female" Then
            MessageBox.Show("Invalid Gender")
        ElseIf ComboBox3.Text <> "11" And ComboBox3.Text <> "12" Then
            MessageBox.Show("Invalid Grade")


        Else

            Dim conn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            conn.ConnectionString = “Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\RandomStudents.mdb”

            Try
                conn.Open()
                sqlquery.Connection = conn
                sqlquery.CommandText = "INSERT INTO Random (GradeAndSection, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks) VALUES ('" & ComboBox3.Text & " - " & TextBox7.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & " " & TextBox5.Text & ", " & TextBox6.Text & "','" & ComboBox2.Text & "','" & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "');"
                sqlquery.ExecuteNonQuery()
                conn.Close()
                If conn.State = ConnectionState.Open Then
                    MsgBox(“MS Database Connected!”)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Successfully added to remarks")
            Me.Close()
            RandomRemarks.Show()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) > 0 And Asc(e.KeyChar) < 31 Or Asc(e.KeyChar) > 32 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) > 0 And Asc(e.KeyChar) < 31 Or Asc(e.KeyChar) > 32 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) > 0 And Asc(e.KeyChar) < 31 Or Asc(e.KeyChar) > 32 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        RandomRemarks.Show()
    End Sub
End Class


'        MessageBox.Show("You have entered incorrect login details", "Closing Exams",
'                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

