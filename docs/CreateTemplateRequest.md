# OneSignalApi.Model.CreateTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **string** | Your OneSignal App ID in UUID v4 format. | 
**Name** | **string** | Name of the template. | 
**Contents** | [**LanguageStringMap**](LanguageStringMap.md) |  | 
**Headings** | [**LanguageStringMap**](LanguageStringMap.md) |  | [optional] 
**Subtitle** | [**LanguageStringMap**](LanguageStringMap.md) |  | [optional] 
**IsEmail** | **bool** | Set true for an Email template. | [optional] 
**EmailSubject** | **string** | Subject of the email. | [optional] 
**EmailBody** | **string** | Body of the email (HTML supported). | [optional] 
**IsSMS** | **bool** | Set true for an SMS template. | [optional] 
**DynamicContent** | **string** | JSON string for dynamic content personalization. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

