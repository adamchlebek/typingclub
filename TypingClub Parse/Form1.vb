Imports System.Runtime
Imports System.IO

Public Class Form1
    Private myFile As FileInfo

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

        myFile = New FileInfo(file)

        If String.IsNullOrWhiteSpace(myFile.Extension) Then Exit Sub
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(System.Drawing.Color.Gray, 5)

        Dim myGraphics As Graphics = Me.CreateGraphics

        myPen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
        myGraphics.DrawRectangle(myPen, 1, 1, Me.Width - 20, Me.Height - 42)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) / 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) / 2 - 50
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim fileName As String
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xls)|*.xls"
        openFileDialog1.Title = "Select a File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            myFile = New FileInfo(fileName)
        End If

        lblFileName.Text = myFile.FullName
    End Sub

    Private Sub lblDrag_Click(sender As Object, e As EventArgs) Handles lblDrag.Click
        Dim fileName As String
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xls)|*.xls"
        openFileDialog1.Title = "Select a File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            myFile = New FileInfo(fileName)
        End If

        lblFileName.Text = myFile.FullName
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim fileName As String
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xls)|*.xls"
        openFileDialog1.Title = "Select a File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            myFile = New FileInfo(fileName)
        End If

        lblFileName.Text = myFile.FullName
    End Sub
End Class
