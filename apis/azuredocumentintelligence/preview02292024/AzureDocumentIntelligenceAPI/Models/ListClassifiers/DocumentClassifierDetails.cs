using AzureDocumentIntelligenceAPI.Models.BuildClassifier;
using AzureDocumentIntelligenceAPI.Models.Errors;
using Newtonsoft.Json;
using AzureDocumentIntelligenceAPI.Models.BuildClassifier;

namespace AzureDocumentIntelligenceAPI.Models.ListClassifiers
{
    /// <summary>
    /// Document classifier info.
    /// </summary>
    public class DocumentClassifierDetails
    {
        
        [JsonProperty("apiVersion")]
        public string? ApiVersion { get; set;}

        [JsonProperty("baseClassifierId")]
        public string? BaseClassifierId { get; set;}

        [JsonProperty("classifierId")]
        public string? ClassifierId { get; set;}

        [JsonProperty("createdDateTime")]
        public string? CreatedDateTime { get; set;}

        [JsonProperty("description")]
        public string? Description { get; set;}

        [JsonProperty("docTypes")]
        public List<ClassifierDocumentTypeDetails>? DocTypes { get; set;}

        [JsonProperty("expirationDateTime")]
        public string? ExpirationDateTime { get; set;}

        [JsonProperty("warnings")]
        public Warning[]? Warnings { get; set;}

    }
}
