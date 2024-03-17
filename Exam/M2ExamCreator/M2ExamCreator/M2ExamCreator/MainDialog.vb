Imports System
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class MainDialog
	Private Sub btnCreateExam_Click(sender As Object, e As EventArgs) Handles btnCreateExam.Click
		Dim folderDialog As New FolderBrowserDialog
		If (folderDialog.ShowDialog() = DialogResult.OK) Then
			EditExamDialog.examPath = folderDialog.SelectedPath
			EditExamDialog.quesPath = Path.Combine(folderDialog.SelectedPath, "questions.txt")
			EditExamDialog.answerPath = Path.Combine(folderDialog.SelectedPath, "answers.txt")
			EditExamDialog.assetsPath = Path.Combine(folderDialog.SelectedPath, "assets")
			EditExamDialog.createExam = True
			EditExamDialog.Show()
			Hide()
		End If
	End Sub

	Private Sub btnOpenExam_Click(sender As Object, e As EventArgs) Handles btnOpenExam.Click
		Dim folderDialog As New FolderBrowserDialog
		If (folderDialog.ShowDialog() = DialogResult.OK) Then
			EditExamDialog.examPath = folderDialog.SelectedPath
			EditExamDialog.quesPath = Path.Combine(folderDialog.SelectedPath, "questions.txt")
			EditExamDialog.answerPath = Path.Combine(folderDialog.SelectedPath, "answers.txt")
			EditExamDialog.assetsPath = Path.Combine(folderDialog.SelectedPath, "assets")
			EditExamDialog.createExam = False
			EditExamDialog.Show()
			Hide()
		End If
	End Sub
End Class