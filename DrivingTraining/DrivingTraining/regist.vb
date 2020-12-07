Imports System.Data.OleDb

Public Class regist

    Private Sub regist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mon
        If RadioButton1.Checked Then
            mon = 500
        Else
            mon = TextBox4.Text
        End If
        Form1.opencon()

        Dim sql = "insert into trainees(trainee_name,NationalID,[mobile],[address],group_id,fees) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox3.SelectedValue & "','" & mon & "')"
        Dim cmd = New OleDbCommand(sql, Form1.cnn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("تم التسجيل بنجاح")


    End Sub
End Class
