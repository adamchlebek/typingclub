﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileInformation
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
        Me.components = New System.ComponentModel.Container()
        Me.gbFileInfo = New System.Windows.Forms.GroupBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblCapscore = New System.Windows.Forms.Label()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.dgvInformation = New System.Windows.Forms.DataGridView()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.btnExportTextFile = New System.Windows.Forms.Button()
        Me.btnSendKeys = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbFileInfo.SuspendLayout()
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFileInfo
        '
        Me.gbFileInfo.Controls.Add(Me.lblTimer)
        Me.gbFileInfo.Controls.Add(Me.lblCapscore)
        Me.gbFileInfo.Controls.Add(Me.lblWeek)
        Me.gbFileInfo.Controls.Add(Me.lblHour)
        Me.gbFileInfo.Controls.Add(Me.lblTeacher)
        Me.gbFileInfo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFileInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbFileInfo.Name = "gbFileInfo"
        Me.gbFileInfo.Size = New System.Drawing.Size(533, 83)
        Me.gbFileInfo.TabIndex = 0
        Me.gbFileInfo.TabStop = False
        Me.gbFileInfo.Text = "File Information"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(190, 28)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(149, 32)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "5 Seconds"
        Me.lblTimer.Visible = False
        '
        'lblCapscore
        '
        Me.lblCapscore.AutoSize = True
        Me.lblCapscore.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapscore.Location = New System.Drawing.Point(400, 47)
        Me.lblCapscore.Name = "lblCapscore"
        Me.lblCapscore.Size = New System.Drawing.Size(127, 21)
        Me.lblCapscore.TabIndex = 4
        Me.lblCapscore.Text = "Cap Score: XXX"
        '
        'lblWeek
        '
        Me.lblWeek.AutoSize = True
        Me.lblWeek.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeek.Location = New System.Drawing.Point(440, 17)
        Me.lblWeek.Name = "lblWeek"
        Me.lblWeek.Size = New System.Drawing.Size(87, 21)
        Me.lblWeek.TabIndex = 3
        Me.lblWeek.Text = "Week #XX"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(6, 47)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(46, 21)
        Me.lblHour.TabIndex = 2
        Me.lblHour.Text = "Hour"
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher.Location = New System.Drawing.Point(6, 17)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(110, 30)
        Me.lblTeacher.TabIndex = 1
        Me.lblTeacher.Text = "Teacher"
        '
        'dgvInformation
        '
        Me.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformation.Location = New System.Drawing.Point(12, 102)
        Me.dgvInformation.Name = "dgvInformation"
        Me.dgvInformation.Size = New System.Drawing.Size(533, 261)
        Me.dgvInformation.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(189, 390)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(162, 41)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.Location = New System.Drawing.Point(133, 366)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(278, 21)
        Me.lblCorrect.TabIndex = 2
        Me.lblCorrect.Text = "Triple Click a Cell to Edit the Value."
        '
        'btnExportTextFile
        '
        Me.btnExportTextFile.Enabled = False
        Me.btnExportTextFile.Location = New System.Drawing.Point(281, 390)
        Me.btnExportTextFile.Name = "btnExportTextFile"
        Me.btnExportTextFile.Size = New System.Drawing.Size(162, 41)
        Me.btnExportTextFile.TabIndex = 3
        Me.btnExportTextFile.Text = "Export"
        Me.btnExportTextFile.UseVisualStyleBackColor = True
        Me.btnExportTextFile.Visible = False
        '
        'btnSendKeys
        '
        Me.btnSendKeys.Location = New System.Drawing.Point(102, 390)
        Me.btnSendKeys.Name = "btnSendKeys"
        Me.btnSendKeys.Size = New System.Drawing.Size(162, 41)
        Me.btnSendKeys.TabIndex = 4
        Me.btnSendKeys.Text = "Send Keys"
        Me.btnSendKeys.UseVisualStyleBackColor = True
        Me.btnSendKeys.Visible = False
        '
        'Timer1
        '
        '
        'FileInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 443)
        Me.Controls.Add(Me.btnSendKeys)
        Me.Controls.Add(Me.btnExportTextFile)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.dgvInformation)
        Me.Controls.Add(Me.gbFileInfo)
        Me.Name = "FileInformation"
        Me.Text = "File Information"
        Me.gbFileInfo.ResumeLayout(False)
        Me.gbFileInfo.PerformLayout()
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbFileInfo As GroupBox
    Friend WithEvents lblTeacher As Label
    Friend WithEvents lblWeek As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents dgvInformation As DataGridView
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblCorrect As Label
    Friend WithEvents btnExportTextFile As Button
    Friend WithEvents btnSendKeys As Button
    Friend WithEvents lblCapscore As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
End Class
