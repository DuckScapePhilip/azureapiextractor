using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.ClassifyResult
{
    /// <summary>
    /// A formula object.
    /// </summary>
    public class DocumentFormula
    {
        /// <summary>
        /// Confidence of correctly extracting the formula.
        /// </summary>
        [JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Formula kind.
        /// </summary>
        [JsonProperty("kind")]
        public DocumentFormulaKind? Kind { get; set; }

        /// <summary>
        /// Bounding polygon of the formula, with coordinates specified relative to the top-left of the page. The doubles represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }

        /// <summary>
        /// Location of the formula in the reading order concatenated content.
        /// </summary>
        [JsonProperty("span")]
        public DocumentSpan? Span { get; set; }

        /// <summary>
        /// LaTex expression describing the formula.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
