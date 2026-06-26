# AGENTS.md — OneSignal .NET SDK

Integration guide for AI agents and LLMs using `OneSignalApi`, the OneSignal server SDK for .NET. Human-oriented docs are in the [README](./README.md).

## What this SDK does

Server-side access to the OneSignal REST API: send push / email / SMS, manage users, subscriptions, segments, templates and live activities, and administer apps & API keys.

- NuGet package: `OneSignalApi`
- Repository: https://github.com/OneSignal/onesignal-dotnet-api

## Install

```sh
dotnet add package OneSignalApi
```

## Authentication — two key types

OneSignal uses two bearer credentials; each endpoint requires a specific one:

- **REST API key** — used by almost every endpoint (notifications, users, subscriptions, segments, templates, live activities, custom events). Found in **App Settings → Keys & IDs**.
- **Organization API key** — required *only* for organization-level endpoints: app management (list / create / get / update apps), API-key management (view / create / update / rotate / delete API keys), and copying a template to another app. Found in **Organization Settings**.

> **.NET caveat:** the SDK sends `Configuration.AccessToken` as the bearer for every request — a single client can't hold both keys. Use one `DefaultApi` configured with your REST API key for app-level endpoints, and a **second** `DefaultApi` configured with your Organization API key for the organization-level endpoints above.

Never hard-code keys — read them from environment variables or a secrets manager.

```csharp
using OneSignalApi.Api;
using OneSignalApi.Client;

var restConfig = new Configuration
{
    BasePath = "https://api.onesignal.com",
    AccessToken = Environment.GetEnvironmentVariable("ONESIGNAL_REST_API_KEY"),
};
var client = new DefaultApi(restConfig);

// Organization-level endpoints need a second client:
var orgConfig = new Configuration
{
    BasePath = "https://api.onesignal.com",
    AccessToken = Environment.GetEnvironmentVariable("ONESIGNAL_ORGANIZATION_API_KEY"),
};
var orgClient = new DefaultApi(orgConfig);
```

## Calling convention

Methods take **positional arguments**. Build the model object and pass it directly — do **not** wrap arguments in a request/options object.

```csharp
var notification = new Notification
{
    AppId = "YOUR_APP_ID",
    Contents = new LanguageStringMap(en: "Hello from OneSignal!"),
    IncludeAliases = new Dictionary<string, List<string>>
    {
        { "external_id", new List<string> { "YOUR_USER_EXTERNAL_ID" } }
    },
    TargetChannel = Notification.TargetChannelEnum.Push,
};

CreateNotificationSuccessResponse response = client.CreateNotification(notification);
```

## Idempotent sends & retries

Set `idempotency_key` (a UUID) so a create-notification request can be safely retried — the server returns the original result instead of sending twice. The `CreateNotificationWithRetry` helper handles this for you: it generates an `idempotency_key` when absent, retries `429` / `503` / transport errors with the **same** key (honoring `Retry-After`), and reports via `WasReplayed` whether the server answered from a previously completed request.

```csharp
NotificationHelpers.CreateNotificationWithRetryResult result =
    client.CreateNotificationWithRetry(notification, maxRetries: 5, baseDelayMs: 1000);
Console.WriteLine($"id: {result.Response.Id} replayed: {result.WasReplayed}");
```

> The notification-level `external_id` field is the **deprecated** idempotency mechanism — prefer `idempotency_key`. Don't confuse it with the `external_id` **alias label** (under `include_aliases`) used to target users.

## Full API reference

- [DefaultApi.md](https://github.com/OneSignal/onesignal-dotnet-api/blob/main/docs/DefaultApi.md) — every endpoint, parameter, and model, with runnable examples.
- [OneSignal REST API reference](https://documentation.onesignal.com/reference)
