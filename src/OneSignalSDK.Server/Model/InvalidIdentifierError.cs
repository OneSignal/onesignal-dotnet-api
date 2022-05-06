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
    /// InvalidIdentifierError
    /// </summary>
    [DataContract(Name = "InvalidIdentifierError")]
    public partial class InvalidIdentifierError : IEquatable<InvalidIdentifierError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidIdentifierError" /> class.
        /// </summary>
        /// <param name="invalidExternalUserIds">Returned if using include_external_user_ids.</param>
        /// <param name="invalidPlayerIds">Returned if using include_player_ids and some were valid and others were not..</param>
        public InvalidIdentifierError(List<string> invalidExternalUserIds = default(List<string>), List<string> invalidPlayerIds = default(List<string>))
        {
            this.InvalidExternalUserIds = invalidExternalUserIds;
            this.InvalidPlayerIds = invalidPlayerIds;
        }

        /// <summary>
        /// Returned if using include_external_user_ids
        /// </summary>
        /// <value>Returned if using include_external_user_ids</value>
        [DataMember(Name = "invalid_external_user_ids", EmitDefaultValue = false)]
        public List<string> InvalidExternalUserIds { get; set; }

        /// <summary>
        /// Returned if using include_player_ids and some were valid and others were not.
        /// </summary>
        /// <value>Returned if using include_player_ids and some were valid and others were not.</value>
        [DataMember(Name = "invalid_player_ids", EmitDefaultValue = false)]
        public List<string> InvalidPlayerIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvalidIdentifierError {\n");
            sb.Append("  InvalidExternalUserIds: ").Append(InvalidExternalUserIds).Append("\n");
            sb.Append("  InvalidPlayerIds: ").Append(InvalidPlayerIds).Append("\n");
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
            return this.Equals(input as InvalidIdentifierError);
        }

        /// <summary>
        /// Returns true if InvalidIdentifierError instances are equal
        /// </summary>
        /// <param name="input">Instance of InvalidIdentifierError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvalidIdentifierError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvalidExternalUserIds == input.InvalidExternalUserIds ||
                    this.InvalidExternalUserIds != null &&
                    input.InvalidExternalUserIds != null &&
                    this.InvalidExternalUserIds.SequenceEqual(input.InvalidExternalUserIds)
                ) && 
                (
                    this.InvalidPlayerIds == input.InvalidPlayerIds ||
                    this.InvalidPlayerIds != null &&
                    input.InvalidPlayerIds != null &&
                    this.InvalidPlayerIds.SequenceEqual(input.InvalidPlayerIds)
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
                if (this.InvalidExternalUserIds != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidExternalUserIds.GetHashCode();
                }
                if (this.InvalidPlayerIds != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidPlayerIds.GetHashCode();
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
