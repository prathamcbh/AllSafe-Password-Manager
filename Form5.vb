Imports System.Data.SqlClient
Public Class Bin
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select rsite from bin", con)
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
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim st As String = ComboBox1.Text

        con.Open()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "Select rsite,rurl,rpass,rname from Bin where ('" + st + "')=rsite"
        cmd4.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd4.ExecuteReader()
        sdr.Read()
        If st = sdr("rsite").ToString() Then
            TextBoxName.Text = sdr("rname").ToString()
            TextBoxpass.Text = sdr("rpass").ToString()
            TextBoxLink.Text = sdr("rurl").ToString()
            TextBoxSite.Text = sdr("rsite").ToString()
        End If
        con.Close()

    End Sub

    Private Sub binbtn_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim ans
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to be Deleted!", MsgBoxStyle.Critical, "Select an item")
        Else
            ans = MsgBox("Are you sure you want to delete " + TextBoxSite.Text + "?", MsgBoxStyle.YesNo, "Delete " + TextBoxSite.Text + "?")
            If ans = vbYes Then
                Dim str As String = ComboBox1.Text
                con.Open()
                Dim cmd2 As New SqlCommand
                cmd2.Connection = con
                cmd2.CommandText = "Delete from bin where ('" + str + "')=rsite "

                cmd2.ExecuteNonQuery()

                MsgBox("Deleted Successfully", MsgBoxStyle.Information, "Notice")
                TextBoxName.Text = ""
                TextBoxpass.Text = ""
                TextBoxLink.Text = ""
                TextBoxSite.Text = ""
                con.Close()
                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from bin", con)
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

        End If

    End Sub

    Private Sub BtnDelA_Click(sender As Object, e As EventArgs) Handles BtnDelA.Click
        Dim ans As Integer
        Dim cmd As New SqlCommand
        Dim count As Integer = -1
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select count(rsite) from bin"
        cmd.ExecuteNonQuery()
        count = Convert.ToInt32(cmd.ExecuteScalar)
        con.Close()

        If count < 1 Then
            MsgBox("Bin is already empty.", MsgBoxStyle.Information, "Bin is empty")
        Else
            ans = MsgBox("Are you sure you want to delete all passwords?", MsgBoxStyle.YesNo, "Delete all?")
            If ans = vbYes Then


                con.Open()
                Dim cmd2 As New SqlCommand
                cmd2.Connection = con
                cmd2.CommandText = "Delete from bin "

                cmd2.ExecuteNonQuery()

                MsgBox("Deleted Successfully!", MsgBoxStyle.Information, "Successfully Deleted!")
                con.Close()
                TextBoxName.Text = ""
                TextBoxpass.Text = ""
                TextBoxLink.Text = ""
                TextBoxSite.Text = ""
                ComboBox1.Items.Clear()

                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from bin", con)
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
        End If



    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        Dim a As String
        a = ComboBox1.Text
        Dim ans As Integer
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to be Restored!", MsgBoxStyle.Critical, "Select an item")

        Else
            ans = MsgBox("Are you sure you want to Restore " + TextBoxSite.Text + "?", MsgBoxStyle.YesNo, "Restore " + TextBoxSite.Text + "?")
            If ans = vbYes Then
                con.Open()
                Dim cmd4 As New SqlCommand
                Dim cmd2 As New SqlCommand, cmd3 As New SqlCommand
                Dim n As Integer = -1



                cmd3.Connection = con
                cmd3.CommandText = "Select count ([lsite]) from [Main] where lsite like ('%" + TextBoxSite.Text + "%')"
                n = Convert.ToInt32(cmd3.ExecuteScalar())
                con.Close()

                If n > 0 Then
                    n += 1
                    Dim x As String = TextBoxSite.Text + " (" + n.ToString + ")"

                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxLink.Text + "','" + TextBoxpass.Text + "','" + TextBoxName.Text + "','" + x + "' )"

                    cmd2.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    cmd4.Connection = con
                    cmd4.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxLink.Text + "','" + TextBoxpass.Text + "','" + TextBoxName.Text + "','" + TextBoxSite.Text + "' )"
                    cmd4.ExecuteNonQuery()
                    con.Close()
                End If





                MsgBox("Restored Successfully!", MsgBoxStyle.Information, "Restore")
                TextBoxName.Text = ""
                TextBoxpass.Text = ""
                TextBoxLink.Text = ""
                TextBoxSite.Text = ""
                ComboBox1.Items.Clear()
                con.Close()


                Dim cmd5 As New SqlCommand
                cmd5.Connection = con
                con.Open()
                cmd5.CommandText = "Delete from Bin where ('" + a + "')=rsite "
                cmd5.ExecuteNonQuery()
                con.Close()
                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from bin", con)
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

        End If


    End Sub





    Private Sub BtnRestore_MouseEnter(sender As Object, e As EventArgs) Handles BtnRestore.MouseEnter
        BtnRestore.BackColor = Color.Cyan
    End Sub

    Private Sub BtnRestore_MouseLeave(sender As Object, e As EventArgs) Handles BtnRestore.MouseLeave
        BtnRestore.BackColor = Color.Transparent
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub IC_Click(sender As Object, e As EventArgs) Handles IC.Click
        TextBoxpass.PasswordChar = "*"
        IO.BringToFront()
    End Sub

    Private Sub IO_Click(sender As Object, e As EventArgs) Handles IO.Click
        TextBoxpass.PasswordChar = ""
        IC.BringToFront()
    End Sub
End Class