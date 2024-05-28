using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyDocument
{
    // Document splitting mode.
    public class SplitMode
    {
        /// <summary>
        /// Automatically split file into documents.
        /// </summary>
        [JsonProperty("auto")]
        public string? Auto { get; set; }

        /// <summary>
        /// Treat the entire file as a single document.
        /// </summary>
        [JsonProperty("none")]
        public string? None { get; set; }

        /// <summary>
        /// Treat each page in the file as a separate document.
        /// </summary>
        [JsonProperty("perPage")]
        public string? PerPage { get; set; }
    }
}
