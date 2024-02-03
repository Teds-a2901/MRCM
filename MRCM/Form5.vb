Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Naea\source\repos\MRCM\MRCM1.0.accdb"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource

        loaddata()
    End Sub

    Public result As String
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Dim str As String

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Sub loaddata()
        Try
            reload("SELECT * FROM doctorsre", ComboBox2)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "DoctorID"
            ComboBox2.ValueMember = "DoctorID"
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using add As New OleDbCommand("INSERT INTO doctorsre ([Name], [Address], [MedicalFieldSpecialization], [Age], [Sex], [Email], [TelephoneNumber], [CellphoneNumber])VALUES(@Name,@Address,@MedicalFieldSpecialization,@Age,@Sex,@Email,@TelephoneNumber,@CellphoneNumber)", con)
            add.Parameters.AddWithValue("@Name", OleDbType.VarChar).Value = TextBox1.Text.Trim()
            add.Parameters.AddWithValue("@Address", OleDbType.VarChar).Value = TextBox2.Text.Trim()
            add.Parameters.AddWithValue("@MedicalFieldSpecialization", OleDbType.VarChar).Value = ComboBox1.Text.Trim()
            add.Parameters.AddWithValue("@Age", OleDbType.VarChar).Value = TextBox4.Text.Trim()
            add.Parameters.AddWithValue("@Sex", OleDbType.VarChar).Value = TextBox5.Text.Trim()
            add.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = TextBox6.Text.Trim()
            add.Parameters.AddWithValue("@TelephoneNumber", OleDbType.VarChar).Value = TextBox7.Text.Trim()
            add.Parameters.AddWithValue("@CellphoneNumber", OleDbType.VarChar).Value = TextBox8.Text.Trim()


            If add.ExecuteNonQuery Then
                MessageBox.Show("Successful add to the record", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                ComboBox1.Text = ""
                ComboBox2.Text = ""
            End If
        End Using
        con.Close()
        loaddata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd2 As New OleDbCommand("Update doctorsre set Name='" & TextBox1.Text & "',Address='" & TextBox2.Text & "',MedicalFieldSpecialization='" & ComboBox1.Text & "',Age='" & TextBox4.Text & "',Sex='" & TextBox5.Text & "',Email='" & TextBox6.Text & "',TelephoneNumber='" & TextBox7.Text & "',CellphoneNumber='" & TextBox8.Text & "'where DoctorID=" & ComboBox2.Text & "", con)
        cmd2.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        loaddata()

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql = "Select * FROM doctorsre WHERE DoctorID Like '%" & ComboBox2.Text & "%'"
        cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item("Name").ToString
                TextBox2.Text = dt.Rows(0).Item("Address").ToString
                ComboBox1.Text = dt.Rows(0).Item("MedicalFieldSpecialization").ToString
                TextBox4.Text = dt.Rows(0).Item("Age").ToString
                TextBox5.Text = dt.Rows(0).Item("Sex").ToString
                TextBox6.Text = dt.Rows(0).Item("Email").ToString
                TextBox7.Text = dt.Rows(0).Item("TelephoneNumber").ToString
                TextBox8.Text = dt.Rows(0).Item("CellphoneNumber").ToString

            End If

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd1 As New OleDbCommand("Delete from doctorsre where doctorID =@DoctorID", con)
        cmd1.Parameters.AddWithValue("@DoctorID", ComboBox2.Text)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        loaddata()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        Form6.Show()
        Form6.Refresh()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class