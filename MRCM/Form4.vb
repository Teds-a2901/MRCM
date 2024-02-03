Imports System.Data.OleDb
Public Class Form4
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Naea\source\repos\MRCM\MRCM1.0.accdb"
    Public result As String
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Dim str As String

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
            reload1("SELECT * FROM doctorsre", ComboBox3)
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "DoctorID"
            ComboBox3.ValueMember = "DoctorID"
        Catch ex As Exception

        End Try
    End Sub

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
            reload("SELECT * FROM PatientSchedule1", ComboBox1)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "PatientID"
            ComboBox1.ValueMember = "PatientID"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"


        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        loaddata1()
        loaddata()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        Form5.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using add As New OleDbCommand("INSERT INTO PatientSchedule1 ([FullName2], [Address2], [ContactNumber2], [EmergencyContactNumber2], [EmailAddress2], [Nationality2], [Sex2], [Diagnosis2], [DoctorName2], [MedicalFieldSpecialization2], [StartingSchedule], [EndOfSchedule])VALUES(@FullName2,@Address2,@ContactNumber2,@EmergencyContactNumber2,@EmailAddress2,@Nationality2,@Sex2,@Diagnosis2,@DoctorName2,@MedicalFieldSpecialization2,@StartingSchedule,@EndOfSchedule)", con)
            add.Parameters.AddWithValue("@FullName2", OleDbType.VarChar).Value = TextBox1.Text.Trim()
            add.Parameters.AddWithValue("@Address2", OleDbType.VarChar).Value = TextBox2.Text.Trim()
            add.Parameters.AddWithValue("@ContactNumber2", OleDbType.VarChar).Value = TextBox3.Text.Trim()
            add.Parameters.AddWithValue("@EmergencyContactNumber2", OleDbType.VarChar).Value = TextBox4.Text.Trim()
            add.Parameters.AddWithValue("@EmailAddress2", OleDbType.VarChar).Value = TextBox5.Text.Trim()
            add.Parameters.AddWithValue("@Nationality2", OleDbType.VarChar).Value = TextBox6.Text.Trim()
            add.Parameters.AddWithValue("@Sex2", OleDbType.VarChar).Value = ComboBox2.Text.Trim()
            add.Parameters.AddWithValue("@Diagnosis2", OleDbType.VarChar).Value = TextBox7.Text.Trim()
            add.Parameters.AddWithValue("@DoctorName2", OleDbType.VarChar).Value = ComboBox3.Text.Trim()
            add.Parameters.AddWithValue("@MedicalFieldSpecialization2", OleDbType.VarChar).Value = TextBox8.Text.Trim()
            add.Parameters.AddWithValue("@StartingSchedule", OleDbType.VarChar).Value = DateTimePicker2.Text.Trim()
            add.Parameters.AddWithValue("@EndOfSchedule", OleDbType.VarChar).Value = DateTimePicker3.Text.Trim()
            If add.ExecuteNonQuery Then
                MessageBox.Show("Successful add to the Patient Record Schedule", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""

            End If
        End Using
        con.Close()
        loaddata1()
        loaddata()
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql = "Select * FROM doctorsre WHERE Name Like '%" & ComboBox3.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox8.Text = dt.Rows(0).Item("MedicalFieldSpecialization").ToString

            End If

        Catch ex As Exception
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql = "Select * FROM PatientSchedule1 WHERE PatientID Like '%" & ComboBox1.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item("FullName2").ToString
                TextBox2.Text = dt.Rows(0).Item("Address2").ToString
                TextBox3.Text = dt.Rows(0).Item("ContactNumber2").ToString
                TextBox4.Text = dt.Rows(0).Item("EmergencyContactNumber2").ToString
                TextBox5.Text = dt.Rows(0).Item("EmailAddress2").ToString
                TextBox6.Text = dt.Rows(0).Item("Nationality2").ToString
                ComboBox2.Text = dt.Rows(0).Item("Sex2").ToString
                TextBox7.Text = dt.Rows(0).Item("Diagnosis2").ToString
                ComboBox3.Text = dt.Rows(0).Item("DoctorName2").ToString
                TextBox8.Text = dt.Rows(0).Item("MedicalFieldSpecialization2").ToString
                DateTimePicker2.Text = dt.Rows(0).Item("StartingSchedule").ToString
                DateTimePicker3.Text = dt.Rows(0).Item("EndOfSchedule").ToString

            End If

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        Button1.Enabled = True
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        DateTimePicker2.ResetText()
        DateTimePicker3.ResetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd2 As New OleDbCommand("Update PatientSchedule1 set FullName2='" & TextBox1.Text & "',Address2='" & TextBox2.Text & "',ContactNumber2='" & TextBox3.Text & "',EmergencyContactNumber2='" & TextBox4.Text & "',EmailAddress2='" & TextBox5.Text & "',Nationality2='" & TextBox6.Text & "',Sex2='" & ComboBox2.Text & "',Diagnosis2='" & TextBox7.Text & "',DoctorName2='" & ComboBox3.Text & "',MedicalFieldSpecialization2='" & TextBox8.Text & "',StartingSchedule='" & DateTimePicker2.Text & "',EndOfSchedule='" & DateTimePicker3.Text & "'where PatientID=" & ComboBox1.Text & "", con)
        cmd2.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        DateTimePicker2.ResetText()
        DateTimePicker3.ResetText()
        loaddata()
        loaddata1()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd1 As New OleDbCommand("Delete from PatientSchedule1 where PatientID =@PatientID", con)
        cmd1.Parameters.AddWithValue("@PatientID", ComboBox1.Text)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        loaddata1()
        loaddata()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim eex As Integer

        eex = MessageBox.Show("Do you want to Log-Out?", "Log-Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If eex = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM PatientSchedule1 WHERE StartingSchedule =? and EndOfSchedule =?", con)

            cmd.Parameters.AddWithValue("@StartingSchedule", OleDbType.VarChar).Value = DateTimePicker2.Text.Trim()
            cmd.Parameters.AddWithValue("@EndOfSchedule", OleDbType.VarChar).Value = DateTimePicker3.Text.Trim()

            Dim count = Convert.ToInt32(cmd.ExecuteScalar)
            If count > 0 Then
                MessageBox.Show("The Schedule time are not Available", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Button1.Enabled = False
                Exit Sub
            ElseIf Button1.Enabled = True Then
                MessageBox.Show("Schedule time are Available", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Using
    End Sub
End Class