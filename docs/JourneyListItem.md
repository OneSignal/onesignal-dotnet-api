# OneSignalApi.Model.JourneyListItem
Summary journey representation returned by the list endpoint. Excludes description, nodes, early-exit configuration, and concurrency_key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Journey UUID. Read-only. | [optional] 
**AppId** | **string** | UUID of the app the journey belongs to. Read-only. | [optional] 
**Name** | **string** | Journey name, up to 300 characters. | [optional] 
**State** | **string** | Journey state. New journeys are created as draft. processing is transient while activation is in progress. archived is a journey that has been stopped. Change it through the state field on Update journey. | [optional] 
**CreatedAt** | **string** | ISO 8601 creation time. Read-only. | [optional] 
**UpdatedAt** | **string** | ISO 8601 last-update time. Read-only. | [optional] 
**StartedAt** | **string** | ISO 8601 time the journey was activated, or null. Read-only. | [optional] 
**ArchivedAt** | **string** | ISO 8601 time the journey was archived, or null. Read-only. | [optional] 
**CreatedSource** | **string** | Origin of the journey, for example public_api or dashboard. Read-only. | [optional] 
**Schedule** | [**JourneySchedule**](JourneySchedule.md) |  | [optional] 
**Audience** | [**JourneyListAudience**](JourneyListAudience.md) |  | [optional] 
**ReentryRules** | [**JourneyReentryRules**](JourneyReentryRules.md) |  | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

