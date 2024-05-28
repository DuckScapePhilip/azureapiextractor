using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// Format of the content in analyzed result.
    /// </summary>
    public class ContentFormat
    {
        /// <summary>
        /// Markdown representation of the document content with section headings, tables, etc.
        /// </summary>
        [JsonProperty("markDown")]
        public string? MarkDown { get; set; }

        /// <summary>
        /// Plain text representation of the document content without any formatting.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}
