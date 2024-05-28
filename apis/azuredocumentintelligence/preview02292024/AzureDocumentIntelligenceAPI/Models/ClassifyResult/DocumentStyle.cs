using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// An object representing observed text styles.
    /// </summary>
    public class DocumentStyle
    {
        /// <summary>
        /// Background color in #rrggbb hexadecimal format.
        /// </summary>
        [JsonProperty("backgroundColor")]
        public string? BlackgroundColor { get; set; }

        /// <summary>
        /// Foreground color in #rrggbb hexadecimal format.
        /// </summary>
        [JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Confidence of correctly identifying the style.
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Font style.
        /// </summary>
        [JsonProperty("fontStyle")]
        public FontStyle? FontStyle { get; set; }

        /// <summary>
        /// Font weight.
        /// </summary>
        [JsonProperty("fontWeight")]
        public FontWeight? FontWeight { get; set; }

        /// <summary>
        /// Is content handwritten?
        /// </summary>
        [JsonProperty("isHandwritten")]
        public bool IsHandwritten { get; set; }

        /// <summary>
        /// Visually most similar font from among the set of supported font families, with fallback fonts following CSS convention (ex. 'Arial, sans-serif').
        /// </summary>
        [JsonProperty("similarFontFamily")]
        public string? SimilarFontFamily { get; set; }

        /// <summary>
        /// Location of the text elements in the concatenated content the style applies to.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
