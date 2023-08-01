/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.2.2
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
    /// SubscriptionObject
    /// </summary>
    [DataContract(Name = "SubscriptionObject")]
    public partial class SubscriptionObject : IEquatable<SubscriptionObject>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum IOSPush for value: iOSPush
            /// </summary>
            [EnumMember(Value = "iOSPush")]
            IOSPush = 1,

            /// <summary>
            /// Enum AndroidPush for value: AndroidPush
            /// </summary>
            [EnumMember(Value = "AndroidPush")]
            AndroidPush = 2,

            /// <summary>
            /// Enum FireOSPush for value: FireOSPush
            /// </summary>
            [EnumMember(Value = "FireOSPush")]
            FireOSPush = 3,

            /// <summary>
            /// Enum ChromeExtensionPush for value: ChromeExtensionPush
            /// </summary>
            [EnumMember(Value = "ChromeExtensionPush")]
            ChromeExtensionPush = 4,

            /// <summary>
            /// Enum ChromePush for value: ChromePush
            /// </summary>
            [EnumMember(Value = "ChromePush")]
            ChromePush = 5,

            /// <summary>
            /// Enum WindowsPush for value: WindowsPush
            /// </summary>
            [EnumMember(Value = "WindowsPush")]
            WindowsPush = 6,

            /// <summary>
            /// Enum SafariLegacyPush for value: SafariLegacyPush
            /// </summary>
            [EnumMember(Value = "SafariLegacyPush")]
            SafariLegacyPush = 7,

            /// <summary>
            /// Enum FirefoxPush for value: FirefoxPush
            /// </summary>
            [EnumMember(Value = "FirefoxPush")]
            FirefoxPush = 8,

            /// <summary>
            /// Enum MacOSPush for value: macOSPush
            /// </summary>
            [EnumMember(Value = "macOSPush")]
            MacOSPush = 9,

            /// <summary>
            /// Enum HuaweiPush for value: HuaweiPush
            /// </summary>
            [EnumMember(Value = "HuaweiPush")]
            HuaweiPush = 10,

            /// <summary>
            /// Enum SafariPush for value: SafariPush
            /// </summary>
            [EnumMember(Value = "SafariPush")]
            SafariPush = 11,

            /// <summary>
            /// Enum Email for value: Email
            /// </summary>
            [EnumMember(Value = "Email")]
            Email = 12,

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 13

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionObject" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="token">token.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="notificationTypes">notificationTypes.</param>
        /// <param name="sessionTime">sessionTime.</param>
        /// <param name="sessionCount">sessionCount.</param>
        /// <param name="sdk">sdk.</param>
        /// <param name="deviceModel">deviceModel.</param>
        /// <param name="deviceOs">deviceOs.</param>
        /// <param name="rooted">rooted.</param>
        /// <param name="testType">testType.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="netType">netType.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="webAuth">webAuth.</param>
        /// <param name="webP256">webP256.</param>
        public SubscriptionObject(string id = default(string), TypeEnum? type = default(TypeEnum?), string token = default(string), bool enabled = default(bool), decimal notificationTypes = default(decimal), decimal sessionTime = default(decimal), decimal sessionCount = default(decimal), string sdk = default(string), string deviceModel = default(string), string deviceOs = default(string), bool rooted = default(bool), decimal testType = default(decimal), string appVersion = default(string), decimal netType = default(decimal), string carrier = default(string), string webAuth = default(string), string webP256 = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.Token = token;
            this.Enabled = enabled;
            this.NotificationTypes = notificationTypes;
            this.SessionTime = sessionTime;
            this.SessionCount = sessionCount;
            this.Sdk = sdk;
            this.DeviceModel = deviceModel;
            this.DeviceOs = deviceOs;
            this.Rooted = rooted;
            this.TestType = testType;
            this.AppVersion = appVersion;
            this.NetType = netType;
            this.Carrier = carrier;
            this.WebAuth = webAuth;
            this.WebP256 = webP256;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets NotificationTypes
        /// </summary>
        [DataMember(Name = "notification_types", EmitDefaultValue = false)]
        public decimal NotificationTypes { get; set; }

        /// <summary>
        /// Gets or Sets SessionTime
        /// </summary>
        [DataMember(Name = "session_time", EmitDefaultValue = false)]
        public decimal SessionTime { get; set; }

        /// <summary>
        /// Gets or Sets SessionCount
        /// </summary>
        [DataMember(Name = "session_count", EmitDefaultValue = false)]
        public decimal SessionCount { get; set; }

        /// <summary>
        /// Gets or Sets Sdk
        /// </summary>
        [DataMember(Name = "sdk", EmitDefaultValue = false)]
        public string Sdk { get; set; }

        /// <summary>
        /// Gets or Sets DeviceModel
        /// </summary>
        [DataMember(Name = "device_model", EmitDefaultValue = false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or Sets DeviceOs
        /// </summary>
        [DataMember(Name = "device_os", EmitDefaultValue = false)]
        public string DeviceOs { get; set; }

        /// <summary>
        /// Gets or Sets Rooted
        /// </summary>
        [DataMember(Name = "rooted", EmitDefaultValue = true)]
        public bool Rooted { get; set; }

        /// <summary>
        /// Gets or Sets TestType
        /// </summary>
        [DataMember(Name = "test_type", EmitDefaultValue = false)]
        public decimal TestType { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets NetType
        /// </summary>
        [DataMember(Name = "net_type", EmitDefaultValue = false)]
        public decimal NetType { get; set; }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or Sets WebAuth
        /// </summary>
        [DataMember(Name = "web_auth", EmitDefaultValue = false)]
        public string WebAuth { get; set; }

        /// <summary>
        /// Gets or Sets WebP256
        /// </summary>
        [DataMember(Name = "web_p256", EmitDefaultValue = false)]
        public string WebP256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  NotificationTypes: ").Append(NotificationTypes).Append("\n");
            sb.Append("  SessionTime: ").Append(SessionTime).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  Sdk: ").Append(Sdk).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DeviceOs: ").Append(DeviceOs).Append("\n");
            sb.Append("  Rooted: ").Append(Rooted).Append("\n");
            sb.Append("  TestType: ").Append(TestType).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  NetType: ").Append(NetType).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  WebAuth: ").Append(WebAuth).Append("\n");
            sb.Append("  WebP256: ").Append(WebP256).Append("\n");
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
            return this.Equals(input as SubscriptionObject);
        }

        /// <summary>
        /// Returns true if SubscriptionObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionObject input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.NotificationTypes == input.NotificationTypes ||
                    this.NotificationTypes.Equals(input.NotificationTypes)
                ) && 
                (
                    this.SessionTime == input.SessionTime ||
                    this.SessionTime.Equals(input.SessionTime)
                ) && 
                (
                    this.SessionCount == input.SessionCount ||
                    this.SessionCount.Equals(input.SessionCount)
                ) && 
                (
                    this.Sdk == input.Sdk ||
                    (this.Sdk != null &&
                    this.Sdk.Equals(input.Sdk))
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
                    this.Rooted == input.Rooted ||
                    this.Rooted.Equals(input.Rooted)
                ) && 
                (
                    this.TestType == input.TestType ||
                    this.TestType.Equals(input.TestType)
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.NetType == input.NetType ||
                    this.NetType.Equals(input.NetType)
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.WebAuth == input.WebAuth ||
                    (this.WebAuth != null &&
                    this.WebAuth.Equals(input.WebAuth))
                ) && 
                (
                    this.WebP256 == input.WebP256 ||
                    (this.WebP256 != null &&
                    this.WebP256.Equals(input.WebP256))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.NotificationTypes.GetHashCode();
                hashCode = (hashCode * 59) + this.SessionTime.GetHashCode();
                hashCode = (hashCode * 59) + this.SessionCount.GetHashCode();
                if (this.Sdk != null)
                {
                    hashCode = (hashCode * 59) + this.Sdk.GetHashCode();
                }
                if (this.DeviceModel != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceModel.GetHashCode();
                }
                if (this.DeviceOs != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceOs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rooted.GetHashCode();
                hashCode = (hashCode * 59) + this.TestType.GetHashCode();
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NetType.GetHashCode();
                if (this.Carrier != null)
                {
                    hashCode = (hashCode * 59) + this.Carrier.GetHashCode();
                }
                if (this.WebAuth != null)
                {
                    hashCode = (hashCode * 59) + this.WebAuth.GetHashCode();
                }
                if (this.WebP256 != null)
                {
                    hashCode = (hashCode * 59) + this.WebP256.GetHashCode();
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
