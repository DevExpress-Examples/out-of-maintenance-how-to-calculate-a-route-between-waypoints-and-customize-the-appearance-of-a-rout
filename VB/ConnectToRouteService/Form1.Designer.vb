Namespace ConnectToRouteService
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
            Me.splashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ConnectToRouteService.WaitForm1), True, True)
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.imageProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splashScreenManager
            ' 
            Me.splashScreenManager.ClosingDelay = 500
            ' 
            ' imageLayer1
            ' 
            Me.imageLayer1.DataProvider = Me.imageProvider
            ' 
            ' informationLayer
            ' 
            Me.informationLayer.EnableHighlighting = False
            Me.informationLayer.EnableSelection = False
            Me.informationLayer.Name = "RouteLayer"
            ' 
            ' mapControl
            ' 
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Layers.Add(Me.imageLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(640, 360)
            Me.mapControl.TabIndex = 0
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 360)
            Me.Controls.Add(Me.mapControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
        Private imageProvider As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer As DevExpress.XtraMap.InformationLayer
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private splashScreenManager As DevExpress.XtraSplashScreen.SplashScreenManager
    End Class
End Namespace

