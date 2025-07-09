# OneSignalApi - the C# library for the OneSignal

A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com

- API version: 5.2.0
- SDK version: 5.2.0-beta1
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
            // Configure configuration with organization_api_key Bearer token for authorization to access endpoints
            // that require the OneSignal Organization API Key.
            var orgConfig = new Configuration();
            orgConfig.BasePath = "https://api.onesignal.com";
            orgConfig.AccessToken = "YOUR_ORGANIZATION_API_KEY"; // Organization key is only required for creating new apps and other top-level endpoints
            
            var userInstance = new DefaultApi(orgConfig);

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


            // Configure configuration with rest_api_key Bearer token for authorization to access endpoints
            // that require the OneSignal App REST API Key.
            var appConfig = new Configuration();
            appConfig.BasePath = "https://api.onesignal.com";
            appConfig.AccessToken = "YOUR_REST_API_KEY"; // App REST API key required for most endpoints
            
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

All URIs are relative to *https://api.onesignal.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**CancelNotification**](docs/DefaultApi.md#cancelnotification) | **DELETE** /notifications/{notification_id} | Stop a scheduled or currently outgoing notification
*DefaultApi* | [**CreateAlias**](docs/DefaultApi.md#createalias) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
*DefaultApi* | [**CreateAliasBySubscription**](docs/DefaultApi.md#createaliasbysubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
*DefaultApi* | [**CreateApp**](docs/DefaultApi.md#createapp) | **POST** /apps | Create an app
*DefaultApi* | [**CreateNotification**](docs/DefaultApi.md#createnotification) | **POST** /notifications | Create notification
*DefaultApi* | [**CreateSegment**](docs/DefaultApi.md#createsegment) | **POST** /apps/{app_id}/segments | Create Segment
*DefaultApi* | [**CreateSubscription**](docs/DefaultApi.md#createsubscription) | **POST** /apps/{app_id}/users/by/{alias_label}/{alias_id}/subscriptions | 
*DefaultApi* | [**CreateUser**](docs/DefaultApi.md#createuser) | **POST** /apps/{app_id}/users | 
*DefaultApi* | [**DeleteAlias**](docs/DefaultApi.md#deletealias) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity/{alias_label_to_delete} | 
*DefaultApi* | [**DeleteSegment**](docs/DefaultApi.md#deletesegment) | **DELETE** /apps/{app_id}/segments/{segment_id} | Delete Segment
*DefaultApi* | [**DeleteSubscription**](docs/DefaultApi.md#deletesubscription) | **DELETE** /apps/{app_id}/subscriptions/{subscription_id} | 
*DefaultApi* | [**DeleteUser**](docs/DefaultApi.md#deleteuser) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
*DefaultApi* | [**ExportEvents**](docs/DefaultApi.md#exportevents) | **POST** /notifications/{notification_id}/export_events?app_id&#x3D;{app_id} | Export CSV of Events
*DefaultApi* | [**ExportSubscriptions**](docs/DefaultApi.md#exportsubscriptions) | **POST** /players/csv_export?app_id&#x3D;{app_id} | Export CSV of Subscriptions
*DefaultApi* | [**GetAliases**](docs/DefaultApi.md#getaliases) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
*DefaultApi* | [**GetAliasesBySubscription**](docs/DefaultApi.md#getaliasesbysubscription) | **GET** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
*DefaultApi* | [**GetApp**](docs/DefaultApi.md#getapp) | **GET** /apps/{app_id} | View an app
*DefaultApi* | [**GetApps**](docs/DefaultApi.md#getapps) | **GET** /apps | View apps
*DefaultApi* | [**GetNotification**](docs/DefaultApi.md#getnotification) | **GET** /notifications/{notification_id} | View notification
*DefaultApi* | [**GetNotificationHistory**](docs/DefaultApi.md#getnotificationhistory) | **POST** /notifications/{notification_id}/history | Notification History
*DefaultApi* | [**GetNotifications**](docs/DefaultApi.md#getnotifications) | **GET** /notifications | View notifications
*DefaultApi* | [**GetOutcomes**](docs/DefaultApi.md#getoutcomes) | **GET** /apps/{app_id}/outcomes | View Outcomes
*DefaultApi* | [**GetSegments**](docs/DefaultApi.md#getsegments) | **GET** /apps/{app_id}/segments | Get Segments
*DefaultApi* | [**GetUser**](docs/DefaultApi.md#getuser) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
*DefaultApi* | [**TransferSubscription**](docs/DefaultApi.md#transfersubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/owner | 
*DefaultApi* | [**UnsubscribeEmailWithToken**](docs/DefaultApi.md#unsubscribeemailwithtoken) | **POST** /apps/{app_id}/notifications/{notification_id}/unsubscribe | Unsubscribe with token
*DefaultApi* | [**UpdateApp**](docs/DefaultApi.md#updateapp) | **PUT** /apps/{app_id} | Update an app
*DefaultApi* | [**UpdateLiveActivity**](docs/DefaultApi.md#updateliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/notifications | Update a Live Activity via Push
*DefaultApi* | [**UpdateSubscription**](docs/DefaultApi.md#updatesubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id} | 
*DefaultApi* | [**UpdateUser**](docs/DefaultApi.md#updateuser) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.App](docs/App.md)
 - [Model.BasicNotification](docs/BasicNotification.md)
 - [Model.BasicNotificationAllOf](docs/BasicNotificationAllOf.md)
 - [Model.BasicNotificationAllOfAndroidBackgroundLayout](docs/BasicNotificationAllOfAndroidBackgroundLayout.md)
 - [Model.Button](docs/Button.md)
 - [Model.CreateNotificationSuccessResponse](docs/CreateNotificationSuccessResponse.md)
 - [Model.CreateSegmentConflictResponse](docs/CreateSegmentConflictResponse.md)
 - [Model.CreateSegmentSuccessResponse](docs/CreateSegmentSuccessResponse.md)
 - [Model.CreateUserConflictResponse](docs/CreateUserConflictResponse.md)
 - [Model.CreateUserConflictResponseErrorsInner](docs/CreateUserConflictResponseErrorsInner.md)
 - [Model.CreateUserConflictResponseErrorsItemsMeta](docs/CreateUserConflictResponseErrorsItemsMeta.md)
 - [Model.DeliveryData](docs/DeliveryData.md)
 - [Model.ExportEventsSuccessResponse](docs/ExportEventsSuccessResponse.md)
 - [Model.ExportSubscriptionsRequestBody](docs/ExportSubscriptionsRequestBody.md)
 - [Model.ExportSubscriptionsSuccessResponse](docs/ExportSubscriptionsSuccessResponse.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.FilterExpression](docs/FilterExpression.md)
 - [Model.GenericError](docs/GenericError.md)
 - [Model.GenericSuccessBoolResponse](docs/GenericSuccessBoolResponse.md)
 - [Model.GetNotificationHistoryRequestBody](docs/GetNotificationHistoryRequestBody.md)
 - [Model.GetSegmentsSuccessResponse](docs/GetSegmentsSuccessResponse.md)
 - [Model.LanguageStringMap](docs/LanguageStringMap.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.NotificationAllOf](docs/NotificationAllOf.md)
 - [Model.NotificationHistorySuccessResponse](docs/NotificationHistorySuccessResponse.md)
 - [Model.NotificationSlice](docs/NotificationSlice.md)
 - [Model.NotificationTarget](docs/NotificationTarget.md)
 - [Model.NotificationWithMeta](docs/NotificationWithMeta.md)
 - [Model.NotificationWithMetaAllOf](docs/NotificationWithMetaAllOf.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.OutcomeData](docs/OutcomeData.md)
 - [Model.OutcomesData](docs/OutcomesData.md)
 - [Model.PlatformDeliveryData](docs/PlatformDeliveryData.md)
 - [Model.PlatformDeliveryDataEmailAllOf](docs/PlatformDeliveryDataEmailAllOf.md)
 - [Model.PlatformDeliveryDataSmsAllOf](docs/PlatformDeliveryDataSmsAllOf.md)
 - [Model.PropertiesBody](docs/PropertiesBody.md)
 - [Model.PropertiesDeltas](docs/PropertiesDeltas.md)
 - [Model.PropertiesObject](docs/PropertiesObject.md)
 - [Model.Purchase](docs/Purchase.md)
 - [Model.RateLimitError](docs/RateLimitError.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.SegmentData](docs/SegmentData.md)
 - [Model.SegmentNotificationTarget](docs/SegmentNotificationTarget.md)
 - [Model.Subscription](docs/Subscription.md)
 - [Model.SubscriptionBody](docs/SubscriptionBody.md)
 - [Model.SubscriptionNotificationTarget](docs/SubscriptionNotificationTarget.md)
 - [Model.TransferSubscriptionRequestBody](docs/TransferSubscriptionRequestBody.md)
 - [Model.UpdateLiveActivityRequest](docs/UpdateLiveActivityRequest.md)
 - [Model.UpdateLiveActivitySuccessResponse](docs/UpdateLiveActivitySuccessResponse.md)
 - [Model.UpdateUserRequest](docs/UpdateUserRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserIdentityBody](docs/UserIdentityBody.md)
 - [Model.WebButton](docs/WebButton.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="organization_api_key"></a>
### organization_api_key

- **Type**: Bearer Authentication

<a name="rest_api_key"></a>
### rest_api_key

- **Type**: Bearer Authentication

