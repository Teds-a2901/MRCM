Imports System.Data.OleDb
Public Class Form8
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Naea\source\repos\MRCM\MRCM1.0.accdb"
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
            reload1("SELECT * FROM covid19screnning", ComboBox9)
            ComboBox9.DataSource = dt
            ComboBox9.DisplayMember = "Covid19ScreeningID"
            ComboBox9.ValueMember = "Covid19ScreeningID"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub reload1(ByVal sql As String, ByVal DTG As Object)
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
    Sub loaddata1()
        Try
            reload1("SELECT * FROM PatientSchedule1", ComboBox2)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "FullName2"
            ComboBox2.ValueMember = "FullName2"
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        Form9.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql = "Select * FROM PatientSchedule1 WHERE FullName2 Like '%" & ComboBox2.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item("Address2").ToString
                TextBox2.Text = dt.Rows(0).Item("ContactNumber2").ToString


            End If

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using add As New OleDbCommand("INSERT INTO covid19screnning ([Name_19], [Address_19], [ContactNumber_19], [Vaccine], [TypeOfVaccine], [Question1], [Question2], [Question3], [Question4], [Question5], [Arrival])VALUES(@Name_19,@Address_19,@ContactNumber_19,@Vaccine,@TypeOfVaccine,@Question1,@Question2,@Question3,@Question4,@Question5,@Arrival)", con)
            add.Parameters.AddWithValue("@Name_19", OleDbType.VarChar).Value = ComboBox2.Text.Trim()
            add.Parameters.AddWithValue("@Address_19", OleDbType.VarChar).Value = TextBox1.Text.Trim()
            add.Parameters.AddWithValue("@ContactNumber_19", OleDbType.VarChar).Value = TextBox2.Text.Trim()
            add.Parameters.AddWithValue("@Vaccine", OleDbType.VarChar).Value = ComboBox3.Text.Trim()
            add.Parameters.AddWithValue("@TypeOfVaccine", OleDbType.VarChar).Value = ComboBox4.Text.Trim()
            add.Parameters.AddWithValue("@Question1", OleDbType.VarChar).Value = ComboBox1.Text.Trim()
            add.Parameters.AddWithValue("@Question2", OleDbType.VarChar).Value = ComboBox5.Text.Trim()
            add.Parameters.AddWithValue("@Question3", OleDbType.VarChar).Value = ComboBox6.Text.Trim()
            add.Parameters.AddWithValue("@Question4", OleDbType.VarChar).Value = ComboBox8.Text.Trim()
            add.Parameters.AddWithValue("@Question5", OleDbType.VarChar).Value = ComboBox7.Text.Trim()
            add.Parameters.AddWithValue("@Arrival", OleDbType.VarChar).Value = DateTimePicker2.Text.Trim()
            If add.ExecuteNonQuery Then
                MessageBox.Show("Successful add to the Patient Record Schedule", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                ComboBox4.Text = ""
                ComboBox5.Text = ""
                ComboBox6.Text = ""
                ComboBox7.Text = ""
                ComboBox8.Text = ""
            End If
        End Using
        con.Close()
        loaddata1()
        loaddata()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd2 As New OleDbCommand("Update covid19screnning set Name_19='" & ComboBox2.Text & "',Address_19='" & TextBox1.Text & "',ContactNumber_19='" & TextBox2.Text & "',Vaccine='" & ComboBox3.Text & "',TypeOfVaccine='" & ComboBox4.Text & "',Arrival='" & DateTimePicker2.Text & "',Question1='" & ComboBox1.Text & "',Question2='" & ComboBox5.Text & "',Question3='" & ComboBox6.Text & "',Question4='" & ComboBox8.Text & "',Question5='" & ComboBox7.Text & "'where Covid19ScreeningID=" & ComboBox9.Text & "", con)

        cmd2.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        loaddata1()
        loaddata()
    End Sub
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss"
        con.ConnectionString = dbProvider & dbSource
        loaddata1()
        loaddata()
    End Sub
    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Try
            Dim sql1 As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql1 = "Select * FROM covid19screnning WHERE Covid19ScreeningID Like '%" & ComboBox9.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = sql1
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                ComboBox2.Text = dt.Rows(0).Item("Name_19").ToString
                TextBox1.Text = dt.Rows(0).Item("Address_19").ToString
                TextBox2.Text = dt.Rows(0).Item("ContactNumber_19").ToString
                ComboBox3.Text = dt.Rows(0).Item("Vaccine").ToString
                ComboBox4.Text = dt.Rows(0).Item("TypeOfVaccine").ToString
                ComboBox1.Text = dt.Rows(0).Item("Question1").ToString
                ComboBox5.Text = dt.Rows(0).Item("Question2").ToString
                ComboBox6.Text = dt.Rows(0).Item("Question3").ToString
                ComboBox8.Text = dt.Rows(0).Item("Question4").ToString
                ComboBox7.Text = dt.Rows(0).Item("Question5").ToString
                DateTimePicker2.Text = dt.Rows(0).Item("Arrival").ToString


            End If

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        DateTimePicker2.ResetText()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd1 As New OleDbCommand("Delete from covid19screnning where Covid19ScreeningID =@Covid19ScreeningID", con)
        cmd1.Parameters.AddWithValue("@Covid19ScreeningID", ComboBox9.Text)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        DateTimePicker2.ResetText()
        loaddata1()
        loaddata()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim eex As Integer

        eex = MessageBox.Show("Do you want to Log-Out?", "Log-Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If eex = vbYes Then
            Application.ExitThread()
        End If
    End Sub
End Class