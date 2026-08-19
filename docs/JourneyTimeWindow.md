# OneSignalApi.Model.JourneyTimeWindow
A wall-clock window. Each window must span at least 15 minutes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**JourneyTimePoint**](JourneyTimePoint.md) | When the window opens. | [optional] 
**End** | [**JourneyTimePoint**](JourneyTimePoint.md) | When the window closes. | [optional] 
**DayOfWeek** | **int** | Day of week, 1 &#x3D; Monday. Omit to apply the window to every day. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

