# OneSignalApi.Model.UpdateTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Updated name of the template. | [optional] 
**Contents** | [**LanguageStringMap**](LanguageStringMap.md) |  | [optional] 
**Headings** | [**LanguageStringMap**](LanguageStringMap.md) |  | [optional] 
**Subtitle** | [**LanguageStringMap**](LanguageStringMap.md) |  | [optional] 
**IsEmail** | **bool** | Set true for an Email template. | [optional] 
**EmailSubject** | **string** | Subject of the email. | [optional] 
**EmailBody** | **string** | Body of the email (HTML supported). | [optional] 
**EmailBcc** | **List&lt;string&gt;** | BCC recipients for the email template. Maximum 5 addresses. Only supported when the email service provider is OneSignal Email. | [optional] 
**IsSMS** | **bool** | Set true for an SMS template. | [optional] 
**DynamicContent** | **string** | JSON string for dynamic content personalization. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

