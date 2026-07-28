# OneSignalApi.Model.ListAuditLogsSuccessResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuditLogs** | [**List&lt;AuditLogEvent&gt;**](AuditLogEvent.md) | Array of audit log events, ordered by occurred_at ascending. | [optional] 
**HasMore** | **bool** | True if additional events exist beyond this page. Use next_cursor to fetch the next page. | [optional] 
**NextCursor** | **string** | Opaque cursor to pass as cursor in the next request. Only present when has_more is true. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

