using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing a list in the document.
    /// </summary>
    public class DocumentList
    {
        /// <summary>
        /// Items in the list.
        /// </summary>
        [JsonProperty("items")]
        public DocumentListItem[]? Items { get; set; }

        /// <summary>
        /// Location of the list in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
