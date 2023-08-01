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
    /// Segment
    /// </summary>
    [DataContract(Name = "Segment")]
    public partial class Segment : IEquatable<Segment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Segment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        /// <param name="id">UUID of the segment.  If left empty, it will be assigned automaticaly..</param>
        /// <param name="name">Name of the segment.  You&#39;ll see this name on the Web UI. (required).</param>
        /// <param name="filters">Filter or operators the segment will have.  For a list of available filters with details, please see Send to Users Based on Filters. (required).</param>
        public Segment(string id = default(string), string name = default(string), List<FilterExpressions> filters = default(List<FilterExpressions>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Segment and cannot be null");
            }
            this.Name = name;
            // to ensure "filters" is required (not null)
            if (filters == null)
            {
                throw new ArgumentNullException("filters is a required property for Segment and cannot be null");
            }
            this.Filters = filters;
            this.Id = id;
        }

        /// <summary>
        /// UUID of the segment.  If left empty, it will be assigned automaticaly.
        /// </summary>
        /// <value>UUID of the segment.  If left empty, it will be assigned automaticaly.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the segment.  You&#39;ll see this name on the Web UI.
        /// </summary>
        /// <value>Name of the segment.  You&#39;ll see this name on the Web UI.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Filter or operators the segment will have.  For a list of available filters with details, please see Send to Users Based on Filters.
        /// </summary>
        /// <value>Filter or operators the segment will have.  For a list of available filters with details, please see Send to Users Based on Filters.</value>
        [DataMember(Name = "filters", IsRequired = true, EmitDefaultValue = false)]
        public List<FilterExpressions> Filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Segment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(input as Segment);
        }

        /// <summary>
        /// Returns true if Segment instances are equal
        /// </summary>
        /// <param name="input">Instance of Segment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Segment input)
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
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
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
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
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
