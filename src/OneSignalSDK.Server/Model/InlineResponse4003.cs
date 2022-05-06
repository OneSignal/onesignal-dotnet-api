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
    /// InlineResponse4003
    /// </summary>
    [DataContract(Name = "inline_response_400_3")]
    public partial class InlineResponse4003 : IEquatable<InlineResponse4003>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4003" /> class.
        /// </summary>
        /// <param name="erorrs">erorrs.</param>
        public InlineResponse4003(List<string> erorrs = default(List<string>))
        {
            this.Erorrs = erorrs;
        }

        /// <summary>
        /// Gets or Sets Erorrs
        /// </summary>
        [DataMember(Name = "erorrs", EmitDefaultValue = false)]
        public List<string> Erorrs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse4003 {\n");
            sb.Append("  Erorrs: ").Append(Erorrs).Append("\n");
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
            return this.Equals(input as InlineResponse4003);
        }

        /// <summary>
        /// Returns true if InlineResponse4003 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse4003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4003 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Erorrs == input.Erorrs ||
                    this.Erorrs != null &&
                    input.Erorrs != null &&
                    this.Erorrs.SequenceEqual(input.Erorrs)
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
                if (this.Erorrs != null)
                {
                    hashCode = (hashCode * 59) + this.Erorrs.GetHashCode();
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