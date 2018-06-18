Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Runtime

Public Class FileInformation
    Dim editing As Boolean = False
    Private Sub FileInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        lblTeacher.Text = var.teacher
        lblHour.Text = var.hour & " hour"
        lblWeek.Text = "Week #" & var.week
        dgvInformation.ColumnCount = 3
        dgvInformation.Columns(0).Name = "Last Name"
        dgvInformation.Columns(1).Name = "First Name"
        dgvInformation.Columns(2).Name = "Hours"

        ReadCSV()
        AddData()
    End Sub

    Public Sub ReadCSV()
        Using reader = New StreamReader(var.myFile.FullName)

            Dim count As Integer = 0

            reader.ReadLine()

            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim values = line.Split(","c)
                var.lastName.Add(values(0))
                var.firstName.Add(values(1))
                var.hours.Add(values(9))
            End While
        End Using
    End Sub

    Public Sub AddData()
        For i As Integer = 0 To var.lastName.Count - 1
            dgvInformation.Rows.Add(var.lastName(i), var.firstName(i), var.hours(i))
        Next
    End Sub

    Public Sub GetTotalTime()
        Dim tempStr As String
        Dim values As String()
        Dim totalTime As Integer

        For i As Integer = 0 To var.hours.Count - 1
            If var.hours.Item(i).Contains("minutes") Then
                tempStr = var.hours(i).Substring(0, 5)
                values = tempStr.Split(":"c)
                values(0) = CType(values(0), Decimal)
                values(1) = CType(values(1), Decimal)
                totalTime = values(0)
                If values(1) >= 30 Then
                    totalTime += 1
                End If

            End If

            If var.hours.Item(i).Contains("hours") Then
                tempStr = var.hours(i).Substring(0, 8)
                values = tempStr.Split(":"c)
                values(0) = CType(values(0), Decimal)
                values(1) = CType(values(1), Decimal)
                values(2) = CType(values(2), Decimal)
                totalTime = values(0) * 60
                totalTime += values(1)
                If values(2) >= 30 Then
                    totalTime += 1
                End If
            End If
        Next
    End Sub

    Public Sub GetNewInfo()
        var.firstName.Clear()
        var.lastName.Clear()
        var.hours.Clear()

        For i As Integer = 1 To dgvInformation.RowCount - 1
            var.firstName.Add(dgvInformation.Rows(i - 1).Cells("First Name").Value.ToString)
            var.lastName.Add(dgvInformation.Rows(i - 1).Cells("Last Name").Value.ToString)
            var.hours.Add(dgvInformation.Rows(i - 1).Cells("Hours").Value.ToString)
        Next
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs)
        MsgBox("Please select the cell that is incorrect!")
        editing = True
    End Sub

    Private Sub dgvInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInformation.CellContentClick
        If editing Then
            Dim str As String = InputBox("Enter the information you would like to change: ", "Edit Value")

            If Not str = "" Then
                dgvInformation.CurrentCell.Value = str
            End If
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        GetNewInfo()

        dgvInformation.ColumnCount = 4
        dgvInformation.Columns(3).Name = "Score"
        GetTotalTime()
    End Sub
End Class