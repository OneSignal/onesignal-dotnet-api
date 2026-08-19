# OneSignalApi.Model.JourneyNode
A journey node. The kind field selects which other fields apply. Branching nodes (split_range, yes_no, wait_until) nest their sub-graphs inline via branches[].nodes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Server-assigned node UUID. Returned on reads. Required on update to keep an existing node. Rejected on create with a 400 validation error. | [optional] 
**Kind** | **string** | Node kind. Selects which other fields apply. | 
**ClientNodeId** | **string** | Optional client-assigned identifier, unique within the journey. Use it to reference this node from elsewhere in the same request. Persisted and returned on reads. | [optional] 
**Annotation** | **string** | Optional free-text label, up to 255 characters. Stored and returned as-is with no effect on journey behavior. | [optional] 
**DurationSeconds** | **int?** | wait nodes: seconds to hold the user. Minimum 60, maximum 31556952 (1 year). | [optional] 
**RelativeTo** | **string** | time_window nodes: schedule_in_timezone uses the configured windows; last_active_time holds relative to the user&#39;s last active time. | [optional] 
**Windows** | [**List&lt;JourneyTimeWindow&gt;**](JourneyTimeWindow.md) | time_window nodes: one or more time windows. A window with no day_of_week applies to every day. Required when relative_to is schedule_in_timezone; omit when it is last_active_time. | [optional] 
**TimeZone** | **string** | time_window nodes: IANA timezone identifier used when the user&#39;s timezone is unavailable. | [optional] 
**UseUserTimeZone** | **bool?** | time_window nodes: when true, uses the user&#39;s timezone if available. | [optional] 
**TemplateId** | **string** | send_push, send_email, and send_sms nodes: UUID of the template to send. | [optional] 
**IamId** | **string** | send_iam nodes: UUID of the in-app message to send. | [optional] 
**UserTtlSeconds** | **int?** | send_iam nodes: optional time-to-live for the in-app message, in seconds. | [optional] 
**WebhookId** | **string** | send_webhook nodes: UUID of the webhook to send. | [optional] 
**Assignments** | **Dictionary&lt;string, string&gt;** | tag nodes: tag key-value pairs to assign. An empty string value removes the tag. Keys are limited to 255 characters and values to 1024. | [optional] 
**RandomizeOnEntry** | **bool?** | split_range nodes: when true, assigns each user to a branch at random on entry. Defaults to false. | [optional] 
**Branches** | [**List&lt;JourneyBranch&gt;**](JourneyBranch.md) | Branching nodes: nested branches. split_range requires 2-20 weighted branches that sum to 100. yes_no requires exactly 2 branches. wait_until requires 1-10 condition branches. | [optional] 
**Expiration** | [**JourneyWaitUntilExpiration**](JourneyWaitUntilExpiration.md) |  | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

