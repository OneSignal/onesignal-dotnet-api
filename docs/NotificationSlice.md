# OneSignalApi.Model.NotificationSlice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCount** | **int** |  | [optional] 
**Offset** | **int** |  | [optional] 
**Limit** | **int** |  | [optional] 
**TimeOffset** | **string** | The time_offset cursor specified in the request, if any. | [optional] 
**NextTimeOffset** | **string** | An opaque Base64 cursor token representing the next page of messages to fetch.  Present when time_offset was provided in the request.  Pass this value as time_offset on the next request to continue paginating. | [optional] 
**Notifications** | [**List&lt;NotificationWithMeta&gt;**](NotificationWithMeta.md) |  | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

