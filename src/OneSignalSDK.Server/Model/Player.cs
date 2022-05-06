/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: devrel@onesignal.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OneSignalSDK.Server.Client.OpenAPIDateConverter;

namespace OneSignalSDK.Server.Model
{
    /// <summary>
    /// Player
    /// </summary>
    [DataContract(Name = "Player")]
    public partial class Player : IEquatable<Player>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Player() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="appId">appId.</param>
        /// <param name="deviceType">Required The device&#39;s platform:   0 &#x3D; iOS   1 &#x3D; Android   2 &#x3D; Amazon   3 &#x3D; WindowsPhone (MPNS)   4 &#x3D; Chrome Apps / Extensions   5 &#x3D; Chrome Web Push   6 &#x3D; Windows (WNS)   7 &#x3D; Safari   8 &#x3D; Firefox   9 &#x3D; MacOS   10 &#x3D; Alexa   11 &#x3D; Email   13 &#x3D; For Huawei App Gallery Builds SDK Setup. Not for Huawei Devices using FCM   14 &#x3D; SMS  (required).</param>
        /// <param name="externalUserId">a custom user ID.</param>
        /// <param name="externalUserIdAuthHash">Only required if you have enabled Identity Verification and device_type is NOT 11 email..</param>
        /// <param name="emailAuthHash">Email - Only required if you have enabled Identity Verification and device_type is email (11)..</param>
        /// <param name="identifier">Recommended: For Push Notifications, this is the Push Token Identifier from Google or Apple. For Apple Push identifiers, you must strip all non alphanumeric characters. Examples: iOS: 7abcd558f29d0b1f048083e2834ad8ea4b3d87d8ad9c088b33c132706ff445f0 Android: APA91bHbYHk7aq-Uam_2pyJ2qbZvqllyyh2wjfPRaw5gLEX2SUlQBRvOc6sck1sa7H7nGeLNlDco8lXj83HWWwzV... For Email Addresses, set the full email address email@email.com and make sure to set device_type to 11. .</param>
        /// <param name="language">Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en .</param>
        /// <param name="timezone">Number of seconds away from UTC. Example: -28800 .</param>
        /// <param name="gameVersion">Version of your app. Example: 1.1 .</param>
        /// <param name="deviceModel">Device make and model. Example: iPhone5,1 .</param>
        /// <param name="deviceOs">Device operating system version. Example: 7.0.4 .</param>
        /// <param name="adId">The ad id for the device&#39;s platform: Android &#x3D; Advertising Id iOS &#x3D; identifierForVendor WP8.0 &#x3D; DeviceUniqueId WP8.1 &#x3D; AdvertisingId .</param>
        /// <param name="sdk">Name and version of the sdk/plugin that&#39;s calling this API method (if any).</param>
        /// <param name="sessionCount">Number of times the user has played the game, defaults to 1.</param>
        /// <param name="tags">Custom tags for the player. Only support string and integer key value pairs. Does not support arrays or other nested objects. Setting a tag value to null or an empty string will remove the tag. Example: {\&quot;foo\&quot;:\&quot;bar\&quot;,\&quot;this\&quot;:\&quot;that\&quot;} Limitations: - 100 tags per call - Android SDK users: tags cannot be removed or changed via API if set through SDK sendTag methods. Recommended to only tag devices with 1 kilobyte of data Please consider using your own Database to save more than 1 kilobyte of data. See: Internal Database &amp; CRM .</param>
        /// <param name="amountSpent">Amount the user has spent in USD, up to two decimal places.</param>
        /// <param name="createdAt">Unixtime when the player joined the game.</param>
        /// <param name="playtime">Seconds player was running your app..</param>
        /// <param name="badgeCount">Current iOS badge count displayed on the app icon NOTE: Not supported for apps created after June 2018, since badge count for apps created after this date are handled on the client. .</param>
        /// <param name="lastActive">Unixtime when the player was last active.</param>
        /// <param name="notificationTypes">1 &#x3D; subscribed -2 &#x3D; unsubscribed iOS - These values are set each time the user opens the app from the SDK. Use the SDK function set Subscription instead. Android - You may set this but you can no longer use the SDK method setSubscription later in your app as it will create synchronization issues. .</param>
        /// <param name="testType">This is used in deciding whether to use your iOS Sandbox or Production push certificate when sending a push when both have been uploaded. Set to the iOS provisioning profile that was used to build your app. 1 &#x3D; Development 2 &#x3D; Ad-Hoc Omit this field for App Store builds. .</param>
        /// <param name="_long">Longitude of the device, used for geotagging to segment on..</param>
        /// <param name="lat">Latitude of the device, used for geotagging to segment on..</param>
        /// <param name="country">Country code in the ISO 3166-1 Alpha 2 format.</param>
        public Player(string appId = default(string), int deviceType = default(int), string externalUserId = default(string), string externalUserIdAuthHash = default(string), string emailAuthHash = default(string), string identifier = default(string), string language = default(string), int? timezone = default(int?), string gameVersion = default(string), string deviceModel = default(string), string deviceOs = default(string), string adId = default(string), string sdk = default(string), int sessionCount = default(int), Object tags = default(Object), string amountSpent = default(string), long createdAt = default(long), long playtime = default(long), int badgeCount = default(int), int lastActive = default(int), int notificationTypes = default(int), int? testType = default(int?), decimal _long = default(decimal), decimal lat = default(decimal), string country = default(string))
        {
            this.DeviceType = deviceType;
            this.AppId = appId;
            this.ExternalUserId = externalUserId;
            this.ExternalUserIdAuthHash = externalUserIdAuthHash;
            this.EmailAuthHash = emailAuthHash;
            this.Identifier = identifier;
            this.Language = language;
            this.Timezone = timezone;
            this.GameVersion = gameVersion;
            this.DeviceModel = deviceModel;
            this.DeviceOs = deviceOs;
            this.AdId = adId;
            this.Sdk = sdk;
            this.SessionCount = sessionCount;
            this.Tags = tags;
            this.AmountSpent = amountSpent;
            this.CreatedAt = createdAt;
            this.Playtime = playtime;
            this.BadgeCount = badgeCount;
            this.LastActive = lastActive;
            this.NotificationTypes = notificationTypes;
            this.TestType = testType;
            this.Long = _long;
            this.Lat = lat;
            this.Country = country;
        }

