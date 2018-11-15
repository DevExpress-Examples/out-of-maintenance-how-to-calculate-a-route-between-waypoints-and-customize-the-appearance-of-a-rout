<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ConnectToRouteService/Form1.cs) (VB: [Form1.vb](./VB/ConnectToRouteService/Form1.vb))
<!-- default file list end -->
# How to calculate a route between waypoints and customize the appearance of a route path using a Microsoft Bing Route web service


<p>This example demonstrates how to calculate a route between several waypoints and change the appearance of a route path by means of the Microsoft Bing Route web service.</p>
<p> </p>
<p> </p>


<h3>Description</h3>

To calculate a route between waypoints, call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic"><u>BingRouteDataProvider.CalculateRoute</u></a> method and pass a list of waypoints as its argument.
<p>&nbsp;</p>
<p>To customize the route path appearance, do the following:</p>
<p>- Handle the&nbsp; <a href="https://isc.devexpress.com/Thread/WorkplaceDetails/BingRouteDataProvider.RouteCalculated"><u>BingRouteDataProvider.RouteCalculated</u></a> event;<br /> - Access the route path using the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteCalculationResulttopic"><u>RouteCalculationResult</u></a> object inside t<a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingRouteCalculatedEventArgstopic">he&nbsp; <strong>BingRouteDataProvider.RouteCalculated</strong> event handler's <u>BingRouteCalculatedEventArgs</u></a>;<br /> - Create a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapPolylinetopic"><u>MapPolyline</u></a><u> </u>with calculated route points. To access the route points collection, use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_RoutePathtopic"><u>BingRouteResult.RoutePath</u></a> property;<br /> - Customize the stroke and stroke width of the map polyline using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_Stroketopic"><u>MapItem.Stroke</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItem_StrokeWidthtopic"><u>MapItem.StrokeWidth</u></a> properties.</p>
<p>The map pushpins are generated automatically at each route waypoint position&nbsp; because the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_GenerateLayerItemstopic"><u>InformationDataProviderBase.GenerateLayerItems</u></a><u> </u>property is set to <strong>true</strong> by default.&nbsp; Note that&nbsp; the pushpins' text contains an empty string. <br /> To number route waypoints (from start to finish) in the pushpin, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_LayerItemsGeneratingtopic"><u>InformationDataProviderBase.LayerItemsGenerating</u></a><u> </u>event and modify the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPointer_Texttopic"><u>MapPointer.Text</u></a> property.</p>
<p>Note that if you run this sample as is, you will get a warning message saying that the specified Bing Maps key is invalid. To learn more about Bing Map keys, please refer to the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument15102"><u>How to: Get a Bing Maps Key</u></a><u> </u>tutorial.</p>

<br/>


