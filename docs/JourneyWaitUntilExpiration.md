# OneSignalApi.Model.JourneyWaitUntilExpiration
Optional expiration timer. null waits indefinitely.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DurationSeconds** | **int?** | Seconds to wait before the timer fires. Minimum 60, maximum 31556952 (1 year). | [optional] 
**Exits** | **bool?** | When true, the user exits the journey when the timer fires; when false, the user continues to convergence. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

