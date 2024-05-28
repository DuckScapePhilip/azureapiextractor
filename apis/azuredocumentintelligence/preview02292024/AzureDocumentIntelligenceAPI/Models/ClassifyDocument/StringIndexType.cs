using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyDocument
{
    // Method used to compute string offset and length.
    public class StringIndexType
    {
        /// <summary>
        /// User-perceived display character, or grapheme cluster, as defined by Unicode 8.0.0.
        /// </summary>
        [JsonProperty("textElements")]
        public string? TextElements { get; set; }

        /// <summary>
        /// Character unit represented by a single unicode code point. Used by Python 3.
        /// </summary>
        [JsonProperty("unicodeCodePoints")]
        public string? UnicodeCodePoints { get; set; }

        /// <summary>
        /// Character unit represented by a 16-bit Unicode code unit. Used by JavaScript, Java, and .NET.
        /// </summary>
        [JsonProperty("unicodeCodeUnits")]
        public string? UnicodeCodeUnits { get; set; }

    }
}
