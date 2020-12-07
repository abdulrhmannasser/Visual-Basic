Imports System.Data.OleDb

Public Class admin_trinee

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Public cid = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql = "insert into trainers(trainer_name,[username],[password]) values('" & TextBox3.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')"
        Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cid <> -1 Then

            Dim sql = "update trainers set trainer_name='" & TextBox3.Text & "',[password]='" & TextBox1.Text & "',[username]='" & TextBox2.Text & "' where trainer_id=" & cid
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
                cmd.ExecuteNonQuery()
                gridrefresh()

        Else
            MessageBox.Show("لم يتم اختيار عميله")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cid <> -1 Then
            Dim sql = "delete from  trainers  where trainer_id=" & cid
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()
        Else
            MessageBox.Show("لم يتم اختيار عميله")
        End If

    End Sub
    Private Sub gridrefresh()
        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT trainers.trainer_id as [رقم المدربه], trainers.trainer_name as [اسم المدربه], trainers.username as [اسم المستخدم], trainers.password as [كلمه السر]FROM trainers", Form1.cnn)
        dad.Fill(dtb)
        DataGridView1.DataSource = dtb
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < DataGridView1.Rows.Count - 1 Then
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value



            cid = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
End Class
