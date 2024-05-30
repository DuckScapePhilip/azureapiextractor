using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetResourceInfo
{
    /// <summary>
    /// Details regarding custom document models.
    /// </summary>
    public class CustomDocumentModelsDetails
    {
        /// <summary>
        /// Number of custom document models in the current resource.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Maximum number of custom document models supported in the current resource.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
