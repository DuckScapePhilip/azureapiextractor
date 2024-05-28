using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.Errors
{
    // Error response object.
    public class ErrorResponse
    {
        /// <summary>
        /// Error info.
        /// </summary>
        [JsonProperty("error")]
        public InnerError? Error { get; set; }
    }
}
