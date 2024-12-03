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
    /// Channel: Push Notifications Platform: Android Allowing setting a background image for the notification. This is a JSON object containing the following keys. See our Background Image documentation for image sizes. 
    /// </summary>
    [DataContract(Name = "BasicNotification_allOf_android_background_layout")]
    public partial class BasicNotificationAllOfAndroidBackgroundLayout : IEquatable<BasicNotificationAllOfAndroidBackgroundLayout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicNotificationAllOfAndroidBackgroundLayout" /> class.
        /// </summary>
        /// <param name="image">Asset file, android resource name, or URL to remote image..</param>
        /// <param name="headingsColor">Title text color ARGB Hex format. Example(Blue) \&quot;FF0000FF\&quot;..</param>
        /// <param name="contentsColor">Body text color ARGB Hex format. Example(Red) \&quot;FFFF0000\&quot;..</param>
        public BasicNotificationAllOfAndroidBackgroundLayout(string image = default(string), string headingsColor = default(string), string contentsColor = default(string))
        {
            this.Image = image;
            this.HeadingsColor = headingsColor;
            this.ContentsColor = contentsColor;
        }

        /// <summary>
        /// Asset file, android resource name, or URL to remote image.
        /// </summary>
        /// <value>Asset file, android resource name, or URL to remote image.</value>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Title text color ARGB Hex format. Example(Blue) \&quot;FF0000FF\&quot;.
        /// </summary>
        /// <value>Title text color ARGB Hex format. Example(Blue) \&quot;FF0000FF\&quot;.</value>
        [DataMember(Name = "headings_color", EmitDefaultValue = false)]
        public string HeadingsColor { get; set; }

        /// <summary>
        /// Body text color ARGB Hex format. Example(Red) \&quot;FFFF0000\&quot;.
        /// </summary>
        /// <value>Body text color ARGB Hex format. Example(Red) \&quot;FFFF0000\&quot;.</value>
        [DataMember(Name = "contents_color", EmitDefaultValue = false)]
        public string ContentsColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BasicNotificationAllOfAndroidBackgroundLayout {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  HeadingsColor: ").Append(HeadingsColor).Append("\n");
            sb.Append("  ContentsColor: ").Append(ContentsColor).Append("\n");
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
            return this.Equals(input as BasicNotificationAllOfAndroidBackgroundLayout);
        }

        /// <summary>
        /// Returns true if BasicNotificationAllOfAndroidBackgroundLayout instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicNotificationAllOfAndroidBackgroundLayout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicNotificationAllOfAndroidBackgroundLayout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.HeadingsColor == input.HeadingsColor ||
                    (this.HeadingsColor != null &&
                    this.HeadingsColor.Equals(input.HeadingsColor))
                ) && 
                (
                    this.ContentsColor == input.ContentsColor ||
                    (this.ContentsColor != null &&
                    this.ContentsColor.Equals(input.ContentsColor))
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
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.HeadingsColor != null)
                {
                    hashCode = (hashCode * 59) + this.HeadingsColor.GetHashCode();
                }
                if (this.ContentsColor != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsColor.GetHashCode();
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
