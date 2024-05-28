using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing a form field with distinct field label (key) and field value (may be empty).
    /// </summary>
    public class DocumentKeyValuePair
    {
        /// <summary>
        /// Confidence of correctly extracting the key-value pair.
        /// </summary>
        [JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Field label of the key-value pair.
        /// </summary>
        [JsonProperty("key")]
        public DocumentKeyValueElement? Key { get; set; }

        /// <summary>
        /// Field value of the key-value pair.
        /// </summary>
        [JsonProperty("value")]
        public DocumentKeyValueElement? Value { get; set; }
    }
}
