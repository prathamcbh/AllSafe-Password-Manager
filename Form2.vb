Imports System.Data.SqlClient
Imports System.Text

Public Class Form2
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelRec.Hide()
        backupkeyR.Hide()
        IOR.Hide()
        ICR.Hide()
        IOP.BringToFront()
        IOCP.BringToFront()


        TextBoxUname.Select()

    End Sub


    Function RandomString(minCharacters As Integer, maxCharacters As Integer)

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub crtbtn_Click(sender As Object, e As EventArgs) Handles crtbtn.Click

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into Login(unameAS,upassAS,bkpstr) values('" + TextBoxUname.Text + "','" + TextPass.Text + "','" + backupkeyR.Text + "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Account successfully created", MsgBoxStyle.Information, "Success!")
        Login.Visible = True
        Me.Close()
        MsgBox("To change and reset Recovery key and Master Password, use settings from Dashboard!", MsgBoxStyle.Information, "Tip")
    End Sub


    Private Sub Buttonconfirm_Click(sender As Object, e As EventArgs) Handles Buttonconfirm.Click
        Dim CurChar As String
        Dim HasNum As Boolean = False
        Dim HasCaps As Boolean = False
        Dim HasLower As Boolean = False
        Dim HasChar As Boolean = False
        Dim x As Long
        Dim MinLength As Integer = 8
        Dim PW As String = TextPass.Text
        Dim chk As Boolean = False
        Dim chk2 As Boolean = False



        If TextBoxUname.Text = "" Or TextPass.Text = "" Or TextCPass.Text = "" Then
            MsgBox("Username and Password cannot be left blank", MsgBoxStyle.Exclamation, "Enter Credentials")
            chk = True
            chk2 = True
        ElseIf TextBoxUname.Text.Trim = "" Then
            MsgBox("Username cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Check the Fields")
            chk = True
            chk2 = True
        ElseIf TextPass.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
            chk = True
            chk2 = True
        ElseIf TextPass.Text <> TextCPass.Text Then
            MsgBox("Those passwords didn't match. Please try again!", MsgBoxStyle.Information, "Check the passwords")
            chk = True
            chk2 = True

        ElseIf Len(PW) < MinLength Then
            MsgBox("Password should be atleast 8 charcters", MsgBoxStyle.Exclamation, "Warning!")
            chk = True
            chk2 = True
        Else
            If Not chk Then

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
        End If


        If Not chk And HasCaps = True And HasChar = True And HasNum = True And HasLower = True Then
            backupkeyR.Text = RandomString(10, 10)
            MsgBox("Note the Recovery Key somewhere safe. If you forgot password, use Recovery key to reset it!", MsgBoxStyle.Information, "Notice")
            LabelRec.Show()
            backupkeyR.Show()
            IOR.Show()
            ICR.Show()
            IOR.BringToFront()
            crtbtn.BringToFront()
        ElseIf Not chk2 Then
            MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol CHAR", MsgBoxStyle.Information, "Enter a strong password")
        End If
    End Sub

    Private Sub Buttonconfirm_MouseEnter(sender As Object, e As EventArgs) Handles Buttonconfirm.MouseEnter
        Buttonconfirm.BackColor = Color.Cyan
    End Sub

    Private Sub Buttonconfirm_MouseLeave(sender As Object, e As EventArgs) Handles Buttonconfirm.MouseLeave
        Buttonconfirm.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles IOP.Click
        ICP.BringToFront()
        TextPass.PasswordChar = ""
        TextPass.Select()
    End Sub

    Private Sub TextPass_TextChanged(sender As Object, e As EventArgs) Handles TextPass.TextChanged

    End Sub

    Private Sub IC_Click(sender As Object, e As EventArgs) Handles ICP.Click
        IOP.BringToFront()
        TextPass.PasswordChar = "*"
        TextPass.Select()
    End Sub

    Private Sub ICCP_Click(sender As Object, e As EventArgs) Handles ICCP.Click
        IOCP.BringToFront()
        TextCPass.PasswordChar = "*"
        TextCPass.Select()
    End Sub

    Private Sub IOCP_Click(sender As Object, e As EventArgs) Handles IOCP.Click
        ICCP.BringToFront()
        TextCPass.PasswordChar = ""
        TextCPass.Select()
    End Sub

    Private Sub IOR_Click(sender As Object, e As EventArgs) Handles IOR.Click
        ICR.BringToFront()
        backupkeyR.PasswordChar = ""
        backupkeyR.Select()
    End Sub

    Private Sub ICR_Click(sender As Object, e As EventArgs) Handles ICR.Click
        IOR.BringToFront()
        backupkeyR.PasswordChar = "*"
        backupkeyR.Select()
    End Sub

    Private Sub crtbtn_MouseEnter(sender As Object, e As EventArgs) Handles crtbtn.MouseEnter
        crtbtn.BackColor = Color.Cyan
    End Sub

    Private Sub crtbtn_MouseLeave(sender As Object, e As EventArgs) Handles crtbtn.MouseLeave
        crtbtn.BackColor = Color.Transparent
    End Sub
End Class