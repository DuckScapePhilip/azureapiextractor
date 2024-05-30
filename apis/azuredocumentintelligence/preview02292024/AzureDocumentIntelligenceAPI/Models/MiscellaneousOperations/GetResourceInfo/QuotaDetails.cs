using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetResourceInfo
{
    /// <summary>
    /// Quota used, limit, and next reset date/time.
    /// </summary>
    public class QuotaDetails
    {
        /// <summary>
        /// Resource quota limit.
        /// </summary>
        [JsonProperty("quota")]
        public int Quota { get; set; }

        /// <summary>
        /// Date/time when the resource quota usage will be reset.
        /// </summary>
        [JsonProperty("quotaResetDateTime")]
        public string QuotaResetDateTime { get; set; } = "";

        /// <summary>
        /// Amount of the resource quota used.
        /// </summary>
        [JsonProperty("used")]
        public int Used { get; set; }
    }
}