        /// <summary>
        /// The device&#39;s OneSignal ID
        /// </summary>
        /// <value>The device&#39;s OneSignal ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// If true, this is the equivalent of a user being Unsubscribed
        /// </summary>
        /// <value>If true, this is the equivalent of a user being Unsubscribed</value>
        [DataMember(Name = "invalid_identifier", EmitDefaultValue = true)]
        public bool InvalidIdentifier { get; private set; }

        /// <summary>
        /// Returns false as InvalidIdentifier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvalidIdentifier()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name = "app_id", EmitDefaultValue = false)]
        public string AppId { get; set; }

        /// <summary>
        /// Required The device&#39;s platform:   0 &#x3D; iOS   1 &#x3D; Android   2 &#x3D; Amazon   3 &#x3D; WindowsPhone (MPNS)   4 &#x3D; Chrome Apps / Extensions   5 &#x3D; Chrome Web Push   6 &#x3D; Windows (WNS)   7 &#x3D; Safari   8 &#x3D; Firefox   9 &#x3D; MacOS   10 &#x3D; Alexa   11 &#x3D; Email   13 &#x3D; For Huawei App Gallery Builds SDK Setup. Not for Huawei Devices using FCM   14 &#x3D; SMS 
        /// </summary>
        /// <value>Required The device&#39;s platform:   0 &#x3D; iOS   1 &#x3D; Android   2 &#x3D; Amazon   3 &#x3D; WindowsPhone (MPNS)   4 &#x3D; Chrome Apps / Extensions   5 &#x3D; Chrome Web Push   6 &#x3D; Windows (WNS)   7 &#x3D; Safari   8 &#x3D; Firefox   9 &#x3D; MacOS   10 &#x3D; Alexa   11 &#x3D; Email   13 &#x3D; For Huawei App Gallery Builds SDK Setup. Not for Huawei Devices using FCM   14 &#x3D; SMS </value>
        [DataMember(Name = "device_type", IsRequired = true, EmitDefaultValue = false)]
        public int DeviceType { get; set; }

