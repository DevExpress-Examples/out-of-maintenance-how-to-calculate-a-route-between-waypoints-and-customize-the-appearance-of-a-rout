# How to calculate a route between waypoints and customize the appearance of a route path using a Microsoft Bing Route web service


<p>This example demonstrates how to calculate a route between several waypoints and change the appearance of a route path by means of the Microsoft Bing Route web service.</p>
<p> </p>
<p> </p>


<h3>Description</h3>

<p>&nbsp;To calculate a route between waypoints, call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic">BingRouteDataProvider.CalculateRoute</a> method and pass a list of waypoints as its argument.&nbsp;</p>
<p>To customize the route&nbsp;appearance, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_LayerItemsGeneratingtopic">InformationDataProviderBase.LayerItemsGenerating</a><u> </u>event and modify the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPointer_Texttopic">MapPointer.Text</a> property of each MapPushpin and customize the MapPolyline appearance.</p>
<p>Note that the polyline for the route and map pushpins for waypoints are generated automatically&nbsp;because the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_GenerateLayerItemstopic">InformationDataProviderBase.GenerateLayerItems</a><u> </u>property is set to <strong>true</strong> by default.</p>
<p>If you run this sample as is, you will get a warning message saying that the specified Bing Maps key is invalid. To learn more about Bing Map keys, please refer to the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument15102">How to: Get a Bing Maps Key</a>&nbsp;tutorial.</p>

<br/>


