Imports System.Data.OleDb
Public Class Form7
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Naea\source\repos\MRCM\MRCM1.0.accdb"
    Dim cmd As New OleDbDataAdapter
    Dim dt As New DataTable
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MRCM1_0DataSet1.PatientSchedule1' table. You can move, or remove it, as needed.
        Me.PatientSchedule1TableAdapter.Fill(Me._MRCM1_0DataSet1.PatientSchedule1)
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        cmd = New OleDbDataAdapter("SELECT * FROM PatientSchedule1", con)
        cmd.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim q As String = "SELECT * FROM PatientSchedule1 WHERE FullName2 LIKE '%" & TextBox1.Text & "%' OR PatientID LIKE '%" & TextBox1.Text & "%'"
        Using cmd1 As OleDbCommand = New OleDbCommand(q, con)
            Using da As OleDbDataAdapter = New OleDbDataAdapter
                da.SelectCommand = cmd1
                Using dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        DataGridView1.DataSource = dt
                    Else
                        MessageBox.Show("No Record Found")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim eex As Integer

        eex = MessageBox.Show("Do you want to Log-Out?", "Log-Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If eex = vbYes Then
            Application.ExitThread()
        End If
    End Sub
End Class