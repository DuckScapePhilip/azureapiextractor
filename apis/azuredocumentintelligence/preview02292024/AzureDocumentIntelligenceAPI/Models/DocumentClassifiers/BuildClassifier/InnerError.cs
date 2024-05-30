using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.BuildClassifier
{
    /// <summary>
    /// An object containing more specific information about the error.
    /// </summary>
    public class InnerError
    {
        /// <summary>
        /// One of a server-defined set of error codes.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Inner error.
        /// </summary>
        [JsonProperty("innererror")]
        public InnerError? InnerErrorDetail { get; set; }

        /// <summary>
        /// A human-readable representation of the error.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
