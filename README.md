# OneSignalApi - the C# library for the OneSignal

A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com

- API version: 1.0.1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://onesignal.com](https://onesignal.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            // Configure configuration with user_key Bearer token for authorization to access endpoints
            // that require the OneSignal User Auth Key.
            var userConfig = new Configuration();
            userConfig.BasePath = "https://onesignal.com/api/v1";
            userConfig.AccessToken = "USER_AUTH_KEY";
            
            var userInstance = new DefaultApi(userConfig);

            try
            {
                // Create a new app
                var app = new App(name: "Sample App");
                var result = userInstance.CreateApp(app);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateApp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }


            // Configure configuration with app_key Bearer token for authorization to access endpoints
            // that require the OneSignal App REST API Key.
            var appConfig = new Configuration();
            appConfig.BasePath = "https://onesignal.com/api/v1";
            appConfig.AccessToken = "REST_API_KEY";
            
            var appInstance = new DefaultApi(appConfig);

            var appId = "appId_example";  // string | 
            var notificationId = "notificationId_example";  // string | 
            try
            {
                // Stop a scheduled or currently outgoing notification
                var result = appInstance.CancelNotification(appId, notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://onesignal.com/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**CancelNotification**](docs/DefaultApi.md#cancelnotification) | **DELETE** /notifications/{notification_id} | Stop a scheduled or currently outgoing notification
*DefaultApi* | [**CreateApp**](docs/DefaultApi.md#createapp) | **POST** /apps | Create an app
*DefaultApi* | [**CreateNotification**](docs/DefaultApi.md#createnotification) | **POST** /notifications | Create notification
*DefaultApi* | [**CreatePlayer**](docs/DefaultApi.md#createplayer) | **POST** /players | Add a device
*DefaultApi* | [**CreateSegments**](docs/DefaultApi.md#createsegments) | **POST** /apps/{app_id}/segments | Create Segments
*DefaultApi* | [**DeletePlayer**](docs/DefaultApi.md#deleteplayer) | **DELETE** /players/{player_id} | Delete a user record
*DefaultApi* | [**DeleteSegments**](docs/DefaultApi.md#deletesegments) | **DELETE** /apps/{app_id}/segments/{segment_id} | Delete Segments
*DefaultApi* | [**ExportPlayers**](docs/DefaultApi.md#exportplayers) | **POST** /players/csv_export?app_id&#x3D;{app_id} | CSV export
*DefaultApi* | [**GetApp**](docs/DefaultApi.md#getapp) | **GET** /apps/{app_id} | View an app
*DefaultApi* | [**GetApps**](docs/DefaultApi.md#getapps) | **GET** /apps | View apps
*DefaultApi* | [**GetNotification**](docs/DefaultApi.md#getnotification) | **GET** /notifications/{notification_id} | View notification
*DefaultApi* | [**GetNotificationHistory**](docs/DefaultApi.md#getnotificationhistory) | **POST** /notifications/{notification_id}/history | Notification History
*DefaultApi* | [**GetNotifications**](docs/DefaultApi.md#getnotifications) | **GET** /notifications | View notifications
*DefaultApi* | [**GetOutcomes**](docs/DefaultApi.md#getoutcomes) | **GET** /apps/{app_id}/outcomes | View Outcomes
*DefaultApi* | [**GetPlayer**](docs/DefaultApi.md#getplayer) | **GET** /players/{player_id} | View device
*DefaultApi* | [**GetPlayers**](docs/DefaultApi.md#getplayers) | **GET** /players | View devices
*DefaultApi* | [**UpdateApp**](docs/DefaultApi.md#updateapp) | **PUT** /apps/{app_id} | Update an app
*DefaultApi* | [**UpdatePlayer**](docs/DefaultApi.md#updateplayer) | **PUT** /players/{player_id} | Edit device
*DefaultApi* | [**UpdatePlayerTags**](docs/DefaultApi.md#updateplayertags) | **PUT** /apps/{app_id}/users/{external_user_id} | Edit tags with external user id


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.App](docs/App.md)
 - [Model.Button](docs/Button.md)
 - [Model.DeliveryData](docs/DeliveryData.md)
 - [Model.ExportPlayersRequestBody](docs/ExportPlayersRequestBody.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.FilterExpressions](docs/FilterExpressions.md)
 - [Model.FilterNotificationTarget](docs/FilterNotificationTarget.md)
 - [Model.GetNotificationRequestBody](docs/GetNotificationRequestBody.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse201](docs/InlineResponse201.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.InlineResponse4001](docs/InlineResponse4001.md)
 - [Model.InlineResponse4002](docs/InlineResponse4002.md)
 - [Model.InlineResponse4003](docs/InlineResponse4003.md)
 - [Model.InvalidIdentifierError](docs/InvalidIdentifierError.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.Notification200Errors](docs/Notification200Errors.md)
 - [Model.NotificationAllOf](docs/NotificationAllOf.md)
 - [Model.NotificationAllOfAndroidBackgroundLayout](docs/NotificationAllOfAndroidBackgroundLayout.md)
 - [Model.NotificationSlice](docs/NotificationSlice.md)
 - [Model.NotificationTarget](docs/NotificationTarget.md)
 - [Model.NotificationWithMeta](docs/NotificationWithMeta.md)
 - [Model.NotificationWithMetaAllOf](docs/NotificationWithMetaAllOf.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.OutcomeData](docs/OutcomeData.md)
 - [Model.OutcomesData](docs/OutcomesData.md)
 - [Model.PlatformDeliveryData](docs/PlatformDeliveryData.md)
 - [Model.Player](docs/Player.md)
 - [Model.PlayerNotificationTarget](docs/PlayerNotificationTarget.md)
 - [Model.PlayerSlice](docs/PlayerSlice.md)
 - [Model.Purchase](docs/Purchase.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.SegmentNotificationTarget](docs/SegmentNotificationTarget.md)
 - [Model.StringMap](docs/StringMap.md)
 - [Model.UpdatePlayerTagsRequestBody](docs/UpdatePlayerTagsRequestBody.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="app_key"></a>
### app_key

- **Type**: Bearer Authentication

<a name="user_key"></a>
### user_key

- **Type**: Bearer Authentication

