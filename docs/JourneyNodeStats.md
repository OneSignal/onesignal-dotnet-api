# OneSignalApi.Model.JourneyNodeStats
Stats for a single node. Keyed in the response by the node's server-assigned id.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | Node kind, repeated here so stats can be read without joining against the journey definition. | [optional] 
**Waiting** | **int** | Users currently held at this node. | [optional] 
**Completed** | **int** | Users who advanced past this node normally. | [optional] 
**ExitedEarly** | **int** | Users who left the journey from this node through an early exit rule. | [optional] 
**MessageStats** | [**JourneyMessageStats**](JourneyMessageStats.md) |  | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

