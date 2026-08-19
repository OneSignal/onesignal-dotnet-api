# OneSignalApi.Model.JourneySchedule
Optional future start and/or stop time. null means no scheduled activation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartAt** | **string** | ISO 8601 start time. Use UTC (Z or +00:00). Must be at least 5 minutes in the future. | [optional] 
**StopAt** | **string** | ISO 8601 stop time. Use UTC (Z or +00:00). Must be in the future and later than start_at. | [optional] 
**Error** | **string** | Read-only. Present when a scheduling error occurred. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

