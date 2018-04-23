Imports DevExpress.XtraMap
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace ConnectToRouteService
    Partial Public Class Form1
        Inherits Form

        Private Const bingKey As String = "YOUR BING KEY"
        Private ReadOnly Property RouteLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("RouteLayer"), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property RouteProvider() As BingRouteDataProvider
            Get
                Return CType(RouteLayer.DataProvider, BingRouteDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            RouteLayer.DataProvider = New BingRouteDataProvider() With {.BingKey = bingKey}
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
'            #Region "#Waypoints"
            ' Create three waypoints and add them to a route waypoints list. 
            Dim waypoints As New List(Of RouteWaypoint)()
            waypoints.Add(New RouteWaypoint("New York", New GeoPoint(41.145556, -73.995)))
            waypoints.Add(New RouteWaypoint("Oklahoma", New GeoPoint(36.131389, -95.937222)))
            waypoints.Add(New RouteWaypoint("Las Vegas", New GeoPoint(36.175, -115.136389)))
'            #End Region ' #Waypoints

            ' Call the BingRouteDataProvider.CalculateRoute method.
            RouteProvider.CalculateRoute(waypoints)

            ' Handle the BingRouteDataProvider.LayerItemsGenerating event.
            AddHandler RouteProvider.LayerItemsGenerating, AddressOf routeLayerItemsGenerating
            AddHandler RouteLayer.DataRequestCompleted, AddressOf RouteLayer_DataRequestCompleted
        End Sub

        Private Sub RouteLayer_DataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl1.ZoomToFitLayerItems()
        End Sub

        Private Sub routeLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            If e.Cancelled OrElse (e.Error IsNot Nothing) Then
                Return
            End If

            Dim pushpinMarker As Char = "A"c
            For Each item As MapItem In e.Items
                Dim pushpin As MapPushpin = TryCast(item, MapPushpin)
                If pushpin IsNot Nothing Then
                    pushpin.Text = pushpinMarker.ToString()
                    pushpinMarker = ChrW(AscW(pushpinMarker) + 1)
                End If
                Dim polyline As MapPolyline = TryCast(item, MapPolyline)
                If polyline IsNot Nothing Then
                    polyline.Stroke = Color.FromArgb(&HFF, &HFE, &H72, &HFF)
                    polyline.StrokeWidth = 4
                End If
            Next item
        End Sub
    End Class
End Namespace