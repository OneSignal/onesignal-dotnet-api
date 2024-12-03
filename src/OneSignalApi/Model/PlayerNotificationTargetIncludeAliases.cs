/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.3.0
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
    /// PlayerNotificationTargetIncludeAliases
    /// </summary>
    [DataContract(Name = "PlayerNotificationTarget_include_aliases")]
    public partial class PlayerNotificationTargetIncludeAliases : IEquatable<PlayerNotificationTargetIncludeAliases>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerNotificationTargetIncludeAliases" /> class.
        /// </summary>
        /// <param name="aliasLabel">aliasLabel.</param>
        public PlayerNotificationTargetIncludeAliases(List<string> aliasLabel = default(List<string>))
        {
            this.AliasLabel = aliasLabel;
        }

        /// <summary>
        /// Gets or Sets AliasLabel
        /// </summary>
        [DataMember(Name = "alias_label", EmitDefaultValue = false)]
        public List<string> AliasLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerNotificationTargetIncludeAliases {\n");
            sb.Append("  AliasLabel: ").Append(AliasLabel).Append("\n");
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
            return this.Equals(input as PlayerNotificationTargetIncludeAliases);
        }

        /// <summary>
        /// Returns true if PlayerNotificationTargetIncludeAliases instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerNotificationTargetIncludeAliases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerNotificationTargetIncludeAliases input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AliasLabel == input.AliasLabel ||
                    this.AliasLabel != null &&
                    input.AliasLabel != null &&
                    this.AliasLabel.SequenceEqual(input.AliasLabel)
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
                if (this.AliasLabel != null)
                {
                    hashCode = (hashCode * 59) + this.AliasLabel.GetHashCode();
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
