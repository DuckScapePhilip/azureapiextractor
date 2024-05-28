using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// A content line object consisting of an adjacent sequence of content elements, such as words and selection marks.
    /// </summary>
    public class DocumentLine
    {
        /// <summary>
        /// Concatenated content of the contained elements in reading order.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Bounding polygon of the line, with coordinates specified relative to the top-left of the page. The doubles represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }

        /// <summary>
        /// Location of the line in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }
    }
}
