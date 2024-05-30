using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentClassifiers.GetClassifyResult
{
    /// <summary>
    /// A barcode object.
    /// </summary>
    public class DocumentBarcode
    {
        /// <summary>
        /// Confidence of correctly extracting the barcode.
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Barcode kind.
        /// </summary>
        [JsonProperty("kind")]
        public DocumentBarcodeKind? Kind { get; set; }

        /// <summary>
        /// Bounding polygon of the barcode, with coordinates specified relative to the top-left of the page. The doubles represent the x, y values of the polygon vertices, clockwise from the left (-180 degrees inclusive) relative to the element orientation.
        /// </summary>
        [JsonProperty("polygon")]
        public double[]? Polygon { get; set; }

        /// <summary>
        /// Location of the barcode in the reading order concatenated content.
        /// </summary>
        [JsonProperty("span")]
        public DocumentSpan? Span { get; set; }

        /// <summary>
        /// Barcode value.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
