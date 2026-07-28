# OneSignalApi.Model.AuditLogEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The action that was performed (e.g. notification.sent, segment.created, member.invited). | [optional] 
**Actor** | [**AuditLogActor**](AuditLogActor.md) |  | [optional] 
**AppId** | **string** | UUID of the app the event is associated with. Absent for org-level events. | [optional] 
**Context** | [**AuditLogContext**](AuditLogContext.md) |  | [optional] 
**Id** | **string** | UUID of the audit log event. | [optional] 
**Metadata** | **Object** | Additional event-specific data that does not fit into the standard fields. | [optional] 
**OccurredAt** | **string** | RFC 3339 timestamp of when the event occurred (e.g. 2026-02-18T12:34:56Z). | [optional] 
**OrganizationId** | **string** | UUID of the organization the event belongs to. | [optional] 
**Targets** | [**List&lt;AuditLogTarget&gt;**](AuditLogTarget.md) | The resources the action was performed on. May be empty for org-level events. | [optional] 
**_Version** | **int** | Schema version of the event payload. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

