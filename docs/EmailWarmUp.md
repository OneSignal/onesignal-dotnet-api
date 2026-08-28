# OneSignalApi.Model.EmailWarmUp
Channel: Email Present only when this notification's `kind` is \"warmup\". The Auto Warm Up campaign's stage schedule, scheduling strategy, and live status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Stages** | [**List&lt;EmailWarmUpStage&gt;**](EmailWarmUpStage.md) | The campaign&#39;s sending schedule, stage by stage. | [optional] 
**Strategy** | **string** | How the stage schedule was produced:   * &#x60;recommended&#x60; - OneSignal generated (and may still adjust) the schedule based on past delivery volumes, scheduled Auto Warm Up emails, and the size of the current audience.   * &#x60;custom&#x60; - The stages were provided as-is in the create request.  | [optional] 
**Status** | **string** | Current status of the campaign:   * &#x60;initializing&#x60; - The stages have been submitted and the schedule is being set up.   * &#x60;draft&#x60; - The campaign has been created but has not started sending.   * &#x60;active&#x60; - The campaign is currently working through its stages.   * &#x60;finished&#x60; - All stages have completed.   * &#x60;canceled&#x60; - The campaign was canceled before finishing.  | [optional] 
**IsLive** | **bool** | Whether the campaign is currently live (actively sending). | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

