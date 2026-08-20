# OneSignalApi.Model.JourneyMessageStats
Delivery stats for a message-sending node. Present only on send_push, send_email, send_sms, send_iam, and send_webhook nodes. The keys inside totals depend on the node's channel.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Totals** | **Dictionary&lt;string, decimal&gt;** | All-time totals for this node, keyed by channel-specific stat name. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

