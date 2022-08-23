' Developer Express Code Central Example:
' How to calculate a route between waypoints and customize the appearance of a route path using a Microsoft Bing Route web service
' 
' This example demonstrates how to calculate a route between several waypoints and
' change the appearance of a route path by means of the Microsoft Bing Route web
' service.
' 
' To calculate a route between waypoints, call the
' BingRouteDataProvider.CalculateRoute
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic)
' method and pass a list of waypoints as its argument.
' 
' To customize the route
' path appearance, do the following:
' 
' - Handle the
' BingRouteDataProvider.RouteCalculated event;
' - Access the route path using the
' RouteCalculationResult
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteCalculationResulttopic)
' object inside the BingRouteDataProvider.RouteCalculated event handler's
' BingRouteCalculatedEventArgs
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingRouteCalculatedEventArgstopic);
' -
' Create a MapPolyline
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapPolylinetopic)
' with calculated route points. To access the route points collection, use the
' BingRouteResult.RoutePath
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_RoutePathtopic)
' property;
' - Customize the stroke and stroke width of the map polyline using the
' MapItem.Stroke
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_Stroketopic)
' and MapItem.StrokeWidth
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_StrokeWidthtopic)
' properties. The map pushpins are generated automatically at each route waypoint
' position because the InformationDataProviderBase.GenerateLayerItems
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_GenerateLayerItemstopic)
' property is set to true by default. Note that the pushpins' text contains an
' empty string. To number route waypoints (from start to finish) in the pushpin,
' handle the InformationDataProviderBase.LayerItemsGenerating
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_LayerItemsGeneratingtopic)
' event and modify the MapPointer.Text
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPointer_Texttopic)
' property. Note that if you run this sample as is, you will get a warning message
' saying that the specified Bing Maps key is invalid. To learn more about Bing Map
' keys, please refer to the How to: Get a Bing Maps Key
' (http://help.devexpress.com/#WindowsForms/CustomDocument15102) tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5100
' Developer Express Code Central Example:
' How to calculate a route between waypoints and customize the appearance of a route path using a Bing Route web service
' 
' This example demonstrates how to calculate a route between several route
' waypoints and change the appearance of a route path by means of the Bing Route
' web service.
' 
' To calculate a route between waypoints, call the
' BingRouteDataProvider.CalculateRoute
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic)
' method and pass the list of waypoints as its argument.
' 
' To customize the route
' path appearance, do the following:
' 
' - Handle the
' BingRouteDataProvider.RouteCalculated event;
' - Access the route path using the
' RouteCalculationResult
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteCalculationResulttopic)
' object inside BingRouteCalculatedEventArgs
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingRouteCalculatedEventArgstopic)
' of the BingRouteDataProvider.RouteCalculated event handler;
' - Create a
' MapPolyline
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapPolylinetopic)
' with calculated route points. To access the route points collection, use the
' BingRouteResult.RoutePath
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_RoutePathtopic)
' property;
' - Customize the stroke and stroke width of the map polyline using the
' MapItem.Stroke
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_Stroketopic)
' and MapItem.StrokeWidth
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_StrokeWidthtopic)
' properties. Note that if you run this sample as is, you will get a warning
' message saying that the specified Bing Maps key is invalid. To learn more about
' Bing Map keys, please refer to the How to: Get a Bing Maps Key
' (http://help.devexpress.com/#WindowsForms/CustomDocument15102) tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5100
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly:AssemblyTitle("ConnectToRouteService")>
<Assembly:AssemblyDescription("")>
<Assembly:AssemblyConfiguration("")>
<Assembly:AssemblyCompany("")>
<Assembly:AssemblyProduct("ConnectToRouteService")>
<Assembly:AssemblyCopyright("Copyright ©  2014")>
<Assembly:AssemblyTrademark("")>
<Assembly:AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly:ComVisible(False)>
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly:Guid("0ee01052-2f3b-4c4f-a9f6-27a48ec8fac9")>
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly:AssemblyVersion("1.0.0.0")>
<Assembly:AssemblyFileVersion("1.0.0.0")>
