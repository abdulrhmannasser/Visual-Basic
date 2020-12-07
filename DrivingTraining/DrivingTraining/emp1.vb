Imports System.Data.OleDb

Public Class emp1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Regist1.Visible = True
        Trainers1.Visible = False
        Tarainer_date1.Visible = False
        Bills1.Visible = False



    End Sub
    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Regist1.Visible = False
        Trainers1.Visible = False
        Tarainer_date1.Visible = True
        Bills1.Visible = False

    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Regist1.Visible = False
        Trainers1.Visible = True
        Tarainer_date1.Visible = False
        Bills1.Visible = False

    End Sub
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Regist1.Visible = False
        Trainers1.Visible = False
        Tarainer_date1.Visible = False
        Bills1.Visible = True

    End Sub
    Private Sub Regist1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        Me.Close()

    End Sub

    Private Sub emp1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Regist1.Visible = True


        Form1.opencon()



        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        Dim dtb6 As New DataTable
        Dim dad6 As OleDbDataAdapter
        Dim dtb1 As New DataTable
        Dim dad1 As OleDbDataAdapter

        Dim dtb3 As New DataTable
        Dim dad3 As OleDbDataAdapter
        Dim dtb4 As New DataTable
        Dim dad4 As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT groups.group_id as [رقم المجموعه], groups.group_time as [معاد المجموعه], trainers.trainer_name as [اسم المدربه] FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad.Fill(dtb)
        Tarainer_date1.DataGridView1.DataSource = dtb
        Tarainer_date1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        dad1 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad1.Fill(dtb1)
        Trainers1.DataGridView1.DataSource = dtb1
        Trainers1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        dad3 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID where trainees.fees=500;", Form1.cnn)
        dad3.Fill(dtb3)
        Bills1.DataGridView1.DataSource = dtb3
        Bills1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        dad4 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID where trainees.fees<>500;", Form1.cnn)
        dad4.Fill(dtb4)
        Bills1.DataGridView2.DataSource = dtb4
        Bills1.DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "سدد"
        btn.Text = "سدد"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True
        Bills1.DataGridView2.Columns.Insert(8, btn)

        dad6 = New OleDbDataAdapter("SELECT groups.group_id, 'المدربه '+[trainer_name]+' '+[group_time] AS disp FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID;", Form1.cnn)
        dad6.Fill(dtb6)
        Regist1.ComboBox3.DataSource = dtb6
        Regist1.ComboBox3.DisplayMember = "disp"
        Regist1.ComboBox3.ValueMember = "group_id"






    End Sub
End Class