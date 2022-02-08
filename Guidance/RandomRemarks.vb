Imports System.ComponentModel
Public Class RandomRemarks
    Dim connection As OleDb.OleDbConnection
    Private Sub RandomRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\RandomStudents.mdb")
        connection.Open()
        DatagridShow()
        If DataGridView1.RowCount = 0 Then
            Label16.Visible = True
            DataGridView1.ColumnHeadersVisible = False
            DataGridView1.Enabled = False
        Else
            DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(7).Width = 60
            DataGridView1.Columns(8).Visible = False
        End If
    End Sub
    Private Sub DatagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDb.OleDbDataAdapter

        da = New OleDb.OleDbDataAdapter("SELECT * FROM Random", connection)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Unlisted.Show()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Form1.no1 = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Form1.grsec = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Form1.lastname = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Form1.firstname = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Form1.surname = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Form1.stdno = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Form1.bday = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Form1.gender1 = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Form1.remarks1 = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        Me.Close()
        Form1.sectionmenu = 13
        Remarks.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.sectionmenu = 13
        Form2.choice = 2
        Form1.lastname = TextBox2.Text
        SearchResult.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.sectionmenu = 13
        Form2.choice = 1
        Form1.stdno = TextBox1.Text
        SearchResult.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class