// Developer Express Code Central Example:
// How to calculate a route between waypoints and customize the appearance of a route path using a Microsoft Bing Route web service
// 
// This example demonstrates how to calculate a route between several waypoints and
// change the appearance of a route path by means of the Microsoft Bing Route web
// service.
// 
// To calculate a route between waypoints, call the
// BingRouteDataProvider.CalculateRoute
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic)
// method and pass a list of waypoints as its argument.
// 
// To customize the route
// path appearance, do the following:
// 
// - Handle the
// BingRouteDataProvider.RouteCalculated event;
// - Access the route path using the
// RouteCalculationResult
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteCalculationResulttopic)
// object inside the BingRouteDataProvider.RouteCalculated event handler's
// BingRouteCalculatedEventArgs
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingRouteCalculatedEventArgstopic);
// -
// Create a MapPolyline
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapPolylinetopic)
// with calculated route points. To access the route points collection, use the
// BingRouteResult.RoutePath
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_RoutePathtopic)
// property;
// - Customize the stroke and stroke width of the map polyline using the
// MapItem.Stroke
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_Stroketopic)
// and MapItem.StrokeWidth
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_StrokeWidthtopic)
// properties. The map pushpins are generated automatically at each route waypoint
// position because the InformationDataProviderBase.GenerateLayerItems
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_GenerateLayerItemstopic)
// property is set to true by default. Note that the pushpins' text contains an
// empty string. To number route waypoints (from start to finish) in the pushpin,
// handle the InformationDataProviderBase.LayerItemsGenerating
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_LayerItemsGeneratingtopic)
// event and modify the MapPointer.Text
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPointer_Texttopic)
// property. Note that if you run this sample as is, you will get a warning message
// saying that the specified Bing Maps key is invalid. To learn more about Bing Map
// keys, please refer to the How to: Get a Bing Maps Key
// (http://help.devexpress.com/#WindowsForms/CustomDocument15102) tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5100

// Developer Express Code Central Example:
// How to calculate a route between waypoints and customize the appearance of a route path using a Bing Route web service
// 
// This example demonstrates how to calculate a route between several route
// waypoints and change the appearance of a route path by means of the Bing Route
// web service.
// 
// To calculate a route between waypoints, call the
// BingRouteDataProvider.CalculateRoute
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic)
// method and pass the list of waypoints as its argument.
// 
// To customize the route
// path appearance, do the following:
// 
// - Handle the
// BingRouteDataProvider.RouteCalculated event;
// - Access the route path using the
// RouteCalculationResult
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteCalculationResulttopic)
// object inside BingRouteCalculatedEventArgs
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingRouteCalculatedEventArgstopic)
// of the BingRouteDataProvider.RouteCalculated event handler;
// - Create a
// MapPolyline
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapPolylinetopic)
// with calculated route points. To access the route points collection, use the
// BingRouteResult.RoutePath
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_RoutePathtopic)
// property;
// - Customize the stroke and stroke width of the map polyline using the
// MapItem.Stroke
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_Stroketopic)
// and MapItem.StrokeWidth
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_StrokeWidthtopic)
// properties. Note that if you run this sample as is, you will get a warning
// message saying that the specified Bing Maps key is invalid. To learn more about
// Bing Map keys, please refer to the How to: Get a Bing Maps Key
// (http://help.devexpress.com/#WindowsForms/CustomDocument15102) tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5100

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectToRouteService.Properties {


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}
