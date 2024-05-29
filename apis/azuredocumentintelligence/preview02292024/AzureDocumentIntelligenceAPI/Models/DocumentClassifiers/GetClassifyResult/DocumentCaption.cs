using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// A caption object describing a table or figure.
    /// </summary>
    public class DocumentCaption
    {
        /// <summary>
        /// Bounding regions covering the caption.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Content of the caption.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Child elements of the caption.
        /// </summary>
        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        /// <summary>
        /// Location of the caption in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
