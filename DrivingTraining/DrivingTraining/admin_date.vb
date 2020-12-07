Imports System.Data.OleDb

Public Class admin_date

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public cid = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.opencon()
        Dim sql1 = "select group_id from groups where group_time='" & ComboBox2.SelectedItem & "' and trainer_id=" & ComboBox1.SelectedValue & ""
        Dim cmd1 = New OleDbCommand(sql1, Form1.cnn)
        Dim id = cmd1.ExecuteScalar()
        If id = Nothing Then



            Dim sql = "insert into groups(group_time,trainer_id) values('" & ComboBox2.SelectedItem & "','" & ComboBox1.SelectedValue & "')"
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()
        Else
            MessageBox.Show("المدربه لديها مجموعه في نفس الوقت")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.opencon()
        If cid <> -1 Then
            Dim sql1 = "select group_id from groups where group_time='" & ComboBox2.SelectedItem & "' and trainer_id=" & ComboBox1.SelectedValue & ""
            Dim cmd1 = New OleDbCommand(sql1, Form1.cnn)
            Dim id = cmd1.ExecuteScalar()
            If id = Nothing Then
                Dim sql = "update groups set group_time='" & ComboBox2.SelectedItem & "',trainer_id='" & ComboBox1.SelectedValue & "' where group_id=" & cid
                Dim cmd = New OleDbCommand(sql, Form1.cnn)
                cmd.ExecuteNonQuery()
                gridrefresh()
            Else
                MessageBox.Show("المدربه لديها مجموعه في نفس الوقت")
            End If
        Else
            MessageBox.Show("لم يتم اختيار عميله")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cid <> -1 Then
            Dim sql = "delete from  groups  where group_id=" & cid
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            gridrefresh()
        Else
            MessageBox.Show("لم يتم اختيار عميله")
        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

    End Sub
    Private Sub gridrefresh()
        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT groups.group_id as [رقم المجموعه], groups.group_time as [معاد المجموعه], trainers.trainer_name as [اسم المدربه] FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad.Fill(dtb)
        DataGridView1.DataSource = dtb
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < DataGridView1.Rows.Count - 1 Then
            ComboBox2.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(1).Value

            ComboBox1.SelectedIndex = ComboBox1.Items.IndexOf(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
            ComboBox2.SelectedValue = DataGridView1.Rows(e.RowIndex).Cells(2).Value

            cid = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
End Class
