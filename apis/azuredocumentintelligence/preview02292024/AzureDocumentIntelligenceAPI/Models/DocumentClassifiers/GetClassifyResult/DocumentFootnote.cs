using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// A footnote object describing a table or figure.
    /// </summary>
    public class DocumentFootnote
    {
        /// <summary>
        /// Bounding regions covering the footnote.
        /// </summary>
        [JsonProperty("boundingRegions")]
        public BoundingRegion[]? BoundingRegions { get; set; }

        /// <summary>
        /// Content of the footnote.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Child elements of the footnote.
        /// </summary>
        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        /// <summary>
        /// Location of the footnote in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
