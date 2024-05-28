using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models
{
    // Document classifier build operation details. This is returned by the Get Operation API.
    public class DocumentClassifierBuildOperationDetails
    {
        /// <summary>
        /// API version used to create this operation.
        /// </summary>
        [JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Date and time (UTC) when the operation was created.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Type of operation.
        /// </summary>
        [JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Date and time (UTC) when the status was last updated.
        /// </summary>
        [JsonProperty("lastUpdatedDateTime")]
        public DateTime LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Operation ID
        /// </summary>
        [JsonProperty("operationId")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Operation progress (0-100).
        /// </summary>
        [JsonProperty("percentCompleted")]
        public int PercentCompleted { get; set; }

        /// <summary>
        /// URL of the resource targeted by this operation.
        /// </summary>
        [JsonProperty("resourceLocation")]
        public string? ResourceLocation { get; set; }

        /// <summary>
        /// Operation result upon success.
        /// </summary>
        [JsonProperty("result")]
        public DocumentClassifierDetails? Result { get; set; }

        /// <summary>
        /// Operation status. notStarted, running, completed, or failed
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// List of key-value tag attributes associated with the document model.
        /// </summary>
        [JsonProperty("tags")]
        public Dictionary<string, string>? Tags { get; set; }
    }
}


