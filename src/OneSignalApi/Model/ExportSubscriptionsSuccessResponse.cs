/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 5.2.0
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
    /// ExportSubscriptionsSuccessResponse
    /// </summary>
    [DataContract(Name = "ExportSubscriptionsSuccessResponse")]
    public partial class ExportSubscriptionsSuccessResponse : IEquatable<ExportSubscriptionsSuccessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportSubscriptionsSuccessResponse" /> class.
        /// </summary>
        /// <param name="csvFileUrl">csvFileUrl.</param>
        public ExportSubscriptionsSuccessResponse(string csvFileUrl = default(string))
        {
            this.CsvFileUrl = csvFileUrl;
        }

        /// <summary>
        /// Gets or Sets CsvFileUrl
        /// </summary>
        [DataMember(Name = "csv_file_url", EmitDefaultValue = false)]
        public string CsvFileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportSubscriptionsSuccessResponse {\n");
            sb.Append("  CsvFileUrl: ").Append(CsvFileUrl).Append("\n");
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
            return this.Equals(input as ExportSubscriptionsSuccessResponse);
        }

        /// <summary>
        /// Returns true if ExportSubscriptionsSuccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportSubscriptionsSuccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportSubscriptionsSuccessResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CsvFileUrl == input.CsvFileUrl ||
                    (this.CsvFileUrl != null &&
                    this.CsvFileUrl.Equals(input.CsvFileUrl))
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
                if (this.CsvFileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CsvFileUrl.GetHashCode();
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
