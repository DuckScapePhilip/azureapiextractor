using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// A paragraph object consisting with contiguous lines generally with common alignment and spacing.
    /// </summary>
    public class DocumentParagraph
    {
        /// <summary>
        /// Bounding regions covering the paragraph.
        /// </summary>
        [JsonProperty("boudingRegions")]
        public BoundingRegion[]? BouldingRegions { get; set; }

        /// <summary>
        /// Concatenated content of the paragraph in reading order.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Semantic role of the paragraph.
        /// </summary>
        [JsonProperty("role")]
        public ParagraphRole? Role { get; set; }

        /// <summary>
        /// Location of the paragraph in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
