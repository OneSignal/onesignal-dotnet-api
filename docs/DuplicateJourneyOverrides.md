# OneSignalApi.Model.DuplicateJourneyOverrides
Journey fields to apply over the copy as a JSON Merge Patch (RFC 7396). Accepts the same writable fields as Create journey, and none of them are required. The patch merges into the copy, not the source. The copy starts without a schedule, so an omitted schedule leaves the copy unscheduled. An object merges key by key. A null value clears a nullable field. An array such as nodes replaces the copied array. Server-controlled fields such as id or state are rejected.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name for the copy, up to 300 characters. If you omit it, the copy takes the name of the source plus \&quot; (Copy)\&quot;. | [optional] 
**Description** | **string** | Optional journey description, up to 1024 characters. If you omit it, the copy takes the description of the source. Send null to clear it. | [optional] 
**Audience** | [**JourneyAudience**](JourneyAudience.md) |  | [optional] 
**EarlyExit** | [**JourneyEarlyExit**](JourneyEarlyExit.md) |  | [optional] 
**ReentryRules** | [**JourneyReentryRules**](JourneyReentryRules.md) |  | [optional] 
**Schedule** | [**JourneySchedule**](JourneySchedule.md) |  | [optional] 
**Nodes** | [**List&lt;JourneyNode&gt;**](JourneyNode.md) | Full ordered list of nodes. Replaces the copied graph. Server-assigned id fields are rejected. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

