Imports System.Data.SqlClient
Imports System.Text
Public Class Settings
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs)
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to Regenerate the Recovery Key", MsgBoxStyle.YesNo, "Regenerate Key?")
        If ans = vbYes Then
            Textboxbkpstr.ReadOnly = False
            BtnSavebkpstr.BringToFront()
        End If


    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT [bkpstr] FROM [Login]"
        cmd.ExecuteNonQuery()
        Dim bkpstr As String = Convert.ToString(cmd.ExecuteScalar())
        Textboxbkpstr.Text = bkpstr
        Textboxbkpstr.ReadOnly = True
        PanelBkpstr.BringToFront()
        con.Close()
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles btnpass.Click
        PanelPass.BringToFront()
    End Sub

    Private Sub Btnbkpstr_Click(sender As Object, e As EventArgs) Handles Btnbkpstr.Click
        PanelBkpstr.BringToFront()
    End Sub

    Private Sub BtnChgbkpstr_Click(sender As Object, e As EventArgs) Handles BtnChgbkpstr.Click
        Textboxbkpstr.Text = RandomString(10, 10)
    End Sub

    Private Sub BtnSavebkpstr_Click(sender As Object, e As EventArgs) Handles BtnSavebkpstr.Click

        Dim ans1 As Integer = MsgBox("Are you sure you want to Overwrite?", vbOKCancel, "Overwrite the entry?")
        If ans1 = vbOK Then
            con.Open()

            Dim cmd4 As New SqlCommand
            cmd4.Connection = con
            cmd4.CommandText = "UPDATE Login SET bkpstr=('" + Textboxbkpstr.Text + "')"
            cmd4.ExecuteNonQuery()
            MsgBox("Items saved successfully!", MsgBoxStyle.Information, "Saved!")
            con.Close()
        End If

    End Sub



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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim cmd As New SqlCommand

        Dim CurChar As String
        Dim HasNum As Boolean
        Dim HasCaps As Boolean
        Dim HasLower As Boolean
        Dim HasChar As Boolean
        Dim x As Long
        Dim MinLength As Integer = 8
        Dim PW As String = TextBoxCP.Text
        Dim chk As Boolean

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select upassAS from login"
        cmd.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        sdr.Read()
        Dim a As String = sdr("upassAS").ToString()
        con.Close()

        If TextBoxCurrentPass.Text = "" Or TextBoxCP.Text = "" Or TextBoxNP.Text = "" Then
            MsgBox("Fill in all the fields.!", MsgBoxStyle.Exclamation, "Enter all fields")
            chk = True
        ElseIf a <> TextBoxCurrentPass.Text Then
            MsgBox("Current password did not match. Please enter current password!", MsgBoxStyle.Exclamation, "Check current password")
            chk = True
        ElseIf a = TextBoxCP.Text Then
            MsgBox("New password cannot be same as current password. Please change the password and try again.", MsgBoxStyle.Information, "Enter a new password")
            chk = True
        ElseIf Len(PW) < MinLength Then
            MsgBox("Password should be atleast 8 charcters", MsgBoxStyle.Exclamation, "Warning!")
            chk = True
        ElseIf TextBoxNP.Text <> TextBoxCP.Text Then
            MsgBox("Those passwords did not match. Please try again!", MsgBoxStyle.Critical, "Password didn't match")
            chk = True

        ElseIf TextBoxCp.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
            chk = True

        Else
            For x = 1 To Len(PW)
                CurChar = Mid(PW, x, 1)
                Select Case Asc(CurChar)
                    Case 48 To 57   'Numbers
                        HasNum = True
                    Case 65 To 90   'Capital letters
                        HasCaps = True
                    Case 97 To 122  'Lower case letters
                        HasLower = True
                    Case Else       'Characters
                        HasChar = True
                        Exit For
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
            ElseIf TextBoxCurrentPass.Text = a And TextBoxCP.Text = TextBoxNP.Text Then

                Dim cmd1 As New SqlCommand

                con.Open()
                cmd1.Connection = con
                cmd1.CommandText = "UPDATE Login SET upassAS=('" + TextBoxNP.Text + "') "
                cmd1.ExecuteNonQuery()
                con.Close()
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
                TextBoxNP.Text = ""
                TextBoxCP.Text = ""
                TextBoxCurrentPass.Text = ""
            End If
        End If
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub IOB_Click(sender As Object, e As EventArgs) Handles IOB.Click
        ICB.BringToFront()
        Textboxbkpstr.PasswordChar = ""
    End Sub

    Private Sub ICB_Click(sender As Object, e As EventArgs) Handles ICB.Click
        IOB.BringToFront()
        Textboxbkpstr.PasswordChar = "*"
    End Sub

    Private Sub IOCr_Click(sender As Object, e As EventArgs) Handles IOCr.Click
        ICCr.BringToFront()
        TextBoxCurrentPass.PasswordChar = ""
    End Sub

    Private Sub IOCP_Click(sender As Object, e As EventArgs) Handles IOCP.Click
        ICCP.BringToFront()
        TextBoxCP.PasswordChar = ""
    End Sub

    Private Sub ICCr_Click(sender As Object, e As EventArgs) Handles ICCr.Click
        IOCr.BringToFront()
        TextBoxCurrentPass.PasswordChar = "*"
    End Sub

    Private Sub IOnp_Click(sender As Object, e As EventArgs) Handles IOnp.Click
        ICnp.BringToFront()
        TextBoxNP.PasswordChar = ""
    End Sub

    Private Sub ICnp_Click(sender As Object, e As EventArgs) Handles ICnp.Click
        IOnp.BringToFront()
        TextBoxNP.PasswordChar = "*"
    End Sub

    Private Sub ICCP_Click(sender As Object, e As EventArgs) Handles ICCP.Click
        IOCP.BringToFront()
        TextBoxCP.PasswordChar = "*"
    End Sub

    Private Sub btnsave_MouseEnter(sender As Object, e As EventArgs) Handles btnsave.MouseEnter
        btnsave.BackColor = Color.Cyan
    End Sub

    Private Sub btnsave_MouseLeave(sender As Object, e As EventArgs) Handles btnsave.MouseLeave
        btnsave.BackColor = Color.Transparent
    End Sub

    Private Sub Btnbkpstr_MouseEnter(sender As Object, e As EventArgs) Handles Btnbkpstr.MouseEnter
        Btnbkpstr.BackColor = Color.Cyan
    End Sub

    Private Sub Btnbkpstr_MouseLeave(sender As Object, e As EventArgs) Handles Btnbkpstr.MouseLeave
        Btnbkpstr.BackColor = Color.Transparent
    End Sub

    Private Sub btnpass_MouseEnter(sender As Object, e As EventArgs) Handles btnpass.MouseEnter
        btnpass.BackColor = Color.Cyan
    End Sub

    Private Sub btnpass_MouseLeave(sender As Object, e As EventArgs) Handles btnpass.MouseLeave
        btnpass.BackColor = Color.Transparent
    End Sub

    Private Sub BtnChgbkpstr_MouseEnter(sender As Object, e As EventArgs) Handles BtnChgbkpstr.MouseEnter
        BtnChgbkpstr.BackColor = Color.Cyan
    End Sub

    Private Sub BtnChgbkpstr_MouseLeave(sender As Object, e As EventArgs) Handles BtnChgbkpstr.MouseLeave
        BtnChgbkpstr.BackColor = Color.Transparent
    End Sub

    Private Sub BtnSavebkpstr_MouseEnter(sender As Object, e As EventArgs) Handles BtnSavebkpstr.MouseEnter
        BtnSavebkpstr.BackColor = Color.Cyan
    End Sub

    Private Sub BtnSavebkpstr_MouseLeave(sender As Object, e As EventArgs) Handles BtnSavebkpstr.MouseLeave
        BtnSavebkpstr.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Cyan
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub
End Class