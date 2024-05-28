using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.AnalyzeDocument
{
    /// <summary>
    /// List of optional analysis features.
    /// </summary>
    public class DocumentAnalysisFeature
    {
        /// <summary>
        /// Enable the detection of barcodes in the document.
        /// </summary>
        [JsonProperty("barcodes")]
        public string? Barcodes { get; set; }

        /// <summary>
        /// Enable the detection of mathematical expressions in the document.
        /// </summary>
        [JsonProperty("formulas")]
        public string? Formulas { get; set; }

        /// <summary>
        /// Enable the detection of general key value pairs (form fields) in the document.
        /// </summary>
        [JsonProperty("keyValuePairs")]
        public string? KeyValuePairs { get; set; }

        /// <summary>
        /// Enable the detection of the text content language.
        /// </summary>
        [JsonProperty("languages")]
        public string? Languages { get; set; }

        /// <summary>
        /// Perform OCR at a higher resolution to handle documents with fine print.
        /// </summary>
        [JsonProperty("ocrHighResolution")]
        public string? OcrHighResolution { get; set; }

        /// <summary>
        /// Enable the extraction of additional fields via the queryFields query parameter.
        /// </summary>
        [JsonProperty("queryFields")]
        public string? QueryFields { get; set; }

        /// <summary>
        /// Enable the recognition of various font styles.
        /// </summary>
        [JsonProperty("styleFont")]
        public string? StyleFont { get; set; }
    }
}
