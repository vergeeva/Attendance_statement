<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentDateOfBorn = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Girl = New System.Windows.Forms.RadioButton()
        Me.Boy = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentNum = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.School = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StudentClass = New System.Windows.Forms.NumericUpDown()
        Me.StudentTeacher = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cabinet = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ParentName1 = New System.Windows.Forms.TextBox()
        Me.ParentRelShip1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ParentNumber1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ParentHomeNumber1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ParentHomeNumber2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ParentNumber2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ParentRelShip2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ParentName2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ParentHomeNumber3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ParentNumber3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ParentRelShip3 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ParentName3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentName
        '
        Me.StudentName.Location = New System.Drawing.Point(19, 61)
        Me.StudentName.Margin = New System.Windows.Forms.Padding(4)
        Me.StudentName.Name = "StudentName"
        Me.StudentName.Size = New System.Drawing.Size(502, 26)
        Me.StudentName.TabIndex = 0
        Me.StudentName.Text = "Вергеева Анастасия Олеговна"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ФИО учащегося"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cabinet)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.StudentTeacher)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.StudentClass)
        Me.GroupBox1.Controls.Add(Me.School)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.StudentDateOfBorn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Girl)
        Me.GroupBox1.Controls.Add(Me.Boy)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StudentNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.StudentName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 277)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Информация об учащемся"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Дата рождения учащегося"
        '
        'StudentDateOfBorn
        '
        Me.StudentDateOfBorn.Location = New System.Drawing.Point(19, 179)
        Me.StudentDateOfBorn.Name = "StudentDateOfBorn"
        Me.StudentDateOfBorn.Size = New System.Drawing.Size(255, 26)
        Me.StudentDateOfBorn.TabIndex = 7
        Me.StudentDateOfBorn.Value = New Date(2001, 7, 15, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Пол учащегося"
        '
        'Girl
        '
        Me.Girl.AutoSize = True
        Me.Girl.Checked = True
        Me.Girl.Location = New System.Drawing.Point(307, 124)
        Me.Girl.Name = "Girl"
        Me.Girl.Size = New System.Drawing.Size(88, 23)
        Me.Girl.TabIndex = 5
        Me.Girl.TabStop = True
        Me.Girl.Text = "Женский"
        Me.Girl.UseVisualStyleBackColor = True
        '
        'Boy
        '
        Me.Boy.AutoSize = True
        Me.Boy.Location = New System.Drawing.Point(212, 123)
        Me.Boy.Name = "Boy"
        Me.Boy.Size = New System.Drawing.Size(89, 23)
        Me.Boy.TabIndex = 4
        Me.Boy.Text = "Мужской"
        Me.Boy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Номер учащегося"
        '
        'StudentNum
        '
        Me.StudentNum.Location = New System.Drawing.Point(19, 120)
        Me.StudentNum.Name = "StudentNum"
        Me.StudentNum.Size = New System.Drawing.Size(176, 26)
        Me.StudentNum.TabIndex = 2
        Me.StudentNum.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Школа"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ГБДОУ", "МБДОУ", "ГБОУ", "МБОУ", "МКОУ", "СОШ", "МАОУ", "МАОУ СОШ", "МКШ", "СУНЦ", "ШНОР", "ШВОР", "ГБПОУ КМБ", "ГКОУ СКОШИ"})
        Me.ComboBox1.Location = New System.Drawing.Point(292, 178)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 27)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.Text = "МАОУ СОШ"
        '
        'School
        '
        Me.School.Location = New System.Drawing.Point(439, 179)
        Me.School.Name = "School"
        Me.School.Size = New System.Drawing.Size(82, 26)
        Me.School.TabIndex = 11
        Me.School.Text = "147"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Класс"
        '
        'StudentClass
        '
        Me.StudentClass.Location = New System.Drawing.Point(19, 233)
        Me.StudentClass.Name = "StudentClass"
        Me.StudentClass.Size = New System.Drawing.Size(176, 26)
        Me.StudentClass.TabIndex = 12
        Me.StudentClass.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'StudentTeacher
        '
        Me.StudentTeacher.Location = New System.Drawing.Point(218, 233)
        Me.StudentTeacher.Name = "StudentTeacher"
        Me.StudentTeacher.Size = New System.Drawing.Size(303, 26)
        Me.StudentTeacher.TabIndex = 14
        Me.StudentTeacher.Text = "Понятовская Е.В."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Учитель"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Кабинет"
        '
        'Cabinet
        '
        Me.Cabinet.Location = New System.Drawing.Point(401, 121)
        Me.Cabinet.Name = "Cabinet"
        Me.Cabinet.Size = New System.Drawing.Size(120, 26)
        Me.Cabinet.TabIndex = 17
        Me.Cabinet.Text = "21"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ParentHomeNumber1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ParentNumber1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ParentRelShip1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ParentName1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 203)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Информация о первом родителе/опекуне"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ФИО родителя/опекуна"
        '
        'ParentName1
        '
        Me.ParentName1.Location = New System.Drawing.Point(18, 55)
        Me.ParentName1.Margin = New System.Windows.Forms.Padding(4)
        Me.ParentName1.Name = "ParentName1"
        Me.ParentName1.Size = New System.Drawing.Size(502, 26)
        Me.ParentName1.TabIndex = 2
        Me.ParentName1.Text = "Вергеева Елена Александровна"
        '
        'ParentRelShip1
        '
        Me.ParentRelShip1.Location = New System.Drawing.Point(18, 107)
        Me.ParentRelShip1.Name = "ParentRelShip1"
        Me.ParentRelShip1.Size = New System.Drawing.Size(201, 26)
        Me.ParentRelShip1.TabIndex = 4
        Me.ParentRelShip1.Text = "Родитель"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Отношение"
        '
        'ParentNumber1
        '
        Me.ParentNumber1.Location = New System.Drawing.Point(246, 107)
        Me.ParentNumber1.Mask = "+7(999) 000-00-00"
        Me.ParentNumber1.Name = "ParentNumber1"
        Me.ParentNumber1.Size = New System.Drawing.Size(197, 26)
        Me.ParentNumber1.TabIndex = 19
        Me.ParentNumber1.Text = "9085982371"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(242, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Рабочий телефон"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Домашний телефон"
        '
        'ParentHomeNumber1
        '
        Me.ParentHomeNumber1.Location = New System.Drawing.Point(162, 146)
        Me.ParentHomeNumber1.Mask = "000-00-00"
        Me.ParentHomeNumber1.Name = "ParentHomeNumber1"
        Me.ParentHomeNumber1.Size = New System.Drawing.Size(197, 26)
        Me.ParentHomeNumber1.TabIndex = 22
        Me.ParentHomeNumber1.Text = "7777777"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ParentHomeNumber2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ParentNumber2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.ParentRelShip2)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ParentName2)
        Me.GroupBox3.Location = New System.Drawing.Point(564, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 225)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Информация о втором родителе/опекуне"
        '
        'ParentHomeNumber2
        '
        Me.ParentHomeNumber2.Location = New System.Drawing.Point(166, 172)
        Me.ParentHomeNumber2.Mask = "000-00-00"
        Me.ParentHomeNumber2.Name = "ParentHomeNumber2"
        Me.ParentHomeNumber2.Size = New System.Drawing.Size(197, 26)
        Me.ParentHomeNumber2.TabIndex = 22
        Me.ParentHomeNumber2.Text = "5555555"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 19)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Домашний телефон"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 19)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Рабочий телефон"
        '
        'ParentNumber2
        '
        Me.ParentNumber2.Location = New System.Drawing.Point(166, 132)
        Me.ParentNumber2.Mask = "+7(999) 000-00-00"
        Me.ParentNumber2.Name = "ParentNumber2"
        Me.ParentNumber2.Size = New System.Drawing.Size(197, 26)
        Me.ParentNumber2.TabIndex = 19
        Me.ParentNumber2.Text = "9085760268"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(68, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Отношение"
        '
        'ParentRelShip2
        '
        Me.ParentRelShip2.Location = New System.Drawing.Point(162, 93)
        Me.ParentRelShip2.Name = "ParentRelShip2"
        Me.ParentRelShip2.Size = New System.Drawing.Size(201, 26)
        Me.ParentRelShip2.TabIndex = 4
        Me.ParentRelShip2.Text = "Родитель"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 19)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "ФИО родителя/опекуна"
        '
        'ParentName2
        '
        Me.ParentName2.Location = New System.Drawing.Point(18, 52)
        Me.ParentName2.Margin = New System.Windows.Forms.Padding(4)
        Me.ParentName2.Name = "ParentName2"
        Me.ParentName2.Size = New System.Drawing.Size(345, 26)
        Me.ParentName2.TabIndex = 2
        Me.ParentName2.Text = "Вергеев Олег Леонидович"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ParentHomeNumber3)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.ParentNumber3)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.ParentRelShip3)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.ParentName3)
        Me.GroupBox4.Location = New System.Drawing.Point(564, 245)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(387, 225)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Информация о контактном лице"
        '
        'ParentHomeNumber3
        '
        Me.ParentHomeNumber3.Location = New System.Drawing.Point(166, 172)
        Me.ParentHomeNumber3.Mask = "000-00-00"
        Me.ParentHomeNumber3.Name = "ParentHomeNumber3"
        Me.ParentHomeNumber3.Size = New System.Drawing.Size(197, 26)
        Me.ParentHomeNumber3.TabIndex = 22
        Me.ParentHomeNumber3.Text = "8888888"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 19)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Домашний телефон"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 19)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Рабочий телефон"
        '
        'ParentNumber3
        '
        Me.ParentNumber3.Location = New System.Drawing.Point(166, 132)
        Me.ParentNumber3.Mask = "+7(999) 000-00-00"
        Me.ParentNumber3.Name = "ParentNumber3"
        Me.ParentNumber3.Size = New System.Drawing.Size(197, 26)
        Me.ParentNumber3.TabIndex = 19
        Me.ParentNumber3.Text = "9088860371"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(68, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 19)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Отношение"
        '
        'ParentRelShip3
        '
        Me.ParentRelShip3.Location = New System.Drawing.Point(162, 93)
        Me.ParentRelShip3.Name = "ParentRelShip3"
        Me.ParentRelShip3.Size = New System.Drawing.Size(201, 26)
        Me.ParentRelShip3.TabIndex = 4
        Me.ParentRelShip3.Text = "Родитель"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 19)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "ФИО родителя/опекуна"
        '
        'ParentName3
        '
        Me.ParentName3.Location = New System.Drawing.Point(18, 52)
        Me.ParentName3.Margin = New System.Windows.Forms.Padding(4)
        Me.ParentName3.Name = "ParentName3"
        Me.ParentName3.Size = New System.Drawing.Size(345, 26)
        Me.ParentName3.TabIndex = 2
        Me.ParentName3.Text = "Вергеев Олег Леонидович"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(387, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Перейти к выставлению посещаемости"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Public WithEvents StudentName As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents Label4 As Label
    Public WithEvents StudentDateOfBorn As DateTimePicker
    Public WithEvents Label3 As Label
    Public WithEvents Girl As RadioButton
    Public WithEvents Boy As RadioButton
    Public WithEvents Label2 As Label
    Public WithEvents StudentNum As NumericUpDown
    Public WithEvents Cabinet As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents Label7 As Label
    Public WithEvents StudentTeacher As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents StudentClass As NumericUpDown
    Public WithEvents School As TextBox
    Public WithEvents ComboBox1 As ComboBox
    Public WithEvents Label5 As Label
    Public WithEvents ParentHomeNumber1 As MaskedTextBox
    Public WithEvents Label12 As Label
    Public WithEvents Label11 As Label
    Public WithEvents ParentNumber1 As MaskedTextBox
    Public WithEvents Label10 As Label
    Public WithEvents ParentRelShip1 As TextBox
    Public WithEvents Label9 As Label
    Public WithEvents ParentName1 As TextBox
    Public WithEvents ParentHomeNumber2 As MaskedTextBox
    Public WithEvents Label13 As Label
    Public WithEvents Label14 As Label
    Public WithEvents ParentNumber2 As MaskedTextBox
    Public WithEvents Label15 As Label
    Public WithEvents ParentRelShip2 As TextBox
    Public WithEvents Label16 As Label
    Public WithEvents ParentName2 As TextBox
    Public WithEvents ParentHomeNumber3 As MaskedTextBox
    Public WithEvents Label17 As Label
    Public WithEvents Label18 As Label
    Public WithEvents ParentNumber3 As MaskedTextBox
    Public WithEvents Label19 As Label
    Public WithEvents ParentRelShip3 As TextBox
    Public WithEvents Label20 As Label
    Public WithEvents ParentName3 As TextBox
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents GroupBox2 As GroupBox
    Public WithEvents GroupBox3 As GroupBox
    Public WithEvents GroupBox4 As GroupBox
End Class
