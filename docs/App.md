# OneSignalSDK.Server.Model.App

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [readonly] 
**Name** | **string** | The name of your app, as displayed on your apps list on the dashboard.  This can be renamed. | [optional] 
**Players** | **int** |  | [optional] [readonly] 
**MessageablePlayers** | **int** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**AndroidGcmSenderId** | **string** | Android: Your Google Project number.  Also known as Sender ID. | [optional] 
**GcmKey** | **string** | Android: Your Google Push Messaging Auth Key | [optional] 
**ChromeWebOrigin** | **string** | Chrome (All Browsers except Safari) (Recommended): The URL to your website.  This field is required if you wish to enable web push and specify other web push parameters. | [optional] 
**ChromeKey** | **string** | Not for web push.  Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions. | [optional] 
**ChromeWebDefaultNotificationIcon** | **string** | Chrome (All Browsers except Safari): Your default notification icon. Should be 256x256 pixels, min 80x80. | [optional] 
**ChromeWebSubDomain** | **string** | Chrome (All Browsers except Safari): A subdomain of your choice in order to support Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed. | [optional] 
**ApnsEnv** | **string** | iOS: Either sandbox or production | [optional] 
**ApnsP12** | **string** | iOS: Your apple push notification p12 certificate file, converted to a string and Base64 encoded. | [optional] 
**ApnsP12Password** | **string** | iOS: Required if using p12 certificate.  Password for the apns_p12 file. | [optional] 
**ApnsCertificates** | **string** |  | [optional] [readonly] 
**SafariApnsCertificates** | **string** |  | [optional] [readonly] 
**SafariApnsP12** | **string** | Safari: Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded. | [optional] 
**SafariApnsP12Password** | **string** | Safari: Password for safari_apns_p12 file | [optional] 
**SafariSiteOrigin** | **string** | Safari (Recommended): The hostname to your website including http(s):// | [optional] 
**SafariPushId** | **string** |  | [optional] [readonly] 
**SafariIcon1616** | **string** |  | [optional] [readonly] 
**SafariIcon3232** | **string** |  | [optional] [readonly] 
**SafariIcon6464** | **string** |  | [optional] [readonly] 
**SafariIcon128128** | **string** |  | [optional] [readonly] 
**SafariIcon256256** | **string** | Safari: A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide. | [optional] 
**SiteName** | **string** | All Browsers (Recommended): The Site Name. Requires both chrome_web_origin and safari_site_origin to be set to add or update it. | [optional] 
**BasicAuthKey** | **string** |  | [optional] [readonly] 
**OrganizationId** | **string** | The Id of the Organization you would like to add this app to. | [optional] 
**AdditionalDataIsRootPayload** | **bool** | iOS: Notification data (additional data) values will be added to the root of the apns payload when sent to the device.  Ignore if you&#39;re not using any other plugins, or not using OneSignal SDK methods to read the payload. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

