<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditExamDialog
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
		lblQues = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		txtQues = New TextBox()
		txtA = New TextBox()
		txtB = New TextBox()
		txtC = New TextBox()
		txtD = New TextBox()
		previousQues = New Button()
		nextQues = New Button()
		createQues = New Button()
		cbbQues = New ComboBox()
		Label1 = New Label()
		grpChooseAns = New GroupBox()
		radioC = New RadioButton()
		radioD = New RadioButton()
		radioB = New RadioButton()
		radioA = New RadioButton()
		btnSave = New Button()
		delQues = New Button()
		chkAutoSave = New CheckBox()
		btnBrowImg = New Button()
		picPreview = New PictureBox()
		btnDelImage = New Button()
		grpChooseAns.SuspendLayout()
		CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' lblQues
		' 
		lblQues.AutoSize = True
		lblQues.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		lblQues.Location = New Point(30, 26)
		lblQues.Name = "lblQues"
		lblQues.Size = New Size(83, 28)
		lblQues.TabIndex = 0
		lblQues.Text = "Câu hỏi"
		lblQues.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label2.Location = New Point(590, 26)
		Label2.Name = "Label2"
		Label2.Size = New Size(99, 28)
		Label2.TabIndex = 1
		Label2.Text = "Đáp án A"
		Label2.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label3.Location = New Point(590, 135)
		Label3.Name = "Label3"
		Label3.Size = New Size(98, 28)
		Label3.TabIndex = 2
		Label3.Text = "Đáp án B"
		Label3.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label4.Location = New Point(590, 234)
		Label4.Name = "Label4"
		Label4.Size = New Size(97, 28)
		Label4.TabIndex = 3
		Label4.Text = "Đáp án C"
		Label4.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
		Label5.Location = New Point(590, 333)
		Label5.Name = "Label5"
		Label5.Size = New Size(100, 28)
		Label5.TabIndex = 4
		Label5.Text = "Đáp án D"
		Label5.TextAlign = ContentAlignment.MiddleCenter
		' 
		' txtQues
		' 
		txtQues.Location = New Point(30, 67)
		txtQues.Multiline = True
		txtQues.Name = "txtQues"
		txtQues.Size = New Size(540, 362)
		txtQues.TabIndex = 5
		' 
		' txtA
		' 
		txtA.Location = New Point(590, 67)
		txtA.Multiline = True
		txtA.Name = "txtA"
		txtA.Size = New Size(546, 65)
		txtA.TabIndex = 6
		' 
		' txtB
		' 
		txtB.Location = New Point(590, 166)
		txtB.Multiline = True
		txtB.Name = "txtB"
		txtB.Size = New Size(546, 65)
		txtB.TabIndex = 7
		' 
		' txtC
		' 
		txtC.Location = New Point(590, 265)
		txtC.Multiline = True
		txtC.Name = "txtC"
		txtC.Size = New Size(546, 65)
		txtC.TabIndex = 8
		' 
		' txtD
		' 
		txtD.Location = New Point(590, 364)
		txtD.Multiline = True
		txtD.Name = "txtD"
		txtD.Size = New Size(546, 65)
		txtD.TabIndex = 9
		' 
		' previousQues
		' 
		previousQues.Font = New Font("Segoe UI", 11F)
		previousQues.Location = New Point(30, 484)
		previousQues.Name = "previousQues"
		previousQues.Size = New Size(133, 45)
		previousQues.TabIndex = 10
		previousQues.Text = "Câu trước"
		previousQues.UseVisualStyleBackColor = True
		' 
		' nextQues
		' 
		nextQues.Font = New Font("Segoe UI", 11F)
		nextQues.Location = New Point(191, 484)
		nextQues.Name = "nextQues"
		nextQues.Size = New Size(133, 45)
		nextQues.TabIndex = 11
		nextQues.Text = "Câu kế tiếp"
		nextQues.UseVisualStyleBackColor = True
		' 
		' createQues
		' 
		createQues.Font = New Font("Segoe UI", 11F)
		createQues.Location = New Point(30, 547)
		createQues.Name = "createQues"
		createQues.Size = New Size(133, 45)
		createQues.TabIndex = 12
		createQues.Text = "Thêm câu hỏi"
		createQues.UseVisualStyleBackColor = True
		' 
		' cbbQues
		' 
		cbbQues.FormattingEnabled = True
		cbbQues.Location = New Point(191, 604)
		cbbQues.Name = "cbbQues"
		cbbQues.Size = New Size(133, 23)
		cbbQues.TabIndex = 13
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 12F)
		Label1.Location = New Point(30, 602)
		Label1.Name = "Label1"
		Label1.Size = New Size(104, 21)
		Label1.TabIndex = 14
		Label1.Text = "Chọn câu hỏi:"
		' 
		' grpChooseAns
		' 
		grpChooseAns.Controls.Add(radioC)
		grpChooseAns.Controls.Add(radioD)
		grpChooseAns.Controls.Add(radioB)
		grpChooseAns.Controls.Add(radioA)
		grpChooseAns.Location = New Point(358, 476)
		grpChooseAns.Name = "grpChooseAns"
		grpChooseAns.Size = New Size(212, 151)
		grpChooseAns.TabIndex = 15
		grpChooseAns.TabStop = False
		grpChooseAns.Text = "Chọn đáp án đúng"
		' 
		' radioC
		' 
		radioC.AutoSize = True
		radioC.Font = New Font("Segoe UI", 11F)
		radioC.Location = New Point(6, 82)
		radioC.Name = "radioC"
		radioC.Size = New Size(88, 24)
		radioC.TabIndex = 3
		radioC.TabStop = True
		radioC.Text = "Đáp án C"
		radioC.UseVisualStyleBackColor = True
		' 
		' radioD
		' 
		radioD.AutoSize = True
		radioD.Font = New Font("Segoe UI", 11F)
		radioD.Location = New Point(6, 112)
		radioD.Name = "radioD"
		radioD.Size = New Size(90, 24)
		radioD.TabIndex = 2
		radioD.TabStop = True
		radioD.Text = "Đáp án D"
		radioD.UseVisualStyleBackColor = True
		' 
		' radioB
		' 
		radioB.AutoSize = True
		radioB.Font = New Font("Segoe UI", 11F)
		radioB.Location = New Point(6, 52)
		radioB.Name = "radioB"
		radioB.Size = New Size(88, 24)
		radioB.TabIndex = 1
		radioB.TabStop = True
		radioB.Text = "Đáp án B"
		radioB.UseVisualStyleBackColor = True
		' 
		' radioA
		' 
		radioA.AutoSize = True
		radioA.Font = New Font("Segoe UI", 11F)
		radioA.Location = New Point(6, 22)
		radioA.Name = "radioA"
		radioA.Size = New Size(89, 24)
		radioA.TabIndex = 0
		radioA.TabStop = True
		radioA.Text = "Đáp án A"
		radioA.UseVisualStyleBackColor = True
		' 
		' btnSave
		' 
		btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
		btnSave.Location = New Point(590, 612)
		btnSave.Name = "btnSave"
		btnSave.Size = New Size(193, 45)
		btnSave.TabIndex = 17
		btnSave.Text = "Lưu thay đổi"
		btnSave.UseVisualStyleBackColor = True
		' 
		' delQues
		' 
		delQues.Font = New Font("Segoe UI", 11F)
		delQues.Location = New Point(191, 547)
		delQues.Name = "delQues"
		delQues.Size = New Size(133, 45)
		delQues.TabIndex = 18
		delQues.Text = "Xoá câu hỏi"
		delQues.UseVisualStyleBackColor = True
		' 
		' chkAutoSave
		' 
		chkAutoSave.AutoSize = True
		chkAutoSave.Location = New Point(590, 587)
		chkAutoSave.Name = "chkAutoSave"
		chkAutoSave.Size = New Size(193, 19)
		chkAutoSave.TabIndex = 19
		chkAutoSave.Text = "Tự động lưu khi chuyển câu hỏi"
		chkAutoSave.UseVisualStyleBackColor = True
		' 
		' btnBrowImg
		' 
		btnBrowImg.Font = New Font("Segoe UI", 11F)
		btnBrowImg.Location = New Point(590, 456)
		btnBrowImg.Name = "btnBrowImg"
		btnBrowImg.Size = New Size(193, 43)
		btnBrowImg.TabIndex = 21
		btnBrowImg.Text = "Chèn ảnh"
		btnBrowImg.UseVisualStyleBackColor = True
		' 
		' picPreview
		' 
		picPreview.BorderStyle = BorderStyle.FixedSingle
		picPreview.Location = New Point(803, 456)
		picPreview.Name = "picPreview"
		picPreview.Size = New Size(333, 201)
		picPreview.SizeMode = PictureBoxSizeMode.Zoom
		picPreview.TabIndex = 22
		picPreview.TabStop = False
		' 
		' btnDelImage
		' 
		btnDelImage.Font = New Font("Segoe UI", 11F)
		btnDelImage.Location = New Point(590, 519)
		btnDelImage.Name = "btnDelImage"
		btnDelImage.Size = New Size(193, 43)
		btnDelImage.TabIndex = 23
		btnDelImage.Text = "Xoá ảnh"
		btnDelImage.UseVisualStyleBackColor = True
		' 
		' EditExamDialog
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1162, 669)
		Controls.Add(btnDelImage)
		Controls.Add(picPreview)
		Controls.Add(btnBrowImg)
		Controls.Add(chkAutoSave)
		Controls.Add(delQues)
		Controls.Add(btnSave)
		Controls.Add(grpChooseAns)
		Controls.Add(Label1)
		Controls.Add(cbbQues)
		Controls.Add(createQues)
		Controls.Add(nextQues)
		Controls.Add(previousQues)
		Controls.Add(txtD)
		Controls.Add(txtC)
		Controls.Add(txtB)
		Controls.Add(txtA)
		Controls.Add(txtQues)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(lblQues)
		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		Name = "EditExamDialog"
		StartPosition = FormStartPosition.CenterScreen
		Text = "M2ExamCreator"
		grpChooseAns.ResumeLayout(False)
		grpChooseAns.PerformLayout()
		CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblQues As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtQues As TextBox
	Friend WithEvents txtA As TextBox
	Friend WithEvents txtB As TextBox
	Friend WithEvents txtC As TextBox
	Friend WithEvents txtD As TextBox
	Friend WithEvents previousQues As Button
	Friend WithEvents nextQues As Button
	Friend WithEvents createQues As Button
	Friend WithEvents cbbQues As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents grpChooseAns As GroupBox
	Friend WithEvents radioC As RadioButton
	Friend WithEvents radioD As RadioButton
	Friend WithEvents radioB As RadioButton
	Friend WithEvents radioA As RadioButton
	Friend WithEvents btnSave As Button
	Friend WithEvents delQues As Button
	Friend WithEvents chkAutoSave As CheckBox
	Friend WithEvents btnBrowImg As Button
	Friend WithEvents picPreview As PictureBox
	Friend WithEvents btnDelImage As Button
End Class
