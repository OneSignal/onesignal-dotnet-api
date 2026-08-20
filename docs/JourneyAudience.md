# OneSignalApi.Model.JourneyAudience
The journey entry audience. The kind field selects which other fields apply.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | Audience kind. Selects which other fields apply. | 
**IncludedSegmentIds** | **List&lt;string&gt;** | segment audiences: Segment UUIDs whose users enter the journey. | [optional] 
**ExcludedSegmentIds** | **List&lt;string&gt;** | segment audiences: Segment UUIDs whose users are excluded. | [optional] 
**FutureAdditionsOnly** | **bool?** | segment audiences: when true, only users who newly match the segment after activation enter the journey. Defaults to false. | [optional] 
**Name** | **string** | event_trigger audiences: event name that triggers entry, up to 255 characters. | [optional] 
**Attributes** | **List&lt;List&lt;JourneyEventAttribute&gt;&gt;** | Event attribute matchers, as a list of condition groups. Send a single group whose conditions are AND&#39;d together. More than one group is rejected. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

