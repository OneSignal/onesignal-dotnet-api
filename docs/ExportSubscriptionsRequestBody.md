# OneSignalApi.Model.ExportSubscriptionsRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtraFields** | **List&lt;string&gt;** | Additional fields that you wish to include. Currently supports location, country, rooted, notification_types, ip, external_user_id, web_auth, and web_p256. | [optional] 
**LastActiveSince** | **string** | Export all devices with a last_active timestamp greater than this time.  Unixtime in seconds. | [optional] 
**SegmentName** | **string** | Export all devices belonging to the segment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

