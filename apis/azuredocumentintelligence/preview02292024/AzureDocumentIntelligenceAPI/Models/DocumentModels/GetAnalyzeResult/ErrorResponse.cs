using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Error response object.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Error info.
        /// </summary>
        [JsonProperty("error")]
        public Error? Error { get; set; }
    }
}
