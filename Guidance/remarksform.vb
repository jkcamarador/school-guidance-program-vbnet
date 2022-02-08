Public Class remarksform
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
            conn.ConnectionString = “Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade11Sections.mdb”
            'delete info from database
            Try
                conn.Open()
                sqlquery.Connection = conn

                If Form1.section = 1 Or Form1.tablename = "01ANM" Then
                    sqlquery.CommandText = "DELETE FROM 01ANM WHERE StudentNo='" & deletename & "';"
                ElseIf Form1.section = 2 Or Form1.tablename = "01AUT" Then
                    sqlquery.CommandText = "DELETE FROM 01AUT WHERE StudentNo='" & deletename & "';"
                ElseIf Form1.section = 3 Or Form1.tablename = "01BPO" Then
                    sqlquery.CommandText = "DELETE FROM 01BPO WHERE StudentNo='" & deletename & "';"
                ElseIf Form1.section = 4 Or Form1.tablename = "01CPG" Then
                    sqlquery.CommandText = "DELETE FROM 01CPG WHERE StudentNo='" & deletename & "';"
                ElseIf Form1.section = 5 Or Form1.tablename = "01CSS" Then
                    sqlquery.CommandText = "DELETE FROM 01CSS WHERE StudentNo='" & deletename & "';"
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
                    If Form1.section = 1 Or Form1.tablename = "01ANM" Then
                        sqlquery.CommandText = "INSERT INTO 01ANM (No, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 2 Or Form1.tablename = "01AUT" Then
                        sqlquery.CommandText = "INSERT INTO 01AUT (Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 3 Or Form1.tablename = "01BPO" Then
                        sqlquery.CommandText = "INSERT INTO 01BPO (Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 4 Or Form1.tablename = "01CPG" Then
                        sqlquery.CommandText = "INSERT INTO 01CPG (Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 5 Or Form1.tablename = "01CSS" Then
                        sqlquery.CommandText = "INSERT INTO 01CSS (Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & RichTextBox1.Text & "','" & Form1.tablename & "');"
                    End If
                ElseIf Form1.addedit = 1 Then
                    If Form1.section = 1 Or Form1.tablename = "01ANM" Then
                        sqlquery.CommandText = "INSERT INTO 01ANM (Number_, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 2 Or Form1.tablename = "01AUT" Then
                        sqlquery.CommandText = "INSERT INTO 01AUT (Number_, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 3 Or Form1.tablename = "01BPO" Then
                        sqlquery.CommandText = "INSERT INTO 01BPO (Number_, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 4 Or Form1.tablename = "01CPG" Then
                        sqlquery.CommandText = "INSERT INTO 01CPG (Number_, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
                    ElseIf Form1.section = 5 Or Form1.tablename = "01CSS" Then
                        sqlquery.CommandText = "INSERT INTO 01CSS (Number_, Lastname, Firstname, Middlename, StudentNo, BirthDate, Gender, Remarks, SectionName) VALUES ('" & Form1.no1 & "','" & Label3.Text & "','" & Label1.Text & "','" & Label2.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & Label12.Text & "','" & Form1.remarks1 & RichTextBox1.Text & Environment.NewLine & "Date: " & Label9.Text & Environment.NewLine & Environment.NewLine & "','" & Form1.tablename & "');"
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
                G11StudentsList.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.Close()
        Remarks.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Remarks.Show()
    End Sub
End Class