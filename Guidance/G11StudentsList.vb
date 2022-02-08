Imports System.ComponentModel
Public Class G11StudentsList
    Dim connection As OleDb.OleDbConnection
    Private Sub StudentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Grade11Sections.mdb")
        '\Users\KENETH\Desktop\Guidance
        connection.Open()

        DatagridShow()
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(6).Width = 60

        Label3.Text = DataGridView1.RowCount
        Label4.Text = Form1.secname
    End Sub
    Private Sub DatagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDb.OleDbDataAdapter

        If Form1.section = 1 Then
            da = New OleDb.OleDbDataAdapter("SELECT * FROM 01ANM", connection)
        ElseIf Form1.section = 2 Then
            da = New OleDb.OleDbDataAdapter("SELECT * FROM 01AUT", connection)
        ElseIf Form1.section = 3 Then
            da = New OleDb.OleDbDataAdapter("SELECT * FROM 01BPO", connection)
        ElseIf Form1.section = 4 Then
            da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CPG", connection)
        Else
            da = New OleDb.OleDbDataAdapter("SELECT * FROM 01CSS", connection)
        End If

        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Schedule.Show()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Form1.no1 = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Form1.lastname = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Form1.firstname = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Form1.surname = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Form1.stdno = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Form1.bday = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Form1.gender1 = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Form1.remarks1 = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Form1.tablename = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        Me.Close()
        Remarks.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.choice = 2
        Form1.lastname = TextBox2.Text
        SearchResult.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.choice = 1
        Form1.stdno = TextBox1.Text
        SearchResult.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        grade11.Show()
    End Sub
End Class