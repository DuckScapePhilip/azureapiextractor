using AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.BuildClassifier;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifier
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
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Document classifier description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of document types to classify against.
        /// </summary>
        [JsonProperty("docTypes")]
        public Dictionary<string, ClassifierDocumentTypeDetails>? DocTypes { get; set; }

        /// <summary>
        /// Date and time (UTC) when the document classifier will expire.
        /// </summary>
        [JsonProperty("expirationDateTime")]
        public DateTime ExpirationDateTime { get; set; } = DateTime.Now.AddYears(1);
    }
}
