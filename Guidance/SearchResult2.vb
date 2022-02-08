Imports System.ComponentModel
Public Class SearchResult2
    Dim connection As OleDb.OleDbConnection
    Dim connection2 As OleDb.OleDbConnection

    Private Sub SearchResult2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade11Sections.mdb")
        connection.Open()
        connection2 = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade12Sections.mdb")
        connection2.Open()

        DatagridShow()
        DatagridShow2()
        DataGridView1.Columns(6).Visible = False
        DataGridView2.Columns(6).Visible = False
        If DataGridView1.RowCount = 0 And DataGridView2.RowCount = 0 Then
            MessageBox.Show("No Result/s Found")
            Me.Close()
        ElseIf DataGridView1.RowCount = 0 Then
            Label3.Visible = True
            DataGridView1.ColumnHeadersVisible = False
        ElseIf DataGridView2.RowCount = 0 Then
            Label4.Visible = True
            DataGridView2.ColumnHeadersVisible = False
        End If
        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)
        DataGridView2.Sort(DataGridView2.Columns(0), ListSortDirection.Ascending)
    End Sub


    Private Sub DatagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        ds.Tables.Add(dt)
        If Form2.choice = 2 Then
            da = New OleDb.OleDbDataAdapter("           SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01ANM WHERE Lastname = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01AUT WHERE Lastname = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01BPO WHERE Lastname = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01CPG WHERE Lastname = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01CSS WHERE Lastname = '" & Form1.lastname & "'", connection)
        ElseIf Form2.choice = 1 Then
            da = New OleDb.OleDbDataAdapter("           SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01ANM WHERE StudentNo = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01AUT WHERE StudentNo = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01BPO WHERE StudentNo = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01CPG WHERE StudentNo = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT Lastname as [Lastname], Firstname as [Firstname], Middlename as [Middlename], StudentNo as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01CSS WHERE StudentNo = '" & Form1.stdno & "'", connection)
        End If
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        connection.Close()
    End Sub

    Private Sub DatagridShow2()
        Dim ds1 As New DataSet
        Dim dt1 As New DataTable
        Dim da1 As New OleDb.OleDbDataAdapter
        ds1.Tables.Add(dt1)
        If Form2.choice = 2 Then
            da1 = New OleDb.OleDbDataAdapter("           SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01 WHERE LastName = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 02 WHERE LastName = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 03 WHERE LastName = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 04 WHERE LastName = '" & Form1.lastname & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 05 WHERE LastName = '" & Form1.lastname & "'", connection2)
        ElseIf Form2.choice = 1 Then
            da1 = New OleDb.OleDbDataAdapter("           SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 01 WHERE StudentNumber = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 02 WHERE StudentNumber = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 03 WHERE StudentNumber = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 04 WHERE StudentNumber = '" & Form1.stdno & "'" &
                                        " UNION ALL SELECT LastName as [Lastname], FirstName as [Firstname], MiddleName as [Middlename], StudentNumber as [StudentNo], BirthDate as [BirthDate], Gender as [Gender], Remarks as [Remarks], SectionName as [SectionName] FROM 05 WHERE StudentNumber = '" & Form1.stdno & "'", connection2)
        End If
        da1.Fill(dt1)
        DataGridView2.DataSource = dt1.DefaultView
        connection2.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Form1.firstname = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Form1.lastname = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Form1.surname = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Form1.gender1 = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Form1.stdno = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Form1.bday = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Form1.remarks1 = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Form1.tablename = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Form1.sectionmenu = 14
        Form2.Hide()

        DataGridView1.ColumnHeadersVisible = True
        DataGridView2.ColumnHeadersVisible = True
        Label3.Visible = False
        Label4.Visible = False

        Me.Close()
        Remarks.Show()
    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Form1.firstname = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        Form1.lastname = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        Form1.surname = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        Form1.gender1 = DataGridView2.CurrentRow.Cells(5).Value.ToString()
        Form1.stdno = DataGridView2.CurrentRow.Cells(3).Value.ToString()
        Form1.bday = DataGridView2.CurrentRow.Cells(4).Value.ToString()
        Form1.remarks1 = DataGridView2.CurrentRow.Cells(6).Value.ToString()
        Form1.tablename = DataGridView2.CurrentRow.Cells(7).Value.ToString()
        Form1.sectionmenu = 15
        Form2.Hide()

        DataGridView1.ColumnHeadersVisible = True
        DataGridView2.ColumnHeadersVisible = True
        Label3.Visible = False
        Label4.Visible = False

        Me.Close()
        Remarks.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        DataGridView1.ColumnHeadersVisible = True
        DataGridView2.ColumnHeadersVisible = True
        Label3.Visible = False
        Label4.Visible = False
    End Sub
End Class