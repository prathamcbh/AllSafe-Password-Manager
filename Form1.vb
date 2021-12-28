Imports System.Data.SqlClient
Public Class Login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim a As String, b As String
    Dim count As Integer = -1

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles ButtonLogin.MouseHover
        ButtonLogin.BackColor = Color.Cyan
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles ButtonLogin.MouseEnter
        ButtonLogin.BackColor = Color.Cyan
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLogin.MouseLeave
        ButtonLogin.BackColor = Color.FromArgb(27, 26, 25)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Hide()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select unameAS,upassAS from login"
        cmd.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        sdr.Read()
        a = sdr("unameAS").ToString()
        b = sdr("upassAS").ToString()

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Enter Credentials to Username and Password", MsgBoxStyle.Critical, "Error")

        ElseIf a <> TextBox1.Text Then
            MsgBox("Check your Username", MsgBoxStyle.Critical, "Check Username")

        ElseIf a = TextBox1.Text And b <> TextBox2.Text Then
            LinkLabel1.Show()
            MsgBox("Check your password", MsgBoxStyle.Critical, "Check your password")

        ElseIf a = TextBox1.Text And b = TextBox2.Text Then
            Dashboard.Show()
            Me.Close()
        End If
        con.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonsignup.Click

        Form2.Show()
        Me.Close()
    End Sub

End Class
