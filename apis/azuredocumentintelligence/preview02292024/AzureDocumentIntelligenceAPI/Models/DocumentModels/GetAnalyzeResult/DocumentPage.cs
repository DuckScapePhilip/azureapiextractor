using Newtonsoft.Json;

namespace AzureDocumentIntelligenceAPI.Models.DocumentModels.GetAnalyzeResult
{
    /// <summary>
    /// Content and layout elements extracted from a page from the input.
    /// </summary>
    public class DocumentPage
    {
        /// <summary>
        /// The general orientation of the content in clockwise direction, measured in degrees between (-180, 180].
        /// </summary>
        [JsonProperty("angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// Extracted barcodes from the page.
        /// </summary>
        [JsonProperty("barcodes")]
        public DocumentBarcode[]? Barcodes { get; set; }

        /// <summary>
        /// Extracted formulas from the page.
        /// </summary>
        [JsonProperty("formulas")]
        public DocumentFormula[]? Formulas { get; set; }

        /// <summary>
        /// The height of the image/PDF in pixels/inches, respectively.
        /// </summary>
        [JsonProperty("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Extracted lines from the page, potentially containing both textual and visual elements.
        /// </summary>
        [JsonProperty("lines")]
        public DocumentLine[]? Lines { get; set; }

        /// <summary>
        /// 1-based page double in the input document.
        /// </summary>
        [JsonProperty("pageNumber")]
        public int pageNumber { get; set; }

        /// <summary>
        /// Extracted selection marks from the page.
        /// </summary>
        [JsonProperty("selectionMarks")]
        public DocumentSelectionMark[]? SelectionMarks { get; set; }

        /// <summary>
        /// Location of the page in the reading order concatenated content.
        /// </summary>
        [JsonProperty("spans")]
        public DocumentSpan[]? Spans { get; set; }

        /// <summary>
        /// The unit used by the width, height, and polygon properties. For images, the unit is "pixel". For PDF, the unit is "inch".
        /// </summary>
        [JsonProperty("unit")]
        public LenghtUnit? Unit { get; set; }

        /// <summary>
        /// The width of the image/PDF in pixels/inches, respectively.
        /// </summary>
        [JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Extracted words from the page.
        /// </summary>
        [JsonProperty("words")]
        public DocumentWord[]? Words { get; set; }

    }
}
