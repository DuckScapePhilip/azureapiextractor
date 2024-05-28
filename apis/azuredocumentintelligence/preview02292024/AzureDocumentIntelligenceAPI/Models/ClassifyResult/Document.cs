using Newtonsoft.Json;
using AzureDocumentIntelligenceAPI.Models.ClassifyResult;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// An object describing the location and semantic content of a document.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Bounding regions covering the document.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Confidence of correctly extracting the document.
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Document type.
        /// </summary>
        [JsonProperty("docType")]
        public string? DocType { get; set; }

        /// <summary>
        /// Dictionary of named field values.
        /// </summary>
        [JsonProperty("fields")]
        public Dictionary<string, DocumentField>? Fields { get; set; }

        /// <summary>
        /// Location of the document in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }

    }
}
