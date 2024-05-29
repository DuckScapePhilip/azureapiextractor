using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// A word object consisting of a contiguous sequence of characters. For non-space delimited languages, such as Chinese, Japanese, and Korean, each character is represented as its own word.
    /// </summary>
    public class DocumentWord
    {
        /// <summary>
        /// Confidence of correctly extracting the word.
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Text content of the word.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Bounding polygon of the word, with coordinates specified relative to the top-left of the page. The numbers represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }

        /// <summary>
        /// Location of the word in the reading order concatenated content.
        /// </summary>
        [JsonProperty("span")]
        public DocumentSpan? Span { get; set; }
    }
}
