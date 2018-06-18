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
                var.totalTime.Add(totalTime)
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
                var.totalTime.Add(totalTime)
            End If
        Next
    End Sub

    Public Sub FillScore()
        Dim score As Integer
        Dim capScore As Integer = 60 * var.week

        For i As Integer = 0 To var.firstName.Count - 1
            Select Case CType(var.totalTime.Item(i), Integer)
                Case 0 To capScore * 0.05 - 1
                    var.score.Add(0)
                Case capScore * 0.05 To capScore * 0.1 - 1
                    var.score.Add(0.5)
                Case capScore * 0.1 To capScore * 0.15 - 1
                    var.score.Add(1)
                Case capScore * 0.15 To capScore * 0.2 - 1
                    var.score.Add(1.5)
                Case capScore * 0.2 To capScore * 0.25 - 1
                    var.score.Add(2)
                Case capScore * 0.25 To capScore * 0.3 - 1
                    var.score.Add(2.5)
                Case capScore * 0.3 To capScore * 0.35 - 1
                    var.score.Add(3)
                Case capScore * 0.35 To capScore * 0.4 - 1
                    var.score.Add(3.5)
                Case capScore * 0.4 To capScore * 0.45 - 1
                    var.score.Add(4)
                Case capScore * 0.45 To capScore * 0.5 - 1
                    var.score.Add(4.5)
                Case capScore * 0.5 To capScore * 0.55 - 1
                    var.score.Add(5)
                Case capScore * 0.55 To capScore * 0.6 - 1
                    var.score.Add(5.5)
                Case capScore * 0.6 To capScore * 0.65 - 1
                    var.score.Add(6)
                Case capScore * 0.65 To capScore * 0.7 - 1
                    var.score.Add(6.5)
                Case capScore * 0.7 To capScore * 0.75 - 1
                    var.score.Add(7)
                Case capScore * 0.75 To capScore * 0.8 - 1
                    var.score.Add(7.5)
                Case capScore * 0.8 To capScore * 0.85 - 1
                    var.score.Add(8.5)
                Case capScore * 0.85 To capScore * 0.9 - 1
                    var.score.Add(9)
                Case capScore * 0.9 To capScore * 0.95 - 1
                    var.score.Add(9.5)
                Case capScore * 0.95 To capScore * 1 - 1
                    var.score.Add(10)
                Case > capScore * 1
                    var.score.Add(10)
                Case Else
                    var.score.Add(-1)
            End Select
        Next

        For i As Integer = 0 To var.score.Count - 1
            dgvInformation.Rows(i).Cells("Score").Value = var.score.Item(i)
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
        GetTotalTime()

        For Each dgvr As DataGridViewRow In Me.dgvInformation.Rows
            dgvr.Cells("Hours").Value = String.Empty
        Next

        dgvInformation.ColumnCount = 4
        dgvInformation.Columns(2).Name = "Minutes"
        dgvInformation.Columns(3).Name = "Score"

        For i As Integer = 0 To var.totalTime.Count - 1
            dgvInformation.Rows(i).Cells("Minutes").Value = var.totalTime.Item(i)
        Next

        FillScore()

        For i As Integer = 0 To var.totalTime.Count - 1
            dgvInformation.Rows(i).Cells("Score").Value = var.score.Item(i)
        Next

        For i As Integer = 0 To dgvInformation.RowCount - 2
            Dim myRgbColor As New Color()

            Select Case dgvInformation.Rows(i).Cells("Score").Value
                Case 0
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(200, 0, 30)
                Case 0.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(183, 8, 36)
                Case 1
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(176, 16, 37)
                Case 1.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(169, 24, 37)
                Case 2
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(162, 32, 38)
                Case 2.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(155, 40, 38)
                Case 3
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(148, 48, 39)
                Case 3.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(141, 56, 40)
                Case 4
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(134, 64, 40)
                Case 4.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(127, 72, 41)
                Case 5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(119, 80, 41)
                Case 5.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(112, 88, 42)
                Case 6
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(98, 104, 43)
                Case 6.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(91, 112, 44)
                Case 7
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(84, 120, 44)
                Case 7.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(77, 128, 45)
                Case 8
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(70, 136, 45)
                Case 8.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(63, 144, 46)
                Case 9
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(56, 152, 46)
                Case 9.5
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(49, 160, 48)
                Case 10
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Color.FromArgb(42, 168, 48)
                Case Else
                    dgvInformation.Rows(i).Cells("Score").Style.BackColor = Nothing
            End Select
        Next

        btnContinue.Visible = False
        btnSendKeys.Visible = True
        btnExportTextFile.Visible = True
    End Sub
End Class