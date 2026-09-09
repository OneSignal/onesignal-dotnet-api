# OneSignalApi.Model.EmailReputationResponse
App-wide email bounce and spam complaint rates, broken out by time window. `last_24_hours`, `last_7_days`, and `last_30_days` each hold the bounce and complaint rates for email delivered in that window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Last24Hours** | [**EmailReputationWindow**](EmailReputationWindow.md) |  | [optional] 
**Last7Days** | [**EmailReputationWindow**](EmailReputationWindow.md) |  | [optional] 
**Last30Days** | [**EmailReputationWindow**](EmailReputationWindow.md) |  | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

