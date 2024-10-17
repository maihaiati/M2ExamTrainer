Public Class Startup
	Private Sub btnCreate_Click(sender As Object, e As RoutedEventArgs)
		Dim mainWindow As MainWindow = CType(Application.Current.MainWindow, MainWindow)
		Dim createExam As New CreateExam

		mainWindow.MainGrid.Children.Clear()
		mainWindow.MainGrid.Children.Add(createExam)
	End Sub

	Private Sub btnBrowse_Click(sender As Object, e As RoutedEventArgs) Handles btnBrowse.Click
		Dim examFile = QuickAction.GetFile()

		If Not String.IsNullOrWhiteSpace(examFile) And examFile <> "CANCEL_SELECT_FILE" Then
			Dim mainWindow As MainWindow = CType(Application.Current.MainWindow, MainWindow)
			Dim editExam As EditExam = New EditExam(examFile)

			mainWindow.MainGrid.Children.Clear()
			mainWindow.MainGrid.Children.Add(editExam)
		End If
	End Sub
End Class
