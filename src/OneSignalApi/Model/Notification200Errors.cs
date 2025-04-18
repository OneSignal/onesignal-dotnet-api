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
using System.Reflection;

namespace OneSignalApi.Model
{
    /// <summary>
    /// Notification200Errors
    /// </summary>
    [JsonConverter(typeof(Notification200ErrorsJsonConverter))]
    [DataContract(Name = "Notification200Errors")]
    public partial class Notification200Errors : AbstractOpenAPISchema, IEquatable<Notification200Errors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification200Errors" /> class
        /// with the <see cref="InvalidIdentifierError" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InvalidIdentifierError.</param>
        public Notification200Errors(InvalidIdentifierError actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification200Errors" /> class
        /// with the <see cref="List{String}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;string&gt;.</param>
        public Notification200Errors(List<string> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
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
                if (value.GetType() == typeof(InvalidIdentifierError))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(List<string>))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InvalidIdentifierError, List<string>");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InvalidIdentifierError`. If the actual instance is not `InvalidIdentifierError`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InvalidIdentifierError</returns>
        public InvalidIdentifierError GetInvalidIdentifierError()
        {
            return (InvalidIdentifierError)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;string&gt;`. If the actual instance is not `List&lt;string&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;string&gt;</returns>
        public List<string> GetListString()
        {
            return (List<string>)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification200Errors {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Notification200Errors.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Notification200Errors
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Notification200Errors</returns>
        public static Notification200Errors FromJson(string jsonString)
        {
            Notification200Errors newNotification200Errors = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotification200Errors;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InvalidIdentifierError).GetProperty("AdditionalProperties") == null)
                {
                    newNotification200Errors = new Notification200Errors(JsonConvert.DeserializeObject<InvalidIdentifierError>(jsonString, Notification200Errors.SerializerSettings));
                }
                else
                {
                    newNotification200Errors = new Notification200Errors(JsonConvert.DeserializeObject<InvalidIdentifierError>(jsonString, Notification200Errors.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InvalidIdentifierError");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InvalidIdentifierError: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<string>).GetProperty("AdditionalProperties") == null)
                {
                    newNotification200Errors = new Notification200Errors(JsonConvert.DeserializeObject<List<string>>(jsonString, Notification200Errors.SerializerSettings));
                }
                else
                {
                    newNotification200Errors = new Notification200Errors(JsonConvert.DeserializeObject<List<string>>(jsonString, Notification200Errors.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<string>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<string>: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newNotification200Errors;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Notification200Errors);
        }

        /// <summary>
        /// Returns true if Notification200Errors instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification200Errors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification200Errors input)
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
    /// Custom JSON converter for Notification200Errors
    /// </summary>
    public class Notification200ErrorsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Notification200Errors).GetMethod("ToJson").Invoke(value, null)));
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
            if(reader.TokenType == JsonToken.StartObject)
            {
                return Notification200Errors.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            else if(reader.TokenType == JsonToken.StartArray)
            {
                return Notification200Errors.FromJson(JArray.Load(reader).ToString(Formatting.None));
            }
            else if(reader.TokenType != JsonToken.Null)
            {
                return Notification200Errors.FromJson(reader.Value.ToString());
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
