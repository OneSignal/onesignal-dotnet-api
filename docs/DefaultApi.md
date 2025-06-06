# OneSignalApi.Api.DefaultApi

All URIs are relative to *https://api.onesignal.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelNotification**](DefaultApi.md#cancelnotification) | **DELETE** /notifications/{notification_id} | Stop a scheduled or currently outgoing notification
[**CreateAlias**](DefaultApi.md#createalias) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
[**CreateAliasBySubscription**](DefaultApi.md#createaliasbysubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
[**CreateApp**](DefaultApi.md#createapp) | **POST** /apps | Create an app
[**CreateNotification**](DefaultApi.md#createnotification) | **POST** /notifications | Create notification
[**CreateSegment**](DefaultApi.md#createsegment) | **POST** /apps/{app_id}/segments | Create Segment
[**CreateSubscription**](DefaultApi.md#createsubscription) | **POST** /apps/{app_id}/users/by/{alias_label}/{alias_id}/subscriptions | 
[**CreateUser**](DefaultApi.md#createuser) | **POST** /apps/{app_id}/users | 
[**DeleteAlias**](DefaultApi.md#deletealias) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity/{alias_label_to_delete} | 
[**DeleteSegment**](DefaultApi.md#deletesegment) | **DELETE** /apps/{app_id}/segments/{segment_id} | Delete Segment
[**DeleteSubscription**](DefaultApi.md#deletesubscription) | **DELETE** /apps/{app_id}/subscriptions/{subscription_id} | 
[**DeleteUser**](DefaultApi.md#deleteuser) | **DELETE** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
[**ExportEvents**](DefaultApi.md#exportevents) | **POST** /notifications/{notification_id}/export_events?app_id&#x3D;{app_id} | Export CSV of Events
[**ExportSubscriptions**](DefaultApi.md#exportsubscriptions) | **POST** /players/csv_export?app_id&#x3D;{app_id} | Export CSV of Subscriptions
[**GetAliases**](DefaultApi.md#getaliases) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id}/identity | 
[**GetAliasesBySubscription**](DefaultApi.md#getaliasesbysubscription) | **GET** /apps/{app_id}/subscriptions/{subscription_id}/user/identity | 
[**GetApp**](DefaultApi.md#getapp) | **GET** /apps/{app_id} | View an app
[**GetApps**](DefaultApi.md#getapps) | **GET** /apps | View apps
[**GetNotification**](DefaultApi.md#getnotification) | **GET** /notifications/{notification_id} | View notification
[**GetNotificationHistory**](DefaultApi.md#getnotificationhistory) | **POST** /notifications/{notification_id}/history | Notification History
[**GetNotifications**](DefaultApi.md#getnotifications) | **GET** /notifications | View notifications
[**GetOutcomes**](DefaultApi.md#getoutcomes) | **GET** /apps/{app_id}/outcomes | View Outcomes
[**GetSegments**](DefaultApi.md#getsegments) | **GET** /apps/{app_id}/segments | Get Segments
[**GetUser**](DefaultApi.md#getuser) | **GET** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 
[**TransferSubscription**](DefaultApi.md#transfersubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id}/owner | 
[**UnsubscribeEmailWithToken**](DefaultApi.md#unsubscribeemailwithtoken) | **POST** /apps/{app_id}/notifications/{notification_id}/unsubscribe | Unsubscribe with token
[**UpdateApp**](DefaultApi.md#updateapp) | **PUT** /apps/{app_id} | Update an app
[**UpdateLiveActivity**](DefaultApi.md#updateliveactivity) | **POST** /apps/{app_id}/live_activities/{activity_id}/notifications | Update a Live Activity via Push
[**UpdateSubscription**](DefaultApi.md#updatesubscription) | **PATCH** /apps/{app_id}/subscriptions/{subscription_id} | 
[**UpdateUser**](DefaultApi.md#updateuser) | **PATCH** /apps/{app_id}/users/by/{alias_label}/{alias_id} | 


<a name="cancelnotification"></a>
# **CancelNotification**
> GenericSuccessBoolResponse CancelNotification (string appId, string notificationId)

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var notificationId = "notificationId_example";  // string | 

            try
            {
                // Stop a scheduled or currently outgoing notification
                GenericSuccessBoolResponse result = apiInstance.CancelNotification(appId, notificationId);
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

[**GenericSuccessBoolResponse**](GenericSuccessBoolResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createalias"></a>
# **CreateAlias**
> UserIdentityBody CreateAlias (string appId, string aliasLabel, string aliasId, UserIdentityBody userIdentityBody)



Upserts one or more Aliases to an existing User identified by (:alias_label, :alias_id).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 
            var userIdentityBody = new UserIdentityBody(); // UserIdentityBody | 

            try
            {
                UserIdentityBody result = apiInstance.CreateAlias(appId, aliasLabel, aliasId, userIdentityBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAlias: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 
 **userIdentityBody** | [**UserIdentityBody**](UserIdentityBody.md)|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaliasbysubscription"></a>
# **CreateAliasBySubscription**
> UserIdentityBody CreateAliasBySubscription (string appId, string subscriptionId, UserIdentityBody userIdentityBody)



Upserts one or more Aliases for the User identified by :subscription_id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateAliasBySubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var userIdentityBody = new UserIdentityBody(); // UserIdentityBody | 

            try
            {
                UserIdentityBody result = apiInstance.CreateAliasBySubscription(appId, subscriptionId, userIdentityBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAliasBySubscription: " + e.Message );
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
 **subscriptionId** | **string**|  | 
 **userIdentityBody** | [**UserIdentityBody**](UserIdentityBody.md)|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: organization_api_key
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

[organization_api_key](../README.md#organization_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, invalid_aliases, or No Subscribed Players If a message was successfully created, you will get a 200 response and an id for the notification. If the 200 response contains \&quot;invalid_aliases\&quot; this will mark devices that exist in the provided app_id but are no longer subscribed. If no id is returned, then a message was not created and the targeted User IDs do not exist under the provided app_id. Any User IDs sent in the request that do not exist under the specified app_id will be ignored.  |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsegment"></a>
# **CreateSegment**
> CreateSegmentSuccessResponse CreateSegment (string appId, Segment segment = null)

Create Segment

Create a segment visible and usable in the dashboard and API - Required: OneSignal Paid Plan The Create Segment method is used when you want your server to programmatically create a segment instead of using the OneSignal Dashboard UI. Just like creating Segments from the dashboard you can pass in filters with multiple \"AND\" or \"OR\" operator's. &#x1F6A7; Does Not Update Segments This endpoint will only create segments, it does not edit or update currently created Segments. You will need to use the Delete Segment endpoint and re-create it with this endpoint to edit. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var segment = new Segment(); // Segment |  (optional) 

            try
            {
                // Create Segment
                CreateSegmentSuccessResponse result = apiInstance.CreateSegment(appId, segment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSegment: " + e.Message );
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscription"></a>
# **CreateSubscription**
> SubscriptionBody CreateSubscription (string appId, string aliasLabel, string aliasId, SubscriptionBody subscriptionBody)



Creates a new Subscription under the User provided. Useful to add email addresses and SMS numbers to the User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 
            var subscriptionBody = new SubscriptionBody(); // SubscriptionBody | 

            try
            {
                SubscriptionBody result = apiInstance.CreateSubscription(appId, aliasLabel, aliasId, subscriptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSubscription: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 
 **subscriptionBody** | [**SubscriptionBody**](SubscriptionBody.md)|  | 

### Return type

[**SubscriptionBody**](SubscriptionBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | CREATED |  -  |
| **202** | ACCEPTED |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Operation is not permitted due to user having the maximum number of subscriptions assigned |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> User CreateUser (string appId, User user)



Creates a User, optionally Subscriptions owned by the User as well as Aliases. Aliases provided in the payload will be used to look up an existing User.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var user = new User(); // User | 

            try
            {
                User result = apiInstance.CreateUser(appId, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateUser: " + e.Message );
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
 **user** | [**User**](User.md)|  | 

### Return type

[**User**](User.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CREATED |  -  |
| **201** | CREATED |  -  |
| **202** | ACCEPTED |  -  |
| **400** | Bad Request |  -  |
| **409** | Multiple User Identity Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletealias"></a>
# **DeleteAlias**
> UserIdentityBody DeleteAlias (string appId, string aliasLabel, string aliasId, string aliasLabelToDelete)



Deletes an alias by alias label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeleteAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 
            var aliasLabelToDelete = "aliasLabelToDelete_example";  // string | 

            try
            {
                UserIdentityBody result = apiInstance.DeleteAlias(appId, aliasLabel, aliasId, aliasLabelToDelete);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAlias: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 
 **aliasLabelToDelete** | **string**|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesegment"></a>
# **DeleteSegment**
> GenericSuccessBoolResponse DeleteSegment (string appId, string segmentId)

Delete Segment

Delete a segment (not user devices) - Required: OneSignal Paid Plan You can delete a segment under your app by calling this API. You must provide an API key in the Authorization header that has admin access on the app. The segment_id can be found in the URL of the segment when viewing it in the dashboard. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeleteSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var segmentId = "segmentId_example";  // string | The segment_id can be found in the URL of the segment when viewing it in the dashboard.

            try
            {
                // Delete Segment
                GenericSuccessBoolResponse result = apiInstance.DeleteSegment(appId, segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSegment: " + e.Message );
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

[**GenericSuccessBoolResponse**](GenericSuccessBoolResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string appId, string subscriptionId)



Deletes the Subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 

            try
            {
                apiInstance.DeleteSubscription(appId, subscriptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSubscription: " + e.Message );
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
 **subscriptionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | ACCEPTED |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string appId, string aliasLabel, string aliasId)



Removes the User identified by (:alias_label, :alias_id), and all Subscriptions and Aliases

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 

            try
            {
                apiInstance.DeleteUser(appId, aliasLabel, aliasId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteUser: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportevents"></a>
# **ExportEvents**
> ExportEventsSuccessResponse ExportEvents (string notificationId, string appId)

Export CSV of Events

Generate a compressed CSV report of all of the events data for a notification. This will return a URL immediately upon success but it may take several minutes for the CSV to become available at that URL depending on the volume of data. Only one export can be in-progress per OneSignal account at any given time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class ExportEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var notificationId = "notificationId_example";  // string | The ID of the notification to export events from.
            var appId = "appId_example";  // string | The ID of the app that the notification belongs to.

            try
            {
                // Export CSV of Events
                ExportEventsSuccessResponse result = apiInstance.ExportEvents(notificationId, appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ExportEvents: " + e.Message );
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
 **notificationId** | **string**| The ID of the notification to export events from. | 
 **appId** | **string**| The ID of the app that the notification belongs to. | 

### Return type

[**ExportEventsSuccessResponse**](ExportEventsSuccessResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportsubscriptions"></a>
# **ExportSubscriptions**
> ExportSubscriptionsSuccessResponse ExportSubscriptions (string appId, ExportSubscriptionsRequestBody exportSubscriptionsRequestBody = null)

Export CSV of Subscriptions

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
    public class ExportSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The app ID that you want to export devices from
            var exportSubscriptionsRequestBody = new ExportSubscriptionsRequestBody(); // ExportSubscriptionsRequestBody |  (optional) 

            try
            {
                // Export CSV of Subscriptions
                ExportSubscriptionsSuccessResponse result = apiInstance.ExportSubscriptions(appId, exportSubscriptionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ExportSubscriptions: " + e.Message );
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
 **exportSubscriptionsRequestBody** | [**ExportSubscriptionsRequestBody**](ExportSubscriptionsRequestBody.md)|  | [optional] 

### Return type

[**ExportSubscriptionsSuccessResponse**](ExportSubscriptionsSuccessResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaliases"></a>
# **GetAliases**
> UserIdentityBody GetAliases (string appId, string aliasLabel, string aliasId)



Lists all Aliases for the User identified by (:alias_label, :alias_id).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetAliasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 

            try
            {
                UserIdentityBody result = apiInstance.GetAliases(appId, aliasLabel, aliasId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAliases: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaliasesbysubscription"></a>
# **GetAliasesBySubscription**
> UserIdentityBody GetAliasesBySubscription (string appId, string subscriptionId)



Lists all Aliases for the User identified by :subscription_id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetAliasesBySubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 

            try
            {
                UserIdentityBody result = apiInstance.GetAliasesBySubscription(appId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAliasesBySubscription: " + e.Message );
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
 **subscriptionId** | **string**|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: organization_api_key
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

[organization_api_key](../README.md#organization_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: organization_api_key
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

[organization_api_key](../README.md#organization_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationhistory"></a>
# **GetNotificationHistory**
> NotificationHistorySuccessResponse GetNotificationHistory (string notificationId, GetNotificationHistoryRequestBody getNotificationHistoryRequestBody)

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var notificationId = "notificationId_example";  // string | The \"id\" of the message found in the Notification object
            var getNotificationHistoryRequestBody = new GetNotificationHistoryRequestBody(); // GetNotificationHistoryRequestBody | 

            try
            {
                // Notification History
                NotificationHistorySuccessResponse result = apiInstance.GetNotificationHistory(notificationId, getNotificationHistoryRequestBody);
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
 **getNotificationHistoryRequestBody** | [**GetNotificationHistoryRequestBody**](GetNotificationHistoryRequestBody.md)|  | 

### Return type

[**NotificationHistorySuccessResponse**](NotificationHistorySuccessResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegments"></a>
# **GetSegments**
> GetSegmentsSuccessResponse GetSegments (string appId, int? offset = null, int? limit = null)

Get Segments

Returns an array of segments from an app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetSegmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var offset = 56;  // int? | Segments are listed in ascending order of created_at date. offset will omit that number of segments from the beginning of the list. Eg offset 5, will remove the 5 earliest created Segments. (optional) 
            var limit = 56;  // int? | The amount of Segments in the response. Maximum 300. (optional) 

            try
            {
                // Get Segments
                GetSegmentsSuccessResponse result = apiInstance.GetSegments(appId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSegments: " + e.Message );
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
 **offset** | **int?**| Segments are listed in ascending order of created_at date. offset will omit that number of segments from the beginning of the list. Eg offset 5, will remove the 5 earliest created Segments. | [optional] 
 **limit** | **int?**| The amount of Segments in the response. Maximum 300. | [optional] 

### Return type

[**GetSegmentsSuccessResponse**](GetSegmentsSuccessResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (string appId, string aliasLabel, string aliasId)



Returns the User’s properties, Aliases, and Subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 

            try
            {
                User result = apiInstance.GetUser(appId, aliasLabel, aliasId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUser: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfersubscription"></a>
# **TransferSubscription**
> UserIdentityBody TransferSubscription (string appId, string subscriptionId, TransferSubscriptionRequestBody transferSubscriptionRequestBody)



Transfers this Subscription to the User identified by the identity in the payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class TransferSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var transferSubscriptionRequestBody = new TransferSubscriptionRequestBody(); // TransferSubscriptionRequestBody | 

            try
            {
                UserIdentityBody result = apiInstance.TransferSubscription(appId, subscriptionId, transferSubscriptionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TransferSubscription: " + e.Message );
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
 **subscriptionId** | **string**|  | 
 **transferSubscriptionRequestBody** | [**TransferSubscriptionRequestBody**](TransferSubscriptionRequestBody.md)|  | 

### Return type

[**UserIdentityBody**](UserIdentityBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribeemailwithtoken"></a>
# **UnsubscribeEmailWithToken**
> GenericSuccessBoolResponse UnsubscribeEmailWithToken (string appId, string notificationId, string token)

Unsubscribe with token

Unsubscribe an email with a token when using your own custom email unsubscribe landing page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UnsubscribeEmailWithTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | The OneSignal App ID for your app.  Available in Keys & IDs.
            var notificationId = "notificationId_example";  // string | The id of the message found in the creation notification POST response, View Notifications GET response, or URL within the Message Report.
            var token = "token_example";  // string | The unsubscribe token that is generated via liquid syntax in {{subscription.unsubscribe_token}} when personalizing an email.

            try
            {
                // Unsubscribe with token
                GenericSuccessBoolResponse result = apiInstance.UnsubscribeEmailWithToken(appId, notificationId, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UnsubscribeEmailWithToken: " + e.Message );
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
 **notificationId** | **string**| The id of the message found in the creation notification POST response, View Notifications GET response, or URL within the Message Report. | 
 **token** | **string**| The unsubscribe token that is generated via liquid syntax in {{subscription.unsubscribe_token}} when personalizing an email. | 

### Return type

[**GenericSuccessBoolResponse**](GenericSuccessBoolResponse.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: organization_api_key
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

[organization_api_key](../README.md#organization_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

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
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
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

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscription"></a>
# **UpdateSubscription**
> void UpdateSubscription (string appId, string subscriptionId, SubscriptionBody subscriptionBody)



Updates an existing Subscription’s properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var subscriptionBody = new SubscriptionBody(); // SubscriptionBody | 

            try
            {
                apiInstance.UpdateSubscription(appId, subscriptionId, subscriptionBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSubscription: " + e.Message );
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
 **subscriptionId** | **string**|  | 
 **subscriptionBody** | [**SubscriptionBody**](SubscriptionBody.md)|  | 

### Return type

void (empty response body)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> PropertiesBody UpdateUser (string appId, string aliasLabel, string aliasId, UpdateUserRequest updateUserRequest)



Updates an existing User’s properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.onesignal.com";
            // Configure Bearer token for authorization: rest_api_key
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var appId = "appId_example";  // string | 
            var aliasLabel = "aliasLabel_example";  // string | 
            var aliasId = "aliasId_example";  // string | 
            var updateUserRequest = new UpdateUserRequest(); // UpdateUserRequest | 

            try
            {
                PropertiesBody result = apiInstance.UpdateUser(appId, aliasLabel, aliasId, updateUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateUser: " + e.Message );
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
 **aliasLabel** | **string**|  | 
 **aliasId** | **string**|  | 
 **updateUserRequest** | [**UpdateUserRequest**](UpdateUserRequest.md)|  | 

### Return type

[**PropertiesBody**](PropertiesBody.md)

### Authorization

[rest_api_key](../README.md#rest_api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | ACCEPTED |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **429** | Rate Limit Exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

