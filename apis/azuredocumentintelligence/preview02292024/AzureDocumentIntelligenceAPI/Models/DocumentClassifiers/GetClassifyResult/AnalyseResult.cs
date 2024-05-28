using AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.ClassifyDocument;
using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// Document analysis result.
    /// </summary>
    public class AnalyzeResult
    {
        /// <summary>
        /// API version used to produce this result.
        /// </summary>
        [JsonProperty("apiversion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Concatenate string representation of all textual and visual elements in reading order.
        /// </summary>
        [JsonProperty("content")]
        public ContentFormat? Content { get; set; }

        /// <summary>
        /// Format of the analyze result top-level content.
        /// </summary>
        [JsonProperty("contentFormat")]
        public string? ContentFormat { get; set; }

        /// <summary>
        /// Extracted documents.
        /// </summary>
        [JsonProperty("documents")]
        public Document[]? Documents { get; set; }

        /// <summary>
        /// Extracted figures.
        /// </summary>
        [JsonProperty("figures")]
        public DocumentFigure[]? Figures { get; set; }

        /// <summary>
        /// Extracted key-value pairs.
        /// </summary>
        [JsonProperty("keyValuePairs")]
        public DocumentKeyValuePair[]? KeyValuePairs { get; set; }

        /// <summary>
        /// Detected languages.
        /// </summary>
        [JsonProperty("languages")]
        public DocumentLanguage[]? Languages { get; set; }

        /// <summary>
        /// Extracted lists.
        /// </summary>
        [JsonProperty("lists")]
        public DocumentList[]? Lists { get; set; }

        /// <summary>
        /// Document model ID used to produce this result.
        /// </summary>
        [JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Analyzed pages.
        /// </summary>
        [JsonProperty("pages")]
        public DocumentPage[]? Pages { get; set; }

        /// <summary>
        /// Extracted paragraphs.
        /// </summary>
        [JsonProperty("paragraphs")]
        public DocumentParagraph[]? Paragraphs { get; set; }

        /// <summary>
        /// Extracted sections.
        /// </summary>
        [JsonProperty("sections")]
        public DocumentSection[]? Sections { get; set; }

        /// <summary>
        /// Method used to compute string offset and length.
        /// </summary>
        [JsonProperty("stringIndexType")]
        public StringIndexType? StringIndexType { get; set; }

        /// <summary>
        /// Extracted font styles.
        /// </summary>
        [JsonProperty("styles")]
        public DocumentStyle[]? Styles { get; set; }

        /// <summary>
        /// Extracted tables.
        /// </summary>
        [JsonProperty("tables")]
        public DocumentTable[]? Tables { get; set; }

    }
}
