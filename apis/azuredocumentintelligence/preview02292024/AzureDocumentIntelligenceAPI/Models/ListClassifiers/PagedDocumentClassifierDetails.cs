using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ListClassifiers
{
    /// <summary>
    /// Paged collection of DocumentClassifierDetails items
    /// </summary>
    public class PagedDocumentClassifierDetails
    {
        /// <summary>
        /// The link to the next page of items
        /// </summary>
        [JsonProperty("nexLink")]
        public string? NexLink { get; set; }

        /// <summary>
        /// The DocumentClassifierDetails items on this page
        /// </summary>
        [JsonProperty("value")]
        public DocumentClassifierDetails[]? Value { get; set; }
    }
}
