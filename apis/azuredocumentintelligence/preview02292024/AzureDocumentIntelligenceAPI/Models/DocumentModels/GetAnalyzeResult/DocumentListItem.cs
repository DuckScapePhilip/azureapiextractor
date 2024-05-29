using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// An object representing a list item in the document.
    /// </summary>
    public class DocumentListItem
    {
        /// <summary>
        /// Bounding regions covering the list item.
        /// </summary>
        [JsonProperty("boudingRegions")]
        public BoundingRegion[]? BoudingRegions { get; set; }

        /// <summary>
        /// Content of the list item.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Child elements of the list item.
        /// </summary>
        [JsonProperty("elements")]
        public string[]? Elements { get; set; }

        /// <summary>
        /// Level of the list item (1-indexed).
        /// </summary>
        [JsonProperty("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Location of the list item in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
