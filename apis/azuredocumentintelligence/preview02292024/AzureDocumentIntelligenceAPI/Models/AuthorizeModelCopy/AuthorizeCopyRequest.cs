using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.AuthorizeModelCopy
{
    /// <summary>
    /// Request body to authorize document model copy.
    /// </summary>
    public class AuthorizeCopyRequest
    {
        /// <summary>
        /// Document model description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique document model name.
        /// </summary>
        [JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// List of key-value tag attributes associated with the document model.
        /// </summary>
        [JsonProperty("tags")]
        public object? Tags { get; set; }
    }
}
