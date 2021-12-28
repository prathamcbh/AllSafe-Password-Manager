Imports System.Text
Imports System.Data.SqlClient
Public Class NewPass
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand

    Function RandomString(minCharacters As Integer, maxCharacters As Integer)

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()+-{}[]~<>"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TextBoxpass.Text = RandomString(8, 25)
    End Sub



    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxsite.Clear()
        TextBoxuname.Clear()
        TextBoxpass.Clear()
        TextBoxlink.Clear()
        IC.SendToBack()
        IO.BringToFront()
    End Sub


    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub IO_Click_1(sender As Object, e As EventArgs) Handles IO.Click
        IC.BringToFront()
        TextBoxpass.PasswordChar = ""
    End Sub

    Private Sub IC_Click(sender As Object, e As EventArgs) Handles IC.Click
        IO.BringToFront()
        TextBoxpass.PasswordChar = "*"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxsite.Text = "" Or TextBoxuname.Text = "" Or TextBoxpass.Text = "" Or TextBoxlink.Text = "" Then
            MsgBox("Fill in all the fields to proceed.", MsgBoxStyle.Information, "Enter Details!")
        ElseIf TextBoxuname.Text.Trim = "" Then
            MsgBox("Username cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxpass.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxsite.Text.Trim = "" Then
            MsgBox("Site cannot have just spaces. Please re-insert the Site!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxlink.Text.Trim = "" Then
            MsgBox("Link cannot have just spaces. Please re-insert the Link!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxsite.Text.Contains(" ") Then
            MsgBox("Site cannot have spaces. Please Re-insert the Site name", MsgBoxStyle.Information, "Check site name")
        ElseIf TextBoxlink.Text.Contains(" ") Then
            MsgBox("Link cannot have spaces. Please Re-insert correct Link", MsgBoxStyle.Information, "Check Website link")
        Else

            con.Open()
            Dim cmd4 As New SqlCommand
            Dim cmd2 As New SqlCommand, cmd3 As New SqlCommand
            Dim n As Integer = -1



            cmd3.Connection = con
            cmd3.CommandText = "Select count ([lsite]) from [Main] where lsite like ('%" + TextBoxsite.Text + "%')"
            n = Convert.ToInt32(cmd3.ExecuteScalar())
            con.Close()

            If n > 0 Then
                n += 1
                Dim x As String = TextBoxsite.Text + " (" + n.ToString + ")"

                con.Open()
                cmd2.Connection = con
                cmd2.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxlink.Text + "','" + TextBoxpass.Text + "','" + TextBoxuname.Text + "','" + x + "' )"

                cmd2.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                cmd4.Connection = con
                cmd4.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxlink.Text + "','" + TextBoxpass.Text + "','" + TextBoxuname.Text + "','" + TextBoxsite.Text + "' )"
                cmd4.ExecuteNonQuery()
                con.Close()

            End If
            MsgBox("Account successfully created", MsgBoxStyle.Information, "Success!")
            Dashboard.Refresh()
            Dashboard.ResetText()

            Dashboard.Show()

            Me.Close()
        End If
    End Sub
End Class