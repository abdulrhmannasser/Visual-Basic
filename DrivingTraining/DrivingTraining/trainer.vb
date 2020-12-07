Imports System.Data.OleDb

Public Class trainer
    Public tid
    Private Sub trainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.opencon()
        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        Dim dtb1 As New DataTable
        Dim dad1 As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT groups.group_id as [رقم المجموعه], groups.group_time as [معاد المجموعه], trainers.trainer_name as [اسم المدربه] FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID where groups.Trainer_ID=" & tid, Form1.cnn)
        dad.Fill(dtb)
        Tarainer_date1.DataGridView1.DataSource = dtb
        Tarainer_date1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        dad1 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID where trainers.trainer_id =" & tid, Form1.cnn)
        dad1.Fill(dtb1)
        Trainers_for_traine1.DataGridView1.DataSource = dtb1
        Trainers_for_traine1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Trainers_for_traine1.Visible = False
        Tarainer_date1.Visible = True

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Trainers_for_traine1.Visible = True
        Tarainer_date1.Visible = False

    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        Me.Close()

    End Sub
End Class