        /// <summary>
        /// a custom user ID
        /// </summary>
        /// <value>a custom user ID</value>
        [DataMember(Name = "external_user_id", EmitDefaultValue = false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Only required if you have enabled Identity Verification and device_type is NOT 11 email.
        /// </summary>
        /// <value>Only required if you have enabled Identity Verification and device_type is NOT 11 email.</value>
        [DataMember(Name = "external_user_id_auth_hash", EmitDefaultValue = false)]
        public string ExternalUserIdAuthHash { get; set; }

        /// <summary>
        /// Email - Only required if you have enabled Identity Verification and device_type is email (11).
        /// </summary>
        /// <value>Email - Only required if you have enabled Identity Verification and device_type is email (11).</value>
        [DataMember(Name = "email_auth_hash", EmitDefaultValue = false)]
        public string EmailAuthHash { get; set; }

        /// <summary>
        /// Recommended: For Push Notifications, this is the Push Token Identifier from Google or Apple. For Apple Push identifiers, you must strip all non alphanumeric characters. Examples: iOS: 7abcd558f29d0b1f048083e2834ad8ea4b3d87d8ad9c088b33c132706ff445f0 Android: APA91bHbYHk7aq-Uam_2pyJ2qbZvqllyyh2wjfPRaw5gLEX2SUlQBRvOc6sck1sa7H7nGeLNlDco8lXj83HWWwzV... For Email Addresses, set the full email address email@email.com and make sure to set device_type to 11. 
        /// </summary>
        /// <value>Recommended: For Push Notifications, this is the Push Token Identifier from Google or Apple. For Apple Push identifiers, you must strip all non alphanumeric characters. Examples: iOS: 7abcd558f29d0b1f048083e2834ad8ea4b3d87d8ad9c088b33c132706ff445f0 Android: APA91bHbYHk7aq-Uam_2pyJ2qbZvqllyyh2wjfPRaw5gLEX2SUlQBRvOc6sck1sa7H7nGeLNlDco8lXj83HWWwzV... For Email Addresses, set the full email address email@email.com and make sure to set device_type to 11. </value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en 
        /// </summary>
        /// <value>Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en </value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Number of seconds away from UTC. Example: -28800 
        /// </summary>
        /// <value>Number of seconds away from UTC. Example: -28800 </value>
        [DataMember(Name = "timezone", EmitDefaultValue = true)]
        public int? Timezone { get; set; }

        /// <summary>
        /// Version of your app. Example: 1.1 
        /// </summary>
        /// <value>Version of your app. Example: 1.1 </value>
        [DataMember(Name = "game_version", EmitDefaultValue = false)]
        public string GameVersion { get; set; }

        /// <summary>
        /// Device make and model. Example: iPhone5,1 
        /// </summary>
        /// <value>Device make and model. Example: iPhone5,1 </value>
        [DataMember(Name = "device_model", EmitDefaultValue = false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Device operating system version. Example: 7.0.4 
        /// </summary>
        /// <value>Device operating system version. Example: 7.0.4 </value>
        [DataMember(Name = "device_os", EmitDefaultValue = false)]
        public string DeviceOs { get; set; }

        /// <summary>
        /// The ad id for the device&#39;s platform: Android &#x3D; Advertising Id iOS &#x3D; identifierForVendor WP8.0 &#x3D; DeviceUniqueId WP8.1 &#x3D; AdvertisingId 
        /// </summary>
        /// <value>The ad id for the device&#39;s platform: Android &#x3D; Advertising Id iOS &#x3D; identifierForVendor WP8.0 &#x3D; DeviceUniqueId WP8.1 &#x3D; AdvertisingId </value>
        [DataMember(Name = "ad_id", EmitDefaultValue = false)]
        public string AdId { get; set; }

        /// <summary>
        /// Name and version of the sdk/plugin that&#39;s calling this API method (if any)
        /// </summary>
        /// <value>Name and version of the sdk/plugin that&#39;s calling this API method (if any)</value>
        [DataMember(Name = "sdk", EmitDefaultValue = false)]
        public string Sdk { get; set; }

        /// <summary>
        /// Number of times the user has played the game, defaults to 1
        /// </summary>
        /// <value>Number of times the user has played the game, defaults to 1</value>
        [DataMember(Name = "session_count", EmitDefaultValue = false)]
        public int SessionCount { get; set; }

        /// <summary>
        /// Custom tags for the player. Only support string and integer key value pairs. Does not support arrays or other nested objects. Setting a tag value to null or an empty string will remove the tag. Example: {\&quot;foo\&quot;:\&quot;bar\&quot;,\&quot;this\&quot;:\&quot;that\&quot;} Limitations: - 100 tags per call - Android SDK users: tags cannot be removed or changed via API if set through SDK sendTag methods. Recommended to only tag devices with 1 kilobyte of data Please consider using your own Database to save more than 1 kilobyte of data. See: Internal Database &amp; CRM 
        /// </summary>
        /// <value>Custom tags for the player. Only support string and integer key value pairs. Does not support arrays or other nested objects. Setting a tag value to null or an empty string will remove the tag. Example: {\&quot;foo\&quot;:\&quot;bar\&quot;,\&quot;this\&quot;:\&quot;that\&quot;} Limitations: - 100 tags per call - Android SDK users: tags cannot be removed or changed via API if set through SDK sendTag methods. Recommended to only tag devices with 1 kilobyte of data Please consider using your own Database to save more than 1 kilobyte of data. See: Internal Database &amp; CRM </value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Object Tags { get; set; }

        /// <summary>
        /// Amount the user has spent in USD, up to two decimal places
        /// </summary>
        /// <value>Amount the user has spent in USD, up to two decimal places</value>
        [DataMember(Name = "amount_spent", EmitDefaultValue = false)]
        public string AmountSpent { get; set; }

        /// <summary>
        /// Unixtime when the player joined the game
        /// </summary>
        /// <value>Unixtime when the player joined the game</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Seconds player was running your app.
        /// </summary>
        /// <value>Seconds player was running your app.</value>
        [DataMember(Name = "playtime", EmitDefaultValue = false)]
        public long Playtime { get; set; }

        /// <summary>
        /// Current iOS badge count displayed on the app icon NOTE: Not supported for apps created after June 2018, since badge count for apps created after this date are handled on the client. 
        /// </summary>
        /// <value>Current iOS badge count displayed on the app icon NOTE: Not supported for apps created after June 2018, since badge count for apps created after this date are handled on the client. </value>
        [DataMember(Name = "badge_count", EmitDefaultValue = false)]
        public int BadgeCount { get; set; }

        /// <summary>
        /// Unixtime when the player was last active
        /// </summary>
        /// <value>Unixtime when the player was last active</value>
        [DataMember(Name = "last_active", EmitDefaultValue = false)]
        public int LastActive { get; set; }

        /// <summary>
        /// 1 &#x3D; subscribed -2 &#x3D; unsubscribed iOS - These values are set each time the user opens the app from the SDK. Use the SDK function set Subscription instead. Android - You may set this but you can no longer use the SDK method setSubscription later in your app as it will create synchronization issues. 
        /// </summary>
        /// <value>1 &#x3D; subscribed -2 &#x3D; unsubscribed iOS - These values are set each time the user opens the app from the SDK. Use the SDK function set Subscription instead. Android - You may set this but you can no longer use the SDK method setSubscription later in your app as it will create synchronization issues. </value>
        [DataMember(Name = "notification_types", EmitDefaultValue = false)]
        public int NotificationTypes { get; set; }

        /// <summary>
        /// This is used in deciding whether to use your iOS Sandbox or Production push certificate when sending a push when both have been uploaded. Set to the iOS provisioning profile that was used to build your app. 1 &#x3D; Development 2 &#x3D; Ad-Hoc Omit this field for App Store builds. 
        /// </summary>
        /// <value>This is used in deciding whether to use your iOS Sandbox or Production push certificate when sending a push when both have been uploaded. Set to the iOS provisioning profile that was used to build your app. 1 &#x3D; Development 2 &#x3D; Ad-Hoc Omit this field for App Store builds. </value>
        [DataMember(Name = "test_type", EmitDefaultValue = true)]
        public int? TestType { get; set; }

        /// <summary>
        /// Longitude of the device, used for geotagging to segment on.
        /// </summary>
        /// <value>Longitude of the device, used for geotagging to segment on.</value>
        [DataMember(Name = "long", EmitDefaultValue = false)]
        public decimal Long { get; set; }

        /// <summary>
        /// Latitude of the device, used for geotagging to segment on.
        /// </summary>
        /// <value>Latitude of the device, used for geotagging to segment on.</value>
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public decimal Lat { get; set; }

        /// <summary>
        /// Country code in the ISO 3166-1 Alpha 2 format
        /// </summary>
        /// <value>Country code in the ISO 3166-1 Alpha 2 format</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Player {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvalidIdentifier: ").Append(InvalidIdentifier).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
            sb.Append("  ExternalUserIdAuthHash: ").Append(ExternalUserIdAuthHash).Append("\n");
            sb.Append("  EmailAuthHash: ").Append(EmailAuthHash).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  GameVersion: ").Append(GameVersion).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DeviceOs: ").Append(DeviceOs).Append("\n");
            sb.Append("  AdId: ").Append(AdId).Append("\n");
            sb.Append("  Sdk: ").Append(Sdk).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  AmountSpent: ").Append(AmountSpent).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Playtime: ").Append(Playtime).Append("\n");
            sb.Append("  BadgeCount: ").Append(BadgeCount).Append("\n");
            sb.Append("  LastActive: ").Append(LastActive).Append("\n");
            sb.Append("  NotificationTypes: ").Append(NotificationTypes).Append("\n");
            sb.Append("  TestType: ").Append(TestType).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Player);
        }

