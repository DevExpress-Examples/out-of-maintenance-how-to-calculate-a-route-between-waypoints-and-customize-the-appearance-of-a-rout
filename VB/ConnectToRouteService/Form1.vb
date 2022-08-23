Imports DevExpress.XtraMap
Imports System.Collections.Generic
Imports System.Drawing

Namespace ConnectToRouteService

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Const yourBingKey As String = "YOUR BING KEY"

        Private routeProvider As BingRouteDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            imageProvider.BingKey = yourBingKey
            routeProvider = New BingRouteDataProvider With {.BingKey = yourBingKey}
            informationLayer.DataProvider = routeProvider
#Region "#Waypoints"
            ' Create three waypoints and add them to a route waypoints list. 
            Dim waypoints As List(Of RouteWaypoint) = New List(Of RouteWaypoint) From {New RouteWaypoint("New York", New GeoPoint(41.145556, -73.995)), New RouteWaypoint("Oklahoma", New GeoPoint(36.131389, -95.937222)), New RouteWaypoint("Las Vegas", New GeoPoint(36.175, -115.136389))}
#End Region  ' #Waypoints
            ' Call the BingRouteDataProvider.CalculateRoute method.
            splashScreenManager.ShowWaitForm()
            routeProvider.CalculateRoute(waypoints)
            ' Handle the BingRouteDataProvider.LayerItemsGenerating event.
            AddHandler routeProvider.LayerItemsGenerating, AddressOf routeLayerItemsGenerating
        End Sub

        Private Sub routeLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            If e.Cancelled OrElse e.Error IsNot Nothing Then Return
            'char pushpinMarker = 'A';
            For Each item As MapItem In e.Items
                'MapPushpin pushpin = item as MapPushpin;
                'if(pushpin != null) {
                '    pushpin.Text = pushpinMarker++.ToString();
                '}
                Dim polyline As MapPolyline = TryCast(item, MapPolyline)
                If polyline IsNot Nothing Then
                    polyline.Stroke = Color.FromArgb(&HFF, &H00, &H72, &HC6)
                    polyline.StrokeWidth = 4
                End If
            Next

            splashScreenManager.CloseWaitForm()
            mapControl.ZoomToFit(e.Items, 0.4)
        End Sub
    End Class
End Namespace
