using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.AnalyzeDocument
{
    /// <summary>
    /// Document analysis parameters.
    /// </summary>
    public class AnalyzeDocumentRequest
    {
        /// <summary>
        /// Base64 encoding of the document to analyze. Either urlSource or base64Source must be specified.
        /// </summary>
        [JsonProperty("base64Source")]
        public string? Base64Source { get; set; }

        /// <summary>
        /// Document URL to analyze. Either urlSource or base64Source must be specified.
        /// </summary>
        [JsonProperty("urlSource")]
        public string? UrlSource { get; set; }
    }
}
