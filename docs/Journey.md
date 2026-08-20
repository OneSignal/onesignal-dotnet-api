# OneSignalApi.Model.Journey
Full journey representation returned by the detail, create, and update endpoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Journey UUID. Read-only. | [optional] 
**AppId** | **string** | UUID of the app the journey belongs to. Read-only. | [optional] 
**Name** | **string** | Journey name, up to 300 characters. | [optional] 
**Description** | **string** | Journey description, up to 1024 characters. Defaults to an empty string. | [optional] 
**State** | **string** | Journey state. New journeys are created as draft. processing is transient while activation is in progress. archived is a journey that has been stopped. Change it through the state field on Update journey. | [optional] 
**CreatedAt** | **string** | ISO 8601 creation time. Read-only. | [optional] 
**UpdatedAt** | **string** | ISO 8601 last-update time. Read-only. | [optional] 
**StartedAt** | **string** | ISO 8601 time the journey was activated, or null. Read-only. May stay null briefly after you set state to active: activation is enqueued, and started_at populates once the journey finishes processing. | [optional] 
**ArchivedAt** | **string** | ISO 8601 time the journey was archived, or null. Read-only. | [optional] 
**CreatedSource** | **string** | Origin of the journey, for example public_api or dashboard. Read-only. | [optional] 
**Audience** | [**JourneyAudience**](JourneyAudience.md) |  | [optional] 
**EarlyExit** | [**JourneyEarlyExit**](JourneyEarlyExit.md) |  | [optional] 
**ReentryRules** | [**JourneyReentryRules**](JourneyReentryRules.md) |  | [optional] 
**Schedule** | [**JourneySchedule**](JourneySchedule.md) |  | [optional] 
**Nodes** | [**List&lt;JourneyNode&gt;**](JourneyNode.md) | Ordered list of journey nodes. | [optional] 
**ConcurrencyKey** | **string** | Opaque optimistic-concurrency token. Read-only. Pass it back on update to guard against overwriting a concurrent change (409). Send it back exactly as read; do not construct or parse it. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

