# OneSignalApi.Model.UpdateSegmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Required. The segment name. Maximum 128 characters. | 
**Description** | **string** | Optional human-readable description for the segment. Maximum 255 characters. Pass an empty string to clear; omit to leave unchanged. | [optional] 
**Filters** | [**List&lt;FilterExpression&gt;**](FilterExpression.md) | Optional. When provided, replaces all existing filters. Filters define the segment based on user properties like tags, activity, or location using flexible AND/OR logic. Limited to 200 total entries, including fields and OR operators. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

