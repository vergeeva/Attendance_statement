Imports Microsoft.Office.Interop
Imports System.IO
Public Class Form2
    Dim dict As Dictionary(Of Integer, Dictionary(Of Integer, String)) = New Dictionary(Of Integer, Dictionary(Of Integer, String))
    'Для хранения посещаемости
    Public Function TakeFrom(FileName As String, ByRef d As Dictionary(Of Integer, Dictionary(Of Integer, String)), Month As Integer) As Integer
        Dim sr As IO.StreamReader = New IO.StreamReader(My.Application.Info.DirectoryPath & "\" & FileName)
        Dim st As String
        Dim temp As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        While sr.Peek <> -1
            st = sr.ReadLine()
            If st <> "" Then
                Dim Day As Integer = Convert.ToInt32(st.Split("!")(0))
                Dim Status As String = st.Split("!")(1)
                temp.Add(Day, Status)
            End If
        End While
        d.Add(Month, temp)
        sr.Close()
        Return 1
    End Function

    Public Function WriteIn(Month As Integer, ByRef d As Dictionary(Of Integer, Dictionary(Of Integer, String))) As Integer
        Dim Mnth As String = ""
        Select Case Month
            Case 1
                Mnth = "Январь"
            Case 2
                Mnth = "Февраль"
            Case 3
                Mnth = "Март"
            Case 4
                Mnth = "Апрель"
            Case 5
                Mnth = "Май"
            Case 6
                Mnth = "Июнь"
            Case 7
                Mnth = "Июль"
            Case 8
                Mnth = "Август"
            Case 9
                Mnth = "Сентябрь"
            Case 10
                Mnth = "Октябрь"
            Case 11
                Mnth = "Ноябрь"
            Case 12
                Mnth = "Декабрь"
        End Select
        Dim sw As IO.StreamWriter = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\" & Mnth & ".txt")
        Dim Line As String
        For Each el As KeyValuePair(Of Integer, String) In d(Month)
            Line = Convert.ToString(el.Key) + "!" + el.Value
            sw.WriteLine(Line)
        Next
        sw.Close()
        Return 0
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Создание экземпляра
        Dim MyExcel As New Excel.Application
        'Отображение на экране
        MyExcel.Visible = True
        'Открытие отчета по затратам
        MyExcel.Workbooks.Open(Filename:=Directory.GetCurrentDirectory() + "\ВедомостьПосещаемости.xlsx").Activate()
        Dim Frm As Form1 = New Form1()
        'Заполнение данных об ученике
        MyExcel.Range("A4").Select()
        MyExcel.ActiveCell.Value = Frm.StudentName.Text

        MyExcel.Range("J4").Select()
        MyExcel.ActiveCell.Value = Frm.StudentNum.Text

        If Frm.Boy.Checked Then
            MyExcel.Range("O4").Select()
            MyExcel.ActiveCell.Value = "Мужской"
        Else
            MyExcel.Range("O4").Select()
            MyExcel.ActiveCell.Value = "Женский"
        End If
        MyExcel.Range("R4").Select()
        MyExcel.ActiveCell.Value = Frm.StudentDateOfBorn.Value.ToShortDateString

        MyExcel.Range("V4").Select()
        MyExcel.ActiveCell.Value = Frm.ComboBox1.Text + " № " + Frm.School.Text

        MyExcel.Range("AD4").Select()
        MyExcel.ActiveCell.Value = Frm.StudentClass.Text

        MyExcel.Range("AG4").Select()
        MyExcel.ActiveCell.Value = Frm.StudentTeacher.Text

        MyExcel.Range("AJ4").Select()
        MyExcel.ActiveCell.Value = Frm.Cabinet.Text

        'Заполнение данных о родителях
        'Первый родитель:
        MyExcel.Range("A6").Select()
        MyExcel.ActiveCell.Value = Frm.ParentName1.Text

        MyExcel.Range("J6").Select()
        MyExcel.ActiveCell.Value = Frm.ParentRelShip1.Text

        MyExcel.Range("V6").Select()
        MyExcel.ActiveCell.Value = Frm.ParentNumber1.Text

        MyExcel.Range("AD6").Select()
        MyExcel.ActiveCell.Value = Frm.ParentHomeNumber1.Text

        'второй родитель
        MyExcel.Range("A8").Select()
        MyExcel.ActiveCell.Value = Frm.ParentName2.Text

        MyExcel.Range("J8").Select()
        MyExcel.ActiveCell.Value = Frm.ParentRelShip2.Text

        MyExcel.Range("V8").Select()
        MyExcel.ActiveCell.Value = Frm.ParentNumber2.Text

        MyExcel.Range("AD8").Select()
        MyExcel.ActiveCell.Value = Frm.ParentHomeNumber2.Text

        'Контактное лицо

        MyExcel.Range("A10").Select()
        MyExcel.ActiveCell.Value = Frm.ParentName3.Text

        MyExcel.Range("J10").Select()
        MyExcel.ActiveCell.Value = Frm.ParentRelShip3.Text

        MyExcel.Range("V10").Select()
        MyExcel.ActiveCell.Value = Frm.ParentNumber3.Text

        MyExcel.Range("AD10").Select()
        MyExcel.ActiveCell.Value = Frm.ParentHomeNumber3.Text

        'Выставление посещамости
        Dim RangeList = New String() {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF"}
        Dim Mnth As Integer
        For Each el As KeyValuePair(Of Integer, Dictionary(Of Integer, String)) In dict
            Select Case el.Key
                Case 1
                    Mnth = 23
                Case 2
                    Mnth = 25
                Case 3
                    Mnth = 27
                Case 4
                    Mnth = 29
                Case 5
                    Mnth = 31
                Case 6
                    Mnth = 33
                Case 7
                    Mnth = 35
                Case 8
                    Mnth = 13
                Case 9
                    Mnth = 15
                Case 10
                    Mnth = 17
                Case 11
                    Mnth = 19
                Case 12
                    Mnth = 21
            End Select
            For Each element As KeyValuePair(Of Integer, String) In el.Value

                For Each mark As String In RangeList
                    MyExcel.Range(mark & Mnth).Select()
                    If MyExcel.ActiveCell.Value = element.Key Then
                        MyExcel.Range(mark & Mnth + 1).Select()
                        MyExcel.ActiveCell.Value = element.Value
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Up As Date = New Date(2020, 8, 3)
        Dim Down As Date = New Date(2021, 7, 31)

        If Not (DateTimePicker1.Value >= Up And DateTimePicker1.Value <= Down) Then
            DateTimePicker1.Value = DateTime.Now
        End If

        If DateTimePicker1.Value.DayOfWeek = 6 Or DateTimePicker1.Value.DayOfWeek = 0 Then
            DateTimePicker1.Value = DateTime.Now
            MessageBox.Show("Это выходной день", "Предупреждение")
        End If
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        'Вывод по месяцам
        If dict.ContainsKey(DateTimePicker1.Value.Month) Then
            For Each el As KeyValuePair(Of Integer, String) In dict(DateTimePicker1.Value.Month)
                Dim cl As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                cl.HeaderText = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, el.Key).ToShortDateString
                cl.Width = 100
                DataGridView1.Columns.Add(cl)
                DataGridView1.Rows(0).Cells(DataGridView1.Columns.IndexOf(cl)).Value = el.Value
            Next
        Else
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim temp As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        Dim status As String = ""
        Select Case ComboBox1.Text
            Case "Присутствовал"
                status = "П"
            Case "Опоздание"
                status = "О"
            Case "Без уважительной причины"
                status = "Б"
            Case "По уважительной причине"
                status = "У"
        End Select
        If Not dict.ContainsKey(DateTimePicker1.Value.Month) Then
            If Not temp.ContainsKey(DateTimePicker1.Value.Day) Then
                Dim cl As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                temp.Add(DateTimePicker1.Value.Day, status)
                dict.Add(DateTimePicker1.Value.Month, temp)
                cl.HeaderText = DateTimePicker1.Value.ToShortDateString
                cl.Width = 100
                DataGridView1.Columns.Add(cl)
                DataGridView1.Rows(0).Cells(DataGridView1.Columns.IndexOf(cl)).Value = status
                WriteIn(DateTimePicker1.Value.Month, dict)
            End If
        Else
            If Not dict.Item(DateTimePicker1.Value.Month).ContainsKey(DateTimePicker1.Value.Day) Then
                Dim cl As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                dict.Item(DateTimePicker1.Value.Month).Add(DateTimePicker1.Value.Day, status)
                cl.HeaderText = DateTimePicker1.Value.ToShortDateString
                cl.Width = 100
                DataGridView1.Columns.Add(cl)
                DataGridView1.Rows(0).Cells(DataGridView1.Columns.IndexOf(cl)).Value = status
                WriteIn(DateTimePicker1.Value.Month, dict)
            Else
                MessageBox.Show("Посещаемость уже проставлена на эту дату", "Предупреждение")
            End If
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TakeFrom("Март.txt", dict, 3)
        TakeFrom("Апрель.txt", dict, 4)
        DateTimePicker1_ValueChanged(sender, e)
    End Sub
End Class