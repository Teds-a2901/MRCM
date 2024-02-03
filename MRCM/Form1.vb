Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Naea\source\repos\MRCM\MRCM1.0.accdb"
    Private Sub User_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "User ID" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Leave_User(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "User ID"
            TextBox1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Leave_Password(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"
            TextBox2.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM login WHERE UserID =? and Password =?", con)
            cmd.Parameters.AddWithValue("@UserID", OleDbType.VarChar).Value = TextBox1.Text.Trim()
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = TextBox2.Text.Trim()

            Dim count = Convert.ToInt32(cmd.ExecuteScalar)
            If count > 0 Then
                Me.Hide()
                Form3.Show()
            Else
                MessageBox.Show("Invalid User ID And Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End Using

        con.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
