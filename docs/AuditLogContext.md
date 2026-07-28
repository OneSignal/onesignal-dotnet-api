# OneSignalApi.Model.AuditLogContext
Request context at the time of the event. Absent if context was not captured.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **string** | Country code derived from the request IP. | [optional] 
**Ip** | **string** | IP address the request originated from. | [optional] 
**Metadata** | **Object** | Additional context-specific data. | [optional] 
**UserAgent** | **string** | User agent of the client that made the request. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

