using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// Contiguous region of the concatenated content property, specified as an offset and length.
    /// </summary>
    public class DocumentSpan
    {
        /// <summary>
        /// Number of characters in the content represented by the span.
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }

        /// <summary>
        /// Zero-based index of the content represented by the span.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}
