Imports System.Data.OleDb

Public Class Form1

    Public con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\access\cartraining.mdb"
    Public cnn As New OleDb.OleDbConnection(con)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opencon()

        If RadioButton1.Checked Then
            Try


                Dim us = TextBox1.Text
                Dim pass = TextBox2.Text
                Dim sql1 = "select emp_id from employees where username='" & us & "' and password='" & pass & "'"
                Dim cmd1 = New OleDbCommand(sql1, cnn)
                Dim id = cmd1.ExecuteScalar()
                If id <> Nothing Then
                    Me.Hide()
                    emp1.Show()
                Else
                    MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")

                End If


            Catch ex As Exception
                MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")
            End Try

        ElseIf RadioButton2.Checked Then
            Try



                Dim us = TextBox1.Text
                Dim pass = TextBox2.Text
                Dim sql1 = "select trainer_id from trainers where username='" & us & "' and password='" & pass & "'"
                Dim cmd1 = New OleDbCommand(sql1, cnn)
                Dim id = cmd1.ExecuteScalar()
                If id <> Nothing Then
                    'Form2.empid = id
                    trainer.tid = id
                    Me.Hide()
                    trainer.Show()
                Else
                    MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")

                End If



            Catch ex As Exception
                MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")

            End Try
        ElseIf RadioButton3.Checked Then
            Try



                Dim us = TextBox1.Text
                Dim pass = TextBox2.Text
                Dim sql1 = "select admin_id from admins where username='" & us & "' and password='" & pass & "'"
                Dim cmd1 = New OleDbCommand(sql1, cnn)
                Dim id = cmd1.ExecuteScalar()
                If id <> Nothing Then
                    'Form2.empid = id
                    Me.Hide()
                    admin.Show()
                Else
                    MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")

                End If



            Catch ex As Exception
                MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه")

            End Try

        End If
        cnn.Close()

    End Sub
    Public Sub opencon()
        If (cnn.State = ConnectionState.Closed) Then
            cnn.Open()
        End If

    End Sub

End Class
