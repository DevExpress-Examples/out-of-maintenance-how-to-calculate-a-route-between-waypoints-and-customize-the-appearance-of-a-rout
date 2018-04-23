Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectToRouteService
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"
        Private polyline As New MapPolyline()
        Private waypoints As New List(Of RouteWaypoint)()
        Private routeProvider As BingRouteDataProvider
        Private waypointIndex As Integer = 0

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Call the PrepareMap method.  
            PrepareMap()

            ' Create three waypoints and add them to a route waypoints list. 
            Dim NY As New GeoPoint(41.145556, -73.995)
            Dim waypoint1 As New RouteWaypoint("NY", NY)
            waypoints.Add(waypoint1)
            Dim Oklahoma As New GeoPoint(36.131389, -95.937222)
            Dim waypoint2 As New RouteWaypoint("Oklahoma", Oklahoma)
            waypoints.Add(waypoint2)
            Dim LasVegas As New GeoPoint(36.175, -115.136389)
            Dim waypoint3 As New RouteWaypoint("Las Vegas", LasVegas)
            waypoints.Add(waypoint3)

            ' Call the BingRouteDataProvider.CalculateRoute method.
            routeProvider.CalculateRoute(waypoints)

            ' Handle the BingRouteDataProvider.RouteCalculated event.
            AddHandler routeProvider.RouteCalculated, AddressOf routeProvider_RouteCalculated

            ' Handle the BingRouteDataProvider.LayerItemsGenerating event.
            AddHandler routeProvider.LayerItemsGenerating, AddressOf routeLayerItemsGenerating
        End Sub


        Private Sub routeProvider_RouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)

            Dim result As RouteCalculationResult = e.CalculationResult

            If result.ResultCode = RequestResultCode.Success Then
                polyline.Points.AddRange(result.RouteResults(0).RoutePath)

                ' Customize the appearance of the calculated route path. 
                polyline.Stroke = Color.FromArgb(&HFF, &HFE, &H72, &HFF)
                polyline.StrokeWidth = 4
            End If
        End Sub

        Private Sub routeLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)

            If e.Error Is Nothing AndAlso (Not e.Cancelled) Then
                ProcessRouteItems(e.Items)
            End If
        End Sub

        Public Sub ProcessRouteItems(ByVal items() As MapItem)

            For Each item As MapItem In items
                Dim pushpin As MapPushpin = TryCast(item, MapPushpin)

                If pushpin IsNot Nothing Then
                    pushpin.Text = NextWaypointLetter()
                End If
            Next item
        End Sub

        Protected Function NextWaypointLetter() As String
            waypointIndex += 1
            Return waypointIndex.ToString()

        End Function

        Private Sub PrepareMap()
            ' Create a map control.
            Dim map As New MapControl()

            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill

            ' Add the map control to the window.
            Me.Controls.Add(map)

            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As New ImageTilesLayer()
            map.Layers.Add(tilesLayer)

            ' Create an information layer and add it to the map.
            Dim infoLayer As New InformationLayer()
            map.Layers.Add(infoLayer)

            ' Create a vector items layer and add it to the map.
            Dim itemsLayer As New VectorItemsLayer()
            Dim storage As New MapItemStorage()
            itemsLayer.Data = storage
            map.Layers.Add(itemsLayer)

            storage.Items.Add(polyline)

            ' Create a Bing data provider and specify the Bing key.
            Dim bingProvider As New BingMapDataProvider()
            tilesLayer.DataProvider = bingProvider
            bingProvider.BingKey = yourBingKey

            ' Create a Bing route data provider and specify the Bing key.
            routeProvider = New BingRouteDataProvider()
            infoLayer.DataProvider = routeProvider
            routeProvider.BingKey = yourBingKey

            ' Specify the map center point and zoom level. 
            map.CenterPoint = New GeoPoint(37, -92)
            map.ZoomLevel = 4
        End Sub
    End Class
End Namespace