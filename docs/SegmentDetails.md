# OneSignalApi.Model.SegmentDetails
Segment details. Only included when the include-segment-detail query parameter is set to true.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the segment (UUID v4). | [optional] 
**Name** | **string** | The segment name. | [optional] 
**Description** | **string** | Human-readable description for the segment. &#x60;null&#x60; when unset. Maximum 255 characters. | [optional] 
**CreatedAt** | **int** | Unix timestamp when the segment was created. | [optional] 
**Source** | **string** | The source of the segment. | [optional] 
**Filters** | [**List&lt;FilterExpression&gt;**](FilterExpression.md) | Array of filter and operator objects defining the segment criteria. Uses the same format as the Create Segment API, so filters can be directly used to recreate or update the segment. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

