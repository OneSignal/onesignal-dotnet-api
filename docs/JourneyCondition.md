# OneSignalApi.Model.JourneyCondition
A branch condition. The kind field selects which other fields apply.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | Condition kind. Selects which other fields apply. | 
**IncludedSegmentIds** | **List&lt;string&gt;** | segment_membership conditions: Segment UUIDs the user must belong to. | [optional] 
**ExcludedSegmentIds** | **List&lt;string&gt;** | segment_membership conditions: Segment UUIDs the user must not belong to. | [optional] 
**Action** | **string** | on_notification_action conditions: the notification action to branch on. Which actions apply depends on the sending node&#39;s channel. | [optional] 
**SendingNodeId** | **string** | on_notification_action conditions: id of the sending node this action refers to. Returned on reads; accepted on write. | [optional] 
**ClientNodeId** | **string** | on_notification_action conditions: write-only alternative to sending_node_id. References the sending node by its client_node_id. | [optional] 
**Name** | **string** | event_trigger conditions: event name, up to 255 characters. | [optional] 
**Attributes** | **List&lt;List&lt;JourneyEventAttribute&gt;&gt;** | Event attribute matchers, as a list of condition groups. Send a single group whose conditions are AND&#39;d together. More than one group is rejected. | [optional] 
**EntryEventMatchAttributes** | **List&lt;Object&gt;** | event_trigger conditions: match incoming event properties against the journey&#39;s entry event. Only valid on event-triggered journeys. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

