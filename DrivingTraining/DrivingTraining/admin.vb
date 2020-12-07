Imports System.Data.OleDb

Public Class admin
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Admin_date1.Visible = True
        Admin_trainerr1.Visible = False
        Admin_trinee1.Visible = False
        Bills1.Visible = False

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Admin_date1.Visible = False
        Admin_trainerr1.Visible = True
        Admin_trinee1.Visible = False
        Bills1.Visible = False

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Admin_date1.Visible = False
        Admin_trainerr1.Visible = False
        Admin_trinee1.Visible = True
        Bills1.Visible = False

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Admin_date1.Visible = False
        Admin_trainerr1.Visible = False
        Admin_trinee1.Visible = False
        Bills1.Visible = True

    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        Me.Close()

    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.opencon()

        'SELECT groups.group_id, groups.group_time, trainers.trainer_name FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID;
        Dim dtb As New DataTable
        Dim dad As OleDbDataAdapter
        Dim dtb1 As New DataTable
        Dim dad1 As OleDbDataAdapter
        Dim dtb2 As New DataTable
        Dim dad2 As OleDbDataAdapter
        Dim dtb3 As New DataTable
        Dim dad3 As OleDbDataAdapter
        Dim dtb4 As New DataTable
        Dim dad4 As OleDbDataAdapter
        Dim dtb5 As New DataTable
        Dim dad5 As OleDbDataAdapter
        Dim dtb6 As New DataTable
        Dim dad6 As OleDbDataAdapter
        dad = New OleDbDataAdapter("SELECT groups.group_id as [رقم المجموعه], groups.group_time as [معاد المجموعه], trainers.trainer_name as [اسم المدربه] FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad.Fill(dtb)
        Admin_date1.DataGridView1.DataSource = dtb
        Admin_date1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        dad1 = New OleDbDataAdapter("SELECT trainees.trainee_id as [رقم المتدربه], trainees.trainee_name as [اسم المتدربه], trainees.NationalID as [الرقم القومي], trainees.Mobile as [الجوال], trainees.Address as [العنوان], trainees.fees as [المبلغ المدفوع] , trainers.trainer_name as [اسم المدربه], groups.group_time as [وقت المجموعه] FROM trainers INNER JOIN (groups INNER JOIN trainees ON groups.group_id = trainees.Group_ID) ON trainers.trainer_id = groups.Trainer_ID", Form1.cnn)
        dad1.Fill(dtb1)
        Admin_trainerr1.DataGridView1.DataSource = dtb1
        Admin_trainerr1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        dad2 = New OleDbDataAdapter("SELECT trainers.trainer_id as [رقم المدربه], trainers.trainer_name as [اسم المدربه], trainers.username as [اسم المستخدم], trainers.password as [كلمه السر]FROM trainers;", Form1.cnn)
        dad2.Fill(dtb2)
        Admin_trinee1.DataGridView1.DataSource = dtb2
        Admin_trinee1.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

        dad5 = New OleDbDataAdapter("select * from trainers", Form1.cnn)
        dad5.Fill(dtb5)
        Admin_date1.ComboBox1.DataSource = dtb5
        Admin_date1.ComboBox1.DisplayMember = "trainer_name"
        Admin_date1.ComboBox1.ValueMember = "trainer_id"

        dad6 = New OleDbDataAdapter("SELECT groups.group_id, 'المدربه '+[trainer_name]+' '+[group_time] AS disp FROM trainers INNER JOIN groups ON trainers.trainer_id = groups.Trainer_ID;", Form1.cnn)
        dad6.Fill(dtb6)
        Admin_trainerr1.ComboBox3.DataSource = dtb6
        Admin_trainerr1.ComboBox3.DisplayMember = "disp"
        Admin_trainerr1.ComboBox3.ValueMember = "group_id"

    End Sub
End Class