Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace Example
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim t As Integer=101
			t += 1
		Dim btn As System.Windows.Controls.Button = New Button()
			AddHandler btn.Click, Sub(sn, args)
				Dim t2 As Integer = 1234
				t2 += 1
			End Sub
		End Sub
	End Class

	Public Interface ITest
		Sub SomeMethod()
	End Interface

	Public Class TestClass
		Implements ITest

		Public Sub SomeMethod() Implements ITest.SomeMethod

		End Sub
	End Class
End Namespace