        /// <summary>
        /// Returns true if Player instances are equal
        /// </summary>
        /// <param name="input">Instance of Player to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Player input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvalidIdentifier == input.InvalidIdentifier ||
                    this.InvalidIdentifier.Equals(input.InvalidIdentifier)
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    this.DeviceType.Equals(input.DeviceType)
                ) && 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
                ) && 
                (
                    this.ExternalUserIdAuthHash == input.ExternalUserIdAuthHash ||
                    (this.ExternalUserIdAuthHash != null &&
                    this.ExternalUserIdAuthHash.Equals(input.ExternalUserIdAuthHash))
                ) && 
                (
                    this.EmailAuthHash == input.EmailAuthHash ||
                    (this.EmailAuthHash != null &&
                    this.EmailAuthHash.Equals(input.EmailAuthHash))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.GameVersion == input.GameVersion ||
                    (this.GameVersion != null &&
                    this.GameVersion.Equals(input.GameVersion))
                ) && 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.DeviceOs == input.DeviceOs ||
                    (this.DeviceOs != null &&
                    this.DeviceOs.Equals(input.DeviceOs))
                ) && 
                (
                    this.AdId == input.AdId ||
                    (this.AdId != null &&
                    this.AdId.Equals(input.AdId))
                ) && 
                (
                    this.Sdk == input.Sdk ||
                    (this.Sdk != null &&
                    this.Sdk.Equals(input.Sdk))
                ) && 
                (
                    this.SessionCount == input.SessionCount ||
                    this.SessionCount.Equals(input.SessionCount)
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.AmountSpent == input.AmountSpent ||
                    (this.AmountSpent != null &&
                    this.AmountSpent.Equals(input.AmountSpent))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Playtime == input.Playtime ||
                    this.Playtime.Equals(input.Playtime)
                ) && 
                (
                    this.BadgeCount == input.BadgeCount ||
                    this.BadgeCount.Equals(input.BadgeCount)
                ) && 
                (
                    this.LastActive == input.LastActive ||
                    this.LastActive.Equals(input.LastActive)
                ) && 
                (
                    this.NotificationTypes == input.NotificationTypes ||
                    this.NotificationTypes.Equals(input.NotificationTypes)
                ) && 
                (
                    this.TestType == input.TestType ||
                    (this.TestType != null &&
                    this.TestType.Equals(input.TestType))
                ) && 
                (
                    this.Long == input.Long ||
                    this.Long.Equals(input.Long)
                ) && 
                (
                    this.Lat == input.Lat ||
                    this.Lat.Equals(input.Lat)
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvalidIdentifier.GetHashCode();
                if (this.AppId != null)
                {
                    hashCode = (hashCode * 59) + this.AppId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                if (this.ExternalUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUserId.GetHashCode();
                }
                if (this.ExternalUserIdAuthHash != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUserIdAuthHash.GetHashCode();
                }
                if (this.EmailAuthHash != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAuthHash.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                }
                if (this.GameVersion != null)
                {
                    hashCode = (hashCode * 59) + this.GameVersion.GetHashCode();
                }
                if (this.DeviceModel != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceModel.GetHashCode();
                }
                if (this.DeviceOs != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceOs.GetHashCode();
                }
                if (this.AdId != null)
                {
                    hashCode = (hashCode * 59) + this.AdId.GetHashCode();
                }
                if (this.Sdk != null)
                {
                    hashCode = (hashCode * 59) + this.Sdk.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SessionCount.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.AmountSpent != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSpent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.Playtime.GetHashCode();
                hashCode = (hashCode * 59) + this.BadgeCount.GetHashCode();
                hashCode = (hashCode * 59) + this.LastActive.GetHashCode();
                hashCode = (hashCode * 59) + this.NotificationTypes.GetHashCode();
                if (this.TestType != null)
                {
                    hashCode = (hashCode * 59) + this.TestType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Long.GetHashCode();
                hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
