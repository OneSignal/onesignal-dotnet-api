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
    /// PlayerNotificationTarget
    /// </summary>
    [DataContract(Name = "PlayerNotificationTarget")]
    public partial class PlayerNotificationTarget : IEquatable<PlayerNotificationTarget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerNotificationTarget" /> class.
        /// </summary>
        /// <param name="includePlayerIds">Specific playerids to send your notification to. _Does not require API Auth Key. Do not combine with other targeting parameters. Not compatible with any other targeting parameters. Example: [\&quot;1dd608f2-c6a1-11e3-851d-000c2940e62c\&quot;] Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeExternalUserIds">Target specific devices by custom user IDs assigned via API. Not compatible with any other targeting parameters Example: [\&quot;custom-id-assigned-by-api\&quot;] REQUIRED: REST API Key Authentication Limit of 2,000 entries per REST API call. Note: If targeting push, email, or sms subscribers with same ids, use with channel_for_external_user_ids to indicate you are sending a push or email or sms. .</param>
        /// <param name="includeEmailTokens">Recommended for Sending Emails - Target specific email addresses. If an email does not correspond to an existing user, a new user will be created. Example: nick@catfac.ts Limit of 2,000 entries per REST API call .</param>
        /// <param name="includePhoneNumbers">Recommended for Sending SMS - Target specific phone numbers. The phone number should be in the E.164 format. Phone number should be an existing subscriber on OneSignal. Refer our docs to learn how to add phone numbers to OneSignal. Example phone number: +1999999999 Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeIosTokens">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using iOS device tokens. Warning: Only works with Production tokens. All non-alphanumeric characters must be removed from each token. If a token does not correspond to an existing user, a new user will be created. Example: ce777617da7f548fe7a9ab6febb56cf39fba6d38203... Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeWpWnsUris">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Windows URIs. If a token does not correspond to an existing user, a new user will be created. Example: http://s.notify.live.net/u/1/bn1/HmQAAACPaLDr-... Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeAmazonRegIds">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Amazon ADM registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: amzn1.adm-registration.v1.XpvSSUk0Rc3hTVVV... Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeChromeRegIds">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome App registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeChromeWebRegIds">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome Web Push registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call .</param>
        /// <param name="includeAndroidRegIds">Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Android device registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call .</param>
        public PlayerNotificationTarget(List<string> includePlayerIds = default(List<string>), List<string> includeExternalUserIds = default(List<string>), List<string> includeEmailTokens = default(List<string>), List<string> includePhoneNumbers = default(List<string>), List<string> includeIosTokens = default(List<string>), List<string> includeWpWnsUris = default(List<string>), List<string> includeAmazonRegIds = default(List<string>), List<string> includeChromeRegIds = default(List<string>), List<string> includeChromeWebRegIds = default(List<string>), List<string> includeAndroidRegIds = default(List<string>))
        {
            this.IncludePlayerIds = includePlayerIds;
            this.IncludeExternalUserIds = includeExternalUserIds;
            this.IncludeEmailTokens = includeEmailTokens;
            this.IncludePhoneNumbers = includePhoneNumbers;
            this.IncludeIosTokens = includeIosTokens;
            this.IncludeWpWnsUris = includeWpWnsUris;
            this.IncludeAmazonRegIds = includeAmazonRegIds;
            this.IncludeChromeRegIds = includeChromeRegIds;
            this.IncludeChromeWebRegIds = includeChromeWebRegIds;
            this.IncludeAndroidRegIds = includeAndroidRegIds;
        }

        /// <summary>
        /// Specific playerids to send your notification to. _Does not require API Auth Key. Do not combine with other targeting parameters. Not compatible with any other targeting parameters. Example: [\&quot;1dd608f2-c6a1-11e3-851d-000c2940e62c\&quot;] Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Specific playerids to send your notification to. _Does not require API Auth Key. Do not combine with other targeting parameters. Not compatible with any other targeting parameters. Example: [\&quot;1dd608f2-c6a1-11e3-851d-000c2940e62c\&quot;] Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_player_ids", EmitDefaultValue = false)]
        public List<string> IncludePlayerIds { get; set; }

        /// <summary>
        /// Target specific devices by custom user IDs assigned via API. Not compatible with any other targeting parameters Example: [\&quot;custom-id-assigned-by-api\&quot;] REQUIRED: REST API Key Authentication Limit of 2,000 entries per REST API call. Note: If targeting push, email, or sms subscribers with same ids, use with channel_for_external_user_ids to indicate you are sending a push or email or sms. 
        /// </summary>
        /// <value>Target specific devices by custom user IDs assigned via API. Not compatible with any other targeting parameters Example: [\&quot;custom-id-assigned-by-api\&quot;] REQUIRED: REST API Key Authentication Limit of 2,000 entries per REST API call. Note: If targeting push, email, or sms subscribers with same ids, use with channel_for_external_user_ids to indicate you are sending a push or email or sms. </value>
        [DataMember(Name = "include_external_user_ids", EmitDefaultValue = false)]
        public List<string> IncludeExternalUserIds { get; set; }

        /// <summary>
        /// Recommended for Sending Emails - Target specific email addresses. If an email does not correspond to an existing user, a new user will be created. Example: nick@catfac.ts Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Recommended for Sending Emails - Target specific email addresses. If an email does not correspond to an existing user, a new user will be created. Example: nick@catfac.ts Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_email_tokens", EmitDefaultValue = false)]
        public List<string> IncludeEmailTokens { get; set; }

        /// <summary>
        /// Recommended for Sending SMS - Target specific phone numbers. The phone number should be in the E.164 format. Phone number should be an existing subscriber on OneSignal. Refer our docs to learn how to add phone numbers to OneSignal. Example phone number: +1999999999 Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Recommended for Sending SMS - Target specific phone numbers. The phone number should be in the E.164 format. Phone number should be an existing subscriber on OneSignal. Refer our docs to learn how to add phone numbers to OneSignal. Example phone number: +1999999999 Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_phone_numbers", EmitDefaultValue = false)]
        public List<string> IncludePhoneNumbers { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using iOS device tokens. Warning: Only works with Production tokens. All non-alphanumeric characters must be removed from each token. If a token does not correspond to an existing user, a new user will be created. Example: ce777617da7f548fe7a9ab6febb56cf39fba6d38203... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using iOS device tokens. Warning: Only works with Production tokens. All non-alphanumeric characters must be removed from each token. If a token does not correspond to an existing user, a new user will be created. Example: ce777617da7f548fe7a9ab6febb56cf39fba6d38203... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_ios_tokens", EmitDefaultValue = false)]
        public List<string> IncludeIosTokens { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Windows URIs. If a token does not correspond to an existing user, a new user will be created. Example: http://s.notify.live.net/u/1/bn1/HmQAAACPaLDr-... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Windows URIs. If a token does not correspond to an existing user, a new user will be created. Example: http://s.notify.live.net/u/1/bn1/HmQAAACPaLDr-... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_wp_wns_uris", EmitDefaultValue = false)]
        public List<string> IncludeWpWnsUris { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Amazon ADM registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: amzn1.adm-registration.v1.XpvSSUk0Rc3hTVVV... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Amazon ADM registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: amzn1.adm-registration.v1.XpvSSUk0Rc3hTVVV... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_amazon_reg_ids", EmitDefaultValue = false)]
        public List<string> IncludeAmazonRegIds { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome App registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome App registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_chrome_reg_ids", EmitDefaultValue = false)]
        public List<string> IncludeChromeRegIds { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome Web Push registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Chrome Web Push registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_chrome_web_reg_ids", EmitDefaultValue = false)]
        public List<string> IncludeChromeWebRegIds { get; set; }

        /// <summary>
        /// Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Android device registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call 
        /// </summary>
        /// <value>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead. Target using Android device registration IDs. If a token does not correspond to an existing user, a new user will be created. Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_... Limit of 2,000 entries per REST API call </value>
        [DataMember(Name = "include_android_reg_ids", EmitDefaultValue = false)]
        public List<string> IncludeAndroidRegIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerNotificationTarget {\n");
            sb.Append("  IncludePlayerIds: ").Append(IncludePlayerIds).Append("\n");
            sb.Append("  IncludeExternalUserIds: ").Append(IncludeExternalUserIds).Append("\n");
            sb.Append("  IncludeEmailTokens: ").Append(IncludeEmailTokens).Append("\n");
            sb.Append("  IncludePhoneNumbers: ").Append(IncludePhoneNumbers).Append("\n");
            sb.Append("  IncludeIosTokens: ").Append(IncludeIosTokens).Append("\n");
            sb.Append("  IncludeWpWnsUris: ").Append(IncludeWpWnsUris).Append("\n");
            sb.Append("  IncludeAmazonRegIds: ").Append(IncludeAmazonRegIds).Append("\n");
            sb.Append("  IncludeChromeRegIds: ").Append(IncludeChromeRegIds).Append("\n");
            sb.Append("  IncludeChromeWebRegIds: ").Append(IncludeChromeWebRegIds).Append("\n");
            sb.Append("  IncludeAndroidRegIds: ").Append(IncludeAndroidRegIds).Append("\n");
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
            return this.Equals(input as PlayerNotificationTarget);
        }

        /// <summary>
        /// Returns true if PlayerNotificationTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerNotificationTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerNotificationTarget input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IncludePlayerIds == input.IncludePlayerIds ||
                    this.IncludePlayerIds != null &&
                    input.IncludePlayerIds != null &&
                    this.IncludePlayerIds.SequenceEqual(input.IncludePlayerIds)
                ) && 
                (
                    this.IncludeExternalUserIds == input.IncludeExternalUserIds ||
                    this.IncludeExternalUserIds != null &&
                    input.IncludeExternalUserIds != null &&
                    this.IncludeExternalUserIds.SequenceEqual(input.IncludeExternalUserIds)
                ) && 
                (
                    this.IncludeEmailTokens == input.IncludeEmailTokens ||
                    this.IncludeEmailTokens != null &&
                    input.IncludeEmailTokens != null &&
                    this.IncludeEmailTokens.SequenceEqual(input.IncludeEmailTokens)
                ) && 
                (
                    this.IncludePhoneNumbers == input.IncludePhoneNumbers ||
                    this.IncludePhoneNumbers != null &&
                    input.IncludePhoneNumbers != null &&
                    this.IncludePhoneNumbers.SequenceEqual(input.IncludePhoneNumbers)
                ) && 
                (
                    this.IncludeIosTokens == input.IncludeIosTokens ||
                    this.IncludeIosTokens != null &&
                    input.IncludeIosTokens != null &&
                    this.IncludeIosTokens.SequenceEqual(input.IncludeIosTokens)
                ) && 
                (
                    this.IncludeWpWnsUris == input.IncludeWpWnsUris ||
                    this.IncludeWpWnsUris != null &&
                    input.IncludeWpWnsUris != null &&
                    this.IncludeWpWnsUris.SequenceEqual(input.IncludeWpWnsUris)
                ) && 
                (
                    this.IncludeAmazonRegIds == input.IncludeAmazonRegIds ||
                    this.IncludeAmazonRegIds != null &&
                    input.IncludeAmazonRegIds != null &&
                    this.IncludeAmazonRegIds.SequenceEqual(input.IncludeAmazonRegIds)
                ) && 
                (
                    this.IncludeChromeRegIds == input.IncludeChromeRegIds ||
                    this.IncludeChromeRegIds != null &&
                    input.IncludeChromeRegIds != null &&
                    this.IncludeChromeRegIds.SequenceEqual(input.IncludeChromeRegIds)
                ) && 
                (
                    this.IncludeChromeWebRegIds == input.IncludeChromeWebRegIds ||
                    this.IncludeChromeWebRegIds != null &&
                    input.IncludeChromeWebRegIds != null &&
                    this.IncludeChromeWebRegIds.SequenceEqual(input.IncludeChromeWebRegIds)
                ) && 
                (
                    this.IncludeAndroidRegIds == input.IncludeAndroidRegIds ||
                    this.IncludeAndroidRegIds != null &&
                    input.IncludeAndroidRegIds != null &&
                    this.IncludeAndroidRegIds.SequenceEqual(input.IncludeAndroidRegIds)
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
                if (this.IncludePlayerIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludePlayerIds.GetHashCode();
                }
                if (this.IncludeExternalUserIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeExternalUserIds.GetHashCode();
                }
                if (this.IncludeEmailTokens != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeEmailTokens.GetHashCode();
                }
                if (this.IncludePhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.IncludePhoneNumbers.GetHashCode();
                }
                if (this.IncludeIosTokens != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeIosTokens.GetHashCode();
                }
                if (this.IncludeWpWnsUris != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeWpWnsUris.GetHashCode();
                }
                if (this.IncludeAmazonRegIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeAmazonRegIds.GetHashCode();
                }
                if (this.IncludeChromeRegIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeChromeRegIds.GetHashCode();
                }
                if (this.IncludeChromeWebRegIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeChromeWebRegIds.GetHashCode();
                }
                if (this.IncludeAndroidRegIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeAndroidRegIds.GetHashCode();
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
