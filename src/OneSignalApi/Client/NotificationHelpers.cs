using System;
using System.Collections.Generic;
using System.Threading;
using OneSignalApi.Api;
using OneSignalApi.Model;

namespace OneSignalApi.Client
{
    /// <summary>
    /// Helpers for common OneSignal API usage patterns.
    /// </summary>
    public static class NotificationHelpers
    {
        public const int DefaultMaxRetries = 3;
        public const int DefaultBaseDelayMs = 1000;
        public const int MinBaseDelayMs = 1000;
        public const int MaxBaseDelayMs = 60000;

        /// <summary>
        /// Result of <see cref="CreateNotificationWithRetry"/>: the create
        /// response plus whether the server replayed a previously completed
        /// request (Idempotent-Replayed response header).
        /// </summary>
        public class CreateNotificationWithRetryResult
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CreateNotificationWithRetryResult"/> class.
            /// </summary>
            /// <param name="response">The successful create-notification response.</param>
            /// <param name="wasReplayed">Whether the server replayed a previously completed request.</param>
            public CreateNotificationWithRetryResult(CreateNotificationSuccessResponse response, bool wasReplayed)
            {
                Response = response;
                WasReplayed = wasReplayed;
            }

            /// <summary>
            /// The successful create-notification response.
            /// </summary>
            public CreateNotificationSuccessResponse Response { get; private set; }

            /// <summary>
            /// True when the server answered from a previously completed request,
            /// as signaled by the Idempotent-Replayed response header.
            /// </summary>
            public bool WasReplayed { get; private set; }
        }

        /// <summary>
        /// Create a notification with safe, idempotent retries.
        ///
        /// Ensures <c>notification.IdempotencyKey</c> is set (generating a
        /// UUIDv4 when absent) so the server can deduplicate, then calls
        /// <c>CreateNotification</c>. Transient failures (HTTP 429, HTTP 503,
        /// or transport-level errors) are retried with the SAME idempotency
        /// key, honoring the <c>Retry-After</c> response header when present
        /// and falling back to exponential backoff
        /// (<c>baseDelayMs * 2^attempt</c>) otherwise. Other errors are thrown
        /// immediately.
        /// </summary>
        /// <param name="api">The API instance to call through.</param>
        /// <param name="notification">An existing idempotency key is respected, never overwritten.</param>
        /// <param name="maxRetries">Retries after the initial attempt.</param>
        /// <param name="baseDelayMs">Backoff base in milliseconds when Retry-After is absent. Clamped to [1000, 60000].</param>
        /// <returns>The response plus the replay flag.</returns>
        /// <exception cref="ApiException">When the call fails with a non-retryable error or the retry budget is exhausted.</exception>
        public static CreateNotificationWithRetryResult CreateNotificationWithRetry(DefaultApi api, Notification notification, int maxRetries = DefaultMaxRetries, int baseDelayMs = DefaultBaseDelayMs)
        {
            if (string.IsNullOrEmpty(notification.IdempotencyKey))
            {
                notification.IdempotencyKey = Guid.NewGuid().ToString();
            }

            // Clamp the backoff base so a stray value can neither hammer the API
            // (too small) nor stall the caller for an unbounded stretch (too large).
            baseDelayMs = Math.Min(MaxBaseDelayMs, Math.Max(MinBaseDelayMs, baseDelayMs));

            var attempt = 0;
            while (true)
            {
                int delayMs;
                try
                {
                    var response = api.CreateNotificationWithHttpInfo(notification);
                    if ((int)response.StatusCode == 0)
                    {
                        // RestSharp reports transport-level failures (timeouts,
                        // connection resets) as a status-0 response instead of
                        // throwing, with the cause in ErrorText.
                        if (attempt >= maxRetries)
                        {
                            throw new ApiException(0, response.ErrorText ?? "Transport error calling CreateNotification");
                        }
                        delayMs = BackoffMs(attempt, baseDelayMs);
                    }
                    else
                    {
                        return new CreateNotificationWithRetryResult(response.Data, IsReplayed(response.Headers));
                    }
                }
                catch (ApiException e)
                {
                    var retryable = e.ErrorCode == 429 || e.ErrorCode == 503;
                    if (!retryable || attempt >= maxRetries)
                    {
                        throw;
                    }
                    delayMs = RetryDelayMs(e.Headers, attempt, baseDelayMs);
                }

                if (delayMs > 0)
                {
                    Thread.Sleep(delayMs);
                }
                attempt++;
            }
        }

        private static string HeaderValue(Multimap<string, string> headers, string name)
        {
            if (headers == null)
            {
                return null;
            }
            foreach (KeyValuePair<string, IList<string>> entry in headers)
            {
                if (string.Equals(entry.Key, name, StringComparison.OrdinalIgnoreCase)
                    && entry.Value != null && entry.Value.Count > 0)
                {
                    return entry.Value[0];
                }
            }
            return null;
        }

        private static bool IsReplayed(Multimap<string, string> headers)
        {
            var value = HeaderValue(headers, "Idempotent-Replayed");
            return value != null && string.Equals(value.Trim(), "true", StringComparison.OrdinalIgnoreCase);
        }

        private static int RetryDelayMs(Multimap<string, string> headers, int attempt, int baseDelayMs)
        {
            var retryAfter = HeaderValue(headers, "Retry-After");
            if (retryAfter != null && int.TryParse(retryAfter.Trim(), out var seconds) && seconds >= 0)
            {
                return seconds * 1000;
            }
            return BackoffMs(attempt, baseDelayMs);
        }

        private static int BackoffMs(int attempt, int baseDelayMs)
        {
            return baseDelayMs * (1 << attempt);
        }
    }

    /// <summary>
    /// Surfaces the idempotent-retry helper as a <see cref="DefaultApi"/>
    /// method so the call mirrors <c>CreateNotification</c>. Delegates to
    /// <see cref="NotificationHelpers"/> (single source of truth).
    /// </summary>
    public static class DefaultApiNotificationExtensions
    {
        /// <summary>
        /// Create a notification with safe, idempotent retries. See
        /// <see cref="NotificationHelpers.CreateNotificationWithRetry"/> for
        /// the full retry/idempotency contract.
        /// </summary>
        /// <param name="api">The API instance to call through.</param>
        /// <param name="notification">An existing idempotency key is respected, never overwritten.</param>
        /// <param name="maxRetries">Retries after the initial attempt.</param>
        /// <param name="baseDelayMs">Backoff base in milliseconds when Retry-After is absent.</param>
        /// <returns>The response plus the replay flag.</returns>
        public static NotificationHelpers.CreateNotificationWithRetryResult CreateNotificationWithRetry(this DefaultApi api, Notification notification, int maxRetries = NotificationHelpers.DefaultMaxRetries, int baseDelayMs = NotificationHelpers.DefaultBaseDelayMs)
        {
            return NotificationHelpers.CreateNotificationWithRetry(api, notification, maxRetries, baseDelayMs);
        }
    }
}
