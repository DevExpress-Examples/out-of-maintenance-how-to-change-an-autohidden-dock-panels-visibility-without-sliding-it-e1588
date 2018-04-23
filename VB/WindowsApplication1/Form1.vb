Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			dockManager1.BeginInit()
			Try
				If dockPanel1.Visibility = DockVisibility.Hidden Then
					dockPanel1.Visibility = DockVisibility.AutoHide
				Else
					dockPanel1.Visibility = DockVisibility.Hidden
				End If
			Finally
				dockManager1.EndInit()
			End Try
		End Sub
	End Class
End Namespace