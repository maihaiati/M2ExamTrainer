Class MainWindow
	Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
		Dim startup As New Startup

		MainGrid.Children.Clear()
		MainGrid.Children.Add(startup)
	End Sub
End Class
