<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDialog
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
		Label1 = New Label()
		btnCreateExam = New Button()
		btnOpenExam = New Button()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label1.Location = New Point(106, 26)
		Label1.Name = "Label1"
		Label1.Size = New Size(164, 28)
		Label1.TabIndex = 0
		Label1.Text = "M2ExamCreator"
		' 
		' btnCreateExam
		' 
		btnCreateExam.Font = New Font("Segoe UI", 12F)
		btnCreateExam.Location = New Point(50, 81)
		btnCreateExam.Name = "btnCreateExam"
		btnCreateExam.Size = New Size(120, 120)
		btnCreateExam.TabIndex = 1
		btnCreateExam.Text = "Tạo đề thi"
		btnCreateExam.UseVisualStyleBackColor = True
		' 
		' btnOpenExam
		' 
		btnOpenExam.Font = New Font("Segoe UI", 12F)
		btnOpenExam.Location = New Point(200, 81)
		btnOpenExam.Name = "btnOpenExam"
		btnOpenExam.Size = New Size(120, 120)
		btnOpenExam.TabIndex = 2
		btnOpenExam.Text = "Mở đề thi"
		btnOpenExam.UseVisualStyleBackColor = True
		' 
		' MainDialog
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(368, 235)
		Controls.Add(btnOpenExam)
		Controls.Add(btnCreateExam)
		Controls.Add(Label1)
		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		Name = "MainDialog"
		StartPosition = FormStartPosition.CenterScreen
		Text = "M2ExamCreator"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnCreateExam As Button
	Friend WithEvents btnOpenExam As Button
End Class
