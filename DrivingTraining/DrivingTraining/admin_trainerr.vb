Imports System.Data.OleDb

Public Class admin_trainerr
    Public cid = -1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cid <> -1 Then

            Dim sql = "update trainees set trainee_name='" & TextBox1.Text & "',nationalid='" & TextBox2.Text & "',mobile='" & TextBox3.Text & "',address='" & TextBox5.Text & "',group_id='" & ComboBox3.SelectedValue & "' where trainee_id=" & cid
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()
        Else

            MessageBox.Show("لم يتم اختيار عميله")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cid <> -1 Then
            Dim sql = "delete from  trainees  where trainee_id=" & cid
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()
        Else
            MessageBox.Show("لم يتم اختيار عميله")
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < DataGridView1.Rows.Count - 1 Then
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value


            ComboBox3.SelectedIndex = ComboBox3.Items.IndexOf(DataGridView1.Rows(e.RowIndex).Cells(5).Value)

            cid = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
    Private Sub gridrefresh()
        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad.Fill(dtb)
        DataGridView1.DataSource = dtb
    End Sub
End Class
