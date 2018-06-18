<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileInformation
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
        Me.gbFileInfo = New System.Windows.Forms.GroupBox()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.dgvInformation = New System.Windows.Forms.DataGridView()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.gbFileInfo.SuspendLayout()
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFileInfo
        '
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
        Me.dgvInformation.Size = New System.Drawing.Size(533, 226)
        Me.dgvInformation.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(189, 355)
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
        Me.lblCorrect.Location = New System.Drawing.Point(133, 331)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(278, 21)
        Me.lblCorrect.TabIndex = 2
        Me.lblCorrect.Text = "Triple Click a Cell to Edit the Value."
        '
        'FileInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 408)
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
End Class
