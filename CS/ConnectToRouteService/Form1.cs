using DevExpress.XtraMap;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConnectToRouteService {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        const string yourBingKey = "YOUR BING KEY";
        BingRouteDataProvider routeProvider;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            imageProvider.BingKey = yourBingKey;

            routeProvider = new BingRouteDataProvider { BingKey = yourBingKey };
            informationLayer.DataProvider = routeProvider;
            #region #Waypoints
            // Create three waypoints and add them to a route waypoints list. 
            List<RouteWaypoint> waypoints = new List<RouteWaypoint> {
                new RouteWaypoint("New York", new GeoPoint(41.145556, -73.995)),
                new RouteWaypoint("Oklahoma", new GeoPoint(36.131389, -95.937222)),
                new RouteWaypoint("Las Vegas", new GeoPoint(36.175, -115.136389))
            };
            #endregion #Waypoints
            // Call the BingRouteDataProvider.CalculateRoute method.
            splashScreenManager.ShowWaitForm();
            routeProvider.CalculateRoute(waypoints);

            // Handle the BingRouteDataProvider.LayerItemsGenerating event.
            routeProvider.LayerItemsGenerating += routeLayerItemsGenerating;
        }

        private void routeLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            if(e.Cancelled || (e.Error != null)) return;
            
            //char pushpinMarker = 'A';
            foreach(MapItem item in e.Items) {
                //MapPushpin pushpin = item as MapPushpin;
                //if(pushpin != null) {
                //    pushpin.Text = pushpinMarker++.ToString();
                //}
                MapPolyline polyline = item as MapPolyline;
                if(polyline != null) {
                    polyline.Stroke = Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
            splashScreenManager.CloseWaitForm();
            mapControl.ZoomToFit(e.Items, 0.4);
        }
    }
}