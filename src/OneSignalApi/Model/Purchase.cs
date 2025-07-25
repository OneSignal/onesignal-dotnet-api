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
    /// Purchase
    /// </summary>
    [DataContract(Name = "Purchase")]
    public partial class Purchase : IEquatable<Purchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Purchase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        /// <param name="sku">The unique identifier of the purchased item. (required).</param>
        /// <param name="amount">The amount, in USD, spent purchasing the item. (required).</param>
        /// <param name="iso">The 3-letter ISO 4217 currency code. Required for correct storage and conversion of amount. (required).</param>
        /// <param name="count">count.</param>
        public Purchase(string sku = default(string), string amount = default(string), string iso = default(string), int count = default(int))
        {
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new ArgumentNullException("sku is a required property for Purchase and cannot be null");
            }
            this.Sku = sku;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for Purchase and cannot be null");
            }
            this.Amount = amount;
            // to ensure "iso" is required (not null)
            if (iso == null)
            {
                throw new ArgumentNullException("iso is a required property for Purchase and cannot be null");
            }
            this.Iso = iso;
            this.Count = count;
        }

        /// <summary>
        /// The unique identifier of the purchased item.
        /// </summary>
        /// <value>The unique identifier of the purchased item.</value>
        [DataMember(Name = "sku", IsRequired = true, EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// The amount, in USD, spent purchasing the item.
        /// </summary>
        /// <value>The amount, in USD, spent purchasing the item.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The 3-letter ISO 4217 currency code. Required for correct storage and conversion of amount.
        /// </summary>
        /// <value>The 3-letter ISO 4217 currency code. Required for correct storage and conversion of amount.</value>
        [DataMember(Name = "iso", IsRequired = true, EmitDefaultValue = false)]
        public string Iso { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Purchase {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Iso: ").Append(Iso).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as Purchase);
        }

        /// <summary>
        /// Returns true if Purchase instances are equal
        /// </summary>
        /// <param name="input">Instance of Purchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Purchase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Iso == input.Iso ||
                    (this.Iso != null &&
                    this.Iso.Equals(input.Iso))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Iso != null)
                {
                    hashCode = (hashCode * 59) + this.Iso.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
