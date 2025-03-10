/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// OutcomeData
    /// </summary>
    [DataContract(Name = "OutcomeData")]
    public partial class OutcomeData : IEquatable<OutcomeData>, IValidatableObject
    {
        /// <summary>
        /// Defines Aggregation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationEnum
        {
            /// <summary>
            /// Enum Sum for value: sum
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum = 1,

            /// <summary>
            /// Enum Count for value: count
            /// </summary>
            [EnumMember(Value = "count")]
            Count = 2

        }


        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name = "aggregation", IsRequired = true, EmitDefaultValue = false)]
        public AggregationEnum Aggregation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutcomeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeData" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="aggregation">aggregation (required).</param>
        public OutcomeData(string id = default(string), int value = default(int), AggregationEnum aggregation = default(AggregationEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for OutcomeData and cannot be null");
            }
            this.Id = id;
            this.Value = value;
            this.Aggregation = aggregation;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public int Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutcomeData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
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
            return this.Equals(input as OutcomeData);
        }

        /// <summary>
        /// Returns true if OutcomeData instances are equal
        /// </summary>
        /// <param name="input">Instance of OutcomeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeData input)
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
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Aggregation == input.Aggregation ||
                    this.Aggregation.Equals(input.Aggregation)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.Aggregation.GetHashCode();
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
