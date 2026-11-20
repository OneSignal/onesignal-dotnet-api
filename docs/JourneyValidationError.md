# OneSignalApi.Model.JourneyValidationError

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Stable, kebab-case error identifier. Always &#x60;invalid-payload&#x60; for validation failures. | [optional] 
**Title** | **string** | Human-readable message. Wording may change between releases. | [optional] 
**Meta** | **Dictionary&lt;string, Object&gt;** | Structured context. Always includes &#x60;attribute&#x60; (the field, or &#x60;base&#x60; for request-level errors); may also include &#x60;path&#x60;, &#x60;node_id&#x60;, or &#x60;client_node_id&#x60;. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

