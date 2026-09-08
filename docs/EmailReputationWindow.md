# OneSignalApi.Model.EmailReputationWindow
Email reputation rates for a single time window. Each rate is a fraction of successfully delivered emails (for example, `0.02` means 2%). Both rates are `0` when no email was successfully delivered in the window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BounceRate** | **double** | The fraction of successfully delivered emails that hard or soft bounced during the window. | [optional] 
**ComplaintRate** | **double** | The fraction of successfully delivered emails that recipients reported as spam during the window. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

