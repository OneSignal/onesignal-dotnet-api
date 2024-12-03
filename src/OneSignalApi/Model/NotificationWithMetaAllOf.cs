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
    /// NotificationWithMetaAllOf
    /// </summary>
    [DataContract(Name = "NotificationWithMeta_allOf")]
    public partial class NotificationWithMetaAllOf : IEquatable<NotificationWithMetaAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationWithMetaAllOf" /> class.
        /// </summary>
        /// <param name="remaining">Number of notifications that have not been sent out yet. This can mean either our system is still processing the notification or you have delayed options set..</param>
        /// <param name="successful">Number of notifications that were successfully delivered..</param>
        /// <param name="failed">Number of notifications that could not be delivered due to those devices being unsubscribed..</param>
        /// <param name="errored">Number of notifications that could not be delivered due to an error. You can find more information by viewing the notification in the dashboard..</param>
        /// <param name="converted">Number of users who have clicked / tapped on your notification..</param>
        /// <param name="queuedAt">Unix timestamp indicating when the notification was created..</param>
        /// <param name="sendAfter">Unix timestamp indicating when notification delivery should begin..</param>
        /// <param name="completedAt">Unix timestamp indicating when notification delivery completed. The delivery duration from start to finish can be calculated with completed_at - send_after..</param>
        /// <param name="platformDeliveryStats">platformDeliveryStats.</param>
        /// <param name="received">Confirmed Deliveries number of devices that received the push notification. Paid Feature Only. Free accounts will see 0..</param>
        /// <param name="throttleRatePerMinute">number of push notifications sent per minute. Paid Feature Only. If throttling is not enabled for the app or the notification, and for free accounts, null is returned. Refer to Throttling for more details..</param>
        public NotificationWithMetaAllOf(int remaining = default(int), int successful = default(int), int failed = default(int), int errored = default(int), int converted = default(int), long queuedAt = default(long), long? sendAfter = default(long?), long? completedAt = default(long?), PlatformDeliveryData platformDeliveryStats = default(PlatformDeliveryData), int? received = default(int?), int? throttleRatePerMinute = default(int?))
        {
            this.Remaining = remaining;
            this.Successful = successful;
            this.Failed = failed;
            this.Errored = errored;
            this.Converted = converted;
            this.QueuedAt = queuedAt;
            this.SendAfter = sendAfter;
            this.CompletedAt = completedAt;
            this.PlatformDeliveryStats = platformDeliveryStats;
            this.Received = received;
            this.ThrottleRatePerMinute = throttleRatePerMinute;
        }

        /// <summary>
        /// Number of notifications that have not been sent out yet. This can mean either our system is still processing the notification or you have delayed options set.
        /// </summary>
        /// <value>Number of notifications that have not been sent out yet. This can mean either our system is still processing the notification or you have delayed options set.</value>
        [DataMember(Name = "remaining", EmitDefaultValue = false)]
        public int Remaining { get; set; }

        /// <summary>
        /// Number of notifications that were successfully delivered.
        /// </summary>
        /// <value>Number of notifications that were successfully delivered.</value>
        [DataMember(Name = "successful", EmitDefaultValue = false)]
        public int Successful { get; set; }

        /// <summary>
        /// Number of notifications that could not be delivered due to those devices being unsubscribed.
        /// </summary>
        /// <value>Number of notifications that could not be delivered due to those devices being unsubscribed.</value>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        public int Failed { get; set; }

        /// <summary>
        /// Number of notifications that could not be delivered due to an error. You can find more information by viewing the notification in the dashboard.
        /// </summary>
        /// <value>Number of notifications that could not be delivered due to an error. You can find more information by viewing the notification in the dashboard.</value>
        [DataMember(Name = "errored", EmitDefaultValue = false)]
        public int Errored { get; set; }

        /// <summary>
        /// Number of users who have clicked / tapped on your notification.
        /// </summary>
        /// <value>Number of users who have clicked / tapped on your notification.</value>
        [DataMember(Name = "converted", EmitDefaultValue = false)]
        public int Converted { get; set; }

        /// <summary>
        /// Unix timestamp indicating when the notification was created.
        /// </summary>
        /// <value>Unix timestamp indicating when the notification was created.</value>
        [DataMember(Name = "queued_at", EmitDefaultValue = false)]
        public long QueuedAt { get; set; }

        /// <summary>
        /// Unix timestamp indicating when notification delivery should begin.
        /// </summary>
        /// <value>Unix timestamp indicating when notification delivery should begin.</value>
        [DataMember(Name = "send_after", EmitDefaultValue = true)]
        public long? SendAfter { get; set; }

        /// <summary>
        /// Unix timestamp indicating when notification delivery completed. The delivery duration from start to finish can be calculated with completed_at - send_after.
        /// </summary>
        /// <value>Unix timestamp indicating when notification delivery completed. The delivery duration from start to finish can be calculated with completed_at - send_after.</value>
        [DataMember(Name = "completed_at", EmitDefaultValue = true)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets PlatformDeliveryStats
        /// </summary>
        [DataMember(Name = "platform_delivery_stats", EmitDefaultValue = false)]
        public PlatformDeliveryData PlatformDeliveryStats { get; set; }

        /// <summary>
        /// Confirmed Deliveries number of devices that received the push notification. Paid Feature Only. Free accounts will see 0.
        /// </summary>
        /// <value>Confirmed Deliveries number of devices that received the push notification. Paid Feature Only. Free accounts will see 0.</value>
        [DataMember(Name = "received", EmitDefaultValue = true)]
        public int? Received { get; set; }

        /// <summary>
        /// number of push notifications sent per minute. Paid Feature Only. If throttling is not enabled for the app or the notification, and for free accounts, null is returned. Refer to Throttling for more details.
        /// </summary>
        /// <value>number of push notifications sent per minute. Paid Feature Only. If throttling is not enabled for the app or the notification, and for free accounts, null is returned. Refer to Throttling for more details.</value>
        [DataMember(Name = "throttle_rate_per_minute", EmitDefaultValue = true)]
        public int? ThrottleRatePerMinute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationWithMetaAllOf {\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Errored: ").Append(Errored).Append("\n");
            sb.Append("  Converted: ").Append(Converted).Append("\n");
            sb.Append("  QueuedAt: ").Append(QueuedAt).Append("\n");
            sb.Append("  SendAfter: ").Append(SendAfter).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  PlatformDeliveryStats: ").Append(PlatformDeliveryStats).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  ThrottleRatePerMinute: ").Append(ThrottleRatePerMinute).Append("\n");
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
            return this.Equals(input as NotificationWithMetaAllOf);
        }

        /// <summary>
        /// Returns true if NotificationWithMetaAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationWithMetaAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationWithMetaAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Remaining == input.Remaining ||
                    this.Remaining.Equals(input.Remaining)
                ) && 
                (
                    this.Successful == input.Successful ||
                    this.Successful.Equals(input.Successful)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
                ) && 
                (
                    this.Errored == input.Errored ||
                    this.Errored.Equals(input.Errored)
                ) && 
                (
                    this.Converted == input.Converted ||
                    this.Converted.Equals(input.Converted)
                ) && 
                (
                    this.QueuedAt == input.QueuedAt ||
                    this.QueuedAt.Equals(input.QueuedAt)
                ) && 
                (
                    this.SendAfter == input.SendAfter ||
                    (this.SendAfter != null &&
                    this.SendAfter.Equals(input.SendAfter))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.PlatformDeliveryStats == input.PlatformDeliveryStats ||
                    (this.PlatformDeliveryStats != null &&
                    this.PlatformDeliveryStats.Equals(input.PlatformDeliveryStats))
                ) && 
                (
                    this.Received == input.Received ||
                    (this.Received != null &&
                    this.Received.Equals(input.Received))
                ) && 
                (
                    this.ThrottleRatePerMinute == input.ThrottleRatePerMinute ||
                    (this.ThrottleRatePerMinute != null &&
                    this.ThrottleRatePerMinute.Equals(input.ThrottleRatePerMinute))
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
                hashCode = (hashCode * 59) + this.Remaining.GetHashCode();
                hashCode = (hashCode * 59) + this.Successful.GetHashCode();
                hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                hashCode = (hashCode * 59) + this.Errored.GetHashCode();
                hashCode = (hashCode * 59) + this.Converted.GetHashCode();
                hashCode = (hashCode * 59) + this.QueuedAt.GetHashCode();
                if (this.SendAfter != null)
                {
                    hashCode = (hashCode * 59) + this.SendAfter.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.PlatformDeliveryStats != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformDeliveryStats.GetHashCode();
                }
                if (this.Received != null)
                {
                    hashCode = (hashCode * 59) + this.Received.GetHashCode();
                }
                if (this.ThrottleRatePerMinute != null)
                {
                    hashCode = (hashCode * 59) + this.ThrottleRatePerMinute.GetHashCode();
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
