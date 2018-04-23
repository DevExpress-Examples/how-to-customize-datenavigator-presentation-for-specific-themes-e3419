Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Controls
Imports System.Globalization

Namespace SchedulerDateNavigatorCustomizationWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class ThemeNameConverterExtension
		Inherits MarkupExtension
		Implements IValueConverter
		Private Shared instance As New ThemeNameConverterExtension()
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return instance
		End Function

		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return value
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Dim listBoxItem As ListBoxItem = TryCast(value, ListBoxItem)

			If listBoxItem IsNot Nothing Then
				Return listBoxItem.Content
			End If

			Return value
		End Function
		#End Region
	End Class
End Namespace