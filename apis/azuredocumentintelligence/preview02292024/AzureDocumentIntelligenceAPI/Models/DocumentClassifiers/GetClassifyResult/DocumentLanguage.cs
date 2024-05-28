using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// An object representing the detected language for a given text span.
    /// </summary>
    public class DocumentLanguage
    {
        /// <summary>
        /// Confidence of correctly identifying the language.
        /// </summary>
        [JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Detected language. Value may an ISO 639-1 language code (ex. "en", "fr") or BCP 47 language tag (ex. "zh-Hans").
        /// </summary>
        [JsonProperty("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Location of the text elements in the concatenated content the language applies to.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
