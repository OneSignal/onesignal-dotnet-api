# OneSignalApi.Model.CreateJourneyRequest
Writable fields for Create journey. Journeys are always created in the draft state. Server-controlled fields such as state or id are rejected.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Journey name, up to 300 characters. | 
**Description** | **string** | Optional journey description, up to 1024 characters. | [optional] 
**Audience** | [**JourneyAudience**](JourneyAudience.md) |  | [optional] 
**EarlyExit** | [**JourneyEarlyExit**](JourneyEarlyExit.md) |  | [optional] 
**ReentryRules** | [**JourneyReentryRules**](JourneyReentryRules.md) |  | [optional] 
**Schedule** | [**JourneySchedule**](JourneySchedule.md) |  | [optional] 
**Nodes** | [**List&lt;JourneyNode&gt;**](JourneyNode.md) | Ordered list of journey nodes. Server-assigned id fields are rejected on create. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

