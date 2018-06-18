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

        ShowFileInfo()
    End Sub

    Private Sub ShowFileInfo()
        txtFilePath.Text = myFile.FullName

        lblFileName.Text = "File Name: " & myFile.Name
        lblFileType.Text = "File Type: " & myFile.Extension
        lblFileSize.Text = "File Size: " & Math.Round(myFile.Length / 1024) & " KB"
        lblCreated.Text = "Created: " & myFile.CreationTime
        lblModified.Text = "Modified: " & myFile.LastWriteTime

        pbIcon.Image = Icon.ExtractAssociatedIcon(myFile.FullName).ToBitmap
    End Sub
End Class
