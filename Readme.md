<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576046/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5100)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ConnectToRouteService/Form1.cs) (VB: [Form1.vb](./VB/ConnectToRouteService/Form1.vb))
<!-- default file list end -->
# How to calculate a route between waypoints and customize the appearance of a route path using a Microsoft Bing Route web service


<p>This example demonstrates how to calculate a route between several waypoints and change the appearance of a route path by means of the Microsoft Bing Route web service.</p>
<p> </p>
<p> </p>


<h3>Description</h3>

<p>To calculate a route between waypoints, call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic">BingRouteDataProvider.CalculateRoute</a> method and pass a list of waypoints as its argument.&nbsp;</p>
<p>To customize the route&nbsp;appearance, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_LayerItemsGeneratingtopic">InformationDataProviderBase.LayerItemsGenerating</a><u> </u>event and modify the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPointer_Texttopic">MapPointer.Text</a> property of each MapPushpin and customize the MapPolyline appearance.</p>
<p>Note that the polyline for the route and map pushpins for waypoints are generated automatically&nbsp;because the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationDataProviderBase_GenerateLayerItemstopic">InformationDataProviderBase.GenerateLayerItems</a><u> </u>property is set to <strong>true</strong> by default.</p>
<p>If you run this sample as is, you will get a warning message saying that the specified Bing Maps key is invalid. To learn more about Bing Map keys, please refer to the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument15102">How to: Get a Bing Maps Key</a>&nbsp;tutorial.</p>

<br/>


