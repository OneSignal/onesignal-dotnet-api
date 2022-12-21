# OneSignalApi.Api.DefaultApi

All URIs are relative to *https://onesignal.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BeginLiveActivity**](DefaultApi.md#beginliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/token | Start Live Activity
[**CancelNotification**](DefaultApi.md#cancelnotification) | **DELETE** /notifications/{notification_id} | Stop a scheduled or currently outgoing notification
[**CreateApp**](DefaultApi.md#createapp) | **POST** /apps | Create an app
[**CreateNotification**](DefaultApi.md#createnotification) | **POST** /notifications | Create notification
[**CreatePlayer**](DefaultApi.md#createplayer) | **POST** /players | Add a device
[**CreateSegments**](DefaultApi.md#createsegments) | **POST** /apps/{app_id}/segments | Create Segments
[**DeletePlayer**](DefaultApi.md#deleteplayer) | **DELETE** /players/{player_id} | Delete a user record
[**DeleteSegments**](DefaultApi.md#deletesegments) | **DELETE** /apps/{app_id}/segments/{segment_id} | Delete Segments
[**EndLiveActivity**](DefaultApi.md#endliveactivity) | **DELETE** /apps/{app_id}/live_activities/{activity_id}/token/{subscription_id} | Stop Live Activity
[**ExportPlayers**](DefaultApi.md#exportplayers) | **POST** /players/csv_export?app_id&#x3D;{app_id} | CSV export
[**GetApp**](DefaultApi.md#getapp) | **GET** /apps/{app_id} | View an app
[**GetApps**](DefaultApi.md#getapps) | **GET** /apps | View apps
[**GetNotification**](DefaultApi.md#getnotification) | **GET** /notifications/{notification_id} | View notification
[**GetNotificationHistory**](DefaultApi.md#getnotificationhistory) | **POST** /notifications/{notification_id}/history | Notification History
[**GetNotifications**](DefaultApi.md#getnotifications) | **GET** /notifications | View notifications
[**GetOutcomes**](DefaultApi.md#getoutcomes) | **GET** /apps/{app_id}/outcomes | View Outcomes
[**GetPlayer**](DefaultApi.md#getplayer) | **GET** /players/{player_id} | View device
[**GetPlayers**](DefaultApi.md#getplayers) | **GET** /players | View devices
[**UpdateApp**](DefaultApi.md#updateapp) | **PUT** /apps/{app_id} | Update an app
[**UpdateLiveActivity**](DefaultApi.md#updateliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/notifications | Update a Live Activity via Push
[**UpdatePlayer**](DefaultApi.md#updateplayer) | **PUT** /players/{player_id} | Edit device
[**UpdatePlayerTags**](DefaultApi.md#updateplayertags) | **PUT** /apps/{app_id}/users/{external_user_id} | Edit tags with external user id


<a name="beginliveactivity"></a>
# **BeginLiveActivity**
> void BeginLiveActivity (string appId, string activityId, BeginLiveActivityRequest beginLiveActivityRequest)

Start Live Activity

Starts a Live Activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class BeginLiveActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var activityId = "activityId_example";  // string | Live Activity record ID
            var beginLiveActivityRequest = new BeginLiveActivityRequest(); // BeginLiveActivityRequest | 

            try
            {
                // Start Live Activity
                apiInstance.BeginLiveActivity(appId, activityId, beginLiveActivityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BeginLiveActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **activityId** | **string**| Live Activity record ID | 
 **beginLiveActivityRequest** | [**BeginLiveActivityRequest**](BeginLiveActivityRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelnotification"></a>
# **CancelNotification**
> CancelNotificationSuccessResponse CancelNotification (string appId, string notificationId)

Stop a scheduled or currently outgoing notification

Used to stop a scheduled or currently outgoing notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CancelNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var notificationId = "notificationId_example";  // string | 

            try
            {
                // Stop a scheduled or currently outgoing notification
                CancelNotificationSuccessResponse result = apiInstance.CancelNotification(appId, notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **notificationId** | **string**|  | 

### Return type

[**CancelNotificationSuccessResponse**](CancelNotificationSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapp"></a>
# **CreateApp**
> App CreateApp (App app)

Create an app

Creates a new OneSignal app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: user_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var app = new App(); // App | 

            try
            {
                // Create an app
                App result = apiInstance.CreateApp(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateApp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **app** | [**App**](App.md)|  | 

### Return type

[**App**](App.md)

### Authorization

[user_key](../README.md#user_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnotification"></a>
# **CreateNotification**
> CreateNotificationSuccessResponse CreateNotification (Notification notification)

Create notification

Sends notifications to your users 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var notification = new Notification(); // Notification | 

            try
            {
                // Create notification
                CreateNotificationSuccessResponse result = apiInstance.CreateNotification(notification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**Notification**](Notification.md)|  | 

### Return type

[**CreateNotificationSuccessResponse**](CreateNotificationSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, invalid_player_ids, invalid_external_user_ids or No Subscribed Players If a message was successfully created, you will get a 200 response and an id for the notification. If the 200 response contains \&quot;invalid_player_ids\&quot; or \&quot;invalid_external_user_ids\&quot; this will mark devices that exist in the provided app_id but are no longer subscribed. If no id is returned, then a message was not created and the targeted User IDs do not exist under the provided app_id. Any User IDs sent in the request that do not exist under the specified app_id will be ignored.  |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createplayer"></a>
# **CreatePlayer**
> CreatePlayerSuccessResponse CreatePlayer (Player player)

Add a device

Register a new device to one of your OneSignal apps &#x1F6A7; Don't use this This API endpoint is designed to be used from our open source Mobile and Web Push SDKs. It is not designed for developers to use it directly, unless instructed to do so by OneSignal support. If you use this method instead of our SDKs, many OneSignal features such as conversion tracking, timezone tracking, language detection, and rich-push won't work out of the box. It will also make it harder to identify possible setup issues. This method is used to register a new device with OneSignal. If a device is already registered with the specified identifier, then this will update the existing device record instead of creating a new one. The returned player is a player / user ID. Use the returned ID to send push notifications to this specific user later, or to include this player when sending to a set of users. &#x1F6A7; iOS Must set test_type to 1 when building your iOS app as development. Omit this field in your production app builds. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var player = new Player(); // Player | 

            try
            {
                // Add a device
                CreatePlayerSuccessResponse result = apiInstance.CreatePlayer(player);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePlayer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **player** | [**Player**](Player.md)|  | 

### Return type

[**CreatePlayerSuccessResponse**](CreatePlayerSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsegments"></a>
# **CreateSegments**
> CreateSegmentSuccessResponse CreateSegments (string appId, Segment segment = null)

Create Segments

Create segments visible and usable in the dashboard and API - Required: OneSignal Paid Plan The Create Segment method is used when you want your server to programmatically create a segment instead of using the OneSignal Dashboard UI. Just like creating Segments from the dashboard you can pass in filters with multiple \"AND\" or \"OR\" operator's. &#x1F6A7; Does Not Update Segments This endpoint will only create segments, it does not edit or update currently created Segments. You will need to use the Delete Segments endpoint and re-create it with this endpoint to edit. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateSegmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var segment = new Segment(); // Segment |  (optional) 

            try
            {
                // Create Segments
                CreateSegmentSuccessResponse result = apiInstance.CreateSegments(appId, segment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSegments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **segment** | [**Segment**](Segment.md)|  | [optional] 

### Return type

[**CreateSegmentSuccessResponse**](CreateSegmentSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplayer"></a>
# **DeletePlayer**
> DeletePlayerSuccessResponse DeletePlayer (string appId, string playerId)

Delete a user record

Delete player - Required: Used to delete a single, specific Player ID record from a specific OneSignal app. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeletePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var playerId = "playerId_example";  // string | The OneSignal player_id

            try
            {
                // Delete a user record
                DeletePlayerSuccessResponse result = apiInstance.DeletePlayer(appId, playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeletePlayer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **playerId** | **string**| The OneSignal player_id | 

### Return type

[**DeletePlayerSuccessResponse**](DeletePlayerSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesegments"></a>
# **DeleteSegments**
> DeleteSegmentSuccessResponse DeleteSegments (string appId, string segmentId)

Delete Segments

Delete segments (not user devices) - Required: OneSignal Paid Plan You can delete a segment under your app by calling this API. You must provide an API key in the Authorization header that has admin access on the app. The segment_id can be found in the URL of the segment when viewing it in the dashboard. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeleteSegmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var segmentId = "segmentId_example";  // string | The segment_id can be found in the URL of the segment when viewing it in the dashboard.

            try
            {
                // Delete Segments
                DeleteSegmentSuccessResponse result = apiInstance.DeleteSegments(appId, segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSegments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **segmentId** | **string**| The segment_id can be found in the URL of the segment when viewing it in the dashboard. | 

### Return type

[**DeleteSegmentSuccessResponse**](DeleteSegmentSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endliveactivity"></a>
# **EndLiveActivity**
> void EndLiveActivity (string appId, string activityId, string subscriptionId)

Stop Live Activity

Stops a Live Activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class EndLiveActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var activityId = "activityId_example";  // string | Live Activity record ID
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID

            try
            {
                // Stop Live Activity
                apiInstance.EndLiveActivity(appId, activityId, subscriptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EndLiveActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **activityId** | **string**| Live Activity record ID | 
 **subscriptionId** | **string**| Subscription ID | 

### Return type

void (empty response body)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportplayers"></a>
# **ExportPlayers**
> ExportPlayersSuccessResponse ExportPlayers (string appId, ExportPlayersRequestBody exportPlayersRequestBody = null)

CSV export

Generate a compressed CSV export of all of your current user data This method can be used to generate a compressed CSV export of all of your current user data. It is a much faster alternative than retrieving this data using the /players API endpoint. The file will be compressed using GZip. The file may take several minutes to generate depending on the number of users in your app. The URL generated will be available for 3 days and includes random v4 uuid as part of the resource name to be unguessable. &#x1F6A7; 403 Error Responses          You can test if it is complete by making a GET request to the csv_file_url value. This file may take time to generate depending on how many device records are being pulled. If the file is not ready, a 403 error will be returned. Otherwise the file itself will be returned. &#x1F6A7; Requires Authentication Key Requires your OneSignal App's REST API Key, available in Keys & IDs. &#x1F6A7; Concurrent Exports Only one concurrent export is allowed per OneSignal account. Please ensure you have successfully downloaded the .csv.gz file before exporting another app. CSV File Format: - Default Columns:   | Field | Details |   | - -- | - -- |   | id | OneSignal Player Id |   | identifier | Push Token |   | session_count | Number of times they visited the app or site   | language | Device language code |   | timezone | Number of seconds away from UTC. Example: -28800 |   | game_version | Version of your mobile app gathered from Android Studio versionCode in your App/build.gradle and iOS uses kCFBundleVersionKey in Xcode. |   | device_os | Device Operating System Version. Example: 80 = Chrome 80, 9 = Android 9 |   | device_type | Device Operating System Type |   | device_model | Device Hardware String Code. Example: Mobile Web Subscribers will have `Linux armv` |   | ad_id | Based on the Google Advertising Id for Android, identifierForVendor for iOS. OptedOut means user turned off Advertising tracking on the device. |   | tags | Current OneSignal Data Tags on the device. |   | last_active | Date and time the user last opened the mobile app or visited the site. |   | playtime | Total amount of time in seconds the user had the mobile app open. |   | amount_spent |  Mobile only - amount spent in USD on In-App Purchases. |    | created_at | Date and time the device record was created in OneSignal. Mobile - first time they opened the app with OneSignal SDK. Web - first time the user subscribed to the site. |   | invalid_identifier | t = unsubscribed, f = subscibed |   | badge_count | Current number of badges on the device | - Extra Columns:   | Field | Details |   | - -- | - -- |   | external_user_id | Your User Id set on the device |   | notification_types | Notification types |   | location | Location points (Latitude and Longitude) set on the device. |   | country | Country code |   | rooted | Android device rooted or not |   | ip | IP Address of the device if being tracked. See Handling Personal Data. |   | web_auth | Web Only authorization key. |   | web_p256 | Web Only p256 key. | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class ExportPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The app ID that you want to export devices from
            var exportPlayersRequestBody = new ExportPlayersRequestBody(); // ExportPlayersRequestBody |  (optional) 

            try
            {
                // CSV export
                ExportPlayersSuccessResponse result = apiInstance.ExportPlayers(appId, exportPlayersRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ExportPlayers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The app ID that you want to export devices from | 
 **exportPlayersRequestBody** | [**ExportPlayersRequestBody**](ExportPlayersRequestBody.md)|  | [optional] 

### Return type

[**ExportPlayersSuccessResponse**](ExportPlayersSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapp"></a>
# **GetApp**
> App GetApp (string appId)

View an app

View the details of a single OneSignal app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: user_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | An app id

            try
            {
                // View an app
                App result = apiInstance.GetApp(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetApp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| An app id | 

### Return type

[**App**](App.md)

### Authorization

[user_key](../README.md#user_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapps"></a>
# **GetApps**
> List&lt;App&gt; GetApps ()

View apps

View the details of all of your current OneSignal apps

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetAppsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: user_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                // View apps
                List<App> result = apiInstance.GetApps();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetApps: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;App&gt;**](App.md)

### Authorization

[user_key](../README.md#user_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotification"></a>
# **GetNotification**
> NotificationWithMeta GetNotification (string appId, string notificationId)

View notification

View the details of a single notification and outcomes associated with it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var notificationId = "notificationId_example";  // string | 

            try
            {
                // View notification
                NotificationWithMeta result = apiInstance.GetNotification(appId, notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **notificationId** | **string**|  | 

### Return type

[**NotificationWithMeta**](NotificationWithMeta.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationhistory"></a>
# **GetNotificationHistory**
> NotificationHistorySuccessResponse GetNotificationHistory (string notificationId, GetNotificationRequestBody getNotificationRequestBody)

Notification History

-> View the devices sent a message - OneSignal Paid Plan Required This method will return all devices that were sent the given notification_id of an Email or Push Notification if used within 7 days of the date sent. After 7 days of the sending date, the message history data will be unavailable. After a successful response is received, the destination url may be polled until the file becomes available. Most exports are done in ~1-3 minutes, so setting a poll interval of 10 seconds should be adequate. For use cases that are not meant to be consumed by a script, an email will be sent to the supplied email address. &#x1F6A7; Requirements A OneSignal Paid Plan. Turn on Send History via OneSignal API in Settings -> Analytics. Cannot get data before this was turned on. Must be called within 7 days after sending the message. Messages targeting under 1000 recipients will not have \"sent\" events recorded, but will show \"clicked\" events. Requires your OneSignal App's REST API Key, available in Keys & IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetNotificationHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var notificationId = "notificationId_example";  // string | The \"id\" of the message found in the Notification object
            var getNotificationRequestBody = new GetNotificationRequestBody(); // GetNotificationRequestBody | 

            try
            {
                // Notification History
                NotificationHistorySuccessResponse result = apiInstance.GetNotificationHistory(notificationId, getNotificationRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNotificationHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **string**| The \&quot;id\&quot; of the message found in the Notification object | 
 **getNotificationRequestBody** | [**GetNotificationRequestBody**](GetNotificationRequestBody.md)|  | 

### Return type

[**NotificationHistorySuccessResponse**](NotificationHistorySuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotifications"></a>
# **GetNotifications**
> NotificationSlice GetNotifications (string appId, int? limit = null, int? offset = null, int? kind = null)

View notifications

View the details of multiple notifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The app ID that you want to view notifications from
            var limit = 56;  // int? | How many notifications to return.  Max is 50.  Default is 50. (optional) 
            var offset = 56;  // int? | Page offset.  Default is 0.  Results are sorted by queued_at in descending order.  queued_at is a representation of the time that the notification was queued at. (optional) 
            var kind = 0;  // int? | Kind of notifications returned:   * unset - All notification types (default)   * `0` - Dashboard only   * `1` - API only   * `3` - Automated only  (optional) 

            try
            {
                // View notifications
                NotificationSlice result = apiInstance.GetNotifications(appId, limit, offset, kind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNotifications: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The app ID that you want to view notifications from | 
 **limit** | **int?**| How many notifications to return.  Max is 50.  Default is 50. | [optional] 
 **offset** | **int?**| Page offset.  Default is 0.  Results are sorted by queued_at in descending order.  queued_at is a representation of the time that the notification was queued at. | [optional] 
 **kind** | **int?**| Kind of notifications returned:   * unset - All notification types (default)   * &#x60;0&#x60; - Dashboard only   * &#x60;1&#x60; - API only   * &#x60;3&#x60; - Automated only  | [optional] 

### Return type

[**NotificationSlice**](NotificationSlice.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoutcomes"></a>
# **GetOutcomes**
> OutcomesData GetOutcomes (string appId, string outcomeNames, string outcomeNames2 = null, string outcomeTimeRange = null, string outcomePlatforms = null, string outcomeAttribution = null)

View Outcomes

View the details of all the outcomes associated with your app  &#x1F6A7; Requires Authentication Key Requires your OneSignal App's REST API Key, available in Keys & IDs.  &#x1F6A7; Outcome Data Limitations Outcomes are only accessible for around 30 days before deleted from our servers. You will need to export this data every month if you want to keep it. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetOutcomesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var outcomeNames = "outcomeNames_example";  // string | Required Comma-separated list of names and the value (sum/count) for the returned outcome data. Note: Clicks only support count aggregation. For out-of-the-box OneSignal outcomes such as click and session duration, please use the \"os\" prefix with two underscores. For other outcomes, please use the name specified by the user. Example:os__session_duration.count,os__click.count,CustomOutcomeName.sum 
            var outcomeNames2 = "outcomeNames_example";  // string | Optional If outcome names contain any commas, then please specify only one value at a time. Example: outcome_names[]=os__click.count&outcome_names[]=Sales, Purchase.count where \"Sales, Purchase\" is the custom outcomes with a comma in the name.  (optional) 
            var outcomeTimeRange = "outcomeTimeRange_example";  // string | Optional Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data). Default is 1h if the parameter is omitted.  (optional) 
            var outcomePlatforms = "outcomePlatforms_example";  // string | Optional Platform id. Refer device's platform ids for values. Example: outcome_platform=0 for iOS outcome_platform=7,8 for Safari and Firefox Default is data from all platforms if the parameter is omitted.  (optional) 
            var outcomeAttribution = "outcomeAttribution_example";  // string | Optional Attribution type for the outcomes. The values can be direct or influenced or unattributed. Example: outcome_attribution=direct Default is total (returns direct+influenced+unattributed) if the parameter is omitted.  (optional) 

            try
            {
                // View Outcomes
                OutcomesData result = apiInstance.GetOutcomes(appId, outcomeNames, outcomeNames2, outcomeTimeRange, outcomePlatforms, outcomeAttribution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetOutcomes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **outcomeNames** | **string**| Required Comma-separated list of names and the value (sum/count) for the returned outcome data. Note: Clicks only support count aggregation. For out-of-the-box OneSignal outcomes such as click and session duration, please use the \&quot;os\&quot; prefix with two underscores. For other outcomes, please use the name specified by the user. Example:os__session_duration.count,os__click.count,CustomOutcomeName.sum  | 
 **outcomeNames2** | **string**| Optional If outcome names contain any commas, then please specify only one value at a time. Example: outcome_names[]&#x3D;os__click.count&amp;outcome_names[]&#x3D;Sales, Purchase.count where \&quot;Sales, Purchase\&quot; is the custom outcomes with a comma in the name.  | [optional] 
 **outcomeTimeRange** | **string**| Optional Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data). Default is 1h if the parameter is omitted.  | [optional] 
 **outcomePlatforms** | **string**| Optional Platform id. Refer device&#39;s platform ids for values. Example: outcome_platform&#x3D;0 for iOS outcome_platform&#x3D;7,8 for Safari and Firefox Default is data from all platforms if the parameter is omitted.  | [optional] 
 **outcomeAttribution** | **string**| Optional Attribution type for the outcomes. The values can be direct or influenced or unattributed. Example: outcome_attribution&#x3D;direct Default is total (returns direct+influenced+unattributed) if the parameter is omitted.  | [optional] 

### Return type

[**OutcomesData**](OutcomesData.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayer"></a>
# **GetPlayer**
> Player GetPlayer (string appId, string playerId, string emailAuthHash = null)

View device

View the details of an existing device in one of your OneSignal apps

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetPlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | Your app_id for this device
            var playerId = "playerId_example";  // string | Player's OneSignal ID
            var emailAuthHash = "emailAuthHash_example";  // string | Email - Only required if you have enabled Identity Verification and device_type is email (11). (optional) 

            try
            {
                // View device
                Player result = apiInstance.GetPlayer(appId, playerId, emailAuthHash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPlayer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Your app_id for this device | 
 **playerId** | **string**| Player&#39;s OneSignal ID | 
 **emailAuthHash** | **string**| Email - Only required if you have enabled Identity Verification and device_type is email (11). | [optional] 

### Return type

[**Player**](Player.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayers"></a>
# **GetPlayers**
> PlayerSlice GetPlayers (string appId, int? limit = null, int? offset = null)

View devices

View the details of multiple devices in one of your OneSignal apps Unavailable for Apps Over 80,000 Users For performance reasons, this method is not available for larger apps. Larger apps should use the CSV export API endpoint, which is much more performant. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The app ID that you want to view players from
            var limit = 56;  // int? | How many devices to return. Max is 300. Default is 300 (optional) 
            var offset = 56;  // int? | Result offset. Default is 0. Results are sorted by id; (optional) 

            try
            {
                // View devices
                PlayerSlice result = apiInstance.GetPlayers(appId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPlayers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The app ID that you want to view players from | 
 **limit** | **int?**| How many devices to return. Max is 300. Default is 300 | [optional] 
 **offset** | **int?**| Result offset. Default is 0. Results are sorted by id; | [optional] 

### Return type

[**PlayerSlice**](PlayerSlice.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapp"></a>
# **UpdateApp**
> App UpdateApp (string appId, App app)

Update an app

Updates the name or configuration settings of an existing OneSignal app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdateAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: user_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | An app id
            var app = new App(); // App | 

            try
            {
                // Update an app
                App result = apiInstance.UpdateApp(appId, app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateApp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| An app id | 
 **app** | [**App**](App.md)|  | 

### Return type

[**App**](App.md)

### Authorization

[user_key](../README.md#user_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateliveactivity"></a>
# **UpdateLiveActivity**
> UpdateLiveActivitySuccessResponse UpdateLiveActivity (string appId, string activityId, UpdateLiveActivityRequest updateLiveActivityRequest)

Update a Live Activity via Push

Updates a specified live activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdateLiveActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var activityId = "activityId_example";  // string | Live Activity record ID
            var updateLiveActivityRequest = new UpdateLiveActivityRequest(); // UpdateLiveActivityRequest | 

            try
            {
                // Update a Live Activity via Push
                UpdateLiveActivitySuccessResponse result = apiInstance.UpdateLiveActivity(appId, activityId, updateLiveActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateLiveActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID for your app.  Available in Keys &amp; IDs. | 
 **activityId** | **string**| Live Activity record ID | 
 **updateLiveActivityRequest** | [**UpdateLiveActivityRequest**](UpdateLiveActivityRequest.md)|  | 

### Return type

[**UpdateLiveActivitySuccessResponse**](UpdateLiveActivitySuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplayer"></a>
# **UpdatePlayer**
> UpdatePlayerSuccessResponse UpdatePlayer (string playerId, Player player)

Edit device

Update an existing device in one of your OneSignal apps

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var playerId = "playerId_example";  // string | Player's OneSignal ID
            var player = new Player(); // Player | 

            try
            {
                // Edit device
                UpdatePlayerSuccessResponse result = apiInstance.UpdatePlayer(playerId, player);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdatePlayer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **playerId** | **string**| Player&#39;s OneSignal ID | 
 **player** | [**Player**](Player.md)|  | 

### Return type

[**UpdatePlayerSuccessResponse**](UpdatePlayerSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplayertags"></a>
# **UpdatePlayerTags**
> UpdatePlayerTagsSuccessResponse UpdatePlayerTags (string appId, string externalUserId, UpdatePlayerTagsRequestBody updatePlayerTagsRequestBody = null)

Edit tags with external user id

Update an existing device's tags in one of your OneSignal apps using the External User ID. Warning - Android SDK Data Synchronization Tags added through the Android SDK tagging methods may not update if using the API to change or update the same tag. For example, if you use SDK method sendTag(\"key\", \"value1\") then update the tag value to \"value2\" with this API endpoint. You will not be able to set the value back to \"value1\" through the SDK, you will need to change it to something different through the SDK to be reset. Recommendations if using this Endpoint on Android Mobile Apps: 1 - Do not use the same tag keys for SDK and API updates 2 - If you want to use the same key for both SDK and API updates, call the SDK getTags method first to update the device's tags. This is only applicable on the Android Mobile App SDKs. &#128216; Deleting Tags To delete a tag, include its key and set its value to blank. Omitting a key/value will not delete it. For example, if I wanted to delete two existing tags rank and category while simultaneously adding a new tag class, the tags JSON would look like the following: \"tags\": {    \"rank\": \"\",    \"category\": \"\",    \"class\": \"my_new_value\" } 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdatePlayerTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://onesignal.com/api/v1";
            // Configure Bearer token for authorization: app_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID the user record is found under.
            var externalUserId = "externalUserId_example";  // string | The External User ID mapped to teh device record in OneSignal.  Must be actively set on the device to be updated.
            var updatePlayerTagsRequestBody = new UpdatePlayerTagsRequestBody(); // UpdatePlayerTagsRequestBody |  (optional) 

            try
            {
                // Edit tags with external user id
                UpdatePlayerTagsSuccessResponse result = apiInstance.UpdatePlayerTags(appId, externalUserId, updatePlayerTagsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdatePlayerTags: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The OneSignal App ID the user record is found under. | 
 **externalUserId** | **string**| The External User ID mapped to teh device record in OneSignal.  Must be actively set on the device to be updated. | 
 **updatePlayerTagsRequestBody** | [**UpdatePlayerTagsRequestBody**](UpdatePlayerTagsRequestBody.md)|  | [optional] 

### Return type

[**UpdatePlayerTagsSuccessResponse**](UpdatePlayerTagsSuccessResponse.md)

### Authorization

[app_key](../README.md#app_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

