Public Class remarksform2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            conn.ConnectionString = “Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade12Sections.mdb”

            'delete info from database
            Try
                conn.Open()
                sqlquery.Connection = conn

                If Form1.section = 1 Or Form1.tablename = "01" Then
                    sqlquery.CommandText = "DELETE FROM 01 WHERE StudentNumber='" & deletename & "';"
                ElseIf Form1.section = 2 Or Form1.tablename = "02" Then
                    sqlquery.CommandText = "DELETE FROM 02 WHERE StudentNumber='" & deletename & "';"
                ElseIf Form1.section = 3 Or Form1.tablename = "03" Then
                    sqlquery.CommandText = "DELETE FROM 03 WHERE StudentNumber='" & deletename & "';"
                ElseIf Form1.section = 4 Or Form1.tablename = "04" Then
                    sqlquery.CommandText = "DELETE FROM 04 WHERE StudentNumber='" & deletename & "';"
                ElseIf Form1.section = 5 Or Form1.tablename = "05" Then
                    sqlquery.CommandText = "DELETE FROM 05 WHERE StudentNumber='" & deletename & "';"
                End If

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
                    If Form1.section = 1 Or Form1.tablename = "01" Then
                        sqlquery.CommandText = "INSERT INTO 01 (LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 2 Or Form1.tablename = "02" Then
                        sqlquery.CommandText = "INSERT INTO 02 (LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 3 Or Form1.tablename = "03" Then
                        sqlquery.CommandText = "INSERT INTO 03 (LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 4 Or Form1.tablename = "04" Then
                        sqlquery.CommandText = "INSERT INTO 04 (LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 5 Or Form1.tablename = "05" Then
                        sqlquery.CommandText = "INSERT INTO 05 (LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    End If
                ElseIf Form1.addedit = 1 Then
                    If Form1.section = 1 Or Form1.tablename = "01" Then
                        sqlquery.CommandText = "INSERT INTO 01 (Number_, LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 2 Or Form1.tablename = "02" Then
                        sqlquery.CommandText = "INSERT INTO 02 (Number_, LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 3 Or Form1.tablename = "03" Then
                        sqlquery.CommandText = "INSERT INTO 03 (Number_, LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 4 Or Form1.tablename = "04" Then
                        sqlquery.CommandText = "INSERT INTO 04 (Number_, LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 5 Or Form1.tablename = "05" Then
                        sqlquery.CommandText = "INSERT INTO 05 (Number_, LastName, FirstName, MiddleName, StudentNumber, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    End If
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
            If Form1.sectionmenu = 14 Or Form1.sectionmenu = 15 Then
                Form2.Show()
            Else
                G12StudentsList.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Remarks.Show()
    End Sub
End Class