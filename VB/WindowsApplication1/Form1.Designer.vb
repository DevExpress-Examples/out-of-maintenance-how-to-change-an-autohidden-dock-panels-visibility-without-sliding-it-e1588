Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.hideContainerRight.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() { Me.hideContainerRight})
			Me.dockManager1.Form = Me
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel1.ID = New System.Guid("11989061-fcd8-4352-8660-250d596e7f8b")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel1.SavedIndex = 0
			Me.dockPanel1.Size = New System.Drawing.Size(200, 512)
			Me.dockPanel1.Text = "dockPanel1"
			Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 484)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(118, 266)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' hideContainerRight
			' 
			Me.hideContainerRight.Controls.Add(Me.dockPanel1)
			Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.hideContainerRight.Location = New System.Drawing.Point(663, 0)
			Me.hideContainerRight.Name = "hideContainerRight"
			Me.hideContainerRight.Size = New System.Drawing.Size(19, 512)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(682, 512)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.hideContainerRight)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.hideContainerRight.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
	End Class
End Namespace

