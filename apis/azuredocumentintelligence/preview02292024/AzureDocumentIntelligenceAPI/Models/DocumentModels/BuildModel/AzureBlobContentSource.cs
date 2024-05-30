using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.BuildModel
{ 
    /// <summary>
    /// Azure Blob Storage content.
    /// </summary>
    public class AzureBlobContentSource
    {
        /// <summary>
        /// Azure Blob Storage container URL.
        /// </summary>
        [JsonProperty("containerUrl")]
        public string? ContainerUrl { get; set; } = "";

        /// <summary>
        /// Blob name prefix.
        /// </summary>
        [JsonProperty("prefix")]
        public string? Prefix { get; set; } = "";
    }
}
