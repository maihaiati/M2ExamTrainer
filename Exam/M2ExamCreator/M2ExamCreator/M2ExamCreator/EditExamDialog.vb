Imports System.IO
Public Class EditExamDialog
	' Các biến liên quan đến đường dẫn file
	Public createExam As Boolean
	Public path As String
	Public quesPath As String
	Public answerPath As String
	Public assetsPath As String

	Private numOfQues As Integer ' Biến lưu giữ index của câu hỏi cuối cùng
	Private quesIndex As Integer ' Biến lưu giữ câu hỏi hiện thời đang trên màn hình
	Private quesList As String() = New String() {} ' Mảng lưu trữ danh sách câu hỏi
	Private answerList As String() = New String() {} ' Mảng lưu trữ danh sách đáp án
	Private splitQues = New String() {} ' Mảng chứa các thành phần của câu hỏi đang làm việc
	Private enableCommit As Boolean ' Biến lưu trữ trạng thái cho phép commit dữ liệu vào mảng hay không

	Private Sub saveData()
		' Mở tệp để ghi dữ liệu
		Using quesWriter As New StreamWriter(quesPath)
			For i = 0 To quesList.Length - 1
				If i <> quesList.Length - 1 Then
					quesWriter.WriteLine(quesList(i))
				Else
					quesWriter.Write(quesList(i))
				End If
			Next
		End Using

		Using answerWriter As New StreamWriter(answerPath)
			For i = 0 To answerList.Length - 1
				If i <> answerList.Length - 1 Then
					answerWriter.WriteLine(answerList(i))
				Else
					answerWriter.Write(answerList(i))
				End If
			Next
		End Using
	End Sub

	Private Sub commitToQues(quesIndex As Integer, index As Integer, data As String)
		Select Case index
			Case 0
				quesList(quesIndex) = data & "~" & Split(quesList(quesIndex), "~"c)(1) & "~" & Split(quesList(quesIndex), "~"c)(2) & "~" & Split(quesList(quesIndex), "~"c)(3) & "~" & Split(quesList(quesIndex), "~"c)(4)
			Case 1
				quesList(quesIndex) = Split(quesList(quesIndex), "~"c)(0) & "~" & data & "~" & Split(quesList(quesIndex), "~"c)(2) & "~" & Split(quesList(quesIndex), "~"c)(3) & "~" & Split(quesList(quesIndex), "~"c)(4)
			Case 2
				quesList(quesIndex) = Split(quesList(quesIndex), "~"c)(0) & "~" & Split(quesList(quesIndex), "~"c)(1) & "~" & data & "~" & Split(quesList(quesIndex), "~"c)(3) & "~" & Split(quesList(quesIndex), "~"c)(4)
			Case 3
				quesList(quesIndex) = Split(quesList(quesIndex), "~"c)(0) & "~" & Split(quesList(quesIndex), "~"c)(1) & "~" & Split(quesList(quesIndex), "~"c)(2) & "~" & data & "~" & Split(quesList(quesIndex), "~"c)(4)
			Case 4
				quesList(quesIndex) = Split(quesList(quesIndex), "~"c)(0) & "~" & Split(quesList(quesIndex), "~"c)(1) & "~" & Split(quesList(quesIndex), "~"c)(2) & "~" & Split(quesList(quesIndex), "~"c)(3) & "~" & data
		End Select
	End Sub

	Private Sub commitToAnswer(quesIndex As Integer, answer As Integer)
		answerList(quesIndex) = answer
	End Sub

	Private Sub addQues(question As String)
		' Thêm một phần tử mới vào mảng
		If quesList IsNot Nothing Then
			' Nếu mảng đã tồn tại, thêm phần tử mới vào cuối mảng và duy trì dữ liệu hiện có
			ReDim Preserve quesList(quesList.Length)
		Else
			' Nếu mảng chưa được khởi tạo, khởi tạo mảng có 1 phần tử
			ReDim quesList(0)
		End If
		' Gán giá trị cho phần tử mới
		quesList(quesList.Length - 1) = question
	End Sub

	Private Sub addAnswer(answer As String)
		If answerList IsNot Nothing Then
			ReDim Preserve answerList(answerList.Length)
		Else
			ReDim answerList(0)
		End If
		answerList(answerList.Length - 1) = answer
	End Sub

	Private Sub removeQues(index As Integer)
		If index >= 0 AndAlso index < quesList.Length Then
			Dim tempArray(quesList.Length - 2) As String
			Array.Copy(quesList, 0, tempArray, 0, index)
			Array.Copy(quesList, index + 1, tempArray, index, quesList.Length - index - 1)
			quesList = tempArray
		End If
	End Sub

	Private Sub removeAnswer(index As Integer)
		If index >= 0 AndAlso index < answerList.Length Then
			Dim tempArray(answerList.Length - 2) As String
			Array.Copy(answerList, 0, tempArray, 0, index)
			Array.Copy(answerList, index + 1, tempArray, index, answerList.Length - index - 1)
			answerList = tempArray
		End If
	End Sub

	Private Sub clearAllScreen()
		txtQues.Clear()
		txtA.Clear()
		txtB.Clear()
		txtC.Clear()
		txtD.Clear()
	End Sub

	Private Function multiToLine(ques As String)
		Return ques.Replace("<", "&lt;").Replace(">", "&gt;").Replace(vbCrLf, "<br>").Replace(" ", "&nbsp;").Replace(vbTab, "&nbsp;&nbsp;&nbsp;&nbsp;")
	End Function

	Private Function lineToMulti(ques As String)
		Return ques.Replace("&lt;", "<").Replace("&gt;", ">").Replace("<br>", vbCrLf).Replace("&nbsp;", " ").Replace("&nbsp;&nbsp;&nbsp;&nbsp;", vbTab)
	End Function

	Private Sub loadQues(quesNum As Integer)
		If chkAutoSave.Checked Then
			saveData()
		End If

		lblQues.Text = "Câu hỏi " & quesNum + 1
		quesIndex = quesNum
		enableCommit = True

		'If quesList.Length <= 0 Then
		'previousQues.Enabled = False
		'nextQues.Enabled = False
		'cbbQues.Enabled = False
		'createQues.Enabled = False
		'delQues.Enabled = False
		'radioA.Enabled = False
		'radioB.Enabled = False
		'radioC.Enabled = False
		'radioD.Enabled = False
		'splitQues = {"", "", "", "", ""}
		'Debug.WriteLine("Case 1: {0}", splitQues.Length)
		'Return
		'End If

		If numOfQues = 0 Then
			delQues.Enabled = False
		End If

		If quesList(quesNum) = "~ ~ ~ ~ " Then
			enableCommit = False
			clearAllScreen()
			previousQues.Enabled = False
			nextQues.Enabled = False
			cbbQues.Enabled = False
			createQues.Enabled = False
			radioA.Enabled = False
			radioB.Enabled = False
			radioC.Enabled = False
			radioD.Enabled = False
			cbbQues.SelectedIndex = quesNum
			splitQues = {"", "", "", "", ""}
			enableCommit = True
			Return
		End If

		splitQues = Split(quesList(quesNum), "~"c)
		txtQues.Text = lineToMulti(splitQues(0))
		For i = 1 To splitQues.Length - 1
			Select Case i
				Case 1
					txtA.Text = lineToMulti(splitQues(1))
				Case 2
					txtB.Text = lineToMulti(splitQues(2))
				Case 3
					txtC.Text = lineToMulti(splitQues(3))
				Case 4
					txtD.Text = lineToMulti(splitQues(4))
			End Select
		Next

		Select Case answerList(quesNum)
			Case -1
				radioA.Checked = False
				radioB.Checked = False
				radioC.Checked = False
				radioD.Checked = False
			Case 1
				radioA.Checked = True
			Case 2
				radioB.Checked = True
			Case 3
				radioC.Checked = True
			Case 4
				radioD.Checked = True
			Case Else
				radioA.Checked = True
		End Select

		cbbQues.SelectedIndex = quesNum
	End Sub

	Private Sub EditExamDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
		If createExam Then
			Dim quesFile As StreamWriter = File.CreateText(quesPath)
			Dim answerFile As StreamWriter = File.CreateText(answerPath)
			If Not Directory.Exists(assetsPath) Then
				Directory.CreateDirectory(assetsPath)
			End If
			quesFile.Close()
			answerFile.Close()
			addQues("~ ~ ~ ~ ")
			addAnswer("-1")
			cbbQues.Items.Add(cbbQues.Items.Count + 1)
			quesIndex = 0
			numOfQues = quesList.Length - 1
			lblQues.Text = "Câu hỏi " & quesIndex
			enableCommit = False
			loadQues(0)
		Else
			If File.Exists(quesPath) And File.Exists(answerPath) Then
				Dim quesFile As New StreamReader(quesPath)
				Dim answerFile As New StreamReader(answerPath)
				Dim line As String

				' Đọc từng dòng trong file questions.txt
				While quesFile.Peek() > -1
					line = quesFile.ReadLine()
					addQues(line)
				End While
				quesFile.Close()

				' Đọc từng dòng trong file answers.txt
				While answerFile.Peek() > -1
					line = answerFile.ReadLine()
					addAnswer(line)
				End While
				answerFile.Close()

				If quesList.Length <> answerList.Length Then
					MsgBox("Lỗi đề thi: File câu hỏi và đáp án không trùng khớp!")
					Close()
				End If

				If quesList.Length = 0 Then
					addQues("~ ~ ~ ~ ")
					addAnswer("-1")
				End If

				numOfQues = quesList.Length - 1

				For i = 1 To quesList.Length
					cbbQues.Items.Add(i)
				Next

				enableCommit = False
				loadQues(numOfQues)
			Else
				MsgBox("Không tìm thấy đề thi trong thư mục này. Vui lòng tạo đề thi mới!")
				Close()
			End If

			enableCommit = True
			Me.Text = "M2ExamCreator - " & path
		End If
	End Sub

	Private Sub EditExamDialog_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		MainDialog.Show()
	End Sub

	Private Sub btnBrowImg_Click(sender As Object, e As EventArgs) Handles btnBrowImg.Click
		Dim fileDialog As New OpenFileDialog()

		' Thiết lập tiêu đề của hộp thoại
		fileDialog.Title = "Chọn hình ảnh"

		' Thiết lập thư mục mặc định khi mở hộp thoại
		fileDialog.InitialDirectory = "C:\"

		' Thiết lập bộ lọc cho các tệp tin
		fileDialog.Filter = "Tệp tin hình ảnh|*.jpg;*.jpeg;*.png|Tất cả các tệp tin|*.*"

		' Chỉ cho phép chọn nhiều tệp tin
		fileDialog.Multiselect = False

		' Mở hộp thoại và kiểm tra kết quả
		If fileDialog.ShowDialog() = DialogResult.OK Then
			' Xử lý các tệp tin đã chọn ở đây
			picPreview.Image = Image.FromFile(fileDialog.FileName)
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		saveData()
	End Sub

	Private Sub previousQues_Click(sender As Object, e As EventArgs) Handles previousQues.Click
		enableCommit = False
		If quesIndex <> 0 Then
			loadQues(quesIndex - 1)
		Else
			loadQues(numOfQues)
		End If
	End Sub

	Private Sub nextQues_Click(sender As Object, e As EventArgs) Handles nextQues.Click
		enableCommit = False
		If quesIndex <> numOfQues Then
			loadQues(quesIndex + 1)
		Else
			loadQues(0)
		End If
	End Sub

	Private Sub createQues_Click(sender As Object, e As EventArgs) Handles createQues.Click
		addQues("~ ~ ~ ~ ")
		addAnswer("-1")
		numOfQues = quesList.Length - 1
		If numOfQues > 0 And delQues.Enabled = False Then
			delQues.Enabled = True
		End If
		enableCommit = False
		cbbQues.Items.Add(cbbQues.Items.Count + 1)
		loadQues(numOfQues)
	End Sub

	Private Sub delQues_Click(sender As Object, e As EventArgs) Handles delQues.Click
		If numOfQues = 0 Then
			MsgBox("Không thể xoá tất cả câu hỏi trong đề")
			delQues.Enabled = False
			Return
		End If
		removeQues(quesIndex)
		removeAnswer(quesIndex)
		numOfQues = quesList.Length - 1
		enableCommit = False
		cbbQues.Items.RemoveAt(cbbQues.Items.Count - 1)
		If quesIndex = numOfQues + 1 Then
			loadQues(0)
		Else
			loadQues(quesIndex)
		End If
	End Sub

	Private Sub cbbQues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbQues.SelectedIndexChanged
		enableCommit = False
		loadQues(cbbQues.SelectedItem - 1)
	End Sub

	Private Sub txtQues_TextChanged(sender As Object, e As EventArgs) Handles txtQues.TextChanged
		If txtQues.Text = "" Then
			previousQues.Enabled = False
			nextQues.Enabled = False
			cbbQues.Enabled = False
			createQues.Enabled = False
			If txtQues.Text <> splitQues(0) And enableCommit Then
				splitQues(0) = txtQues.Text
				commitToQues(quesIndex, 0, multiToLine(splitQues(0)))
			End If
		Else
			previousQues.Enabled = True
			nextQues.Enabled = True
			cbbQues.Enabled = True
			createQues.Enabled = True
			If txtQues.Text <> splitQues(0) And enableCommit Then
				splitQues(0) = txtQues.Text
				commitToQues(quesIndex, 0, multiToLine(splitQues(0)))
			End If
		End If
	End Sub

	Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
		If txtA.Text = "" Then
			radioA.Checked = False
			radioA.Enabled = False
			If txtA.Text <> splitQues(1) And enableCommit Then
				splitQues(1) = txtA.Text
				commitToQues(quesIndex, 1, multiToLine(splitQues(1)))
			End If
		Else
			radioA.Enabled = True
			If txtA.Text <> splitQues(1) And enableCommit Then
				splitQues(1) = txtA.Text
				commitToQues(quesIndex, 1, multiToLine(splitQues(1)))
			End If
		End If
	End Sub

	Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
		If txtB.Text = "" Then
			radioB.Checked = False
			radioB.Enabled = False
			If txtB.Text <> splitQues(2) And enableCommit Then
				splitQues(2) = txtB.Text
				commitToQues(quesIndex, 2, multiToLine(splitQues(2)))
			End If
		Else
			radioB.Enabled = True
			If txtB.Text <> splitQues(2) And enableCommit Then
				splitQues(2) = txtB.Text
				commitToQues(quesIndex, 2, multiToLine(splitQues(2)))
			End If
		End If
	End Sub

	Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged
		If txtC.Text = "" Then
			radioC.Checked = False
			radioC.Enabled = False
			If txtC.Text <> splitQues(3) And enableCommit Then
				splitQues(3) = txtC.Text
				commitToQues(quesIndex, 3, multiToLine(splitQues(3)))
			End If
		Else
			radioC.Enabled = True
			If txtC.Text <> splitQues(3) And enableCommit Then
				splitQues(3) = txtC.Text
				commitToQues(quesIndex, 3, multiToLine(splitQues(3)))
			End If
		End If
	End Sub

	Private Sub txtD_TextChanged(sender As Object, e As EventArgs) Handles txtD.TextChanged
		If txtD.Text = "" Then
			radioD.Checked = False
			radioD.Enabled = False
			If txtD.Text <> splitQues(4) And enableCommit Then
				splitQues(4) = txtD.Text
				commitToQues(quesIndex, 4, multiToLine(splitQues(4)))
			End If
		Else
			radioD.Enabled = True
			If txtD.Text <> splitQues(4) And enableCommit Then
				splitQues(4) = txtD.Text
				commitToQues(quesIndex, 4, multiToLine(splitQues(4)))
			End If
		End If
	End Sub

	Private Sub radioA_CheckedChanged(sender As Object, e As EventArgs) Handles radioA.CheckedChanged
		If radioA.Checked Then
			If txtA.Text = "" And enableCommit Then
				MsgBox("Không thể chọn đáp án trống. Vui lòng nhập đáp án vào hộp đáp án rồi chọn lại!")
				radioA.Checked = False
			End If
			If enableCommit Then
				commitToAnswer(quesIndex, 1)
			End If
		End If
	End Sub

	Private Sub radioB_CheckedChanged(sender As Object, e As EventArgs) Handles radioB.CheckedChanged
		If radioB.Checked Then
			If txtB.Text = "" Then
				MsgBox("Không thể chọn đáp án trống. Vui lòng nhập đáp án vào hộp đáp án rồi chọn lại!")
				radioB.Checked = False
			End If
			If enableCommit Then
				commitToAnswer(quesIndex, 2)
			End If
		End If
	End Sub

	Private Sub radioC_CheckedChanged(sender As Object, e As EventArgs) Handles radioC.CheckedChanged
		If radioC.Checked Then
			If txtC.Text = "" Then
				MsgBox("Không thể chọn đáp án trống. Vui lòng nhập đáp án vào hộp đáp án rồi chọn lại!")
				radioC.Checked = False
			End If
			If enableCommit Then
				commitToAnswer(quesIndex, 3)
			End If
		End If
	End Sub

	Private Sub radioD_CheckedChanged(sender As Object, e As EventArgs) Handles radioD.CheckedChanged
		If radioD.Checked Then
			If txtD.Text = "" Then
				MsgBox("Không thể chọn đáp án trống. Vui lòng nhập đáp án vào hộp đáp án rồi chọn lại!")
				radioD.Checked = False
			End If
			If enableCommit Then
				commitToAnswer(quesIndex, 4)
			End If
		End If
	End Sub
End Class