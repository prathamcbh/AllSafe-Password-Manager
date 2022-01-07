Imports System.Data.SqlClient
Public Class Splash
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive New\OneDrive - T. John Group of Institutions\Projects\Password manager\VB Files\Password Manager 1.1\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim count As Integer = -1

    'Git Try
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = 80 Then
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Count([unameAS]) FROM [Login]"
            cmd.ExecuteNonQuery()
            count = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            If count = 0 Then
                Form2.Show()
            Else
                Login.Show()
            End If
            Me.Hide()

        End If


    End Sub


End Class

