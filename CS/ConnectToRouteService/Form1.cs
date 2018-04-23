
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ConnectToRouteService {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        const string yourBingKey = "INSERT_YOUR_BING_KEY_HERE";
        MapPolyline polyline = new MapPolyline();
        List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
        BingRouteDataProvider routeProvider;
        int waypointIndex = 0;

        private void Form1_Load(object sender, System.EventArgs e) {
            // Call the PrepareMap method.  
            PrepareMap();

            // Create three waypoints and add them to a route waypoints list. 
            GeoPoint NY = new GeoPoint(41.145556, -73.995);
            RouteWaypoint waypoint1 = new RouteWaypoint("NY", NY);
            waypoints.Add(waypoint1);
            GeoPoint Oklahoma = new GeoPoint(36.131389, -95.937222);
            RouteWaypoint waypoint2 = new RouteWaypoint("Oklahoma", Oklahoma);
            waypoints.Add(waypoint2);
            GeoPoint LasVegas = new GeoPoint(36.175, -115.136389);
            RouteWaypoint waypoint3 = new RouteWaypoint("Las Vegas", LasVegas);
            waypoints.Add(waypoint3);

            // Call the BingRouteDataProvider.CalculateRoute method.
            routeProvider.CalculateRoute(waypoints);

            // Handle the BingRouteDataProvider.RouteCalculated event.
            routeProvider.RouteCalculated += new BingRouteCalculatedEventHandler(routeProvider_RouteCalculated);

            // Handle the BingRouteDataProvider.LayerItemsGenerating event.
            routeProvider.LayerItemsGenerating += new LayerItemsGeneratingEventHandler(routeLayerItemsGenerating);
        }


        private void routeProvider_RouteCalculated(object sender, BingRouteCalculatedEventArgs e) {

            RouteCalculationResult result = e.CalculationResult;

            if (result.ResultCode == RequestResultCode.Success) {
                polyline.Points.AddRange(result.RouteResults[0].RoutePath);

                // Customize the appearance of the calculated route path. 
                polyline.Stroke = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
                polyline.StrokeWidth = 4;
            }
        }

        private void routeLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {

            if (e.Error == null && !e.Cancelled)
                ProcessRouteItems(e.Items);
        }

        public void ProcessRouteItems(MapItem[] items) {

            foreach (MapItem item in items) {
                MapPushpin pushpin = item as MapPushpin;

                if (pushpin != null) {
                    pushpin.Text = NextWaypointLetter();
                }
            }
        }

        protected string NextWaypointLetter() {
            waypointIndex++;
            return waypointIndex.ToString(); ;
        }

        private void PrepareMap() {
            // Create a map control.
            MapControl map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a vector items layer and add it to the map.
            VectorItemsLayer itemsLayer = new VectorItemsLayer();
            MapItemStorage storage = new MapItemStorage();
            itemsLayer.Data = storage;
            map.Layers.Add(itemsLayer);

            storage.Items.Add(polyline);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a Bing route data provider and specify the Bing key.
            routeProvider = new BingRouteDataProvider();
            infoLayer.DataProvider = routeProvider;
            routeProvider.BingKey = yourBingKey;

            // Specify the map center point and zoom level. 
            map.CenterPoint = new GeoPoint(37, -92);
            map.ZoomLevel = 4;
        }
    }
}