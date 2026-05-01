# OneSignalApi - the C# library for OneSignal

A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com

- API version: 5.4.0
- SDK version: 5.5.1

## Installation

```bash
dotnet add package OneSignalApi
```

## Configuration

Every SDK requires authentication via API keys. Two key types are available:

- **REST API Key** — required for most endpoints (sending notifications, managing users, etc.). Found in your app's **Settings > Keys & IDs**.
- **Organization API Key** — only required for organization-level endpoints like creating or listing apps. Found in **Organization Settings**.

> **Warning:** Store your API keys in environment variables or a secrets manager. Never commit them to source control.

```csharp
using OneSignalApi.Api;
using OneSignalApi.Client;

var config = new Configuration();
config.BasePath = "https://api.onesignal.com";
config.AccessToken = "YOUR_REST_API_KEY";

var client = new DefaultApi(config);
```

## Send a push notification

```csharp
using OneSignalApi.Model;

var notification = new Notification(appId: "YOUR_APP_ID")
{
    Contents = new StringMap(en: "Hello from OneSignal!"),
    Headings = new StringMap(en: "Push Notification"),
    IncludedSegments = new List<string> { "Subscribed Users" }
};

var response = client.CreateNotification(notification);
Console.WriteLine("Notification ID: " + response.Id);
```

## Send an email

```csharp
var notification = new Notification(appId: "YOUR_APP_ID")
{
    EmailSubject = "Important Update",
    EmailBody = "<h1>Hello!</h1><p>This is an HTML email.</p>",
    IncludedSegments = new List<string> { "Subscribed Users" },
    ChannelForExternalUserIds = "email"
};

var response = client.CreateNotification(notification);
```

## Send an SMS

```csharp
var notification = new Notification(appId: "YOUR_APP_ID")
{
    Contents = new StringMap(en: "Your SMS message content here"),
    IncludedSegments = new List<string> { "Subscribed Users" },
    ChannelForExternalUserIds = "sms",
    SmsFrom = "+15551234567"
};

var response = client.CreateNotification(notification);
```

## Full API reference

The complete list of API endpoints and their parameters is available in the [DefaultApi documentation](https://github.com/OneSignal/onesignal-dotnet-api/blob/main/docs/DefaultApi.md).

For the underlying REST API, see the [OneSignal API reference](https://documentation.onesignal.com/reference).
