<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trainer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trainer))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.Tarainer_date1 = New DrivingTraining.tarainer_date()
        Me.Trainers_for_traine1 = New DrivingTraining.trainers_for_traine()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(221, 694)
        Me.panel1.TabIndex = 10
        '
        'button3
        '
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.Location = New System.Drawing.Point(0, 15)
        Me.button3.Margin = New System.Windows.Forms.Padding(4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(217, 97)
        Me.button3.TabIndex = 1
        Me.button3.Text = "المواعيد"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button3.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(0, 127)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(217, 97)
        Me.button1.TabIndex = 1
        Me.button1.Text = "المتدربات"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button1.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button13.ForeColor = System.Drawing.Color.White
        Me.button13.Image = CType(resources.GetObject("button13.Image"), System.Drawing.Image)
        Me.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.Location = New System.Drawing.Point(1121, 0)
        Me.button13.Margin = New System.Windows.Forms.Padding(4)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(56, 58)
        Me.button13.TabIndex = 9
        Me.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button13.UseVisualStyleBackColor = True
        '
        'Tarainer_date1
        '
        Me.Tarainer_date1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Tarainer_date1.Location = New System.Drawing.Point(221, 44)
        Me.Tarainer_date1.Margin = New System.Windows.Forms.Padding(5)
        Me.Tarainer_date1.Name = "Tarainer_date1"
        Me.Tarainer_date1.Size = New System.Drawing.Size(940, 613)
        Me.Tarainer_date1.TabIndex = 11
        '
        'Trainers_for_traine1
        '
        Me.Trainers_for_traine1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Trainers_for_traine1.Location = New System.Drawing.Point(221, 44)
        Me.Trainers_for_traine1.Margin = New System.Windows.Forms.Padding(5)
        Me.Trainers_for_traine1.Name = "Trainers_for_traine1"
        Me.Trainers_for_traine1.Size = New System.Drawing.Size(940, 613)
        Me.Trainers_for_traine1.TabIndex = 12
        Me.Trainers_for_traine1.Visible = False
        '
        'trainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1177, 694)
        Me.Controls.Add(Me.Trainers_for_traine1)
        Me.Controls.Add(Me.Tarainer_date1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.button13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "trainer"
        Me.Text = "trainer"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button13 As System.Windows.Forms.Button
    Friend WithEvents Tarainer_date1 As DrivingTraining.tarainer_date
    Friend WithEvents Trainers_for_traine1 As DrivingTraining.trainers_for_traine
End Class
