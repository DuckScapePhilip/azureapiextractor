using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// A selection mark object representing check boxes, radio buttons, and other elements indicating a selection.
    /// </summary>
    public class DocumentSelectionMark
    {
        /// <summary>
        /// Confidence of correctly extracting the selection mark.
        /// </summary>
        [JsonProperty("confidente")]
        public double? Confidente { get; set; }

        /// <summary>
        /// Bounding polygon of the selection mark, with coordinates specified relative to the top-left of the page. The numbers represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }

        /// <summary>
        /// Location of the selection mark in the reading order concatenated content.
        /// </summary>
        [JsonProperty("span")]
        public DocumentSpan? Span { get; set; }

        /// <summary>
        /// State of the selection mark.
        /// </summary>
        [JsonProperty("state")]
        public DocumentSelectionMarkState? State { get; set; }
    }
}
