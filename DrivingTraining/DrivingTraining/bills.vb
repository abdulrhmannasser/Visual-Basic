Imports System.Data.OleDb

Public Class bills
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            Dim sql = "update trainees set fees=500 where trainee_id=" & DataGridView2.Rows(e.RowIndex).Cells(1).Value
            Dim cmd = New OleDbCommand(sql, Form1.cnn)
            cmd.ExecuteNonQuery()
            Dim dtb3 As New DataTable
            Dim dad3 As OleDbDataAdapter
            Dim dad4 As OleDbDataAdapter
            Dim dtb4 As New DataTable
            dad3 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID where trainees.fees=500;", Form1.cnn)
            dad3.Fill(dtb3)
            DataGridView1.DataSource = dtb3
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            dad4 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID where trainees.fees<>500;", Form1.cnn)
            dad4.Fill(dtb4)
            DataGridView2.DataSource = dtb4
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub
End Class
