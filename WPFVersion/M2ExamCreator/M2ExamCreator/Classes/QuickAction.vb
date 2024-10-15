Imports System.Windows.Forms

Public Class QuickAction
	Public Shared Function GetDir() As String
		Using dialog As FolderBrowserDialog
			Dim result As DialogResult = dialog.ShowDialog()

			If result = DialogResult.OK Then
				Return dialog.SelectedPath
			Else
				Return "CANCEL_SELECT_DIR"
			End If
		End Using
	End Function

	Public Shared Function GetFile() As String

	End Function

	Private Shared Sub SaveStreamToFile(dir As String, data As Byte())

	End Sub

	Public Shared Function CreateExam(dir As String, name As String, fileName As String, author As String, minute As Int64) As Boolean

	End Function

	' Read Exam here

	' Write Exam here
End Class
