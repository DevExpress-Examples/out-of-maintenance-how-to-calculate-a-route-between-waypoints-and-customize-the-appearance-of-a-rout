using DevExpress.XtraMap;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConnectToRouteService {
    public partial class Form1 : Form {
        const string bingKey = "YOUR BING KEY";
        InformationLayer RouteLayer { get { return (InformationLayer)mapControl1.Layers["RouteLayer"]; } }
        BingRouteDataProvider RouteProvider { get { return (BingRouteDataProvider)RouteLayer.DataProvider; } }

        public Form1() {
            InitializeComponent();
            RouteLayer.DataProvider = new BingRouteDataProvider() { BingKey = bingKey };
        }
        
        private void Form1_Load(object sender, System.EventArgs e) {
            #region #Waypoints
            // Create three waypoints and add them to a route waypoints list. 
            List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
            waypoints.Add(new RouteWaypoint("New York", new GeoPoint(41.145556, -73.995)));
            waypoints.Add(new RouteWaypoint("Oklahoma", new GeoPoint(36.131389, -95.937222)));
            waypoints.Add(new RouteWaypoint("Las Vegas", new GeoPoint(36.175, -115.136389)));
            #endregion #Waypoints

            // Call the BingRouteDataProvider.CalculateRoute method.
            RouteProvider.CalculateRoute(waypoints);

            // Handle the BingRouteDataProvider.LayerItemsGenerating event.
            RouteProvider.LayerItemsGenerating += routeLayerItemsGenerating;
            RouteLayer.DataRequestCompleted += RouteLayer_DataRequestCompleted;
        }

        void RouteLayer_DataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl1.ZoomToFitLayerItems();
        }

        private void routeLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            if (e.Cancelled || (e.Error != null)) return;
            
            char pushpinMarker = 'A';
            foreach (MapItem item in e.Items) {
                MapPushpin pushpin = item as MapPushpin;
                if (pushpin != null) {
                    pushpin.Text = pushpinMarker++.ToString();
                }
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null) {
                    polyline.Stroke = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
                    polyline.StrokeWidth = 4;
                }
            }
        }
    }
}