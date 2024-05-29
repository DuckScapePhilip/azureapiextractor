using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ListClassifiers
{
    /// <summary>
    /// The error object.
    /// </summary>
    public class Warning
    {
        /// <summary>
        /// One of a server-defined set of warning codes.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable representation of the warning.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The target of the error.
        /// </summary>
        [JsonProperty("target")]
        public string? Target { get; set; }
    }
}
