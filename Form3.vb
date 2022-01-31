Imports System.Data.SqlClient
Imports System.Text
Public Class Form3
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim a As String
    Dim b As String
    Private Sub rstbtn_MouseEnter(sender As Object, e As EventArgs) Handles rstbtn.MouseEnter
        rstbtn.BackColor = Color.Cyan
    End Sub

    Private Sub rstbtn_MouseLeave(sender As Object, e As EventArgs) Handles rstbtn.MouseLeave
        rstbtn.BackColor = Color.FromArgb(27, 26, 25)
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub rstbtn_Click(sender As Object, e As EventArgs) Handles rstbtn.Click
        Dim CurChar As String
        Dim HasNum As Boolean
        Dim HasCaps As Boolean
        Dim HasLower As Boolean
        Dim HasChar As Boolean
        Dim x As Long
        Dim MinLength As Integer = 8
        Dim PW As String = TextBoxC.Text
        Dim chk As Boolean


        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select bkpstr,upassAS from login"
        cmd.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        sdr.Read()
        a = sdr("bkpstr").ToString()
        b = sdr("upassAS").ToString()
        con.Close()

        If TextBoxN.Text = "" Or TextBoxC.Text = "" Or TextBoxR.Text = "" Then
            MsgBox("Enter the Recovery Key and Password!", MsgBoxStyle.Exclamation, "Enter all fields")
            chk = True
        ElseIf a <> TextBoxR.Text Then
            MsgBox("That Recovery key did not match. Please try again!", MsgBoxStyle.Exclamation, "Check Recovery Key")
            chk = True

        ElseIf Len(PW) < MinLength Then
            MsgBox("Password should be atleast 8 charcters", MsgBoxStyle.Exclamation, "Warning!")
            chk = True
        ElseIf TextBoxN.Text <> TextBoxC.Text Then
            MsgBox("Those passwords did not match. Please try again!", MsgBoxStyle.Critical, "Password didn't match")
            chk = True
        ElseIf TextBoxN.Text = b Then
            MsgBox("New password cannot be same as existing password. Please re-enter new password, or click on back to continue same password.", MsgBoxStyle.Critical, "Password matches existing password")
            chk = True
        ElseIf TextBoxC.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
            chk = True

        Else
            For x = 1 To Len(PW)
                CurChar = Mid(PW, x, 1)
                Select Case Asc(CurChar)
                    Case 32 To 47       'Characters
                        HasChar = True

                    Case 48 To 57   'Numbers
                        HasNum = True

                    Case 58 To 64       'Characters
                        HasChar = True

                    Case 65 To 90   'Capital letters
                        HasCaps = True

                    Case 91 To 96       'Characters
                        HasChar = True

                    Case 97 To 122  'Lower case letters
                        HasLower = True

                    Case 123 To 127       'Characters
                        HasChar = True

                End Select
            Next x
            chk = False
        End If


        If Not chk Then
            If Not HasNum Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")

            ElseIf Not HasCaps Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf Not HasLower Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf Not HasChar Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf TextBoxR.Text = a And TextBoxN.Text = TextBoxC.Text Then


                con.Open()
                cmd1.Connection = con
                cmd1.CommandText = "UPDATE Login SET upassAS=('" + TextBoxN.Text + "')"
                cmd1.ExecuteNonQuery()
                con.Close()
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
                Me.Close()
                Login.Show()
            End If
        End If
    End Sub

    Private Sub ICR_Click(sender As Object, e As EventArgs) Handles ICR.Click
        IOR.BringToFront()
        TextBoxR.PasswordChar = "*"
    End Sub

    Private Sub IOR_Click(sender As Object, e As EventArgs) Handles IOR.Click
        ICR.BringToFront()
        TextBoxR.PasswordChar = ""
    End Sub

    Private Sub IOP_Click(sender As Object, e As EventArgs) Handles IOP.Click
        ICP.BringToFront()
        TextBoxN.PasswordChar = ""
    End Sub

    Private Sub ICP_Click(sender As Object, e As EventArgs) Handles ICP.Click
        IOP.BringToFront()
        TextBoxN.PasswordChar = "*"
    End Sub

    Private Sub IOCP_Click(sender As Object, e As EventArgs) Handles IOCP.Click
        ICCP.BringToFront()
        TextBoxC.PasswordChar = ""
    End Sub

    Private Sub ICCP_Click(sender As Object, e As EventArgs) Handles ICCP.Click
        IOCP.BringToFront()
        TextBoxC.PasswordChar = "*"
    End Sub

    Private Sub Form3_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub backbtn_MouseEnter(sender As Object, e As EventArgs) Handles backbtn.MouseEnter
        backbtn.BackColor = Color.Cyan
    End Sub

    Private Sub backbtn_MouseLeave(sender As Object, e As EventArgs) Handles backbtn.MouseLeave
        backbtn.BackColor = Color.Transparent
    End Sub
End Class