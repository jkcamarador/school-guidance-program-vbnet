Imports System.ComponentModel
Public Class SearchResult
    Dim connection As OleDb.OleDbConnection
    Private Sub SearchResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.sectionmenu = 11 Then
            connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade11Sections.mdb")
        ElseIf Form1.sectionmenu = 12 Then
            connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade12Sections.mdb")
        ElseIf Form1.sectionmenu = 13 Then
            connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\RandomStudents.mdb")
        End If
        connection.Open()

        DatagridShow()
        If Form1.sectionmenu = 13 Then
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(0).Visible = False
        Else
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
        End If
        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("No Result/s Found")
            Me.Close()
        End If
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)
    End Sub

    Private Sub DatagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        ds.Tables.Add(dt)

        If Form1.sectionmenu = 11 Then
            If Form2.choice = 2 Then
                If Form1.section = 1 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01ANM WHERE Lastname='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 2 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01AUT WHERE Lastname='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 3 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01BPO WHERE Lastname='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 4 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CPG WHERE Lastname='" & Form1.lastname & "'", connection)
                Else
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CSS WHERE Lastname='" & Form1.lastname & "'", connection)
                End If
            Else
                If Form1.section = 1 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01ANM WHERE StudentNo='" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 2 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01AUT WHERE StudentNo='" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 3 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01BPO WHERE StudentNo='" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 4 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CPG WHERE StudentNo='" & Form1.stdno & "'", connection)
                Else
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CSS WHERE StudentNo='" & Form1.stdno & "'", connection)
                End If
            End If
        ElseIf Form1.sectionmenu = 12 Then
            If Form2.choice = 2 Then
                If Form1.section = 1 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01 WHERE LastName='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 2 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 02 WHERE LastName='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 3 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 03 WHERE LastName='" & Form1.lastname & "'", connection)
                ElseIf Form1.section = 4 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 04 WHERE LastName='" & Form1.lastname & "'", connection)
                Else
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 05 WHERE LastName='" & Form1.lastname & "'", connection)
                End If
            Else
                If Form1.section = 1 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 01 WHERE StudentNumber='" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 2 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 02 WHERE StudentNumber='" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 3 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 03 WHERE StudentNumber'" & Form1.stdno & "'", connection)
                ElseIf Form1.section = 4 Then
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 04 WHERE StudentNumber'" & Form1.stdno & "'", connection)
                Else
                    da = New OleDb.OleDbDataAdapter("SELECT * FROM 05 WHERE StudentNumber'" & Form1.stdno & "'", connection)
                End If
            End If
        Else
            If Form2.choice = 2 Then
                da = New OleDb.OleDbDataAdapter("Select * FROM Random WHERE Lastname='" & Form1.lastname & "'", connection)
            Else
                da = New OleDb.OleDbDataAdapter("SELECT * FROM Random WHERE StudentNo='" & Form1.stdno & "'", connection)
            End If
        End If

        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

        connection.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Form1.sectionmenu = 13 Then
            Form1.grsec = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Form1.firstname = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            Form1.lastname = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Form1.surname = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            Form1.gender1 = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            Form1.stdno = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            Form1.bday = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            Form1.remarks1 = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Else
            Form1.firstname = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Form1.lastname = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Form1.surname = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            Form1.gender1 = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            Form1.stdno = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            Form1.bday = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            Form1.remarks1 = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            Form1.tablename = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        End If
        If Form1.sectionmenu = 11 Then
            G11StudentsList.Close()
        ElseIf Form1.sectionmenu = 12 Then
            G12StudentsList.Close()
        ElseIf Form1.sectionmenu = 14 Then
            Form2.Hide()
        Else
            RandomRemarks.Close()
            Form1.sectionmenu = 13
        End If
        Me.Close()
        Remarks.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class