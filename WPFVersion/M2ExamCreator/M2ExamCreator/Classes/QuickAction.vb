Imports System.IO
Imports System.Windows.Forms

Public Class QuickAction
	Public Shared Function GetDir() As String
		Using dialog As New FolderBrowserDialog
			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Return dialog.SelectedPath
			Else
				Return "CANCEL_SELECT_DIR"
			End If
		End Using
	End Function

	Public Shared Function GetFile() As String
		Using dialog As New OpenFileDialog
			dialog.Filter = "Exam Files (*.exam)|*.exam;"

			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK And Not String.IsNullOrWhiteSpace(dialog.FileName) Then
				Dim fileName = dialog.FileName
				Return fileName
			ElseIf result = DialogResult.Cancel Then
				Return "CANCEL_SELECT_FILE"
			End If
			Return String.Empty
		End Using
	End Function

	Private Shared Sub SaveStreamToFile(dir As String, data As Byte())
		Try
			Using fileStream As New FileStream(dir, FileMode.Create, FileAccess.Write)
				fileStream.Write(data, 0, data.Length)
			End Using
		Catch ex As Exception
			MessageBox.Show("Đã xảy ra lỗi không xác định!\nMã lỗi: " + ex.ToString, "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Public Shared Function CreateExam(dir As String, name As String, fileName As String, author As String, minute As Int64) As Boolean

	End Function

	' Read Exam here

	' Write Exam here
End Class
