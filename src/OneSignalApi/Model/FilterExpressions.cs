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
    /// FilterExpressions
    /// </summary>
    [JsonConverter(typeof(FilterExpressionsJsonConverter))]
    [DataContract(Name = "FilterExpressions")]
    public partial class FilterExpressions : AbstractOpenAPISchema, IEquatable<FilterExpressions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterExpressions" /> class
        /// with the <see cref="Filter" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Filter.</param>
        public FilterExpressions(Filter actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterExpressions" /> class
        /// with the <see cref="Operator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Operator.</param>
        public FilterExpressions(Operator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Filter))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Operator))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Filter, Operator");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Filter`. If the actual instance is not `Filter`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Filter</returns>
        public Filter GetFilter()
        {
            return (Filter)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Operator`. If the actual instance is not `Operator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Operator</returns>
        public Operator GetOperator()
        {
            return (Operator)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterExpressions {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, FilterExpressions.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of FilterExpressions
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of FilterExpressions</returns>
        public static FilterExpressions FromJson(string jsonString)
        {
            FilterExpressions newFilterExpressions = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newFilterExpressions;
            }

            try
            {
                newFilterExpressions = new FilterExpressions(JsonConvert.DeserializeObject<Filter>(jsonString, FilterExpressions.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newFilterExpressions;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Filter: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newFilterExpressions = new FilterExpressions(JsonConvert.DeserializeObject<Operator>(jsonString, FilterExpressions.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newFilterExpressions;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Operator: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilterExpressions);
        }

        /// <summary>
        /// Returns true if FilterExpressions instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterExpressions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterExpressions input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for FilterExpressions
    /// </summary>
    public class FilterExpressionsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(FilterExpressions).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return FilterExpressions.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
