/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 5.0.1
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
using OpenAPIDateConverter = OneSignalApi.Client.OpenAPIDateConverter;

namespace OneSignalApi.Model
{
    /// <summary>
    /// App
    /// </summary>
    [DataContract(Name = "App")]
    public partial class App : IEquatable<App>, IValidatableObject
    {
        /// <summary>
        /// iOS: Either sandbox or production
        /// </summary>
        /// <value>iOS: Either sandbox or production</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApnsEnvEnum
        {
            /// <summary>
            /// Enum Sandbox for value: sandbox
            /// </summary>
            [EnumMember(Value = "sandbox")]
            Sandbox = 1,

            /// <summary>
            /// Enum Production for value: production
            /// </summary>
            [EnumMember(Value = "production")]
            Production = 2

        }


        /// <summary>
        /// iOS: Either sandbox or production
        /// </summary>
        /// <value>iOS: Either sandbox or production</value>
        [DataMember(Name = "apns_env", EmitDefaultValue = true)]
        public ApnsEnvEnum? ApnsEnv { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="name">The name of your app, as displayed on your apps list on the dashboard.  This can be renamed..</param>
        /// <param name="androidGcmSenderId">Android: Your Google Project number.  Also known as Sender ID..</param>
        /// <param name="gcmKey">Android: Your Google Push Messaging Auth Key.</param>
        /// <param name="chromeWebOrigin">Chrome (All Browsers except Safari) (Recommended): The URL to your website.  This field is required if you wish to enable web push and specify other web push parameters..</param>
        /// <param name="chromeKey">Not for web push.  Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions..</param>
        /// <param name="chromeWebDefaultNotificationIcon">Chrome (All Browsers except Safari): Your default notification icon. Should be 256x256 pixels, min 80x80..</param>
        /// <param name="chromeWebSubDomain">Chrome (All Browsers except Safari): A subdomain of your choice in order to support Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed..</param>
        /// <param name="apnsEnv">iOS: Either sandbox or production.</param>
        /// <param name="apnsP12">iOS: Your apple push notification p12 certificate file, converted to a string and Base64 encoded..</param>
        /// <param name="apnsP12Password">iOS: Required if using p12 certificate.  Password for the apns_p12 file..</param>
        /// <param name="safariApnsP12">Safari: Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded..</param>
        /// <param name="safariApnsP12Password">Safari: Password for safari_apns_p12 file.</param>
        /// <param name="apnsKeyId">iOS: Required if using p8. Unique identifier for the p8 authentication key..</param>
        /// <param name="apnsTeamId">iOS: Required if using p8. Team ID generated by Apple for your developer account..</param>
        /// <param name="apnsBundleId">iOS: Required if using p8. Bundle ID for your app in the Apple ecosystem..</param>
        /// <param name="apnsP8">iOS: Required if using p8. Base64 encoded p8 key.</param>
        /// <param name="safariSiteOrigin">Safari (Recommended): The hostname to your website including http(s)://.</param>
        /// <param name="safariIcon256256">Safari: A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide..</param>
        /// <param name="siteName">All Browsers (Recommended): The Site Name. Requires both chrome_web_origin and safari_site_origin to be set to add or update it..</param>
        /// <param name="organizationId">The Id of the Organization you would like to add this app to..</param>
        /// <param name="additionalDataIsRootPayload">iOS: Notification data (additional data) values will be added to the root of the apns payload when sent to the device.  Ignore if you&#39;re not using any other plugins, or not using OneSignal SDK methods to read the payload..</param>
        public App(string name = default(string), string androidGcmSenderId = default(string), string gcmKey = default(string), string chromeWebOrigin = default(string), string chromeKey = default(string), string chromeWebDefaultNotificationIcon = default(string), string chromeWebSubDomain = default(string), ApnsEnvEnum? apnsEnv = default(ApnsEnvEnum?), string apnsP12 = default(string), string apnsP12Password = default(string), string safariApnsP12 = default(string), string safariApnsP12Password = default(string), string apnsKeyId = default(string), string apnsTeamId = default(string), string apnsBundleId = default(string), string apnsP8 = default(string), string safariSiteOrigin = default(string), string safariIcon256256 = default(string), string siteName = default(string), string organizationId = default(string), bool additionalDataIsRootPayload = default(bool))
        {
            this.Name = name;
            this.AndroidGcmSenderId = androidGcmSenderId;
            this.GcmKey = gcmKey;
            this.ChromeWebOrigin = chromeWebOrigin;
            this.ChromeKey = chromeKey;
            this.ChromeWebDefaultNotificationIcon = chromeWebDefaultNotificationIcon;
            this.ChromeWebSubDomain = chromeWebSubDomain;
            this.ApnsEnv = apnsEnv;
            this.ApnsP12 = apnsP12;
            this.ApnsP12Password = apnsP12Password;
            this.SafariApnsP12 = safariApnsP12;
            this.SafariApnsP12Password = safariApnsP12Password;
            this.ApnsKeyId = apnsKeyId;
            this.ApnsTeamId = apnsTeamId;
            this.ApnsBundleId = apnsBundleId;
            this.ApnsP8 = apnsP8;
            this.SafariSiteOrigin = safariSiteOrigin;
            this.SafariIcon256256 = safariIcon256256;
            this.SiteName = siteName;
            this.OrganizationId = organizationId;
            this.AdditionalDataIsRootPayload = additionalDataIsRootPayload;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// The name of your app, as displayed on your apps list on the dashboard.  This can be renamed.
        /// </summary>
        /// <value>The name of your app, as displayed on your apps list on the dashboard.  This can be renamed.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name = "players", EmitDefaultValue = false)]
        public int Players { get; private set; }

        /// <summary>
        /// Returns false as Players should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlayers()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MessageablePlayers
        /// </summary>
        [DataMember(Name = "messageable_players", EmitDefaultValue = false)]
        public int MessageablePlayers { get; private set; }

        /// <summary>
        /// Returns false as MessageablePlayers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessageablePlayers()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Android: Your Google Project number.  Also known as Sender ID.
        /// </summary>
        /// <value>Android: Your Google Project number.  Also known as Sender ID.</value>
        [DataMember(Name = "android_gcm_sender_id", EmitDefaultValue = false)]
        public string AndroidGcmSenderId { get; set; }

        /// <summary>
        /// Android: Your Google Push Messaging Auth Key
        /// </summary>
        /// <value>Android: Your Google Push Messaging Auth Key</value>
        [DataMember(Name = "gcm_key", EmitDefaultValue = true)]
        public string GcmKey { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari) (Recommended): The URL to your website.  This field is required if you wish to enable web push and specify other web push parameters.
        /// </summary>
        /// <value>Chrome (All Browsers except Safari) (Recommended): The URL to your website.  This field is required if you wish to enable web push and specify other web push parameters.</value>
        [DataMember(Name = "chrome_web_origin", EmitDefaultValue = true)]
        public string ChromeWebOrigin { get; set; }

        /// <summary>
        /// Not for web push.  Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions.
        /// </summary>
        /// <value>Not for web push.  Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions.</value>
        [DataMember(Name = "chrome_key", EmitDefaultValue = true)]
        public string ChromeKey { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari): Your default notification icon. Should be 256x256 pixels, min 80x80.
        /// </summary>
        /// <value>Chrome (All Browsers except Safari): Your default notification icon. Should be 256x256 pixels, min 80x80.</value>
        [DataMember(Name = "chrome_web_default_notification_icon", EmitDefaultValue = true)]
        public string ChromeWebDefaultNotificationIcon { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari): A subdomain of your choice in order to support Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed.
        /// </summary>
        /// <value>Chrome (All Browsers except Safari): A subdomain of your choice in order to support Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed.</value>
        [DataMember(Name = "chrome_web_sub_domain", EmitDefaultValue = true)]
        public string ChromeWebSubDomain { get; set; }

        /// <summary>
        /// iOS: Your apple push notification p12 certificate file, converted to a string and Base64 encoded.
        /// </summary>
        /// <value>iOS: Your apple push notification p12 certificate file, converted to a string and Base64 encoded.</value>
        [DataMember(Name = "apns_p12", EmitDefaultValue = false)]
        public string ApnsP12 { get; set; }

        /// <summary>
        /// iOS: Required if using p12 certificate.  Password for the apns_p12 file.
        /// </summary>
        /// <value>iOS: Required if using p12 certificate.  Password for the apns_p12 file.</value>
        [DataMember(Name = "apns_p12_password", EmitDefaultValue = false)]
        public string ApnsP12Password { get; set; }

        /// <summary>
        /// Gets or Sets ApnsCertificates
        /// </summary>
        [DataMember(Name = "apns_certificates", EmitDefaultValue = true)]
        public string ApnsCertificates { get; private set; }

        /// <summary>
        /// Returns false as ApnsCertificates should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApnsCertificates()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SafariApnsCertificates
        /// </summary>
        [DataMember(Name = "safari_apns_certificates", EmitDefaultValue = false)]
        public string SafariApnsCertificates { get; private set; }

        /// <summary>
        /// Returns false as SafariApnsCertificates should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariApnsCertificates()
        {
            return false;
        }
        /// <summary>
        /// Safari: Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded.
        /// </summary>
        /// <value>Safari: Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded.</value>
        [DataMember(Name = "safari_apns_p12", EmitDefaultValue = false)]
        public string SafariApnsP12 { get; set; }

        /// <summary>
        /// Safari: Password for safari_apns_p12 file
        /// </summary>
        /// <value>Safari: Password for safari_apns_p12 file</value>
        [DataMember(Name = "safari_apns_p12_password", EmitDefaultValue = false)]
        public string SafariApnsP12Password { get; set; }

        /// <summary>
        /// iOS: Required if using p8. Unique identifier for the p8 authentication key.
        /// </summary>
        /// <value>iOS: Required if using p8. Unique identifier for the p8 authentication key.</value>
        [DataMember(Name = "apns_key_id", EmitDefaultValue = true)]
        public string ApnsKeyId { get; set; }

        /// <summary>
        /// iOS: Required if using p8. Team ID generated by Apple for your developer account.
        /// </summary>
        /// <value>iOS: Required if using p8. Team ID generated by Apple for your developer account.</value>
        [DataMember(Name = "apns_team_id", EmitDefaultValue = true)]
        public string ApnsTeamId { get; set; }

        /// <summary>
        /// iOS: Required if using p8. Bundle ID for your app in the Apple ecosystem.
        /// </summary>
        /// <value>iOS: Required if using p8. Bundle ID for your app in the Apple ecosystem.</value>
        [DataMember(Name = "apns_bundle_id", EmitDefaultValue = true)]
        public string ApnsBundleId { get; set; }

        /// <summary>
        /// iOS: Required if using p8. Base64 encoded p8 key
        /// </summary>
        /// <value>iOS: Required if using p8. Base64 encoded p8 key</value>
        [DataMember(Name = "apns_p8", EmitDefaultValue = true)]
        public string ApnsP8 { get; set; }

        /// <summary>
        /// Safari (Recommended): The hostname to your website including http(s)://
        /// </summary>
        /// <value>Safari (Recommended): The hostname to your website including http(s)://</value>
        [DataMember(Name = "safari_site_origin", EmitDefaultValue = true)]
        public string SafariSiteOrigin { get; set; }

        /// <summary>
        /// Gets or Sets SafariPushId
        /// </summary>
        [DataMember(Name = "safari_push_id", EmitDefaultValue = true)]
        public string SafariPushId { get; private set; }

        /// <summary>
        /// Returns false as SafariPushId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariPushId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SafariIcon1616
        /// </summary>
        [DataMember(Name = "safari_icon_16_16", EmitDefaultValue = false)]
        public string SafariIcon1616 { get; private set; }

        /// <summary>
        /// Returns false as SafariIcon1616 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariIcon1616()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SafariIcon3232
        /// </summary>
        [DataMember(Name = "safari_icon_32_32", EmitDefaultValue = false)]
        public string SafariIcon3232 { get; private set; }

        /// <summary>
        /// Returns false as SafariIcon3232 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariIcon3232()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SafariIcon6464
        /// </summary>
        [DataMember(Name = "safari_icon_64_64", EmitDefaultValue = false)]
        public string SafariIcon6464 { get; private set; }

        /// <summary>
        /// Returns false as SafariIcon6464 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariIcon6464()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SafariIcon128128
        /// </summary>
        [DataMember(Name = "safari_icon_128_128", EmitDefaultValue = false)]
        public string SafariIcon128128 { get; private set; }

        /// <summary>
        /// Returns false as SafariIcon128128 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSafariIcon128128()
        {
            return false;
        }
        /// <summary>
        /// Safari: A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide.
        /// </summary>
        /// <value>Safari: A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide.</value>
        [DataMember(Name = "safari_icon_256_256", EmitDefaultValue = false)]
        public string SafariIcon256256 { get; set; }

        /// <summary>
        /// All Browsers (Recommended): The Site Name. Requires both chrome_web_origin and safari_site_origin to be set to add or update it.
        /// </summary>
        /// <value>All Browsers (Recommended): The Site Name. Requires both chrome_web_origin and safari_site_origin to be set to add or update it.</value>
        [DataMember(Name = "site_name", EmitDefaultValue = true)]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or Sets BasicAuthKey
        /// </summary>
        [DataMember(Name = "basic_auth_key", EmitDefaultValue = true)]
        public string BasicAuthKey { get; private set; }

        /// <summary>
        /// Returns false as BasicAuthKey should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBasicAuthKey()
        {
            return false;
        }
        /// <summary>
        /// The Id of the Organization you would like to add this app to.
        /// </summary>
        /// <value>The Id of the Organization you would like to add this app to.</value>
        [DataMember(Name = "organization_id", EmitDefaultValue = false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// iOS: Notification data (additional data) values will be added to the root of the apns payload when sent to the device.  Ignore if you&#39;re not using any other plugins, or not using OneSignal SDK methods to read the payload.
        /// </summary>
        /// <value>iOS: Notification data (additional data) values will be added to the root of the apns payload when sent to the device.  Ignore if you&#39;re not using any other plugins, or not using OneSignal SDK methods to read the payload.</value>
        [DataMember(Name = "additional_data_is_root_payload", EmitDefaultValue = true)]
        public bool AdditionalDataIsRootPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class App {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  MessageablePlayers: ").Append(MessageablePlayers).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AndroidGcmSenderId: ").Append(AndroidGcmSenderId).Append("\n");
            sb.Append("  GcmKey: ").Append(GcmKey).Append("\n");
            sb.Append("  ChromeWebOrigin: ").Append(ChromeWebOrigin).Append("\n");
            sb.Append("  ChromeKey: ").Append(ChromeKey).Append("\n");
            sb.Append("  ChromeWebDefaultNotificationIcon: ").Append(ChromeWebDefaultNotificationIcon).Append("\n");
            sb.Append("  ChromeWebSubDomain: ").Append(ChromeWebSubDomain).Append("\n");
            sb.Append("  ApnsEnv: ").Append(ApnsEnv).Append("\n");
            sb.Append("  ApnsP12: ").Append(ApnsP12).Append("\n");
            sb.Append("  ApnsP12Password: ").Append(ApnsP12Password).Append("\n");
            sb.Append("  ApnsCertificates: ").Append(ApnsCertificates).Append("\n");
            sb.Append("  SafariApnsCertificates: ").Append(SafariApnsCertificates).Append("\n");
            sb.Append("  SafariApnsP12: ").Append(SafariApnsP12).Append("\n");
            sb.Append("  SafariApnsP12Password: ").Append(SafariApnsP12Password).Append("\n");
            sb.Append("  ApnsKeyId: ").Append(ApnsKeyId).Append("\n");
            sb.Append("  ApnsTeamId: ").Append(ApnsTeamId).Append("\n");
            sb.Append("  ApnsBundleId: ").Append(ApnsBundleId).Append("\n");
            sb.Append("  ApnsP8: ").Append(ApnsP8).Append("\n");
            sb.Append("  SafariSiteOrigin: ").Append(SafariSiteOrigin).Append("\n");
            sb.Append("  SafariPushId: ").Append(SafariPushId).Append("\n");
            sb.Append("  SafariIcon1616: ").Append(SafariIcon1616).Append("\n");
            sb.Append("  SafariIcon3232: ").Append(SafariIcon3232).Append("\n");
            sb.Append("  SafariIcon6464: ").Append(SafariIcon6464).Append("\n");
            sb.Append("  SafariIcon128128: ").Append(SafariIcon128128).Append("\n");
            sb.Append("  SafariIcon256256: ").Append(SafariIcon256256).Append("\n");
            sb.Append("  SiteName: ").Append(SiteName).Append("\n");
            sb.Append("  BasicAuthKey: ").Append(BasicAuthKey).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  AdditionalDataIsRootPayload: ").Append(AdditionalDataIsRootPayload).Append("\n");
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
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Players == input.Players ||
                    this.Players.Equals(input.Players)
                ) && 
                (
                    this.MessageablePlayers == input.MessageablePlayers ||
                    this.MessageablePlayers.Equals(input.MessageablePlayers)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.AndroidGcmSenderId == input.AndroidGcmSenderId ||
                    (this.AndroidGcmSenderId != null &&
                    this.AndroidGcmSenderId.Equals(input.AndroidGcmSenderId))
                ) && 
                (
                    this.GcmKey == input.GcmKey ||
                    (this.GcmKey != null &&
                    this.GcmKey.Equals(input.GcmKey))
                ) && 
                (
                    this.ChromeWebOrigin == input.ChromeWebOrigin ||
                    (this.ChromeWebOrigin != null &&
                    this.ChromeWebOrigin.Equals(input.ChromeWebOrigin))
                ) && 
                (
                    this.ChromeKey == input.ChromeKey ||
                    (this.ChromeKey != null &&
                    this.ChromeKey.Equals(input.ChromeKey))
                ) && 
                (
                    this.ChromeWebDefaultNotificationIcon == input.ChromeWebDefaultNotificationIcon ||
                    (this.ChromeWebDefaultNotificationIcon != null &&
                    this.ChromeWebDefaultNotificationIcon.Equals(input.ChromeWebDefaultNotificationIcon))
                ) && 
                (
                    this.ChromeWebSubDomain == input.ChromeWebSubDomain ||
                    (this.ChromeWebSubDomain != null &&
                    this.ChromeWebSubDomain.Equals(input.ChromeWebSubDomain))
                ) && 
                (
                    this.ApnsEnv == input.ApnsEnv ||
                    this.ApnsEnv.Equals(input.ApnsEnv)
                ) && 
                (
                    this.ApnsP12 == input.ApnsP12 ||
                    (this.ApnsP12 != null &&
                    this.ApnsP12.Equals(input.ApnsP12))
                ) && 
                (
                    this.ApnsP12Password == input.ApnsP12Password ||
                    (this.ApnsP12Password != null &&
                    this.ApnsP12Password.Equals(input.ApnsP12Password))
                ) && 
                (
                    this.ApnsCertificates == input.ApnsCertificates ||
                    (this.ApnsCertificates != null &&
                    this.ApnsCertificates.Equals(input.ApnsCertificates))
                ) && 
                (
                    this.SafariApnsCertificates == input.SafariApnsCertificates ||
                    (this.SafariApnsCertificates != null &&
                    this.SafariApnsCertificates.Equals(input.SafariApnsCertificates))
                ) && 
                (
                    this.SafariApnsP12 == input.SafariApnsP12 ||
                    (this.SafariApnsP12 != null &&
                    this.SafariApnsP12.Equals(input.SafariApnsP12))
                ) && 
                (
                    this.SafariApnsP12Password == input.SafariApnsP12Password ||
                    (this.SafariApnsP12Password != null &&
                    this.SafariApnsP12Password.Equals(input.SafariApnsP12Password))
                ) && 
                (
                    this.ApnsKeyId == input.ApnsKeyId ||
                    (this.ApnsKeyId != null &&
                    this.ApnsKeyId.Equals(input.ApnsKeyId))
                ) && 
                (
                    this.ApnsTeamId == input.ApnsTeamId ||
                    (this.ApnsTeamId != null &&
                    this.ApnsTeamId.Equals(input.ApnsTeamId))
                ) && 
                (
                    this.ApnsBundleId == input.ApnsBundleId ||
                    (this.ApnsBundleId != null &&
                    this.ApnsBundleId.Equals(input.ApnsBundleId))
                ) && 
                (
                    this.ApnsP8 == input.ApnsP8 ||
                    (this.ApnsP8 != null &&
                    this.ApnsP8.Equals(input.ApnsP8))
                ) && 
                (
                    this.SafariSiteOrigin == input.SafariSiteOrigin ||
                    (this.SafariSiteOrigin != null &&
                    this.SafariSiteOrigin.Equals(input.SafariSiteOrigin))
                ) && 
                (
                    this.SafariPushId == input.SafariPushId ||
                    (this.SafariPushId != null &&
                    this.SafariPushId.Equals(input.SafariPushId))
                ) && 
                (
                    this.SafariIcon1616 == input.SafariIcon1616 ||
                    (this.SafariIcon1616 != null &&
                    this.SafariIcon1616.Equals(input.SafariIcon1616))
                ) && 
                (
                    this.SafariIcon3232 == input.SafariIcon3232 ||
                    (this.SafariIcon3232 != null &&
                    this.SafariIcon3232.Equals(input.SafariIcon3232))
                ) && 
                (
                    this.SafariIcon6464 == input.SafariIcon6464 ||
                    (this.SafariIcon6464 != null &&
                    this.SafariIcon6464.Equals(input.SafariIcon6464))
                ) && 
                (
                    this.SafariIcon128128 == input.SafariIcon128128 ||
                    (this.SafariIcon128128 != null &&
                    this.SafariIcon128128.Equals(input.SafariIcon128128))
                ) && 
                (
                    this.SafariIcon256256 == input.SafariIcon256256 ||
                    (this.SafariIcon256256 != null &&
                    this.SafariIcon256256.Equals(input.SafariIcon256256))
                ) && 
                (
                    this.SiteName == input.SiteName ||
                    (this.SiteName != null &&
                    this.SiteName.Equals(input.SiteName))
                ) && 
                (
                    this.BasicAuthKey == input.BasicAuthKey ||
                    (this.BasicAuthKey != null &&
                    this.BasicAuthKey.Equals(input.BasicAuthKey))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.AdditionalDataIsRootPayload == input.AdditionalDataIsRootPayload ||
                    this.AdditionalDataIsRootPayload.Equals(input.AdditionalDataIsRootPayload)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Players.GetHashCode();
                hashCode = (hashCode * 59) + this.MessageablePlayers.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.AndroidGcmSenderId != null)
                {
                    hashCode = (hashCode * 59) + this.AndroidGcmSenderId.GetHashCode();
                }
                if (this.GcmKey != null)
                {
                    hashCode = (hashCode * 59) + this.GcmKey.GetHashCode();
                }
                if (this.ChromeWebOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.ChromeWebOrigin.GetHashCode();
                }
                if (this.ChromeKey != null)
                {
                    hashCode = (hashCode * 59) + this.ChromeKey.GetHashCode();
                }
                if (this.ChromeWebDefaultNotificationIcon != null)
                {
                    hashCode = (hashCode * 59) + this.ChromeWebDefaultNotificationIcon.GetHashCode();
                }
                if (this.ChromeWebSubDomain != null)
                {
                    hashCode = (hashCode * 59) + this.ChromeWebSubDomain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApnsEnv.GetHashCode();
                if (this.ApnsP12 != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsP12.GetHashCode();
                }
                if (this.ApnsP12Password != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsP12Password.GetHashCode();
                }
                if (this.ApnsCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsCertificates.GetHashCode();
                }
                if (this.SafariApnsCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.SafariApnsCertificates.GetHashCode();
                }
                if (this.SafariApnsP12 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariApnsP12.GetHashCode();
                }
                if (this.SafariApnsP12Password != null)
                {
                    hashCode = (hashCode * 59) + this.SafariApnsP12Password.GetHashCode();
                }
                if (this.ApnsKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsKeyId.GetHashCode();
                }
                if (this.ApnsTeamId != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsTeamId.GetHashCode();
                }
                if (this.ApnsBundleId != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsBundleId.GetHashCode();
                }
                if (this.ApnsP8 != null)
                {
                    hashCode = (hashCode * 59) + this.ApnsP8.GetHashCode();
                }
                if (this.SafariSiteOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.SafariSiteOrigin.GetHashCode();
                }
                if (this.SafariPushId != null)
                {
                    hashCode = (hashCode * 59) + this.SafariPushId.GetHashCode();
                }
                if (this.SafariIcon1616 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariIcon1616.GetHashCode();
                }
                if (this.SafariIcon3232 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariIcon3232.GetHashCode();
                }
                if (this.SafariIcon6464 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariIcon6464.GetHashCode();
                }
                if (this.SafariIcon128128 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariIcon128128.GetHashCode();
                }
                if (this.SafariIcon256256 != null)
                {
                    hashCode = (hashCode * 59) + this.SafariIcon256256.GetHashCode();
                }
                if (this.SiteName != null)
                {
                    hashCode = (hashCode * 59) + this.SiteName.GetHashCode();
                }
                if (this.BasicAuthKey != null)
                {
                    hashCode = (hashCode * 59) + this.BasicAuthKey.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AdditionalDataIsRootPayload.GetHashCode();
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
