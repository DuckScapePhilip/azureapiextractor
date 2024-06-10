using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.BuildClassifier
{
    /// <summary>
    /// Request body for building a document classifier. 
    /// </summary>
    public class BuildDocumentClassifierRequestBody
    {
        /// <summary>
        /// Base classifierId on top of which to train the classifier.
        /// </summary>
        [JsonProperty("baseClassifierId")]
        public string? BaseClassifierId { get; set; }

        /// <summary>
        /// Unique document classifier name.
        /// </summary>
        [JsonProperty("classifierId")]
        public string? ClassifierId { get; set; }

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
    }
}
