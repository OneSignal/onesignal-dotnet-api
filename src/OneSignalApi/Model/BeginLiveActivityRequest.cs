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
using OpenAPIDateConverter = OneSignalApi.Client.OpenAPIDateConverter;

namespace OneSignalApi.Model
{
    /// <summary>
    /// BeginLiveActivityRequest
    /// </summary>
    [DataContract(Name = "BeginLiveActivityRequest")]
    public partial class BeginLiveActivityRequest : IEquatable<BeginLiveActivityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeginLiveActivityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeginLiveActivityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeginLiveActivityRequest" /> class.
        /// </summary>
        /// <param name="pushToken">pushToken (required).</param>
        /// <param name="subscriptionId">subscriptionId (required).</param>
        public BeginLiveActivityRequest(string pushToken = default(string), string subscriptionId = default(string))
        {
            // to ensure "pushToken" is required (not null)
            if (pushToken == null)
            {
                throw new ArgumentNullException("pushToken is a required property for BeginLiveActivityRequest and cannot be null");
            }
            this.PushToken = pushToken;
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId is a required property for BeginLiveActivityRequest and cannot be null");
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Gets or Sets PushToken
        /// </summary>
        [DataMember(Name = "push_token", IsRequired = true, EmitDefaultValue = false)]
        public string PushToken { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscription_id", IsRequired = true, EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeginLiveActivityRequest {\n");
            sb.Append("  PushToken: ").Append(PushToken).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return this.Equals(input as BeginLiveActivityRequest);
        }

        /// <summary>
        /// Returns true if BeginLiveActivityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BeginLiveActivityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeginLiveActivityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PushToken == input.PushToken ||
                    (this.PushToken != null &&
                    this.PushToken.Equals(input.PushToken))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.PushToken != null)
                {
                    hashCode = (hashCode * 59) + this.PushToken.GetHashCode();
                }
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
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