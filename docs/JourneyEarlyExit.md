# OneSignalApi.Model.JourneyEarlyExit
Conditions that remove a user from the journey before it completes. At least one rule must be set under rules. Send null to remove early exit entirely.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | [**JourneyEarlyExitRules**](JourneyEarlyExitRules.md) |  | [optional] 
**TagOnEarlyExit** | **Dictionary&lt;string, string&gt;** | Tag key-value pairs applied when a user exits early. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

