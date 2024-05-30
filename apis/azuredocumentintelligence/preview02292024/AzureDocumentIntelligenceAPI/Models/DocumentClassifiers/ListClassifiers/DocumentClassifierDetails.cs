using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ListClassifiers
{
    /// <summary>
    /// Document classifier info.
    /// </summary>
    public class DocumentClassifierDetails
    {
        /// <summary>
        /// API version used to create this document classifier.
        /// </summary>
        [JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Base classifierId on top of which the classifier was trained.
        /// </summary>
        [JsonProperty("baseClassifierId")]
        public string? BaseClassifierId { get; set; }

        /// <summary>
        /// Unique document classifier name.
        /// </summary>
        [JsonProperty("classifierId")]
        public string? ClassifierId { get; set; }

        /// <summary>
        /// Date and time (UTC) when the document classifier was created.
        /// </summary>
        [JsonProperty("createdDateTime")]
        public string? CreatedDateTime { get; set; }

        /// <summary>
        /// Document classifier description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of document types to classify against.
        /// </summary>
        [JsonProperty("docTypes")]
        public List<ClassifierDocumentTypeDetails>? DocTypes { get; set; }

        /// <summary>
        /// Date and time (UTC) when the document classifier will expire.
        /// </summary>
        [JsonProperty("expirationDateTime")]
        public string? ExpirationDateTime { get; set; }

        /// <summary>
        /// List of warnings encountered while building the classifier.
        /// </summary>
        [JsonProperty("warnings")]
        public Warning[]? Warnings { get; set; }
    }
}
