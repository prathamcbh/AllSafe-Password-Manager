Imports System.Data
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlck.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        NewPass.Show()
        Me.Close()
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles BtnUpd.MouseEnter
        BtnUpd.BackColor = Color.Cyan
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles BtnUpd.MouseLeave
        BtnUpd.BackColor = Color.Transparent

    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select lsite from Main", con)
            Dim ds As New DataSet
            da.Fill(ds, "1")


            For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
            Next

        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        Finally
            con.Close()
        End Try



        TextBoxlink.Text = ""
        TextBoxpass.Text = ""
        TextBoxsite.Text = ""
        TextBoxuname.Text = ""
        ComboBox1.Text = "Select an Item"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim a As String
        a = ComboBox1.Text
        Dim ans As Integer
        If TextBoxsite.Text = "" Then
            MsgBox("Select an password to be deleted.", MsgBoxStyle.Exclamation, "Invalid item")
        Else

            ans = MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Delete the entry?")
            If ans = vbYes Then
                con.Open()
                Dim cmd3 As New SqlCommand
                cmd3.Connection = con
                cmd3.CommandText = "insert into Bin(rname,rsite,rpass,rurl) values('" + TextBoxuname.Text + "','" + TextBoxsite.Text + "','" + TextBoxpass.Text + "','" + TextBoxlink.Text + "')"
                cmd3.ExecuteNonQuery()
                con.Close()

                TextBoxuname.Clear()
                TextBoxpass.Clear()
                TextBoxlink.Clear()
                TextBoxsite.Clear()
                ComboBox1.Text = ""

                con.Open()
                Dim cmd4 As New SqlCommand
                cmd4.Connection = con
                cmd4.CommandText = "Delete from main where ('" + a + "')=lsite "
                cmd4.ExecuteNonQuery()
                con.Close()
                MsgBox("Items moved to bin successfully!", MsgBoxStyle.Information, "Deleted!")



            End If
            ComboBox1.Items.Clear()
            Try
                con.Open()
                Dim da As New SqlDataAdapter("select lsite from Main", con)
                Dim ds As New DataSet
                da.Fill(ds, "1")


                For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                    Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
                Next

            Catch ex As Exception
                MsgBox("Error : " + ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub binbtn_Click(sender As Object, e As EventArgs) Handles binbtn.Click
        Bin.Show()
        Me.Close()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        Dim a As String
        Dim b As String
        Dim c As String
        Dim current As String = ComboBox1.Text


        If ComboBox1.Text = "" Then
            MsgBox("Select an item to be overwritten", MsgBoxStyle.Critical, "Select password")
        ElseIf TextBoxuname.Text.Trim = "" Then
            MsgBox("Username cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Re-enter Username")
        ElseIf TextBoxpass.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Re-enter Password")
        ElseIf TextBoxlink.Text.Trim = "" Then
            MsgBox("Link cannot have just spaces. Please re-insert the Link!", MsgBoxStyle.Critical, "Re-enter Link")
        ElseIf TextBoxlink.Text.Contains(" ") Then
            MsgBox("Link cannot have spaces. Please Re-insert correct Link", MsgBoxStyle.Information, "Check Website link")
        Else
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Select lname, lpass, lurl from Main where lsite=('" + ComboBox1.Text + "')"
            cmd.CommandType = CommandType.Text
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            sdr.Read()
            a = sdr("lname").ToString()
            b = sdr("lpass").ToString()
            c = sdr("lurl").ToString()
            con.Close()


            Dim ans1 As Integer
            ans1 = MsgBox("Are you sure you want to Overwrite?", vbOKCancel, "Overwrite the entry?")

            If ans1 = vbOK And (a <> TextBoxuname.Text Or b <> TextBoxpass.Text Or c <> TextBoxlink.Text) Then

                con.Open()

                Dim cmd2 As New SqlCommand
                cmd2.Connection = con
                cmd2.CommandText = "UPDATE main SET lname=('" + TextBoxuname.Text + "'),lpass=('" + TextBoxpass.Text + "'),lurl=('" + TextBoxlink.Text + "') where lsite=('" + ComboBox1.Text + "')"
                cmd2.ExecuteNonQuery()
                MsgBox("Items saved successfully!", MsgBoxStyle.Information, "Saved!")
                con.Close()

                TextBoxuname.Clear()
                TextBoxpass.Clear()
                TextBoxlink.Clear()
                TextBoxsite.Clear()
                ComboBox1.Text = ""

                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select lsite from Main", con)
                    Dim ds As New DataSet
                    da.Fill(ds, "1")


                    For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                        Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
                    Next

                Catch ex As Exception
                    MsgBox("Error : " + ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Cannot overwrite the same details. Please change the values.", MsgBoxStyle.Information, "Change the details to overwrite")
            End If
            ComboBox1.Text = current
        End If



    End Sub







    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles IO.Click
        IC.BringToFront()
        TextBoxpass.PasswordChar = ControlChars.NullChar
    End Sub

    Private Sub IC_Click(sender As Object, e As EventArgs) Handles IC.Click
        IO.BringToFront()
        TextBoxpass.PasswordChar = "*"
    End Sub

    Private Sub Cpypw_Click(sender As Object, e As EventArgs) Handles Cpypw.Click
        If TextBoxpass.Text = "" Then
            MsgBox("Cannot copy blank field! Select an item to copy.", MsgBoxStyle.Information, "Blank field cannot be copied")
        Else
            My.Computer.Clipboard.SetText(TextBoxpass.Text)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles cpyu.Click
        If TextBoxuname.Text = "" Then
            MsgBox("Cannot copy blank field! Select an item to copy.", MsgBoxStyle.Information, "Blank field cannot be copied")
        Else
            My.Computer.Clipboard.SetText(TextBoxuname.Text)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles oplnk.LinkClicked
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to open Link.", MsgBoxStyle.Information, "Select an entry!")
        Else
            System.Diagnostics.Process.Start("http://" + TextBoxlink.Text)
        End If

    End Sub

    Private Sub btnkey_Click(sender As Object, e As EventArgs) Handles btnset.Click
        Settings.Show()
        Me.Close()
    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkgen.LinkClicked
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to generate password.", MsgBoxStyle.Information, "Select an entry!")
        Else
            TextBoxpass.Text = RandomString(8, 25)
        End If

    End Sub





    Private Sub btndel_MouseEnter(sender As Object, e As EventArgs) Handles btndel.MouseEnter
        btndel.BackColor = Color.Cyan
    End Sub

    Private Sub btndel_MouseLeave(sender As Object, e As EventArgs) Handles btndel.MouseLeave
        btndel.BackColor = Color.Transparent
    End Sub

    Private Sub addbtn_MouseEnter(sender As Object, e As EventArgs) Handles addbtn.MouseEnter
        addbtn.BackColor = Color.Cyan
    End Sub

    Private Sub addbtn_MouseLeave(sender As Object, e As EventArgs) Handles addbtn.MouseLeave
        addbtn.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnlck.MouseEnter
        btnlck.BackColor = Color.Cyan
    End Sub

    Private Sub btnlck_MouseLeave(sender As Object, e As EventArgs) Handles btnlck.MouseLeave
        btnlck.BackColor = Color.Transparent
    End Sub

    Private Sub binbtn_MouseEnter(sender As Object, e As EventArgs) Handles binbtn.MouseEnter
        binbtn.BackColor = Color.Cyan
    End Sub

    Private Sub binbtn_MouseLeave(sender As Object, e As EventArgs) Handles binbtn.MouseLeave
        binbtn.BackColor = Color.Transparent
    End Sub

    Private Sub btnset_MouseEnter(sender As Object, e As EventArgs) Handles btnset.MouseEnter
        btnset.BackColor = Color.Cyan
    End Sub

    Private Sub btnset_MouseLeave(sender As Object, e As EventArgs) Handles btnset.MouseLeave
        btnset.BackColor = Color.Transparent
    End Sub

    Private Sub cpyu_MouseEnter(sender As Object, e As EventArgs) Handles cpyu.MouseEnter
        cpyu.BackColor = Color.Cyan
    End Sub

    Private Sub cpyu_MouseLeave(sender As Object, e As EventArgs) Handles cpyu.MouseLeave
        cpyu.BackColor = Color.Transparent
    End Sub

    Private Sub Cpypw_MouseEnter(sender As Object, e As EventArgs) Handles Cpypw.MouseEnter
        Cpypw.BackColor = Color.Cyan
    End Sub

    Private Sub Cpypw_MouseLeave(sender As Object, e As EventArgs) Handles Cpypw.MouseLeave
        Cpypw.BackColor = Color.Transparent
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim st As String = ComboBox1.Text

        con.Open()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "Select lsite,lurl,lpass,lname from Main where ('" + st + "')=lsite"
        cmd4.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd4.ExecuteReader()
        sdr.Read()
        If st = sdr("lsite").ToString() Then
            TextBoxuname.Text = sdr("lname").ToString()
            TextBoxpass.Text = sdr("lpass").ToString()
            TextBoxlink.Text = sdr("lurl").ToString()
            TextBoxsite.Text = sdr("lsite").ToString()
        End If
        con.Close()

    End Sub

    Private Sub TextBoxpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpass.KeyPress
        If ComboBox1.Text = "" Then
            If e.KeyChar <> ChrW(Keys.Back) Then

                e.Handled = True
            End If
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

    Private Sub TextBoxlink_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxlink.KeyPress
        If ComboBox1.Text = "" Then
            If e.KeyChar <> ChrW(Keys.Back) Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxuname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxuname.KeyPress
        If ComboBox1.Text = "" Then
            If e.KeyChar <> ChrW(Keys.Back) Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnlck_MouseHover(sender As Object, e As EventArgs) Handles btnlck.MouseHover

    End Sub
End Class