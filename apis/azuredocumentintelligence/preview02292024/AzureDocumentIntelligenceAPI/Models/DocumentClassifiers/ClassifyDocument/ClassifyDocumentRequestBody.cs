using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ClassifyDocument
{
    //Document classification parameters.
    public class ClassifyDocumentRequestBody
    {
        /// <summary>
        /// Base64 encoding of the document to classify. Either urlSource or base64Source must be specified.
        /// </summary>
        [JsonProperty("base64Source")]
        public string? Base64Source { get; set; }

        /// <summary>
        /// Document URL to classify. Either urlSource or base64Source must be specified.
        /// </summary>
        [JsonProperty("urlSource")]
        public string? UrlSource { get; set; }
    }
}
