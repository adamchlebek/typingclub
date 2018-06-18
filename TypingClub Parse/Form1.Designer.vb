<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.gbFileInfo = New System.Windows.Forms.GroupBox()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.lblFileSize = New System.Windows.Forms.Label()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblModified = New System.Windows.Forms.Label()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.gbFileInfo.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFilePath
        '
        Me.txtFilePath.Enabled = False
        Me.txtFilePath.Location = New System.Drawing.Point(13, 13)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(441, 20)
        Me.txtFilePath.TabIndex = 0
        '
        'gbFileInfo
        '
        Me.gbFileInfo.Controls.Add(Me.pbIcon)
        Me.gbFileInfo.Controls.Add(Me.lblModified)
        Me.gbFileInfo.Controls.Add(Me.lblCreated)
        Me.gbFileInfo.Controls.Add(Me.lblFileSize)
        Me.gbFileInfo.Controls.Add(Me.lblFileType)
        Me.gbFileInfo.Controls.Add(Me.lblFileName)
        Me.gbFileInfo.Location = New System.Drawing.Point(13, 75)
        Me.gbFileInfo.Name = "gbFileInfo"
        Me.gbFileInfo.Size = New System.Drawing.Size(441, 116)
        Me.gbFileInfo.TabIndex = 1
        Me.gbFileInfo.TabStop = False
        Me.gbFileInfo.Text = "File Info"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Location = New System.Drawing.Point(79, 70)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(47, 13)
        Me.lblCreated.TabIndex = 3
        Me.lblCreated.Text = "Created:"
        '
        'lblFileSize
        '
        Me.lblFileSize.AutoSize = True
        Me.lblFileSize.Location = New System.Drawing.Point(79, 42)
        Me.lblFileSize.Name = "lblFileSize"
        Me.lblFileSize.Size = New System.Drawing.Size(49, 13)
        Me.lblFileSize.TabIndex = 2
        Me.lblFileSize.Text = "File Size:"
        '
        'lblFileType
        '
        Me.lblFileType.AutoSize = True
        Me.lblFileType.Location = New System.Drawing.Point(79, 29)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(53, 13)
        Me.lblFileType.TabIndex = 1
        Me.lblFileType.Text = "File Type:"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(79, 16)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(57, 13)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "File Name:"
        '
        'lblModified
        '
        Me.lblModified.AutoSize = True
        Me.lblModified.Location = New System.Drawing.Point(79, 83)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(50, 13)
        Me.lblModified.TabIndex = 4
        Me.lblModified.Text = "Modified:"
        '
        'pbIcon
        '
        Me.pbIcon.Location = New System.Drawing.Point(6, 17)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(67, 66)
        Me.pbIcon.TabIndex = 5
        Me.pbIcon.TabStop = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 214)
        Me.Controls.Add(Me.gbFileInfo)
        Me.Controls.Add(Me.txtFilePath)
        Me.Name = "Form1"
        Me.Text = "File Check"
        Me.gbFileInfo.ResumeLayout(False)
        Me.gbFileInfo.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents gbFileInfo As GroupBox
    Friend WithEvents lblCreated As Label
    Friend WithEvents lblFileSize As Label
    Friend WithEvents lblFileType As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblModified As Label
    Friend WithEvents pbIcon As PictureBox
End Class
