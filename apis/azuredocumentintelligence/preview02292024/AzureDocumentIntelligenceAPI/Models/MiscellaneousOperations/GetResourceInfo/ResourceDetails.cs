using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.MiscellaneousOperations.GetResourceInfo
{
    /// <summary>
    /// General information regarding the current resource.
    /// </summary>
    public class ResourceDetails
    {
        [JsonProperty("customDocumentModels")]
        public CustomDocumentModelsDetails? CustomDocumentModels { get; set; }


        [JsonProperty("customNeuralDocumentModelBuilds")]
        public QuotaDetails? CustomNeuralDocumentModelBuilds { get; set; }
    }
}
